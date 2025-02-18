
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_porequestsdtl_list
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
    Protected WithEvents txtRequestedQty As System.Web.UI.WebControls.TextBox
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
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox

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
    Public strStoredProc As String = "inv_porequestsdtl_list"
    Public strSubMenuName As String = "inv_porequestsdtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"
    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

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

        SetFocus(ddlRawMats)
    End Sub
    Private Sub ReadyAdd()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_ItemsCompany_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Items.Insert(0, "")
        ddlRawMats.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_UOM_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "name"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        ddlUOM.Items.Insert(0, "")
        ddlUOM.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "name"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        ddlBrand.Items.Insert(0, "")
        ddlBrand.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        ClearInputs()

    End Sub
    Private Sub ClearInputs()

        ddlRawMats.Visible = True
        txtItemDesc.Visible = False

        ddlBrand.Visible = True
        txtBrand.Visible = False

        ddlUOM.Enabled = True
        ddlRawMats.Enabled = True
        ddlBrand.Enabled = True

        txtItemDesc.Text = ""
        txtItemDesc.Enabled = True

        chbItemNotFound.Checked = False
        chbItemNotFound.Enabled = True

        chbBrandNotFound.Checked = False
        chbBrandNotFound.Enabled = True

        txtBrand.Text = ""
        txtBrand.Enabled = True

        txtRequestedQty.Text = ""
        txtRequestedQty.Enabled = True

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
        Dim objCommand As New SqlCommand("Inv_PORequestsDTL_Get", objConnection)
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

        txtItemDesc.Text = Trim(objReader("item_desc"))
        txtItemDesc.Enabled = bolChangeable

        If Trim(objReader("rm_code")) = "" Then
            chbItemNotFound.Checked = True
            ddlRawMats.Visible = False
            txtItemDesc.Visible = True
        Else
            chbItemNotFound.Checked = False
            ddlRawMats.Visible = True
            txtItemDesc.Visible = False
        End If
        chbItemNotFound.Enabled = bolChangeable

        If Trim(objReader("isBrandFound")) = 0 Then
            chbBrandNotFound.Checked = True
            ddlBrand.Visible = False
            txtBrand.Visible = True
        Else
            chbBrandNotFound.Checked = False
            ddlBrand.Visible = True
            txtBrand.Visible = False
        End If
        chbBrandNotFound.Enabled = bolChangeable

        txtBrand.Text = Trim(objReader("brand"))
        txtBrand.Enabled = bolChangeable

        txtRequestedQty.Text = Trim(objReader("requested_qty"))
        txtRequestedQty.Enabled = bolChangeable

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


    End Sub


    Private Sub ReadyDelete()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PORequestsDTL_Get", objConnection)
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

        lblID.Text = Trim(objReader("id"))

        txtItemDesc.Text = Trim(objReader("item_desc"))
        txtItemDesc.Enabled = False

        If Trim(objReader("rm_code")) = "" Then
            chbItemNotFound.Checked = True
            ddlRawMats.Visible = False
            txtItemDesc.Visible = True
        Else
            chbItemNotFound.Checked = False
            ddlRawMats.Visible = True
            txtItemDesc.Visible = False
        End If
        chbItemNotFound.Enabled = False

        If Trim(objReader("isBrandFound")) = 0 Then
            chbBrandNotFound.Checked = True
            ddlBrand.Visible = False
            txtBrand.Visible = True
        Else
            chbBrandNotFound.Checked = False
            ddlBrand.Visible = True
            txtBrand.Visible = False
        End If
        chbBrandNotFound.Enabled = False

        txtBrand.Text = Trim(objReader("brand"))
        txtBrand.Enabled = False

        txtRequestedQty.Text = Trim(objReader("requested_qty"))
        txtRequestedQty.Enabled = False

        objReader.Close()

        objCommand = New SqlCommand("Ref_ItemsCompany_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@Session_username", Session("username"))

        objReader = objCommand.ExecuteReader
        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Enabled = False
        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_UOM_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "name"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        ddlUOM.Enabled = False
        ddlUOM.SelectedIndex = ddlUOM.Items.IndexOf(ddlUOM.Items.FindByValue(strUOM.ToString))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "name"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        ddlBrand.Enabled = False
        ddlBrand.SelectedIndex = ddlBrand.Items.IndexOf(ddlBrand.Items.FindByValue(strBrand.ToString))
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
        Dim objCommand As New SqlCommand("Inv_PORequestsDTL_Save", objConnection)
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
        objCommand.Parameters.Add("@requested_qty", txtRequestedQty.Text)
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
        objCommand.Parameters.Add("@requested_qty", txtRequestedQty.Text)

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
                                    "brand", _
                                    "item_desc", _                                    
                                    "uom", _
                                    "requested_qty"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Brand", _
                                    "Item Desc", _
                                    "UOM", _
                                    "Requested Qty"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_"}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "N2"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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

                    'reset and rebind       
                    txtPageNo.Text = 1
                    DisplayHeader()                    
                    GridBind()


                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False
                    Response.Redirect("inv_porequestsdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))

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


    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

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
        Dim objCommand As New SqlCommand("Inv_PORequests_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = objReader("status") = "PENDING"
        Dim bolVisible As Boolean = objReader("status") <> "PENDING"

        lblPRID.Text = Trim(objReader("id"))
        lblStatus.Text = Trim(objReader("status"))
        lblPRCode.Text = Trim(objReader("por_code"))

        txtSONo.Text = Trim(objReader("so_no"))

        If Trim(objReader("total_requested_qty")) <> 0 Then
            txtSONo.Visible = False
            lblSONo.Visible = True
        End If
        txtSONo.Enabled = bolChangeable

        lblSONo.Text = Trim(objReader("so_no"))
        lblCustomer.Text = Trim(objReader("customer_name"))
        lblCustomerCode.Text = Trim(objReader("customer"))

        calPRDate.SelectedDate = Trim(objReader("por_date"))
        calPRDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calPRDate.Enabled = bolChangeable

        lblRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Enabled = bolChangeable

        calDueDate.SelectedDate = Trim(objReader("due_date"))
        calDueDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calDueDate.Enabled = bolChangeable

        lblTotalRequestedQty.Text = objReader("total_requested_qty")
        txtNote.Text = objReader("note")
        txtNote.Enabled = bolChangeable

        btnAddImg.Visible = bolChangeable
        btnSaveImg.Visible = bolChangeable        
        btnReplicateImg.Visible = bolVisible
        'btnPrintImg.Visible = bolVisible

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
        Dim objCommand As New SqlCommand("Inv_PORequests_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_por_form?code=" & lblPRCode.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_porequestsdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
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
        Response.Redirect("inv_porequests_list")
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
        Dim objCommand As New SqlCommand("Inv_PORequests_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@so_no", txtSONo.Text)
        objCommand.Parameters.Add("@customer", lblCustomerCode.Text)
        objCommand.Parameters.Add("@requested_by", txtRequestedBy.Text)
        objCommand.Parameters.Add("@due_date", calDueDate.SelectedDate)
        objCommand.Parameters.Add("@note", txtNote.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))
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
            If txtFormAction.Text = "Delete" Then
                SaveHeader = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveHeader = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub txtSONo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSONo.TextChanged
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Inv_PORequests_SONoGet", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@so_no", txtSONo.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Trim(objReader("customer_code")) = "" Then
            txtSONo.Text = ""
        End If

        lblCustomer.Text = Trim(objReader("customer"))
        lblCustomerCode.Text = Trim(objReader("customer_code"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub calPRDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calPRDate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtRequestedBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRequestedBy.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
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
            SetFocus(txtBrand)
        Else
            ddlBrand.Visible = True
            txtBrand.Visible = False
            SetFocus(ddlBrand)
        End If

    End Sub

    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged
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
    End Sub

    Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

End Class

