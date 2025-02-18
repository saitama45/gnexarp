
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class rep_issuance_status
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
    Protected WithEvents lblDashboard As System.Web.UI.WebControls.Label
    Protected WithEvents panelDashboard As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDashboard As System.Web.UI.WebControls.Table
    Protected WithEvents lblAR As System.Web.UI.WebControls.Label
    Protected WithEvents panelAR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblAR As System.Web.UI.WebControls.Table
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
    Protected WithEvents lstSubCategories As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstClient As System.Web.UI.WebControls.ListBox
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
    Protected WithEvents calCancelledDateFrom As eWorld.UI.CalendarPopup
    Protected WithEvents calCancelledDateTo As eWorld.UI.CalendarPopup
    Protected WithEvents panelCancelledDate As System.Web.UI.WebControls.Panel
    Protected WithEvents panelReportingDate As System.Web.UI.WebControls.Panel
    Protected WithEvents lstBillingType As System.Web.UI.WebControls.ListBox
    Protected WithEvents btnSummary As System.Web.UI.WebControls.Button
    Protected WithEvents btnDeduction As System.Web.UI.WebControls.Button


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
    Public strSubMenuName As String = "rep_issuance_status"
    Public strStoredProc As String = "rep_issuance_status"
    Public strSubMenuFullView As String = "rep_issuance_status_popup.aspx"

    Public strSPParam_BSDateFr As String = "@bs_date_from"
    Public strSPParam_BSDateTo As String = "@bs_date_to"
    Public strSPParam_User As String = "@Session_username"

    Public strFileNameExcel As String = "IssuanceStatusReport.xls"
    Public strFileNamePDF As String = "IssuanceStatusReport.pdf"

    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        Sys_Class.DisplaySideBarMenu(lblUser, _
                                    lblUserTab, _
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
                                    tblSetting)

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage.aspx")
        End If

        If Not Page.IsPostBack Then


            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            'get the list of BU
            Dim objCommand As New SqlCommand("Ref_Status_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
            objCommand.Parameters.Add("@id", 0)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            lstSubCategories.DataSource = objReader
            lstSubCategories.DataValueField = "code"
            lstSubCategories.DataTextField = "name"
            lstSubCategories.DataBind()
            objReader.Close()

            objConnection.Close()
        End If
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        btnDownload.Visible = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@status", lstSubCategories.SelectedValue)

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

        Dim BUvalue As String
        BUvalue = "0"
        For Each item As ListItem In lstSubCategories.Items
            If item.Selected Then
                BUvalue = BUvalue + IIf(BUvalue <> "", ",", "") + item.Value
                selected = selected + 1
            End If
        Next

        SetEndPopup(strSubMenuFullView & "?subcategory=" & BUvalue & _
                    " &title=" & lblTitle.Text)


    End Sub
    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        dgList.SelectedIndex = -1

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@status", lstSubCategories.SelectedValue)

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

        Dim aColumns() As String = {"status", _
                                    "qty"}


        'the headers to diplay, instead of the default fieldname

        Dim aHeaders() As String = {"Status", _
                                    "Qty"}


        Dim aFooters() As String = {"", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    ""}

        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
                                     ""}


        'sortkeys are control at the stored proc, not here
        Session("SortKey") = aSortKeys(0)

        rasa.Sys_Class.DataGrid_ItemCreated_v2(e, _
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
        rasa.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "','_blank')</SCRIPT>"
        RegisterStartupScript("startup", s)

    End Sub
End Class
