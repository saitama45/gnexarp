
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class inv_dritems_printamort
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnLast As System.Web.UI.WebControls.Button
    Protected WithEvents BtnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrevious As System.Web.UI.WebControls.Button
    Protected WithEvents BtnFirst As System.Web.UI.WebControls.Button
    Protected WithEvents txtPageNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMorePage As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents divCreatedByESignDrag As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divApprovedByESignDrag As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divCompanyLogo As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblPrintedOn As System.Web.UI.WebControls.Label
    Protected WithEvents lblCreatedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendor As System.Web.UI.WebControls.Label
    Protected WithEvents lblAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientName As System.Web.UI.WebControls.Label
    Protected WithEvents lblFirstAmortDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblMonthlyAmort As System.Web.UI.WebControls.Label
    Protected WithEvents lblApplicationDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblLoanAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblMonthlyTerms As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public strStoredProc As String = "Inv_PrintPreview_LoanAmort"

    Public strSPParam_DateFr As String = "@dateFrom"
    Public strSPParam_DateTo As String = "@dateTo"

    Public strSPParam_Value1 As String = "@customer"
    Public strSPParam_Value2 As String = "@business_name"

    Public strFileNameExcel As String = "LoanAmortization.xls"
    Public strFileNamePDF As String = "LoanAmortization.pdf"

    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList
    Public strDefaultSortKey As String = "Account_Title"
    Public strKeyField As String = "Account_Title"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then
            'is this module in the list of accessable menus?
            'If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            '    'go somewhere
            '    Response.Redirect("sys_errorpage")
            'End If

            lblPrintedOn.Text = Date.UtcNow.AddHours(8)

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            Dim objCommand As New SqlCommand(strStoredProc, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@monthly_payment", Request("monthly_payment"))
            objCommand.Parameters.Add("@loan_terms", Request("loan_terms"))
            objCommand.Parameters.Add("@first_amort_date", Request("start_paydate"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            'objReader.Read() 'Uncomment to hide first row

            dgList.DataSource = objReader
            dgList.DataBind()

            objReader.Close()

            objCommand = New SqlCommand("Inv_Issuance_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@id", Request("id"))            

            objReader = objCommand.ExecuteReader
            objReader.Read()

            Dim monthlyPayment = Request("monthly_payment")
            Dim monthlyPaymentDecimal As Decimal = Convert.ToDecimal(monthlyPayment)
            Dim formattedMonthlyPayment As String = monthlyPaymentDecimal.ToString("#,##0.00")

            lblClientName.Text = Trim(objReader("client"))
            lblFirstAmortDate.Text = Request("start_paydate")   'Trim(objReader(""))
            lblMonthlyAmort.Text = formattedMonthlyPayment   'Trim(objReader(""))
            lblLoanAmount.Text = Request("loan_amount")         'Trim(objReader(""))
            lblMonthlyTerms.Text = Request("loan_terms")       'Trim(objReader(""))
            lblApplicationDate.Text = Trim(objReader("si_date"))

            objReader.Close()

            objCommand = New SqlCommand("Sys_Company_LogoImagePath", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@Session_username", Session("username"))

            objReader = objCommand.ExecuteReader
            objReader.Read()

            Dim htmlImgCompanyLogo As String = String.Empty

            htmlImgCompanyLogo = "<img height='60px' width='230px' src=" & Trim(objReader("logo_path")) & ">"
            divCompanyLogo.InnerHtml = htmlImgCompanyLogo

            objReader.Close()
            objConnection.Close()

            dgList.Visible = True           

        End If

    End Sub
   
    Private Sub dgList_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
Handles dgList.ItemCreated
        'handles for each item(ROW) created
        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"PERIOD", _
                                    "PAYDATE", _
                                    "EMI", _
                                    "PRINCIPAL", _
                                    "INTEREST", _
                                    "BALANCE"}


        'the headers to diplay, instead of the default fieldname

        Dim aHeaders() As String = {"PERIOD", _
                                    "PAYDATE", _
                                    "MONTHLY AMORTIZATION", _
                                    "PRINCIPAL", _
                                    "INTEREST", _
                                    "BALANCE"}


        Dim aFooters() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"C", _
                                    "C", _
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
                                     ""}

        'sortkeys are control at the stored proc, not here
        Session("SortKey") = aSortKeys(0)

        srx.Sys_Class.DataGrid_ItemCreated_v3(e, _
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

    Private Sub dgList_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
    Handles dgList.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub

    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub


End Class
