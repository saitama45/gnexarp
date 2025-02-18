Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class Login
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents lblPrompt As System.Web.UI.WebControls.Label
    'Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    'Protected WithEvents lblSystem As System.Web.UI.WebControls.Label
    Protected WithEvents lblModule As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents label3 As System.Web.UI.WebControls.Label
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    Protected WithEvents lblSystem As System.Web.UI.WebControls.Label
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Dim objNewCookie As HttpCookie
    Dim objConnection As SqlConnection


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strConn As String = ConfigurationSettings.AppSettings("appConn")
        objConnection = New SqlConnection(strConn)

        If Not Page.IsPostBack Then

            txtUserName.Text = ""
            txtPassword.Text = ""
            SetFocus(txtUserName)

            'get setup info from database            
            Dim strSP As String = "sys_setup_get"
            Dim objCommand As New SqlCommand(strSP, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objConnection.Open()
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            ' get the status
            Session("Co_Name") = Trim(objReader("co_name"))
            Session("Co_Add_Postal") = Trim(objReader("co_add_postal"))
            Session("Co_Add_Email") = Trim(objReader("co_add_email"))
            Session("System_Name") = Trim(objReader("system_name"))

            objReader.Close()
            objConnection.Close()

            'put session variables to textboxes
            'lblCompany.Text = Session("co_name")
            'lblSystem.Text = Session("system_name")
            'lblCompany.Text = Session("Co_Name")

            '**end of get system setup values

            'request the cookie from the user's pc
            Dim objCookie As HttpCookie = Request.Cookies(ConfigurationSettings.AppSettings("appName"))

            ' load values to textboxes if cookie exist 
            If Not IsNothing(objCookie) Then
                'txtUserName.Text = objCookie.Values("username")
                'lblPrompt.Text = "Welcome back " & objCookie.Values("Fullname") & "! Your last visit was on " & objCookie.Values("LastVisit")
            End If

        End If

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSubmit.Click

        Dim strSP As String = "sys_login"
        Dim objCommand As New SqlCommand(strSP, objConnection)

        'objConnection = New SqlConnection(strConn)

        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@UID", txtUserName.Text)
        objCommand.Parameters.Add("@Password", "INV" & Trim(txtUserName.Text) & Trim(txtPassword.Text))
        'objCommand.Parameters.Add("@Password", Trim(ConfigurationSettings.AppSettings("appName")) & Trim(txtUserName.Text) & Trim(txtPassword.Text))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        objReader.Read()

        'get the status
        lblPrompt.Text = objReader("status")
        'get the group
        Session("Group") = Trim(objReader("sys_group"))
        'get the group id
        Session("Sys_Group_ID") = Trim(objReader("sys_group_id"))
		'get the firstname
        Session("Firstname") = objReader("firstname")
        'get the fullname
        Session("Fullname") = objReader("fullname")
        'get default screen 
        Session("default_screen") = objReader("default_screen")
        'get company code
        Session("company_code") = objReader("company")
        'get company name
        Session("company_name") = objReader("company_name")

        If lblPrompt.Text = "ok" Then
            'login is ok
            'add this new variables to a cookie
            objNewCookie = New HttpCookie(ConfigurationSettings.AppSettings("appName"))

            objNewCookie.Values.Add("UserName", txtUserName.Text)
            objNewCookie.Values.Add("FullName", Session("Firstname"))
            objNewCookie.Values.Add("LastVisit", DateTime.UtcNow.AddHours(8))
            objNewCookie.Values.Add("CompanyName", Session("company_name"))

            ' expire cookie after 6 months
            objNewCookie.Expires = DateTime.UtcNow.AddMonths(6)

            'add to response
            Response.Cookies.Add(objNewCookie)

            If Session("username") <> txtUserName.Text Then
                'create the session 
                Session("username") = txtUserName.Text

                'add a count to current visitors
                Application.Lock()
                Application("CurrentVisitors") += 1
                Application.UnLock()
            End If

            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        "Login", _
                                        "System", _
                                        Session("username"), _
                                        "0", _
                                        "0")

            'authenticate user
            FormsAuthentication.SetAuthCookie(txtUserName.Text, False)

            'go to the main page
            Response.Redirect(Session("default_screen"))
        End If

        objReader.Close()
        objConnection.Close()

    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub
End Class
