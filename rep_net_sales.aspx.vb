
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class rep_net_sales
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
    Protected WithEvents lstCategories As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstClient As System.Web.UI.WebControls.ListBox
    Protected WithEvents calBSDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calBSDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents btnFullView As System.Web.UI.WebControls.Button
    Protected WithEvents lstMainClient As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstLSC As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstSalesBy As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents calReportingDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calReportingDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents rdoDates As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents panReportingDate As System.Web.UI.WebControls.Panel
    Protected WithEvents calDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents panelCancelledDate As System.Web.UI.WebControls.Panel
    Protected WithEvents panelReportingDate As System.Web.UI.WebControls.Panel
    Protected WithEvents lstCompany As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    Protected WithEvents lstBusinessName As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblBusinessName As System.Web.UI.WebControls.Label
    Protected WithEvents lstAccountName As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblAccountName As System.Web.UI.WebControls.Label
    Protected WithEvents lstItem As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblItem As System.Web.UI.WebControls.Label
    Protected WithEvents lstBrand As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblBrand As System.Web.UI.WebControls.Label
    Protected WithEvents lstSalesPerson As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblSalesPerson As System.Web.UI.WebControls.Label
    Protected WithEvents btnSummary As System.Web.UI.WebControls.Button
    Protected WithEvents btnDeduction As System.Web.UI.WebControls.Button
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
    Public strSubMenuName As String = "rep_net_sales"
    Public strStoredProc As String = "Rep_Net_Sales_AccountName_Detail"
    Public strStoredProc2 As String = "Rep_Net_Sales_AccountName_Summary"
    Public strStoredProc3 As String = "Rep_Net_Sales_BusinessName_Detail"
    Public strStoredProc4 As String = "Rep_Net_Sales_BusinessName_Summary"
    Public strStoredProc5 As String = "Rep_Net_Sales_Product_Detail"
    Public strStoredProc6 As String = "Rep_Net_Sales_Product_Summary"
    Public strStoredProc7 As String = "Rep_Net_Sales_Brand_Detail"
    Public strStoredProc8 As String = "Rep_Net_Sales_Brand_Summary"
    Public strStoredProc9 As String = "Rep_Net_Sales_SalesPerson"
    Public strStoredProc10 As String = "Rep_Net_Sales_SalesPerDay"
    Public strStoredProc11 As String = "Rep_Net_Sales_SalesPerDay_Detail"
    Public strSubMenuFullView As String = "rep_net_sales_popup"

    Public strSPParam_BSDateFr As String = "@bs_date_from"
    Public strSPParam_BSDateTo As String = "@bs_date_to"
    Public strSPParam_User As String = "@Session_username"

    Public strFileNameExcel As String = "NetSalesReport.xls"
    Public strFileNamePDF As String = "NetSalesReport.pdf"

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
            calDateFrom.SelectedDate = DateSerial(Today.Year, Today.Month, 1)
            calDateTo.SelectedDate = Now

            lblAccountName.Visible = True
            lstAccountName.Visible = True

            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            'get the list of Categories
            Dim objCommand As New SqlCommand("Ref_Items_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
            objCommand.Parameters.Add("@id", 0)
            objCommand.Parameters.Add("@Session_username", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            lstItem.DataSource = objReader
            lstItem.DataValueField = "code"
            lstItem.DataTextField = "name"
            lstItem.DataBind()
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

            'get the list of SubCategories
            objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstCompany.DataSource = objReader
            lstCompany.DataValueField = "code"
            lstCompany.DataTextField = "name"
            lstCompany.DataBind()
            lstCompany.Enabled = True
            objReader.Close()

            'get the list of SubCategories
            objCommand = New SqlCommand("Ref_MainClients_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstBusinessName.DataSource = objReader
            lstBusinessName.DataValueField = "name"
            lstBusinessName.DataTextField = "name"
            lstBusinessName.DataBind()
            lstBusinessName.Enabled = True
            objReader.Close()

            'get the list of Items
            objCommand = New SqlCommand("Ref_Clients_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstAccountName.DataSource = objReader
            lstAccountName.DataValueField = "code"
            lstAccountName.DataTextField = "name"
            lstAccountName.DataBind()
            lstAccountName.Enabled = True
            objReader.Close()

            'get the list of Items
            objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist2", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstSalesPerson.DataSource = objReader
            lstSalesPerson.DataValueField = "name"
            lstSalesPerson.DataTextField = "name"
            lstSalesPerson.DataBind()
            lstSalesPerson.Enabled = True
            objReader.Close()

            objConnection.Close()
        End If
    End Sub
    Private Function GetSelectedValues(ByVal lstBox As ListBox) As String
        Dim selectedValues As New ArrayList

        For Each item As ListItem In lstBox.Items
            If item.Selected Then
                selectedValues.Add(item.Value)
            End If
        Next

        Return String.Join(",", CType(selectedValues.ToArray(GetType(String)), String()))
    End Function


    Private Function GetSelectedValues2(ByVal lstBox As ListBox) As String
        Dim selected As Integer

        Dim ClientValue As String
        ClientValue = "0"
        For Each item As ListItem In lstAccountName.Items
            If item.Selected Then
                ClientValue = ClientValue + IIf(ClientValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim BUValue As String
        BUValue = "0"
        For Each item As ListItem In lstCompany.Items
            If item.Selected Then
                BUValue = BUValue + IIf(BUValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim MainClientValue As String
        MainClientValue = "0"
        For Each item As ListItem In lstBusinessName.Items
            If item.Selected Then
                MainClientValue = MainClientValue + IIf(MainClientValue <> "", ",", "") + item.Value
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

        Dim BrandValue As String
        BrandValue = "0"
        For Each item As ListItem In lstBrand.Items
            If item.Selected Then
                BrandValue = BrandValue + IIf(BrandValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim SalesPersonValue As String
        SalesPersonValue = "0"
        For Each item As ListItem In lstSalesPerson.Items
            If item.Selected Then
                SalesPersonValue = SalesPersonValue + IIf(SalesPersonValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next
    End Function
    Private Function GetCommandBySelectedValue(ByVal connection As SqlConnection) As SqlCommand

        Dim objCommand As SqlCommand = Nothing

        Select Case lstSalesBy.SelectedValue
            Case "DetPerAccountName"
                objCommand = New SqlCommand(strStoredProc, connection)
            Case "SumPerAccountName"
                objCommand = New SqlCommand(strStoredProc2, connection)
            Case "DetPerBusinessName"
                objCommand = New SqlCommand(strStoredProc3, connection)
            Case "SumPerBusinessName"
                objCommand = New SqlCommand(strStoredProc4, connection)
            Case "DetPerProduct"
                objCommand = New SqlCommand(strStoredProc5, connection)
            Case "SumPerProduct"
                objCommand = New SqlCommand(strStoredProc6, connection)
            Case "DetPerBrand"
                objCommand = New SqlCommand(strStoredProc7, connection)
            Case "SumPerBrand"
                objCommand = New SqlCommand(strStoredProc8, connection)
            Case "SalesPerson"
                objCommand = New SqlCommand(strStoredProc9, connection)
            Case "SalesPerDay"
                objCommand = New SqlCommand(strStoredProc10, connection)
            Case "SalesPerDayDet"
                objCommand = New SqlCommand(strStoredProc11, connection)
        End Select

        If Not objCommand Is Nothing Then
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = 600
        End If

        Return objCommand
    End Function
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim ClientValue As String = GetSelectedValues(lstAccountName)
        Dim BUValue As String = GetSelectedValues(lstCompany)
        Dim MainClientValue As String = GetSelectedValues(lstBusinessName)
        Dim ItemValue As String = GetSelectedValues(lstItem)
        Dim BrandValue As String = GetSelectedValues(lstBrand)
        Dim SalesPersonValue As String = GetSelectedValues(lstSalesPerson)

        btnDownload.Visible = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As SqlCommand = GetCommandBySelectedValue(objConnection)

        If Not objCommand Is Nothing Then
            objCommand.Parameters.Add("@company", BUValue)
            objCommand.Parameters.Add("@customer", ClientValue)
            objCommand.Parameters.Add("@sales_person", SalesPersonValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@brand", BrandValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            dgList.DataSource = objReader
            dgList.DataBind()

            objReader.Close()
            objConnection.Close()

            dgList.Visible = True

            lblMessage.Text = "Record/s found: " & dgList.Items.Count
        End If

    End Sub
    Private Sub btnFullView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFullView.Click

        Dim selected As Integer

        Dim ClientValue As String
        ClientValue = "0"
        For Each item As ListItem In lstAccountName.Items
            If item.Selected Then
                ClientValue = ClientValue + IIf(ClientValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim MainClientValue As String
        MainClientValue = "0"
        For Each item As ListItem In lstBusinessName.Items
            If item.Selected Then
                MainClientValue = MainClientValue + IIf(MainClientValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        SetEndPopup(strSubMenuFullView & "?accountname=" & ClientValue & _
                    " &businessname=" & MainClientValue & _
                    " &title=" & lblTitle.Text)


    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        Dim ClientValue As String = GetSelectedValues(lstAccountName)
        Dim BUValue As String = GetSelectedValues(lstCompany)
        Dim MainClientValue As String = GetSelectedValues(lstBusinessName)
        Dim ItemValue As String = GetSelectedValues(lstItem)
        Dim BrandValue As String = GetSelectedValues(lstBrand)
        Dim SalesPersonValue As String = GetSelectedValues(lstSalesPerson)

        dgList.SelectedIndex = -1

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As SqlCommand = GetCommandBySelectedValue(objConnection)

        If Not objCommand Is Nothing Then
            objCommand.Parameters.Add("@company", BUValue)
            objCommand.Parameters.Add("@customer", ClientValue)
            objCommand.Parameters.Add("@sales_person", SalesPersonValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            objConnection.Open()

            ' Code to download the data
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
        End If

    End Sub
    Private Sub dgList_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgList.ItemCreated
        'handles for each item(ROW) created
        'the columns (ONLY) to display, each items must exist from the resultset

        If lstSalesBy.SelectedValue = "DetPerProduct" Or lstSalesBy.SelectedValue = "SumPerProduct" _
         Then

            Dim aColumns() As String = {"id", _
                                        "client", _
                                        "invoice_no", _
                                        "si_date", _
                                        "qty", _
                                        "net_sales", _
                                        "cogs", _
                                        "profit"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "Item Desc", _
                                        "SI #", _
                                        "SI Date", _
                                        "Qty", _
                                        "Net Sales", _
                                        "COGS", _
                                        "Profit"}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_"}

            Dim aFormats() As String = {"", _
                                        "", _
                                        "", _
                                        "DS", _
                                        "N2", _
                                        "N2", _
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
                                                strStoredProc5, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                dgList)

        ElseIf lstSalesBy.SelectedValue = "DetPerBrand" Or lstSalesBy.SelectedValue = "SumPerBrand" Then

            Dim aColumns() As String = {"id", _
                                        "client", _
                                        "invoice_no", _
                                        "si_date", _
                                        "qty", _
                                        "net_sales", _
                                        "cogs", _
                                        "profit"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "Brand", _
                                        "SI #", _
                                        "SI Date", _
                                        "Qty", _
                                        "Net Sales", _
                                        "COGS", _
                                        "Profit"}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_"}

            Dim aFormats() As String = {"", _
                                        "", _
                                        "", _
                                        "DS", _
                                        "N2", _
                                        "N2", _
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
                                                strStoredProc5, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                dgList)

        ElseIf lstSalesBy.SelectedValue = "SalesPerDay" Then
            Dim aColumns() As String = {"id", _
                                        "customer", _
                                        "si_date", _
                                        "vatable_sales", _
                                        "vat", _
                                        "net_amount", _
                                        "net_sales", _
                                        "paid_amount", _
                                        "owing", _
                                        "cogs", _
                                        "profit"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "Account Name", _
                                        "SI Date", _
                                        "Vatable Sales", _
                                        "Vat", _
                                        "Net Amount", _
                                        "Gross Sales", _
                                        "Payment", _
                                        "Balance", _
                                        "COGS", _
                                        "Net Profit"}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_"}

            Dim aFormats() As String = {"", _
                                        "", _
                                        "DS", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
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
                                                strStoredProc9, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                dgList)

        ElseIf lstSalesBy.SelectedValue = "SalesPerDayDet" Then
            Dim aColumns() As String = {"id", _
                                        "si_date", _
                                        "invoice_no", _
                                        "customer", _
                                        "vatable_sales", _
                                        "vat", _
                                        "net_amount", _
                                        "discount", _
                                        "net_sales", _
                                        "cogs", _
                                        "profit"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "SI Date", _
                                        "SI No.", _
                                        "Account Name", _
                                        "Vatable Sales", _
                                        "Vat", _
                                        "Net Amount", _
                                        "Discount", _
                                        "Gross Sales", _
                                        "COGS", _
                                        "Net Profit"}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_"}

            Dim aFormats() As String = {"", _
                                        "DS", _
                                        "", _
                                        "", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
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
                                                strStoredProc9, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                dgList)

        ElseIf lstSalesBy.SelectedValue = "SalesPerson" Then
            Dim aColumns() As String = {"id", _
                                        "sales_person", _
                                        "client", _
                                        "net_sales", _
                                        "item", _
                                        "si_date", _
                                        "hlight"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "Sales Person", _
                                        "Account Name", _
                                        "Net Sales", _
                                        "Item Desc", _
                                        "SI Date", _
                                        ""}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "", _
                                        "", _
                                        ""}

            Dim aFormats() As String = {"", _
                                        "", _
                                        "", _
                                        "N2", _
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
                                                strStoredProc9, _
                                                Session("Sys_AccessList"), _
                                                "", _
                                                dgList)

        ElseIf lstSalesBy.SelectedValue = "DetPerBusinessName" Or lstSalesBy.SelectedValue = "SumPerBusinessName" Then

            Dim aColumns() As String = {"id", _
                                        "client", _
                                        "invoice_no", _
                                        "si_date", _
                                        "vatable_sales", _
                                        "vat", _
                                        "net_amount", _
                                        "discount", _
                                        "net_sales", _
                                        "cogs", _
                                        "profit"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "Business Name", _
                                        "SI #", _
                                        "SI Date", _
                                        "Vatable Sales", _
                                        "VAT", _
                                        "Net Amount", _
                                        "Discount", _
                                        "Net Sales", _
                                        "COGS", _
                                        "Profit"}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_"}

            Dim aFormats() As String = {"", _
                                        "", _
                                        "", _
                                        "DS", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "", _
                                        "N2", _
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
            Dim aColumns() As String = {"id", _
                                        "client", _
                                        "invoice_no", _
                                        "si_date", _
                                        "vatable_sales", _
                                        "vat", _
                                        "net_amount", _
                                        "discount", _
                                        "net_sales", _
                                        "cogs", _
                                        "profit"}


            'the headers to diplay, instead of the default fieldname

            Dim aHeaders() As String = {"#", _
                                        "Account Name", _
                                        "SI #", _
                                        "SI Date", _
                                        "Vatable Sales", _
                                        "VAT", _
                                        "Net Amount", _
                                        "Discount", _
                                        "Net Sales", _
                                        "COGS", _
                                        "Profit"}


            Dim aFooters() As String = {"", _
                                        "", _
                                        "", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "", _
                                        "_SUM_", _
                                        "_SUM_", _
                                        "_SUM_"}

            Dim aFormats() As String = {"", _
                                        "", _
                                        "", _
                                        "DS", _
                                        "N2", _
                                        "N2", _
                                        "N2", _
                                        "", _
                                        "N2", _
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

    Private Sub lstSalesBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSalesBy.SelectedIndexChanged

        If lstSalesBy.SelectedValue = "DetPerAccountName" Or lstSalesBy.SelectedValue = "SumPerAccountName" Or lstSalesBy.SelectedValue = "SalesPerDay" Then
            lblAccountName.Visible = True
            lstAccountName.Visible = True

            lblBusinessName.Visible = False
            lstBusinessName.Visible = False
            lblItem.Visible = False
            lstItem.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False
            lblSalesPerson.Visible = False
            lstSalesPerson.Visible = False

        ElseIf lstSalesBy.SelectedValue = "DetPerBusinessName" Or lstSalesBy.SelectedValue = "SumPerBusinessName" Then
            lblBusinessName.Visible = True
            lstBusinessName.Visible = True

            lblAccountName.Visible = False
            lstAccountName.Visible = False
            lblItem.Visible = False
            lstItem.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False
            lblSalesPerson.Visible = False
            lstSalesPerson.Visible = False

        ElseIf lstSalesBy.SelectedValue = "DetPerProduct" Or lstSalesBy.SelectedValue = "SumPerProduct" Then
            lblItem.Visible = True
            lstItem.Visible = True

            lblBusinessName.Visible = False
            lstBusinessName.Visible = False
            lblAccountName.Visible = False
            lstAccountName.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False
            lblSalesPerson.Visible = False
            lstSalesPerson.Visible = False

        ElseIf lstSalesBy.SelectedValue = "DetPerBrand" Or lstSalesBy.SelectedValue = "SumPerBrand" Then
            lblBrand.Visible = True
            lstBrand.Visible = True

            lblBusinessName.Visible = False
            lstBusinessName.Visible = False
            lblAccountName.Visible = False
            lstAccountName.Visible = False
            lblItem.Visible = False
            lstItem.Visible = False
            lblSalesPerson.Visible = False
            lstSalesPerson.Visible = False

        ElseIf lstSalesBy.SelectedValue = "SalesPerson" Then

            lblSalesPerson.Visible = True
            lstSalesPerson.Visible = True
            lblAccountName.Visible = True
            lstAccountName.Visible = True

            lblCompany.Visible = False
            lstCompany.Visible = False
            lblBusinessName.Visible = False
            lstBusinessName.Visible = False
            lblItem.Visible = False
            lstItem.Visible = False
            lblBrand.Visible = False
            lstBrand.Visible = False

        End If
    End Sub
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("sys_reports")
    End Sub
End Class
