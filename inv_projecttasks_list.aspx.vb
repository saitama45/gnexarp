
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_projecttasks_list
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
    Protected WithEvents btnX As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button    
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid    
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents hlViewFullHistory As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid As System.Web.UI.WebControls.Panel
    Protected WithEvents panelRecent As System.Web.UI.WebControls.Panel
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
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtTaskDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents calStartDate As eWorld.UI.CalendarPopup
    Protected WithEvents calEndDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtAssignedTo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTeamLead As System.Web.UI.WebControls.TextBox
    Protected WithEvents calCompletedDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblSONo As System.Web.UI.WebControls.Label    
    Protected WithEvents lblProjectName As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomer As System.Web.UI.WebControls.Label
    Protected WithEvents txtNoteHDR As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblProjectAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblBudget As System.Web.UI.WebControls.Label    
    Protected WithEvents chbCompletedDate As System.Web.UI.WebControls.CheckBox
    Protected WithEvents btnPrint As System.Web.UI.WebControls.LinkButton

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
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList

    'START MODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    'the stored proc to call
    Public strStoredProc As String = "inv_projecttasks_list"
    Public strSubMenuName As String = "inv_projecttasks_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "id"
    Public strKeyField As String = "id"
    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green
        btnSave.Text = "Add"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        ClearInputs()

        SetFocus(txtTaskDesc)
    End Sub
    
    Private Sub ClearInputs()

        ddlStatus.Enabled = True

        txtTaskDesc.Text = ""
        txtTaskDesc.Enabled = True

        calStartDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calStartDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calStartDate.Enabled = True

        calEndDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calEndDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calEndDate.Enabled = True

        txtAssignedTo.Text = ""
        txtAssignedTo.Enabled = True

        txtTeamLead.Text = ""
        txtTeamLead.Enabled = True

        txtNote.Text = ""
        txtNote.Enabled = True

        chbCompletedDate.Checked = False
        chbCompletedDate.Enabled = True

        calCompletedDate.Visible = False

        SetFocus(txtTaskDesc)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()

    End Sub
    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProjectTasks_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = Trim(objReader("status")) <> "COMPLETED"

        lblID.Text = Trim(objReader("id"))

        ddlStatus.SelectedValue = Trim(objReader("status"))
        ddlStatus.Enabled = bolChangeable

        txtTaskDesc.Text = Trim(objReader("task_desc"))
        txtTaskDesc.Enabled = bolChangeable

        calStartDate.SelectedDate = Trim(objReader("start_date"))
        calStartDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calStartDate.Enabled = bolChangeable

        calEndDate.SelectedDate = Trim(objReader("end_date"))
        calEndDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calEndDate.Enabled = bolChangeable

        txtAssignedTo.Text = Trim(objReader("assigned_to"))
        txtAssignedTo.Enabled = bolChangeable

        txtTeamLead.Text = Trim(objReader("team_lead"))
        txtTeamLead.Enabled = bolChangeable

        If Trim(objReader("completed_date")) = "1/1/1999" Then
            chbCompletedDate.Checked = False
            calCompletedDate.Visible = False            
        Else
            chbCompletedDate.Checked = True
            calCompletedDate.Visible = True
            calCompletedDate.SelectedDate = Trim(objReader("completed_date"))
            calCompletedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        End If
        chbCompletedDate.Enabled = bolChangeable
        calCompletedDate.Enabled = bolChangeable

        'If Trim(objReader("status")) <> "COMPLETED" Then
        '    chbCompletedDate.Enabled = True
        '    calCompletedDate.Enabled = True
        'Else
        '    chbCompletedDate.Enabled = False
        '    calCompletedDate.Enabled = False
        'End If

        txtNote.Text = Trim(objReader("note"))
        txtNote.Enabled = bolChangeable

        objReader.Close()
        objConnection.Close()

        SetFocus(txtTaskDesc)

    End Sub

    Private Sub ReadyDelete()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProjectTasks_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))

        ddlStatus.SelectedValue = Trim(objReader("status"))
        ddlStatus.Enabled = False

        txtTaskDesc.Text = Trim(objReader("task_desc"))
        txtTaskDesc.Enabled = False

        calStartDate.SelectedDate = Trim(objReader("start_date"))
        calStartDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calStartDate.Enabled = False

        calEndDate.SelectedDate = Trim(objReader("end_date"))
        calEndDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calEndDate.Enabled = False

        txtAssignedTo.Text = Trim(objReader("assigned_to"))
        txtAssignedTo.Enabled = False

        txtTeamLead.Text = Trim(objReader("team_lead"))
        txtTeamLead.Enabled = False

        If Trim(objReader("completed_date")) = "1/1/1999" Then
            chbCompletedDate.Checked = False
            calCompletedDate.Visible = False
        Else
            chbCompletedDate.Checked = True
            calCompletedDate.Visible = True
            calCompletedDate.SelectedDate = Trim(objReader("completed_date"))
            calCompletedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        End If
        chbCompletedDate.Enabled = False
        calCompletedDate.Enabled = False

        txtNote.Text = Trim(objReader("note"))
        txtNote.Enabled = False

        If Trim(objReader("status")) <> "PENDING" Then
            btnSave.Visible = False
        Else
            btnSave.Visible = True
        End If

        objReader.Close()
        objConnection.Close()

        SetFocus(btnSave)


    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProjectTasks_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@so_no", lblSONo.Text)
        objCommand.Parameters.Add("@task_desc", txtTaskDesc.Text)
        objCommand.Parameters.Add("@start_date", calStartDate.SelectedDate)
        objCommand.Parameters.Add("@end_date", calEndDate.SelectedDate)
        objCommand.Parameters.Add("@assigned_to", txtAssignedTo.Text)
        objCommand.Parameters.Add("@team_lead", txtTeamLead.Text)
        objCommand.Parameters.Add("@note", txtNote.Text)

        If chbCompletedDate.Checked = True Then
            objCommand.Parameters.Add("@completed_date", calCompletedDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@completed_date", "1/1/1999")
        End If

        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            ''save to audit trail 
            'Sys_Class.SaveToAuditTrail(Session("username"), _
            '                            txtFormAction.Text, _
            '                            Request("sys_table"), _
            '                            "TaskDesc: " + txtTaskDesc.Text, _
            '                            Request("id"), _
            '                            0)

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
        Dim objCommand As New SqlCommand("Inv_ProjectTasks_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@task_desc", txtTaskDesc.Text)
        objCommand.Parameters.Add("@start_date", calStartDate.SelectedDate)

        If chbCompletedDate.Checked = True Then
            objCommand.Parameters.Add("@completed_date", calCompletedDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@completed_date", "1/1/1999")
        End If

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
                                    "status", _
                                    "start_date", _
                                    "end_date", _
                                    "task_desc", _
                                    "assigned_to", _
                                    "team_lead", _
                                    "note", _
                                    "aging", _
                                    "completed_date", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Status", _
                                    "Start Date", _
                                    "End Date", _
                                    "Task", _
                                    "Assigned To", _
                                    "PM / TL", _
                                    "Details", _
                                    "Aging", _
                                    "Completed Date", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
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

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "DS", _
                                    "DS", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "N0", _
                                    "DS", _
                                    "", _
                                    "D", _
                                    "", _
                                    "D"}


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
        'Dim aFormats() As String = {"", "", ""}

        'the URL if you wish an item clickable, pass "" to disable.
        'Dim aURL() As String = {"", "", ""}

        'EndMODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        srx.Sys_Class.DataGrid_ItemCreated_v2(e, _
                                            aColumns, _
                                            aHeaders, _
                                            aFormats, _
                                            aSortKeys, _
                                            aFooters, _
                                            aEnableFields_List, _
                                            aEnableFields_Format, _
                                            aEnableFields_Footer, _
                                            Session("SortKey"), _
                                            strStoredProc, _
                                            Session("Sys_AccessList"), _
                                            "", _
                                            DataGrid)
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

        If Not Page.IsPostBack Then
            DisplayHeader()
            GridBind()
            TriggerStatus()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False
            txtSearch.Visible = False
            btnSearch.Visible = False
            btnAddRecord.Visible = False
            btnSaveImg.Visible = False

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button                
                btnAddImg.Visible = False                
                btnPrintImg.Visible = False
                btnSaveImg.Visible = False                
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
                                    lblPageRecordCount, _
                                    lblSONo.Text)

    End Sub
    Private Function TriggerStatus()

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProjectTasks_Delayed", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@so_no", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblSONo.Text = Trim(objReader("so_no"))      

        objReader.Close()
        objConnection.Close()

        GridBind()

    End Function
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
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

    Private Sub Cleanup_and_Rebind()
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelGrid.Visible = True

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSave.Click

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                If txtFormAction.Text = "Add" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    lblValidate.Visible = False

                    ClearInputs()
                    DisplayHeader()
                    txtPageNo.Text = 1
                    GridBind()


                ElseIf txtFormAction.Text = "Edit" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False
                    panelGrid.Visible = True

                    'reset and rebind       
                    txtPageNo.Text = 1
                    DisplayHeader()
                    GridBind()


                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False
                    panelGrid.Visible = True

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    txtPageNo.Text = 1
                    GridBind()
                    DisplayHeader()

                End If

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateInput
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If


    End Sub


    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.ForeColor = Color.Orange
        btnSave.Text = "Save"

        'show the Form panel
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

        'show the Form panel
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
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').select() </SCRIPT>"
        RegisterStartupScript("select", s)
    End Sub

    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Projects_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@so_no", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblSONo.Text = Trim(objReader("so_no"))

        lblProjectName.Text = Trim(objReader("project_desc"))
        lblCustomer.Text = Trim(objReader("customer"))
        lblProjectAmount.Text = Trim(objReader("net_sales_show"))
        lblBudget.Text = Trim(objReader("budget_amount_show"))
        txtNoteHDR.Text = Trim(objReader("note"))

        objReader.Close()
        objConnection.Close()

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub

    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_Projects_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@so_no", lblSONo.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        'SetEndPopup("trx_pt_form?code=" & lblSONo.Text & _
        '        " &id=" & Request("id") & _
        '        " &formaction=" & "Print")

        SetEndPopup("gantt_chart?code=" & lblSONo.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_projecttasks_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_projects_list")
    End Sub

    Private Sub chbCompletedDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbCompletedDate.CheckedChanged
        If chbCompletedDate.Checked = True Then
            calCompletedDate.Visible = True
            calCompletedDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString
            calCompletedDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString
        Else
            calCompletedDate.Visible = False
        End If
    End Sub
End Class

