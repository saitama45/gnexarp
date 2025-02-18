
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_procurementdtl_list
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
    Protected WithEvents btnShowPreviousPO As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
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
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblRawMats As System.Web.UI.WebControls.Label
    Protected WithEvents chbItemNotFound As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtItemDesc As System.Web.UI.WebControls.TextBox    
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblBrand As System.Web.UI.WebControls.Label
    Protected WithEvents txtBrand As System.Web.UI.WebControls.TextBox
    Protected WithEvents chbBrandNotFound As System.Web.UI.WebControls.CheckBox
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblRequestedQty As System.Web.UI.WebControls.Label
    Protected WithEvents txtForPOQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtVendorCost1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtVendorCost2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtVendorCost3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnReplicateImg As System.Web.UI.WebControls.ImageButton   
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRID As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblSONo As System.Web.UI.WebControls.Label
    Protected WithEvents txtSONo As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCustomer As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomerCode As System.Web.UI.WebControls.Label
    Protected WithEvents calPRDate As eWorld.UI.CalendarPopup
    Protected WithEvents calDueDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtRequestedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalRequestedQty As System.Web.UI.WebControls.Label
    Protected WithEvents txtSupplierA As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSupplierACode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSupplierB As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSupplierBCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSupplierC As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSupplierCCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents chbSupplierA As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbSupplierB As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbSupplierC As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblProjectName As System.Web.UI.WebControls.Label
    Protected WithEvents ddlSupplierA As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlSupplierB As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlSupplierC As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblSupplierAName As System.Web.UI.WebControls.Label
    Protected WithEvents lblSupplierBName As System.Web.UI.WebControls.Label
    Protected WithEvents lblSupplierCName As System.Web.UI.WebControls.Label
    Protected WithEvents chbSupANotFound As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbSupBNotFound As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbSupCNotFound As System.Web.UI.WebControls.CheckBox
    Protected WithEvents btnCreatePOSupA As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnCreatePOSupB As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnCreatePOSupC As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lblSelectedVendor As System.Web.UI.WebControls.Label
    Protected WithEvents btnYes As System.Web.UI.WebControls.Button
    Protected WithEvents btnNo As System.Web.UI.WebControls.Button
    Protected WithEvents btnCompleted As System.Web.UI.WebControls.LinkButton

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
    Public strStoredProc As String = "inv_procurementdtl_list"
    Public strSubMenuName As String = "inv_procurementdtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"
    
    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProcurementDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strRawMats As String = objReader("rm_code")
        Dim strUOM As String = objReader("uom")
        Dim strBrand As String = objReader("brand")

        Dim bolChangeable As Boolean = lblStatus.Text = "PENDING"

        lblID.Text = Trim(objReader("id"))        

        If Trim(objReader("rm_code")) = "" Then
            chbItemNotFound.Checked = True
            ddlRawMats.Visible = False
            txtItemDesc.Visible = True
            txtItemDesc.Text = Trim(objReader("item_desc"))
        Else
            chbItemNotFound.Checked = False
            ddlRawMats.Visible = True
            txtItemDesc.Visible = False
            txtItemDesc.Text = ""
        End If
        txtItemDesc.Enabled = bolChangeable
        chbItemNotFound.Enabled = bolChangeable

        If Trim(objReader("isBrandFound")) = 0 Then
            chbBrandNotFound.Checked = True
            ddlBrand.Visible = False
            txtBrand.Visible = True
            txtBrand.Text = Trim(objReader("brand"))            
        Else
            chbBrandNotFound.Checked = False
            ddlBrand.Visible = True
            txtBrand.Visible = False            
            txtBrand.Text = ""
        End If
        chbBrandNotFound.Enabled = bolChangeable

        txtBrand.Enabled = bolChangeable

        lblRequestedQty.Text = Trim(objReader("requested_qty"))
        lblSOH.Text = Trim(objReader("soh"))

        If Trim(objReader("for_po_qty")) = 0 Then
            txtForPOQty.Text = lblRequestedQty.Text
        Else
            txtForPOQty.Text = Trim(objReader("for_po_qty"))
        End If

        txtForPOQty.Enabled = bolChangeable

        If Trim(objReader("vendor1_ok")) = 1 Then
            chbSupplierA.Checked = True
        Else
            chbSupplierA.Checked = False
        End If
        chbSupplierA.Enabled = bolChangeable

        If Trim(objReader("vendor2_ok")) = 1 Then
            chbSupplierB.Checked = True
        Else
            chbSupplierB.Checked = False
        End If
        chbSupplierB.Enabled = bolChangeable

        If Trim(objReader("vendor3_ok")) = 1 Then
            chbSupplierC.Checked = True
        Else
            chbSupplierC.Checked = False
        End If
        chbSupplierC.Enabled = bolChangeable

        txtVendorCost1.Text = Trim(objReader("vendor1_cost"))
        txtVendorCost1.Enabled = bolChangeable

        txtVendorCost2.Text = Trim(objReader("vendor2_cost"))
        txtVendorCost2.Enabled = bolChangeable

        txtVendorCost3.Text = Trim(objReader("vendor3_cost"))
        txtVendorCost3.Enabled = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_ItemsCompany_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@Session_username", Session("username"))

        objReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Enabled = bolChangeable
        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_UOM_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "name"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        ddlUOM.Enabled = bolChangeable
        ddlUOM.SelectedIndex = ddlUOM.Items.IndexOf(ddlUOM.Items.FindByValue(strUOM.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "name"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        ddlBrand.Enabled = bolChangeable
        ddlBrand.SelectedIndex = ddlBrand.Items.IndexOf(ddlBrand.Items.FindByValue(strBrand.ToString))
        objReader.Close()

        objConnection.Close()

        SetFocus(ddlRawMats)

        Refresh_lblRawMats()

    End Sub

    Private Function Refresh_lblRawMats()
        panelSuccess.Visible = False
        panelInfo.Visible = False

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Inv_PORequestsDTL_ItemsGet", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblRawMats.Text = Trim(objReader("item_name"))

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
        Dim objCommand As New SqlCommand("Inv_ProcurementDTL_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@por_id", lblPRID.Text)
        objCommand.Parameters.Add("@por_code", lblPRCode.Text)

        If chbItemNotFound.Checked = True Then
            objCommand.Parameters.Add("@item_desc", txtItemDesc.Text)
            objCommand.Parameters.Add("@rm_code", "")
        Else
            objCommand.Parameters.Add("@item_desc", lblRawMats.Text)
            objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        End If

        If chbBrandNotFound.Checked = True Then
            objCommand.Parameters.Add("@brand", txtBrand.Text)
            objCommand.Parameters.Add("@isBrandFound", 0)
        Else
            objCommand.Parameters.Add("@brand", ddlBrand.SelectedValue)
            objCommand.Parameters.Add("@isBrandFound", 1)
        End If

        objCommand.Parameters.Add("@uom", ddlUOM.SelectedValue)
        objCommand.Parameters.Add("@requested_qty", lblRequestedQty.Text)
        objCommand.Parameters.Add("@for_po_qty", txtForPOQty.Text)
        objCommand.Parameters.Add("@vendor1_cost", txtVendorCost1.Text)

        If chbSupplierA.Checked = True Then
            objCommand.Parameters.Add("@vendor1_ok", 1)
        Else
            objCommand.Parameters.Add("@vendor1_ok", 0)
        End If

        objCommand.Parameters.Add("@vendor2_cost", txtVendorCost2.Text)

        If chbSupplierB.Checked = True Then
            objCommand.Parameters.Add("@vendor2_ok", 1)
        Else
            objCommand.Parameters.Add("@vendor2_ok", 0)
        End If

        objCommand.Parameters.Add("@vendor3_cost", txtVendorCost3.Text)

        If chbSupplierC.Checked = True Then
            objCommand.Parameters.Add("@vendor3_ok", 1)
        Else
            objCommand.Parameters.Add("@vendor3_ok", 0)
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

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        Request("sys_table"), _
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue, _
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
        Dim objCommand As New SqlCommand("Inv_PORequestsDTL_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@item_desc", txtItemDesc.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@por_id", lblPRID.Text)
        objCommand.Parameters.Add("@requested_qty", lblRequestedQty.Text)

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
                                    "item_desc", _
                                    "rm_code", _
                                    "brand", _
                                    "uom", _
                                    "requested_qty", _
                                    "soh", _
                                    "for_po_qty", _
                                    "supplier_a", _
                                    "supplier_b", _
                                    "supplier_c", _
                                    "hlight"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Item Desc", _
                                    "Item Code", _
                                    "Brand", _
                                    "UOM", _
                                    "Requested Qty", _
                                    "SOH", _
                                    "For PO Qty", _
                                    "Supplier A", _
                                    "Supplier B", _
                                    "Supplier C", _
                                    ""}

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
                                    ""}

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
                                    "X8"}


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

            txtItemDesc.Visible = False
            txtBrand.Visible = False

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
                                    lblPRID.Text)

    End Sub
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub DataGrid2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemDataBound
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

                If txtFormAction.Text = "Edit" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False

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
        Dim objCommand As New SqlCommand("Inv_Procurement_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = objReader("status") = "PENDING"
        Dim bolVisible As Boolean = objReader("status") <> "PENDING"

        Dim strVendorACode As String = objReader("supplier_a_code")
        Dim strVendorBCode As String = objReader("supplier_b_code")
        Dim strVendorCCode As String = objReader("supplier_c_code")

        lblPRID.Text = Trim(objReader("id"))
        lblStatus.Text = Trim(objReader("status"))
        lblPRCode.Text = Trim(objReader("por_code"))

        txtSONo.Text = Trim(objReader("so_no"))

        If Trim(objReader("total_requested_qty")) <> 0 Then
            txtSONo.Visible = False
            lblSONo.Visible = True
        End If
        txtSONo.Enabled = False

        lblSONo.Text = Trim(objReader("so_no"))
        lblProjectName.Text = Trim(objReader("project_desc"))
        lblCustomer.Text = Trim(objReader("customer_name"))
        lblCustomerCode.Text = Trim(objReader("customer"))

        calPRDate.SelectedDate = Trim(objReader("por_date"))
        calPRDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calPRDate.Enabled = False

        lblRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Enabled = False

        calDueDate.SelectedDate = Trim(objReader("due_date"))
        calDueDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calDueDate.Enabled = False

        lblTotalRequestedQty.Text = objReader("total_requested_qty")

        lblSupplierAName.Text = Trim(objReader("supplier_a"))
        lblSupplierBName.Text = Trim(objReader("supplier_b"))
        lblSupplierCName.Text = Trim(objReader("supplier_c"))

        txtNote.Text = objReader("note")
        txtNote.Enabled = False

        btnAddImg.Visible = False
        btnSaveImg.Visible = bolChangeable
        btnCompleted.Visible = bolChangeable        
        'btnApprove.Visible = False
        'btnCancelPR.Visible = False
        btnReplicateImg.Visible = False
        btnPrintImg.Visible = bolChangeable

        If Trim(objReader("supplier_a_code")) = "" Then
            ddlSupplierA.Visible = False
            chbSupANotFound.Checked = True
            txtSupplierA.Visible = True
            txtSupplierA.Text = Trim(objReader("supplier_a"))
            btnCreatePOSupA.Visible = False
        Else
            ddlSupplierA.Visible = True
            chbSupANotFound.Checked = False
            txtSupplierA.Visible = False

            If ddlSupplierA.SelectedIndex = 0 Then
                btnCreatePOSupA.Visible = False
            Else
                btnCreatePOSupA.Visible = True
            End If

        End If
        ddlSupplierA.Enabled = bolChangeable
        chbSupANotFound.Enabled = bolChangeable
        txtSupplierA.Enabled = bolChangeable

        If Trim(objReader("supplier_b_code")) = "" Then
            ddlSupplierB.Visible = False
            chbSupBNotFound.Checked = True
            txtSupplierB.Visible = True
            txtSupplierB.Text = Trim(objReader("supplier_b"))
            btnCreatePOSupB.Visible = False
        Else
            ddlSupplierB.Visible = True
            chbSupBNotFound.Checked = False
            txtSupplierB.Visible = False

            If ddlSupplierB.SelectedIndex = 0 Then
                btnCreatePOSupB.Visible = False
            Else
                btnCreatePOSupB.Visible = True
            End If

        End If
        ddlSupplierB.Enabled = bolChangeable
        chbSupBNotFound.Enabled = bolChangeable
        txtSupplierB.Enabled = bolChangeable

        If Trim(objReader("supplier_c_code")) = "" Then
            ddlSupplierC.Visible = False
            chbSupCNotFound.Checked = True
            txtSupplierC.Visible = True
            txtSupplierC.Text = Trim(objReader("supplier_c"))
            btnCreatePOSupC.Visible = False
        Else
            ddlSupplierC.Visible = True
            chbSupCNotFound.Checked = False
            txtSupplierC.Visible = False

            If ddlSupplierC.SelectedIndex = 0 Then
                btnCreatePOSupC.Visible = False
            Else
                btnCreatePOSupC.Visible = True
            End If

        End If
        ddlSupplierC.Enabled = bolChangeable
        chbSupCNotFound.Enabled = bolChangeable

        btnCreatePOSupA.Visible = bolChangeable
        btnCreatePOSupB.Visible = bolChangeable
        btnCreatePOSupC.Visible = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_Vendors_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlSupplierA.DataSource = objReader
        ddlSupplierA.DataValueField = "code"
        ddlSupplierA.DataTextField = "name"
        ddlSupplierA.DataBind()
        ddlSupplierA.Items.Insert(0, "")
        ddlSupplierA.SelectedIndex = 0
        ddlSupplierA.SelectedIndex = ddlSupplierA.Items.IndexOf(ddlSupplierA.Items.FindByValue(strVendorACode.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Vendors_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlSupplierB.DataSource = objReader
        ddlSupplierB.DataValueField = "code"
        ddlSupplierB.DataTextField = "name"
        ddlSupplierB.DataBind()
        ddlSupplierB.Items.Insert(0, "")
        ddlSupplierB.SelectedIndex = 0
        ddlSupplierB.SelectedIndex = ddlSupplierB.Items.IndexOf(ddlSupplierB.Items.FindByValue(strVendorBCode.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Vendors_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlSupplierC.DataSource = objReader
        ddlSupplierC.DataValueField = "code"
        ddlSupplierC.DataTextField = "name"
        ddlSupplierC.DataBind()
        ddlSupplierC.Items.Insert(0, "")
        ddlSupplierC.SelectedIndex = 0
        ddlSupplierC.SelectedIndex = ddlSupplierC.Items.IndexOf(ddlSupplierC.Items.FindByValue(strVendorCCode.ToString))
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
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_pr_preview?code=" & lblPRCode.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_procurementdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub btnReplicateImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnReplicateImg.Click
        Dim SaveInput As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POReplicate_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        'objCommand.Parameters.Add("@vendor_code", lblVendorCode.Text)
        'objCommand.Parameters.Add("@requested_by", lblRequestedBy.Text)
        'objCommand.Parameters.Add("@currency", ddlCurrency.SelectedValue)
        'objCommand.Parameters.Add("@current_forex", txtCurrentForex.Text)
        'objCommand.Parameters.Add("@discount", lblDiscount.Text)
        'objCommand.Parameters.Add("@terms", lblTerms.Text)
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
                                        "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow.AddHours(8), _
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
        Response.Redirect("inv_procurement_list")
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
        Dim objCommand As New SqlCommand("Inv_PORequests_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@due_date", calDueDate.SelectedDate)
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
        Dim objCommand As New SqlCommand("Inv_Procurement_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))

        If chbSupANotFound.Checked = True Then
            objCommand.Parameters.Add("@supplier_a", txtSupplierA.Text)
            objCommand.Parameters.Add("@supplier_a_code", "")
        Else            
            objCommand.Parameters.Add("@supplier_a", lblSupplierAName.Text)
            objCommand.Parameters.Add("@supplier_a_code", ddlSupplierA.SelectedValue)
        End If

        If chbSupBNotFound.Checked = True Then
            objCommand.Parameters.Add("@supplier_b", txtSupplierB.Text)
            objCommand.Parameters.Add("@supplier_b_code", "")
        Else
            objCommand.Parameters.Add("@supplier_b", lblSupplierBName.Text)
            objCommand.Parameters.Add("@supplier_b_code", ddlSupplierB.SelectedValue)
        End If        

        If chbSupCNotFound.Checked = True Then
            objCommand.Parameters.Add("@supplier_c", txtSupplierC.Text)
            objCommand.Parameters.Add("@supplier_c_code", "")
        Else
            objCommand.Parameters.Add("@supplier_c", lblSupplierCName.Text)
            objCommand.Parameters.Add("@supplier_c_code", ddlSupplierC.SelectedValue)
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
            '                            strSubMenuName, _
            '                            "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow, _
            '                            objNewID.Value, _
            '                            0)

            'Session("objNewID") = objNewID.Value

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
    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged

        Refresh_lblRawMats()
    End Sub
    Private Sub txtSupplierA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierA.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSupplierB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierB.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSupplierC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierC.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub chbItemNotFound_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbItemNotFound.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        If chbItemNotFound.Checked = True Then
            ddlRawMats.Visible = False
            txtItemDesc.Visible = True
            txtItemDesc.Text = ""
            SetFocus(txtItemDesc)
        Else
            ddlRawMats.Visible = True
            txtItemDesc.Visible = False
            SetFocus(ddlRawMats)
        End If
    End Sub

    Private Sub chbBrandNotFound_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbBrandNotFound.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        If chbBrandNotFound.Checked = True Then
            ddlBrand.Visible = False
            txtBrand.Visible = True
            txtBrand.Text = ""
            SetFocus(txtBrand)
        Else
            ddlBrand.Visible = True
            txtBrand.Visible = False
            SetFocus(ddlBrand)
        End If
    End Sub
    Private Sub chbSupANotFound_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbSupANotFound.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        If chbSupANotFound.Checked = True Then
            ddlSupplierA.Visible = False
            txtSupplierA.Visible = True
            txtSupplierA.Text = ""
            btnCreatePOSupA.Visible = False
            SetFocus(txtSupplierA)
        Else
            ddlSupplierA.Visible = True
            txtSupplierA.Visible = False

            If ddlSupplierA.SelectedIndex = 0 Then
                btnCreatePOSupA.Visible = False
            Else
                btnCreatePOSupA.Visible = True
            End If

            SetFocus(ddlSupplierA)
        End If
    End Sub

    Private Sub chbSupBNotFound_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbSupBNotFound.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        If chbSupBNotFound.Checked = True Then
            ddlSupplierB.Visible = False
            txtSupplierB.Visible = True
            txtSupplierB.Text = ""
            btnCreatePOSupB.Visible = False
            SetFocus(txtSupplierB)
        Else
            ddlSupplierB.Visible = True
            txtSupplierB.Visible = False

            If ddlSupplierB.SelectedIndex = 0 Then
                btnCreatePOSupB.Visible = False
            Else
                btnCreatePOSupB.Visible = True
            End If

            SetFocus(ddlSupplierB)
        End If
    End Sub

    Private Sub chbSupCNotFound_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbSupCNotFound.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        If chbSupCNotFound.Checked = True Then
            ddlSupplierC.Visible = False
            txtSupplierC.Visible = True
            txtSupplierC.Text = ""
            btnCreatePOSupC.Visible = False
            SetFocus(txtSupplierB)
        Else
            ddlSupplierC.Visible = True
            txtSupplierC.Visible = False

            If ddlSupplierC.SelectedIndex = 0 Then
                btnCreatePOSupC.Visible = False
            Else
                btnCreatePOSupC.Visible = True
            End If

            SetFocus(ddlSupplierC)
        End If
    End Sub

    Private Sub btnCreatePOSupA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreatePOSupA.Click
        'validate the inputs vs. table records
        Dim strValidateCreatePOSupA As String = ValidateCreatePOSupA()

        'is the validation 
        If strValidateCreatePOSupA = "ok" Then
            'then save the inputs
            Dim strSaveCreatePOSupA As String = SaveCreatePOSupA()

            'is the saving successfull?
            If strSaveCreatePOSupA = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                lblValidate.Visible = False

                'reset and rebind       
                txtPageNo.Text = 1
                DisplayHeader()
                GridBind()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveCreatePOSupA
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateCreatePOSupA
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If
    End Sub

    Private Function ValidateCreatePOSupA()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateCreatePOSupA = "ok"

        lblSelectedVendor.Text = 1

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCreatePOSupA_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@por_id", lblPRID.Text)
        objCommand.Parameters.Add("@supplier_a_code", ddlSupplierA.SelectedValue)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateCreatePOSupA = objReader("Error_Message")
            End While
        End If

        If ValidateCreatePOSupA = "Warning! There is already a PO created for this request.<br> Do you still want to proceed?<br><br>" Then
            btnYes.Visible = True
            btnNo.Visible = True
        Else
            btnYes.Visible = False
            btnNo.Visible = False
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveCreatePOSupA()

        SaveCreatePOSupA = "ok"

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCreatePOSupA_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "CreatePO")
        objCommand.Parameters.Add("@por_id", Request("id"))
        objCommand.Parameters.Add("@supplier_a_code", ddlSupplierA.SelectedValue)
        objCommand.Parameters.Add("@Session_fullname", Session("fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try

        'reset and rebind       
        txtPageNo.Text = 1
        DisplayHeader()
        GridBind()
    End Function

    Private Sub btnCreatePOSupB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreatePOSupB.Click
        'validate the inputs vs. table records
        Dim strValidateCreatePOSupB As String = ValidateCreatePOSupB()

        'is the validation 
        If strValidateCreatePOSupB = "ok" Then
            'then save the inputs
            Dim strSaveCreatePOSupB As String = SaveCreatePOSupB()

            'is the saving successfull?
            If strSaveCreatePOSupB = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                lblValidate.Visible = False

                'reset and rebind       
                txtPageNo.Text = 1
                DisplayHeader()
                GridBind()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveCreatePOSupB
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateCreatePOSupB
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If
    End Sub

    Private Function ValidateCreatePOSupB()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateCreatePOSupB = "ok"

        lblSelectedVendor.Text = 2

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCreatePOSupB_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@por_id", lblPRID.Text)
        objCommand.Parameters.Add("@supplier_b_code", ddlSupplierB.SelectedValue)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateCreatePOSupB = objReader("Error_Message")
            End While
        End If

        If ValidateCreatePOSupB = "Warning! There is already a PO created for this request.<br> Do you still want to proceed?<br><br>" Then
            btnYes.Visible = True
            btnNo.Visible = True
        Else
            btnYes.Visible = False
            btnNo.Visible = False
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveCreatePOSupB()

        SaveCreatePOSupB = "ok"

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCreatePOSupB_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "CreatePO")
        objCommand.Parameters.Add("@por_id", Request("id"))
        objCommand.Parameters.Add("@supplier_b_code", ddlSupplierB.SelectedValue)
        objCommand.Parameters.Add("@Session_fullname", Session("fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try

        'reset and rebind       
        txtPageNo.Text = 1
        DisplayHeader()
        GridBind()
    End Function

    Private Sub btnCreatePOSupC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreatePOSupC.Click
        'validate the inputs vs. table records
        Dim strValidateCreatePOSupC As String = ValidateCreatePOSupC()

        'is the validation 
        If strValidateCreatePOSupC = "ok" Then
            'then save the inputs
            Dim strSaveCreatePOSupC As String = SaveCreatePOSupC()

            'is the saving successfull?
            If strSaveCreatePOSupC = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                lblValidate.Visible = False

                'reset and rebind       
                txtPageNo.Text = 1
                DisplayHeader()
                GridBind()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveCreatePOSupC
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateCreatePOSupC
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If
    End Sub
    Private Function ValidateCreatePOSupC()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateCreatePOSupC = "ok"

        lblSelectedVendor.Text = 3

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCreatePOSupC_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@por_id", lblPRID.Text)
        objCommand.Parameters.Add("@supplier_c_code", ddlSupplierC.SelectedValue)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateCreatePOSupC = objReader("Error_Message")
            End While
        End If

        If ValidateCreatePOSupC = "Warning! There is already a PO created for this request.<br> Do you still want to proceed?<br><br>" Then
            btnYes.Visible = True
            btnNo.Visible = True
        Else
            btnYes.Visible = False
            btnNo.Visible = False
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveCreatePOSupC()

        SaveCreatePOSupC = "ok"

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCreatePOSupC_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "CreatePO")
        objCommand.Parameters.Add("@por_id", Request("id"))
        objCommand.Parameters.Add("@supplier_c_code", ddlSupplierC.SelectedValue)
        objCommand.Parameters.Add("@Session_fullname", Session("fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try

        'reset and rebind       
        txtPageNo.Text = 1
        DisplayHeader()
        GridBind()
    End Function

    Private Sub btnNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Response.Redirect("inv_procurementdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYes.Click
        If lblSelectedVendor.Text = 1 Then
            SaveCreatePOSupA()
        End If

        If lblSelectedVendor.Text = 2 Then
            SaveCreatePOSupB()
        End If

        If lblSelectedVendor.Text = 3 Then
            SaveCreatePOSupC()
        End If

        panelInfo.Visible = False
        panelSuccess.Visible = True
        panelGrid.Visible = True
        btnYes.Visible = False
        btnNo.Visible = False
    End Sub

    Private Sub btnCompleted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCompleted.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_ProcurementDTLCompleted_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Complete")
        objCommand.Parameters.Add("@por_id", Request("id"))
        objCommand.Parameters.Add("@Session_fullname", Session("fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try

        'reset and rebind       
        txtPageNo.Text = 1
        DisplayHeader()
        GridBind()

        panelInfo.Visible = False
        panelSuccess.Visible = True
        panelGrid.Visible = True
        btnYes.Visible = False
        btnNo.Visible = False
    End Sub
End Class

