
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.IO

Public Class ref_clients_dtl
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
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
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
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFormAction2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents lblID2 As System.Web.UI.WebControls.Label
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnNewRecordImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnClientAssetImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblOnProcessOrders As System.Web.UI.WebControls.Label
    Protected WithEvents lblOrderCount As System.Web.UI.WebControls.Label
    Protected WithEvents lblLastOrdered As System.Web.UI.WebControls.Label
    Protected WithEvents lblBalance As System.Web.UI.WebControls.Label
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBranch As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTin As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContact As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContactNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDeliveryAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCity As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlIndustry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlStatus2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlPricing As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents calClientSince As eWorld.UI.CalendarPopup
    Protected WithEvents ddlCGroup As System.Web.UI.WebControls.DropDownList    
    Protected WithEvents panelEquipment As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents btnX As System.Web.UI.WebControls.Button
    Protected WithEvents txtEquipment As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtType As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBrand As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtModel As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSerial As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents txtCustomerItemID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCustomerItemSRPValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnSaveSRP As System.Web.UI.WebControls.Button
    Protected WithEvents ddlItem As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtItemStatusValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtItemSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSessionFullname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCustomerCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblStandardSRP As System.Web.UI.WebControls.Label

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
    Public strStoredProc As String = "ref_clients_dtl"
    Public strStoredProc2 As String = "ref_clients_item"
    Public strSubMenuName As String = "ref_clientassets_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "id"
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

            DisplayHeader()
            GridBind()
            LoadCustomerItemGrid()

            txtSessionFullname.Text = Session("Fullname")
            txtCustomerCode.Text = Request("id")

            'txtFormAction.Text = "Edit"

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button

            End If
        End If

    End Sub
    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Clients_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@code", Request("id"))
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))

        lblClient.Text = Trim(objReader("name"))
        lblOnProcessOrders.Text = Trim(objReader("onprocess_orders"))
        lblOrderCount.Text = Trim(objReader("order_count"))

        If Trim(objReader("last_ordered")) = "1/1/1900" Then
            lblLastOrdered.Text = "N/A"
        Else
            lblLastOrdered.Text = Trim(objReader("last_ordered"))
        End If

        lblBalance.Text = Trim(objReader("owing"))

        txtName.Text = Trim(objReader("name"))
        txtBranch.Text = Trim(objReader("branch"))
        txtEmail.Text = Trim(objReader("email"))
        txtTin.Text = Trim(objReader("tin_no"))
        txtContact.Text = Trim(objReader("contact"))
        txtContactNo.Text = Trim(objReader("contact_no"))

        txtAddress.Text = Trim(objReader("address"))
        txtDeliveryAddress.Text = Trim(objReader("delivery_address"))

        ddlStatus.SelectedValue = Trim(objReader("status"))
        txtTerms.Text = Trim(objReader("terms"))
        txtDiscount.Text = Trim(objReader("discount"))
        ddlPricing.SelectedValue = Trim(objReader("pricing"))

        calClientSince.SelectedDate = Trim(objReader("client_since"))

        Dim strCity As String = objReader("city")
        Dim strIndustry As String = objReader("industry")
        Dim strCompany As String = objReader("company")
        Dim strCustomerGroup As String = objReader("customer_group")

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
        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))

        objCommand = New SqlCommand("Ref_City_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCity.DataSource = objReader
        ddlCity.DataValueField = "name"
        ddlCity.DataTextField = "name"
        ddlCity.DataBind()
        objReader.Close()
        ddlCity.SelectedIndex = ddlCity.Items.IndexOf(ddlCity.Items.FindByValue(strCity.ToString))

        objCommand = New SqlCommand("Ref_Industry_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlIndustry.DataSource = objReader
        ddlIndustry.DataValueField = "name"
        ddlIndustry.DataTextField = "name"
        ddlIndustry.DataBind()
        objReader.Close()
        ddlIndustry.SelectedIndex = ddlIndustry.Items.IndexOf(ddlIndustry.Items.FindByValue(strIndustry.ToString))

        objCommand = New SqlCommand("Ref_CustomerGroups_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCGroup.DataSource = objReader
        ddlCGroup.DataValueField = "name"
        ddlCGroup.DataTextField = "name"
        ddlCGroup.DataBind()
        objReader.Close()
        ddlCGroup.SelectedIndex = ddlCGroup.Items.IndexOf(ddlCGroup.Items.FindByValue(strCustomerGroup.ToString))

        objConnection.Close()
       
    End Sub
    
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("ref_clients_list")
    End Sub

    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
        Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "status", _
                                    "invoice_no", _
                                    "si_date", _
                                    "dr_code", _
                                    "total_item", _
                                    "net_sales", _
                                    "owing"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Status", _
                                    "SI #", _
                                    "SI Date", _
                                    "DR #", _
                                    "Total Item", _
                                    "Amount", _
                                    "Balance"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_"}

        Dim aFormats() As String = {"", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "DS", _
                                    "", _
                                    "N0", _
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
                                            "", _
                                            DataGrid)
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
                                    Request("id"))

    End Sub    

    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub

    Private Function SaveEdit()

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes                

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            panelInfo.Visible = True
            lblValidate.Text = strValidateInput
        End If

    End Function
    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Clients_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@client_code", "")
        objCommand.Parameters.Add("@contact_no", txtContactNo.Text)
        objCommand.Parameters.Add("@client_since", calClientSince.SelectedDate)
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
        Dim objCommand As New SqlCommand("Ref_Clients_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@client_code", "")
        objCommand.Parameters.Add("@branch", txtBranch.Text)
        objCommand.Parameters.Add("@tin_no", txtTin.Text)
        objCommand.Parameters.Add("@contact", txtContact.Text)
        objCommand.Parameters.Add("@contact_no", txtContactNo.Text)
        objCommand.Parameters.Add("@email", txtEmail.Text)
        objCommand.Parameters.Add("@address", txtAddress.Text)
        objCommand.Parameters.Add("@delivery_address", txtDeliveryAddress.Text)
        objCommand.Parameters.Add("@city", ddlCity.SelectedValue)
        objCommand.Parameters.Add("@industry", ddlIndustry.SelectedValue)
        objCommand.Parameters.Add("@customer_group", ddlCGroup.SelectedValue)
        objCommand.Parameters.Add("@terms", txtTerms.Text)
        objCommand.Parameters.Add("@discount", txtDiscount.Text)
        objCommand.Parameters.Add("@client_since", calClientSince.SelectedDate)
        objCommand.Parameters.Add("@pricing", ddlPricing.SelectedValue)
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
                                        strStoredProc, _
                                        "Ref#: " + lblID.Text + " Status: " + ddlStatus.SelectedValue + " > Comapny: " + ddlCompany.SelectedValue + " > ClientName: " + txtName.Text + " > ClientCode: " + "" + " > Branch: " + txtBranch.Text + " > Tin#: " + txtTin.Text + " > Contact: " + txtContact.Text + " > Contact#: " + txtContactNo.Text + " > Email: " + txtEmail.Text + " > Address: " + txtAddress.Text + " > DeliveryAddress: " + txtDeliveryAddress.Text + " > City: " + ddlCity.SelectedValue + " > Industry: " + ddlIndustry.SelectedValue + " > Terms:  " + txtTerms.Text + " > Discount: " + txtDiscount.Text + " > ClientSince: " + "1/1/1999" + " > Pricing: " + ddlPricing.SelectedValue, _
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

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtBranch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranch.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtTin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTin.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtContactNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactNo.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        SaveEdit()
    End Sub

    Private Sub txtDeliveryAddress_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeliveryAddress.TextChanged
        SaveEdit()
    End Sub

    Private Sub ddlCity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCity.SelectedIndexChanged
        SaveEdit()
    End Sub

    Private Sub ddlIndustry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlIndustry.SelectedIndexChanged
        SaveEdit()
    End Sub

    Private Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlStatus.SelectedIndexChanged
        SaveEdit()
    End Sub

    Private Sub txtTerms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerms.TextChanged
        SaveEdit()
    End Sub
    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        SaveEdit()
    End Sub

    Private Sub ddlPricing_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPricing.SelectedIndexChanged
        SaveEdit()
    End Sub

    Private Sub calClientSince_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calClientSince.DateChanged
        SaveEdit()
    End Sub

    Private Sub ddlCGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCGroup.SelectedIndexChanged
        SaveEdit()
    End Sub
    Private Sub ddlCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCompany.SelectedIndexChanged
        SaveEdit()
    End Sub

    Private Sub btnClientAssetImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnClientAssetImg.Click
        Response.Redirect(strSubMenuName & "?id=" & Request("id") & "&sys_table=Ref_Clients_List")
        'SetEndPopup(strSubMenuName & "?id=" & Request("id") & _
        '            " &sys_table=Ref_Clients_List")                    

    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "','_blank')</SCRIPT>"
        RegisterStartupScript("startup", s)

    End Sub
    Private Sub LoadCustomerItemGrid()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand(strStoredProc2, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@customer", Request("id"))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim myItems As String = String.Empty

        While objReader.Read

            If Trim(objReader("status")) = "Active" Then
                myItems &= ("<tr>" & _
                                "<td class='sys_id'>" & _
                                    Trim(objReader("id")) & _
                                "</td>" & _
                                "<td class='item_code'>" & _
                                    "<span>" + Trim(objReader("item_code")) + "</span>" & _
                                "</td>" & _
                                    "<td>" & _
                                    "<select class='ddlItemStatus w3-pale-blue' name='option'>" & _
                                        "<option value='" + Trim(objReader("status")) + "' selected>" + Trim(objReader("status")) + "</option>" & _
                                        "<option value='Inactive'>Inactive</option>" & _
                                    "</select>" & _
                                "</td>" & _
                                "<td>" & _
                                    Trim(objReader("barcode")) & _
                                "</td>" & _
                                "<td>" & _
                                    Trim(objReader("brand")) & _
                                "</td>" & _
                                "<td style='text-align:left;'>" & _
                                    Trim(objReader("item_name")) & _
                                "</td>" & _
                                "<td>" & _
                                    Trim(objReader("uom")) & _
                                "</td>" & _
                                "<td class='standardsrp'>" & _
                                    Trim(objReader("standard_srp")) & _
                                "</td>" & _
                                "<td class='discount'>" & _
                                    Trim(objReader("disc")) & _
                                "</td>" & _
                                "<td class='txtCustomerItemSRP'>" & _
                                    "<input type='text' class='CustomerItemSRP' style='text-align:center;' value='" + Trim(objReader("srp")) + "'>" & _
                                "</td>" & _
                            "</tr>")
            Else
                myItems &= ("<tr>" & _
                                "<td class='sys_id'>" & _
                                    Trim(objReader("id")) & _
                                "</td>" & _
                                "<td class='item_code'>" & _
                                    "<span>" + Trim(objReader("item_code")) + "</span>" & _
                                "</td>" & _
                                    "<td>" & _
                                    "<select class='ddlItemStatus w3-pale-blue' name='option'>" & _
                                        "<option value='Active'>Active</option>" & _
                                        "<option value='" + Trim(objReader("status")) + "' selected>" + Trim(objReader("status")) + "</option>" & _
                                    "</select>" & _
                                "</td>" & _
                                "<td>" & _
                                    Trim(objReader("barcode")) & _
                                "</td>" & _
                                "<td>" & _
                                    Trim(objReader("brand")) & _
                                "</td>" & _
                                "<td style='text-align:left;'>" & _
                                    Trim(objReader("item_name")) & _
                                "</td>" & _
                                "<td>" & _
                                    Trim(objReader("uom")) & _
                                "</td>" & _
                                "<td class='standardsrp'>" & _
                                    Trim(objReader("standard_srp")) & _
                                "</td>" & _
                                "<td class='discount'>" & _
                                    Trim(objReader("disc")) & _
                                "</td>" & _
                                "<td class='txtCustomerItemSRP'>" & _
                                    "<input type='text' class='CustomerItemSRP' style='text-align:center;' value='" + Trim(objReader("srp")) + "'>" & _
                                "</td>" & _
                            "</tr>")
            End If

        End While

        Div1.InnerHtml = myItems

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        txtFormAction.Visible = False
        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green
        btnSave.Text = "Add"
        panelGrid.Visible = False
        SetFocus(ddlItem)

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                            panelSuccess, _
                            panelInfo, _
                            lblMessage, _
                            ValidationSummary1, _
                            lblMode, _
                            txtFormAction)

        txtItemSRP.Text = 0

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Items_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlItem.DataSource = objReader
        ddlItem.DataValueField = "code"
        ddlItem.DataTextField = "name"
        ddlItem.DataBind()
        ddlItem.Items.Insert(0, "")
        ddlItem.SelectedIndex = 0
        objReader.Close()
        objConnection.Close()
    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        panelGrid.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelForm.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput2()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput2()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                lblValidate.Visible = False
            
                SetFocus(ddlItem)
                ddlItem.Items.Insert(0, "")
                ddlItem.SelectedIndex = 0
                lblStandardSRP.Text = 0
                txtItemSRP.Text = 0
                panelForm.Visible = True
                panelGrid.Visible = False
                LoadCustomerItemGrid()

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

        
    End Sub
    Private Function ValidateInput2()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput2 = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientsItem_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@customer", Request("id"))
        objCommand.Parameters.Add("@item_code", ddlItem.SelectedValue)

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
        SaveInput2 = "ok"

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Ref_ClientsItem_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@customer", Request("id"))
        objCommand.Parameters.Add("@item_code", ddlItem.SelectedValue)
        objCommand.Parameters.Add("@srp", txtItemSRP.Text)
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

    End Function

    Private Sub btnSaveSRP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveSRP.Click
        'Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'Dim objCommand As New SqlCommand("Ref_ClientsItem_Save", objConnection)
        'objCommand.CommandType = CommandType.StoredProcedure

        'objCommand.Parameters.Add("@FormAction", "Edit")
        'objCommand.Parameters.Add("@id", txtCustomerItemID.Text)                
        'objCommand.Parameters.Add("@srp", txtCustomerItemSRPValue.Text)        
        'objCommand.Parameters.Add("@Session_fullname", Session("fullname"))

        ''the returned new id 
        'Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        'objCommand.Parameters.Add(objNewID)
        'objNewID.Direction = ParameterDirection.Output

        'Try
        '    'open the connection and execute the query 
        '    objConnection.Open()
        '    objCommand.ExecuteNonQuery()

        'Catch ex As Exception
        '    'in case of error

        'Finally

        '    objConnection.Close()
        'End Try

        'panelSuccess.Visible = True
        'panelInfo.Visible = False
        'panelForm.Visible = False
        'LoadCustomerItemGrid()

    End Sub

    Private Sub ddlItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlItem.SelectedIndexChanged

        panelSuccess.Visible = False
        panelInfo.Visible = False

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Ref_Items_GetID", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@code", ddlItem.SelectedValue)        

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblStandardSRP.Text = Trim(objReader("srp"))

        objReader.Close()
        objConnection.Close()
        
    End Sub
End Class

