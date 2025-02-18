
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState


Public Class sys_User_list
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtMorePage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPageNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRecordsPerPage As System.Web.UI.WebControls.TextBox    
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label                
    Protected WithEvents BtnFirst As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrevious As System.Web.UI.WebControls.Button
    Protected WithEvents BtnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnLast As System.Web.UI.WebControls.Button
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox        
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefault_Screen As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents ddlGroup As System.Web.UI.WebControls.DropDownList        
    Protected WithEvents txtUID As System.Web.UI.WebControls.TextBox
    Protected WithEvents calAccess_Start As eWorld.UI.CalendarPopup
    Protected WithEvents cbAccess_Start As System.Web.UI.WebControls.CheckBox
    Protected WithEvents cbAccess_End As System.Web.UI.WebControls.CheckBox
    Protected WithEvents calAccess_End As eWorld.UI.CalendarPopup
    Protected WithEvents txtFullname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox    
    Protected WithEvents cbResetPassword As System.Web.UI.WebControls.CheckBox    
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
    Protected WithEvents lblValidate As System.Web.UI.WebControls.Label
    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents lblUserTab As System.Web.UI.WebControls.Label
    Protected WithEvents lblCompanyName As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblDashboard As System.Web.UI.WebControls.Label
    Protected WithEvents panelDashboard As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDashboard As System.Web.UI.WebControls.Table
    Protected WithEvents lblAR As System.Web.UI.WebControls.Label
    Protected WithEvents panelAR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblAR As System.Web.UI.WebControls.Table
    Protected WithEvents lblDR As System.Web.UI.WebControls.Label
    Protected WithEvents panelDR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDR As System.Web.UI.WebControls.Table
    Protected WithEvents lblPO As System.Web.UI.WebControls.Label
    Protected WithEvents panelPO As System.Web.UI.WebControls.Panel
    Protected WithEvents tblPO As System.Web.UI.WebControls.Table
    Protected WithEvents lblMyAccount As System.Web.UI.WebControls.Label
    Protected WithEvents panelMyAccount As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMyAccount As System.Web.UI.WebControls.Table
    Protected WithEvents lblInvoice As System.Web.UI.WebControls.Label
    Protected WithEvents panelInvoice As System.Web.UI.WebControls.Panel
    Protected WithEvents tblInvoice As System.Web.UI.WebControls.Table
    Protected WithEvents lblReference As System.Web.UI.WebControls.Label
    Protected WithEvents panelReference As System.Web.UI.WebControls.Panel
    Protected WithEvents tblReference As System.Web.UI.WebControls.Table
    Protected WithEvents lblReports As System.Web.UI.WebControls.Label
    Protected WithEvents panelReports As System.Web.UI.WebControls.Panel
    Protected WithEvents tblReports As System.Web.UI.WebControls.Table
    Protected WithEvents lblSetting As System.Web.UI.WebControls.Label
    Protected WithEvents panelSetting As System.Web.UI.WebControls.Panel
    Protected WithEvents tblSetting As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu1 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu1 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu1 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu2 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu2 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu2 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu3 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu3 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu3 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu4 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu4 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu4 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu5 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu5 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu5 As System.Web.UI.WebControls.Table
    Protected WithEvents lblCountNotif As System.Web.UI.WebControls.Label
    Protected WithEvents tblNotif As System.Web.UI.WebControls.Table
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblFullname As System.Web.UI.WebControls.Label
    Protected WithEvents lblUsername As System.Web.UI.WebControls.Label
    Protected WithEvents lblRole As System.Web.UI.WebControls.Label
    Protected WithEvents lblDefault_Screen As System.Web.UI.WebControls.Label
    Protected WithEvents chkAllList As System.Web.UI.WebControls.CheckBox
    Protected WithEvents cblBUList As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents lblBUMessage As System.Web.UI.WebControls.Label
    Protected WithEvents btnBUOK As System.Web.UI.WebControls.Button
    Protected WithEvents btnBUCancel As System.Web.UI.WebControls.Button
    Protected WithEvents PanelBU As System.Web.UI.WebControls.Panel
    Protected WithEvents lblFullnameClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblUsernameClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblRoleClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblDefault_ScreenClient As System.Web.UI.WebControls.Label
    Protected WithEvents chkAllListClient As System.Web.UI.WebControls.CheckBox
    Protected WithEvents cblBUListClient As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents lblClientMessage As System.Web.UI.WebControls.Label
    Protected WithEvents btnClientOK As System.Web.UI.WebControls.Button
    Protected WithEvents btnClientCancel As System.Web.UI.WebControls.Button
    Protected WithEvents PanelClient As System.Web.UI.WebControls.Panel
    Protected WithEvents cblClientList As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents cblDefaultList As System.Web.UI.WebControls.CheckBoxList    
    Protected WithEvents txtFirstname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLastname As System.Web.UI.WebControls.TextBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'holds an array of invisible fields
    Public aDisableFields As New ArrayList

    'START MODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    'the stored proc to call
    Public strStoredProc As String = "Sys_User_List"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "uid"
    Public strKeyField As String = "uid"

    Private Sub ReadyEdit()
        
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@UID", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()
        Dim strSys_Group As String = Trim(objReader("sys_group"))

        lblID.Text = objReader("id")
        txtUID.Text = Trim(objReader("uid"))
        txtUID.Enabled = True

        txtFullname.Text = Trim(objReader("fullname"))
        txtFullname.Enabled = True

        txtFirstname.Text = Trim(objReader("firstname"))
        txtFirstname.Enabled = True

        txtLastname.Text = Trim(objReader("lastname"))
        txtLastname.Enabled = True
        
        If Convert.IsDBNull(objReader("email")) Then
            txtEmail.Text = ""
        Else
            txtEmail.Text = objReader("email")
        End If
        txtEmail.Enabled = True

        If IsDate(objReader("access_start")) Then
            cbAccess_Start.Checked = True
            calAccess_Start.SelectedDate = objReader("access_start")
        Else
            cbAccess_Start.Checked = False
            calAccess_Start.SelectedDate = Now
        End If
        calAccess_Start.VisibleDate = calAccess_Start.SelectedDate
        calAccess_Start.Visible = True
        calAccess_Start.Enabled = True
        cbAccess_Start.Enabled = True

        If IsDate(objReader("access_end")) Then
            cbAccess_End.Checked = True
            calAccess_End.SelectedDate = objReader("access_end")
        Else
            cbAccess_End.Checked = False
            calAccess_End.SelectedDate = Now
        End If

        calAccess_End.VisibleDate = calAccess_End.SelectedDate
        calAccess_End.Visible = True
        calAccess_End.Enabled = True
        cbAccess_End.Enabled = True

        objReader.Close()

        'get the list of groups
        objCommand = New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlGroup.DataSource = objReader
        ddlGroup.DataValueField = "id"
        ddlGroup.DataTextField = "description"
        ddlGroup.DataBind()
        'default to it's group
        ddlGroup.SelectedIndex = ddlGroup.Items.IndexOf(ddlGroup.Items.FindByValue(strSys_Group.ToLower))
        ddlGroup.Enabled = True
        objReader.Close()

        objConnection.Close()

        cbResetPassword.Visible = True
        cbResetPassword.Checked = False

    End Sub


    Private Sub ReadyDelete()
        
        'retrieve and fill in the panel record textboxes for editing
        'set the key feild value base on datagrid selected index
        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@UID", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()
        Dim strSys_Group As String = Trim(objReader("sys_group"))

        lblID.Text = objReader("id")

        txtUID.Text = Trim(objReader("uid"))
        txtUID.Enabled = False

        txtFullname.Text = Trim(objReader("fullname"))
        txtFullname.Enabled = False

        txtFirstname.Text = Trim(objReader("firstname"))
        txtFirstname.Enabled = False

        txtLastname.Text = Trim(objReader("lastname"))
        txtLastname.Enabled = False

        If Convert.IsDBNull(objReader("email")) Then
            txtEmail.Text = ""
        Else
            txtEmail.Text = objReader("email")
        End If
        txtEmail.Enabled = False

        If IsDate(objReader("access_start")) Then
            cbAccess_Start.Checked = True
            calAccess_Start.SelectedDate = objReader("access_start")
        Else
            cbAccess_Start.Checked = False
            calAccess_Start.SelectedDate = Now
        End If
        calAccess_Start.VisibleDate = calAccess_Start.SelectedDate
        cbAccess_Start.Enabled = False
        calAccess_Start.Visible = True
        calAccess_Start.Enabled = False

        If IsDate(objReader("access_end")) Then
            cbAccess_End.Checked = True
            calAccess_End.SelectedDate = objReader("access_end")
        Else
            cbAccess_End.Checked = False
            calAccess_End.SelectedDate = Now
        End If

        calAccess_End.VisibleDate = calAccess_End.SelectedDate
        cbAccess_End.Enabled = False
        calAccess_End.Visible = True
        calAccess_End.Enabled = False

        objReader.Close()

        'get the list of groups
        objCommand = New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlGroup.DataSource = objReader
        ddlGroup.DataValueField = "id"
        ddlGroup.DataTextField = "description"
        ddlGroup.DataBind()
        'default to it's group
        ddlGroup.SelectedIndex = ddlGroup.Items.IndexOf(ddlGroup.Items.FindByValue(strSys_Group.ToLower))
        ddlGroup.Enabled = False
        objReader.Close()

        cbResetPassword.Visible = False

        objConnection.Close()
    End Sub


    Private Sub ClearInputs()
        'centralized clearing of text boxes 
        'removes settings of readonly textboxes - usually set by ReadyEdit()
        'perform any housekeeping here        

        lblID.Text = 0

        txtUID.Text = ""
        txtUID.Enabled = True

        cbResetPassword.Checked = False
        cbResetPassword.Visible = False

        txtFullname.Text = ""
        txtFullname.Enabled = True

        txtFirstname.Text = ""
        txtFirstname.Enabled = True

        txtLastname.Text = ""
        txtLastname.Enabled = True

        txtEmail.Text = ""
        txtEmail.Enabled = True

        cbAccess_Start.Checked = False
        cbAccess_Start.Enabled = True

        calAccess_Start.SelectedDate = Now
        calAccess_Start.Enabled = True

        cbAccess_End.Checked = False
        cbAccess_End.Enabled = True

        calAccess_End.SelectedDate = Now        
        calAccess_End.Enabled = True

        ddlGroup.Items.Clear()
        ddlGroup.Enabled = True

    End Sub


    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@UID", txtUID.Text)
        objCommand.Parameters.Add("@Fullname", txtFullname.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateInput = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function


    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@UID", txtUID.Text)
        objCommand.Parameters.Add("@Fullname", txtFullname.Text)
        objCommand.Parameters.Add("@Firstname", txtFirstname.Text)
        objCommand.Parameters.Add("@Lastname", txtLastname.Text)
        objCommand.Parameters.Add("@email", txtEmail.Text)

        If txtFormAction.Text = "Add" Or (txtFormAction.Text = "Edit" And cbResetPassword.Checked) Then
            objCommand.Parameters.Add("@Password", "INV" & Trim(txtUID.Text) & Trim(txtUID.Text))
        End If

        Dim strAccessStart As String
        Dim strAccessEnd As String

        If cbAccess_Start.Checked Then
            objCommand.Parameters.Add("@Access_Start", calAccess_Start.SelectedDate)
            strAccessStart = "True"
        Else
            strAccessStart = "False"
        End If

        If cbAccess_End.Checked Then
            objCommand.Parameters.Add("@Access_End", calAccess_End.SelectedDate)
            strAccessEnd = "True"
        Else
            strAccessEnd = "False"
        End If

        objCommand.Parameters.Add("@Sys_group", ddlGroup.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            Dim strCalAccessStart As String
            Dim strCalAccessEnd As String

            If strAccessStart = "True" Then
                strCalAccessStart = calAccess_Start.SelectedDate
            Else
                strCalAccessStart = "[blank]"
            End If

            If strAccessEnd = "True" Then
                strCalAccessEnd = calAccess_End.SelectedDate
            Else
                strCalAccessEnd = "[blank]"
            End If

            'get the name of Group
            objCommand = New SqlCommand("sys_group_get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", ddlGroup.SelectedValue)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strGroup As String = objReader("code")

            objReader.Close()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strStoredProc, _
                                        txtUID.Text + " > " + txtFullname.Text + " > " + txtEmail.Text + " > " + strCalAccessStart + " > " + strCalAccessEnd + " > " + strGroup, _
                                        objNewID.Value, _
                                        "0")

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveInput = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function


    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
    Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "uid", _
                                    "fullname", _
                                    "firstname", _
                                    "lastname", _
                                    "email", _
                                    "access_start", _
                                    "access_end", _
                                    "SYS_GROUP_code", _
                                    "SYS_GROUP_description", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}

        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"ID", _
                                    "User ID", _
                                    "Full Name", _
                                    "First Name", _
                                    "Last Name", _
                                    "Email", _
                                    "Access Start", _
                                    "Access End", _
                                    "Sys Group Code", _
                                    "Group Desc", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        'the item display formats. pass "" to display as is
        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        'the URL if you wish an item clickable, pass "" to disable.
        'Dim aURL() As String = {"", "", ""}

        'EndMODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        srx.Sys_Class.DataGrid_ItemCreated(e, _
                                            aColumns, _
                                            aHeaders, _
                                            aSortKeys, _
                                            aDisableFields, _
                                            Session("SortKey"), _
                                            strStoredProc, _
                                            Session("Sys_AccessList"))
    End Sub


    'End modular MODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load

        Sys_Class.DisplaySideBarMenu(lblUser, _
                                    lblUserTab, _
                                    lblCompanyName, _
                                    Session("group"), _
                                    lblDashboard, _
                                    panelDashboard, _
                                    tblDashboard, _
                                    lblPO, _
                                    panelPO, _
                                    tblPO, _
                                    lblMyAccount, _
                                    panelMyAccount, _
                                    tblMyAccount, _
                                    lblAR, _
                                    panelAR, _
                                    tblAR, _
                                    lblDR, _
                                    panelDR, _
                                    tblDR, _
                                    lblInvoice, _
                                    panelInvoice, _
                                    tblInvoice, _
                                    lblReference, _
                                    panelReference, _
                                    tblReference, _
                                    lblReports, _
                                    panelReports, _
                                    tblReports, _
                                    lblSetting, _
                                    panelSetting, _
                                    tblSetting, _
                                    lblMenu1, _
                                    panelMenu1, _
                                    tblMenu1, _
                                    lblMenu2, _
                                    panelMenu2, _
                                    tblMenu2, _
                                    lblMenu3, _
                                    panelMenu3, _
                                    tblMenu3, _
                                    lblMenu4, _
                                    panelMenu4, _
                                    tblMenu4, _
                                    lblMenu5, _
                                    panelMenu5, _
                                    tblMenu5, _
                                    lblCountNotif, _
                                    tblNotif)


        If Not Page.IsPostBack Then
            GridBind()

            btnBUOK.Attributes("onclick") = "return confirm('Save Access?');"
            btnClientOK.Attributes("onclick") = "return confirm('Save Access?');"
            btnBUCancel.Attributes("onclick") = "return confirm('Cancel Access changes?');"
            btnClientCancel.Attributes("onclick") = "return confirm('Cancel Access changes?');"
            btnCancel.Attributes("onclick") = "return confirm('Cancel?');"
            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            hlViewFullTrail.NavigateUrl = "trx_fullhistory?sys_table=" & strStoredProc & "&mode=2&ID=0"

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddRecord.Visible = False
            End If

        End If
        

    End Sub

    
    Sub GridBind()

        'this condition must only run once. initialize session(module) variables
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(DataGrid, _
                                            strStoredProc, _
                                            Session("SortKey"), _
                                            strKeyField, _
                                            BtnFirst, _
                                            btnPrevious, _
                                            BtnNext, _
                                            btnLast, _
                                            txtPageNo, _
                                            txtMorePage, _
                                            ddlRecordsPerPage, _
                                            txtSearch, _
                                            lblPageRecordCount)

    End Sub


    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles BtnFirst.Click
        txtPageNo.Text = 1
        GridBind()        
        Cleanup_and_Rebind()
    End Sub


    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnPrevious.Click
        txtPageNo.Text -= 1
        GridBind()        
        Cleanup_and_Rebind()
    End Sub


    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles BtnNext.Click
        txtPageNo.Text += 1
        GridBind()        
        Cleanup_and_Rebind()
    End Sub


    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnLast.Click
        txtPageNo.Text = (Val(txtPageNo.Text) + Val(txtMorePage.Text))
        GridBind()        
        Cleanup_and_Rebind()
    End Sub

    Private Sub ddlRecordsPerPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles ddlRecordsPerPage.SelectedIndexChanged

        txtPageNo.Text = 1
        GridBind()        
        Cleanup_and_Rebind()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSearch.Click
        'If txtSearch.Text = "" Then
        '    lblPageRecordCount.Text = lblPageRecordCount.Text & " *Please enter a search key."
        '    Exit Sub
        'End If

        txtPageNo.Text = 1
        GridBind()        
        Cleanup_and_Rebind()

    End Sub


    Private Sub DataGrid_SortCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) _
    Handles DataGrid.SortCommand
        Session("SortKey") = e.SortExpression
        txtPageNo.Text = 1
        txtSearch.Text = ""
        GridBind()        
        Cleanup_and_Rebind()
    End Sub


    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAddRecord.Click

        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green
        ClearInputs()
        SetFocus(txtUID)
        PanelClient.Visible = False
        PanelBU.Visible = False
        btnSave.Text = "Save"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        'get the list of groups
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlGroup.DataSource = objReader
        ddlGroup.DataValueField = "id"
        ddlGroup.DataTextField = "description"
        ddlGroup.DataBind()
        objReader.Close()

        objConnection.Close()

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnCancel.Click

        panelForm.Visible = False

        panelInfo.Visible = True
        panelSuccess.Visible = False

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub


    Private Sub Cleanup_and_Rebind()
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSave.Click

        'always hide, but show later in this module
        lblMessage.Visible = False

        If Not Page.IsValid Then
            Exit Sub
        End If

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes
                lblMessage.Visible = True                

                If txtFormAction.Text = "Add" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    PanelClient.Visible = False
                    PanelBU.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    PanelClient.Visible = False
                    PanelBU.Visible = False

                    'reset and rebind                    
                    GridBind()

                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    PanelClient.Visible = False
                    PanelBU.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()
                End If

            Else
                'notify unsucessful and the reason
                lblMessage.Visible = True
                lblMessage.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            lblMessage.Visible = True
            lblMessage.Text = strValidateInput
        End If

    End Sub


    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.ForeColor = Color.Orange
        btnSave.Text = "Save"

        'show the input panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        PanelClient.Visible = False
        PanelBU.Visible = False

        ReadyEdit() 'retrive and fill the text box for editing
    End Sub


    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Delete"
        lblMode.ForeColor = Color.Red
        btnSave.Text = "Delete"

        'show the form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        PanelClient.Visible = False
        PanelBU.Visible = False

        ReadyDelete() 'retrive and fill the text box for editing
    End Sub
    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
     Handles DataGrid.ItemCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        If e.CommandName = "Company" Then
            BU_Command()

        ElseIf e.CommandName = "Client" Then
            Client_Command()

        End If

    End Sub

    Private Sub btnBUCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBUCancel.Click
        panelInfo.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        PanelClient.Visible = False
        PanelBU.Visible = False

        'reset the selected index in case of edit modes and rebind        
        GridBind()
    End Sub
    Private Sub btnClientCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClientCancel.Click
        panelInfo.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        PanelClient.Visible = False
        PanelBU.Visible = False

        'reset the selected index in case of edit modes and rebind        
        GridBind()
    End Sub

    Private Sub btnBUOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBUOK.Click
        'validate the inputs vs. table records
        Dim strValidateAccess As String = ValidateAccess()

        'is the validation 
        If strValidateAccess = "ok" Then

            'save the inputs
            Dim strSaveInput As String = SaveAccess()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes            
                lblBUMessage.Visible = True

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                PanelClient.Visible = False
                PanelBU.Visible = False

                GridBind()

            Else
                'notify unsucessful and the reason
                lblBUMessage.Visible = True
                lblBUMessage.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateAccess
        End If
        
    End Sub
    Private Function ValidateAccess()
       
        ValidateAccess = "ok"

        Dim TotalCount As Integer

        Dim i As Integer
        For i = 0 To (cblBUList.Items.Count - 1)
            If cblDefaultList.Items(i).Selected Then

                TotalCount = TotalCount + 1

            End If

            If ValidateAccess <> "ok" Then
                Exit For
            End If

        Next

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Company_Access_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@Session_username", lblUsername.Text)
        objCommand.Parameters.Add("@default_bu", TotalCount)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateAccess = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()

    End Function
    Private Function SaveAccess()
        'used to save the inputs when user clicks permission
        'called by btnPermissionOK.Click handler
        'returns a string status 
        SaveAccess = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Company_Access_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Delete")
        objCommand.Parameters.Add("@sys_user", lblUsername.Text)

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            Dim i As Integer
            For i = 0 To (cblBUList.Items.Count - 1)
                If cblBUList.Items(i).Selected Or cblDefaultList.Items(i).Selected Then

                    objConnection.Close()
                    objCommand = New SqlCommand("Sys_Company_Access_Save", objConnection)
                    objCommand.CommandType = CommandType.StoredProcedure
                    objCommand.Parameters.Add("@FormAction", "Save")
                    objCommand.Parameters.Add("@sys_user", lblUsername.Text)
                    objCommand.Parameters.Add("@code", cblBUList.Items(i).Value)

                    If cblBUList.Items(i).Selected Then
                        objCommand.Parameters.Add("@List_Mode", 1)
                    End If

                    If cblDefaultList.Items(i).Selected Then
                        objCommand.Parameters.Add("@Default_Mode", 1)
                    End If

                    objConnection.Open()
                    objCommand.ExecuteNonQuery()
                End If

              
            Next

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                       "Changed", _
                                        "Sys_Company_Access_Save", _
                                        lblUsername.Text, _
                                        lblID.Text, _
                                        "0")

        Catch ex As Exception
            'in case of error
            SaveAccess = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try
    End Function
    Private Sub btnClientOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClientOK.Click
        'save the inputs
        Dim strSaveInput As String = SaveClientAccess()

        'is the saving successfull?
        If strSaveInput = "ok" Then
            'notify and clear input boxes            
            lblClientMessage.Visible = True

            panelSuccess.Visible = True
            panelInfo.Visible = False
            panelForm.Visible = False
            PanelClient.Visible = False
            PanelBU.Visible = False

            GridBind()

        Else
            'notify unsucessful and the reason
            lblClientMessage.Visible = True
            lblClientMessage.Text = strSaveInput
        End If
    End Sub
    Private Sub BU_Command()
        'Handles permission command when clicked at the grid
        lblBUMessage.Visible = False
        PanelBU.Visible = True
        PanelClient.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@UID", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblFullname.Text = objReader("fullname")
        lblUsername.Text = objReader("uid")
        lblRole.Text = objReader("SYS_GROUP_description")
        lblDefault_ScreenClient.Text = objReader("default_screen")

        objConnection.Close()

        objCommand = New SqlCommand("Sys_Company_Access_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@sys_user", strKeyFieldValue)
        objConnection.Open()
        objReader = objCommand.ExecuteReader

        cblBUList.Items.Clear()
        cblDefaultList.Items.Clear()

        While objReader.Read
            Dim cblAccessItem As New ListItem
            Dim cbmDefaultItem As New ListItem

            cblAccessItem.Value = objReader("code")
            cblAccessItem.Text = Trim(objReader("code"))

            cbmDefaultItem.Value = objReader("code")
            cbmDefaultItem.Text = Trim(objReader("code"))

            If VarType(objReader("list_mode")) = VariantType.Boolean Then
                cblAccessItem.Selected = (objReader("list_mode") = True)
            Else
                cblAccessItem.Selected = False
            End If

            If VarType(objReader("is_default")) = VariantType.Boolean Then
                cbmDefaultItem.Selected = (objReader("is_default") = True)
            Else
                cbmDefaultItem.Selected = False
            End If

            cblBUList.Items.Add(cblAccessItem)
            cblDefaultList.Items.Add(cbmDefaultItem)

        End While


        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub Client_Command()
        'Handles permission command when clicked at the grid
        lblClientMessage.Visible = False
        PanelClient.Visible = True
        PanelBU.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@UID", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblFullnameClient.Text = objReader("fullname")
        lblUsernameClient.Text = objReader("uid")
        lblRoleClient.Text = objReader("SYS_GROUP_description")
        lblDefault_ScreenClient.Text = objReader("default_screen")

        objConnection.Close()

        objCommand = New SqlCommand("Sys_Client_Access_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@sys_user", strKeyFieldValue)
        objConnection.Open()
        objReader = objCommand.ExecuteReader

        cblClientList.Items.Clear()

        While objReader.Read
            Dim cblAccessItem As New ListItem

            cblAccessItem.Value = objReader("account_no")
            cblAccessItem.Text = "" & Trim(objReader("client")) & " > " & Trim(objReader("account_no"))

            If VarType(objReader("list_mode")) = VariantType.Boolean Then
                cblAccessItem.Selected = (objReader("list_mode") = True)
            Else
                cblAccessItem.Selected = False
            End If

            cblClientList.Items.Add(cblAccessItem)

        End While


        objReader.Close()
        objConnection.Close()

    End Sub

    Private Function SaveClientAccess()
        'used to save the inputs when user clicks permission
        'called by btnPermissionOK.Click handler
        'returns a string status 
        SaveClientAccess = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Client_Access_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Delete")
        objCommand.Parameters.Add("@sys_user", lblUsernameClient.Text)
        'objCommand.Parameters.Add("@bu_id", lblRole.Text)

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            Dim i As Integer
            For i = 0 To (cblClientList.Items.Count - 1)
                If cblClientList.Items(i).Selected Then

                    objConnection.Close()
                    objCommand = New SqlCommand("Sys_Client_Access_Save", objConnection)
                    objCommand.CommandType = CommandType.StoredProcedure
                    objCommand.Parameters.Add("@FormAction", "Save")
                    objCommand.Parameters.Add("@sys_user", lblUsernameClient.Text)
                    objCommand.Parameters.Add("@account_no", cblClientList.Items(i).Value)
                    objCommand.Parameters.Add("@List_Mode", 1)


                    objConnection.Open()
                    objCommand.ExecuteNonQuery()
                End If

            Next

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                       "Changed", _
                                        "Sys_Client_Access", _
                                        lblUsernameClient.Text, _
                                        lblID.Text, _
                                        "0")

        Catch ex As Exception
            'in case of error
            SaveClientAccess = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try
    End Function
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub
End Class
