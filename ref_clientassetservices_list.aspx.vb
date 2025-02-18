
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class ref_clientassetservices_list
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
    Protected WithEvents lblClient As System.Web.UI.WebControls.Label
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlItemName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtBrand As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtModel As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSerial As System.Web.UI.WebControls.TextBox
    Protected WithEvents calAcquiredDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtUtilizedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPMSEvery As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCalEvery As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents calServicedDate As eWorld.UI.CalendarPopup    
    Protected WithEvents txtIssues As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlService As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtDetails As System.Web.UI.WebControls.TextBox
    Protected WithEvents calReportedDate As eWorld.UI.CalendarPopup
    Protected WithEvents calAccomplishedDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtAmount As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTechnician As System.Web.UI.WebControls.TextBox    
    Protected WithEvents chbDate As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblAccomplishedDate As System.Web.UI.WebControls.Label

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
    Public strStoredProc As String = "ref_clientassetservices_list"
    Public strSubMenuName As String = "ref_clientassetservices_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "id"
    Public strKeyField As String = "id"

    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green
        ClearInputs()
        'panelGrid.Visible = False

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        ReadyAdd()

    End Sub
    Private Sub ReadyAdd()

        ClearInputs()        

    End Sub
    Private Sub ClearInputs()

        calServicedDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calServicedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calServicedDate.Enabled = True

        txtIssues.Text = ""
        txtIssues.Enabled = True
               
        ddlService.Items.Insert(0, "")
        ddlService.SelectedIndex = 0
        ddlService.Enabled = True

        txtDetails.Text = ""
        txtDetails.Enabled = True

        calReportedDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calReportedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calReportedDate.Enabled = True

        chbDate.Checked = False
        chbDate.Visible = True
        chbDate.Enabled = True

        calAccomplishedDate.Visible = False
        calAccomplishedDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calAccomplishedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calAccomplishedDate.Enabled = True

        txtAmount.Text = 0
        txtAmount.Enabled = True

        txtTechnician.Text = ""
        txtTechnician.Enabled = True

        SetFocus(txtIssues)

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
        Dim objCommand As New SqlCommand("Ref_ClientAssetServices_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()                

        lblID.Text = Trim(objReader("id"))

        calReportedDate.SelectedDate = Trim(objReader("reported_date"))
        calReportedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calServicedDate.SelectedDate = Trim(objReader("serviced_date"))
        calServicedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        txtIssues.Text = Trim(objReader("issues"))
        ddlService.SelectedValue = Trim(objReader("service_rendered"))
        txtDetails.Text = Trim(objReader("details"))

        If Trim(objReader("accomplished_date")) = "1/1/1999" Then
            chbDate.Checked = False
            chbDate.Visible = True
            calAccomplishedDate.Visible = False
            calAccomplishedDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString            
            calAccomplishedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString

            calReportedDate.Enabled = True
            calServicedDate.Enabled = True
            txtIssues.Enabled = True
            ddlService.Enabled = True
            txtDetails.Enabled = True
            txtAmount.Enabled = True
            txtTechnician.Enabled = True
        Else
            chbDate.Checked = True
            chbDate.Visible = False
            calAccomplishedDate.Visible = True
            calAccomplishedDate.SelectedDate = Trim(objReader("accomplished_date"))
            calAccomplishedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString

            calReportedDate.Enabled = False
            calServicedDate.Enabled = False
            txtIssues.Enabled = False
            ddlService.Enabled = False
            txtDetails.Enabled = False
            txtAmount.Enabled = False
            txtTechnician.Enabled = False
        End If

        txtAmount.Text = Trim(objReader("amount"))
        txtTechnician.Text = Trim(objReader("technician"))
        objReader.Close()
        objConnection.Close()

        SetFocus(txtIssues)

    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientAssetServices_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@customer", Request("client"))
        objCommand.Parameters.Add("@clientasset_id", Request("id"))
        objCommand.Parameters.Add("@serviced_date", calServicedDate.SelectedDate)
        objCommand.Parameters.Add("@issues", txtIssues.Text)
        objCommand.Parameters.Add("@service_rendered", ddlService.SelectedValue)
        objCommand.Parameters.Add("@details", txtDetails.Text)
        objCommand.Parameters.Add("@reported_date", calReportedDate.SelectedDate)

        If chbDate.Checked = False Then
            objCommand.Parameters.Add("@accomplished_date", "1/1/1999")
        Else
            objCommand.Parameters.Add("@accomplished_date", calAccomplishedDate.SelectedDate)
        End If
        
        objCommand.Parameters.Add("@amount", txtAmount.Text)
        objCommand.Parameters.Add("@technician", txtTechnician.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

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
                                        "Ref_Clients_List", _
                                        "ServicedDate: " + calServicedDate.SelectedDate + " > Issues: " + txtIssues.Text + " > ServiceRenderd: " + ddlService.SelectedValue + " > Details: " + txtDetails.Text + " > ReportedDate: " + calReportedDate.SelectedDate + " > AccomplishedDate: " + calAccomplishedDate.SelectedDate + " > Amount: " + txtAmount.Text + " > Technician: " + txtTechnician.Text, _
                                        Request("id"), _
                                        0)

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
        Dim objCommand As New SqlCommand("Ref_ClientAssetServices_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@amount", txtAmount.Text)        
        objCommand.Parameters.Add("@id", lblID.Text)

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
                                    "accomplished_date", _
                                    "reported_date", _
                                    "serviced_date", _
                                    "issues", _
                                    "service_rendered", _
                                    "details", _                                                                        
                                    "amount", _
                                    "technician"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Accomplished Date", _
                                    "Date Reported", _
                                    "Date Visited", _
                                    "Issues/Concerns", _
                                    "Service Rendered", _
                                    "Details", _
                                    "Amount", _
                                    "Technician"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    "DS", _
                                    "DS", _
                                    "DS", _
                                    "", _
                                    "", _
                                    "", _
                                    "N2", _
                                    ""}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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
            DisplayClient()
            DisplayHeader()
            GridBind()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddImg.Visible = False
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
                                    Request("id"))

    End Sub
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
                    panelGrid.Visible = True

                    'Session("last_isdtl_sku") = ddlSKU.SelectedValue
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
        'panelGrid.Visible = False

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

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientAssets_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()        

        Dim bolChangeable As Boolean = Trim(objReader("total_service")) <= 0

        Dim strAsset As String = Trim(objReader("asset"))

        lblAccomplishedDate.Text = Trim(objReader("last_check"))

        ddlStatus.SelectedValue = Trim(objReader("status"))
        ddlStatus.Enabled = bolChangeable

        txtDesc.Text = Trim(objReader("description"))
        txtDesc.Enabled = bolChangeable

        ddlType.SelectedValue = Trim(objReader("type"))
        ddlType.Enabled = bolChangeable

        txtBrand.Text = Trim(objReader("brand"))
        txtBrand.Enabled = bolChangeable

        txtModel.Text = Trim(objReader("model"))
        txtModel.Enabled = bolChangeable

        txtSerial.Text = Trim(objReader("serial"))
        txtSerial.Enabled = bolChangeable

        calAcquiredDate.SelectedDate = Trim(objReader("acquired_date"))
        calAcquiredDate.Enabled = bolChangeable

        txtUtilizedBy.Text = Trim(objReader("utilized_by"))
        txtUtilizedBy.Enabled = bolChangeable

        txtPMSEvery.Text = Trim(objReader("pms_frequency"))
        txtPMSEvery.Enabled = bolChangeable

        txtCalEvery.Text = Trim(objReader("cal_frequency"))
        txtCalEvery.Enabled = bolChangeable

        txtNote.Text = Trim(objReader("note"))
        txtNote.Enabled = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_Assets_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlItemName.DataSource = objReader
        ddlItemName.DataValueField = "code"
        ddlItemName.DataTextField = "name"
        ddlItemName.DataBind()
        ddlItemName.Enabled = bolChangeable
        objReader.Close()

        ddlItemName.SelectedIndex = ddlItemName.Items.IndexOf(ddlItemName.Items.FindByValue(strAsset.ToString))        
        objConnection.Close()

    End Sub
    Sub DisplayClient()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Clients_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", Request("client"))
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblClient.Text = Trim(objReader("name"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("ref_clientassets_list?id=" & Request("client") & "&sys_table=Ref_Clients_List")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub
    Private Sub btnSaveImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveImg.Click
        SaveHeaderClick()

    End Sub
    Private Function SaveHeaderClick()
        'validate the inputs vs. table records
        Dim strValidateHeader As String = ValidateHeader()

        'is the validation 
        If strValidateHeader = "ok" Then
            'then save the inputs
            Dim strSaveHeader As String = SaveHeader()

            'is the saving successfull?
            If strSaveHeader = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                lblValidate.Visible = False
                panelGrid.Visible = True

                'reset and rebind       
                DataGrid.SelectedIndex = -1
                GridBind()
                DisplayHeader()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveHeader
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateHeader
        End If
    End Function
    Private Function ValidateHeader()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateHeader = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientAssets_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@serial", txtSerial.Text)
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateHeader = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveHeader()
        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveHeader = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientAssets_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@customer", Request("client"))
        objCommand.Parameters.Add("@asset", ddlItemName.SelectedValue)
        objCommand.Parameters.Add("@description", txtDesc.Text)
        objCommand.Parameters.Add("@type", ddlType.SelectedValue)
        objCommand.Parameters.Add("@brand", txtBrand.Text)
        objCommand.Parameters.Add("@model", txtModel.Text)
        objCommand.Parameters.Add("@serial", txtSerial.Text)
        objCommand.Parameters.Add("@acquired_date", calAcquiredDate.SelectedDate)
        objCommand.Parameters.Add("@utilized_by", txtUtilizedBy.Text)        
        objCommand.Parameters.Add("@note", txtNote.Text)
        objCommand.Parameters.Add("@pms_frequency", txtPMSEvery.Text)
        objCommand.Parameters.Add("@cal_frequency", txtCalEvery.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        'the returned new code 
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
                                        "Status: " + ddlStatus.SelectedValue + " > Name: " + ddlItemName.SelectedValue + " > Desc: " + txtDesc.Text + " > Type: " + ddlType.SelectedValue, _
                                        objNewID.Value, _
                                        "0")

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveHeader = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveHeader = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try
    End Function

    Private Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlStatus.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlItemName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlItemName.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtDesc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtBrand_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrand.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtModel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModel.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSerial_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerial.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlType.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub calAcquiredDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calAcquiredDate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtUtilizedBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUtilizedBy.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtPMSEvery_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPMSEvery.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtCalEvery_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCalEvery.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        If chbDate.Checked = True Then
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calAccomplishedDate.Visible = True

            SetFocus(txtIssues)
        Else
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calAccomplishedDate.Visible = False

            SetFocus(txtIssues)
        End If
    End Sub

End Class

