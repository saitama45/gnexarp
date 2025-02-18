
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_returnitems_list
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
    Protected WithEvents btnPrint As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnPrintSO As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPRRefNo As System.Web.UI.WebControls.Label    
    Protected WithEvents lblDRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientName As System.Web.UI.WebControls.Label
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblDestination As System.Web.UI.WebControls.Label
    Protected WithEvents lblAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItems As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalQty As System.Web.UI.WebControls.Label    
    Protected WithEvents lblTotalCost As System.Web.UI.WebControls.Label 
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblSourceWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblCurrentSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblOnProcessSOH As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH As System.Web.UI.WebControls.Label
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlWarehouse As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlClient As System.Web.UI.WebControls.DropDownList
    Protected WithEvents calDate As eWorld.UI.CalendarPopup
    Protected WithEvents lblSerial As System.Web.UI.WebControls.Label
    Protected WithEvents panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents lblOnProcessSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblRemainingSOH2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblISSID As System.Web.UI.WebControls.Label

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
    Public strStoredProc As String = "inv_returnitems_list"
    Public strSubMenuName As String = "inv_returnitems_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

   Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblWarehouse.Text = "" Then
            panelInfo.Visible = True
            lblValidate.Text = "Please select and save warehouse first."
        Else
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
                    btnAddRecord.Visible = False
                End If
            End If
        End If
        
    End Sub
    Private Sub ReadyAdd()        

        panelSuccess.Visible = False
        panelInfo.Visible = False        
        ClearInputs()
    End Sub
    Private Sub ClearInputs()

        lblID.Text = 0

        lblOnProcessSOH.Text = 0
        lblRemainingSOH.Text = 0
        lblOnProcessSOH2.Text = 0
        lblRemainingSOH2.Text = 0

        lblSourceWarehouse.Text = ddlWarehouse.SelectedValue

        ddlRawMats.Enabled = True

        txtBarcode.Text = ""
        txtBarcode.Enabled = True

        txtQty.Text = 0
        txtQty.Enabled = True

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

    End Sub
    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReturnItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strWarehouse = Trim(objReader("warehouse"))
        Dim strItem As String = objReader("itemdtl_id")

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        If Session("group") = "ADMIN" Then

            lblID.Text = Trim(objReader("id"))

            lblSourceWarehouse.Text = Trim(objReader("warehouse"))

            txtBarcode.Text = Trim(objReader("barcode"))
            txtBarcode.Enabled = True

            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = True

            objReader.Close()

            objCommand = New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@warehouse", lblSourceWarehouse.Text)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            ddlRawMats.DataSource = objReader
            ddlRawMats.DataValueField = "code"
            ddlRawMats.DataTextField = "name"
            ddlRawMats.DataBind()
            ddlRawMats.Enabled = True
            objReader.Close()

            ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strItem.ToString))

        Else

            lblID.Text = Trim(objReader("id"))
            lblSourceWarehouse.Text = Trim(objReader("warehouse"))

            txtBarcode.Text = Trim(objReader("barcode"))
            txtBarcode.Enabled = bolChangeable

            txtQty.Text = Trim(objReader("qty"))
            txtQty.Enabled = bolChangeable

            objReader.Close()

            objCommand = New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@warehouse", lblSourceWarehouse.Text)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            ddlRawMats.DataSource = objReader
            ddlRawMats.DataValueField = "code"
            ddlRawMats.DataTextField = "name"
            ddlRawMats.DataBind()
            ddlRawMats.Enabled = True
            objReader.Close()

            ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strItem.ToString))

        End If

        objConnection.Close()       

        SetFocus(ddlRawMats)
        
        Refresh_CurrentSOH()
        Refresh_Serial()

    End Sub


    Private Sub ReadyDelete()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReturnItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))
        lblSourceWarehouse.Text = Trim(objReader("warehouse"))

        txtBarcode.Text = Trim(objReader("barcode"))
        txtBarcode.Enabled = False

        txtQty.Text = Trim(objReader("qty"))
        txtQty.Enabled = False

        Dim strItem As String = objReader("rm_code")
        Dim strWarehouse = Trim(objReader("warehouse"))

        objReader.Close()


        objCommand = New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@warehouse", lblSourceWarehouse.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        objReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Enabled = False
        objReader.Close()
        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strItem.ToString))

        objConnection.Close()
        
        Refresh_CurrentSOH()
        Refresh_Serial()
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
        Dim objCommand As New SqlCommand("Inv_ReturnItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@warehouse", lblSourceWarehouse.Text)
        objCommand.Parameters.Add("@dr_code", lblRefNo.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
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
                                        "ReturnItemCode: " + ddlRawMats.SelectedValue + " > Qty: " + txtQty.Text, _
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
        Dim objCommand As New SqlCommand("Inv_ReturnItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@current_soh", lblCurrentSOH.Text)
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

    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
        Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "", _
                                    "barcode", _
                                    "item_code", _
                                    "rm_name", _
                                    "rm_code", _
                                    "expiry_date", _
                                    "uom", _
                                    "qty", _
                                    ""}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Warehouse", _
                                    "Barcode", _
                                    "Item Code", _
                                    "Item", _
                                    "Lot#/Serial#", _
                                    "Expiry Date", _
                                    "UOM", _
                                    "Qty", _
                                    "Cost"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_"}

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "DS", _
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
                If lblTotalItems.Text = "0" Then
                    btnPrintImg.Visible = False
                Else
                    btnPrintImg.Visible = True
                End If
                btnAddImg.Visible = True
                'btnAddRecord.Text = "Add Item"
            Else
                btnAddImg.Visible = False
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
                        'panelForm.Visible = False
                        lblValidate.Visible = False

                        SetFocus(ddlRawMats)
                        btnPrintImg.Visible = True

                        lblOnProcessSOH.Text = 0
                        lblRemainingSOH.Text = 0
                        lblOnProcessSOH2.Text = 0
                        lblRemainingSOH2.Text = 0

                        ddlRawMats.SelectedIndex = 0
                        txtQty.Text = 0                        

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
        End If

        If Not Page.IsValid Then
            Exit Sub
        End If


    End Sub


    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.EditCommand

        If lblWarehouse.Text = "" Then
            panelInfo.Visible = True
            lblValidate.Text = "Please select and save warehouse first."

        Else
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
        End If

    End Sub


    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

        If lblWarehouse.Text = "" Then
            panelInfo.Visible = True
            lblValidate.Text = "Please select and save warehouse first."

        Else
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

        Dim strDestination As String = objReader("destination")
        Dim strWarehouse As String = objReader("warehouse")

        Dim bolChangeable As Boolean = objReader("status") = "ON PROCESS"

        lblISSID.Text = objReader("id")
        lblStatus.Text = objReader("status")
        lblWarehouse.Text = objReader("warehouse")

        lblRefNo.Text = objReader("dr_code")

        lblDate.Text = objReader("dr_date")
        calDate.SelectedDate = objReader("dr_date")
        calDate.Enabled = bolChangeable
        calDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()

        lblDestination.Text = objReader("destination")

        lblAddress.Text = objReader("return_address")
        txtAddress.Text = objReader("return_address")
        txtAddress.Enabled = bolChangeable

        lblTotalItems.Text = objReader("total_item")
        lblTotalQty.Text = objReader("total_qty")
        lblTotalCost.Text = objReader("total_cost")

        txtNote.Text = objReader("note")
        txtNote.Enabled = bolChangeable

        objReader.Close()        

        If lblTotalItems.Text <> "0" Then
            objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "name"
            ddlWarehouse.DataBind()
            ddlWarehouse.Items.Insert(0, "")
            ddlWarehouse.SelectedIndex = 0
            ddlWarehouse.Visible = False
            lblWarehouse.Visible = True
            objReader.Close()
        Else
            objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "name"
            ddlWarehouse.DataBind()
            ddlWarehouse.Items.Insert(0, "")
            ddlWarehouse.SelectedIndex = 0
            ddlWarehouse.Enabled = bolChangeable
            ddlWarehouse.Visible = True
            lblWarehouse.Visible = False
            objReader.Close()
        End If

        objConnection.Close()

        ddlWarehouse.SelectedIndex = ddlWarehouse.Items.IndexOf(ddlWarehouse.Items.FindByValue(strWarehouse.ToString))        

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

        SetFocus(calDate)
        Refresh_Destination()
    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_returns_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_ReturnItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@dr_code", lblRefNo.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_return_form?code=" & lblRefNo.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_returnitems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged

        Refresh_CurrentSOH()
        Refresh_Serial()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        SetFocus(txtQty)
    End Sub

    'Private Sub Refresh_Items()

    '    Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
    '    objConnection.Open()
    '    Dim objCommand As New SqlCommand("Ref_WarehouseItemDTL_Get_droplist", objConnection)
    '    objCommand.CommandType = CommandType.StoredProcedure

    '    objCommand.Parameters.Add("@id", Request("id"))
    '    objCommand.Parameters.Add("@warehouse", lblSourceWarehouse.Text)
    '    objCommand.Parameters.Add("@Session_username", Session("username"))

    '    Dim objReader As SqlDataReader = objCommand.ExecuteReader

    '    ddlRawMats.DataSource = objReader
    '    ddlRawMats.DataValueField = "code"
    '    ddlRawMats.DataTextField = "name"
    '    ddlRawMats.DataBind()
    '    ddlRawMats.Items.Insert(0, "")
    '    ddlRawMats.SelectedIndex = 0
    '    objReader.Close()

    '    objConnection.Close()

    '    SetFocus(ddlRawMats)
    'End Sub
    Private Sub Refresh_CurrentSOH()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_RemainingSOH2_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@ud_id", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@warehouse", lblSourceWarehouse.Text)

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
        Dim objCommand As New SqlCommand("Inv_Returns_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@dr_date", calDate.SelectedDate)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@destination", ddlClient.SelectedValue)

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
        Dim objCommand As New SqlCommand("Inv_Returns_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@dr_date", calDate.SelectedDate)
        objCommand.Parameters.Add("@destination", ddlClient.SelectedValue)
        objCommand.Parameters.Add("@address", txtAddress.Text)
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
                                        "Ref# " + " > Warehouse: " + ddlWarehouse.SelectedValue + lblID.Text + " > Date: " + calDate.SelectedDate + " > Customer: " + ddlClient.SelectedValue + " > Note: " + txtNote.Text, _
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

    Private Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False

        Refresh_Destination()
    End Sub

    Private Sub calDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlClient_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlClient.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub Refresh_Destination()

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

        Dim strDestination As String = objReader("destination")
        Dim bolChangeable As Boolean = objReader("status") = "ON PROCESS"

        objReader.Close()

        objCommand = New SqlCommand("Ref_ReturnVendors_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlClient.DataSource = objReader
        ddlClient.DataValueField = "name"
        ddlClient.DataTextField = "name"
        ddlClient.DataBind()
        ddlClient.SelectedIndex = ddlClient.Items.IndexOf(ddlClient.Items.FindByValue(strDestination.ToString))

        objReader.Close()
        objConnection.Close()

       
    End Sub
End Class

