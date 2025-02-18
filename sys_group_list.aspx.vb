
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState


Public Class sys_group_list
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtMorePage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPageNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRecordsPerPage As System.Web.UI.WebControls.TextBox    
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label    
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label    
    Protected WithEvents BtnFirst As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrevious As System.Web.UI.WebControls.Button
    Protected WithEvents BtnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnLast As System.Web.UI.WebControls.Button
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefault_Screen As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents PanelMenu As System.Web.UI.WebControls.Panel
    Protected WithEvents cblAdd As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents cblList As System.Web.UI.WebControls.CheckBoxList    
    Protected WithEvents lblDescription As System.Web.UI.WebControls.Label
    Protected WithEvents lblDefault_Screen As System.Web.UI.WebControls.Label
    Protected WithEvents btnMenuOK As System.Web.UI.WebControls.Button
    Protected WithEvents btnMenuCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblMenuMessage As System.Web.UI.WebControls.Label
    Protected WithEvents cblEdit As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents cblDelete As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents PanelAccount As System.Web.UI.WebControls.Panel
    Protected WithEvents lblAccountCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountID As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountDescription As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountDefault_Screen As System.Web.UI.WebControls.Label
    Protected WithEvents ddlAccount As System.Web.UI.WebControls.DropDownList
    Protected WithEvents cblAccount As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents lblAccountMessage As System.Web.UI.WebControls.Label
    Protected WithEvents btnAccountOK As System.Web.UI.WebControls.Button
    Protected WithEvents btnAccountCancel As System.Web.UI.WebControls.Button
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
    Protected WithEvents txtID As System.Web.UI.WebControls.Label
    Protected WithEvents lblMyProfile As System.Web.UI.WebControls.Label    
    Protected WithEvents lblID As System.Web.UI.WebControls.Label    
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
    Protected WithEvents chkAllList As System.Web.UI.WebControls.CheckBox

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

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "Code"
    Public strKeyField As String = "id"


    Private Sub ReadyEdit()        

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()
        txtID.Text = objReader("id")
        txtCode.Text = Trim(objReader("code"))
        txtDescription.Text = Trim(objReader("description"))
        txtDefault_Screen.Text = Trim(objReader("default_screen"))

        objReader.Close()
        objConnection.Close()

        'protect the box containing the key field
        txtCode.Enabled = False
        txtDescription.Enabled = True
        txtDefault_Screen.Enabled = True
        PanelMenu.Visible = False
    End Sub


    Private Sub ReadyDelete()        

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()
        txtID.Text = objReader("id")
        txtCode.Text = Trim(objReader("code"))
        txtDescription.Text = Trim(objReader("description"))
        txtDefault_Screen.Text = Trim(objReader("default_screen"))

        objReader.Close()
        objConnection.Close()

        'protect the box containing the key field
        txtCode.Enabled = False
        txtDescription.Enabled = False
        txtDefault_Screen.Enabled = False
        PanelMenu.Visible = False
    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", txtID.Text)
        objCommand.Parameters.Add("@Code", txtCode.Text)
        objCommand.Parameters.Add("@Description", txtDescription.Text)
        objCommand.Parameters.Add("@Default_Screen", txtDefault_Screen.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

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
                                        txtFormAction.Text, _
                                        strStoredProc, _
                                        txtCode.Text + " > " + txtDescription.Text + " > " + txtDefault_Screen.Text, _
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


    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", txtID.Text)
        objCommand.Parameters.Add("@Code", txtCode.Text)
        objCommand.Parameters.Add("@Description", txtDescription.Text)

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


    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
        Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "code", _
                                    "description", _
                                    "default_screen", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}

        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"id", _
                                    "Code", _
                                    "Description", _
                                    "Default Screen", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"id", _
                                    "Code", _
                                    "Description", _
                                    "", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}

        'the item display formats. pass "" to display as is
        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFooters() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        'the URL if you wish an item clickable, pass "" to disable.
        'Dim aURL() As String = {"", "", ""}

        srx.Sys_Class.DataGrid_ItemCreated(e, _
                                             aColumns, _
                                             aHeaders, _
                                             aSortKeys, _
                                             aDisableFields, _
                                             Session("SortKey"), _
                                             strStoredProc, _
                                             Session("Sys_AccessList"))
    End Sub


    'EndMODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

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

            btnCancel.Attributes("onclick") = "return confirm('Cancel?');"
            btnMenuOK.Attributes("onclick") = "return confirm('Save menu changes?');"
            btnMenuCancel.Attributes("onclick") = "return confirm('Cancel menu changes?');"
            btnAccountOK.Attributes("onclick") = "return confirm('Save account access changes?');"
            btnAccountCancel.Attributes("onclick") = "return confirm('Cancel account access changes?');"
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
        SetFocus(txtCode)
        btnsave.text = "Add"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()


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

    Private Sub ClearInputs()
        'centralized clearing of text boxes 
        'removes settings of readonly and enabled textboxes - usually set by ReadyEdit()
        'Display Side Bar Menus        

        txtID.Text = 0
        txtCode.Text = ""
        txtCode.ReadOnly = False
        txtCode.Enabled = True

        txtDescription.Text = ""
        txtDescription.ReadOnly = False
        txtDescription.Enabled = True

        txtDefault_Screen.Text = ""
        txtDefault_Screen.ReadOnly = False
        txtDefault_Screen.Enabled = True

        panelSuccess.Visible = False
        panelInfo.Visible = False
        PanelMenu.Visible = False
        PanelAccount.Visible = False

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub

    Private Sub Cleanup_and_Rebind()

        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        PanelMenu.Visible = False
        PanelAccount.Visible = False

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
                'lblMessage.Text = "Record saved."                

                If txtFormAction.Text = "Add" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    PanelMenu.Visible = False
                    PanelAccount.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    PanelMenu.Visible = False
                    PanelAccount.Visible = False

                    'reset and rebind                    
                    GridBind()

                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    PanelMenu.Visible = False
                    PanelAccount.Visible = False

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
        btnsave.text = "Add"

        'show the input panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)
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
        ReadyDelete() 'retrive and fill the text box for editing
    End Sub

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
     Handles DataGrid.ItemCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        If e.CommandName = "Menu" Then
            Menu_Command()

        ElseIf e.CommandName = "Account" Then
            Account_Command()

        End If

    End Sub
    Private Sub btnMenuCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnMenuCancel.Click

        panelInfo.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        PanelMenu.Visible = False
        PanelAccount.Visible = False

        'reset the selected index in case of edit modes and rebind        
        GridBind()
    End Sub

    Private Sub btnMenuOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnMenuOK.Click

        'save the inputs
        Dim strSaveInput As String = SaveMenu()

        'is the saving successfull?
        If strSaveInput = "ok" Then
            'notify and clear input boxes            
            lblMenuMessage.Visible = True

            panelSuccess.Visible = True
            panelInfo.Visible = False
            panelForm.Visible = False
            PanelMenu.Visible = False
            PanelAccount.Visible = False

            GridBind()

        Else
            'notify unsucessful and the reason
            lblMenuMessage.Visible = True
            lblMenuMessage.Text = strSaveInput
        End If

    End Sub
    Private Sub Menu_Command()
        'Handles permission command when clicked at the grid
        lblMenuMessage.Visible = False
        PanelMenu.Visible = True
        PanelAccount.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblCode.Text = objReader("code")
        lblID.Text = Trim(objReader("id"))
        lblDescription.Text = objReader("description")
        lblDefault_Screen.Text = objReader("default_screen")

        objConnection.Close()

        objCommand = New SqlCommand("Sys_Access_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)
        objConnection.Open()
        objReader = objCommand.ExecuteReader

        cblList.Items.Clear()
        cblAdd.Items.Clear()
        cblEdit.Items.Clear()
        cblDelete.Items.Clear()

        While objReader.Read
            Dim cblListItem As New ListItem
            Dim cblAddItem As New ListItem
            Dim cblEditItem As New ListItem
            Dim cblDeleteItem As New ListItem

            cblListItem.Value = objReader("id")
            cblAddItem.Value = objReader("code")
            cblEditItem.Value = objReader("code")
            cblDeleteItem.Value = objReader("code")

            cblListItem.Text = "" & Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))
            cblAddItem.Text = "" & Trim(objReader("sub_menu"))
            cblEditItem.Text = "" & Trim(objReader("sub_menu"))
            cblDeleteItem.Text = "" & Trim(objReader("sub_menu"))

            If VarType(objReader("list_mode")) = VariantType.Boolean Then
                cblListItem.Selected = (objReader("list_mode") = True)
            Else
                cblListItem.Selected = False
            End If

            If VarType(objReader("add_mode")) = VariantType.Boolean Then
                cblAddItem.Selected = (objReader("add_mode") = True)
            Else
                cblAddItem.Selected = False
            End If

            If VarType(objReader("edit_mode")) = VariantType.Boolean Then
                cblEditItem.Selected = (objReader("edit_mode") = True)
            Else
                cblEditItem.Selected = False
            End If

            If VarType(objReader("delete_mode")) = VariantType.Boolean Then
                cblDeleteItem.Selected = (objReader("delete_mode") = True)
            Else
                cblDeleteItem.Selected = False
            End If

            cblList.Items.Add(cblListItem)
            cblAdd.Items.Add(cblAddItem)
            cblEdit.Items.Add(cblEditItem)
            cblDelete.Items.Add(cblDeleteItem)
        End While

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Function SaveMenu()
        'used to save the inputs when user clicks permission
        'called by btnPermissionOK.Click handler
        'returns a string status 
        SaveMenu = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Access_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Delete")
        objCommand.Parameters.Add("@Sys_Group", lblID.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            Dim i As Integer
            For i = 0 To (cblList.Items.Count - 1)
                If cblList.Items(i).Selected Then

                    objConnection.Close()
                    objCommand = New SqlCommand("Sys_Access_Save", objConnection)
                    objCommand.CommandType = CommandType.StoredProcedure
                    objCommand.Parameters.Add("@FormAction", "Save")
                    objCommand.Parameters.Add("@Sys_Group", lblID.Text)
                    objCommand.Parameters.Add("@Sys_Menu", cblList.Items(i).Value)
                    objCommand.Parameters.Add("@Session_username", Session("username"))
                    objCommand.Parameters.Add("@List_Mode", 1)

                    If cblAdd.Items(i).Selected Then
                        objCommand.Parameters.Add("@Add_Mode", 1)
                    End If

                    If cblEdit.Items(i).Selected Then
                        objCommand.Parameters.Add("@Edit_Mode", 1)
                    End If

                    If cblDelete.Items(i).Selected Then
                        objCommand.Parameters.Add("@Delete_Mode", 1)
                    End If

                    objConnection.Open()
                    objCommand.ExecuteNonQuery()
                End If

            Next

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        "Changed", _
                                        "Sys_Access", _
                                        lblCode.Text, _
                                        lblID.Text, _
                                        "0")

        Catch ex As Exception
            'in case of error
            SaveMenu = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try

    End Function

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub btnAccountCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAccountCancel.Click
        panelInfo.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        PanelMenu.Visible = False
        PanelAccount.Visible = False

        'reset the selected index in case of edit modes and rebind        
        GridBind()
    End Sub

    Private Sub btnAccountOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAccountOK.Click

        Dim strValidateInput As String = ValidateAccount()

        'is the validation 
        If strValidateInput = "ok" Then
            'save the inputs
            Dim strSaveInput As String = SaveAccount()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes            
                lblAccountMessage.Visible = True

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                PanelMenu.Visible = False
                PanelAccount.Visible = False

                GridBind()

            Else
                'notify unsucessful and the reason
                lblAccountMessage.Visible = True
                lblAccountMessage.Text = strSaveInput
            End If
        Else
            'notify user and reason of invalidation
            lblAccountMessage.Visible = True
            lblAccountMessage.Text = strValidateInput
        End If

    End Sub
    Private Sub Account_Command()
        'Handles permission command when clicked at the grid
        lblAccountMessage.Visible = False
        PanelAccount.Visible = True
        PanelMenu.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Group_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblAccountCode.Text = objReader("code")
        lblAccountID.Text = Trim(objReader("id"))
        lblAccountDescription.Text = objReader("description")
        lblAccountDefault_Screen.Text = objReader("default_screen")

        objReader.Close()

        'get the list of Client
        objCommand = New SqlCommand("Ref_Client_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objReader = objCommand.ExecuteReader
        ddlAccount.DataSource = objReader
        ddlAccount.DataValueField = "id"
        ddlAccount.DataTextField = "name"
        ddlAccount.DataBind()
        objReader.Close()

        objConnection.Close()

        Refresh_Outlet()

    End Sub
    Private Function ValidateAccount()
        ValidateAccount = "ok"

        Dim i As Integer
        For i = 0 To (cblAccount.Items.Count - 1)
            If cblAccount.Items(i).Selected Then
                'the connection 
                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

                'the stored procedure and parameters
                Dim objCommand As New SqlCommand("Sys_Account_Access_Validate", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@client_outlet", cblAccount.Items(i).Value)

                'open the connection and execute the reader 
                objConnection.Open()

                Dim objReader As SqlDataReader = objCommand.ExecuteReader

                If objReader.HasRows Then
                    While objReader.Read
                        ValidateAccount = objReader("Error_Message")
                    End While
                End If

                'close immediately the reader and connection object 
                objReader.Close()
                objConnection.Close()

            End If

            If ValidateAccount <> "ok" Then
                Exit For
            End If
        Next

    End Function
    Private Function SaveAccount()
        'used to save the inputs when user clicks permission
        'called by btnPermissionOK.Click handler
        'returns a string status 
        SaveAccount = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Account_Access_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Delete")
        objCommand.Parameters.Add("@Sys_Group", lblAccountID.Text)
        objCommand.Parameters.Add("@client", ddlAccount.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            Dim i As Integer
            For i = 0 To (cblAccount.Items.Count - 1)
                If cblAccount.Items(i).Selected Then

                    objConnection.Close()
                    objCommand = New SqlCommand("Sys_Account_Access_Save", objConnection)
                    objCommand.CommandType = CommandType.StoredProcedure
                    objCommand.Parameters.Add("@FormAction", "Save")
                    objCommand.Parameters.Add("@sys_group", lblAccountID.Text)
                    objCommand.Parameters.Add("@client", ddlAccount.SelectedValue)
                    objCommand.Parameters.Add("@client_outlet", cblAccount.Items(i).Value)
                    objCommand.Parameters.Add("@Session_username", Session("username"))

                    If cblAccount.Items(i).Selected Then
                        objCommand.Parameters.Add("@access_mode", 1)
                    End If

                    objConnection.Open()
                    objCommand.ExecuteNonQuery()
                End If

            Next

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        "Changed", _
                                        "Sys_Account_Access", _
                                        lblAccountCode.Text, _
                                        lblAccountID.Text, _
                                        0)

        Catch ex As Exception
            'in case of error
            SaveAccount = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub Refresh_Outlet()

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Account_Access_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblAccountID.Text)
        objCommand.Parameters.Add("@client", ddlAccount.SelectedValue)


        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        cblAccount.Items.Clear()

        While objReader.Read
            Dim cblAccountItem As New ListItem

            cblAccountItem.Value = objReader("id")

            cblAccountItem.Text = "" & Trim(objReader("outlet"))

            If VarType(objReader("access_mode")) = VariantType.Boolean Then
                cblAccountItem.Selected = (objReader("access_mode") = True)
            Else
                cblAccountItem.Selected = False
            End If

            cblAccount.Items.Add(cblAccountItem)

        End While

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub ddlAccount_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlAccount.SelectedIndexChanged
        Refresh_Outlet()
    End Sub
End Class
