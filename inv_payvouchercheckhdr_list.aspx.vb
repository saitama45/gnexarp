
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.TimeZone

Public Class inv_payvouchercheckhdr_list
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnPrev As System.Web.UI.WebControls.Button
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents txtCurrentPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageTotal As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalRecords As System.Web.UI.WebControls.Label
    Protected WithEvents panelPaginations As System.Web.UI.WebControls.Panel

    Protected WithEvents BtnFirst As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrevious As System.Web.UI.WebControls.Button
    Protected WithEvents btnLast As System.Web.UI.WebControls.Button
    Protected WithEvents txtMorePage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPageNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label

    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents hlViewFullHistory As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid As System.Web.UI.WebControls.Panel
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
    Protected WithEvents lblValidate As System.Web.UI.WebControls.Label
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
    Protected WithEvents lblDebit As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayableAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblVoucherNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayable As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayableShow As System.Web.UI.WebControls.Label
    Protected WithEvents txtCheckNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calCheckDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtCashVoucherNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calCashVoucherDate As eWorld.UI.CalendarPopup
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents chbCheckDate As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chbCashVoucherDate As System.Web.UI.WebControls.CheckBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'holds an array of invisible fields
    Public aDisableFields As New ArrayList
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList

    'START MODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    'the stored proc to call
    Public strSubMenuName As String = "inv_payvouchercheckhdr_list"
    Public strStoredProc As String = "inv_payvouchercheckhdr_list"
    Public strStoredProc2 As String = "inv_payvoucherdtl_list"
    Public strStoredProcPageCount As String = "Inv_PayVoucherCheckHDRPageCount_Get"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "dr_code"
    Public strKeyField As String = "id"

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


        If Not Page.IsPostBack Then
            GridBind()
            Refresh_PageTotal()
            Refresh_PagingButton()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            hlViewFullTrail.NavigateUrl = "trx_fullhistory?sys_table=" & strSubMenuName & "&mode=2&ID=0"
            btnCancel.Visible = False
            btnAddRecord.Visible = False

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddRecord.Visible = False
            End If

        End If

    End Sub
    Sub GridBind()

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count

    End Sub
    Private Sub Refresh_PageTotal()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProcPageCount, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblPageTotal.Text = Trim(objReader("page_total"))

        objReader.Close()
        objConnection.Close()

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub Refresh_PagingButton()
        Dim currentPage As Integer = Integer.Parse(txtCurrentPage.Text)
        Dim totalPages As Integer = Integer.Parse(lblPageTotal.Text)

        btnNext.Enabled = currentPage < totalPages
        btnPrev.Enabled = currentPage > 1

        If currentPage = totalPages Then
            btnNext.Enabled = False
        End If

        If currentPage = 1 Then
            btnPrev.Enabled = False
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Refresh_NextPage()
        Refresh_PageTotal()
        Refresh_PagingButton()
    End Sub
    Private Sub Refresh_NextPage()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text + 1)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text + 1

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Refresh_PrevPage()
        Refresh_PageTotal()
        Refresh_PagingButton()
    End Sub
    Private Sub Refresh_PrevPage()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text - 1)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text - 1

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub txtCurrentPage_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentPage.TextChanged
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@page_rows_max", 0)
        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        DataGrid.DataSource = objReader
        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text
        Refresh_PagingButton()
        Refresh_PageTotal()

        lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSearch.Click
        If txtSearch.Text = "" Then
            GridBind()
            Refresh_PageTotal()
            Refresh_PagingButton()
            panelPaginations.Visible = True
        Else
            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            'the stored procedure and parameters
            Dim objCommand As New SqlCommand(strStoredProc, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@page_rows_max", 0)
            objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
            objCommand.Parameters.Add("@pSearchKey", txtSearch.Text)
            objCommand.Parameters.Add("@Session_username", Session("username"))

            'open the connection and execute the reader 
            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            DataGrid.DataSource = objReader
            'the key field
            DataGrid.DataKeyField = strKeyField
            DataGrid.DataBind()

            objReader.Close()
            objConnection.Close()

            panelPaginations.Visible = False

            lblTotalRecords.Text = "Total Record/s: " & DataGrid.Items.Count
        End If

    End Sub
    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucher_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = Trim(objReader("status")) = "ON PROCESS"

        If Session("Group") = "GENADMIN" Then
            btnSave.Visible = True

            lblID.Text = Trim(objReader("id"))
            lblDebit.Text = Trim(objReader("debit"))
            lblVoucherNo.Text = Trim(objReader("voucher_no"))

            If Trim(objReader("payable_amount")) = 0 Then
                lblPayableShow.Text = Trim(objReader("credit_show"))
                lblPayable.Text = Trim(objReader("credit"))
            Else
                lblPayableShow.Text = Trim(objReader("payable_amount_show"))
                lblPayable.Text = Trim(objReader("payable_amount"))
            End If

            lblPayableAmount.Text = Trim(objReader("payable_amount"))

            txtCheckNo.Text = Trim(objReader("check_no"))
            txtCheckNo.Enabled = True

            If objReader("check_date") = "1/1/1900" Then
                chbCheckDate.Checked = False
                calCheckDate.Visible = False
                calCheckDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
                calCheckDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            Else
                chbCheckDate.Checked = True
                calCheckDate.Visible = True
                calCheckDate.SelectedDate = objReader("check_date")
                calCheckDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            End If
            calCheckDate.Enabled = True
            chbCheckDate.Enabled = True

            txtCashVoucherNo.Text = Trim(objReader("cash_voucher_no"))
            txtCashVoucherNo.Enabled = True

            If objReader("cash_voucher_date") = "1/1/1900" Then
                chbCashVoucherDate.Checked = False
                calCashVoucherDate.Visible = False
                calCashVoucherDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
                calCashVoucherDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            Else
                chbCashVoucherDate.Checked = True
                calCashVoucherDate.Visible = True
                calCashVoucherDate.SelectedDate = objReader("cash_voucher_date")
                calCashVoucherDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            End If
            calCashVoucherDate.Enabled = True
            chbCashVoucherDate.Enabled = True
        Else
            btnSave.Visible = bolChangeable

            lblID.Text = Trim(objReader("id"))
            lblDebit.Text = Trim(objReader("debit"))
            lblVoucherNo.Text = Trim(objReader("voucher_no"))

            If Trim(objReader("payable_amount")) = 0 Then
                lblPayableShow.Text = Trim(objReader("credit_show"))
                lblPayable.Text = Trim(objReader("credit"))
            Else
                lblPayableShow.Text = Trim(objReader("payable_amount_show"))
                lblPayable.Text = Trim(objReader("payable_amount"))
            End If

            lblPayableAmount.Text = Trim(objReader("payable_amount"))

            txtCheckNo.Text = Trim(objReader("check_no"))
            txtCheckNo.Enabled = bolChangeable

            If objReader("check_date") = "1/1/1900" Then
                chbCheckDate.Checked = False
                calCheckDate.Visible = False
                calCheckDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
                calCheckDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            Else
                chbCheckDate.Checked = True
                calCheckDate.Visible = True
                calCheckDate.SelectedDate = objReader("check_date")
                calCheckDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            End If
            calCheckDate.Enabled = bolChangeable
            chbCheckDate.Enabled = bolChangeable

            txtCashVoucherNo.Text = Trim(objReader("cash_voucher_no"))
            txtCashVoucherNo.Enabled = bolChangeable

            If objReader("cash_voucher_date") = "1/1/1900" Then
                chbCashVoucherDate.Checked = False
                calCashVoucherDate.Visible = False
                calCashVoucherDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
                calCashVoucherDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            Else
                chbCashVoucherDate.Checked = True
                calCashVoucherDate.Visible = True
                calCashVoucherDate.SelectedDate = objReader("cash_voucher_date")
                calCashVoucherDate.VisibleDate = Date.UtcNow.AddHours(8).ToShortDateString()
            End If
            calCashVoucherDate.Enabled = bolChangeable
            chbCashVoucherDate.Enabled = bolChangeable
        End If

        'this condition must only run once. initialize session(module) variables
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(DataGrid2, _
                                    strStoredProc2, _
                                    Session("SortKey"), _
                                    strKeyField, _
                                    BtnFirst, _
                                    btnPrevious, _
                                    btnNext, _
                                    btnLast, _
                                    txtPageNo, _
                                    txtMorePage, _
                                    ddlRecordsPerPage, _
                                    txtSearch, _
                                    lblPageRecordCount, _
                                    Trim(objReader("id")))

        objReader.Close()
        objConnection.Close()

        SetFocus(txtCheckNo)

    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherCheck_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@check_no", txtCheckNo.Text)

        If chbCheckDate.Checked = True Then
            objCommand.Parameters.Add("@check_date", calCheckDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@check_date", "1/1/1900")
        End If

        objCommand.Parameters.Add("@cash_voucher_no", txtCashVoucherNo.Text)

        If chbCashVoucherDate.Checked = True Then
            objCommand.Parameters.Add("@cash_voucher_date", calCashVoucherDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@cash_voucher_date", "1/1/1900")
        End If

        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        objConnection.Close()

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref# " + lblID.Text, _
                                        objNewID.Value, _
                                        0)

            Session("objNewID") = objNewID.Value

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveInput = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try
    End Function


    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnsave.click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objconnection As New SqlConnection(ConfigurationSettings.AppSettings("appconn"))

        'the stored procedure and parameters
        Dim objcommand As New SqlCommand("Inv_PayVoucherCheck_Validate", objconnection)
        objcommand.CommandType = CommandType.StoredProcedure
        objcommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objcommand.Parameters.Add("@id", lblID.Text)
        objcommand.Parameters.Add("@payable_amount", lblPayableAmount.Text)
        objcommand.Parameters.Add("@debit", lblDebit.Text)
        objcommand.Parameters.Add("@check_no", txtCheckNo.Text)

        If chbCheckDate.Checked = True Then
            objcommand.Parameters.Add("@check_date", calCheckDate.SelectedDate)
        Else
            objcommand.Parameters.Add("@check_date", "1/1/1900")
        End If

        objcommand.Parameters.Add("@cash_voucher_no", txtCashVoucherNo.Text)

        If chbCashVoucherDate.Checked = True Then
            objcommand.Parameters.Add("@cash_voucher_date", calCashVoucherDate.SelectedDate)
        Else
            objcommand.Parameters.Add("@cash_voucher_date", "1/1/1900")
        End If

        'open the connection and execute the reader 
        objconnection.Open()

        Dim objreader As SqlDataReader = objcommand.ExecuteReader

        If objreader.HasRows Then
            While objreader.Read
                ValidateInput = objreader("error_message")
            End While
        End If

        'close immediately the reader and connection object 
        objreader.Close()
        objconnection.Close()
    End Function

    Private Sub DataGrid2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub

    Private Sub Cleanup_and_Rebind()
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
        panelGrid.Visible = True

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSave.Click

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                lblValidate.Visible = False
                panelGrid.Visible = True

                'reset and rebind       
                DataGrid.SelectedIndex = -1
                GridBind()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateInput
        End If

    End Sub

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub DataGrid2_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "Account_Title", _
                                    "particulars", _
                                    "debit", _
                                    "credit", _
                                    "cost_center"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Account Title", _
                                    "Particulars", _
                                    "Debit", _
                                    "Credit", _
                                    "Cost Center"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    ""}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}


        'the item display formats. pass "" to display as is
        'Dim aFormats() As String = {"", "", ""}

        'the URL if you wish an item clickable, pass "" to disable.
        'Dim aURL() As String = {"", "", ""}

        'EndMODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

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
                                            strStoredProc2, _
                                            Session("Sys_AccessList"), _
                                            "", _
                                            DataGrid2)
    End Sub

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        If e.CommandName = "Open" Then

            'mark the selected item 
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Edit"
            lblMode.ForeColor = Color.Orange
            panelGrid.Visible = False

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)

            ReadyEdit() 'retrive and fill the text box for editing

        End If
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)


        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PayVoucherDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pv_id", strKeyFieldValue)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Session("company_code") = "FIXUS" Then

            SetEndPopup("trx_cv_print_fixus?code=" & strKeyFieldValue & _
                           " &id=" & strKeyFieldValue & _
                           " &formaction=" & "Print")

        Else
            SetEndPopup("trx_cv_print?code=" & strKeyFieldValue & _
                           " &id=" & strKeyFieldValue & _
                           " &formaction=" & "Print")

        End If

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub chbCheckDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbCheckDate.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucher_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = Trim(objReader("status")) = "ON PROCESS"

        If chbCheckDate.Checked = True Then
            calCheckDate.Visible = True

            If objReader("check_date") = "1/1/1900" Then
                calCheckDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
            Else
                calCheckDate.SelectedDate = objReader("check_date")
            End If

            calCheckDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
            calCheckDate.Enabled = bolChangeable
            chbCheckDate.Enabled = bolChangeable
        Else
            calCheckDate.Visible = False
            calCheckDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
            calCheckDate.Enabled = False
            chbCheckDate.Enabled = False
        End If

        If Session("Group") = "GENADMIN" Then
            calCheckDate.Enabled = True
            chbCheckDate.Enabled = True
        Else
            calCheckDate.Enabled = bolChangeable
            chbCheckDate.Enabled = bolChangeable
        End If

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub chbCashVoucherDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbCashVoucherDate.CheckedChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucher_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = Trim(objReader("status")) = "ON PROCESS"

        If chbCashVoucherDate.Checked = True Then
            calCashVoucherDate.Visible = True

            If objReader("cash_voucher_date") = "1/1/1900" Then
                calCashVoucherDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
            Else
                calCashVoucherDate.SelectedDate = objReader("cash_voucher_date")
            End If

            calCashVoucherDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
            calCashVoucherDate.Enabled = bolChangeable
            chbCashVoucherDate.Enabled = bolChangeable
        Else
            calCashVoucherDate.Visible = False
            calCashVoucherDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
            calCashVoucherDate.Enabled = False
            chbCashVoucherDate.Enabled = bolChangeable
        End If

        If Session("Group") = "GENADMIN" Then
            calCashVoucherDate.Enabled = True
            chbCashVoucherDate.Enabled = True
        Else
            calCashVoucherDate.Enabled = bolChangeable
            chbCashVoucherDate.Enabled = bolChangeable
        End If

        objReader.Close()
        objConnection.Close()
    End Sub


End Class

