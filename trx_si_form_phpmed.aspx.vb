
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class trx_si_form_phpmed
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents dgList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents divCreatedByESignDrag As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divApprovedByESignDrag As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divCompanyLogo As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblPrintedOn As System.Web.UI.WebControls.Label
    Protected WithEvents lblInvoiceNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblSONo As System.Web.UI.WebControls.Label
    Protected WithEvents lblDRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorName As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorTinNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblTerms As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblVAT As System.Web.UI.WebControls.Label
    Protected WithEvents lblVatableSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblVAT2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblVatableSales2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblVAT3 As System.Web.UI.WebControls.Label
    Protected WithEvents lblVatableSales3 As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblCreatedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label
    Protected WithEvents tblQty As System.Web.UI.WebControls.Table
    Protected WithEvents tblUOM As System.Web.UI.WebControls.Table
    Protected WithEvents tblItem As System.Web.UI.WebControls.Table
    Protected WithEvents tblCost As System.Web.UI.WebControls.Table
    Protected WithEvents tblNetCost As System.Web.UI.WebControls.Table
    Protected WithEvents lblPONo As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid As System.Web.UI.WebControls.DataGrid

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public strStoredProc As String = "Inv_PrintPreview_SIForm_PHPMED"
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList
    Public strDefaultSortKey As String = "rm_name"
    Public strKeyField As String = "rm_name"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then
            'is this module in the list of accessable menus?
            'If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            '    'go somewhere
            '    Response.Redirect("sys_errorpage")
            'End If         

            GridBind()

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            Dim objCommand As New SqlCommand("Inv_Issuance_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@code", Request("code"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            lblPrintedOn.Text = Date.UtcNow.AddHours(8)
            lblInvoiceNo.Text = objReader("invoice_no")
            lblSONo.Text = objReader("so_no")
            lblDRCode.Text = objReader("dr_code")
            lblPRDate.Text = objReader("so_date")
            lblVendorName.Text = objReader("client")
            lblPONo.Text = objReader("po_no")

            lblTerms.Text = objReader("terms")
            lblCreatedBy.Text = objReader("created_by")
            lblApprovedBy.Text = objReader("approved_by")

            lblNetAmount.Text = objReader("net_sales")

            lblVAT.Text = objReader("vat")
            lblVatableSales.Text = objReader("vatable_sales")

            lblVatableSales2.Text = objReader("vatable_sales")
            lblVAT2.Text = objReader("vat")

            lblNetSales.Text = objReader("net_sales")

            lblVatableSales3.Text = objReader("vatable_sales")
            lblVAT3.Text = objReader("vat")

            If objReader("isNonVat") = True Then
                lblVAT.Visible = False
                lblVatableSales.Visible = False

                lblVatableSales2.Visible = False
                lblVAT2.Visible = False

                lblVatableSales3.Visible = False
                lblVAT3.Visible = False

                lblNetAmount.Visible = False
            Else
                lblVAT.Visible = True
                lblVatableSales.Visible = True

                lblVatableSales2.Visible = True
                lblVAT2.Visible = True

                lblVatableSales3.Visible = True
                lblVAT3.Visible = True

                lblNetAmount.Visible = True
            End If

            If Convert.IsDBNull(objReader("address")) Then
                lblVendorAddress.Text = ""
            Else
                lblVendorAddress.Text = objReader("address")
            End If

            If objReader("isNonVat") = True Then
                lblVAT.Visible = False
                lblVatableSales.Visible = False

                lblVatableSales2.Visible = False
                lblVAT2.Visible = False

                lblVatableSales3.Visible = False
                lblVAT3.Visible = False
            Else
                lblVAT.Visible = True
                lblVatableSales.Visible = True

                lblVatableSales2.Visible = True
                lblVAT2.Visible = True

                lblVatableSales3.Visible = True
                lblVAT3.Visible = True
            End If

            Dim htmlImgCreatedBy As String = String.Empty
            Dim htmlImgApprovedBy As String = String.Empty

            htmlImgCreatedBy = "<img id='imgCreatedByESignResize' src=" & Trim(objReader("e_sign_path")) & ">"
            divCreatedByESignDrag.InnerHtml = htmlImgCreatedBy

            htmlImgApprovedBy = "<img id='imgApprovedByESignResize' src=" & Trim(objReader("approver_esign")) & ">"
            divApprovedByESignDrag.InnerHtml = htmlImgApprovedBy

            objReader.Close()

            objCommand = New SqlCommand("Sys_Company_LogoImagePath", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader

            objReader.Read()

            Dim htmlImgCompanyLogo As String = String.Empty

            htmlImgCompanyLogo = "<img class='company_logo' src=" & Trim(objReader("logo_path")) & ">"
            divCompanyLogo.InnerHtml = htmlImgCompanyLogo

            'objReader.Close()

            'objCommand = New SqlCommand("Rep_SIDatagrid_Fixus", objConnection)
            'objCommand.CommandType = CommandType.StoredProcedure
            'objCommand.Parameters.Add("@id", Request("id"))
            'objReader = objCommand.ExecuteReader

            'While objReader.Read

            '    Dim tblRowQty As New TableRow
            '    Dim tblCellQty As New TableCell

            '    Dim tblRowUOM As New TableRow
            '    Dim tblCellUOM As New TableCell

            '    Dim tblRowItem As New TableRow
            '    Dim tblCellItem As New TableCell

            '    Dim tblRowCost As New TableRow
            '    Dim tblCellCost As New TableCell

            '    Dim tblRowNetCost As New TableRow
            '    Dim tblCellNetCost As New TableCell

            '    tblCellQty.Text = Trim(objReader("qty"))
            '    tblCellUOM.Text = Trim(objReader("uom"))
            '    tblCellItem.Text = Trim(objReader("rm_name"))
            '    tblCellCost.Text = Trim(objReader("cost"))
            '    tblCellNetCost.Text = Trim(objReader("net_cost"))

            '    tblRowQty.Cells.Add(tblCellQty)
            '    tblQty.Rows.Add(tblRowQty)

            '    tblRowUOM.Cells.Add(tblCellUOM)
            '    tblUOM.Rows.Add(tblRowUOM)

            '    tblRowItem.Cells.Add(tblCellItem)
            '    tblItem.Rows.Add(tblRowItem)

            '    tblRowCost.Cells.Add(tblCellCost)
            '    tblCost.Rows.Add(tblRowCost)

            '    tblRowNetCost.Cells.Add(tblCellNetCost)
            '    tblNetCost.Rows.Add(tblRowNetCost)

            'End While

            objReader.Close()
            objConnection.Close()

        End If

    End Sub

    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub
    Sub GridBind()

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Rep_SIDatagrid_Fixus", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

    End Sub


End Class
