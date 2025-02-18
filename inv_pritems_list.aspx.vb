
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_pritems_list
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
    Protected WithEvents btnShowPreviousPO As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid3 As System.Web.UI.WebControls.DataGrid
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
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnPrint As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPRRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblDueDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorName As System.Web.UI.WebControls.Label
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblCancelledBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblCancelledDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblFulfilledBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblFulfilledDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblEmail As System.Web.UI.WebControls.Label
    Protected WithEvents lblTerms As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalCost As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscount As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscountedAmount As System.Web.UI.WebControls.Label
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblRecentPODate As System.Web.UI.WebControls.Label
    Protected WithEvents lblRecentPOQty As System.Web.UI.WebControls.Label
    Protected WithEvents lblRecentPOCost As System.Web.UI.WebControls.Label
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnReplicate As System.Web.UI.WebControls.LinkButton
    Protected WithEvents calPODate As eWorld.UI.CalendarPopup
    Protected WithEvents calDueDate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlVendor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtRequestedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnLCost As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImportImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnReplicateImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ddlCurrency As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtCurrentForex As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPRID As System.Web.UI.WebControls.Label
    Protected WithEvents btnPrintRR As System.Web.UI.WebControls.LinkButton
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnCompleted As System.Web.UI.WebControls.LinkButton
    Protected WithEvents txtCostImport As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelGrid2 As System.Web.UI.WebControls.Panel
    Protected WithEvents btnAddImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnBackImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    Protected WithEvents panelForm2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMode2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtFormAction2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnX2 As System.Web.UI.WebControls.Button
    Protected WithEvents lblID2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtSKUCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtItemDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPOQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPOUnitCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSave2 As System.Web.UI.WebControls.Button
    Protected WithEvents lblPRItemsID As System.Web.UI.WebControls.Label
    Protected WithEvents chbDueDate As System.Web.UI.WebControls.CheckBox
    Protected WithEvents btnPrintLocal As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnPrintImport As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnPrintItemized As System.Web.UI.WebControls.LinkButton
    Protected WithEvents chbIsVatExclusive As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbIsNonVat As System.Web.UI.WebControls.CheckBox

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
    Public strStoredProc As String = "inv_pritems_list"
    Public strSubMenuName As String = "inv_pritems_list"
    Public strStoredProc2 As String = "ref_venitems_list"
    Public strStoredProc3 As String = "Inv_PRSubItems_List"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"    
    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblStatus.Text = "ON PROCESS" Then
            txtFormAction.Text = "Add"
            lblMode.ForeColor = Color.Green
            'panelGrid.Visible = False
            btnsave.text = "Add"

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)

            ReadyAdd()
        Else
            If Session("group") = "ADMIN" Then
                txtFormAction.Text = "Add"
                lblMode.ForeColor = Color.Green
                'panelGrid.Visible = False
                btnsave.text = "Add"

                'show the Form panel
                Sys_Class.ReadyForm(panelForm, _
                                        panelSuccess, _
                                        panelInfo, _
                                        lblMessage, _
                                        ValidationSummary1, _
                                        lblMode, _
                                        txtFormAction)

                ReadyAdd()
            Else
                btnAddImg.Visible = False
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If
        End If

        SetFocus(ddlRawMats)
    End Sub
    Private Sub ReadyAdd()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_VenItems_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@vendor", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Items.Insert(0, "")
        ddlRawMats.SelectedIndex = 0
        objReader.Close()
        objConnection.Close()

        Refresh_RecentPO()

        ClearInputs()

    End Sub
    Private Sub ClearInputs()

        txtBarcode.Text = ""
        txtBarcode.Enabled = True

        txtQty.Text = 0
        txtQty.Enabled = True

        txtCost.Text = 0
        txtCost.Enabled = True

        txtCostImport.Text = 0
        txtCostImport.Enabled = True

        ddlRawMats.Enabled = True

        SetFocus(ddlRawMats)

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
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strRawMats As String = objReader("rm_code")

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        If Session("group") = "ADMIN" Then
            lblID.Text = Trim(objReader("id"))
            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = True

            txtCost.Text = Trim(objReader("cost"))
            txtCost.Enabled = True

            txtCostImport.Text = Trim(objReader("cost_import"))
            txtCostImport.Enabled = True

            objReader.Close()

            objCommand = New SqlCommand("Ref_VenItems_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@vendor", ddlVendor.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            ddlRawMats.DataSource = objReader
            ddlRawMats.DataValueField = "code"
            ddlRawMats.DataTextField = "name"
            ddlRawMats.DataBind()
            ddlRawMats.Enabled = True
            objReader.Close()

        Else
            lblID.Text = Trim(objReader("id"))
            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = bolChangeable

            txtCost.Text = Trim(objReader("cost"))
            txtCost.Enabled = bolChangeable

            txtCostImport.Text = Trim(objReader("cost_import"))
            txtCostImport.Enabled = bolChangeable

            objReader.Close()

            objCommand = New SqlCommand("Ref_VenItems_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@vendor", ddlVendor.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            ddlRawMats.DataSource = objReader
            ddlRawMats.DataValueField = "code"
            ddlRawMats.DataTextField = "name"
            ddlRawMats.DataBind()
            ddlRawMats.Enabled = bolChangeable
            objReader.Close()

        End If

        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))        

        SetFocus(ddlRawMats)


    End Sub


    Private Sub ReadyDelete()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))
        txtQty.Text = Trim(objReader("qty"))
        txtQty.Enabled = False

        txtCost.Text = Trim(objReader("cost"))
        txtCost.Enabled = False

        txtCostImport.Text = Trim(objReader("cost_import"))
        txtCostImport.Enabled = False

        Dim strRawMats As String = objReader("rm_code")

        objReader.Close()

        objCommand = New SqlCommand("Ref_VenItems_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@vendor", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        objReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Enabled = False
        objReader.Close()

        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

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
        Dim objCommand As New SqlCommand("Inv_PRItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objCommand.Parameters.Add("@vendor_code", lblVendorCode.Text)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@cost", txtCost.Text)
        objCommand.Parameters.Add("@cost_import", txtCostImport.Text)
        objCommand.Parameters.Add("@currency", ddlCurrency.SelectedValue)
        objCommand.Parameters.Add("@current_forex", txtCurrentForex.Text)
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
                                        Request("sys_table"), _
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text + " > Cost: " + txtCost.Text, _
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
        Dim objCommand As New SqlCommand("Inv_PRItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
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
                                    "barcode", _
                                    "brand", _
                                    "rm_name", _
                                    "uom", _
                                    "qty", _
                                    "cost", _
                                    "total_cost", _
                                    "rm_code", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Barcode", _
                                    "Brand", _
                                    "Item", _
                                    "UOM", _
                                    "Qty", _
                                    "Cost", _
                                    "Total Cost", _
                                    "Item Code", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "_COUNT_RECORD_", _                                    
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "", _
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
                                            lblStatus.Text, _
                                            DataGrid)
    End Sub
    Private Sub DataGrid2_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "barcode", _
                                    "rm_code", _
                                    "rm_name", _
                                    "uom", _
                                    "cost", _
                                    "qty"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Barcode", _
                                    "Item Code", _
                                    "Item", _
                                    "UOM", _
                                    "Cost", _
                                    "Qty"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_"}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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
                                            strStoredProc2, _
                                            Session("Sys_AccessList"), _
                                            "", _
                                            DataGrid2)
    End Sub
    Private Sub DataGrid3_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid3.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"main_item", _
                                    "sku_code", _
                                    "item_desc", _
                                    "qty", _
                                    "unit_cost", _
                                    "total_cost", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Main Item", _
                                    "Part No.", _
                                    "Item Desc", _
                                    "Qty", _
                                    "Unit Price", _
                                    "Total Price", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "", _
                                    "", _
                                    "", _
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
                                            lblStatus.Text, _
                                            DataGrid3)
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

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False
            txtSearch.Visible = False
            btnSearch.Visible = False
            btnAddRecord.Visible = False
            btnPrint.Visible = False

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button                
                btnAddImg.Visible = False
                btnReplicateImg.Visible = False

                'btnPrintImg.Visible = False
                btnPrintLocal.Visible = False

                'btnPrintImportImg.Visible = False
                btnPrintImport.Visible = False

                btnPrintItemized.Visible = False

                btnSaveImg.Visible = False
                btnLCost.Visible = False
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
                                    lblPRID.Text)

    End Sub
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub DataGrid2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub DataGrid3_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid3.ItemDataBound
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

        If txtQty.Text = Nothing Or txtQty.Text.Length > 0 And txtQty.Text.Trim().Length = 0 Then 'txtName.Text.Length > 0 And txtName.Text.Trim().Length = 0 to handle empty and white spaces
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = "Cost is required."
            panelSuccess.Visible = False

        Else

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
                        'panelForm.Visible = False
                        lblValidate.Visible = False
                        'panelGrid.Visible = True

                        Session("last_isdtl_sku") = ddlRawMats.SelectedValue
                        ReadyAdd()
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
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If


    End Sub


    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.EditCommand

        If lblStatus.Text = "ON PROCESS" Then

            'mark the selected item 
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Edit"
            lblMode.ForeColor = Color.Orange
            'panelGrid.Visible = False
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
        Else
            If Session("group") = "ADMIN" Then
                'mark the selected item 
                DataGrid.SelectedIndex = e.Item.ItemIndex

                txtFormAction.Text = "Edit"
                lblMode.ForeColor = Color.Orange
                'panelGrid.Visible = False
                btnSave.Text = "Add"

                'show the Form panel
                Sys_Class.ReadyForm(panelForm, _
                                        panelSuccess, _
                                        panelInfo, _
                                        lblMessage, _
                                        ValidationSummary1, _
                                        lblMode, _
                                        txtFormAction)

                ReadyEdit() 'retrive and fill the text box for editing
            Else
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If

        End If

    End Sub


    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

        If lblStatus.Text = "ON PROCESS" Then
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Delete"
            lblMode.ForeColor = Color.Red
            'panelGrid.Visible = False
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
        Else
            If Session("group") = "ADMIN" Then
                DataGrid.SelectedIndex = e.Item.ItemIndex

                txtFormAction.Text = "Delete"
                lblMode.ForeColor = Color.Red
                'panelGrid.Visible = False
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
            Else
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If
        End If

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
        Dim objCommand As New SqlCommand("Inv_PRequests_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strVendors As String = objReader("vendor_code")
        Dim strCurrency As String = objReader("currency")
        Dim bolChangeable As Boolean = objReader("status") = "ON PROCESS"

        lblPRID.Text = objReader("id")

        lblStatus.Text = objReader("status")

        lblCompany.Text = Session("company_code")

        If Session("group") = "GENADMIN" Then

            If objReader("status") = "RECEIVED" Or objReader("status") = "INCOMPLETE" Then
                ddlStatus.Visible = False
                lblStatus.Visible = True

            Else
                lblStatus.Visible = False
                ddlStatus.Visible = True
                ddlStatus.SelectedValue = objReader("status")
            End If

            If objReader("status") = "INCOMPLETE" Then

                btnCompleted.Visible = True
            Else

                btnCompleted.Visible = False
            End If

        Else

            ddlStatus.Visible = False
            lblStatus.Visible = True

        End If

        If lblStatus.Text = "ON PROCESS" Then
            If lblTotalCost.Text = "0.00" Then
                'btnPrintImg.Visible = False
                btnPrintLocal.Visible = False

                'btnPrintImportImg.Visible = False
                btnPrintImport.Visible = False

                btnPrintItemized.Visible = False
            Else
                'btnPrintImg.Visible = True
                btnPrintLocal.Visible = True

                'btnPrintImportImg.Visible = True
                btnPrintImport.Visible = True

                btnPrintItemized.Visible = True
            End If
            btnSaveImg.Visible = True
            btnAddImg.Visible = True
            btnAddImg2.Visible = True
            btnReplicateImg.Visible = False

        ElseIf lblStatus.Text = "RECEIVED" Then
            btnLCost.Visible = True
            btnAddImg.Visible = False
            btnAddImg2.Visible = False
            btnReplicateImg.Visible = True
            btnSaveImg.Visible = False
            btnPrintRR.Visible = True

        ElseIf lblStatus.Text = "INCOMPLETE" Then
            btnLCost.Visible = True
            btnAddImg.Visible = False
            btnAddImg2.Visible = False
            btnReplicateImg.Visible = True
            btnSaveImg.Visible = False
            btnPrintRR.Visible = True
        Else
            btnAddImg.Visible = False
            btnAddImg2.Visible = False
            btnReplicateImg.Visible = True
            btnSaveImg.Visible = False
            btnLCost.Visible = False
            btnPrintRR.Visible = False
        End If

        lblPRCode.Text = objReader("pr_code")

        lblPRDate.Text = objReader("pr_date")
        lblDueDate.Text = objReader("due_date")

        calPODate.SelectedDate = objReader("pr_date")
        calPODate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calPODate.Enabled = False

        chbDueDate.Enabled = bolChangeable
        calDueDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
        calDueDate.Enabled = bolChangeable

        If Trim(objReader("due_date")) = "01/01/1999" Then
            chbDueDate.Checked = False
            calDueDate.Visible = False
        Else
            chbDueDate.Checked = True
            calDueDate.Visible = True
        End If

        lblVendorCode.Text = objReader("vendor_code")
        lblVendorName.Text = objReader("vendor_name")

        lblEmail.Text = objReader("email")

        lblRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Enabled = bolChangeable

        'lblDept.Text = objReader("department")
        lblTerms.Text = objReader("terms")
        txtTerms.Text = objReader("terms")
        txtTerms.Enabled = bolChangeable

        If objReader("isVatExclusive") = True Then
            chbIsVatExclusive.Checked = True
        Else
            chbIsVatExclusive.Checked = False
        End If
        chbIsVatExclusive.Enabled = bolChangeable

        If objReader("isNonVat") = True Then
            chbIsNonVat.Checked = True
        Else
            chbIsNonVat.Checked = False
        End If
        chbIsNonVat.Enabled = bolChangeable

        lblTotalCost.Text = objReader("total_cost")

        lblDiscount.Text = objReader("discount_show")
        txtDiscount.Text = objReader("discount_edit")
        txtDiscount.Enabled = bolChangeable

        txtCurrentForex.Text = objReader("current_forex")
        txtCurrentForex.Enabled = bolChangeable

        lblDiscountedAmount.Text = objReader("discounted_amount")

        lblNetAmount.Text = objReader("net_amount")
        txtNote.Text = objReader("note")
        txtNote.Enabled = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_Vendors_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlVendor.DataSource = objReader
        ddlVendor.DataValueField = "code"
        ddlVendor.DataTextField = "name"
        ddlVendor.DataBind()
        ddlVendor.Enabled = bolChangeable
        objReader.Close()

        objCommand = New SqlCommand("Ref_Currencies_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCurrency.DataSource = objReader
        ddlCurrency.DataValueField = "code"
        ddlCurrency.DataTextField = "name"
        ddlCurrency.DataBind()
        ddlCurrency.Enabled = bolChangeable
        objReader.Close()

        objConnection.Close()

        ddlVendor.SelectedIndex = ddlVendor.Items.IndexOf(ddlVendor.Items.FindByValue(strVendors.ToString))
        ddlCurrency.SelectedIndex = ddlCurrency.Items.IndexOf(ddlCurrency.Items.FindByValue(strCurrency.ToString))

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub

    Private Sub btnBackToList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBackToList.Click
        Response.Redirect("inv_prequests_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "JEZHAN" Then

            SetEndPopup("trx_po_jezhan?code=" & lblPRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "COSMOMED" Then

            SetEndPopup("trx_po_cosmomed?code=" & lblPRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")
        Else
            SetEndPopup("trx_pr_preview?code=" & lblPRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")
        End If

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub btnPrintImportImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImportImg.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "COSMOMED" Then
            SetEndPopup("trx_po_importcost_cosmomed?code=" & lblPRCode.Text & _
                                      " &id=" & Request("id") & _
                                      " &formaction=" & "Print")
        Else
            SetEndPopup("trx_po_importcost?code=" & lblPRCode.Text & _
                                      " &id=" & Request("id") & _
                                      " &formaction=" & "Print")
        End If

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub btnPrintRR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintRR.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "JEZHAN" Then

            SetEndPopup("trx_po_receiving_jezhan?code=" & lblPRCode.Text & _
                           " &id=" & Request("id") & _
                           " &formaction=" & "Print")
        Else
            SetEndPopup("trx_purch_receiving?code=" & lblPRCode.Text & _
                           " &id=" & Request("id") & _
                           " &formaction=" & "Print")
        End If

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_pritems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub btnShowPreviousPO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowPreviousPO.Click

        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False
        lblValidate.Visible = False
        panelGrid.Visible = True

        'this condition must only run once. initialize session(module) variables
        If strStoredProc2 <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc2
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(DataGrid2, _
                                    strStoredProc2, _
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
                                    lblVendorCode.Text)
    End Sub


    Private Sub DataGrid2_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid2.ItemCommand
        'mark the selected item 
        DataGrid2.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid2.DataKeys(DataGrid2.SelectedIndex)

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_VenItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes        
        objReader.Read()

        Dim strItemCode As String = objReader("rm_code")
        Dim intQty As Double = objReader("qty")
        Dim intCost As Double = objReader("cost")

        objReader.Close()

        Dim SaveInput As String

        If e.CommandName = "Add" Then

            Dim strValidateInput As String = "ok"

            'the stored procedure and parameters
            objCommand = New SqlCommand("Inv_PRItems_Validate", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@FormAction", "Add")
            objCommand.Parameters.Add("@pr_id", lblPRID.Text)
            objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
            objCommand.Parameters.Add("@rm_code", strItemCode)
            objCommand.Parameters.Add("@id", 0)

            objReader = objCommand.ExecuteReader

            If objReader.HasRows Then
                While objReader.Read
                    strValidateInput = objReader("Error_Message")
                End While
            End If

            'close immediately the reader and connection object 
            objReader.Close()

            If strValidateInput = "ok" Then
                'the stored procedure and parameters
                objCommand = New SqlCommand("Inv_PRItems_Save", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@FormAction", "Add")
                objCommand.Parameters.Add("@id", 0)
                objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
                objCommand.Parameters.Add("@rm_code", strItemCode)
                objCommand.Parameters.Add("@qty", intQty)
                objCommand.Parameters.Add("@cost", intCost)
                objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

                'the returned new id 
                Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
                objCommand.Parameters.Add(objNewID)
                objNewID.Direction = ParameterDirection.Output

                Try
                    'open the connection and execute the query 
                    'objConnection.Open()
                    objCommand.ExecuteNonQuery()

                    'save to audit trail 
                    Sys_Class.SaveToAuditTrail(Session("username"), _
                                                txtFormAction.Text, _
                                                Request("sys_table"), _
                                                "Item: " + objReader("item_name") + " > RMCode: " + objReader("rm_code") + " > Qty: " + objReader("qty") + " > Cost: " + objReader("cost"), _
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
                    objReader.Close()
                    objConnection.Close()
                End Try

                panelSuccess.Visible = False
                panelInfo.Visible = False

                GridBind()
            Else

                'notify user and reason of invalidation
                panelSuccess.Visible = False
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strValidateInput
            End If

        End If

    End Sub

    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged
        Refresh_RecentPO()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        SetFocus(txtQty)
    End Sub

    Private Sub Refresh_RecentPO()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_VenItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@vendor_code", lblVendorCode.Text)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblRecentPODate.Text = Trim(objReader("lastPO_date"))
        lblRecentPOQty.Text = Trim(objReader("qty"))
        lblRecentPOCost.Text = Trim(objReader("cost"))

        objReader.Close()

        objCommand = New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        objReader = objCommand.ExecuteReader
        objReader.Read()

        txtCost.Text = Trim(objReader("cost"))
        txtBarcode.Text = Trim(objReader("barcode"))

        objReader.Close()
        objConnection.Close()

        panelSuccess.Visible = False
        panelInfo.Visible = False

    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

        Refresh_DDLItems()

    End Sub
    Private Sub Refresh_DDLItems()


        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 9999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@barcode", txtBarcode.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        objReader.Read()

        Dim strItem As String = objReader("code")

        objReader.Close()

        objCommand = New SqlCommand("Ref_Items_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Enabled = True

        objReader.Close()
        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strItem.ToString))
    End Sub

    Private Sub btnReplicateImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnReplicateImg.Click
        Dim SaveInput As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POReplicate_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@vendor_code", lblVendorCode.Text)
        objCommand.Parameters.Add("@requested_by", lblRequestedBy.Text)
        objCommand.Parameters.Add("@currency", ddlCurrency.SelectedValue)
        objCommand.Parameters.Add("@current_forex", txtCurrentForex.Text)
        objCommand.Parameters.Add("@discount", lblDiscount.Text)
        objCommand.Parameters.Add("@terms", lblTerms.Text)
        objCommand.Parameters.Add("@note", txtNote.Text)
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
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
                                        "inv_prequests_list", _
                                        "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow.AddHours(8) + " > VendorCode: " + lblVendorCode.Text + " > RequestedBy: " + lblRequestedBy.Text + " > Dept: " + lblDept.Text + " > Discount: " + lblDiscount.Text + " > Terms: " + lblTerms.Text + " > Note: " + txtNote.Text, _
                                        Request("id"), _
                                        0)

            Session("objNewID") = objNewID.Value

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

        Response.Redirect("inv_pritems_list?&id=" & Session("objNewID") & "&sys_table=inv_prequests_list")
        panelSuccess.Visible = True
    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_prequests_list")
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
        Dim objCommand As New SqlCommand("Inv_PRequests_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@pr_date", calPODate.SelectedDate)
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
        Dim objCommand As New SqlCommand("Inv_PRequests_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@pr_date", calPODate.SelectedDate)

        If chbDueDate.Checked = True Then
            objCommand.Parameters.Add("@due_date", calDueDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@due_date", "1/1/1999")
        End If

        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@requested_by", txtRequestedBy.Text)
        objCommand.Parameters.Add("@currency", ddlCurrency.SelectedValue)
        objCommand.Parameters.Add("@current_forex", txtCurrentForex.Text)
        objCommand.Parameters.Add("@discount", txtDiscount.Text)
        objCommand.Parameters.Add("@terms", txtTerms.Text)

        If chbIsVatExclusive.Checked = True Then
            objCommand.Parameters.Add("@isVatExclusive", 1)
        Else
            objCommand.Parameters.Add("@isVatExclusive", 0)
        End If

        If chbIsNonVat.Checked = True Then
            objCommand.Parameters.Add("@isNonVat", 1)
        Else
            objCommand.Parameters.Add("@isNonVat", 0)
        End If

        objCommand.Parameters.Add("@note", txtNote.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of UOM
            objCommand = New SqlCommand("Ref_Vendors_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@code", ddlVendor.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strVendorCode As String = objReader("code")
            objReader.Close()


            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow + " > VendorCode: " + strVendorCode + " > RequestedBy: " + txtRequestedBy.Text + " > Dept: " + lblDept.Text + " > Discount: " + txtDiscount.Text + " > Terms: " + txtTerms.Text + " > Note: " + txtNote.Text, _
                                        objNewID.Value, _
                                        0)

            Session("objNewID") = objNewID.Value

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
    Private Sub ddlVendor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlVendor.SelectedIndexChanged
        Refresh_Terms()
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub Refresh_Terms()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_Vendors_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@code", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtTerms.Text = Trim(objReader("terms"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub txtRequestedBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRequestedBy.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub calPODate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calPODate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtTerms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerms.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCurrency.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtCurrentForex_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentForex.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlStatus.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub btnLCost_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLCost.Click
        Response.Redirect("inv_lcostpo_list?&id=" & Request("id") & "&sys_table=" & strStoredProc)
    End Sub

    Private Sub btnCompleted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCompleted.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_ReceivingSupplier_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Complete")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@vendor_dr_no", "")
        objCommand.Parameters.Add("@vendor_si_no", "")
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
                                        strSubMenuName, _
                                        "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow, _
                                        objNewID.Value, _
                                        0)

            Session("objNewID") = objNewID.Value

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try

        DisplayHeader()
        GridBind()
        panelSuccess.Visible = True
        panelInfo.Visible = False
        panelForm.Visible = False
    End Sub

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        If e.CommandName = "Open" Then

            lblPRItemsID.Text = strKeyFieldValue

            GridBind2()

            panelSuccess.Visible = False
            panelInfo.Visible = False
            panelForm.Visible = False
            panelForm2.Visible = False
            panelGrid.Visible = False
            panelGrid2.Visible = True

        End If
    End Sub

    Private Sub btnBackImg2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg2.Click
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False
        panelForm2.Visible = False
        panelGrid2.Visible = False
        panelGrid.Visible = True
    End Sub

    Private Sub btnX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX2.Click
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False
        panelForm2.Visible = False
        panelGrid2.Visible = True
        panelGrid.Visible = False

        txtPageNo.Text = 1
        GridBind2()
    End Sub

    Private Sub btnAddImg2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg2.Click
        txtFormAction2.Text = "Add"
        lblMode2.ForeColor = Color.Green
        'panelGrid.Visible = False
        btnSave2.Text = "Add"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm2, _
                            panelSuccess, _
                            panelInfo, _
                            lblMessage, _
                            ValidationSummary1, _
                            lblMode2, _
                            txtFormAction2)

        ReadyAdd2()
    End Sub
    Private Sub ReadyAdd2()

        txtSKUCode.Text = ""
        txtSKUCode.Enabled = True

        txtItemDesc.Text = ""
        txtItemDesc.Enabled = True

        txtPOQty.Text = 0
        txtPOQty.Enabled = True

        txtPOUnitCost.Text = 0
        txtPOUnitCost.Enabled = True

        SetFocus(txtSKUCode)

    End Sub
    Sub GridBind2()

        'this condition must only run once. initialize session(module) variables
        If strStoredProc3 <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc3
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(DataGrid3, _
                                    strStoredProc3, _
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
                                    lblPRItemsID.Text)

    End Sub

    Private Sub DataGrid3_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid3.EditCommand
        'mark the selected item 
        DataGrid3.SelectedIndex = e.Item.ItemIndex

        txtFormAction2.Text = "Edit"
        lblMode2.ForeColor = Color.Orange
        'panelGrid.Visible = False
        btnSave2.Text = "Save"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm2, _
                            panelSuccess, _
                            panelInfo, _
                            lblMessage, _
                            ValidationSummary1, _
                            lblMode2, _
                            txtFormAction2)

        ReadyEdit2() 'retrive and fill the text box for editing
    End Sub

    Private Sub DataGrid3_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid3.DeleteCommand
        'mark the selected item 
        DataGrid3.SelectedIndex = e.Item.ItemIndex

        txtFormAction2.Text = "Delete"
        lblMode2.ForeColor = Color.Red
        'panelGrid.Visible = False
        btnSave2.Text = "Delete"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm2, _
                            panelSuccess, _
                            panelInfo, _
                            lblMessage, _
                            ValidationSummary1, _
                            lblMode2, _
                            txtFormAction2)

        ReadyDelete2() 'retrive and fill the text box for editing
    End Sub

    Private Sub ReadyEdit2()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid3.DataKeys(DataGrid3.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRSubItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        lblID2.Text = Trim(objReader("id"))

        txtSKUCode.Text = Trim(objReader("sku_code"))
        txtSKUCode.Enabled = bolChangeable

        txtItemDesc.Text = Trim(objReader("item_desc"))
        txtItemDesc.Enabled = bolChangeable

        txtPOQty.Text = Trim(objReader("qty"))
        txtPOQty.Enabled = bolChangeable

        txtPOUnitCost.Text = Trim(objReader("unit_cost"))
        txtPOUnitCost.Enabled = bolChangeable

        objReader.Close()

        objConnection.Close()        

        SetFocus(txtSKUCode)


    End Sub
    Private Sub ReadyDelete2()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid3.DataKeys(DataGrid3.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRSubItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        lblID2.Text = Trim(objReader("id"))

        txtSKUCode.Text = Trim(objReader("sku_code"))
        txtSKUCode.Enabled = False

        txtItemDesc.Text = Trim(objReader("item_desc"))
        txtItemDesc.Enabled = False

        txtPOQty.Text = Trim(objReader("qty"))
        txtPOQty.Enabled = False

        txtPOUnitCost.Text = Trim(objReader("unit_cost"))
        txtPOUnitCost.Enabled = False

        objReader.Close()

        objConnection.Close()

        SetFocus(txtSKUCode)
    End Sub

    Private Sub btnSave2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave2.Click
        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput2()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput2()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                If txtFormAction2.Text = "Add" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelForm2.Visible = True
                    panelGrid2.Visible = True
                    panelGrid.Visible = False

                    ReadyAdd2()
                    GridBind2()
                    txtPageNo.Text = 1

                ElseIf txtFormAction2.Text = "Edit" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelForm2.Visible = False
                    panelGrid2.Visible = True
                    panelGrid.Visible = False

                    GridBind2()
                    txtPageNo.Text = 1

                ElseIf txtFormAction2.Text = "Delete" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelForm2.Visible = False
                    panelGrid2.Visible = True
                    panelGrid.Visible = False

                    GridBind2()
                    txtPageNo.Text = 1
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

    Private Function ValidateInput2()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput2 = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRSubItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)
        objCommand.Parameters.Add("@pritems_id", lblPRItemsID.Text)
        objCommand.Parameters.Add("@sku_code", txtSKUCode.Text)
        objCommand.Parameters.Add("@item_desc", txtItemDesc.Text)
        objCommand.Parameters.Add("@qty", txtPOQty.Text)
        objCommand.Parameters.Add("@id", lblID2.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateInput2 = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function

    Private Function SaveInput2()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput2 = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRSubItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)
        objCommand.Parameters.Add("@id", lblID2.Text)
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objCommand.Parameters.Add("@pritems_id", lblPRItemsID.Text)
        objCommand.Parameters.Add("@sku_code", txtSKUCode.Text)
        objCommand.Parameters.Add("@item_desc", txtItemDesc.Text)
        objCommand.Parameters.Add("@qty", txtPOQty.Text)
        objCommand.Parameters.Add("@unit_cost", txtPOUnitCost.Text)
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
                                        Request("sys_table"), _
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text + " > Cost: " + txtCost.Text, _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            If txtFormAction2.Text = "Delete" Then
                SaveInput2 = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveInput2 = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub btnPrintImg2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg2.Click

        SetEndPopup("trx_podetail_cosmomed?code=" & lblPRCode.Text & _
                                    " &id=" & Request("id") & _
                                    " &formaction=" & "Print")
    End Sub

    Private Sub chbDueDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbDueDate.CheckedChanged
        calDueDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()

        If chbDueDate.Checked = True Then
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calDueDate.Visible = True
            calDueDate.Enabled = True
            SetFocus(calDueDate)
        Else
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calDueDate.Visible = False
            calDueDate.Enabled = False
            SetFocus(calDueDate)
        End If

    End Sub

    Private Sub calDueDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDueDate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub btnPrintLocal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintLocal.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "JEZHAN" Then

            SetEndPopup("trx_po_jezhan?code=" & lblPRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "COSMOMED" Then

            SetEndPopup("trx_po_cosmomed?code=" & lblPRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")
        Else
            SetEndPopup("trx_pr_preview?code=" & lblPRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")
        End If

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnPrintImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintImport.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "COSMOMED" Then
            SetEndPopup("trx_po_importcost_cosmomed?code=" & lblPRCode.Text & _
                                      " &id=" & Request("id") & _
                                      " &formaction=" & "Print")
        Else
            SetEndPopup("trx_po_importcost?code=" & lblPRCode.Text & _
                                      " &id=" & Request("id") & _
                                      " &formaction=" & "Print")
        End If

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnPrintItemized_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintItemized.Click
        SetEndPopup("trx_podetail_cosmomed?code=" & lblPRCode.Text & _
                                            " &id=" & Request("id") & _
                                            " &formaction=" & "Print")
    End Sub

    Private Sub chbIsVatExclusive_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbIsVatExclusive.CheckedChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub chbIsNonVat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbIsNonVat.CheckedChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

   
End Class

