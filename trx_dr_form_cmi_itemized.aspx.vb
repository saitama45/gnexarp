
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class trx_dr_form_cmi_itemized
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
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
    Protected WithEvents lblPRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorName As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblEmail As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorContact As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblNote As System.Web.UI.WebControls.Label
    Protected WithEvents lblTerms As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscount As System.Web.UI.WebControls.Label
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblGTotalCost As System.Web.UI.WebControls.Label
    Protected WithEvents tblRMName As System.Web.UI.WebControls.Table
    Protected WithEvents tblUOM As System.Web.UI.WebControls.Table
    Protected WithEvents tblQty As System.Web.UI.WebControls.Table
    Protected WithEvents tblCost As System.Web.UI.WebControls.Table
    Protected WithEvents tblTotalCost As System.Web.UI.WebControls.Table
    Protected WithEvents lblCreatedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscountedAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblCurrency As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblPrintedOn As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label
    Protected WithEvents panelPHPNetAmount As System.Web.UI.WebControls.Panel
    Protected WithEvents lblPHPNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUEmail As System.Web.UI.WebControls.Label
    Protected WithEvents lblBU As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUShippingAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUName As System.Web.UI.WebControls.Label
    Protected WithEvents lblVAT As System.Web.UI.WebControls.Label
    Protected WithEvents lblVATLabel As System.Web.UI.WebControls.Label
    Protected WithEvents lblInvoiceNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblVatableSales As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetSales As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public strStoredProc As String = "Inv_PrintPreview_DRForm_COSMOMED"
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList
    Public strDefaultSortKey As String = "main_item"
    Public strKeyField As String = "main_item"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then
            'is this module in the list of accessable menus?
            'If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            '    'go somewhere
            '    Response.Redirect("sys_errorpage")
            'End If            

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
            lblPRCode.Text = objReader("dr_code")
            lblPRDate.Text = objReader("dr_date")
            lblVendorName.Text = objReader("client")
            lblVendorCode.Text = objReader("client_code")
            lblTerms.Text = objReader("terms")
            lblCreatedBy.Text = objReader("created_by")
            lblApprovedBy.Text = objReader("approved_by")

            lblDiscountedAmount.Text = Trim(objReader("less"))

            lblVatableSales.Text = objReader("vatable_sales")

            If objReader("isNonVat") = True Then
                lblVATLabel.Visible = False
                lblVAT.Visible = False

            Else
                lblVATLabel.Visible = True
                lblVAT.Visible = True
            End If
            lblVAT.Text = objReader("vat")

            lblNetAmount.Text = objReader("net_amount")
            lblDiscount.Text = objReader("discount_edit")
            lblNetSales.Text = objReader("net_sales")

            If Convert.IsDBNull(objReader("address")) Then
                lblVendorAddress.Text = ""
            Else
                lblVendorAddress.Text = objReader("address")
            End If

            If Convert.IsDBNull(objReader("email")) Then
                lblEmail.Text = ""
            Else
                lblEmail.Text = objReader("email")
            End If

            If Convert.IsDBNull(objReader("contact")) Then
                lblVendorContact.Text = ""
            Else
                lblVendorContact.Text = objReader("contact")
            End If

            If Convert.IsDBNull(objReader("contact_no")) Then
                lblVendorContactNo.Text = ""
            Else
                lblVendorContactNo.Text = objReader("contact_no")
            End If

            If Convert.IsDBNull(objReader("address")) Then
                lblVendorAddress.Text = ""
            Else
                lblVendorAddress.Text = objReader("address")
            End If

            If Convert.IsDBNull(objReader("note")) Then
                lblNote.Text = ""
            Else
                lblNote.Text = objReader("note")
            End If


            Dim htmlImgCreatedBy As String = String.Empty
            Dim htmlImgApprovedBy As String = String.Empty

            htmlImgCreatedBy = "<img id='imgCreatedByESignResize' src=" & Trim(objReader("e_sign_path")) & ">"
            divCreatedByESignDrag.InnerHtml = htmlImgCreatedBy

            htmlImgApprovedBy = "<img id='imgApprovedByESignResize' src=" & Trim(objReader("approver_esign")) & ">"
            divApprovedByESignDrag.InnerHtml = htmlImgApprovedBy

            objReader.Close()

            objCommand = New SqlCommand("Sys_Company_IssuanceLogo", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader

            objReader.Read()

            Dim htmlImgCompanyLogo As String = String.Empty

            htmlImgCompanyLogo = "<img class='company_logo' src=" & Trim(objReader("logo_path")) & ">"
            divCompanyLogo.InnerHtml = htmlImgCompanyLogo

            objReader.Close()

            objCommand = New SqlCommand("Sys_Company_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", Request("id"))
            objReader = objCommand.ExecuteReader

            objReader.Read()

            lblBUAddress.Text = Trim(objReader("address"))
            lblBUContactNo.Text = Trim(objReader("contact_no"))
            lblBUEmail.Text = Trim(objReader("email"))

            objReader.Close()
            objConnection.Close()
            GridBind()
            dgList.Visible = True

        End If

    End Sub
    Sub GridBind()
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(dgList, _
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
    Private Sub dgList_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
Handles dgList.ItemCreated
        'handles for each item(ROW) created
        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "item_desc", _
                                    "brand", _
                                    "qty", _
                                    "serial", _
                                    "notes", _
                                    "", _
                                    "", _
                                    "hlight"}

        Dim aHeaders() As String = {"Part Number", _
                                    "DESCRIPTION", _
                                    "BRAND", _
                                    "Qty", _
                                    "SN#", _
                                    "REMARKS", _
                                    "Unit Price", _
                                    "Total Price", _
                                    ""}

        Dim aFooters() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
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
