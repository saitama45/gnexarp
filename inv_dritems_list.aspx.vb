
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.IO

Public Class inv_dritems_list
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
    Protected WithEvents btnSaveLoan As System.Web.UI.WebControls.Button
    Protected WithEvents btnX As System.Web.UI.WebControls.Button
    Protected WithEvents btnXLoan As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFormActionLoan As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMessageLoan As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents lblModeLoan As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid3 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents lblIDLoan As System.Web.UI.WebControls.Label
    Protected WithEvents hlViewFullHistory As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents ValidationSummaryLoan As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelLoan As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid As System.Web.UI.WebControls.Panel
    Protected WithEvents panelOnProcess As System.Web.UI.WebControls.Panel
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
    Protected WithEvents btnPrintSO As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnPrintSI As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnPrintQuote As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPRRefNo As System.Web.UI.WebControls.Label    
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents cbIsFree As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox    
    Protected WithEvents lblRecentSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblCurrentSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblInvoiceNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblSIDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblDRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblSONo As System.Web.UI.WebControls.Label
    Protected WithEvents lblSODate As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientName As System.Web.UI.WebControls.Label
    Protected WithEvents lblVatableSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblVAT As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscount As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblSelectWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents ddlWarehouse As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblWarehouse As System.Web.UI.WebControls.Label    
    Protected WithEvents lblSourceWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblOnProcessSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH As System.Web.UI.WebControls.Label    
    Protected WithEvents lblRemainingSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblOnProcessSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblAmount As System.Web.UI.WebControls.Label
    Protected WithEvents btnUploadSO As System.Web.UI.WebControls.Button
    Protected WithEvents FileUploadSO As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents tblShowValidation As System.Web.UI.WebControls.Table
    Protected WithEvents panelUpload As System.Web.UI.WebControls.Panel
    Protected WithEvents txtSINo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calSIDate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlClient As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscountHDR As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintSOImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintSIImg As System.Web.UI.WebControls.ImageButton    
    Protected WithEvents btnReplicateImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnVoidImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents panelVoid As System.Web.UI.WebControls.Panel
    Protected WithEvents btnYes As System.Web.UI.WebControls.Button
    Protected WithEvents btnNo As System.Web.UI.WebControls.Button
    Protected WithEvents txtLessAmount As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblResult As System.Web.UI.HtmlControls.HtmlInputText
    Protected WithEvents txtNote2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlSalesPerson As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblSerial As System.Web.UI.WebControls.Label
    Protected WithEvents panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblISSID As System.Web.UI.WebControls.Label
    Protected WithEvents btnLoan As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnInTransit As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lblNetSalesLoan As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetSalesLoanShow As System.Web.UI.WebControls.Label
    Protected WithEvents txtDownpayment As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRegistration As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDocsStamp As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblApprovableLoanAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovableLoanAmountShow As System.Web.UI.WebControls.Label
    Protected WithEvents ddlMonthsToPay As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblMonthlyPayment As System.Web.UI.WebControls.Label
    Protected WithEvents lblMonthlyPaymentShow As System.Web.UI.WebControls.Label    
    Protected WithEvents btnCalculate As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrintAmort As System.Web.UI.WebControls.LinkButton
    Protected WithEvents calStartPayDate As eWorld.UI.CalendarPopup
    Protected WithEvents btnOnlineStore As System.Web.UI.WebControls.LinkButton
    Protected WithEvents panelOnlineStore As System.Web.UI.WebControls.Panel
    Protected WithEvents lblModeOnlineStore As System.Web.UI.WebControls.Label
    Protected WithEvents txtFormActionOnlineStore As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblIDOnlineStoreID As System.Web.UI.WebControls.Label
    Protected WithEvents lblOrderNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayType As System.Web.UI.WebControls.Label
    Protected WithEvents lblRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblFullname As System.Web.UI.WebControls.Label
    Protected WithEvents lblHouseDetails As System.Web.UI.WebControls.Label
    Protected WithEvents lblBaranggay As System.Web.UI.WebControls.Label
    Protected WithEvents lblCity As System.Web.UI.WebControls.Label
    Protected WithEvents lblPostalCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblOnlineStoreCustomerEmail As System.Web.UI.WebControls.Label
    Protected WithEvents lblMobileNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblOnlineNotes As System.Web.UI.WebControls.Label
    Protected WithEvents lblCartTotalShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblCartTotal As System.Web.UI.WebControls.Label
    Protected WithEvents lblShippingFeeShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblShippingFee As System.Web.UI.WebControls.Label
    Protected WithEvents lblOrderTotalShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblOrderTotal As System.Web.UI.WebControls.Label
    Protected WithEvents txtBudget As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPONo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtProjectDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents chbIsVatExclusive As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbIsNonVat As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    Protected WithEvents panelForm2 As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMode2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtFormAction2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnX2 As System.Web.UI.WebControls.Button
    Protected WithEvents lblID2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtSKUCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtItemDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSOQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSOUOM As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSOUnitCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNotes As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSave2 As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblDRItemsID As System.Web.UI.WebControls.Label


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
    Public strStoredProc As String = "inv_dritems_list"
    Public strStoredProc2 As String = "Inv_SOSubItems_List"
    Public strStoredProc3 As String = "Inv_DRItemsOnProcess_Get"
    Public strSubMenuName As String = "inv_dritems_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblStatus.Text = "ON PROCESS" Then
            txtFormAction.Text = "Add"
            lblMode.ForeColor = Color.Green
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

            ReadyAdd()
        Else
            If Session("group") = "ADMIN" Then
                txtFormAction.Text = "Add"
                lblMode.ForeColor = Color.Green
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

                ReadyAdd()
            Else
                btnAddRecord.Visible = False
            End If
        End If

    End Sub
    Private Sub ReadyAdd()

        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelLoan.Visible = False
        panelOnlineStore.Visible = False

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_WarehouseCompany_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlWarehouse.DataSource = objReader
        ddlWarehouse.DataValueField = "code"
        ddlWarehouse.DataTextField = "name"
        ddlWarehouse.DataBind()
        ddlWarehouse.Items.Insert(0, "")
        ddlWarehouse.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlSalesPerson.DataSource = objReader
        ddlSalesPerson.DataValueField = "name"
        ddlSalesPerson.DataTextField = "name"
        ddlSalesPerson.DataBind()
        ddlSalesPerson.Items.Insert(0, "")
        ddlSalesPerson.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        ClearInputs()

    End Sub
    Private Sub ClearInputs()

        lblID.Text = 0

        lblOnProcessSOH.Text = 0
        lblRemainingSOH.Text = 0
        lblOnProcessSOH2.Text = 0
        lblRemainingSOH2.Text = 0

        ddlWarehouse.Enabled = True

        txtBarcode.Text = ""
        txtBarcode.Enabled = True

        lblSRP.Text = 0
        txtSRP.Text = 0
        txtSRP.Enabled = True

        txtDiscount.Text = 0
        txtDiscount.Enabled = True

        txtQty.Text = 0
        txtQty.Enabled = True

        txtNote2.Text = ""
        txtNote2.Enabled = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Items.Insert(0, "")
        ddlRawMats.SelectedIndex = 0
        ddlRawMats.Items.Insert(0, "")
        ddlRawMats.SelectedIndex = 0
        ddlRawMats.Enabled = True
        objReader.Close()

        objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlSalesPerson.DataSource = objReader
        ddlSalesPerson.DataValueField = "name"
        ddlSalesPerson.DataTextField = "name"
        ddlSalesPerson.DataBind()
        ddlSalesPerson.Items.Insert(0, "")
        ddlSalesPerson.SelectedIndex = 0
        ddlSalesPerson.Enabled = True
        objReader.Close()

        objConnection.Close()

        cbIsFree.Checked = False
        cbIsFree.Enabled = True

        SetFocus(ddlRawMats)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()

        Refresh_Computation()

    End Sub
    Private Sub ReadyEdit()

        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelLoan.Visible = False
        panelOnlineStore.Visible = False

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strWarehouse = Trim(objReader("warehouse"))
        Dim strItem As String = objReader("itemdtl_id")
        Dim strSalesPerson As String = objReader("sales_person")

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        If Session("group") = "ADMIN" Then

            lblID.Text = Trim(objReader("id"))

            txtBarcode.Text = Trim(objReader("barcode"))
            txtBarcode.Enabled = True

            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = True

            txtSRP.Text = Trim(objReader("cost"))
            txtSRP.Enabled = True

            txtDiscount.Text = Trim(objReader("discount_edit"))
            txtDiscount.Enabled = True

            txtNote2.Text = Trim(objReader("note"))
            txtNote2.Enabled = True

            objReader.Close()

            objCommand = New SqlCommand("Ref_WarehouseCompany_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "name"
            ddlWarehouse.DataBind()
            ddlWarehouse.Enabled = True
            objReader.Close()

            ddlWarehouse.SelectedIndex = ddlWarehouse.Items.IndexOf(ddlWarehouse.Items.FindByValue(strWarehouse.ToString))

            objCommand = New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            ddlRawMats.DataSource = objReader
            ddlRawMats.DataValueField = "code"
            ddlRawMats.DataTextField = "name"
            ddlRawMats.DataBind()
            ddlRawMats.Enabled = True
            objReader.Close()

            ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strItem.ToString))

            objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlSalesPerson.DataSource = objReader
            ddlSalesPerson.DataValueField = "name"
            ddlSalesPerson.DataTextField = "name"
            ddlSalesPerson.DataBind()
            ddlSalesPerson.Enabled = True
            objReader.Close()

            ddlSalesPerson.SelectedIndex = ddlSalesPerson.Items.IndexOf(ddlSalesPerson.Items.FindByValue(strSalesPerson.ToString))

        Else

            lblID.Text = Trim(objReader("id"))

            txtBarcode.Text = Trim(objReader("barcode"))
            txtBarcode.Enabled = bolChangeable

            txtSRP.Text = Trim(objReader("cost"))
            txtSRP.Enabled = bolChangeable

            txtDiscount.Text = Trim(objReader("discount_edit"))
            txtDiscount.Enabled = bolChangeable

            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = bolChangeable

            txtNote2.Text = Trim(objReader("note"))
            txtNote2.Enabled = bolChangeable

            Dim intIsFree As String = Trim(objReader("isfree"))

            If intIsFree = "Yes" Then cbIsFree.Checked = True Else cbIsFree.Checked = False
            cbIsFree.Enabled = bolChangeable

            objReader.Close()

            objCommand = New SqlCommand("Ref_WarehouseCompany_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "name"
            ddlWarehouse.DataBind()
            ddlWarehouse.Enabled = bolChangeable
            objReader.Close()

            ddlWarehouse.SelectedIndex = ddlWarehouse.Items.IndexOf(ddlWarehouse.Items.FindByValue(strWarehouse.ToString))

            objCommand = New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            ddlRawMats.DataSource = objReader
            ddlRawMats.DataValueField = "code"
            ddlRawMats.DataTextField = "name"
            ddlRawMats.DataBind()
            ddlRawMats.Enabled = bolChangeable
            objReader.Close()

            ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strItem.ToString))

            objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlSalesPerson.DataSource = objReader
            ddlSalesPerson.DataValueField = "name"
            ddlSalesPerson.DataTextField = "name"
            ddlSalesPerson.DataBind()
            ddlSalesPerson.Enabled = bolChangeable
            objReader.Close()

            ddlSalesPerson.SelectedIndex = ddlSalesPerson.Items.IndexOf(ddlSalesPerson.Items.FindByValue(strSalesPerson.ToString))

        End If

        objConnection.Close()

        Refresh_DefaultSRP()
        Refresh_CurrentSOH()
        Refresh_Computation()
        Refresh_Serial()

        SetFocus(txtQty)

    End Sub

    Private Sub ReadyDelete()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelLoan.Visible = False
        panelOnlineStore.Visible = False

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))

        txtBarcode.Text = Trim(objReader("barcode"))
        txtBarcode.Enabled = False

        txtSRP.Text = Trim(objReader("cost"))
        txtSRP.Enabled = False

        txtDiscount.Text = Trim(objReader("discount_edit"))
        txtDiscount.Enabled = False

        txtQty.Text = Trim(objReader("qty"))
        txtQty.Enabled = False

        txtNote2.Text = Trim(objReader("note"))
        txtNote2.Enabled = False

        Dim intIsFree As String = Trim(objReader("isfree"))

        If intIsFree = "Yes" Then cbIsFree.Checked = True Else cbIsFree.Checked = False
        cbIsFree.Enabled = False

        Dim strRawMats As String = objReader("itemdtl_id")
        Dim strWarehouse = Trim(objReader("warehouse"))
        Dim strSalesPerson = Trim(objReader("sales_person"))

        objReader.Close()

        objCommand = New SqlCommand("Ref_WarehouseCompany_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        objReader = objCommand.ExecuteReader
        ddlWarehouse.DataSource = objReader
        ddlWarehouse.DataValueField = "code"
        ddlWarehouse.DataTextField = "name"
        ddlWarehouse.DataBind()
        ddlWarehouse.Enabled = False
        objReader.Close()

        ddlWarehouse.SelectedIndex = ddlWarehouse.Items.IndexOf(ddlWarehouse.Items.FindByValue(strWarehouse.ToString))

        objCommand = New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        objReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Enabled = False
        objReader.Close()
        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

        objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlSalesPerson.DataSource = objReader
        ddlSalesPerson.DataValueField = "name"
        ddlSalesPerson.DataTextField = "name"
        ddlSalesPerson.DataBind()
        ddlSalesPerson.Enabled = False
        objReader.Close()

        ddlSalesPerson.SelectedIndex = ddlSalesPerson.Items.IndexOf(ddlSalesPerson.Items.FindByValue(strSalesPerson.ToString))

        objConnection.Close()

        Refresh_DefaultSRP()
        Refresh_CurrentSOH()
        Refresh_Computation()
        Refresh_Serial()

        SetFocus(txtQty)

    End Sub
    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@dr_code", lblDRCode.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)

        Dim intIsFree As Integer

        If cbIsFree.Checked Then
            intIsFree = 1
            objCommand.Parameters.Add("@isfree", intIsFree)
        Else
            intIsFree = 0
            objCommand.Parameters.Add("@isfree", intIsFree)
        End If

        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@discount", txtDiscount.Text)
        objCommand.Parameters.Add("@note", txtNote2.Text)
        objCommand.Parameters.Add("@sales_person", ddlSalesPerson.SelectedValue)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))
        objCommand.Parameters.Add("@shipping_fee", lblShippingFee.Text)

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
                                        "Warehouse: " + lblSourceWarehouse.Text + " > Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text + " > SRP: " + txtSRP.Text + " > Discount: " + txtDiscount.Text, _
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
        Dim objCommand As New SqlCommand("Inv_DRItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@dr_code", lblDRCode.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@def_srp", lblSRP.Text)
        objCommand.Parameters.Add("@current_soh", lblCurrentSOH.Text)
        objCommand.Parameters.Add("@onprocess_soh", lblOnProcessSOH.Text)
        objCommand.Parameters.Add("@remaining_soh", lblRemainingSOH.Text)
        objCommand.Parameters.Add("@remaining_soh2", lblRemainingSOH2.Text)

        Dim intIsFree As Integer

        If cbIsFree.Checked Then
            intIsFree = 1
            objCommand.Parameters.Add("@isfree", intIsFree)
        Else
            intIsFree = 0
            objCommand.Parameters.Add("@isfree", intIsFree)
        End If

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
    Private Sub Refresh_Items()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
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

        SetFocus(ddlRawMats)

    End Sub
    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged
        Refresh_SRP()
        Refresh_CurrentSOH()
        Refresh_Serial()
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'lblAmount.Visible = True
        'lblAmount.Text = (txtSRP.Text * txtQty.Text) - ((txtSRP.Text * txtQty.Text) * (txtDiscount.Text / 100))

        'Dim dblAmount As Double = lblAmount.Text
        'dblAmount = Math.Round(dblAmount, 2)

        'lblAmount.Text = dblAmount.ToString("#,##0.00")

        SetFocus(txtQty)
    End Sub
    Private Sub Refresh_Serial()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Inv_IsNullSerial_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        If txtFormAction.Text = "Add" Then
            objCommand.Parameters.Add("@id", ddlRawMats.SelectedValue)
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        Else
            objCommand.Parameters.Add("@id", lblID.Text)
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        End If
        
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblSerial.Text = Trim(objReader("serial"))

        If IsDBNull(Trim(objReader("serial"))) Then

            panel1.Visible = True
            panel2.Visible = False
        Else
            panel1.Visible = False
            panel2.Visible = True
        End If

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub Refresh_CurrentSOH()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_RemainingSOH2_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@ud_id", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblCurrentSOH.Text = Trim(objReader("soh"))
        lblOnProcessSOH.Text = Trim(objReader("onprocess_soh"))
        lblRemainingSOH.Text = Trim(objReader("remaining_soh"))

        lblRemainingSOH2.Text = Trim(objReader("remaining_soh2"))
        lblOnProcessSOH2.Text = Trim(objReader("onprocess_soh2"))

        objReader.Close()
        objConnection.Close()

        GridBind3()

    End Sub
    Private Sub Refresh_SRP()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_ItemsSRP_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@customer", lblClientCode.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtBarcode.Text = Trim(objReader("barcode"))
        txtSRP.Text = Trim(objReader("srp"))
        lblSRP.Text = Trim(objReader("srp"))
        txtQty.Text = 0

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub Refresh_DefaultSRP()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_ItemsSRP_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@customer", lblClientCode.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtBarcode.Text = Trim(objReader("barcode"))
        lblSRP.Text = Trim(objReader("srp"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
        Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "warehouse", _
                                    "", _
                                    "barcode", _
                                    "item_code", _
                                    "rm_name", _
                                    "rm_code", _
                                    "expiry_date", _
                                    "uom", _
                                    "qty", _
                                    "cost", _
                                    "discount", _
                                    "isfree", _
                                    "total_srp", _
                                    "net_cost", _
                                    "note", _
                                    "sales_person", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Warehouse", _
                                    "DR #", _
                                    "Barcode", _
                                    "Item Code", _
                                    "Item", _
                                    "Lot#/Serial#", _
                                    "Expiry Date", _
                                    "UOM", _
                                    "Qty", _
                                    "SRP", _
                                    "Discount", _
                                    "Is Free?", _
                                    "Total Amount", _
                                    "Net Amt", _
                                    "Note", _
                                    "Sales Person", _
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
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "", _
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
                                    "", _
                                    "", _
                                    "DS", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "", _
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

            If lblStatus.Text = "ON PROCESS" Then

                If lblNetSales.Text = "0.00" Then
                    FileUploadSO.Visible = True
                    btnUploadSO.Visible = True
                    panelUpload.Visible = True

                    btnAddImg.Visible = True
                    btnAddImg2.Visible = True
                    'btnAddRecord.Text = "Add Item"

                    btnPrintSO.Visible = False
                    btnPrintSI.Visible = False
                    btnPrint.Visible = False
                    btnLoan.Visible = False

                Else
                    FileUploadSO.Visible = False
                    btnUploadSO.Visible = False
                    panelUpload.Visible = False

                    btnAddImg.Visible = True
                    btnAddImg2.Visible = True
                    'btnAddRecord.Text = "Add Item"

                    btnPrintSO.Visible = True

                    If lblInvoiceNo.Text = "" Then
                        btnPrintSI.Visible = False
                    Else
                        btnPrintSI.Visible = True
                    End If

                    btnPrint.Visible = False
                    btnLoan.Visible = True

                End If

                btnVoidImg.Visible = False
                btnInTransit.Visible = False

            ElseIf lblStatus.Text = "POSTED" Or lblStatus.Text = "FOR DELIVERY" Or lblStatus.Text = "DELIVERED" Then
                btnAddImg.Visible = False
                btnAddImg2.Visible = False
                btnPrint.Visible = True
                btnPrintSO.Visible = True
                btnPrintSI.Visible = True
                FileUploadSO.Visible = False
                btnUploadSO.Visible = False
                panelUpload.Visible = False
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Enabled = False
                btnSaveImg.Visible = False
                btnVoidImg.Visible = True

                If lblStatus.Text = "DELIVERED" Then
                    btnInTransit.Visible = False
                Else
                    btnInTransit.Visible = True
                End If

            Else
                btnAddImg.Visible = False
                btnAddImg2.Visible = False
                btnPrint.Visible = False
                btnPrintSO.Visible = False
                btnPrintSI.Visible = False
                FileUploadSO.Visible = False
                btnUploadSO.Visible = False
                panelUpload.Visible = False
                lblSelectWarehouse.Visible = True
                ddlWarehouse.Visible = True
                btnVoidImg.Visible = False
                btnInTransit.Visible = False
            End If

            If lblOrderNo.Text <> "" Then
                btnOnlineStore.Visible = True

            Else
                btnOnlineStore.Visible = False
            End If

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button
                btnSaveImg.Visible = False
                btnAddImg.Visible = False
                btnAddImg2.Visible = False
                btnPrint.Visible = False
                btnPrintSO.Visible = False
                btnPrintSI.Visible = False
                FileUploadSO.Visible = False
                btnUploadSO.Visible = False
                panelUpload.Visible = False
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Visible = False
                btnVoidImg.Visible = False
                btnInTransit.Visible = False
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
                                    lblISSID.Text)

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

        If txtQty.Text = Nothing Or txtQty.Text.Length > 0 And txtQty.Text.Trim().Length = 0 Then 'txtName.Text.Length > 0 And txtName.Text.Trim().Length = 0 to handle empty and white spaces
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = "Qty is required."
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
                        lblValidate.Visible = False

                        'Session("last_isdtl_sku") = ddlRawMats.SelectedValue
                        'ReadyAdd()
                        SetFocus(ddlRawMats)

                        lblOnProcessSOH.Text = 0
                        lblRemainingSOH.Text = 0
                        lblOnProcessSOH2.Text = 0
                        lblRemainingSOH2.Text = 0

                        ddlRawMats.SelectedIndex = 0
                        txtQty.Text = 0
                        lblResult.Value = 0
                        txtSRP.Text = 0
                        txtDiscount.Text = 0
                        txtNote2.Text = Nothing
                        ddlSalesPerson.SelectedIndex = 0

                        DisplayHeader()
                        txtPageNo.Text = 1
                        GridBind()
                        btnPrintSO.Visible = True

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
        Dim objCommand As New SqlCommand("Inv_Issuance_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strCustomer As String = objReader("customer")

        Dim bolChangeable As Boolean = objReader("status") = "ON PROCESS"

        lblCompany.Text = Session("company_code")

        lblIDOnlineStoreID.Text = Trim(objReader("ship_id"))

        lblOrderNo.Text = Trim(objReader("order_no"))
        lblPayType.Text = Trim(objReader("pay_type"))
        lblRefNo.Text = Trim(objReader("ref_no"))
        lblFullname.Text = Trim(objReader("Fullname"))
        lblHouseDetails.Text = Trim(objReader("home_details"))
        lblBaranggay.Text = Trim(objReader("barangay"))
        lblCity.Text = Trim(objReader("city"))
        lblPostalCode.Text = Trim(objReader("zip_code"))
        lblOnlineStoreCustomerEmail.Text = Trim(objReader("onlinestore_customeremail"))
        lblMobileNo.Text = Trim(objReader("mobile_no"))
        lblOnlineNotes.Text = Trim(objReader("online_notes"))

        lblCartTotalShow.Text = Trim(objReader("cart_total_show"))
        lblCartTotal.Text = Trim(objReader("cart_total"))

        lblShippingFeeShow.Text = Trim(objReader("shipping_fee_show"))
        lblShippingFee.Text = Trim(objReader("shipping_fee"))

        lblOrderTotalShow.Text = Trim(objReader("grand_total_show"))
        lblOrderTotal.Text = Trim(objReader("grand_total"))

        lblISSID.Text = objReader("id")
        lblStatus.Text = objReader("status")

        txtBudget.Text = objReader("budget_amount")
        txtBudget.Enabled = bolChangeable

        lblInvoiceNo.Text = objReader("invoice_no")
        txtSINo.Text = objReader("invoice_no")
        txtSINo.Enabled = bolChangeable

        lblSIDate.Text = objReader("si_date")
        calSIDate.SelectedDate = objReader("si_date")
        calSIDate.Enabled = bolChangeable

        lblDRCode.Text = objReader("dr_code")

        lblSONo.Text = objReader("so_no")
        lblSODate.Text = objReader("so_date")

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

        lblClientName.Text = objReader("client")
        lblClientCode.Text = objReader("client_code")
        lblVatableSales.Text = objReader("vatable_sales")
        lblVAT.Text = objReader("vat")
        lblNetAmount.Text = objReader("net_amount")

        lblDiscount.Text = objReader("discount")
        txtDiscountHDR.Text = objReader("discount_edit")
        txtDiscountHDR.Enabled = bolChangeable

        txtLessAmount.Text = objReader("less")
        txtLessAmount.Enabled = bolChangeable

        lblNetSales.Text = objReader("net_sales")

        txtNote.Text = objReader("note")
        txtNote.Enabled = bolChangeable

        txtPONo.Text = objReader("po_no")
        txtPONo.Enabled = bolChangeable

        txtProjectDesc.Text = objReader("project_desc")
        txtProjectDesc.Enabled = bolChangeable

        If Trim(objReader("total_item")) > 0 Then
            ddlClient.Enabled = False
        Else
            ddlClient.Enabled = bolChangeable
        End If

        objReader.Close()

        objCommand = New SqlCommand("Ref_Clients_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlClient.DataSource = objReader
        ddlClient.DataValueField = "code"
        ddlClient.DataTextField = "name"
        ddlClient.DataBind()
        objReader.Close()

        objConnection.Close()

        ddlClient.SelectedIndex = ddlClient.Items.IndexOf(ddlClient.Items.FindByValue(strCustomer.ToString))

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

        If lblInvoiceNo.Text = "" Then
            btnPrintSI.Visible = False
        Else
            btnPrintSI.Visible = True
        End If
    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_issuance_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "FIXUS" Then
            SetEndPopup("trx_dr_form_fixus?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "PHPMED" Then
            SetEndPopup("trx_dr_form_phpmed?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "SFS" Or Session("company_code") = "MCTI" Then
            SetEndPopup("trx_dr_form_sfs?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "COSMOMED" And Trim(objReader("sosi_count")) > 0 Then
            SetEndPopup("trx_dr_form_cmi_itemized?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "COSMOMED" Then
            SetEndPopup("trx_dr_form_cosmomed?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        Else
            SetEndPopup("trx_dr_form?code=" & lblDRCode.Text & _
               " &id=" & Request("id") & _
               " &formaction=" & "Print")


        End If

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_dritems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
        panelLoan.Visible = False
        panelSuccess.Visible = False

    End Sub

    Private Sub btnPrintSO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintSO.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "CTEMS" Then

            SetEndPopup("trx_so_form_ctems?code=" & lblDRCode.Text & _
                                       " &id=" & Request("id") & _
                                       " &formaction=" & "Print")

        ElseIf Session("company_code") = "ECPACK" Then

            SetEndPopup("trx_so_form_ecpack?code=" & lblDRCode.Text & _
                                       " &id=" & Request("id") & _
                                       " &formaction=" & "Print")

        ElseIf Session("company_code") = "COSMOMED" Then

            SetEndPopup("trx_so_form_cosmomed?code=" & lblDRCode.Text & _
                                       " &id=" & Request("id") & _
                                       " &formaction=" & "Print")

        Else
            SetEndPopup("trx_so_form?code=" & lblDRCode.Text & _
                           " &id=" & Request("id") & _
                           " &formaction=" & "Print")
        End If




        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub btnPrintSI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintSI.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "FIXUS" Then
            SetEndPopup("trx_si_form_fixus?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "PHPMED" Then
            SetEndPopup("trx_si_form_phpmed?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "CTEMS" Then
            SetEndPopup("trx_si_form_ctems?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "ECPACK" Then
            SetEndPopup("trx_si_form_ecpack?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        ElseIf Session("company_code") = "COSMOMED" Then
            SetEndPopup("trx_si_form_cosmomed?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        Else
            SetEndPopup("trx_si_form?code=" & lblDRCode.Text & _
                            " &id=" & Request("id") & _
                            " &formaction=" & "Print")

        End If

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        Refresh_Items()
        Refresh_CurrentSOH()

        panelSuccess.Visible = False
        panelInfo.Visible = False
        DisplayHeader()

    End Sub
    Protected Sub UploadSO(ByVal sender As Object, ByVal e As EventArgs)

        Dim csvPath As String = Server.MapPath("~/Uploads/") + "uploadedDRems.txt"
        'Dim FileName As String = System.IO.Path.GetFileName(FileUploadBilling.PostedFile.FileName)
        'Dim csvPath As String = Server.MapPath("~/Uploads/") + FileName + ".txt"

        If (Not FileUploadSO.PostedFile Is Nothing) AndAlso (FileUploadSO.PostedFile.ContentLength > 0) Then

            Try
                'Upload and save the File.
                FileUploadSO.PostedFile.SaveAs(csvPath)

                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                Dim objCommand As New SqlCommand("upl_ImportDRItemsCSV", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure

                objCommand.Parameters.Add("@iss_id", lblISSID.Text)

                objConnection.Open()
                Dim objReader As SqlDataReader = objCommand.ExecuteReader
                objReader.Read()

                'Delete the temporary file
                File.Delete(csvPath)

                'validate the inputs vs. table records
                Dim strValidateUpload As String = ValidateUpload()

                'is the validation 
                If strValidateUpload = "ok" Then

                    'then save the inputs
                    Dim strSaveUpload As String = SaveUpload()

                    'is the saving successfull?
                    If strSaveUpload = "ok" Then
                        'notify and clear input boxes

                        panelSuccess.Visible = True
                        panelInfo.Visible = False
                        panelForm.Visible = False
                        lblValidate.Visible = False
                        panelGrid.Visible = True

                        'reset and rebind       
                        txtPageNo.Text = 1
                        DisplayHeader()
                        GridBind()
                        FileUploadSO.Visible = False
                        btnUploadSO.Visible = False
                        panelUpload.Visible = False
                        btnPrintSO.Visible = True

                        If lblInvoiceNo.Text = "" Then
                            btnPrintSI.Visible = False
                        Else
                            btnPrintSI.Visible = True
                        End If

                    Else
                        'notify unsucessful and the reason
                        panelInfo.Visible = True
                        lblValidate.Visible = True
                        lblValidate.Text = strSaveUpload
                    End If

                Else
                    'notify user and reason of invalidation
                    panelSuccess.Visible = False
                    panelInfo.Visible = True
                    lblValidate.Visible = True
                    lblValidate.Text = strValidateUpload

                    objReader.Close()

                    objCommand = New SqlCommand("Inv_DRItemsUpload_Validate2", objConnection)
                    objCommand.CommandType = CommandType.StoredProcedure

                    objCommand.Parameters.Add("@FormAction", "Upload")

                    objReader = objCommand.ExecuteReader

                    tblShowValidation.Visible = True

                    While objReader.Read

                        Dim tblRow As New TableRow
                        Dim tblCell As New TableCell


                        tblCell.Text = objReader("Error_Message")

                        tblRow.Cells.Add(tblCell)
                        tblShowValidation.Rows.Add(tblRow)

                    End While

                    objReader.Close()
                    objConnection.Close()
                End If
            Catch ex As Exception

                panelInfo.Visible = True
                lblValidate.Text = ex.ToString()
            End Try

        Else
            panelInfo.Visible = True
            lblValidate.Text = "Please select a file to upload."
        End If


    End Sub

    Private Function ValidateUpload()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateUpload = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItemsUpload_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Upload")

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateUpload = objReader("Error_Message")
            End While
        End If

        'objReader.Close()
        'objCommand = New SqlCommand("Inv_DRItemsUpload_Validate2", objConnection)
        'objCommand.CommandType = CommandType.StoredProcedure

        'objCommand.Parameters.Add("@FormAction", "Upload")

        'objReader = objCommand.ExecuteReader

        'lblShowValidation.Visible = True
        'lblShowValidation.Text = objReader("Error_Message")

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveUpload()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveUpload = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItemsUpload_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Upload")
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@customer", lblClientCode.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        Request("sys_table"), _
                                        "UploadedDate: " + Date.UtcNow.AddHours(8).ToShortDateString(), _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveUpload = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveUpload = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function

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

                If lblInvoiceNo.Text = "" Then
                    btnPrintSI.Visible = False
                Else
                    btnPrintSI.Visible = True
                End If

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
        Dim objCommand As New SqlCommand("Inv_Issuance_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@si_no", txtSINo.Text)

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
        Dim objCommand As New SqlCommand("Inv_IssuanceWithLessAmt_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@budget", txtBudget.Text)
        objCommand.Parameters.Add("@po_no", txtPONo.Text)
        objCommand.Parameters.Add("@project_desc", txtProjectDesc.Text)
        objCommand.Parameters.Add("@delivery_date", "1/1/1999")
        objCommand.Parameters.Add("@invoice_no", txtSINo.Text)
        objCommand.Parameters.Add("@si_date", calSIDate.SelectedDate)
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@discount", txtDiscountHDR.Text)
        objCommand.Parameters.Add("@less", txtLessAmount.Text)
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
            objCommand = New SqlCommand("Ref_Clients_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@code", ddlClient.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strClient As String = objReader("code")
            objReader.Close()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref# " + lblID.Text + " > SODate: " + calSIDate.SelectedDate + " > Customer: " + strClient + " > Terms: " + txtTerms.Text + " > Discount: " + txtDiscount.Text + " > Note: " + txtNote.Text, _
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

    Private Sub ddlClient_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlClient.SelectedIndexChanged
        Refresh_CurrentTerms()
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub Refresh_CurrentTerms()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Clients_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtTerms.Text = Trim(objReader("terms"))

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub Refresh_Computation()
        lblResult.Value = (txtSRP.Text * txtQty.Text) - ((txtSRP.Text * txtQty.Text) * (txtDiscount.Text / 100))

        Dim dblAmount As Double = lblResult.Value
        dblAmount = Math.Round(dblAmount, 2)

        lblResult.Value = dblAmount.ToString("#,##0.00")

        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub cbIsFree_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbIsFree.CheckedChanged


        If cbIsFree.Checked = True Then
            txtDiscount.Text = 0
            lblResult.Value = 0

        Else
            Refresh_Computation()

        End If

        panelSuccess.Visible = False
        panelInfo.Visible = False

    End Sub

    Private Sub txtSINo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSINo.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub calSIDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calSIDate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtTerms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerms.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    'Private Sub txtDiscountHDR_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscountHDR.TextChanged
    '    SaveHeaderClick()
    '    panelSuccess.Visible = False
    '    panelInfo.Visible = False
    'End Sub

    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtLessAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLessAmount.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm2.Visible = False
    End Sub

    Private Sub btnVoidImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnVoidImg.Click
        panelVoid.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub btnNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Response.Redirect("inv_dritems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
        panelSuccess.Visible = False
        panelSuccess.Visible = True
    End Sub

    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Dim strSaveInput As String = SaveVoid()

        'is the saving successfull?
        If strSaveInput = "ok" Then
            'notify and clear input boxes

            panelSuccess.Visible = True
            panelInfo.Visible = False
            panelForm.Visible = False
            lblValidate.Visible = False
            panelGrid.Visible = True
            panelVoid.Visible = False

            'reset and rebind       
            DataGrid.SelectedIndex = -1
            GridBind()
            DisplayHeader()

        Else
            'notify unsucessful and the reason
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strSaveInput
        End If
    End Sub
    Private Function SaveVoid()
        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveVoid = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Void_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Void")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref# " + Request("id") + " > CancelledDate: " + Date.UtcNow, _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error          
            SaveVoid = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try
    End Function

    Private Sub btnLoan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoan.Click
        panelLoan.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelOnlineStore.Visible = False

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Inv_Issuance_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        'read and fill the boxes
        objReader.Read()

        Dim strLoanTerms = Trim(objReader("loan_terms"))

        lblNetSalesLoanShow.Text = Trim(objReader("total_net_cost_show"))
        lblNetSalesLoan.Text = Trim(objReader("total_net_cost"))

        txtDownpayment.Text = Trim(objReader("downpayment"))
        txtDownpayment.Enabled = bolChangeable

        txtRegistration.Text = Trim(objReader("registration"))
        txtRegistration.Enabled = bolChangeable

        txtDocsStamp.Text = Trim(objReader("docs_stamp"))
        txtDocsStamp.Enabled = bolChangeable

        lblApprovableLoanAmountShow.Text = Trim(objReader("loan_amount_show"))
        lblApprovableLoanAmount.Text = Trim(objReader("loan_amount"))

        lblMonthlyPaymentShow.Text = Trim(objReader("monthly_amort_show"))
        lblMonthlyPayment.Text = Trim(objReader("monthly_amort"))

        If Trim(objReader("first_amort_date")) = "01/01/1999" Then
            calStartPayDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        Else
            calStartPayDate.SelectedDate = Trim(objReader("first_amort_date"))
        End If
        calStartPayDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calStartPayDate.Enabled = bolChangeable

        btnSaveLoan.Visible = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_LoanMonths_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlMonthsToPay.DataSource = objReader
        ddlMonthsToPay.DataValueField = "code"
        ddlMonthsToPay.DataTextField = "code"
        ddlMonthsToPay.DataBind()
        ddlMonthsToPay.Enabled = bolChangeable
        ddlMonthsToPay.SelectedIndex = ddlMonthsToPay.Items.IndexOf(ddlMonthsToPay.Items.FindByValue(strLoanTerms.ToString))

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnXLoan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXLoan.Click
        Response.Redirect("inv_dritems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
        panelForm.Visible = False
        panelLoan.Visible = False
        panelSuccess.Visible = False
    End Sub

    Private Sub btnSaveLoan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveLoan.Click

        'validate the inputs vs. table records
        Dim strValidateLoan As String = ValidateLoan()

        'is the validation 
        If strValidateLoan = "ok" Then
            'then save the inputs
            Dim strSaveLoan As String = SaveLoan()

            'is the saving successfull?
            If strSaveLoan = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelLoan.Visible = False
                panelForm.Visible = False
                lblValidate.Visible = False

                DisplayHeader()
                txtPageNo.Text = 1
                GridBind()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveLoan
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateLoan
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If

    End Sub
    Private Function ValidateLoan()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateLoan = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItemsLoan_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@first_amort_date", calStartPayDate.SelectedDate)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateLoan = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveLoan()
        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveLoan = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DRItemsLoan_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@downpayment", txtDownpayment.Text)
        objCommand.Parameters.Add("@registration", txtRegistration.Text)
        objCommand.Parameters.Add("@docstamp", txtDocsStamp.Text)
        objCommand.Parameters.Add("@loan_terms", ddlMonthsToPay.SelectedValue)
        objCommand.Parameters.Add("@loan_amount", lblApprovableLoanAmount.Text)
        objCommand.Parameters.Add("@monthly_payment", lblMonthlyPayment.Text)
        objCommand.Parameters.Add("@first_amort_date", calStartPayDate.SelectedDate)

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
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text, _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveLoan = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveLoan = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try
    End Function

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        panelLoan.Visible = True
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_LoanMonthsCalc_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@srp", lblNetSalesLoan.Text)
        objCommand.Parameters.Add("@dp", txtDownpayment.Text)
        objCommand.Parameters.Add("@registration", txtRegistration.Text)
        objCommand.Parameters.Add("@docs_stamp", txtDocsStamp.Text)
        objCommand.Parameters.Add("@loan_months", ddlMonthsToPay.SelectedValue)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        objReader.Read()

        lblApprovableLoanAmountShow.Text = Trim(objReader("approvable_amount_show"))
        lblApprovableLoanAmount.Text = Trim(objReader("approvable_amount"))

        lblMonthlyPaymentShow.Text = Trim(objReader("monthly_payment_show"))
        lblMonthlyPayment.Text = Trim(objReader("monthly_payment"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnPrintAmort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintAmort.Click

        SetEndPopup("inv_dritems_printamort?id=" & Request("id") & _
                " &monthly_payment=" & lblMonthlyPayment.Text & _
                " &loan_terms=" & ddlMonthsToPay.SelectedValue & _
                " &loan_amount=" & lblApprovableLoanAmountShow.Text & _
                " &start_paydate=" & calStartPayDate.SelectedDate & _
                " &formaction=" & "Print")

    End Sub

    Private Sub btnInTransit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInTransit.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_DRItemsTransit_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@iss_id", Request("id"))

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

        DisplayHeader()
        panelSuccess.Visible = True
        panelInfo.Visible = False
    End Sub

    Private Sub btnOnlineStore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOnlineStore.Click
        panelOnlineStore.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False
        panelLoan.Visible = False

    End Sub

    Private Sub txtBudget_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBudget.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtProjectDesc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjectDesc.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtPONo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPONo.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
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

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        If e.CommandName = "Open" Then

            lblDRItemsID.Text = strKeyFieldValue

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

        txtSOQty.Text = 0
        txtSOQty.Enabled = True

        txtSOUOM.Text = ""
        txtSOUOM.Enabled = True

        txtSOUnitCost.Text = 0
        txtSOUnitCost.Enabled = True

        txtNotes.Text = ""
        txtNotes.Enabled = True

        SetFocus(txtSKUCode)

    End Sub
    Sub GridBind2()

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
                                    lblDRItemsID.Text)

    End Sub
    Private Sub DataGrid2_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid2.EditCommand
        'mark the selected item 
        DataGrid2.SelectedIndex = e.Item.ItemIndex

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
    Private Sub DataGrid2_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid2.DeleteCommand
        'mark the selected item 
        DataGrid2.SelectedIndex = e.Item.ItemIndex

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
        Dim strKeyFieldValue As String = DataGrid2.DataKeys(DataGrid2.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_SOSubItems_Get", objConnection)
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

        txtSOQty.Text = Trim(objReader("qty"))
        txtSOQty.Enabled = bolChangeable

        txtSOUOM.Text = Trim(objReader("uom"))
        txtSOUOM.Enabled = bolChangeable

        txtSOUnitCost.Text = Trim(objReader("unit_cost"))
        txtSOUnitCost.Enabled = bolChangeable

        txtNotes.Text = Trim(objReader("notes"))
        txtNotes.Enabled = bolChangeable

        objReader.Close()

        objConnection.Close()

        SetFocus(txtSKUCode)


    End Sub
    Private Sub ReadyDelete2()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid2.DataKeys(DataGrid2.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_SOSubItems_Get", objConnection)
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

        txtSOQty.Text = Trim(objReader("qty"))
        txtSOQty.Enabled = False

        txtSOUOM.Text = Trim(objReader("uom"))
        txtSOUOM.Enabled = False

        txtSOUnitCost.Text = Trim(objReader("unit_cost"))
        txtSOUnitCost.Enabled = False

        txtNotes.Text = Trim(objReader("notes"))
        txtNotes.Enabled = False

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
        Dim objCommand As New SqlCommand("Inv_SOSubItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@dritems_id", lblDRItemsID.Text)
        objCommand.Parameters.Add("@sku_code", txtSKUCode.Text)
        objCommand.Parameters.Add("@item_desc", txtItemDesc.Text)
        objCommand.Parameters.Add("@qty", txtSOQty.Text)
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
        Dim objCommand As New SqlCommand("Inv_SOSubItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)
        objCommand.Parameters.Add("@id", lblID2.Text)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@dritems_id", lblDRItemsID.Text)
        objCommand.Parameters.Add("@sku_code", txtSKUCode.Text)
        objCommand.Parameters.Add("@item_desc", txtItemDesc.Text)
        objCommand.Parameters.Add("@qty", txtSOQty.Text)
        objCommand.Parameters.Add("@uom", txtSOUOM.Text)
        objCommand.Parameters.Add("@unit_cost", txtSOUnitCost.Text)
        objCommand.Parameters.Add("@notes", txtNotes.Text)
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
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text, _
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

    Private Sub DataGrid2_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"main_item", _
                                    "sku_code", _
                                    "item_desc", _
                                    "qty", _
                                    "uom", _
                                    "unit_cost", _
                                    "total_cost", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_by", _
                                    "modified_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Main Item", _
                                    "Serial No.", _
                                    "Item Desc", _
                                    "Qty", _
                                    "UOM", _
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
                                    "", _
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
                                            DataGrid2)
    End Sub

    Private Sub btnPrintQuote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintQuote.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_quote_form?code=" & lblDRCode.Text & _
                           " &id=" & Request("id") & _
                           " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()
    End Sub

    Sub GridBind3()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc3, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@ud_id", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid3.DataSource = objReader
        'the key field
        'DataGrid3.DataKeyField = strKeyField
        DataGrid3.DataBind()

        objReader.Close()
        objConnection.Close()
    End Sub

 
End Class

