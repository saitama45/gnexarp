
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class trx_dr_form_fixus
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
    Protected WithEvents lblPRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorName As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorTinNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorTerms As System.Web.UI.WebControls.Label
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
    Protected WithEvents lblNote As System.Web.UI.WebControls.Label
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

    Public strStoredProc As String = "Inv_PrintPreview_SIForm_Fixus"
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
            lblPRDate.Text = Trim(objReader("dr_date"))
            lblVendorTinNo.Text = Trim(objReader("cus_st_tinno"))
            lblVendorTerms.Text = Trim(objReader("dr_terms"))
            lblNote.Text = Trim(objReader("note"))
            lblNetSales.Text = Trim(objReader("net_sales"))
            
            If objReader("so_no") <> "" And objReader("customer") <> "" Then

                'Sales Order - Customer
                lblVendorName.Text = objReader("client")               
                lblVendorAddress.Text = objReader("c_address")

            End If

            If objReader("so_no") = "" And objReader("dest_st") <> "" Then

                If objReader("cus_st_name") <> "" Then

                    'Stock Transfer - Customer
                    lblVendorName.Text = objReader("dest_st")                   
                    lblVendorAddress.Text = objReader("cus_st_address")

                End If

                If objReader("whs_st_name") <> "" Then

                    'Stock Transfer - Warehouse
                    lblVendorName.Text = objReader("dest_st")                  
                    lblVendorAddress.Text = objReader("whs_st_address")

                End If

                If objReader("ven_st_name") <> "" Then

                    'Stock Transfer - Vendor
                    lblVendorName.Text = objReader("dest_st")                   
                    lblVendorAddress.Text = objReader("ven_st_address")

                End If

                If objReader("com_st_name") <> "" Then

                    'Stock Transfer - Company
                    lblVendorName.Text = objReader("dest_st")                   
                    lblVendorAddress.Text = objReader("com_st_address")

                End If

            End If

            If objReader("so_no") = "" And objReader("dest_sr") <> "" Then

                'Stock Return - Vendor
                lblVendorName.Text = objReader("dest_sr")              
                lblVendorAddress.Text = objReader("ven_sr_address")

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
