
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState


Public Class ref_bank_list
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtMorePage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPageNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRecordsPerPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label
    Protected WithEvents lblModule As System.Web.UI.WebControls.Label
    Protected WithEvents BtnFirst As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrevious As System.Web.UI.WebControls.Button
    Protected WithEvents BtnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnLast As System.Web.UI.WebControls.Button
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.Button
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Requiredfieldvalidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtSpecial_Access As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlGroup As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlMenu As System.Web.UI.WebControls.DropDownList
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMyProfile As System.Web.UI.WebControls.Label
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents lblUserTab As System.Web.UI.WebControls.Label
    Protected WithEvents lblDashboard As System.Web.UI.WebControls.Label
    Protected WithEvents panelDashboard As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDashboard As System.Web.UI.WebControls.Table
    Protected WithEvents lblAR As System.Web.UI.WebControls.Label
    Protected WithEvents panelAR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblAR As System.Web.UI.WebControls.Table
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
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSLCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSSLCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtBline As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBline As System.Web.UI.WebControls.Label
    Protected WithEvents txtBranchCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBranchCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtBranchName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBranchName As System.Web.UI.WebControls.Label
    Protected WithEvents lbliFOMSBlineName As System.Web.UI.WebControls.Label
    Protected WithEvents txtBlineName As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlBU As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlClient As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtAttention As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPosition As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtClientArea As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBldg As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAddress1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAddress2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRegionArea As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCheckingDays As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtNotedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator7 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtAuthorizedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator8 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtOtherDetails As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRemarks As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlBank As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnAddBank As System.Web.UI.WebControls.Button
    Protected WithEvents txtBankBranch As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblBankMode As System.Web.UI.WebControls.Label
    Protected WithEvents txtBankFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelBank As System.Web.UI.WebControls.Panel
    Protected WithEvents lblBankID As System.Web.UI.WebControls.Label
    Protected WithEvents txtBank As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBankCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnBankSave As System.Web.UI.WebControls.Button
    Protected WithEvents lblValidate As System.Web.UI.WebControls.Label
    Protected WithEvents btnEditBank As System.Web.UI.WebControls.Button

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
    Public strSubMenuName As String = "ref_bank_list"
    Public strStoredProc As String = "Ref_Bank_List"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "id"
    Public strKeyField As String = "id"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load

        Sys_Class.DisplaySideBarMenu(lblUser, _
                                    lblUserTab, _
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
                                    tblSetting)

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage.aspx")
        End If

        'is the user allowed to add record?
        If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_add") < 0 Then
            'disable the add button
            btnAddRecord.Enabled = False
        End If

        If Not Page.IsPostBack Then
            GridBind()

            btnCancel.Visible = False

            btnCancel.Attributes("onclick") = "return confirm('Cancel?');"
            txtFormAction.Visible = False 'always hide this
            txtBankFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = True
            hlViewFullTrail.NavigateUrl = "trx_fullhistory.aspx?sys_table=" & strStoredProc & "&mode=2&ID=0"
        End If

    End Sub
    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAddRecord.Click

        txtFormAction.Text = "Add"
        lblMode.BackColor = Color.Green
        ClearInputs()
        SetFocus(ddlbank)

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)


        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlBank.DataSource = objReader
        ddlBank.DataValueField = "id"
        ddlBank.DataTextField = "name"
        ddlBank.DataBind()
        objReader.Close()

        objConnection.Close()
    End Sub
    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
   Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.BackColor = Color.Orange

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
        lblMode.BackColor = Color.Red

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
    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("[Ref_BankBranch_Get]", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")
        txtBankBranch.Text = objReader("bank_branch")
       
        Dim intBank As String = objReader("bank_id")
        objReader.Close()

        objCommand = New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", intBank)
        objReader = objCommand.ExecuteReader
        ddlBank.DataSource = objReader
        ddlBank.DataValueField = "id"
        ddlBank.DataTextField = "name"
        ddlBank.DataBind()
        ddlBank.SelectedIndex = ddlBank.Items.IndexOf(ddlBank.Items.FindByValue(intBank))
        objReader.Close()
        objConnection.Close()

        'clear protection
        ddlBank.Enabled = True
        txtBankBranch.ReadOnly = False

        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelBank.Visible = False
        SetFocus(ddlBank)

    End Sub
    Private Sub ReadyDelete()

        'retrieve and fill in the panel record textboxes for editing
        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_BankBranch_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")
        txtBankBranch.Text = objReader("bank_branch")

        Dim intBank As String = objReader("bank_id")
        objReader.Close()

        objCommand = New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", intBank)
        objReader = objCommand.ExecuteReader
        ddlBank.DataSource = objReader
        ddlBank.DataValueField = "id"
        ddlBank.DataTextField = "name"
        ddlBank.DataBind()
        ddlBank.SelectedIndex = ddlBank.Items.IndexOf(ddlBank.Items.FindByValue(intBank))
        objReader.Close()
        objConnection.Close()

        objConnection.Close()

        'protect the inputs 
        ddlBank.Enabled = False
        txtBankBranch.ReadOnly = True

        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelBank.Visible = False
        SetFocus(btnSave)
    End Sub

    Private Sub ClearInputs()
        'centralized clearing of text boxes 
        'removes settings of readonly textboxes - usually set by ReadyEdit()
        'perform any housekeeping here

        ddlBank.Enabled = True
        txtBankBranch.Text = ""
        txtBankBranch.ReadOnly = False

        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelBank.Visible = False

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnCancel.Click

        panelForm.Visible = False

        panelInfo.Visible = True
        panelSuccess.Visible = False
        panelBank.Visible = False

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub

    Private Sub Cleanup_and_Rebind()

        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelBank.Visible = False

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
                    panelBank.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelBank.Visible = False

                    'reset and rebind                    
                    GridBind()

                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelBank.Visible = False

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
    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_BankBranch_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@bank_id", ddlBank.SelectedValue)
        objCommand.Parameters.Add("@name", txtBankBranch.Text)

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
        Dim objCommand As New SqlCommand("Ref_BankBranch_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@bank_id", ddlBank.SelectedValue)
        objCommand.Parameters.Add("@bank_branch", txtBankBranch.Text)
       
        'the returned new code 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.SmallInt)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of Banks
            objCommand = New SqlCommand("ref_bank_get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", ddlBank.SelectedValue)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strBank As String = objReader("name")
            objReader.Close()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "ID " + lblID.Text + " > Bank: " + strBank + " > BankBranch: " + txtBankBranch.Text, _
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
        Dim aColumns() As String = {"id", _
                                    "bank_name", _
                                    "bank_branch"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"ID", _
                                    "Bank", _
                                    "Bank Branch"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
                                     "", _
                                     ""}

        'the item display formats. pass "" to display as is
        Dim aFormats() As String = {"", _
                                    "", _
                                    ""}

        'the URL if you wish an item clickable, pass "" to disable.
        'Dim aURL() As String = {"", "", ""}

        'EndMODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        rasa.Sys_Class.DataGrid_ItemCreated(e, _
                                            aColumns, _
                                            aHeaders, _
                                            aSortKeys, _
                                            aDisableFields, _
                                            Session("SortKey"), _
                                            strSubMenuName, _
                                            Session("Sys_AccessList"))
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
        If txtSearch.Text = "" Then
            lblPageRecordCount.Text = lblPageRecordCount.Text & " *Please enter a search key."
            Exit Sub
        End If

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
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub btnAddBank_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddBank.Click
        txtBankFormAction.Text = "Add"
        lblBankMode.BackColor = Color.Green
        Cleanup_and_Rebind()

        lblBankID.Text = 0
        txtBank.Text = ""
        txtBankCode.Text = ""
        SetFocus(txtBank)

        'show the form panel
        panelBank.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'set the value based on desired action
        lblBankMode.Text = "<< " & txtBankFormAction.Text & " Bank Record >>"

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub

    Private Sub btnBankSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBankSave.Click

        If Not Page.IsValid Then
            Exit Sub
        End If

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateBankInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveBankInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                If txtBankFormAction.Text = "Add" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelBank.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtBankFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelBank.Visible = False

                    'reset and rebind                    
                    GridBind()

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                End If
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
    End Sub
    Private Function ValidateBankInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateBankInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Bank_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtBankFormAction.Text)
        objCommand.Parameters.Add("@id", lblBankID.Text)
        objCommand.Parameters.Add("@name", txtBank.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateBankInput = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveBankInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveBankInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Bank_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtBankFormAction.Text)
        objCommand.Parameters.Add("@id", lblBankID.Text)
        objCommand.Parameters.Add("@name", txtBank.Text)
        objCommand.Parameters.Add("@bank_code", txtBankCode.Text)

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
                                        strSubMenuName, _
                                        txtBank.Text + " > " + txtBankCode.Text, _
                                        objNewID.Value, _
                                        "0")

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveBankInput = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveBankInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub btnEditBank_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditBank.Click
        txtBankFormAction.Text = "Edit"
        lblBankMode.BackColor = Color.Orange
        Cleanup_and_Rebind()

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Bank_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", ddlBank.SelectedValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblBankID.Text = objReader("id")

        txtBank.Text = objReader("name")
        txtBankCode.Text = objReader("bank_code")
        objReader.Close()
        objConnection.Close()

        'show the form panel
        panelBank.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'set the value based on desired action
        lblBankMode.Text = "<< " & txtBankFormAction.Text & " Bank Record >>"

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
        SetFocus(txtBank)
    End Sub
End Class
