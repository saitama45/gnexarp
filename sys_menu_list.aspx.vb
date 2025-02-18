
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState


Public Class sys_Menu_list
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
    Protected WithEvents txtCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents ValidationSummary2 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefault_Screen As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid    
    Protected WithEvents ddlMainMenu As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtSub_Menu As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLink_Page As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLink_Parameter As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSubMenuSortOrder As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
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
    Protected WithEvents btnAddMainMenu As System.Web.UI.WebControls.Button
    Protected WithEvents panelMainMenu As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMainMenuMode As System.Web.UI.WebControls.Label
    Protected WithEvents txtMainMenuFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMainMenuID As System.Web.UI.WebControls.Label
    Protected WithEvents txtMainMenuName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMainMenuCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSortOrder As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSaveMainMenu As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancelMainMenu As System.Web.UI.WebControls.Button
    Protected WithEvents lblMainMenuMessage As System.Web.UI.WebControls.Label
    

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
    Public strStoredProc As String = "Sys_Menu_List"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "id"
    Public strKeyField As String = "id"


    Private Sub ReadyEdit()
        
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Menu_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()        

        lblID.Text = objReader("id")
        txtCode.Text = Trim(objReader("code"))        
        txtSub_Menu.Text = Trim(objReader("sub_menu"))
        txtLink_Page.Text = Trim(objReader("link_page"))
        txtLink_Parameter.Text = Trim(objReader("link_parameter"))
        txtSubMenuSortOrder.Text = Trim(objReader("sort_order"))

        Dim strMainMenu As String = objReader("main_menu_id")

        objReader.Close()

        'get the list of Main Menu
        objCommand = New SqlCommand("Sys_MainMenu_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objReader = objCommand.ExecuteReader
        ddlMainMenu.DataSource = objReader
        ddlMainMenu.DataValueField = "id"
        ddlMainMenu.DataTextField = "name"
        ddlMainMenu.DataBind()
        ddlMainMenu.SelectedIndex = ddlMainMenu.Items.IndexOf(ddlMainMenu.Items.FindByValue(strMainMenu))
        ddlMainMenu.Enabled = True
        objReader.Close()
        objConnection.Close()

        txtCode.Enabled = True
        txtSub_Menu.Enabled = True
        txtLink_Page.Enabled = True
        txtLink_Parameter.Enabled = True
        txtSubMenuSortOrder.Enabled = True

    End Sub


    Private Sub ReadyDelete()      

        'retrieve and fill in the panel record textboxes for editing
        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Menu_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()
        lblID.Text = objReader("id")
        txtCode.Text = Trim(objReader("code"))        
        txtSub_Menu.Text = Trim(objReader("sub_menu"))
        txtLink_Page.Text = Trim(objReader("link_page"))
        txtLink_Parameter.Text = Trim(objReader("link_parameter"))
        txtSubMenuSortOrder.Text = Trim(objReader("sort_order"))

        Dim strMainMenu As String = objReader("main_menu_id")

        objReader.Close()

        'get the list of Main Menu
        objCommand = New SqlCommand("Sys_MainMenu_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objReader = objCommand.ExecuteReader
        ddlMainMenu.DataSource = objReader
        ddlMainMenu.DataValueField = "id"
        ddlMainMenu.DataTextField = "name"
        ddlMainMenu.DataBind()
        ddlMainMenu.SelectedIndex = ddlMainMenu.Items.IndexOf(ddlMainMenu.Items.FindByValue(strMainMenu))
        ddlMainMenu.Enabled = False
        objReader.Close()
        objConnection.Close()

        'protect the textboxes 
        txtCode.Enabled = False
        txtSub_Menu.Enabled = False
        txtLink_Page.Enabled = False
        txtLink_Parameter.Enabled = False
        txtSubMenuSortOrder.Enabled = False
    End Sub


    Private Sub ClearInputs()
        'centralized clearing of text boxes 
        'removes settings of readonly textboxes - usually set by ReadyEdit()
        'perform any housekeeping here

        lblID.Text = 0
        txtCode.Text = ""
        txtCode.Enabled = True

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        'get the list of Main Menu
        Dim objCommand As New SqlCommand("Sys_MainMenu_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@id", 0)
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlMainMenu.DataSource = objReader
        ddlMainMenu.DataValueField = "id"
        ddlMainMenu.DataTextField = "name"
        ddlMainMenu.DataBind()
        ddlMainMenu.Enabled = True
        objReader.Close()
        objConnection.Close()

        txtSub_Menu.Text = ""
        txtSub_Menu.Enabled = True

        txtLink_Page.Text = ""
        txtLink_Page.Enabled = True

        txtLink_Parameter.Text = ""
        txtLink_Parameter.Enabled = True

        txtSubMenuSortOrder.Text = ""
        txtSubMenuSortOrder.Enabled = True

    End Sub

    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_Menu_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@Code", txtCode.Text)
        objCommand.Parameters.Add("@Main_Menu", ddlMainMenu.SelectedValue)
        objCommand.Parameters.Add("@Sub_Menu", txtSub_Menu.Text)
        objCommand.Parameters.Add("@Link_Page", txtLink_Page.Text)
        objCommand.Parameters.Add("@Sort_Order", txtSubMenuSortOrder.Text)

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
        Dim objCommand As New SqlCommand("Sys_Menu_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@Code", txtCode.Text)
        objCommand.Parameters.Add("@Sys_MainMenu", ddlMainMenu.SelectedValue)
        objCommand.Parameters.Add("@Sub_Menu", txtSub_Menu.Text)
        objCommand.Parameters.Add("@Link_Page", txtLink_Page.Text)
        objCommand.Parameters.Add("@Link_Parameter", txtLink_Parameter.Text)
        objCommand.Parameters.Add("@Sort_Order", txtSubMenuSortOrder.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of Main Menu
            objCommand = New SqlCommand("sys_mainmenu_get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", ddlMainMenu.SelectedValue)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strMainMenu As String = objReader("name")

            objReader.Close()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strStoredProc, _
                                        txtCode.Text + " > " + strMainMenu + " > " + txtSub_Menu.Text + " > " + txtLink_Page.Text + " > " + txtSubMenuSortOrder.Text, _
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
                                    "code", _
                                    "main_menu", _
                                    "sub_menu", _
                                    "link_page", _
                                    "link_parameter", _
                                    "sort_order", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}

        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"ID", _
                                    "Code", _
                                    "Main Menu", _
                                    "Sub Menu", _
                                    "Link Page", _
                                    "Link Parameter", _
                                    "Sort Order", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"id", _
                                    "code", _
                                    "main_menu", _
                                    "sub_menu", _
                                    "", _
                                    "", _
                                    "sort_order", _
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

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage")
        End If

        'is the user allowed to add record?
        If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
            'disable the add button
            btnAddRecord.Enabled = False
        End If

        If Not Page.IsPostBack Then

            GridBind()

            btnCancel.Attributes("onclick") = "return confirm('Cancel?');"
            btnCancelMainMenu.Attributes("onclick") = "return confirm('Cancel?');"
            txtFormAction.Visible = False 'always hide this
            txtMainMenuFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = True
            hlViewFullTrail.NavigateUrl = "trx_fullhistory?sys_table=" & strStoredProc & "&mode=2&ID=0"
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
        panelMainMenu.Visible = False
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
        panelMainMenu.Visible = False

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
        panelMainMenu.Visible = False

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

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False

                    'reset and rebind                    
                    GridBind()

                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False

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
        panelMainMenu.Visible = False
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
        panelMainMenu.Visible = False
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
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub btnAddMainMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddMainMenu.Click      

        txtMainMenuFormAction.Text = "Add"
        lblMainMenuMode.BackColor = Color.Green
        Cleanup_and_Rebind()

        lblMainMenuID.Text = 0
        txtMainMenuName.Text = ""
        txtMainMenuCode.Text = ""
        txtSortOrder.Text = ""
        SetFocus(txtMainMenuName)

        'show the form panel
        panelMainMenu.Visible = True        

        lblMainMenuMessage.Visible = False
        ValidationSummary2.Visible = True

        'set the value based on desired action
        lblMainMenuMode.Text = "<< " & txtMainMenuFormAction.Text & " Main Menu Record >>"

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub

    Private Sub btnSaveMainMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveMainMenu.Click

        'always hide, but show later in this module
        lblMainMenuMessage.Visible = False

        If Not Page.IsValid Then
            Exit Sub
        End If

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateMainMenuInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveMainMenuInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes
                lblMainMenuMessage.Visible = True

                If txtMainMenuFormAction.Text = "Add" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelMainMenu.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtMainMenuFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelMainMenu.Visible = False

                    'reset and rebind                    
                    GridBind()

                ElseIf txtMainMenuFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelMainMenu.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                End If
            Else
                'notify unsucessful and the reason
                lblMainMenuMessage.Visible = True
                lblMainMenuMessage.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            lblMainMenuMessage.Visible = True
            lblMainMenuMessage.Text = strValidateInput
        End If
    End Sub
    Private Function ValidateMainMenuInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateMainMenuInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_MainMenu_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@MainMenuName", txtMainMenuName.Text)
        objCommand.Parameters.Add("@MainMenuCode", txtMainMenuCode.Text)
        objCommand.Parameters.Add("@SortOrder", txtSortOrder.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateMainMenuInput = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function

    Private Function SaveMainMenuInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveMainMenuInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Sys_MainMenu_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@MainMenuName", txtMainMenuName.Text)
        objCommand.Parameters.Add("@MainMenuCode", txtMainMenuCode.Text)
        objCommand.Parameters.Add("@SortOrder", txtSortOrder.Text)
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
                                        "Sys_MainMenu", _
                                        txtMainMenuName.Text + " > " + txtMainMenuCode.Text + " > " + txtSortOrder.Text, _
                                        objNewID.Value, _
                                        "0")

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveMainMenuInput = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveMainMenuInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub btnCancelMainMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelMainMenu.Click
        panelForm.Visible = False
        panelMainMenu.Visible = False

        panelInfo.Visible = True
        panelSuccess.Visible = False

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub
End Class
