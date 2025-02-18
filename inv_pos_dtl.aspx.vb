
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.IO

Public Class inv_pos_dtl
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
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
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
    Protected WithEvents btnX As System.Web.UI.WebControls.Button
    Protected WithEvents btnX2 As System.Web.UI.WebControls.Button
    Protected WithEvents btnX3 As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFormAction2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFormAction3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode3 As System.Web.UI.WebControls.Label
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnNewRecordImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnCustomerImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPayImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnReceiptImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnVoidImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPWDImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label    
    Protected WithEvents txtSINo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calSIDate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlClient As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblVatableSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblVAT As System.Web.UI.WebControls.Label
    Protected WithEvents lblAmount As System.Web.UI.WebControls.Label
    Protected WithEvents txtLess As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblDiscount As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayment As System.Web.UI.WebControls.Label
    Protected WithEvents lblBalance As System.Web.UI.WebControls.Label
    Protected WithEvents lblChange As System.Web.UI.WebControls.Label
    Protected WithEvents lblISSID As System.Web.UI.WebControls.Label
    Protected WithEvents ddlWarehouse As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblResult As System.Web.UI.HtmlControls.HtmlInputText
    Protected WithEvents lblOnProcessSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblCardNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovalNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblBankCharge As System.Web.UI.WebControls.Label
    Protected WithEvents lblBank As System.Web.UI.WebControls.Label
    Protected WithEvents ddlPayType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlBank As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtPaidAmount As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCardNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtApprovalNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBankCharge As System.Web.UI.WebControls.TextBox    
    Protected WithEvents txtNetSales As System.Web.UI.WebControls.TextBox    
    Protected WithEvents lblPay As System.Web.UI.HtmlControls.HtmlInputText
    Protected WithEvents lblEType As System.Web.UI.WebControls.Label
    Protected WithEvents ddlEType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents txtRefNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSave2 As System.Web.UI.WebControls.Button
    Protected WithEvents lblTotalItems As System.Web.UI.WebControls.Label
    Protected WithEvents panelVoid As System.Web.UI.WebControls.Panel
    Protected WithEvents btnYes As System.Web.UI.WebControls.Button
    Protected WithEvents btnNo As System.Web.UI.WebControls.Button
    Protected WithEvents panelCustomer As System.Web.UI.WebControls.Panel
    Protected WithEvents lblClientID As System.Web.UI.WebControls.Label
    Protected WithEvents txtCustomerName As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCity As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtSCNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPWDNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSave3 As System.Web.UI.WebControls.Button
    Protected WithEvents lblSerial As System.Web.UI.WebControls.Label
    Protected WithEvents panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblOnProcessSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblClient As System.Web.UI.WebControls.Label
    Protected WithEvents ddlSalesPerson As System.Web.UI.WebControls.DropDownList
    Protected WithEvents chbIsNonVat As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbIsVatExclusive As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label

    Protected WithEvents btnSaveBarcodeItem As System.Web.UI.WebControls.Button
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtISSID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDRCode As System.Web.UI.WebControls.TextBox

    Protected WithEvents txtRemarks As System.Web.UI.WebControls.TextBox

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
    Public strSubMenuName As String = "inv_pos_dtl"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

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
            If Request("Mode") = "Barcode" Then
                btnSaveBarcodeItemClick()

                DisplayHeader()
                GridBind()
            Else
                DisplayHeader()
                GridBind()

                If lblStatus.Text = "DELIVERED" And lblBalance.Text = "0.00" Then
                    btnAddImg.Enabled = False
                    btnPayImg.Enabled = False
                    btnCustomerImg.Enabled = False
                    btnNewRecordImg.Enabled = True

                Else
                    btnAddImg.Enabled = True

                    If lblTotalItems.Text = "0" Then
                        btnPayImg.Enabled = False
                    Else
                        btnPayImg.Enabled = True
                    End If

                    btnCustomerImg.Enabled = True
                    btnNewRecordImg.Enabled = False

                End If

                If lblStatus.Text = "DELIVERED" Then
                    btnVoidImg.Enabled = True
                Else
                    btnVoidImg.Enabled = False
                End If

                'is this module in the list of accessable menus?
                If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
                    'go somewhere
                    Response.Redirect("sys_errorpage")
                End If

                'is the user allowed to add record?
                If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_add") < 0 Then
                    'disable the add button
                    btnVoidImg.Visible = False
                End If
            End If


        End If

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

        lblISSID.Text = objReader("id")
        txtISSID.Text = objReader("id")

        lblDRCode.Text = objReader("dr_code")
        txtDRCode.Text = objReader("dr_code")

        lblStatus.Text = objReader("status")

        If lblStatus.Text = "ON PROCESS" Then

            lblStatus.ForeColor = Color.Orange

        ElseIf lblStatus.Text = "POSTED" Then

            lblStatus.ForeColor = Color.Blue

        ElseIf lblStatus.Text = "CANCELLED" Then

            lblStatus.ForeColor = Color.Red

        End If

        lblTotalItems.Text = objReader("total_item")

        txtSINo.Text = objReader("invoice_no")
        txtSINo.Enabled = bolChangeable

        calSIDate.SelectedDate = objReader("si_date")
        calSIDate.Enabled = bolChangeable        

        lblVatableSales.Text = objReader("vatable_sales")
        lblVAT.Text = objReader("vat")
        lblAmount.Text = objReader("net_amount")

        txtLess.Text = objReader("less")
        txtLess.Enabled = bolChangeable

        lblDiscount.Text = objReader("discount")

        lblNetSales.Text = objReader("net_sales")

        lblPayment.Text = objReader("paid_amount")
        lblChange.Text = objReader("change_amount")
        lblBalance.Text = objReader("owing")

        lblClient.Text = objReader("customer")

        If objReader("isVatExclusive") = True Then
            chbIsVatExclusive.Checked = True
        Else
            chbIsVatExclusive.Checked = False
        End If

        If objReader("isNonVat") = True Then
            chbIsNonVat.Checked = True
        Else
            chbIsNonVat.Checked = False
        End If

        chbIsVatExclusive.Enabled = bolChangeable
        chbIsNonVat.Enabled = bolChangeable

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
        ddlClient.Items.Insert(0, "")
        ddlClient.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        ddlClient.SelectedIndex = ddlClient.Items.IndexOf(ddlClient.Items.FindByValue(strCustomer.ToString))

        If lblDiscount.Text <> "0.00%" Then
            txtLess.Enabled = False

        Else
            txtLess.Enabled = True
        End If

        If lblStatus.Text = "DELIVERED" Then
            btnAddImg.Enabled = False
            btnPayImg.Enabled = False
        Else
            btnAddImg.Enabled = True
            btnPayImg.Enabled = True
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
    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
        Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "rm_name", _
                                    "", _
                                    "", _
                                    "", _
                                    "qty", _
                                    "cost", _
                                    "discount", _
                                    "", _
                                    "", _
                                    "net_cost", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Warehouse", _
                                    "DR #", _
                                    "Barcode", _
                                    "Item", _
                                    "Lot#/Serial#", _
                                    "Expiry Date", _
                                    "UOM", _
                                    "Qty", _
                                    "SRP", _
                                    "(%)", _
                                    "Is Free?", _
                                    "Total Amount", _
                                    "NET", _
                                    "Note", _
                                    "Sales Person", _
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
                                    "_COUNT_RECORD_", _
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

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "DS", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "R", _
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
    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblClient.Text = "" Then
            panelInfo.Visible = True
            lblValidate.Text = "Please select Customer first."
            panelForm.Visible = False
            panelGrid.Visible = False
            panelVoid.Visible = False            
            panelSuccess.Visible = False

        ElseIf lblStatus.Text = "POSTED" Or lblStatus.Text = "DELIVERED" Then
            panelInfo.Visible = True
            lblValidate.Text = "Cannot proceed. This is already " + lblStatus.Text + "!"
            panelForm.Visible = False
            panelGrid.Visible = False
            panelVoid.Visible = False
            panelSuccess.Visible = False
        Else
            panelForm.Visible = True
            panelCustomer.Visible = False
            panelGrid.Visible = False
            panelVoid.Visible = False
            panelInfo.Visible = False
            panelSuccess.Visible = False

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
        End If
       

    End Sub
    Private Sub ReadyAdd()

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
        lblResult.Value = 0

        lblSRP.Text = 0
        txtSRP.Text = 0
        txtSRP.Enabled = True

        txtLess.Text = 0
        txtLess.Enabled = True

        txtQty.Text = 0
        txtQty.Enabled = True

        txtDiscount.Text = 0
        txtDiscount.Enabled = True

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
        'ddlSalesPerson.Items.Insert(0, "")
        ddlSalesPerson.SelectedIndex = 0
        ddlSalesPerson.Enabled = True
        objReader.Close()

        objConnection.Close()

        SetFocus(ddlRawMats)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
        Refresh_CurrentSOH()

    End Sub
    Private Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        Refresh_Items()
        Refresh_CurrentSOH()

        panelSuccess.Visible = False
        panelInfo.Visible = False
        DisplayHeader()

    End Sub
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

        lblOnProcessSOH.Text = Trim(objReader("onprocess_soh"))
        lblRemainingSOH.Text = Trim(objReader("remaining_soh"))

        lblRemainingSOH2.Text = Trim(objReader("remaining_soh2"))
        lblOnProcessSOH2.Text = Trim(objReader("onprocess_soh2"))

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged
        Refresh_SRP()
        Refresh_CurrentSOH()
        Refresh_Serial()
        panelSuccess.Visible = False
        panelInfo.Visible = False

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
    Private Sub Refresh_SRP()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_ItemsSRP_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtSRP.Text = Trim(objReader("srp"))
        lblSRP.Text = Trim(objReader("srp"))

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_pos_list")
    End Sub
    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_pos_dtl?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))

    End Sub
    Private Sub btnX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX2.Click
        Response.Redirect("inv_pos_dtl?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))

    End Sub
    Private Sub btnX23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX3.Click
        Response.Redirect("inv_pos_dtl?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))

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

                        panelForm.Visible = True
                        panelCustomer.Visible = False
                        panelGrid.Visible = False
                        panelVoid.Visible = False
                        panelInfo.Visible = False

                        'Session("last_isdtl_sku") = ddlRawMats.SelectedValue
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

                        DisplayHeader()
                        txtPageNo.Text = 1
                        GridBind()

                        txtQty.Text = 0
                        txtSRP.Text = 0
                        lblResult.Value = 0

                    ElseIf txtFormAction.Text = "Delete" Then

                        'panelSuccess.Visible = True
                        panelForm.Visible = False
                        panelCustomer.Visible = False
                        panelGrid.Visible = False
                        panelVoid.Visible = False
                        panelInfo.Visible = False

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
    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSDtl_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@dr_code", lblDRCode.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@def_srp", lblSRP.Text)        
        objCommand.Parameters.Add("@onprocess_soh", lblOnProcessSOH.Text)
        objCommand.Parameters.Add("@remaining_soh", lblRemainingSOH.Text)
        objCommand.Parameters.Add("@remaining_soh2", lblRemainingSOH2.Text)
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
    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSDtl_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@dr_code", lblDRCode.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@discount", txtDiscount.Text)
        objCommand.Parameters.Add("@sales_person", ddlSalesPerson.SelectedValue)
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
                                        "Warehouse: " + ddlWarehouse.SelectedValue + " > Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text + " > SRP: " + txtSRP.Text + " > Discount: " + txtDiscount.Text, _
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
    Private Function btnSaveBarcodeItemClick()

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateBarcodeInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveBarcodeInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes
                panelForm.Visible = False
                panelCustomer.Visible = False
                panelGrid.Visible = False
                panelVoid.Visible = False
                panelInfo.Visible = False
                panelSuccess.Visible = False

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
      
    End Function
    Private Function ValidateBarcodeInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateBarcodeInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSBarcode_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@barcode", Request("barcode"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateBarcodeInput = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveBarcodeInput()
        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveBarcodeInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSDtl_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", Request("FormAction"))
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@warehouse", Request("warehouse"))
        objCommand.Parameters.Add("@iss_id", Request("id"))
        objCommand.Parameters.Add("@dr_code", Request("dr_code"))
        objCommand.Parameters.Add("@barcode", Request("barcode"))
        objCommand.Parameters.Add("@qty", Request("qty"))
        objCommand.Parameters.Add("@srp", 0)
        objCommand.Parameters.Add("@discount", 0)
        objCommand.Parameters.Add("@sales_person", "")
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

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
            SaveBarcodeInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try
    End Function
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

                panelForm.Visible = False
                panelCustomer.Visible = False
                panelGrid.Visible = False
                panelVoid.Visible = False
                panelInfo.Visible = False
                panelSuccess.Visible = False

                'reset and rebind       
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
        objCommand.Parameters.Add("@delivery_date", calSIDate.SelectedDate)
        objCommand.Parameters.Add("@invoice_no", txtSINo.Text)
        objCommand.Parameters.Add("@si_date", calSIDate.SelectedDate)
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@discount", "0")
        objCommand.Parameters.Add("@less", txtLess.Text)
        objCommand.Parameters.Add("@terms", "0")

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

        objCommand.Parameters.Add("@note", "")
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
                                        "Ref# " + lblID.Text + " > SODate: " + calSIDate.SelectedDate + " > Customer: " + strClient + " > Terms: " + "0" + " > Discount: " + "0" + " > Note: " + "", _
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
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False
        SaveHeaderClick()
    End Sub
    Private Sub txtSINo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSINo.TextChanged
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False
        SaveHeaderClick()
    End Sub
    Private Sub chbIsNonVat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbIsNonVat.CheckedChanged
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False
        SaveHeaderClick()
    End Sub
    Private Sub chbIsVatExclusive_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbIsVatExclusive.CheckedChanged
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False
        SaveHeaderClick()
    End Sub

    Private Sub calSIDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calSIDate.DateChanged
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False
        SaveHeaderClick()
    End Sub

    Private Sub txtLess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLess.TextChanged
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False
        SaveHeaderClick()
    End Sub
    Private Sub btnSaveImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveImg.Click
        SaveHeaderClick()
    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').select() </SCRIPT>"
        RegisterStartupScript("select", s)
    End Sub

    Private Sub btnNewRecordImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnNewRecordImg.Click

        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False

        Dim SaveNewHeader As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Issuance_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Add")
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@delivery_date", "1/1/1999")
        objCommand.Parameters.Add("@invoice_no", "")
        objCommand.Parameters.Add("@si_date", DateTime.UtcNow.AddHours(8).ToShortDateString())
        objCommand.Parameters.Add("@customer", "Walk_in")
        objCommand.Parameters.Add("@discount", 0)
        objCommand.Parameters.Add("@terms", 0)
        objCommand.Parameters.Add("@note", "")
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
                                        "Ref# " + lblID.Text + " > SODate: " + calSIDate.SelectedDate + " > Customer: " + ddlClient.SelectedValue + " > Terms: " + "0" + " > Discount: " + "0" + " > Note: " + "", _
                                        objNewID.Value, _
                                        0)

            Session("objNewID") = objNewID.Value

        Catch ex As Exception
            'in case of error
            SaveNewHeader = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString

        Finally

            objConnection.Close()

        End Try

        'the stored procedure and parameters
        objCommand = New SqlCommand("Inv_Issuance_GetID", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim issuance_id As String = Trim(objReader("id"))

        objReader.Close()
        objConnection.Close()

        Response.Redirect("inv_pos_dtl?&id=" & issuance_id & "&sys_table=" & "inv_issuances_list")

    End Sub

    'Private Sub txtPayment_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPayment.TextChanged
    '    panelSuccess.Visible = False
    '    panelInfo.Visible = False

    '    lblChange.Text = txtPayment.Text - lblNetSales.Text

    '    Dim dblAmount As Double = lblChange.Text
    '    dblAmount = Math.Round(dblAmount, 2)

    '    lblChange.Text = dblAmount.ToString("#,##0.00")

    'End Sub

    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.DeleteCommand
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Delete"
        lblMode.ForeColor = Color.Red
        panelGrid.Visible = False
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

    Private Sub ReadyDelete()
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

        txtSRP.Text = Trim(objReader("cost"))
        txtSRP.Enabled = False

        txtQty.Text = Trim(objReader("qty"))
        txtQty.Enabled = False

        txtDiscount.Text = Trim(objReader("discount"))
        txtDiscount.Enabled = False

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
        Refresh_Serial()

        SetFocus(txtQty)

    End Sub
    Private Sub Refresh_DefaultSRP()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_ItemsSRP_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblSRP.Text = Trim(objReader("srp"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnPayImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPayImg.Click
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = True
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False

        ddlPayType.SelectedValue = "CASH"
        txtBankCharge.Text = 0

        txtNetSales.Text = lblNetSales.Text.Replace(",", "")
        txtPaidAmount.Text = lblNetSales.Text.Replace(",", "")
        lblPay.Value = txtPaidAmount.Text - lblNetSales.Text.Replace(",", "")

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlBank.DataSource = objReader
        ddlBank.DataValueField = "code"
        ddlBank.DataTextField = "name"
        ddlBank.DataBind()
        ddlBank.Items.Insert(0, "")
        ddlBank.SelectedIndex = 0
        ddlBank.SelectedIndex = Nothing
        objReader.Close()

        objCommand = New SqlCommand("Ref_ECash_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlEType.DataSource = objReader
        ddlEType.DataValueField = "name"
        ddlEType.DataTextField = "name"
        ddlEType.DataBind()
        ddlEType.Items.Insert(0, "")
        ddlEType.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        SetFocus(txtPaidAmount)

    End Sub


    Private Sub btnSave2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave2.Click
        'validate the inputs vs. table records
        Dim strValidatePay As String = ValidatePay()

        'is the validation 
        If strValidatePay = "ok" Then
            'then save the inputs
            Dim strSavePay As String = SavePay()

            'is the saving successfull?
            If strSavePay = "ok" Then
                'notify and clear input boxes

                'panelSuccess.Visible = True
                panelForm.Visible = False
                panelCustomer.Visible = False
                panelGrid.Visible = False
                panelVoid.Visible = False
                panelInfo.Visible = False

                btnCustomerImg.Enabled = False
                btnNewRecordImg.Enabled = True
                btnVoidImg.Enabled = True

                DisplayHeader()
                txtPageNo.Text = 1
                GridBind()

                If lblStatus.Text = "DELIVERED" And lblBalance.Text = "0.00" Then
                    btnAddImg.Enabled = False
                    btnPayImg.Enabled = False
                Else
                    btnAddImg.Enabled = True
                    btnPayImg.Enabled = True
                End If

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                panelGrid.Visible = False
                lblValidate.Text = strSavePay
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            panelGrid.Visible = False
            lblValidate.Text = strValidatePay
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If
    End Sub
    Private Function ValidatePay()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidatePay = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSPay_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Add")
        objCommand.Parameters.Add("@paid_amount", txtPaidAmount.Text)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@invoice_no", txtSINo.Text)
        objCommand.Parameters.Add("@si_date", calSIDate.SelectedDate)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidatePay = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function

    Private Function SavePay()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SavePay = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSPay_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Add")
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@invoice_no", txtSINo.Text)
        objCommand.Parameters.Add("@client_code", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@remitted_date", calSIDate.SelectedDate)
        objCommand.Parameters.Add("@or_date", calSIDate.SelectedDate)
        objCommand.Parameters.Add("@or_no", "NA")

        If ddlPayType.SelectedValue = "EPAY" Then
            objCommand.Parameters.Add("@pay_type", ddlEType.SelectedValue)
            objCommand.Parameters.Add("@approval_no", txtRefNo.Text)
        Else
            objCommand.Parameters.Add("@pay_type", ddlPayType.SelectedValue)
            objCommand.Parameters.Add("@approval_no", txtApprovalNo.Text)
        End If

        objCommand.Parameters.Add("@bank_code", ddlBank.SelectedValue)
        objCommand.Parameters.Add("@card_no", txtCardNo.Text)
        objCommand.Parameters.Add("@bank_charge", txtBankCharge.Text)
        objCommand.Parameters.Add("@check_no", "NA")
        objCommand.Parameters.Add("@paid_amount", txtPaidAmount.Text)
        objCommand.Parameters.Add("@remarks", txtRemarks.Text)
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
                                        "Add", _
                                        Request("sys_table"), _
                                        "InvoiceNo: " + txtSINo.Text + " > CustomerCode: " + ddlClient.SelectedValue + " > RemittedDate: " + calSIDate.SelectedDate + " > ORDate: " + calSIDate.SelectedDate + " > ORNo: " + "NA" + " > PayType: " + ddlPayType.SelectedValue + " > BankCode: " + ddlBank.SelectedValue + " > CardNo: " + txtCardNo.Text + " > ApprovalNo: " + txtApprovalNo.Text + " BankCharge: " + txtBankCharge.Text + " > CheckNo: " + "NA" + " > CheckDate: " + calSIDate.SelectedDate + " > PaidAmount: " + txtPaidAmount.Text + " Remarks: " + "NA", _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            SavePay = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try

    End Function
    Private Sub btnVoidImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnVoidImg.Click
        panelForm.Visible = False
        panelCustomer.Visible = False
        panelGrid.Visible = False
        panelVoid.Visible = True
        GridBind()
        panelInfo.Visible = False
        panelSuccess.Visible = False
    End Sub

    Private Sub btnNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Response.Redirect("inv_pos_dtl?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Dim strSaveInput As String = SaveVoid()

        'is the saving successfull?
        If strSaveInput = "ok" Then
            'notify and clear input boxes

            'panelSuccess.Visible = True
            panelForm.Visible = False
            panelCustomer.Visible = False
            panelGrid.Visible = False
            panelVoid.Visible = False
            panelInfo.Visible = False

            btnVoidImg.Enabled = False

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

    Private Sub btnCustomerImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCustomerImg.Click
        panelForm.Visible = False
        panelCustomer.Visible = True
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False

        txtFormAction3.Text = "Add"

        SetFocus(txtCustomerName)

        lblClientID.Text = 0
        txtCustomerName.Text = ""
        txtSCNo.Text = ""
        txtPWDNo.Text = ""

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_City_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlCity.DataSource = objReader
        ddlCity.DataValueField = "name"
        ddlCity.DataTextField = "name"
        ddlCity.DataBind()
        ddlCity.Items.Insert(0, "")
        ddlCity.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

    End Sub

    Private Sub btnSave3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave3.Click
        'validate the inputs vs. table records
        Dim strValidateClient As String = ValidateClient()

        'is the validation 
        If strValidateClient = "ok" Then
            'then save the inputs
            Dim strSaveClient As String = SaveClient()

            'is the saving successfull?
            If strSaveClient = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelForm.Visible = False
                panelCustomer.Visible = False
                panelGrid.Visible = False
                panelVoid.Visible = False
                panelInfo.Visible = False

                DisplayHeader()
                txtPageNo.Text = 1
                GridBind()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                panelGrid.Visible = False
                lblValidate.Text = strSaveClient
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            panelGrid.Visible = False
            lblValidate.Text = strValidateClient
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If
    End Sub
    Private Function ValidateClient()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateClient = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSClient_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction3.Text)
        objCommand.Parameters.Add("@name", txtCustomerName.Text)
        objCommand.Parameters.Add("@id", lblClientID.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateClient = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function SaveClient()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveClient = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSClient_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction3.Text)
        objCommand.Parameters.Add("@id", lblClientID.Text)
        objCommand.Parameters.Add("@issuance_id", Request("id"))
        objCommand.Parameters.Add("@name", txtCustomerName.Text)
        objCommand.Parameters.Add("@city", ddlCity.SelectedValue)
        objCommand.Parameters.Add("@sc_no", txtSCNo.Text)
        objCommand.Parameters.Add("@pwd_no", txtPWDNo.Text)
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
                                        "Add", _
                                        Request("sys_table"), _
                                        "InvoiceNo: " + txtSINo.Text + " > CustomerCode: " + ddlClient.SelectedValue + " > RemittedDate: " + calSIDate.SelectedDate + " > ORDate: " + calSIDate.SelectedDate + " > ORNo: " + "NA" + " > PayType: " + ddlPayType.SelectedValue + " > BankCode: " + ddlBank.SelectedValue + " > CardNo: " + txtCardNo.Text + " > ApprovalNo: " + txtApprovalNo.Text + " BankCharge: " + txtBankCharge.Text + " > CheckNo: " + "NA" + " > CheckDate: " + calSIDate.SelectedDate + " > PaidAmount: " + txtPaidAmount.Text + " Remarks: " + "NA", _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            SaveClient = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub btnPWDImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPWDImg.Click
        panelForm.Visible = False
        panelCustomer.Visible = True
        panelGrid.Visible = False
        panelVoid.Visible = False
        panelInfo.Visible = False
        panelSuccess.Visible = False

        txtFormAction3.Text = "Edit"

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSClient_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", ddlClient.SelectedValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblClientID.Text = Trim(objReader("id"))
        txtCustomerName.Text = Trim(objReader("name"))
        txtSCNo.Text = Trim(objReader("sc_no"))
        txtPWDNo.Text = Trim(objReader("pwd_no"))

        Dim strCity As String = objReader("city")

        objReader.Close()

        objCommand = New SqlCommand("Ref_City_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCity.DataSource = objReader
        ddlCity.DataValueField = "name"
        ddlCity.DataTextField = "name"
        ddlCity.DataBind()
        objReader.Close()

        ddlCity.SelectedIndex = ddlCity.Items.IndexOf(ddlCity.Items.FindByValue(strCity.ToString))

        objConnection.Close()

        SetFocus(txtSCNo)
    End Sub

    Private Sub btnReceiptImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnReceiptImg.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_DRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_pos_receipt?code=" & lblISSID.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()

        GridBind()
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub




End Class

