
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class rep_sales_history
    Inherits System.Web.UI.Page
    Dim ds As DataSet = New DataSet

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents calFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calTo As eWorld.UI.CalendarPopup
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblRecords As System.Web.UI.WebControls.Label
    Protected WithEvents dgList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnGenerate As System.Web.UI.WebControls.Button
    Protected WithEvents btnDownload As System.Web.UI.WebControls.Button
    Protected WithEvents ddlClient As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lstOutletGroup As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstOutlet As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstChannel As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstBrand As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstCategory As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstClass As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstSKU As System.Web.UI.WebControls.ListBox
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
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
    Protected WithEvents calBSDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calBSDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents btnFullView As System.Web.UI.WebControls.Button
    Protected WithEvents lstMainClient As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstLSC As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents calReportingDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calReportingDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents rdoDates As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents panReportingDate As System.Web.UI.WebControls.Panel
    Protected WithEvents calDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents panelCancelledDate As System.Web.UI.WebControls.Panel
    Protected WithEvents panelReportingDate As System.Web.UI.WebControls.Panel
    Protected WithEvents lstMotherCompany As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstItem As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstSalesHistoryBy As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstClient As System.Web.UI.WebControls.ListBox
    Protected WithEvents btnSummary As System.Web.UI.WebControls.Button
    Protected WithEvents btnDeduction As System.Web.UI.WebControls.Button
    Protected WithEvents lblMainClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblBrand As System.Web.UI.WebControls.Label
    Protected WithEvents lblItem As System.Web.UI.WebControls.Label
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'the stored proc to call
    Public strSubMenuName As String = "rep_sales_history"
    Public strStoredProc As String = "Rep_Sales_History_AccountName_Detail"
    Public strStoredProc2 As String = "Rep_Sales_History_AccountName_Summary"
    Public strStoredProc3 As String = "Rep_Sales_History_BusinessName_Detail"
    Public strStoredProc4 As String = "Rep_Sales_History_BusinessName_Summary"
    Public strStoredProc5 As String = "Rep_Sales_History_Product_BusinessName"
    Public strStoredProc6 As String = "Rep_Sales_History_Product_AccountName"
    Public strStoredProc7 As String = "Rep_Sales_History_Brand_AccountName"
    Public strStoredProc8 As String = "Rep_Sales_History_Brand_BusinessName"
    Public strStoredProc9 As String = "Rep_Sales_History_Brand_Product"
    Public strStoredProc10 As String = "Rep_Sales_History_Product_LotSerial"
    Public strSubMenuFullView As String = "rep_sales_history_popup"

    Public strSPParam_BSDateFr As String = "@bs_date_from"
    Public strSPParam_BSDateTo As String = "@bs_date_to"
    Public strSPParam_User As String = "@Session_username"

    Public strFileNameExcel As String = "SalesHistoryReport.xls"
    Public strFileNamePDF As String = "SalesHistoryReport.pdf"

    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList


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

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage")
        End If

        If Not Page.IsPostBack Then
            calDateFrom.SelectedDate = "6/1/2022" 'DateSerial(Today.Year, Today.Month, 1)
            calDateTo.SelectedDate = Now

            lblClient.Visible = True
            lstClient.Visible = True

            lblItem.Visible = True
            lstItem.Visible = True

            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            'get the list of Main Client
            Dim objCommand As New SqlCommand("Ref_MainClients_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            lstMotherCompany.DataSource = objReader
            lstMotherCompany.DataValueField = "code"
            lstMotherCompany.DataTextField = "name"
            lstMotherCompany.DataBind()
            objReader.Close()

            'get the list of Clients
            objCommand = New SqlCommand("Ref_Clients_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstClient.DataSource = objReader
            lstClient.DataValueField = "name"
            lstClient.DataTextField = "name"
            lstClient.DataBind()
            lstClient.Enabled = True
            objReader.Close()

            'get the list of Brands
            objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            lstBrand.DataSource = objReader
            lstBrand.DataValueField = "code"
            lstBrand.DataTextField = "name"
            lstBrand.DataBind()
            lstBrand.Enabled = True
            objReader.Close()

            'get the list of Items
            objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstItem.DataSource = objReader
            lstItem.DataValueField = "code"
            lstItem.DataTextField = "name"
            lstItem.DataBind()
            lstItem.Enabled = True
            objReader.Close()

            objConnection.Close()
        End If
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Dim selected As Integer

        Dim MotherCompanyvalue As String
        MotherCompanyvalue = "0"
        For Each item As ListItem In lstMotherCompany.Items
            If item.Selected Then
                MotherCompanyvalue = MotherCompanyvalue + IIf(MotherCompanyvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim Clientvalue As String
        Clientvalue = "0"
        For Each item As ListItem In lstClient.Items
            If item.Selected Then
                Clientvalue = Clientvalue + IIf(Clientvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim Brandvalue As String
        Brandvalue = "0"
        For Each item As ListItem In lstBrand.Items
            If item.Selected Then
                Brandvalue = Brandvalue + IIf(Brandvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim ItemValue As String
        ItemValue = "0"
        For Each item As ListItem In lstItem.Items
            If item.Selected Then
                ItemValue = ItemValue + IIf(ItemValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        btnDownload.Visible = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand

        If lstSalesHistoryBy.SelectedValue = "DetPerAccountName" Then

            objCommand = New SqlCommand(strStoredProc, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerAccountName" Then

            objCommand = New SqlCommand(strStoredProc2, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerBusinessName" Then

            objCommand = New SqlCommand(strStoredProc3, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerBusinessName" Then

            objCommand = New SqlCommand(strStoredProc4, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerProduct" Then

            objCommand = New SqlCommand(strStoredProc5, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerProduct" Then

            objCommand = New SqlCommand(strStoredProc6, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerProductLot" Then

            objCommand = New SqlCommand(strStoredProc10, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandAccountName" Then

            objCommand = New SqlCommand(strStoredProc7, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", Brandvalue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandBusinessName" Then

            objCommand = New SqlCommand(strStoredProc8, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", Brandvalue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandProduct" Then

            objCommand = New SqlCommand(strStoredProc9, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", ItemValue)
            objCommand.Parameters.Add("@item", Brandvalue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        End If

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        dgList.DataSource = objReader
        dgList.DataBind()

        objReader.Close()
        objConnection.Close()

        dgList.Visible = True

        lblMessage.Text = "Record/s found :" & dgList.Items.Count

    End Sub
    Private Sub btnFullView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFullView.Click

        Dim selected As Integer

        Dim MotherCompanyvalue As String
        MotherCompanyvalue = "0"
        For Each item As ListItem In lstMotherCompany.Items
            If item.Selected Then
                MotherCompanyvalue = MotherCompanyvalue + IIf(MotherCompanyvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim Clientvalue As String
        Clientvalue = "0"
        For Each item As ListItem In lstClient.Items
            If item.Selected Then
                Clientvalue = Clientvalue + IIf(Clientvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim Brandvalue As String
        Brandvalue = "0"
        For Each item As ListItem In lstBrand.Items
            If item.Selected Then
                Brandvalue = Brandvalue + IIf(Brandvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim ItemValue As String
        ItemValue = "0"
        For Each item As ListItem In lstItem.Items
            If item.Selected Then
                ItemValue = ItemValue + IIf(ItemValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        SetEndPopup(strSubMenuFullView & "?motherclient=" & MotherCompanyvalue & _
                    " &item=" & ItemValue & _
                    " &title=" & lblTitle.Text)


    End Sub
    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        Dim selected As Integer

        Dim MotherCompanyvalue As String
        MotherCompanyvalue = "0"
        For Each item As ListItem In lstMotherCompany.Items
            If item.Selected Then
                MotherCompanyvalue = MotherCompanyvalue + IIf(MotherCompanyvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim Clientvalue As String
        Clientvalue = "0"
        For Each item As ListItem In lstClient.Items
            If item.Selected Then
                Clientvalue = Clientvalue + IIf(Clientvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim Brandvalue As String
        Brandvalue = "0"
        For Each item As ListItem In lstBrand.Items
            If item.Selected Then
                Brandvalue = Brandvalue + IIf(Brandvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim ItemValue As String
        ItemValue = "0"
        For Each item As ListItem In lstItem.Items
            If item.Selected Then
                ItemValue = ItemValue + IIf(ItemValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next
        dgList.SelectedIndex = -1

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand

        If lstSalesHistoryBy.SelectedValue = "DetPerAccountName" Then

            objCommand = New SqlCommand(strStoredProc, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerAccountName" Then

            objCommand = New SqlCommand(strStoredProc2, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerBusinessName" Then

            objCommand = New SqlCommand(strStoredProc3, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerBusinessName" Then

            objCommand = New SqlCommand(strStoredProc4, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerProduct" Then

            objCommand = New SqlCommand(strStoredProc5, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerProduct" Then

            objCommand = New SqlCommand(strStoredProc6, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerProductLot" Then

            objCommand = New SqlCommand(strStoredProc10, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandAccountName" Then

            objCommand = New SqlCommand(strStoredProc7, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", Clientvalue)
            objCommand.Parameters.Add("@item", Brandvalue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandBusinessName" Then

            objCommand = New SqlCommand(strStoredProc8, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", MotherCompanyvalue)
            objCommand.Parameters.Add("@item", Brandvalue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandProduct" Then

            objCommand = New SqlCommand(strStoredProc9, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@client", ItemValue)
            objCommand.Parameters.Add("@item", Brandvalue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

        End If

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        dgList.DataSource = objReader
        dgList.DataBind()

        dgList.Visible = True

        Try
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("content-disposition", "attachment;filename=" & strFileNameExcel)
            Response.Charset = ""
            Response.ContentType = "application/vnd.ms-excel"

            Dim sw As New System.IO.StringWriter
            Dim hw As New System.Web.UI.HtmlTextWriter(sw)
            dgList.RenderControl(hw)

            Dim style As String = "<style> .textmode { } </style>"
            Response.Write(style)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()

        Catch ex As Exception
            lblMessage.Text = "Error export Excel : " & ex.Message
        End Try

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub dgList_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgList.ItemCreated
        'handles for each item(ROW) created
        'the columns (ONLY) to display, each items must exist from the resultset

        If lstSalesHistoryBy.SelectedValue = "DetPerProductLot" Then
            Dim aColumns() As String = {"", _
                                        "client", _
                                        "si_no", _
                                        "si_date", _
                                        "qty", _
                                        "net_cost", _
                                        "hlight"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"Business Name", _
                                        "Item Desc", _
                                        "si_no", _
                                        "si_date", _
                                        "Qty", _
                                        "Amount", _
                                        ""}


            Dim aFooters() As String = {"", _
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
                                        "X8"}

            'the sort key expression to associate. pass "" to disable sorting
            Dim aSortKeys() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        ""}


            'sortkeys are control at the stored proc, not here
            Session("SortKey") = aSortKeys(0)

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
                                                dgList)
        Else
            Dim aColumns() As String = {"", _
                                        "sku", _
                                        "si_no", _
                                        "si_date", _
                                        "qty", _
                                        "net_cost", _
                                        "hlight"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"Business Name", _
                                        "Item Desc", _
                                        "si_no", _
                                        "si_date", _
                                        "Qty", _
                                        "Amount", _
                                        ""}


            Dim aFooters() As String = {"", _
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
                                        "X8"}

            'the sort key expression to associate. pass "" to disable sorting
            Dim aSortKeys() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        "", _
                                        ""}


            'sortkeys are control at the stored proc, not here
            Session("SortKey") = aSortKeys(0)

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
                                                dgList)
        End If

    End Sub

    Private Sub dgList_ItemDataBound1(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgList.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "','_blank')</SCRIPT>"
        RegisterStartupScript("startup", s)

    End Sub

    Private Sub lstSalesHistoryBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSalesHistoryBy.SelectedIndexChanged

        If lstSalesHistoryBy.SelectedValue = "DetPerAccountName" Or lstSalesHistoryBy.SelectedValue = "SumPerAccountName" Then
            lblClient.Visible = True
            lstClient.Visible = True

            lblItem.Visible = True
            lstItem.Visible = True

            lblMainClient.Visible = False
            lstMotherCompany.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerBusinessName" Or lstSalesHistoryBy.SelectedValue = "SumPerBusinessName" Then

            lblMainClient.Visible = True
            lstMotherCompany.Visible = True

            lblItem.Visible = True
            lstItem.Visible = True

            lblClient.Visible = False
            lstClient.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerBrand" Or lstSalesHistoryBy.SelectedValue = "SumPerBrand" Then

            lblBrand.Visible = True
            lstBrand.Visible = True

            lblItem.Visible = True
            lstItem.Visible = True

            lblClient.Visible = False
            lstClient.Visible = False
            lblMainClient.Visible = False
            lstMotherCompany.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "SumPerProduct" Then

            lblMainClient.Visible = True
            lstMotherCompany.Visible = True

            lblItem.Visible = True
            lstItem.Visible = True

            lblClient.Visible = False
            lstClient.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "DetPerProduct" Or lstSalesHistoryBy.SelectedValue = "DetPerProductLot" Then

            lblClient.Visible = True
            lstClient.Visible = True
            lblItem.Visible = True
            lstItem.Visible = True

            lblMainClient.Visible = False
            lstMotherCompany.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandAccountName" Then

            lblBrand.Visible = True
            lstBrand.Visible = True
            lblClient.Visible = True
            lstClient.Visible = True

            lblMainClient.Visible = False
            lstMotherCompany.Visible = False
            lblItem.Visible = False
            lstItem.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandBusinessName" Then

            lblBrand.Visible = True
            lstBrand.Visible = True
            lblMainClient.Visible = True
            lstMotherCompany.Visible = True

            lblClient.Visible = False
            lstClient.Visible = False
            lblItem.Visible = False
            lstItem.Visible = False

        ElseIf lstSalesHistoryBy.SelectedValue = "BrandProduct" Then

            lblBrand.Visible = True
            lstBrand.Visible = True
            lblItem.Visible = True
            lstItem.Visible = True

            lblClient.Visible = False
            lstClient.Visible = False
            lblMainClient.Visible = False
            lstMotherCompany.Visible = False

        End If
    End Sub
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("sys_reports")
    End Sub
End Class
