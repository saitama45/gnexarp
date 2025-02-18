
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.IO


Public Class ref_vendors_list
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
    Protected WithEvents txtClientCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBline As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbliFOMSBline As System.Web.UI.WebControls.Label
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContactNo As System.Web.UI.WebControls.TextBox   
    Protected WithEvents txtContact As System.Web.UI.WebControls.TextBox
    Protected WithEvents calContractExpiration As eWorld.UI.CalendarPopup
    Protected WithEvents ddlCity As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlIndustry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents chbNoContractExpiration As System.Web.UI.WebControls.CheckBox
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

    'START MODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    'holds an array of invisible fields
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList

    'the stored proc to call
    Public strSubMenuName As String = "ref_vendors_list"
    Public strStoredProc As String = "Ref_Vendors_List"
    Public strStoredProcPageCount As String = "Inv_VendorsPageCount_Get"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "code"
    Public strKeyField As String = "code"

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
        ClearInputs()
        panelGrid.Visible = False
        SetFocus(txtName)

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

    End Sub
    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
   Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.ForeColor = Color.Orange
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

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Vendors_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", strKeyFieldValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strCity As String = objReader("city")
        Dim strIndustry As String = objReader("industry")
        Dim strCompany As String = objReader("company")

        lblID.Text = objReader("id")

        txtName.Text = Trim(objReader("name"))
        txtClientCode.Text = Trim(objReader("client_code"))
        txtContact.Text = objReader("contact")
        txtContactNo.Text = objReader("contact_no")
        txtEmail.Text = objReader("email")
        txtAddress.Text = objReader("address")
        txtTerms.Text = objReader("terms")

        txtNote.Text = objReader("note")

        If Trim(objReader("contract_expiration")) = "1/1/1900" Then
            chbNoContractExpiration.Checked = True
            chbNoContractExpiration.Enabled = True
            calContractExpiration.Visible = False
            calContractExpiration.SelectedDate = "1/1/1900"
        Else
            chbNoContractExpiration.Checked = False
            chbNoContractExpiration.Enabled = True
            calContractExpiration.Visible = True
            calContractExpiration.SelectedDate = Trim(objReader("contract_expiration"))
        End If

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

        objCommand = New SqlCommand("Ref_City_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCity.DataSource = objReader
        ddlCity.DataValueField = "name"
        ddlCity.DataTextField = "name"
        ddlCity.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Industry_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlIndustry.DataSource = objReader
        ddlIndustry.DataValueField = "name"
        ddlIndustry.DataTextField = "name"
        ddlIndustry.DataBind()
        objReader.Close()

        objConnection.Close()

        'clear protection
        ddlCity.Enabled = True
        ddlIndustry.Enabled = True
        txtName.ReadOnly = False
        txtClientCode.ReadOnly = False
        txtContact.ReadOnly = False
        txtContactNo.ReadOnly = False
        txtEmail.ReadOnly = False
        txtAddress.ReadOnly = False
        txtTerms.ReadOnly = False
        calContractExpiration.Enabled = True
        txtNote.ReadOnly = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False
        SetFocus(txtName)

        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        ddlCity.SelectedIndex = ddlCity.Items.IndexOf(ddlCity.Items.FindByValue(strCity.ToString))
        ddlIndustry.SelectedIndex = ddlIndustry.Items.IndexOf(ddlIndustry.Items.FindByValue(strIndustry.ToString))

    End Sub
    Private Sub ReadyDelete()

        'retrieve and fill in the panel record textboxes for editing
        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Vendors_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", strKeyFieldValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strCity As String = objReader("city")
        Dim strIndustry As String = objReader("industry")
        Dim strCompany As String = objReader("company")

        lblID.Text = objReader("id")
        txtName.Text = objReader("name")
        txtClientCode.Text = objReader("client_code")
        txtContact.Text = objReader("contact")
        txtContactNo.Text = objReader("contact_no")
        txtEmail.Text = objReader("email")
        txtAddress.Text = objReader("address")
        txtTerms.Text = objReader("terms")
        txtNote.Text = objReader("note")

        If Trim(objReader("contract_expiration")) = "1/1/1900" Then
            chbNoContractExpiration.Checked = True
            chbNoContractExpiration.Enabled = False
            calContractExpiration.Visible = False
            calContractExpiration.SelectedDate = "1/1/1900"
        Else
            chbNoContractExpiration.Checked = False
            chbNoContractExpiration.Enabled = False
            calContractExpiration.Visible = True
            calContractExpiration.SelectedDate = Trim(objReader("contract_expiration"))
        End If

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

        objCommand = New SqlCommand("Ref_City_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCity.DataSource = objReader
        ddlCity.DataValueField = "name"
        ddlCity.DataTextField = "name"
        ddlCity.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Industry_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlIndustry.DataSource = objReader
        ddlIndustry.DataValueField = "name"
        ddlIndustry.DataTextField = "name"
        ddlIndustry.DataBind()
        objReader.Close()

        objConnection.Close()

        'protect the inputs 
        ddlCity.Enabled = False
        ddlIndustry.Enabled = False
        txtName.ReadOnly = True
        txtClientCode.ReadOnly = True
        txtContact.ReadOnly = True
        txtContactNo.ReadOnly = True
        txtEmail.ReadOnly = True
        txtAddress.ReadOnly = True
        txtTerms.ReadOnly = True
        calContractExpiration.Enabled = False
        txtNote.ReadOnly = True
        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False

        SetFocus(btnSave)

        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        ddlCity.SelectedIndex = ddlCity.Items.IndexOf(ddlCity.Items.FindByValue(strCity.ToString))
        ddlIndustry.SelectedIndex = ddlIndustry.Items.IndexOf(ddlIndustry.Items.FindByValue(strIndustry.ToString))
    End Sub

    Private Sub ClearInputs()
        'centralized clearing of text boxes 
        'removes settings of readonly textboxes - usually set by ReadyEdit()
        'perform any housekeeping here

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

        objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Industry_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlIndustry.DataSource = objReader
        ddlIndustry.DataValueField = "name"
        ddlIndustry.DataTextField = "name"
        ddlIndustry.DataBind()
        ddlIndustry.Items.Insert(0, "")
        ddlIndustry.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        txtName.Text = ""
        txtClientCode.Text = ""
        txtContact.Text = ""
        txtContactNo.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtTerms.Text = 0

        chbNoContractExpiration.Checked = True
        chbNoContractExpiration.Enabled = True
        calContractExpiration.Visible = False
        calContractExpiration.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
        calContractExpiration.Enabled = True

        txtNote.Text = ""

        ddlCity.Enabled = True
        ddlIndustry.Enabled = True
        txtName.ReadOnly = False
        txtClientCode.ReadOnly = False
        txtContact.ReadOnly = False
        txtContactNo.ReadOnly = False
        txtEmail.ReadOnly = False
        txtAddress.ReadOnly = False
        txtTerms.ReadOnly = False
        calContractExpiration.Enabled = True

        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False

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

                    'reset and rebind        
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
        Dim objCommand As New SqlCommand("Ref_Vendors_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@name", txtName.Text)

        If chbNoContractExpiration.Checked = True Then
            objCommand.Parameters.Add("@contract_expiration", "1/1/1999")
        Else
            objCommand.Parameters.Add("@contract_expiration", calContractExpiration.SelectedDate)
        End If

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
        Dim objCommand As New SqlCommand("Ref_Vendors_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@type", ddlType.SelectedValue)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@client_code", txtClientCode.Text)
        objCommand.Parameters.Add("@contact", txtContact.Text)
        objCommand.Parameters.Add("@contact_no", txtContactNo.Text)
        objCommand.Parameters.Add("@email", txtEmail.Text)
        objCommand.Parameters.Add("@address", txtAddress.Text)
        objCommand.Parameters.Add("@city", ddlCity.SelectedValue)
        objCommand.Parameters.Add("@industry", ddlIndustry.SelectedValue)
        objCommand.Parameters.Add("@terms", txtTerms.Text)

        If chbNoContractExpiration.Checked = True Then
            objCommand.Parameters.Add("@contract_expiration", "1/1/1999")
        Else
            objCommand.Parameters.Add("@contract_expiration", calContractExpiration.SelectedDate)
        End If

        objCommand.Parameters.Add("@note", txtNote.Text)
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
                                        "Ref#: " + lblID.Text + " > VendorName: " + txtName.Text + " > Contact: " + txtContact.Text + " > Contact#: " + txtContactNo.Text + " > Email: " + txtEmail.Text + " > Address: " + txtAddress.Text + " > City: " + ddlCity.SelectedValue + " > Industry: " + ddlIndustry.SelectedValue + " > Terms: " + txtTerms.Text + " > ContractExpiration: " + calContractExpiration.SelectedDate + " > Note: " + txtNote.Text, _
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

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Vendors_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", strKeyFieldValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes 
        objReader.Read()

        lblID.Text = objReader("id")

        If e.CommandName = "Open" Then

            Response.Redirect("ref_venitems_list?&id=" & strKeyFieldValue & "&sys_table=" & strStoredProc)

        End If

        objConnection.Close()


    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("sys_references")
    End Sub

    Private Sub chbNoContractExpiration_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbNoContractExpiration.CheckedChanged

        If chbNoContractExpiration.Checked = True Then
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calContractExpiration.Visible = False
            calContractExpiration.Enabled = False
            SetFocus(txtName)
        Else
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calContractExpiration.Visible = True
            calContractExpiration.Enabled = True
            SetFocus(calContractExpiration)
        End If
    End Sub
    Protected Sub UploadSO(ByVal sender As Object, ByVal e As EventArgs)
        Dim csvPath As String = Server.MapPath("~/Uploads/") + "uploadedVendors.txt"
        'Dim FileName As String = System.IO.Path.GetFileName(FileUploadBilling.PostedFile.FileName)
        'Dim csvPath As String = Server.MapPath("~/Uploads/") + FileName + ".txt"

        If (Not FileUploadSO.PostedFile Is Nothing) AndAlso (FileUploadSO.PostedFile.ContentLength > 0) Then

            Try
                'Upload and save the File.
                FileUploadSO.PostedFile.SaveAs(csvPath)

                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                Dim objCommand As New SqlCommand("upl_ImportVendorsCSV", objConnection)
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

                    objCommand = New SqlCommand("Ref_VendorUpload_Validate2", objConnection)
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
        Dim objCommand As New SqlCommand("Ref_VendorUpload_Validate", objConnection)
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
        Dim objCommand As New SqlCommand("Ref_VendorUpload_Save", objConnection)
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
                                        "ref_vendors_list", _
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
