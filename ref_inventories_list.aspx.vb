
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState


Public Class ref_inventories_list
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
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblModule As System.Web.UI.WebControls.Label
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblValidate As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label    
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents RequiredFieldValidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtSpecial_Access As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlGroup As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlMenu As System.Web.UI.WebControls.DropDownList
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid As System.Web.UI.WebControls.Panel
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
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSLCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSSLCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtBline As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBline As System.Web.UI.WebControls.Label
    Protected WithEvents txtBranchCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBranchCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtBranchName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBranchName As System.Web.UI.WebControls.Label
    Protected WithEvents lbliFOMSBlineName As System.Web.UI.WebControls.Label
    Protected WithEvents ddlCategory As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlSubCategory As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtStock As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSafetyLevel As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSerial As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents calExpiredDate As eWorld.UI.CalendarPopup
    Protected WithEvents lblCode As System.Web.UI.WebControls.Label
    Protected WithEvents lstCategories As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstSubCategories As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstItems As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstSOH As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstWarehouse As System.Web.UI.WebControls.ListBox
    Protected WithEvents btnGenerate As System.Web.UI.WebControls.Button    
    Protected WithEvents btnDownload As System.Web.UI.WebControls.Button
    Protected WithEvents btnFullView As System.Web.UI.WebControls.Button
    Protected WithEvents lstInvRep As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstYear As System.Web.UI.WebControls.ListBox
    Protected WithEvents panelYear As System.Web.UI.WebControls.Panel
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label

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
    Public strSubMenuName As String = "ref_inventories_list"
    Public strStoredProc As String = "ref_inventories_list"
    Public strStoredProc2 As String = "rep_inventories_list"
    Public strStoredProc3 As String = "rep_near_expiry"
    Public strStoredProc4 As String = "rep_serial_soh"
    Public strSubMenuFullView As String = "rep_inventory_audit_popup"

    Public strSPParam_BSDateFr As String = "@bs_date_from"
    Public strSPParam_BSDateTo As String = "@bs_date_to"
    Public strSPParam_User As String = "@Session_username"

    Public strFileNameExcel As String = "InventoryAuditTrailReport.xls"
    Public strFileNamePDF As String = "InventoryAuditTrailReport.pdf"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "name"
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
            GridBind()

            lblCompany.Text = Session("company_code")

            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            'get the list of Categories
            Dim objCommand As New SqlCommand("ref_category_get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
            objCommand.Parameters.Add("@id", 0)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            lstCategories.DataSource = objReader
            lstCategories.DataValueField = "code"
            lstCategories.DataTextField = "name"
            lstCategories.DataBind()
            objReader.Close()

            'get the list of SubCategories
            objCommand = New SqlCommand("ref_subcategory_get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            lstSubCategories.DataSource = objReader
            lstSubCategories.DataValueField = "code"
            lstSubCategories.DataTextField = "name"
            lstSubCategories.DataBind()
            lstSubCategories.Enabled = True
            objReader.Close()

            'get the list of Inventories
            objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstItems.DataSource = objReader
            lstItems.DataValueField = "code"
            lstItems.DataTextField = "name"
            lstItems.DataBind()
            lstItems.Enabled = True
            objReader.Close()

            'get the list of Warehouse
            objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstWarehouse.DataSource = objReader
            lstWarehouse.DataValueField = "code"
            lstWarehouse.DataTextField = "name"
            lstWarehouse.DataBind()
            'lstWarehouse.SelectedValue = "KOO-WH01"
            lstWarehouse.Enabled = True
            objReader.Close()

            'get the list of Warehouse
            objCommand = New SqlCommand("Ref_NearExpiryYear_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            lstYear.DataSource = objReader
            lstYear.DataValueField = "name"
            lstYear.DataTextField = "code"
            lstYear.DataBind()
            lstYear.SelectedValue = Date.UtcNow.AddHours(8).Year
            lstYear.Enabled = True
            objReader.Close()

            objConnection.Close()

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddRecord.Visible = False
            End If
        End If

    End Sub
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Dim selected As Integer

        Dim Catvalue As String
        Catvalue = "0"
        For Each item As ListItem In lstCategories.Items
            If item.Selected Then
                Catvalue = Catvalue + IIf(Catvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim SubCatValue As String
        SubCatValue = "0"
        For Each item As ListItem In lstSubCategories.Items
            If item.Selected Then
                SubCatValue = SubCatValue + IIf(SubCatValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim ItemValue As String
        ItemValue = "0"
        For Each item As ListItem In lstItems.Items
            If item.Selected Then
                ItemValue = ItemValue + IIf(ItemValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim WarehouseValue As String
        WarehouseValue = "0"
        For Each item As ListItem In lstWarehouse.Items
            If item.Selected Then
                WarehouseValue = WarehouseValue + IIf(WarehouseValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        btnDownload.Visible = True

        If lstInvRep.SelectedValue = "SOH" Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand(strStoredProc2, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@soh", lstSOH.SelectedValue)
            objCommand.Parameters.Add("@category", Catvalue)
            objCommand.Parameters.Add("@subcategory", SubCatValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@warehouse", WarehouseValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()

        ElseIf lstInvRep.SelectedValue = "NearExpiry" Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand(strStoredProc3, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@year", lstYear.SelectedValue)
            objCommand.Parameters.Add("@category", Catvalue)
            objCommand.Parameters.Add("@subcategory", SubCatValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@warehouse", WarehouseValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()

        ElseIf lstInvRep.SelectedValue = "SerialSOH" Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand(strStoredProc4, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@soh", lstSOH.SelectedValue)
            objCommand.Parameters.Add("@category", Catvalue)
            objCommand.Parameters.Add("@subcategory", SubCatValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@warehouse", WarehouseValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()
        End If

        DataGrid.Visible = True

        lblMessage.Text = "Record/s found :" & DataGrid.Items.Count

    End Sub
    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        Dim selected As Integer

        Dim Catvalue As String
        Catvalue = "0"
        For Each item As ListItem In lstCategories.Items
            If item.Selected Then
                Catvalue = Catvalue + IIf(Catvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim SubCatValue As String
        SubCatValue = "0"
        For Each item As ListItem In lstSubCategories.Items
            If item.Selected Then
                SubCatValue = SubCatValue + IIf(SubCatValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim ItemValue As String
        ItemValue = "0"
        For Each item As ListItem In lstItems.Items
            If item.Selected Then
                ItemValue = ItemValue + IIf(ItemValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim WarehouseValue As String
        WarehouseValue = "0"
        For Each item As ListItem In lstWarehouse.Items
            If item.Selected Then
                WarehouseValue = WarehouseValue + IIf(WarehouseValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        DataGrid.SelectedIndex = -1

        If lstInvRep.SelectedValue = "SOH" Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            Dim objCommand As New SqlCommand(strStoredProc2, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@soh", lstSOH.SelectedValue)
            objCommand.Parameters.Add("@category", Catvalue)
            objCommand.Parameters.Add("@subcategory", SubCatValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@warehouse", WarehouseValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()

        ElseIf lstInvRep.SelectedValue = "NearExpiry" Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand(strStoredProc3, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@year", lstYear.SelectedValue)
            objCommand.Parameters.Add("@category", Catvalue)
            objCommand.Parameters.Add("@subcategory", SubCatValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@warehouse", WarehouseValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()

        ElseIf lstInvRep.SelectedValue = "SerialSOH" Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand(strStoredProc4, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@soh", lstSOH.SelectedValue)
            objCommand.Parameters.Add("@category", Catvalue)
            objCommand.Parameters.Add("@subcategory", SubCatValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@warehouse", WarehouseValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()
        End If

        DataGrid.Visible = True

        Try
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("content-disposition", "attachment;filename=" & strFileNameExcel)
            Response.Charset = ""
            Response.ContentType = "application/vnd.ms-excel"

            Dim sw As New System.IO.StringWriter
            Dim hw As New System.Web.UI.HtmlTextWriter(sw)
            DataGrid.RenderControl(hw)

            Dim style As String = "<style> .textmode { } </style>"
            Response.Write(style)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()

        Catch ex As Exception
            lblMessage.Text = "Error export Excel : " & ex.Message
        End Try

    End Sub
    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
    Handles DataGrid.ItemCreated

        
        If lstInvRep.SelectedValue = "SOH" Then

            If Session("company_code") = "SVT" Or Session("company_code") = "ENOVATE" Then

                Dim aColumns() As String = {"", _
                                            "status", _
                                            "warehouse", _
                                            "barcode", _
                                            "brand", _
                                            "name", _
                                            "code", _
                                            "soh", _
                                            "uom", _
                                            "safety_level", _
                                            "critical_level", _
                                            "cat_name", _
                                            "subcat_name", _
                                            "hlight"}


                'the headers to diplay, instead of the default fieldname
                Dim aHeaders() As String = {"Ref#", _
                                            "Status", _
                                            "Warehouse", _
                                            "Barcode", _
                                            "Brand", _
                                            "Item Desc", _
                                            "Item Code", _
                                            "SOH", _
                                            "UOM", _
                                            "Safety Level", _
                                            "Critical Level", _
                                            "Category", _
                                            "SubCategory", _
                                            ""}

                'display what you want below - displays if footer is specified in the datagrid
                Dim aFooters() As String = {"_COUNT_RECORD_", _
                                            "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "_SUM_", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             ""}

                'the item display formats. pass "" to display as is
                Dim aFormats() As String = {"_COUNT_RECORD_", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "N2", _
                                            "", _
                                            "N0", _
                                            "N0", _
                                            "", _
                                            "", _
                                            "X6"}

                'the sort key expression to associate. pass "" to disable sorting
                Dim aSortKeys() As String = {"id", _
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
                                                    DataGrid)
            Else
                Dim aColumns() As String = {"", _
                                            "status", _
                                            "warehouse", _
                                            "code", _
                                            "barcode", _
                                            "cat_name", _
                                            "subcat_name", _
                                            "brand", _
                                            "name", _
                                            "uom", _
                                            "soh", _
                                            "safety_level", _
                                            "critical_level", _
                                            "hlight"}


                'the headers to diplay, instead of the default fieldname
                Dim aHeaders() As String = {"Ref#", _
                                            "Status", _
                                            "Warehouse", _
                                            "Item Code", _
                                            "Barcode", _
                                            "Category", _
                                            "SubCategory", _
                                            "Brand", _
                                            "Item Desc", _
                                            "UOM", _
                                            "SOH", _
                                            "Safety Level", _
                                            "Critical Level", _
                                            ""}

                'display what you want below - displays if footer is specified in the datagrid
                Dim aFooters() As String = {"_COUNT_RECORD_", _
                                            "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "", _
                                             "_SUM_", _
                                             "", _
                                             "", _
                                             ""}

                'the item display formats. pass "" to display as is
                Dim aFormats() As String = {"_COUNT_RECORD_", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "", _
                                            "N2", _
                                            "N0", _
                                            "N0", _
                                            "X6"}

                'the sort key expression to associate. pass "" to disable sorting
                Dim aSortKeys() As String = {"id", _
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
                                                    DataGrid)
            End If

            

        ElseIf lstInvRep.SelectedValue = "NearExpiry" Then

            'handles for each item(ROW) created

            'the columns (ONLY) to display, each items must exist from the resultset
            Dim aColumns() As String = {"", _
                                        "status", _
                                        "warehouse", _
                                        "code", _
                                        "barcode", _
                                        "cat_name", _
                                        "subcat_name", _
                                        "name", _
                                        "specs", _
                                        "uom", _
                                        "jan", _
                                        "feb", _
                                        "mar", _
                                        "apr", _
                                        "may", _
                                        "jun", _
                                        "jul", _
                                        "aug", _
                                        "sep", _
                                        "oct", _
                                        "nov", _
                                        "dec", _
                                        "hlight"}


            'the headers to diplay, instead of the default fieldname
            Dim aHeaders() As String = {"Ref#", _
                                        "Status", _
                                        "Warehouse", _
                                        "Item Code", _
                                        "Client Code", _
                                        "Category", _
                                        "SubCategory", _
                                        "Item Desc", _
                                        "Specs", _
                                        "UOM", _
                                        "JAN", _
                                        "FEB", _
                                        "MAR", _
                                        "APR", _
                                        "MAY", _
                                        "JUN", _
                                        "JUL", _
                                        "AUG", _
                                        "SEP", _
                                        "OCT", _
                                        "NOV", _
                                        "DEC", _
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
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         "_SUM_", _
                                         ""}

            'the item display formats. pass "" to display as is
            Dim aFormats() As String = {"_COUNT_RECORD_", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        ""}

            'the sort key expression to associate. pass "" to disable sorting
            Dim aSortKeys() As String = {"id", _
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
                                         "", _
                                         "", _
                                         ""}

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
                                                strStoredProc3, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                DataGrid)

        ElseIf lstInvRep.SelectedValue = "SerialSOH" Then
            'handles for each item(ROW) created

            'the columns (ONLY) to display, each items must exist from the resultset
            Dim aColumns() As String = {"", _
                                        "status", _
                                        "warehouse", _
                                        "code", _
                                        "barcode", _
                                        "cat_name", _
                                        "subcat_name", _
                                        "brand", _
                                        "name", _
                                        "uom", _
                                        "serial", _
                                        "soh", _
                                        "", _
                                        "", _
                                        "received_date", _
                                        "pr_code", _
                                        "hlight"}


            'the headers to diplay, instead of the default fieldname
            Dim aHeaders() As String = {"Ref#", _
                                        "Status", _
                                        "Warehouse", _
                                        "Item Code", _
                                        "Barcode", _
                                        "Category", _
                                        "SubCategory", _
                                        "Brand", _
                                        "Item Desc", _
                                        "UOM", _
                                        "Lot#/Serial#", _
                                        "SOH", _
                                        "Safety Level", _
                                        "Critical Level", _
                                        "Received Date", _
                                        "PO # / Ref #", _
                                        ""}

            'display what you want below - displays if footer is specified in the datagrid
            Dim aFooters() As String = {"_COUNT_RECORD_", _
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
                                         "_SUM_", _
                                         "", _
                                         "", _
                                         "", _
                                         "", _
                                         ""}

            'the item display formats. pass "" to display as is
            Dim aFormats() As String = {"_COUNT_RECORD_", _
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
                                        "N2", _
                                        "N0", _
                                        "N0", _
                                        "DS", _
                                        "", _
                                        "X6"}

            'the sort key expression to associate. pass "" to disable sorting
            Dim aSortKeys() As String = {"id", _
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
                                                strStoredProc4, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                DataGrid)
        End If

    End Sub

    Sub GridBind()

        'this condition must only run once. initialize session(module) variables
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay_v2(DataGrid, _
                                    strStoredProc, _
                                    Session("username"), _
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
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub

    Private Sub ddlRecordsPerPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ddlRecordsPerPage.SelectedIndexChanged

        txtPageNo.Text = 1
        GridBind()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSearch.Click
        'If txtSearch.Text = "" Then
        '    lblPageRecordCount.Text = lblPageRecordCount.Text & " *Please enter a search key."
        '    Exit Sub
        'End If

        txtPageNo.Text = 1
        GridBind()


    End Sub

    Private Sub DataGrid_SortCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) _
    Handles DataGrid.SortCommand
        Session("SortKey") = e.SortExpression
        txtPageNo.Text = 1
        txtSearch.Text = ""
        GridBind()

    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub lstInvRep_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstInvRep.SelectedIndexChanged
        If lstInvRep.SelectedValue = "NearExpiry" Then
            panelYear.Visible = True
        Else
            panelYear.Visible = False
        End If
    End Sub
End Class
