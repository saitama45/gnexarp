
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.IO


Public Class ref_itemswithoucost_list
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnPrev As System.Web.UI.WebControls.Button
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents txtCurrentPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageTotal As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalRecords As System.Web.UI.WebControls.Label
    Protected WithEvents panelPaginations As System.Web.UI.WebControls.Panel

    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
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
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
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
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCategory As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlSubCategory As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtStock As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP12 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP13 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP14 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP15 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtClientCode As System.Web.UI.WebControls.TextBox    
    Protected WithEvents txtSafetyLevel As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelSafetyLevel As System.Web.UI.WebControls.Panel
    Protected WithEvents txtSpecs As System.Web.UI.WebControls.TextBox
    Protected WithEvents chbWarehouse As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents FileUploadSO As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents btnUploadSO As System.Web.UI.WebControls.Button
    Protected WithEvents tblShowValidation As System.Web.UI.WebControls.Table

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
    Public strSubMenuName As String = "ref_itemswithoucost_list"
    Public strStoredProc As String = "Ref_ItemsWithouCost_list"
    Public strStoredProcPageCount As String = "Inv_ItemsPageCount_Get"

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
            Refresh_PageTotal()
            Refresh_PagingButton()

            btnCancel.Visible = False

            btnCancel.Attributes("onclick") = "return confirm('Cancel?');"
            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            hlViewFullTrail.NavigateUrl = "trx_fullhistory?sys_table=" & strSubMenuName & "&mode=2&ID=0"

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
    Sub GridBind()

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count

    End Sub
    Private Sub Refresh_PageTotal()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProcPageCount, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblPageTotal.Text = Trim(objReader("page_total"))

        objReader.Close()
        objConnection.Close()

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub Refresh_PagingButton()
        Dim currentPage As Integer = Integer.Parse(txtCurrentPage.Text)
        Dim totalPages As Integer = Integer.Parse(lblPageTotal.Text)

        btnNext.Enabled = currentPage < totalPages
        btnPrev.Enabled = currentPage > 1

        If currentPage = totalPages Then
            btnNext.Enabled = False
        End If

        If currentPage = 1 Then
            btnPrev.Enabled = False
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Refresh_NextPage()
        Refresh_PageTotal()
        Refresh_PagingButton()
    End Sub
    Private Sub Refresh_NextPage()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text + 1)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text + 1

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Refresh_PrevPage()
        Refresh_PageTotal()
        Refresh_PagingButton()
    End Sub
    Private Sub Refresh_PrevPage()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text - 1)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text - 1

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub txtCurrentPage_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentPage.TextChanged
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text
        Refresh_PagingButton()
        Refresh_PageTotal()

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSearch.Click
        If txtSearch.Text = "" Then
            GridBind()
            Refresh_PageTotal()
            Refresh_PagingButton()
            panelPaginations.Visible = True
        Else
            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            'the stored procedure and parameters
            Dim objCommand As New SqlCommand(strStoredProc, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@page_rows_max", 0)
            objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
            objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            'open the connection and execute the reader 
            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            'the key field
            DataGrid.DataKeyField = strKeyField
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()

            panelPaginations.Visible = False

            lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
        End If

    End Sub
    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAddRecord.Click

        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green
        btnSave.Text = "Add"
        ClearInputs()
        SetFocus(ddlStatus)

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_UOM_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "code"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "code"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        ddlBrand.Items.Insert(0, "")
        ddlBrand.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_Category_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCategory.DataSource = objReader
        ddlCategory.DataValueField = "code"
        ddlCategory.DataTextField = "name"
        ddlCategory.DataBind()
        ddlCategory.Items.Insert(0, "")
        ddlCategory.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_SubCategory_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlSubCategory.DataSource = objReader
        ddlSubCategory.DataValueField = "code"
        ddlSubCategory.DataTextField = "name"
        ddlSubCategory.DataBind()
        ddlSubCategory.Items.Insert(0, "")
        ddlSubCategory.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader

        chbWarehouse.Items.Clear()

        While objReader.Read

            Dim chbListWarehouse As New ListItem

            chbListWarehouse.Value = objReader("code")
            chbListWarehouse.Text = Trim(objReader("code"))

            If VarType(objReader("code")) = VariantType.Boolean Then
                chbListWarehouse.Selected = (objReader("code") = True)
            Else
                chbListWarehouse.Selected = False
            End If

            chbWarehouse.Items.Add(chbListWarehouse)

        End While
        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
   Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.ForeColor = Color.Orange
        btnSave.Text = "Add"
        panelGrid.Visible = False

        'show the input panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        ReadyEdit() 'retrive and fill the text box for editing
        SetFocus(ddlStatus)
    End Sub
    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Delete"
        lblMode.ForeColor = Color.Red
        panelGrid.Visible = False
        btnSave.Text = "Delete"

        'show the form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        ReadyDelete() 'retrive and fill the text box for editing
    End Sub
    Private Sub ReadyEdit()

        panelSafetyLevel.Visible = True
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")

        ddlStatus.SelectedValue = Trim(objReader("status"))
        ddlType.SelectedValue = Trim(objReader("MI"))
        txtClientCode.Text = Trim(objReader("client_code"))
        txtBarcode.Text = Trim(objReader("barcode"))
        txtName.Text = Trim(objReader("name"))
        txtSpecs.Text = Trim(objReader("specs"))
        txtSRP.Text = Trim(objReader("srp"))
        txtSRP2.Text = Trim(objReader("srp2"))
        txtSRP3.Text = Trim(objReader("srp3"))
        txtSRP4.Text = Trim(objReader("srp4"))
        txtSRP5.Text = Trim(objReader("srp5"))
        txtSRP6.Text = Trim(objReader("srp6"))
        txtSRP7.Text = Trim(objReader("srp7"))
        txtSRP8.Text = Trim(objReader("srp8"))
        txtSRP9.Text = Trim(objReader("srp9"))
        txtSRP10.Text = Trim(objReader("srp10"))
        txtSRP11.Text = Trim(objReader("srp11"))
        txtSRP12.Text = Trim(objReader("srp12"))
        txtSRP13.Text = Trim(objReader("srp13"))
        txtSRP14.Text = Trim(objReader("srp14"))
        txtSRP15.Text = Trim(objReader("srp15"))
        txtInc1.Text = Trim(objReader("incentive1"))
        txtInc2.Text = Trim(objReader("incentive2"))
        txtInc3.Text = Trim(objReader("incentive3"))
        txtSafetyLevel.Text = Trim(objReader("safety_level"))

        Dim strCompany As String = objReader("company")
        Dim strUOM As String = objReader("UOM")
        Dim strBrand As String = objReader("brand")
        Dim strCategory As String = objReader("category")
        Dim strSubCategory As String = objReader("subcategory")

        objReader.Close()

        objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_UOM_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "code"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Category_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCategory.DataSource = objReader
        ddlCategory.DataValueField = "code"
        ddlCategory.DataTextField = "name"
        ddlCategory.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "code"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_SubCategory_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlSubCategory.DataSource = objReader
        ddlSubCategory.DataValueField = "code"
        ddlSubCategory.DataTextField = "name"
        ddlSubCategory.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader

        chbWarehouse.Items.Clear()

        While objReader.Read

            Dim chbListWarehouse As New ListItem

            chbListWarehouse.Value = objReader("code")
            chbListWarehouse.Text = Trim(objReader("code"))

            If VarType(objReader("code")) = VariantType.Boolean Then
                chbListWarehouse.Selected = (objReader("code") = True)
            Else
                chbListWarehouse.Selected = False
            End If

            chbWarehouse.Items.Add(chbListWarehouse)

        End While
        objReader.Close()

        objConnection.Close()

        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        ddlUOM.SelectedIndex = ddlUOM.Items.IndexOf(ddlUOM.Items.FindByValue(strUOM.ToString))
        ddlBrand.SelectedIndex = ddlBrand.Items.IndexOf(ddlBrand.Items.FindByValue(strBrand.ToString))
        ddlCategory.SelectedIndex = ddlCategory.Items.IndexOf(ddlCategory.Items.FindByValue(strCategory.ToString))
        ddlSubCategory.SelectedIndex = ddlSubCategory.Items.IndexOf(ddlSubCategory.Items.FindByValue(strSubCategory.ToString))

        'clear protection
        txtBarcode.ReadOnly = False
        txtClientCode.ReadOnly = False
        txtSpecs.ReadOnly = False
        txtName.ReadOnly = False
        txtSRP.ReadOnly = False
        txtSRP2.ReadOnly = False
        txtSRP3.ReadOnly = False
        txtSRP4.ReadOnly = False
        txtSRP5.ReadOnly = False
        txtSRP6.ReadOnly = False
        txtSRP7.ReadOnly = False
        txtSRP8.ReadOnly = False
        txtSRP9.ReadOnly = False
        txtSRP10.ReadOnly = False
        txtSRP11.ReadOnly = False
        txtSRP12.ReadOnly = False
        txtSRP13.ReadOnly = False
        txtSRP14.ReadOnly = False
        txtSRP15.ReadOnly = False
        txtInc1.ReadOnly = False
        txtInc2.ReadOnly = False
        txtInc3.ReadOnly = False
        txtSafetyLevel.ReadOnly = False
        ddlBrand.Enabled = True
        ddlCategory.Enabled = True
        ddlStatus.Enabled = True
        ddlType.Enabled = True
        ddlSubCategory.Enabled = True
        ddlUOM.Enabled = True
        ddlCompany.Enabled = True

        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False
        SetFocus(ddlStatus)

    End Sub
    Private Sub ReadyDelete()

        panelSafetyLevel.Visible = True
        'retrieve and fill in the panel record textboxes for editing
        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")

        ddlStatus.SelectedValue = Trim(objReader("status"))
        ddlType.SelectedValue = Trim(objReader("MI"))
        txtClientCode.Text = Trim(objReader("client_code"))
        txtBarcode.Text = Trim(objReader("barcode"))
        txtSpecs.Text = Trim(objReader("specs"))
        txtName.Text = Trim(objReader("name"))
        txtSRP.Text = Trim(objReader("srp"))
        txtSRP2.Text = Trim(objReader("srp2"))
        txtSRP3.Text = Trim(objReader("srp3"))
        txtSRP4.Text = Trim(objReader("srp4"))
        txtSRP5.Text = Trim(objReader("srp5"))
        txtSRP6.Text = Trim(objReader("srp6"))
        txtSRP7.Text = Trim(objReader("srp7"))
        txtSRP8.Text = Trim(objReader("srp8"))
        txtSRP9.Text = Trim(objReader("srp9"))
        txtSRP10.Text = Trim(objReader("srp10"))
        txtSRP11.Text = Trim(objReader("srp11"))
        txtSRP12.Text = Trim(objReader("srp12"))
        txtSRP13.Text = Trim(objReader("srp13"))
        txtSRP14.Text = Trim(objReader("srp14"))
        txtSRP15.Text = Trim(objReader("srp15"))
        txtInc1.Text = Trim(objReader("incentive1"))
        txtInc2.Text = Trim(objReader("incentive2"))
        txtInc3.Text = Trim(objReader("incentive3"))
        txtSafetyLevel.Text = Trim(objReader("safety_level"))

        Dim strUOM As String = objReader("UOM")
        Dim strBrand As String = objReader("brand")
        Dim strCategory As String = objReader("category")
        Dim strSubCategory As String = objReader("subcategory")
        Dim strCompany As String = objReader("company")

        objReader.Close()

        objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_UOM_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "code"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "code"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Category_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCategory.DataSource = objReader
        ddlCategory.DataValueField = "code"
        ddlCategory.DataTextField = "name"
        ddlCategory.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_SubCategory_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlSubCategory.DataSource = objReader
        ddlSubCategory.DataValueField = "code"
        ddlSubCategory.DataTextField = "name"
        ddlSubCategory.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader

        chbWarehouse.Items.Clear()

        While objReader.Read

            Dim chbListWarehouse As New ListItem

            chbListWarehouse.Value = objReader("code")
            chbListWarehouse.Text = Trim(objReader("code"))

            If VarType(objReader("code")) = VariantType.Boolean Then
                chbListWarehouse.Selected = (objReader("code") = True)
            Else
                chbListWarehouse.Selected = False
            End If

            chbWarehouse.Items.Add(chbListWarehouse)

        End While
        objReader.Close()

        objConnection.Close()

        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        ddlUOM.SelectedIndex = ddlUOM.Items.IndexOf(ddlUOM.Items.FindByValue(strUOM.ToString))
        ddlBrand.SelectedIndex = ddlBrand.Items.IndexOf(ddlBrand.Items.FindByValue(strBrand.ToString))
        ddlCategory.SelectedIndex = ddlCategory.Items.IndexOf(ddlCategory.Items.FindByValue(strCategory.ToString))
        ddlSubCategory.SelectedIndex = ddlSubCategory.Items.IndexOf(ddlSubCategory.Items.FindByValue(strSubCategory.ToString))

        'protect the inputs 
        txtBarcode.ReadOnly = True
        txtClientCode.ReadOnly = True
        txtSpecs.ReadOnly = True
        txtName.ReadOnly = True
        txtSRP.ReadOnly = True
        txtSRP2.ReadOnly = True
        txtSRP3.ReadOnly = True
        txtSRP4.ReadOnly = True
        txtSRP5.ReadOnly = True
        txtSRP6.ReadOnly = True
        txtSRP7.ReadOnly = True
        txtSRP8.ReadOnly = True
        txtSRP9.ReadOnly = True
        txtSRP10.ReadOnly = True
        txtSRP11.ReadOnly = True
        txtSRP12.ReadOnly = True
        txtSRP13.ReadOnly = True
        txtSRP14.ReadOnly = True
        txtSRP15.ReadOnly = True
        txtInc1.ReadOnly = True
        txtInc2.ReadOnly = True
        txtInc3.ReadOnly = True
        txtSafetyLevel.ReadOnly = True
        ddlBrand.Enabled = False
        ddlCategory.Enabled = False
        ddlStatus.Enabled = False
        ddlType.Enabled = False
        ddlSubCategory.Enabled = False
        ddlUOM.Enabled = False
        ddlCompany.Enabled = False

        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False

        SetFocus(btnSave)
    End Sub

    Private Sub ClearInputs()
        'centralized clearing of text boxes 
        'removes settings of readonly textboxes - usually set by ReadyEdit()
        'perform any housekeeping here

        ddlStatus.SelectedValue = "ACTIVE"
        ddlType.SelectedValue = "MI"
        txtClientCode.Text = ""
        txtBarcode.Text = ""
        txtSpecs.Text = ""
        txtName.Text = ""
        txtSRP.Text = 0
        txtSRP2.Text = 0
        txtSRP3.Text = 0
        txtSRP4.Text = 0
        txtSRP5.Text = 0
        txtSRP6.Text = 0
        txtSRP7.Text = 0
        txtSRP8.Text = 0
        txtSRP9.Text = 0
        txtSRP10.Text = 0
        txtSRP11.Text = 0
        txtSRP12.Text = 0
        txtSRP13.Text = 0
        txtSRP14.Text = 0
        txtSRP15.Text = 0
        txtInc1.Text = 0
        txtInc2.Text = 0
        txtInc3.Text = 0
        txtSafetyLevel.Text = 0

        txtClientCode.ReadOnly = False
        txtBarcode.ReadOnly = False
        txtSpecs.ReadOnly = False
        txtName.ReadOnly = False
        txtSRP.ReadOnly = False
        txtSRP2.ReadOnly = False
        txtSRP3.ReadOnly = False
        txtSRP4.ReadOnly = False
        txtSRP5.ReadOnly = False
        txtSRP6.ReadOnly = False
        txtSRP7.ReadOnly = False
        txtSRP8.ReadOnly = False
        txtSRP9.ReadOnly = False
        txtSRP10.ReadOnly = False
        txtSRP11.ReadOnly = False
        txtSRP12.ReadOnly = False
        txtSRP13.ReadOnly = False
        txtSRP14.ReadOnly = False
        txtSRP15.ReadOnly = False
        txtInc1.ReadOnly = False
        txtInc2.ReadOnly = False
        txtInc3.ReadOnly = False
        txtSafetyLevel.ReadOnly = False
        ddlStatus.Enabled = True
        ddlUOM.Enabled = True
        ddlCompany.Enabled = True
        ddlBrand.Enabled = True
        ddlCategory.Enabled = True
        ddlSubCategory.Enabled = True

        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False
        panelGrid.Visible = False

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

        'always hide, but show later in this module
        lblMessage.Visible = False

        If Not Page.IsValid Then
            Exit Sub
        End If

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes
                lblMessage.Visible = True

                If txtFormAction.Text = "Add" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelGrid.Visible = True

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelGrid.Visible = True

                    'reset and rebind    
                    DataGrid.SelectedIndex = -1
                    GridBind()

                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelGrid.Visible = True

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    GridBind()
                End If

            Else
                'notify unsucessful and the reason
                lblMessage.Visible = True
                lblMessage.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            lblMessage.Visible = True
            lblMessage.Text = strValidateInput
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
        Dim objCommand As New SqlCommand("Ref_Items_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@client_code", txtClientCode.Text)
        objCommand.Parameters.Add("@brand", ddlBrand.SelectedValue)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

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
        Dim objCommand As New SqlCommand("Ref_Items_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@client_code", txtClientCode.Text)
        objCommand.Parameters.Add("@barcode", txtBarcode.Text)
        objCommand.Parameters.Add("@type", ddlType.SelectedValue)
        objCommand.Parameters.Add("@brand", ddlBrand.SelectedValue)
        objCommand.Parameters.Add("@category", ddlCategory.SelectedValue)
        objCommand.Parameters.Add("@subcategory", ddlSubCategory.SelectedValue)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@specs", txtSpecs.Text)
        objCommand.Parameters.Add("@uom", ddlUOM.SelectedValue)
        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@srp2", txtSRP2.Text)
        objCommand.Parameters.Add("@srp3", txtSRP3.Text)
        objCommand.Parameters.Add("@srp4", txtSRP4.Text)
        objCommand.Parameters.Add("@srp5", txtSRP5.Text)
        objCommand.Parameters.Add("@srp6", txtSRP6.Text)
        objCommand.Parameters.Add("@srp7", txtSRP7.Text)
        objCommand.Parameters.Add("@srp8", txtSRP8.Text)
        objCommand.Parameters.Add("@srp9", txtSRP9.Text)
        objCommand.Parameters.Add("@srp10", txtSRP10.Text)
        objCommand.Parameters.Add("@srp11", txtSRP11.Text)
        objCommand.Parameters.Add("@srp12", txtSRP12.Text)
        objCommand.Parameters.Add("@srp13", txtSRP13.Text)
        objCommand.Parameters.Add("@srp14", txtSRP14.Text)
        objCommand.Parameters.Add("@srp15", txtSRP15.Text)
        objCommand.Parameters.Add("@incentive1", txtInc1.Text)
        objCommand.Parameters.Add("@incentive2", txtInc2.Text)
        objCommand.Parameters.Add("@incentive3", txtInc3.Text)
        objCommand.Parameters.Add("@safety_level", txtSafetyLevel.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        'the returned new code 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of UOM
            objCommand = New SqlCommand("Ref_UOM_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@name", ddlUOM.SelectedValue)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strUOM As String = objReader("name")
            objReader.Close()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref#: " + lblID.Text + " Status: " + ddlStatus.SelectedValue + " > ClientCode: " + txtClientCode.Text + " > Barcode: " + txtBarcode.Text + " > Type: " + ddlType.SelectedValue + " > Brand: " + ddlBrand.SelectedValue + " > Category: " + ddlCategory.SelectedValue + " > SubCategory: " + ddlSubCategory.SelectedValue + " > Item: " + txtName.Text + " > Specs: " + txtSpecs.Text + " > UOM: " + strUOM + " > SRP: " + txtSRP.Text + " > SRP2: " + txtSRP2.Text + " > SRP3: " + txtSRP3.Text + " > SRP4: " + txtSRP4.Text + " > SRP5: " + txtSRP5.Text + " > SRP6: " + txtSRP6.Text + " > Incentive1: " + txtInc1.Text + " > Incentive2: " + txtInc2.Text + " > Incentive3: " + txtInc3.Text + " > SafetyLevel: " + txtSafetyLevel.Text, _
                                        objNewID.Value, _
                                        "0")

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

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        If e.CommandName = "Open" Then

            Response.Redirect("ref_subitemswithoutcost_list?&id=" & strKeyFieldValue & "&sys_table=" & strStoredProc)

        End If

    End Sub
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("sys_references")
    End Sub
    Protected Sub UploadSO(ByVal sender As Object, ByVal e As EventArgs)
        Dim csvPath As String = Server.MapPath("~/Uploads/") + "uploadedItems.txt"
        'Dim FileName As String = System.IO.Path.GetFileName(FileUploadBilling.PostedFile.FileName)
        'Dim csvPath As String = Server.MapPath("~/Uploads/") + FileName + ".txt"

        If (Not FileUploadSO.PostedFile Is Nothing) AndAlso (FileUploadSO.PostedFile.ContentLength > 0) Then

            Try
                'Upload and save the File.
                FileUploadSO.PostedFile.SaveAs(csvPath)

                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                Dim objCommand As New SqlCommand("upl_ImportItemsCSV", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure

                objCommand.Parameters.Add("@id", 0)

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
                        GridBind()
                        FileUploadSO.Visible = False
                        btnUploadSO.Visible = False

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

                    objCommand = New SqlCommand("Ref_ItemUpload_Validate2", objConnection)
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
        Dim objCommand As New SqlCommand("Ref_ItemUpload_Validate", objConnection)
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
        Dim objCommand As New SqlCommand("Ref_ItemUpload_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Upload")
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        "ref_Items_list", _
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
End Class
