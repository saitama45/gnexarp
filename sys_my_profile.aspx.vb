
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.Configuration
Imports System.IO


Public Class sys_my_profile
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblUserID As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountGroup As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountGroupID As System.Web.UI.WebControls.Label
    Protected WithEvents lblSysGroupID As System.Web.UI.WebControls.Label
    Protected WithEvents lblFullName As System.Web.UI.WebControls.Label
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
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
    Protected WithEvents txtNotedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents btnUploadESign As System.Web.UI.WebControls.Button
    Protected WithEvents FileUploadESign As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents txtAuthorizedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelNotedBy As System.Web.UI.WebControls.Panel
    Protected WithEvents panelAuthorizedBy As System.Web.UI.WebControls.Panel
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents divImgESign As System.Web.UI.HtmlControls.HtmlGenericControl

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
    Public strStoredProc As String = "Sys_Group_List"

    Private Sub ReadyEdit()        

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_User_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@UID", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))
        lblUserID.Text = Trim(objReader("uid"))
        lblFullName.Text = Trim(objReader("fullname"))

        If Convert.IsDBNull(objReader("email")) Then
            txtEmail.Text = ""
        Else
            txtEmail.Text = Trim(objReader("email"))
        End If             

        lblAccountGroup.Text = Trim(objReader("SYS_GROUP_description"))
        lblAccountGroupID.Text = Trim(objReader("SYS_GROUP_code"))
        lblSysGroupID.Text = objReader("sys_group")

        If Convert.IsDBNull(objReader("noted_by")) Then
            txtNotedBy.Text = ""
        Else
            txtNotedBy.Text = Trim(objReader("noted_by"))
        End If

        If Convert.IsDBNull(objReader("authorized_by")) Then
            txtAuthorizedBy.Text = ""
        Else
            txtAuthorizedBy.Text = Trim(objReader("authorized_by"))
        End If

        objReader.Close()

        objConnection.Close()

    End Sub

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
        objCommand.Parameters.Add("@FormAction", "MyProfile")        
        objCommand.Parameters.Add("@email", txtEmail.Text)
        objCommand.Parameters.Add("@noted_by", txtNotedBy.Text)
        objCommand.Parameters.Add("@authorized_by", txtAuthorizedBy.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        objCommand.Parameters.Add("@UID", lblUserID.Text)
        objCommand.Parameters.Add("@Password", "")
        objCommand.Parameters.Add("@Access_Start", DBNull.Value)
        objCommand.Parameters.Add("@Access_End", DBNull.Value)
        objCommand.Parameters.Add("@Sys_Group", lblSysGroupID.Text)

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        "MyProfile", _
                                        "Sys_Profile", _
                                        "Email: " + txtEmail.Text + " > NotedBy: " + txtNotedBy.Text + " > AuthorizedBy: " + txtAuthorizedBy.Text, _
                                        objNewID.Value, _
                                        0)
                                        

        Catch ex As Exception
            'in case of error
            SaveInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try

    End Function


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
            ReadyEdit()
            If Session("Group") = "BC" Or Session("Group") = "BP" Then
                panelNotedBy.Visible = True
            ElseIf Session("Group") = "BH" Or Session("Group") = "BHC" Or Session("Group") = "CC" Then
                panelAuthorizedBy.Visible = True
            Else
                panelNotedBy.Visible = False
                panelAuthorizedBy.Visible = False
            End If

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()
            Dim objCommand As New SqlCommand("Sys_User_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@uid", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim htmlForImages As String = String.Empty

            If Convert.IsDBNull(objReader("e_sign_path")) Then
                htmlForImages = String.Empty
            Else
                htmlForImages = "<img style='width:100%;max-width:200px' src=" & Trim(objReader("e_sign_path")) & ">"
            End If

            divImgESign.InnerHtml = htmlForImages

            objReader.Close()
            objConnection.Close()
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSave.Click

        If (Session("Group") = "BC" Or Session("Group") = "BP") And txtNotedBy.Text = Nothing Or txtNotedBy.Text.Length > 0 And txtNotedBy.Text.Trim().Length = 0 Then 'txtName.Text.Length > 0 And txtName.Text.Trim().Length = 0 to handle empty and white spaces
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = "Noted By is required."
            panelSuccess.Visible = False

        ElseIf (Session("Group") = "BH" Or Session("Group") = "BHC" Or Session("Group") = "CC") And txtAuthorizedBy.Text = Nothing Or (txtAuthorizedBy.Text.Length > 0 And txtAuthorizedBy.Text.Trim().Length = 0) Then
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = "Authorized By is required."
            panelSuccess.Visible = False

        ElseIf txtEmail.Text = Nothing Or txtEmail.Text.Length > 0 And txtEmail.Text.Trim().Length = 0 Then
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = "Email is required."
            panelSuccess.Visible = False

        Else
            'validate the inputs vs. table records
            Dim strValidateInput As String = ValidateInput()

            'is the validation 
            If strValidateInput = "ok" Then
                'then save the inputs
                Dim strSaveInput As String = SaveInput()

                Dim FileName As String = System.IO.Path.GetFileName(FileUploadESign.PostedFile.FileName)
                Dim csvPath As String = Server.MapPath("~/Files/ESign/") + FileName

                Dim contentType As String = FileUploadESign.PostedFile.ContentType
                Dim fs As Stream = FileUploadESign.PostedFile.InputStream
                Dim br As BinaryReader = New BinaryReader(fs)
                Dim size As Decimal = Math.Round((CDec(FileUploadESign.PostedFile.ContentLength) / CDec(1024)), 2)

                If (Not FileUploadESign.PostedFile Is Nothing) AndAlso (FileUploadESign.PostedFile.ContentLength > 0) Then

                    Try

                        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                        Dim objCommand As New SqlCommand("Sys_User_Save", objConnection)
                        objCommand.CommandType = CommandType.StoredProcedure
                        objCommand.Parameters.Add("@FormAction", "UploadEsign")
                        objCommand.Parameters.Add("@uid", lblUserID.Text)
                        objCommand.Parameters.Add("@e_sign_filename", FileName)
                        objCommand.Parameters.Add("@e_sign_contenttype", contentType)
                        objCommand.Parameters.Add("@e_sign_size", size.ToString() + "KB")
                        objCommand.Parameters.Add("@e_sign_path", "Files/ESign/" + FileName)
                        objCommand.Parameters.Add("@Session_username", Session("username"))
                        objCommand.Parameters.Add("@id", lblID.Text)
                        objCommand.Parameters.Add("@newID", lblID.Text)

                        objConnection.Open()
                        objCommand.ExecuteNonQuery()

                        'Upload and save the File.
                        FileUploadESign.PostedFile.SaveAs(csvPath)
                        panelSuccess.Visible = True
                        panelInfo.Visible = False

                        objConnection.Close()
                        ''Delete the temporary file
                        'File.Delete(csvPath)
                    Catch ex As Exception

                        panelInfo.Visible = True
                        lblValidate.Text = ex.ToString()


                    End Try
                Else
                    panelInfo.Visible = True
                    lblValidate.Text = "Please select a file to upload."
                End If

                'is the saving successfull?
                If strSaveInput = "ok" Then

                    Response.Redirect("sys_my_profile")

                Else
                    'notify unsucessful and the reason
                    panelInfo.Visible = True
                    lblValidate.Text = strSaveInput
                End If

            Else
                'notify user and reason of invalidation
                panelInfo.Visible = True
                lblValidate.Text = strValidateInput
            End If
        End If


        If Not Page.IsValid Then
            Exit Sub
        End If
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
        objCommand.Parameters.Add("@FormAction", "MyProfile")
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@UID", lblUserID.Text)
        objCommand.Parameters.Add("@Fullname", lblFullName.Text)
        objCommand.Parameters.Add("@Email", txtEmail.Text)

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
 
End Class
