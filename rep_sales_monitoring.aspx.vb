
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class rep_sales_monitoring
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
    Protected WithEvents lstCategory As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblCategory As System.Web.UI.WebControls.Label
    Protected WithEvents lstSubCategory As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblSubCategory As System.Web.UI.WebControls.Label
    Protected WithEvents lstItem As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblItem As System.Web.UI.WebControls.Label
    Protected WithEvents lstCustomer As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblCustomer As System.Web.UI.WebControls.Label
    Protected WithEvents lstSalesPerson As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblSalesPerson As System.Web.UI.WebControls.Label
    Protected WithEvents btnSummary As System.Web.UI.WebControls.Button
    Protected WithEvents btnDeduction As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lstYear As System.Web.UI.WebControls.ListBox

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
    Public strSubMenuName As String = "rep_sales_monitoring"
    Public Rep_SalesMonitoring_Client As String = "Rep_SalesMonitoring_Client"
    Public Rep_SalesMonitoring_SKU As String = "Rep_SalesMonitoring_SKU"
  
    Public strSubMenuFullView As String = "rep_salesmix_popup"

    Public strSPParam_BSDateFr As String = "@bs_date_from"
    Public strSPParam_BSDateTo As String = "@bs_date_to"
    Public strSPParam_User As String = "@Session_username"

    Public strFileNameExcel As String = "SalesMonitoringReport.xls"
    Public strFileNamePDF As String = "SalesMonitoringReport.pdf"

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
            objCommand = New SqlCommand("Ref_Clients_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstCustomer.DataSource = objReader
            lstCustomer.DataValueField = "code"
            lstCustomer.DataTextField = "name"
            lstCustomer.DataBind()
            lstCustomer.Enabled = True
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
            objCommand = New SqlCommand("ref_category_get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            lstCategory.DataSource = objReader
            lstCategory.DataValueField = "code"
            lstCategory.DataTextField = "name"
            lstCategory.DataBind()
            lstCategory.Enabled = True
            objReader.Close()

            'get the list of Items
            objCommand = New SqlCommand("ref_subcategory_get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            lstSubCategory.DataSource = objReader
            lstSubCategory.DataValueField = "code"
            lstSubCategory.DataTextField = "name"
            lstSubCategory.DataBind()
            lstSubCategory.Enabled = True
            objReader.Close()

            'get the list of Items
            objCommand = New SqlCommand("Ref_SalesPersons_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstSalesPerson.DataSource = objReader
            lstSalesPerson.DataValueField = "name"
            lstSalesPerson.DataTextField = "name"
            lstSalesPerson.DataBind()
            lstSalesPerson.Enabled = True
            objReader.Close()

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
        For Each item As ListItem In lstCategory.Items
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
        For Each item As ListItem In lstSubCategory.Items
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
        For Each item As ListItem In lstCustomer.Items
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
            Case "SalesMonitoringClient"
                objCommand = New SqlCommand(Rep_SalesMonitoring_Client, connection)
            Case "SalesMonitoringSKU"
                objCommand = New SqlCommand(Rep_SalesMonitoring_SKU, connection)            
        End Select

        If Not objCommand Is Nothing Then
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = 600
        End If

        Return objCommand
    End Function
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim ClientValue As String = GetSelectedValues(lstCategory)
        Dim BUValue As String = GetSelectedValues(lstCompany)
        Dim MainClientValue As String = GetSelectedValues(lstSubCategory)
        Dim ItemValue As String = GetSelectedValues(lstItem)
        Dim BrandValue As String = GetSelectedValues(lstCustomer)
        Dim SalesPersonValue As String = GetSelectedValues(lstSalesPerson)

        btnDownload.Visible = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As SqlCommand = GetCommandBySelectedValue(objConnection)

        If Not objCommand Is Nothing Then
            objCommand.Parameters.Add("@company", BUValue)
            objCommand.Parameters.Add("@customer", BrandValue)
            objCommand.Parameters.Add("@sales_person", SalesPersonValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@brand", BrandValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@year", lstYear.SelectedValue)
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
        For Each item As ListItem In lstItem.Items
            If item.Selected Then
                ClientValue = ClientValue + IIf(ClientValue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim MainClientValue As String
        MainClientValue = "0"
        For Each item As ListItem In lstSubCategory.Items
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

        Dim ClientValue As String = GetSelectedValues(lstCategory)
        Dim BUValue As String = GetSelectedValues(lstCompany)
        Dim MainClientValue As String = GetSelectedValues(lstSubCategory)
        Dim ItemValue As String = GetSelectedValues(lstItem)
        Dim BrandValue As String = GetSelectedValues(lstCustomer)
        Dim SalesPersonValue As String = GetSelectedValues(lstSalesPerson)

        dgList.SelectedIndex = -1

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As SqlCommand = GetCommandBySelectedValue(objConnection)

        If Not objCommand Is Nothing Then
            objCommand.Parameters.Add("@company", BUValue)
            objCommand.Parameters.Add("@customer", BrandValue)
            objCommand.Parameters.Add("@sales_person", SalesPersonValue)
            objCommand.Parameters.Add("@item", ItemValue)
            objCommand.Parameters.Add("@brand", BrandValue)
            objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
            objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
            objCommand.Parameters.Add("@year", lstYear.SelectedValue)
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

                ' Remove the style tag and add Excel-specific meta tags
                Response.Write("<html xmlns:x=""urn:schemas-microsoft-com:office:excel"">")
                Response.Write("<head><meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />")
                Response.Write("<meta http-equiv='content-disposition' content='attachment;filename=" & strFileNameExcel & "' />")
                Response.Write("<style>.textmode { }</style>")

                Response.Write("</head><body>")
                dgList.RenderControl(hw)

                'Dim style As String = "<style>" & _
                ' ".textmode { }" & _
                '"table {" & _
                '"    border-collapse: collapse;" & _
                '"    width: 100%;" & _
                '"}" & _
                '"th, td {" & _
                '"    border: 1px solid #dddddd;" & _
                '"    padding: 8px;" & _
                '"}" & _
                '"tr.table-light {" & _
                '"    text-align: center;" & _
                '"}" & _
                '"</style>"

                'Response.Write(style)
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

    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "','_blank')</SCRIPT>"
        RegisterStartupScript("startup", s)

    End Sub

    Private Sub lstSalesBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSalesBy.SelectedIndexChanged

        If lstSalesBy.SelectedValue = "SalesMonitoringClient" Then
            lblCustomer.Visible = True
            lstCustomer.Visible = True

            lblItem.Visible = False
            lstItem.Visible = False

            lblCompany.Visible = True
            lstCompany.Visible = True

            lblCategory.Visible = False
            lstCategory.Visible = False

            lblSubCategory.Visible = False
            lstSubCategory.Visible = False

            lblSalesPerson.Visible = False
            lstSalesPerson.Visible = False

        ElseIf lstSalesBy.SelectedValue = "SalesMonitoringSKU" Then
            lblCustomer.Visible = True
            lstCustomer.Visible = True

            lblItem.Visible = True
            lstItem.Visible = True

            lblCompany.Visible = True
            lstCompany.Visible = True

            lblCategory.Visible = False
            lstCategory.Visible = False

            lblSubCategory.Visible = False
            lstSubCategory.Visible = False

            lblSalesPerson.Visible = False
            lstSalesPerson.Visible = False

        End If
    End Sub
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("sys_reports")
    End Sub

    Private Sub dgList_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgList.ItemDataBound
        If e.Item.ItemType = ListItemType.Header Then
            ' Assuming you want to hide the first header column (index 0)
            e.Item.Cells(0).Visible = False
        ElseIf e.Item.ItemType = ListItemType.Item OrElse e.Item.ItemType = ListItemType.AlternatingItem Then
            ' Assuming you want to hide the first column in the body (index 0)
            e.Item.Cells(0).Visible = False
        End If

    End Sub

End Class
