
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.TimeZone

Public Class inv_requisitions_list
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

    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList    
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary    
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
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid As System.Web.UI.WebControls.Panel
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtRFNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCustomer As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomerCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtSONo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLocation As System.Web.UI.WebControls.TextBox
    Protected WithEvents chbNeededDate As System.Web.UI.WebControls.CheckBox
    Protected WithEvents calRequestedDate As eWorld.UI.CalendarPopup
    Protected WithEvents calNeededDate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlBudgetHolder As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtParticulars As System.Web.UI.WebControls.TextBox
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid

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
    Public strSubMenuName As String = "inv_requisitions_list"
    Public strStoredProc As String = "inv_requisitions_list"
    Public strStoredProc2 As String = "inv_requisitions_listdtl_list"
    Public strStoredProcPageCount As String = "Inv_RequisitionsPageCount_Get"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "pr_code"
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
            'btnAddRecord.Text = "Add PO"

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
    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAddRecord.Click

        panelSuccess.Visible = False
        panelInfo.Visible = False

        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green
        ClearInputs()
        panelGrid.Visible = False
        btnSave.Text = "Add Items"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

    End Sub

    Private Sub ClearInputs()

        txtRFNo.Text = ""
        txtRFNo.Enabled = True

        lblCustomer.Text = ""
        lblCustomerCode.Text = ""

        txtSONo.Text = ""
        txtSONo.Enabled = True

        txtLocation.Text = ""
        txtLocation.Enabled = True

        calRequestedDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calRequestedDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calRequestedDate.Enabled = True

        calNeededDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calNeededDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calNeededDate.Enabled = True

        txtParticulars.Text = ""
        txtParticulars.Enabled = True

        SetFocus(txtSONo)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        ddlCompany.Items.Insert(0, "")
        ddlCompany.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_Employee_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlBudgetHolder.DataSource = objReader
        ddlBudgetHolder.DataValueField = "code"
        ddlBudgetHolder.DataTextField = "name"
        ddlBudgetHolder.DataBind()
        ddlBudgetHolder.Items.Insert(0, "")
        ddlBudgetHolder.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Requisitions_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@so_no", txtSONo.Text)
        objCommand.Parameters.Add("@customer", lblCustomerCode.Text)
        objCommand.Parameters.Add("@location", txtLocation.Text)
        objCommand.Parameters.Add("@rf_no", txtRFNo.Text)
        objCommand.Parameters.Add("@requested_date", calRequestedDate.SelectedDate)

        If chbNeededDate.Checked = True Then
            objCommand.Parameters.Add("@needed_date", calNeededDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@needed_date", "1/1/1999")
        End If

        objCommand.Parameters.Add("@budget_holder", ddlBudgetHolder.SelectedValue)
        objCommand.Parameters.Add("@particulars", txtParticulars.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

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
                                        "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow, _
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
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Requisitions_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@requested_date", calRequestedDate.SelectedDate)
        objCommand.Parameters.Add("@id", lblID.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateInput = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function

    Private Sub Cleanup_and_Rebind()
        panelForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False

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

                Response.Redirect("inv_requisitionsdtl_list?&id=" & Session("objNewID") & "&sys_table=" & strStoredProc)

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

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)


        If e.CommandName = "Open" Then

            Response.Redirect("inv_requisitionsdtl_list?&id=" & strKeyFieldValue & "&sys_table=" & strStoredProc)

        End If

    End Sub

    Private Sub txtSONo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSONo.TextChanged
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Inv_Requisitions_SONoGet", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@so_no", txtSONo.Text)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        If Trim(objReader("customer_code")) = "" Then
            txtSONo.Text = ""
        End If

        lblCustomer.Text = Trim(objReader("customer"))
        lblCustomerCode.Text = Trim(objReader("customer_code"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub chbNeededDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbNeededDate.CheckedChanged
        If chbNeededDate.Checked = True Then
            calNeededDate.Visible = True
        Else
            calNeededDate.Visible = False
        End If
    End Sub

    Private Sub ddlCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCompany.SelectedIndexChanged
        txtSONo.Visible = True

    End Sub
End Class

