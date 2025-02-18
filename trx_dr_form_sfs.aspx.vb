
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class trx_dr_form_sfs
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
    Protected WithEvents btnApprove As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents dgList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnPost As System.Web.UI.WebControls.Button
    Protected WithEvents btnForAcctgCancel As System.Web.UI.WebControls.Button
    Protected WithEvents btnForReplacement As System.Web.UI.WebControls.Button
    Protected WithEvents btnReturn As System.Web.UI.WebControls.Button
    Protected WithEvents btnARPost As System.Web.UI.WebControls.Button
    Protected WithEvents lblNotedBy As System.Web.UI.WebControls.Label
    Protected WithEvents btnUnpostCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents ddlCancelledReason As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblCancelledReason As System.Web.UI.WebControls.Label
    Protected WithEvents lblDetailedReason As System.Web.UI.WebControls.Label
    Protected WithEvents txtDetailedReason As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents btnBackToApprovalList As System.Web.UI.WebControls.Button
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
    Protected WithEvents lblNetPOAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetPayable As System.Web.UI.WebControls.Label
    Protected WithEvents lblInvoiceNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPrintedOn As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label


    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public strStoredProc As String = "Inv_PrintPreview_DRForm_SFS"
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
            btnApprove.Attributes("onclick") = "return confirm('Approve this Invoice?');"
            btnPost.Attributes("onclick") = "return confirm('Post this Invoice?');"
            btnCancel.Attributes("onclick") = "return confirm('Cancel this Invoice?');"
            btnForReplacement.Attributes("onclick") = "return confirm('Are you sure?');"
            btnForAcctgCancel.Attributes("onclick") = "return confirm('Do you want to Cancel this Invoice?');"
            btnARPost.Attributes("onclick") = "return confirm('Do you want to Post this Invoice for AR?');"
            btnUnpostCancel.Attributes("onclick") = "return confirm('Do you want to UnPost Cancellation of this Invoice?');"

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

            If objReader("so_no") <> "" And objReader("customer") <> "" Then

                'Sales Order - Customer
                lblVendorName.Text = objReader("client")
                lblVendorContact.Text = objReader("contact")
                lblVendorContactNo.Text = objReader("contact_no")
                lblVendorAddress.Text = objReader("c_address")

            End If

            If objReader("so_no") = "" And objReader("dest_st") <> "" Then

                If objReader("cus_st_name") <> "" Then

                    'Stock Transfer - Customer
                    lblVendorName.Text = objReader("dest_st")
                    lblVendorContact.Text = objReader("cust_st_contact")
                    lblVendorContactNo.Text = objReader("cus_st_contact_no")
                    lblVendorAddress.Text = objReader("cus_st_address")

                End If

                If objReader("whs_st_name") <> "" Then

                    'Stock Transfer - Warehouse
                    lblVendorName.Text = objReader("dest_st")
                    lblVendorContact.Text = objReader("whs_st_contact")
                    lblVendorContactNo.Text = objReader("whs_st_contact_no")
                    lblVendorAddress.Text = objReader("whs_st_address")

                End If

                If objReader("ven_st_name") <> "" Then

                    'Stock Transfer - Vendor
                    lblVendorName.Text = objReader("dest_st")
                    lblVendorContact.Text = objReader("ven_st_contact")
                    lblVendorContactNo.Text = objReader("ven_st_contact_no")
                    lblVendorAddress.Text = objReader("ven_st_address")

                End If

                If objReader("com_st_name") <> "" Then

                    'Stock Transfer - Company
                    lblVendorName.Text = objReader("dest_st")
                    lblVendorContact.Text = objReader("com_st_contact")
                    lblVendorContactNo.Text = objReader("com_st_contact_no")
                    lblVendorAddress.Text = objReader("com_st_address")

                End If

            End If

            If objReader("so_no") = "" And objReader("dest_sr") <> "" Then

                'Stock Return - Vendor
                lblVendorName.Text = objReader("dest_sr")
                lblVendorContact.Text = objReader("ven_sr_contact")
                lblVendorContactNo.Text = objReader("ven_sr_contact_no")
                lblVendorAddress.Text = objReader("ven_sr_address")

            End If

            lblCreatedBy.Text = objReader("created_by")
            lblApprovedBy.Text = objReader("approved_by")


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
        Dim aColumns() As String = {"rm_name", _
                                    "qty", _
                                    "rm_code", _                                    
                                    "expiry_date"}

        Dim aHeaders() As String = {"Item Desc", _
                                    "Qty", _
                                    "Lot#", _
                                    "Expiry"}

        Dim aFooters() As String = {"_COUNT_RECORD_", _
                                    "_SUM_", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    "N2", _
                                    "", _
                                    "DS"}

        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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
