
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class rep_stock_issuance
    Inherits System.Web.UI.Page
    Dim ds As DataSet = New DataSet

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub   
           
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
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents dgList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnGenerate As System.Web.UI.WebControls.Button
    Protected WithEvents btnDownload As System.Web.UI.WebControls.Button    
    Protected WithEvents btnFullView As System.Web.UI.WebControls.Button    
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label    
    Protected WithEvents calDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calDateTo As eWorld.UI.CalendarPopup   
    Protected WithEvents lstDDL1 As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstDDL2 As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstDDL3 As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstDDL4 As System.Web.UI.WebControls.ListBox
   
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
    Public strSubMenuName As String = "rep_stock_issuance"
    Public strStoredProc As String = "rep_stock_issuance"
    Public strSubMenuFullView As String = "rep_stock_issuance_popup"

    Public strSPParam_BSDateFr As String = "@bs_date_from"
    Public strSPParam_BSDateTo As String = "@bs_date_to"
    Public strSPParam_User As String = "@Session_username"

    Public strFileNameExcel As String = "StockIssuanceReport.xls"
    Public strFileNamePDF As String = "StockIssuanceReport.pdf"

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
            'calDateFrom.SelectedDate = DateSerial(Today.Year, Today.Month, 1)
            calDateFrom.SelectedDate = DateSerial(Today.Year, Today.Month, 1)
            calDateTo.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()

            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            'get the list of Categories
            Dim objCommand As New SqlCommand("Ref_Company_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
            objCommand.Parameters.Add("@Session_username", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            lstDDL2.DataSource = objReader
            lstDDL2.DataValueField = "code"
            lstDDL2.DataTextField = "name"
            lstDDL2.DataBind()
            lstDDL2.Enabled = True
            objReader.Close()

            'get the list of SubCategories
            objCommand = New SqlCommand("Ref_Clients_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstDDL3.DataSource = objReader
            lstDDL3.DataValueField = "code"
            lstDDL3.DataTextField = "name"
            lstDDL3.DataBind()
            lstDDL3.Enabled = True
            objReader.Close()

            'get the list of Items
            objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            lstDDL4.DataSource = objReader
            lstDDL4.DataValueField = "code"
            lstDDL4.DataTextField = "name"
            lstDDL4.DataBind()
            lstDDL4.Enabled = True
            objReader.Close()

            objConnection.Close()
        End If
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Dim selected As Integer

        Dim DDL1Value As String
        DDL1Value = "0"
        For Each item As ListItem In lstDDL1.Items
            If item.Selected Then
                DDL1Value = DDL1Value + IIf(DDL1Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL2Value As String
        DDL2Value = "0"
        For Each item As ListItem In lstDDL2.Items
            If item.Selected Then
                DDL2Value = DDL2Value + IIf(DDL2Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL3Value As String
        DDL3Value = "0"
        For Each item As ListItem In lstDDL3.Items
            If item.Selected Then
                DDL3Value = DDL3Value + IIf(DDL3Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL4Value As String
        DDL4Value = "0"
        For Each item As ListItem In lstDDL4.Items
            If item.Selected Then
                DDL4Value = DDL4Value + IIf(DDL4Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        btnDownload.Visible = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@status", DDL1Value)
        objCommand.Parameters.Add("@company", DDL2Value)
        objCommand.Parameters.Add("@customer", DDL3Value)
        objCommand.Parameters.Add("@item", DDL4Value)
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

        lblMessage.Text = "Record/s found :" & dgList.Items.Count

    End Sub
    Private Sub btnFullView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFullView.Click

        Dim selected As Integer

        Dim DDL1Value As String
        DDL1Value = "0"
        For Each item As ListItem In lstDDL1.Items
            If item.Selected Then
                DDL1Value = DDL1Value + IIf(DDL1Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL2Value As String
        DDL2Value = "0"
        For Each item As ListItem In lstDDL2.Items
            If item.Selected Then
                DDL2Value = DDL2Value + IIf(DDL2Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL3Value As String
        DDL3Value = "0"
        For Each item As ListItem In lstDDL3.Items
            If item.Selected Then
                DDL3Value = DDL3Value + IIf(DDL3Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL4Value As String
        DDL4Value = "0"
        For Each item As ListItem In lstDDL4.Items
            If item.Selected Then
                DDL4Value = DDL4Value + IIf(DDL4Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        SetEndPopup(strSubMenuFullView & "?status=" & DDL1Value & _
                    " &bu=" & DDL2Value & _
                    " &customer=" & DDL3Value & _
                    " &item=" & DDL4Value & _
                    " &title=" & lblTitle.Text)


    End Sub
    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        Dim selected As Integer

        Dim DDL1Value As String
        DDL1Value = "0"
        For Each item As ListItem In lstDDL1.Items
            If item.Selected Then
                DDL1Value = DDL1Value + IIf(DDL1Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL2Value As String
        DDL2Value = "0"
        For Each item As ListItem In lstDDL2.Items
            If item.Selected Then
                DDL2Value = DDL2Value + IIf(DDL2Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL3Value As String
        DDL3Value = "0"
        For Each item As ListItem In lstDDL3.Items
            If item.Selected Then
                DDL3Value = DDL3Value + IIf(DDL3Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        Dim DDL4Value As String
        DDL4Value = "0"
        For Each item As ListItem In lstDDL4.Items
            If item.Selected Then
                DDL4Value = DDL4Value + IIf(DDL4Value <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        dgList.SelectedIndex = -1

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@status", DDL1Value)
        objCommand.Parameters.Add("@company", DDL2Value)
        objCommand.Parameters.Add("@customer", DDL3Value)
        objCommand.Parameters.Add("@item", DDL4Value)
        objCommand.Parameters.Add("@dateFrom", calDateFrom.SelectedDate)
        objCommand.Parameters.Add("@dateTo", calDateTo.SelectedDate)
        objCommand.Parameters.Add("@Session_username", Session("username"))

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

        Dim aColumns() As String = {"id", _
                                    "company", _
                                    "status", _
                                    "dr_code", _
                                    "dr_no", _
                                    "dr_date", _
                                    "delivery_date", _
                                    "customer", _
                                    "item", _
                                    "qty", _
                                    "", _
                                    "dr_terms", _
                                    "invoice_no"}


        'the headers to diplay, instead of the default fieldname

        Dim aHeaders() As String = {"#", _
                                    "BU", _
                                    "Status", _
                                    "Ref#", _
                                    "DR No.", _
                                    "DR Date", _
                                    "Delivered", _
                                    "Account Name", _
                                    "Item Desc", _
                                    "Qty", _
                                    "Amount", _
                                    "Terms", _
                                    "SI No."}


        Dim aFooters() As String = {"", _
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
                                    "", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "DS", _
                                    "DS", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
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


    End Sub

    Private Sub dgList_ItemDataBound1(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgList.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "','_blank')</SCRIPT>"
        RegisterStartupScript("startup", s)

    End Sub
End Class
