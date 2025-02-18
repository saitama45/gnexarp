
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class trx_rf_form
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
    Protected WithEvents lblRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblDateRequested As System.Web.UI.WebControls.Label
    Protected WithEvents lblDateNeeded As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountName As System.Web.UI.WebControls.Label
    Protected WithEvents lblLocation As System.Web.UI.WebControls.Label
    Protected WithEvents lblBudgetHolder As System.Web.UI.WebControls.Label
    Protected WithEvents lblRFNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblParticulars As System.Web.UI.WebControls.Label
    Protected WithEvents lblPrintedOn As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUAddress As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUContactNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUEmail As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public strStoredProc As String = "Inv_PrintPreview_RF"
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList
    Public strDefaultSortKey As String = "id"
    Public strKeyField As String = "id"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then
            'is this module in the list of accessable menus?
            'If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            '    'go somewhere
            '    Response.Redirect("sys_errorpage")
            'End If            

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            Dim objCommand As New SqlCommand("Inv_Requisitions_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
            objCommand.Parameters.Add("@id", Request("id"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            lblPrintedOn.Text = Date.UtcNow.AddHours(8)
            lblRefNo.Text = objReader("ref_no")
            lblDateRequested.Text = objReader("requested_date")
            lblDateNeeded.Text = objReader("needed_date_print")
            lblAccountName.Text = objReader("customer_name")
            lblLocation.Text = objReader("location")
            lblBudgetHolder.Text = objReader("budget_holder")
            lblRFNo.Text = objReader("rf_no")
            lblParticulars.Text = Trim(objReader("particulars"))
            
            Dim htmlImgCreatedBy As String = String.Empty
            Dim htmlImgApprovedBy As String = String.Empty

            htmlImgCreatedBy = "<img id='imgCreatedByESignResize' src=" & Trim(objReader("e_sign_path")) & ">"
            divCreatedByESignDrag.InnerHtml = htmlImgCreatedBy

            htmlImgApprovedBy = "<img id='imgApprovedByESignResize' src=" & Trim(objReader("approver_esign")) & ">"
            divApprovedByESignDrag.InnerHtml = htmlImgApprovedBy

            objReader.Close()

            objCommand = New SqlCommand("Sys_Company_RequisitionLogo", objConnection)
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
                                    "qty", _
                                    "cost", _
                                    "amount"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Item Desc", _
                                    "Qty", _
                                    "Cost", _
                                    "Amount"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_"}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "N2"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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
