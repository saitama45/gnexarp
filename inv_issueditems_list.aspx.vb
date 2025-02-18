
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_issueditems_list
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
    Protected WithEvents btnPrint As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrintSO As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPRRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblDRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblDRDate As System.Web.UI.WebControls.Label    
    Protected WithEvents lblClientName As System.Web.UI.WebControls.Label    
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblCancelledBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblCancelledDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblFulfilledBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblFulfilledDate As System.Web.UI.WebControls.Label
    Protected WithEvents cbIsFree As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblNetCost As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblInvoiceNo As System.Web.UI.WebControls.Label
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblRecentSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblCurrentSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblSelectWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblSourceWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents ddlWarehouse As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblOnProcessSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH As System.Web.UI.WebControls.Label
    Protected WithEvents ddlClient As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblSerial As System.Web.UI.WebControls.Label
    Protected WithEvents panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblOnProcessSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblISSID As System.Web.UI.WebControls.Label
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblResult As System.Web.UI.HtmlControls.HtmlInputText
    Protected WithEvents txtSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblSRP As System.Web.UI.WebControls.Label
    Protected WithEvents txtNote2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDRNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calDRDate As eWorld.UI.CalendarPopup
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    Protected WithEvents txtDeliveredBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDeliveryCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelForm2 As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMode2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtFormAction2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnX2 As System.Web.UI.WebControls.Button
    Protected WithEvents lblID2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtSKUCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtItemDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDRQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSave2 As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblDRItemsID As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid

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
    Public strStoredProc As String = "inv_issueditems_list"
    Public strStoredProc2 As String = "Inv_SOSubItems_List"
    Public strSubMenuName As String = "inv_issueditems_list"

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
                btnAddImg.Visible = False
            End If
        End If
        
    End Sub
    Private Sub ReadyAdd()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_WarehouseDR_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@warehouse_destination", ddlClient.SelectedValue)
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlWarehouse.DataSource = objReader
        ddlWarehouse.DataValueField = "code"
        ddlWarehouse.DataTextField = "code"
        ddlWarehouse.DataBind()
        ddlWarehouse.Items.Insert(0, "")
        ddlWarehouse.SelectedIndex = 0
        ddlWarehouse.Enabled = True
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

        txtBarcode.Text = ""
        txtBarcode.Enabled = True

        lblSRP.Text = 0
        txtSRP.Text = 0
        txtSRP.Enabled = True

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
        ddlRawMats.Enabled = True
        objReader.Close()

        objConnection.Close()

        SetFocus(ddlRawMats)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()

        Refresh_Computation()

    End Sub
    Private Sub Refresh_Computation()
        lblResult.Value = (txtSRP.Text * txtQty.Text)

        Dim dblAmount As Double = lblResult.Value
        dblAmount = Math.Round(dblAmount, 2)

        lblResult.Value = dblAmount.ToString("#,##0.00")

        panelSuccess.Visible = False
        panelInfo.Visible = False
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
    Private Sub ReadyEdit()

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
        Dim strRawMats As String = objReader("itemdtl_id")

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        If Session("group") = "ADMIN" Then

            lblID.Text = Trim(objReader("id"))

            txtBarcode.Text = Trim(objReader("barcode"))
            txtBarcode.Enabled = True

            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = True

            txtSRP.Text = Trim(objReader("cost"))
            txtSRP.Enabled = True

            txtNote2.Text = Trim(objReader("note"))
            txtNote2.Enabled = True

            objReader.Close()

            objCommand = New SqlCommand("Ref_WarehouseDR_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
            objCommand.Parameters.Add("@warehouse_destination", ddlClient.SelectedValue)
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "code"
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

            ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

        Else

            lblID.Text = Trim(objReader("id"))

            txtBarcode.Text = Trim(objReader("barcode"))
            txtBarcode.Enabled = bolChangeable

            txtSRP.Text = Trim(objReader("cost"))
            txtSRP.Enabled = bolChangeable

            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = bolChangeable

            txtNote2.Text = Trim(objReader("note"))
            txtNote2.Enabled = bolChangeable

            Dim intIsFree As String = Trim(objReader("isfree"))

            If intIsFree = "Yes" Then cbIsFree.Checked = True Else cbIsFree.Checked = False
            cbIsFree.Enabled = bolChangeable

            objReader.Close()

            objCommand = New SqlCommand("Ref_WarehouseDR_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
            objCommand.Parameters.Add("@warehouse_destination", ddlClient.SelectedValue)
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "code"
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

            ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))
        End If

        objConnection.Close()

        SetFocus(ddlRawMats)

        Refresh_DefaultSRP()
        Refresh_CurrentSOH()
        Refresh_Serial()
        Refresh_Computation()
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

        txtBarcode.Text = Trim(objReader("barcode"))
        txtBarcode.Enabled = False

        txtSRP.Text = Trim(objReader("cost"))
        txtSRP.Enabled = False

        txtQty.Text = Trim(objReader("qty"))
        txtQty.Enabled = False

        txtNote2.Text = Trim(objReader("note"))
        txtNote2.Enabled = False

        Dim intIsFree As String = Trim(objReader("isfree"))

        If intIsFree = "Yes" Then cbIsFree.Checked = True Else cbIsFree.Checked = False
        cbIsFree.Enabled = False

        Dim strWarehouse = Trim(objReader("warehouse"))
        Dim strRawMats As String = objReader("itemdtl_id")

        objReader.Close()

        objCommand = New SqlCommand("Ref_WarehouseDR_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@warehouse_destination", ddlClient.SelectedValue)
        objReader = objCommand.ExecuteReader
        ddlWarehouse.DataSource = objReader
        ddlWarehouse.DataValueField = "code"
        ddlWarehouse.DataTextField = "code"
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

        objConnection.Close()
        
        Refresh_DefaultSRP()
        Refresh_CurrentSOH()
        Refresh_Serial()
        Refresh_Computation()

        SetFocus(btnSave)

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
    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_IssuedItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
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
        objCommand.Parameters.Add("@note", txtNote2.Text)
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
                                        "Warehoue: " + lblSourceWarehouse.Text + "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text, _
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
        Dim objCommand As New SqlCommand("Inv_IssuedItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@current_soh", lblCurrentSOH.Text)
        objCommand.Parameters.Add("@onprocess_soh", lblOnProcessSOH.Text)
        objCommand.Parameters.Add("@remaining_soh", lblRemainingSOH.Text)
        objCommand.Parameters.Add("@remaining_soh2", lblRemainingSOH2.Text)
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@def_srp", lblSRP.Text)
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
                                    "net_cost", _
                                    "note", _
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
                                    "Net Amt", _
                                    "Note", _
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
                                    "", _
                                    "", _
                                    "DS", _
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
                btnAddImg.Visible = True
                'btnAddImg.Text = "Add Item"
                btnPrintImg.Visible = False
                lblSelectWarehouse.Visible = True
                ddlWarehouse.Enabled = True

            ElseIf lblStatus.Text = "POSTED" Then
                btnAddImg.Visible = False
                btnPrintImg.Visible = True
                'btnPrint.Text = "Print DR"
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Enabled = False
                btnSaveImg.Visible = False

            Else
                btnAddImg.Visible = False
                btnPrintImg.Visible = False
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Enabled = False
                btnSaveImg.Visible = False

            End If

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
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Enabled = False
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
                                    lblISSID.Text)

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

                        SetFocus(ddlRawMats)

                        lblOnProcessSOH.Text = 0
                        lblRemainingSOH.Text = 0
                        lblOnProcessSOH2.Text = 0
                        lblRemainingSOH2.Text = 0

                        ddlRawMats.SelectedIndex = 0
                        txtQty.Text = 0
                        lblResult.Value = 0
                        txtSRP.Text = 0
                        txtNote2.Text = Nothing

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

        Dim strCustomer As String = objReader("dest_st")
        Dim strCompany As String = objReader("company")

        Dim bolChangeable As Boolean = objReader("status") = "ON PROCESS"

        lblISSID.Text = objReader("id")
        lblStatus.Text = objReader("status")
        'lblWarehouse.Text = objReader("warehouse")
        lblInvoiceNo.Text = objReader("invoice_no")
        lblDRCode.Text = objReader("dr_code")
        txtDRNo.Text = objReader("dr_no")

        If objReader("dr_date") = "01/01/1900" Then
            lblDRDate.Text = ""
            calDRDate.SelectedDate = Now.UtcNow.ToShortDateString
            calDRDate.VisibleDate = Now.UtcNow.ToShortDateString
        Else
            lblDRDate.Text = objReader("dr_date")
            calDRDate.SelectedDate = objReader("dr_date")
            calDRDate.VisibleDate = Now.UtcNow.ToShortDateString
        End If

        lblCompany.Text = objReader("company")
        lblClientName.Text = objReader("dest_st")
        lblNetAmount.Text = objReader("net_amount")
        txtTerms.Text = objReader("dr_terms")
        txtNote.Text = objReader("note")
        txtNote.Enabled = bolChangeable
        
        If Trim(objReader("total_item")) > 0 Then
            ddlClient.Visible = False
            ddlCompany.Visible = False
            lblCompany.Visible = True
            lblClientName.Visible = True
        Else
            lblCompany.Visible = False
            lblClientName.Visible = False
            ddlClient.Visible = True
            ddlCompany.Visible = True
        End If

        txtDeliveredBy.Text = objReader("delivered_by")
        txtDeliveryCost.Text = objReader("delivery_cost")

        objReader.Close()

        objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        ddlCompany.Enabled = bolChangeable
        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_ClientVendor_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@company", strCompany)
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlClient.DataSource = objReader
        ddlClient.DataValueField = "code"
        ddlClient.DataTextField = "name"
        ddlClient.DataBind()
        ddlClient.Enabled = bolChangeable
        ddlClient.SelectedIndex = ddlClient.Items.IndexOf(ddlClient.Items.FindByValue(strCustomer.ToString))
        objReader.Close()

        objConnection.Close()

        btnSave.Visible = bolChangeable

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_dr_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click

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

            'ElseIf Session("company_code") = "CTEMS" Then
            '    SetEndPopup("trx_dr_form_ctems?code=" & lblDRCode.Text & _
            '                    " &id=" & Request("id") & _
            '                    " &formaction=" & "Print")

            'ElseIf Session("company_code") = "ECPACK" Then
            '    SetEndPopup("trx_dr_form_ecpack?code=" & lblDRCode.Text & _
            '                    " &id=" & Request("id") & _
            '                    " &formaction=" & "Print")

        Else
            SetEndPopup("trx_dr_form?code=" & lblDRCode.Text & _
               " &id=" & Request("id") & _
               " &formaction=" & "Print")
        End If

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_issueditems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged
        Refresh_SRP()
        Refresh_CurrentSOH()
        Refresh_Serial()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        SetFocus(txtQty)
    End Sub
    Private Sub Refresh_SRP()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_ItemsSRP_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)        
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtBarcode.Text = Trim(objReader("barcode"))
        txtSRP.Text = Trim(objReader("srp"))
        lblSRP.Text = Trim(objReader("srp"))
        txtQty.Text = 1

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
    End Sub

    Private Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        Refresh_Items()
        Refresh_CurrentSOH()

        panelSuccess.Visible = False
        panelInfo.Visible = False
        DisplayHeader()
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
        Dim objCommand As New SqlCommand("Inv_Issuance_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))

        If ddlClient.Visible = False Then
            objCommand.Parameters.Add("@customer", lblClientName.Text)
        Else
            objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        End If

        objCommand.Parameters.Add("@dr_no", txtDRNo.Text)

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
        Dim objCommand As New SqlCommand("Inv_DR_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)

        If ddlClient.Visible = False Then
            objCommand.Parameters.Add("@customer", lblClientName.Text)
        Else
            objCommand.Parameters.Add("@customer", ddlClient.SelectedValue)
        End If

        objCommand.Parameters.Add("@dr_no", txtDRNo.Text)
        objCommand.Parameters.Add("@dr_date", calDRDate.SelectedDate)
        objCommand.Parameters.Add("@terms", txtTerms.Text)
        objCommand.Parameters.Add("@delivered_by", txtDeliveredBy.Text)
        objCommand.Parameters.Add("@delivery_cost", txtDeliveryCost.Text)
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

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref# " + lblID.Text + " > Customer: " + ddlClient.SelectedValue + " > Note: " + txtNote.Text, _
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
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtTerms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerms.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtDRNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDRNo.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub txtDeliveredBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeliveredBy.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtDeliveryCost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeliveryCost.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCompany.SelectedIndexChanged
        Refresh_Destination()
    End Sub
    Private Function Refresh_Destination()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_ClientVendor_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        ddlClient.DataSource = objReader
        ddlClient.DataValueField = "code"
        ddlClient.DataTextField = "name"
        ddlClient.DataBind()
        ddlClient.Items.Insert(0, "")
        ddlClient.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        SetFocus(ddlClient)
    End Function

    Private Sub Refresh_DefaultSRP()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_ItemsSRP_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtBarcode.Text = Trim(objReader("barcode"))
        lblSRP.Text = Trim(objReader("srp"))

        objReader.Close()
        objConnection.Close()
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

        txtDRQty.Text = 0
        txtDRQty.Enabled = True

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

        txtDRQty.Text = Trim(objReader("qty"))
        txtDRQty.Enabled = bolChangeable

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

        txtDRQty.Text = Trim(objReader("qty"))
        txtDRQty.Enabled = False

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
        objCommand.Parameters.Add("@qty", txtDRQty.Text)
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
        objCommand.Parameters.Add("@qty", txtDRQty.Text)
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
                                    "", _
                                    "", _
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
                                            DataGrid2)
    End Sub


End Class

