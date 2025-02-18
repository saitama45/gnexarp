
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_paymentdtl_list
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtMorePage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPageNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRecordsPerPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageRecordCount As System.Web.UI.WebControls.Label
    Protected WithEvents BtnFirst As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrevious As System.Web.UI.WebControls.Button
    Protected WithEvents BtnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnLast As System.Web.UI.WebControls.Button
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnX As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents hlViewFullHistory As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGrid As System.Web.UI.WebControls.Panel
    Protected WithEvents panelBank As System.Web.UI.WebControls.Panel
    Protected WithEvents panelCard As System.Web.UI.WebControls.Panel
    Protected WithEvents panelCheck As System.Web.UI.WebControls.Panel
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
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnPrint As System.Web.UI.WebControls.Button
    Protected WithEvents btnPrintSO As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents calRemittedDate As eWorld.UI.CalendarPopup
    Protected WithEvents calORDate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlPayType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtPaidAmount As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtORNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRemarks As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlBank As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtCardNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtApprovalNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBankCharge As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCheckNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calCheckDate As eWorld.UI.CalendarPopup
    Protected WithEvents calDepositedCheckDate As eWorld.UI.CalendarPopup
    Protected WithEvents lblInvoiceNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblSIDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomer As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomerCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblInvoiceAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblPaidAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblBalance As System.Web.UI.WebControls.Label
    Protected WithEvents lblSINo As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccountName As System.Web.UI.WebControls.Label
    Protected WithEvents lblOwing As System.Web.UI.WebControls.Label
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblISSID As System.Web.UI.WebControls.Label
    Protected WithEvents ddlLoanPayDate As System.Web.UI.WebControls.DropDownList

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
    Public strStoredProc As String = "inv_paymentdtl_list"
    Public strSubMenuName As String = "inv_paymentdtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

   Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblBalance.Text <> "0.00" Then
            txtFormAction.Text = "Add"
            lblMode.ForeColor = Color.Green
            ClearInputs()
            'panelGrid.Visible = False
            btnsave.text = "Add"

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)

            ReadyAdd()
        Else
            If Session("group") = "ADMIN" Then
                txtFormAction.Text = "Add"
                lblMode.ForeColor = Color.Green
                ClearInputs()
                'panelGrid.Visible = False
                btnsave.text = "Add"

                'show the Form panel
                Sys_Class.ReadyForm(panelForm, _
                                        panelSuccess, _
                                        panelInfo, _
                                        lblMessage, _
                                        ValidationSummary1, _
                                        lblMode, _
                                        txtFormAction)

                ReadyAdd()
            Else
                btnAddRecord.Visible = False
            End If
        End If


    End Sub
    Private Sub ReadyAdd()

        ClearInputs()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlBank.DataSource = objReader
        ddlBank.DataValueField = "code"
        ddlBank.DataTextField = "name"
        ddlBank.DataBind()
        ddlBank.Items.Insert(0, "Select Bank")
        ddlBank.SelectedIndex = Nothing
        ddlBank.Enabled = True

        objReader.Close()

        objCommand = New SqlCommand("Ref_LoanAmortPayDate_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", Request("id"))

        objReader = objCommand.ExecuteReader
        ddlLoanPayDate.DataSource = objReader
        ddlLoanPayDate.DataValueField = "id"
        ddlLoanPayDate.DataTextField = "code"
        ddlLoanPayDate.DataBind()
        ddlLoanPayDate.Items.Insert(0, "")
        ddlLoanPayDate.SelectedIndex = Nothing
        ddlLoanPayDate.Enabled = True

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub ReadyEdit()        

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strBank As String = objReader("bank_code")
        Dim strLoanAmortID As String = objReader("loan_amort_id")

        Dim bolChangeable As Boolean = lblBalance.Text <> "0.00"

        If Session("group") = "ADMIN" Then

            lblID.Text = Trim(objReader("id"))

            calRemittedDate.SelectedDate = Trim(objReader("remitted_date"))
            calRemittedDate.Enabled = True

            calORDate.SelectedDate = Trim(objReader("or_date"))
            calORDate.Enabled = True

            ddlPayType.SelectedValue = Trim(objReader("pay_type"))
            ddlPayType.Enabled = True

            txtPaidAmount.Text = Trim(objReader("paid_amount"))
            txtPaidAmount.Enabled = True

            txtORNo.Text = Trim(objReader("or_no"))
            txtORNo.Enabled = True

            txtRemarks.Text = Trim(objReader("remarks"))
            txtRemarks.Enabled = True

            txtCardNo.Text = Trim(objReader("card_no"))
            txtApprovalNo.Text = Trim(objReader("approval_no"))
            txtBankCharge.Text = Trim(objReader("bank_charge"))
            txtCheckNo.Text = Trim(objReader("check_no"))
            calCheckDate.SelectedDate = Trim(objReader("check_date"))
            calDepositedCheckDate.SelectedDate = Trim(objReader("deposited_date"))

            objReader.Close()

            objCommand = New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            ddlBank.DataSource = objReader
            ddlBank.DataValueField = "code"
            ddlBank.DataTextField = "name"
            ddlBank.DataBind()
            objReader.Close()

            objCommand = New SqlCommand("Ref_LoanAmortPayDate_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
            objCommand.Parameters.Add("@id", Request("id"))
            objReader = objCommand.ExecuteReader
            ddlLoanPayDate.DataSource = objReader
            ddlLoanPayDate.DataValueField = "id"
            ddlLoanPayDate.DataTextField = "code"
            ddlLoanPayDate.DataBind()
            ddlLoanPayDate.Enabled = True
            objReader.Close()

            'txtCardNo.Enabled = True
            'txtApprovalNo.Enabled = True
            'txtBankCharge.Enabled = True
            'txtCheckNo.Enabled = True
            'calCheckDate.Enabled = True
            'ddlBank.Enabled = True

            If ddlPayType.SelectedValue = "CARD" Or ddlPayType.SelectedValue = "DEBITCARD" Then
                ddlBank.Enabled = True
                txtCardNo.Enabled = True
                txtApprovalNo.Enabled = True
                txtBankCharge.Enabled = True

            ElseIf ddlPayType.SelectedValue = "CHEQUE" Then
                ddlBank.Enabled = True
                txtCheckNo.Enabled = True
                calCheckDate.Enabled = True
                calDepositedCheckDate.Visible = True
                calDepositedCheckDate.Enabled = True

            ElseIf ddlPayType.SelectedValue = "BANK" Then
                ddlBank.Enabled = True
            End If

        Else

            lblID.Text = Trim(objReader("id"))

            calRemittedDate.SelectedDate = Trim(objReader("remitted_date"))
            calRemittedDate.Enabled = bolChangeable

            calORDate.SelectedDate = Trim(objReader("or_date"))
            calORDate.Enabled = bolChangeable

            ddlPayType.SelectedValue = Trim(objReader("pay_type"))
            ddlPayType.Enabled = bolChangeable

            txtPaidAmount.Text = Trim(objReader("paid_amount"))
            txtPaidAmount.Enabled = bolChangeable

            txtORNo.Text = Trim(objReader("or_no"))
            txtORNo.Enabled = bolChangeable

            txtRemarks.Text = Trim(objReader("remarks"))
            txtRemarks.Enabled = bolChangeable

            txtCardNo.Text = Trim(objReader("card_no"))
            txtApprovalNo.Text = Trim(objReader("approval_no"))
            txtBankCharge.Text = Trim(objReader("bank_charge"))
            txtCheckNo.Text = Trim(objReader("check_no"))
            calCheckDate.SelectedDate = Trim(objReader("check_date"))
            calDepositedCheckDate.SelectedDate = Trim(objReader("deposited_date"))

            objReader.Close()

            objCommand = New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader
            ddlBank.DataSource = objReader
            ddlBank.DataValueField = "code"
            ddlBank.DataTextField = "name"
            ddlBank.DataBind()
            objReader.Close()

            objCommand = New SqlCommand("Ref_LoanAmortPayDate_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
            objCommand.Parameters.Add("@id", Request("id"))
            objReader = objCommand.ExecuteReader
            ddlLoanPayDate.DataSource = objReader
            ddlLoanPayDate.DataValueField = "id"
            ddlLoanPayDate.DataTextField = "code"
            ddlLoanPayDate.DataBind()
            ddlLoanPayDate.Enabled = bolChangeable
            objReader.Close()

            If ddlPayType.SelectedValue = "CARD" Or ddlPayType.SelectedValue = "DEBITCARD" Then
                ddlBank.Enabled = bolChangeable
                txtCardNo.Enabled = bolChangeable
                txtApprovalNo.Enabled = bolChangeable
                txtBankCharge.Enabled = bolChangeable

            ElseIf ddlPayType.SelectedValue = "CHEQUE" Then
                ddlBank.Enabled = bolChangeable
                txtCheckNo.Enabled = bolChangeable
                calCheckDate.Enabled = bolChangeable
                calDepositedCheckDate.Visible = True
                calDepositedCheckDate.Enabled = True


            ElseIf ddlPayType.SelectedValue = "BANK" Or ddlPayType.SelectedValue = "GCASH" Or ddlPayType.SelectedValue = "PAYPAL" Or ddlPayType.SelectedValue = "PAYMAYA" Or ddlPayType.SelectedValue = "SHOPEEPAY" Then
                ddlBank.Enabled = bolChangeable
            End If

        End If

        objConnection.Close()

        ddlBank.SelectedIndex = ddlBank.Items.IndexOf(ddlBank.Items.FindByValue(strBank.ToString))
        ddlLoanPayDate.SelectedIndex = ddlLoanPayDate.Items.IndexOf(ddlLoanPayDate.Items.FindByValue(strLoanAmortID.ToString))

        SetFocus(calRemittedDate)


    End Sub


    Private Sub ReadyDelete()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))

        calRemittedDate.SelectedDate = Trim(objReader("remitted_date"))
        calRemittedDate.Enabled = False

        calORDate.SelectedDate = Trim(objReader("or_date"))
        calORDate.Enabled = False

        ddlPayType.SelectedValue = Trim(objReader("pay_type"))
        ddlPayType.Enabled = False

        txtPaidAmount.Text = Trim(objReader("paid_amount"))
        txtPaidAmount.Enabled = False

        txtORNo.Text = Trim(objReader("or_no"))
        txtORNo.Enabled = False

        txtRemarks.Text = Trim(objReader("remarks"))
        txtRemarks.Enabled = False

        txtCardNo.Text = Trim(objReader("card_no"))
        txtCardNo.Enabled = False

        txtApprovalNo.Text = Trim(objReader("approval_no"))
        txtApprovalNo.Enabled = False

        txtBankCharge.Text = Trim(objReader("bank_charge"))
        txtBankCharge.Enabled = False

        txtCheckNo.Text = Trim(objReader("check_no"))
        txtCheckNo.Enabled = False

        calCheckDate.SelectedDate = Trim(objReader("check_date"))
        calCheckDate.Enabled = False

        calDepositedCheckDate.SelectedDate = Trim(objReader("deposited_date"))
        calDepositedCheckDate.Enabled = False
        calDepositedCheckDate.Visible = False

        Dim strBank As String = objReader("bank_code")
        Dim strLoanAmortID As String = objReader("loan_amort_id")

        objReader.Close()

        objCommand = New SqlCommand("Ref_Bank_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlBank.DataSource = objReader
        ddlBank.DataValueField = "code"
        ddlBank.DataTextField = "name"
        ddlBank.DataBind()
        ddlBank.Enabled = False
        objReader.Close()

        objCommand = New SqlCommand("Ref_LoanAmortPayDate_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", Request("id"))
        objReader = objCommand.ExecuteReader
        ddlLoanPayDate.DataSource = objReader
        ddlLoanPayDate.DataValueField = "id"
        ddlLoanPayDate.DataTextField = "code"
        ddlLoanPayDate.DataBind()
        ddlLoanPayDate.Enabled = False
        ddlLoanPayDate.SelectedIndex = ddlLoanPayDate.Items.IndexOf(ddlLoanPayDate.Items.FindByValue(strLoanAmortID.ToString))
        objReader.Close()

        objConnection.Close()

        ddlBank.SelectedIndex = ddlBank.Items.IndexOf(ddlBank.Items.FindByValue(strBank.ToString))

        SetFocus(btnSave)


    End Sub

    Private Sub ClearInputs()

        calRemittedDate.SelectedDate = Date.UtcNow.AddHours(8)
        calRemittedDate.Enabled = True

        calORDate.SelectedDate = Date.UtcNow.AddHours(8)
        calORDate.Enabled = True

        ddlPayType.SelectedValue = "CASH"
        ddlPayType.Enabled = True

        txtPaidAmount.Text = "0"
        txtPaidAmount.Enabled = True

        txtORNo.Text = "-"
        txtORNo.Enabled = True

        txtRemarks.Text = ""
        txtRemarks.Enabled = True

        txtCardNo.Text = Nothing        

        txtApprovalNo.Text = Nothing        

        txtBankCharge.Text = 0        

        txtCheckNo.Text = Nothing        

        calCheckDate.SelectedDate = "1/1/1999"

        calDepositedCheckDate.SelectedDate = "1/1/1999"
        calDepositedCheckDate.Visible = False

        SetFocus(txtPaidAmount)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()


    End Sub


    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@invoice_no", lblInvoiceNo.Text)
        objCommand.Parameters.Add("@client_code", lblCustomerCode.Text)
        objCommand.Parameters.Add("@remitted_date", calRemittedDate.SelectedDate)
        objCommand.Parameters.Add("@or_date", calORDate.SelectedDate)
        objCommand.Parameters.Add("@or_no", txtORNo.Text)
        objCommand.Parameters.Add("@pay_type", ddlPayType.SelectedValue)

        If ddlBank.Enabled = True Then
            objCommand.Parameters.Add("@bank_code", ddlBank.SelectedValue)
        Else
            objCommand.Parameters.Add("@bank_code", "Select Bank")
        End If

        If txtCardNo.Enabled = True Then
            objCommand.Parameters.Add("@card_no", txtCardNo.Text)
        Else
            objCommand.Parameters.Add("@card_no", Nothing)
        End If

        If txtApprovalNo.Enabled = True Then
            objCommand.Parameters.Add("@approval_no", txtApprovalNo.Text)
        Else
            objCommand.Parameters.Add("@approval_no", Nothing)
        End If

        If txtBankCharge.Enabled = True Then
            objCommand.Parameters.Add("@bank_charge", txtBankCharge.Text)
        Else
            objCommand.Parameters.Add("@bank_charge", 0)
        End If

        If txtCheckNo.Enabled = True Then
            objCommand.Parameters.Add("@check_no", txtCheckNo.Text)
        Else
            objCommand.Parameters.Add("@check_no", Nothing)
        End If

        If calCheckDate.Enabled = True Then
            objCommand.Parameters.Add("@check_date", calCheckDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@check_date", "1/1/1999")
        End If

        If calDepositedCheckDate.Enabled = True Then
            objCommand.Parameters.Add("@deposited_date", calDepositedCheckDate.SelectedDate)
        Else
            objCommand.Parameters.Add("@deposited_date", "1/1/1999")
        End If

        objCommand.Parameters.Add("@paid_amount", txtPaidAmount.Text)
        objCommand.Parameters.Add("@remarks", txtRemarks.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))
        objCommand.Parameters.Add("@loanAmort_id", ddlLoanPayDate.SelectedValue)

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
                                        "inv_paymentdtl_list", _
                                        "InvoiceNo: " + lblInvoiceNo.Text, _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            SaveInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
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
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@remitted_date", calRemittedDate.SelectedDate)
        objCommand.Parameters.Add("@invoice_no", lblInvoiceNo.Text)
        objCommand.Parameters.Add("@paid_amount", txtPaidAmount.Text)
        objCommand.Parameters.Add("@or_no", txtORNo.Text)
        objCommand.Parameters.Add("@check_no", txtCheckNo.Text)
        objCommand.Parameters.Add("@or_date", calORDate.SelectedDate)
        objCommand.Parameters.Add("@check_date", calCheckDate.SelectedDate)
        objCommand.Parameters.Add("@si_date", lblSIDate.Text)

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

    Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
        Handles DataGrid.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "or_no", _
                                    "paid_amount", _
                                    "or_date", _
                                    "pay_type", _
                                    "remitted_date", _
                                    "created_by", _                                    
                                    "created_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "OR #", _
                                    "OR Amount", _
                                    "OR Date", _
                                    "Type", _
                                    "Remitted Date", _
                                    "Created By", _
                                    "Created Date"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "_COUNT_RECORD_", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "N2", _
                                    "DS", _
                                    "", _
                                    "DS", _
                                    "", _
                                    "D"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
                                    "", _
                                    "", _
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
                                            strStoredProc, _
                                            Session("Sys_AccessList"), _
                                            "", _
                                            DataGrid)
    End Sub


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
            DisplayHeader()
            GridBind()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False

            If lblBalance.Text <> "0.00" Then
                btnAddRecord.Visible = True
                btnAddRecord.Text = "Add Payment"
            Else
                btnAddRecord.Visible = False
            End If

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddImg.Visible = False
                btnPrintImg.Visible = False
                btnSaveImg.Visible = False
            End If

        End If

    End Sub

    Sub GridBind()

        'this condition must only run once. initialize session(module) variables
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(DataGrid, _
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
                                    lblISSID.Text)

    End Sub
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles BtnFirst.Click
        txtPageNo.Text = 1
        GridBind()
        Cleanup_and_Rebind()
    End Sub


    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnPrevious.Click
        txtPageNo.Text -= 1
        GridBind()
        Cleanup_and_Rebind()
    End Sub


    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles BtnNext.Click
        txtPageNo.Text += 1
        GridBind()
        Cleanup_and_Rebind()
    End Sub


    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnLast.Click
        txtPageNo.Text = (Val(txtPageNo.Text) + Val(txtMorePage.Text))
        GridBind()
        Cleanup_and_Rebind()
    End Sub
    Private Sub ddlRecordsPerPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ddlRecordsPerPage.SelectedIndexChanged

        txtPageNo.Text = 1
        GridBind()
        Cleanup_and_Rebind()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSearch.Click
        'If txtSearch.Text = "" Then
        '    lblPageRecordCount.Text = lblPageRecordCount.Text & " *Please enter a search key."
        '    Exit Sub
        'End If

        txtPageNo.Text = 1
        GridBind()
        Cleanup_and_Rebind()

    End Sub


    Private Sub DataGrid_SortCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) _
    Handles DataGrid.SortCommand
        Session("SortKey") = e.SortExpression
        txtPageNo.Text = 1
        txtSearch.Text = ""
        GridBind()
        Cleanup_and_Rebind()
    End Sub

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

                If txtFormAction.Text = "Add" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False
                    panelGrid.Visible = True

                    'Session("last_isdtl_sku") = ddlSKU.SelectedValue
                    ClearInputs()
                    DisplayHeader()
                    txtPageNo.Text = 1
                    GridBind()


                ElseIf txtFormAction.Text = "Edit" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False
                    panelGrid.Visible = True

                    'reset and rebind       
                    txtPageNo.Text = 1
                    DisplayHeader()
                    GridBind()


                ElseIf txtFormAction.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False
                    panelGrid.Visible = True

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    txtPageNo.Text = 1
                    GridBind()
                    DisplayHeader()

                End If

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

        If Not Page.IsValid Then
            Exit Sub
        End If


    End Sub


    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.ForeColor = Color.Orange
        'panelGrid.Visible = False
        btnsave.text = "Add"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        ReadyEdit() 'retrive and fill the text box for editing

        'If lblBalance.Text <> "0.00" Then

        '    'mark the selected item 
        '    DataGrid.SelectedIndex = e.Item.ItemIndex

        '    txtFormAction.Text = "Edit"
        '    lblMode.ForeColor = Color.Orange
        '    'panelGrid.Visible = False
        '    btnsave.text = "Add"

        '    'show the Form panel
        '    Sys_Class.ReadyForm(panelForm, _
        '                            panelSuccess, _
        '                            panelInfo, _
        '                            lblMessage, _
        '                            ValidationSummary1, _
        '                            lblMode, _
        '                            txtFormAction)

        '    ReadyEdit() 'retrive and fill the text box for editing
        'Else
        '    If Session("group") = "ADMIN" Then
        '        'mark the selected item 
        '        DataGrid.SelectedIndex = e.Item.ItemIndex

        '        txtFormAction.Text = "Edit"
        '        lblMode.ForeColor = Color.Orange
        '        'panelGrid.Visible = False
        '        btnsave.text = "Add"

        '        'show the Form panel
        '        Sys_Class.ReadyForm(panelForm, _
        '                                panelSuccess, _
        '                                panelInfo, _
        '                                lblMessage, _
        '                                ValidationSummary1, _
        '                                lblMode, _
        '                                txtFormAction)

        '        ReadyEdit() 'retrive and fill the text box for editing
        '    Else
        '        Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record has already " + lblBalance.Text + " Balance!');</script>")
        '    End If

        'End If

    End Sub


    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

        If lblBalance.Text <> "0.00" Then
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Delete"
            lblMode.ForeColor = Color.Red
            'panelGrid.Visible = False
            btnSave.Text = "Delete"

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)
            ReadyDelete() 'retrive and fill the text box for editing
        Else
            If Session("group") = "ADMIN" Then
                DataGrid.SelectedIndex = e.Item.ItemIndex

                txtFormAction.Text = "Delete"
                lblMode.ForeColor = Color.Red
                'panelGrid.Visible = False
                btnSave.Text = "Delete"

                'show the Form panel
                Sys_Class.ReadyForm(panelForm, _
                                        panelSuccess, _
                                        panelInfo, _
                                        lblMessage, _
                                        ValidationSummary1, _
                                        lblMode, _
                                        txtFormAction)
                ReadyDelete() 'retrive and fill the text box for editing
            Else
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record has already " + lblBalance.Text + " Balance!');</script>")
            End If
        End If

    End Sub

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').select() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Issuance_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblISSID.Text = objReader("id")
        lblInvoiceNo.Text = objReader("invoice_no")
        lblSIDate.Text = objReader("si_date")
        lblCustomer.Text = objReader("client")
        lblCustomerCode.Text = objReader("client_code")
        lblInvoiceAmount.Text = objReader("net_sales")
        lblPaidAmount.Text = objReader("paid_amount")
        lblBalance.Text = objReader("owing")

        lblSINo.Text = objReader("invoice_no")
        lblAccountName.Text = objReader("client")
        lblOwing.Text = objReader("owing")

        objReader.Close()
        objConnection.Close()

        hlViewFullHistory.Visible = False
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_payments_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_dr_form?code=" & lblInvoiceNo.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")


        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_paymentdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub ddlPayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPayType.SelectedIndexChanged

        If ddlPayType.SelectedValue = "CARD" Or ddlPayType.SelectedValue = "DEBITCARD" Then

            SetFocus(ddlBank)

            txtCardNo.Text = Nothing
            txtCardNo.Enabled = True

            txtApprovalNo.Text = Nothing
            txtApprovalNo.Enabled = True

            txtBankCharge.Text = 0
            txtBankCharge.Enabled = True

            ddlBank.SelectedIndex = Nothing
            ddlBank.Enabled = True

            txtCheckNo.Text = Nothing
            txtCheckNo.Enabled = False

            calCheckDate.SelectedDate = "1/1/1999"
            calCheckDate.Enabled = False

        ElseIf ddlPayType.SelectedValue = "CHEQUE" Then

            SetFocus(ddlBank)

            txtCheckNo.Enabled = True

            calCheckDate.SelectedDate = Date.UtcNow.AddHours(8)
            calCheckDate.Enabled = True

            ddlBank.SelectedIndex = Nothing
            ddlBank.Enabled = True

            txtCardNo.Text = Nothing
            txtCardNo.Enabled = False

            txtApprovalNo.Text = Nothing
            txtApprovalNo.Enabled = False

            txtBankCharge.Text = 0
            txtBankCharge.Enabled = False

        ElseIf ddlPayType.SelectedValue = "BANK" Or ddlPayType.SelectedValue = "GCASH" Or ddlPayType.SelectedValue = "PAYPAL" Or ddlPayType.SelectedValue = "PAYMAYA" Or ddlPayType.SelectedValue = "SHOPEEPAY" Then

            SetFocus(ddlBank)

            ddlBank.SelectedIndex = Nothing
            ddlBank.Enabled = True

            txtCardNo.Text = Nothing
            txtCardNo.Enabled = False

            txtApprovalNo.Text = Nothing
            txtApprovalNo.Enabled = False

            txtBankCharge.Text = 0
            txtBankCharge.Enabled = False

            txtCheckNo.Text = Nothing
            txtCheckNo.Enabled = False

            calCheckDate.SelectedDate = "1/1/1999"
            calCheckDate.Enabled = False
        Else
            SetFocus(txtPaidAmount)

            ddlBank.SelectedIndex = Nothing
            ddlBank.Enabled = False

            txtCardNo.Text = Nothing
            txtCardNo.Enabled = False

            txtApprovalNo.Text = Nothing
            txtApprovalNo.Enabled = False

            txtBankCharge.Text = 0
            txtBankCharge.Enabled = False

            txtCheckNo.Text = Nothing
            txtCheckNo.Enabled = False

            calCheckDate.SelectedDate = "1/1/1999"
            calCheckDate.Enabled = False
        End If

    End Sub
End Class

