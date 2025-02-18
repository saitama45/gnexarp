
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_paiddtl_list
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
    Protected WithEvents btnShowPreviousPO As System.Web.UI.WebControls.Button
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
    Protected WithEvents panelRecent As System.Web.UI.WebControls.Panel
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
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    
    Protected WithEvents lblBalance As System.Web.UI.WebControls.Label
    Protected WithEvents lblCompany As System.Web.UI.WebControls.Label
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCustomer As System.Web.UI.WebControls.DropDownList
    Protected WithEvents calRemittedDate As eWorld.UI.CalendarPopup
    Protected WithEvents calORDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtORNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtORAmount As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlPayType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtRemarks As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelBank As System.Web.UI.WebControls.Panel
    Protected WithEvents ddlBank As System.Web.UI.WebControls.DropDownList
    Protected WithEvents panelCard As System.Web.UI.WebControls.Panel
    Protected WithEvents txtCardNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtApprovalNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBankCharge As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelCheck As System.Web.UI.WebControls.Panel
    Protected WithEvents txtCheckNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents calCheckDate As eWorld.UI.CalendarPopup
    Protected WithEvents calDepositedCheckDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtSysID As System.Web.UI.WebControls.TextBox
    Protected WithEvents litTableRows As New Literal
    Protected WithEvents btnSaveAmount As System.Web.UI.WebControls.Button
    Protected WithEvents txtSessionFullname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAppliedPaymentValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtWTaxAmountValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDeductionValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscountValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtHeaderID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAmountReceived As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtApplied As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtToApply As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPayTypeValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtGroup As System.Web.UI.WebControls.TextBox

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
    Public strStoredProc As String = "inv_paiddtl_list"
    Public strSubMenuName As String = "inv_paiddtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"
    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PaidDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strBank As String = objReader("bank_code")
        Dim strLoanAmortID As String = objReader("loan_amort_id")
        Dim strCompany As String = objReader("company")
        Dim strCustomer As String = objReader("client_code")

        Dim bolChangeable As Boolean = lblBalance.Text <> "0.00"

        If Session("group") = "ADMIN" Then

            lblID.Text = Trim(objReader("id"))

            calRemittedDate.SelectedDate = Trim(objReader("remitted_date"))
            calRemittedDate.Enabled = True

            calORDate.SelectedDate = Trim(objReader("or_date"))
            calORDate.Enabled = True

            ddlPayType.SelectedValue = Trim(objReader("pay_type"))
            ddlPayType.Enabled = True

            txtORAmount.Text = Trim(objReader("or_amount"))
            txtORAmount.Enabled = True

            txtAmountReceived.Text = Trim(objReader("or_amount_show"))

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

            objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlCompany.DataSource = objReader
            ddlCompany.DataValueField = "code"
            ddlCompany.DataTextField = "name"
            ddlCompany.DataBind()
            ddlCompany.Enabled = True
            objReader.Close()

            objCommand = New SqlCommand("Ref_CustomerCompany_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@company", strCompany)
            objReader = objCommand.ExecuteReader
            ddlCustomer.DataSource = objReader
            ddlCustomer.DataValueField = "code"
            ddlCustomer.DataTextField = "name"
            ddlCustomer.DataBind()
            ddlCustomer.Enabled = True
            objReader.Close()

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

            txtORAmount.Text = Trim(objReader("or_amount"))
            txtORAmount.Enabled = bolChangeable

            txtORNo.Text = Trim(objReader("or_no"))
            txtORNo.Enabled = bolChangeable

            txtAmountReceived.Text = Trim(objReader("or_amount_show"))

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

            objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlCompany.DataSource = objReader
            ddlCompany.DataValueField = "code"
            ddlCompany.DataTextField = "name"
            ddlCompany.DataBind()
            ddlCompany.Enabled = bolChangeable
            objReader.Close()

            objCommand = New SqlCommand("Ref_CustomerCompany_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@company", strCompany)
            objReader = objCommand.ExecuteReader
            ddlCustomer.DataSource = objReader
            ddlCustomer.DataValueField = "code"
            ddlCustomer.DataTextField = "name"
            ddlCustomer.DataBind()
            ddlCustomer.Enabled = bolChangeable
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
        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        ddlCustomer.SelectedIndex = ddlCustomer.Items.IndexOf(ddlCustomer.Items.FindByValue(strCustomer))

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

            If Request("FormAction") = "Save" Then

                SaveAmount()

            Else
                DisplayHeader()
                'GridBind()
                LoadGrid()

                txtGroup.Text = Session("Group")
                txtSessionFullname.Text = Session("Fullname")
                txtHeaderID.Text = lblID.Text                

                'is this module in the list of accessable menus?
                If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                    'go somewhere
                    Response.Redirect("sys_errorpage")
                End If

                'is the user allowed to add record?
                If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                    'disable the add button                

                End If
            End If

        End If

    End Sub
    Private Sub GridBind()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@client_code", ddlCustomer.SelectedValue)
        objCommand.Parameters.Add("@or_no", txtORNo.Text)
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
    End Sub
    Private Sub LoadGrid()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@client_code", ddlCustomer.SelectedValue)
        objCommand.Parameters.Add("@or_no", txtORNo.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim myItems As String = String.Empty

        While objReader.Read

            myItems &= ("<tr>" & _
                            "<td>" & _
                                "<input class='w3-check-small' type='checkbox'>" & _
                            "</td>" & _
                            "<td class='iss_id'>" & _
                                "<span>" + Trim(objReader("id")) + "</span>" & _
                            "</td>" & _
                            "<td>" & _
                                Trim(objReader("invoice_no")) & _
                            "</td>" & _
                            "<td>" & _
                                Trim(objReader("si_date")) & _
                            "</td>" & _
                            "<td>" & _
                                Trim(objReader("net_sales")) & _
                            "</td>" & _
                            "<td class='tdAppliedPayment'>" & _
                                "<input type='text' class='txtAppliedPayment' style='text-align:center;' value='" + Trim(objReader("paid_amount")) + "'>" & _
                            "</td>" & _
                            "<td class='tdWTaxAmount'>" & _
                                "<input type='text' class='txtWTaxAmount' style='text-align:center;' value='" + Trim(objReader("wtax_amount")) + "'>" & _
                            "</td>" & _
                            "<td class='tdtxtDeduction'>" & _
                                "<input type='text' class='txtDeduction' style='text-align:center;' value='" + Trim(objReader("deduction_amount")) + "'>" & _
                            "</td>" & _
                            "<td class='tdtxtDiscount'>" & _
                                "<input type='text' class='txtDiscount' style='text-align:center;' value='" + Trim(objReader("discount_amount")) + "'>" & _
                            "</td>" & _
                            "<td class='tdtxtTotalPaid'>" & _
                                Trim(objReader("total_paid")) & _
                            "</td>" & _
                            "<td class='tdtxtBalance'>" & _
                                Trim(objReader("owing")) & _
                            "</td>" & _
                        "</tr>")

        End While

        litTableRows.Text = myItems

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Function SaveAmount()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_PaidDTL_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Save")
        objCommand.Parameters.Add("@header_id", Request("header_id"))
        objCommand.Parameters.Add("@iss_id", Request("iss_id"))
        objCommand.Parameters.Add("@pay_type", Request("pay_type"))
        objCommand.Parameters.Add("@applied_amount", Request("applied_amount"))
        objCommand.Parameters.Add("@wtax_amount", Request("wtax_amount"))
        objCommand.Parameters.Add("@deduction_amount", Request("deduction_amount"))
        objCommand.Parameters.Add("@discount_amount", Request("discount_amount"))
        objCommand.Parameters.Add("@Session_fullname", Request("Session_fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
    End Function
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_paid_list")
    End Sub

    Private Sub btnSaveImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveImg.Click

        SaveHeaderClick()

    End Sub
    Private Function SaveHeaderClick()
        'validate the inputs vs. table records
        Dim strValidateHeader As String = ValidateHeader()

        'is the validation 
        If strValidateHeader = "ok" Then
            'then save the inputs
            Dim strSaveHeader As String = SaveHeader()

            'is the saving successfull?
            If strSaveHeader = "ok" Then
                'notify and clear input boxes

                panelSuccess.Visible = True
                panelInfo.Visible = False
                panelForm.Visible = False
                'lblValidate.Visible = False
                panelGrid.Visible = True

                'reset and rebind       
                'DataGrid.SelectedIndex = -1
                LoadGrid()
                DisplayHeader()

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Visible = True
                lblValidate.Text = strSaveHeader
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            panelInfo.Visible = True
            lblValidate.Visible = True
            lblValidate.Text = strValidateHeader
        End If
    End Function

    Private Function ValidateHeader()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateHeader = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        'objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        objCommand.Parameters.Add("@remitted_date", calRemittedDate.SelectedDate)
        'objCommand.Parameters.Add("@invoice_no", lblInvoiceNo.Text)
        objCommand.Parameters.Add("@or_amount", txtORAmount.Text)
        objCommand.Parameters.Add("@or_no", txtORNo.Text)
        objCommand.Parameters.Add("@check_no", txtCheckNo.Text)
        objCommand.Parameters.Add("@or_date", calORDate.SelectedDate)
        objCommand.Parameters.Add("@check_date", calCheckDate.SelectedDate)
        'objCommand.Parameters.Add("@si_date", lblSIDate.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateHeader = objReader("Error_Message")
            End While
        End If

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
    End Function

    Private Function SaveHeader()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveHeader = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PaymentDTL_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        'objCommand.Parameters.Add("@iss_id", lblISSID.Text)
        'objCommand.Parameters.Add("@invoice_no", lblInvoiceNo.Text)
        'objCommand.Parameters.Add("@client_code", lblCustomerCode.Text)
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

        objCommand.Parameters.Add("@or_amount", txtORAmount.Text)
        objCommand.Parameters.Add("@remarks", txtRemarks.Text)
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
                                        "Ref#", _
                                        objNewID.Value, _
                                        0)

            Session("objNewID") = objNewID.Value

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveHeader = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveHeader = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

    End Function

    Private Sub ddlPayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPayType.SelectedIndexChanged
        If ddlPayType.SelectedValue = "CARD" Or ddlPayType.SelectedValue = "DEBITCARD" Then

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

        UpdatePayment()
        LoadGrid()
        DisplayHeader()

    End Sub
    Private Sub ddlCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCompany.SelectedIndexChanged
        RefreshCustomer()
    End Sub
    Private Function RefreshCustomer()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_CustomerCompany_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlCustomer.DataSource = objReader
        ddlCustomer.DataValueField = "code"
        ddlCustomer.DataTextField = "name"
        ddlCustomer.DataBind()
        ddlCustomer.Items.Insert(0, "")
        ddlCustomer.SelectedIndex = 0
        objReader.Close()
        objConnection.Close()
    End Function
    Private Function UpdatePayment()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_PaidDTL_Update", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Save")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@pay_type", txtPayTypeValue.Text)
        objCommand.Parameters.Add("@client_code", ddlCustomer.SelectedValue)
        objCommand.Parameters.Add("@or_no", txtORNo.Text)
        objCommand.Parameters.Add("@Session_fullname", Request("Session_fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
    End Function
    'Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    'Handles DataGrid.EditCommand

    '    'mark the selected item 
    '    DataGrid.SelectedIndex = e.Item.ItemIndex

    '    txtFormAction.Text = "Edit"
    '    lblMode.ForeColor = Color.Orange
    '    btnSave.Text = "Save"
    '    panelGrid.Visible = False

    '    'show the input panel
    '    Sys_Class.ReadyForm(panelForm, _
    '                            panelSuccess, _
    '                            panelInfo, _
    '                            lblMessage, _
    '                            ValidationSummary1, _
    '                            lblMode, _
    '                            txtFormAction)


    '    'ReadyEdit() 'retrive and fill the text box for editing
    'End Sub
    'Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    'Handles DataGrid.DeleteCommand

    '    DataGrid.SelectedIndex = e.Item.ItemIndex

    '    txtFormAction.Text = "Delete"
    '    lblMode.ForeColor = Color.Red
    '    btnSave.Text = "Delete"
    '    panelGrid.Visible = False

    '    'show the form panel
    '    Sys_Class.ReadyForm(panelForm, _
    '                            panelSuccess, _
    '                            panelInfo, _
    '                            lblMessage, _
    '                            ValidationSummary1, _
    '                            lblMode, _
    '                            txtFormAction)


    '    'ReadyDelete() 'retrive and fill the text box for editing
    'End Sub
    'Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
    '    srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    'End Sub
    'Private Sub DataGrid_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
    'Handles DataGrid.ItemCreated
    '    'handles for each item(ROW) created

    '    'the columns (ONLY) to display, each items must exist from the resultset
    '    Dim aColumns() As String = {"", _
    '                                "invoice_no", _
    '                                "pay_type", _
    '                                "paid_amount"}

    '    'the headers to diplay, instead of the default fieldname
    '    Dim aHeaders() As String = {"ID", _
    '                                "Invoice No.", _
    '                                "Pay Type", _
    '                                "Applied Amount"}

    '    'the sort key expression to associate. pass "" to disable sorting
    '    Dim aSortKeys() As String = {"", _
    '                                "", _
    '                                "", _
    '                                ""}

    '    'the item display formats. pass "" to display as is
    '    Dim aFormats() As String = {"", _
    '                                "", _
    '                                "", _
    '                                "N2"}

    '    'display what you want below - displays if footer is specified in the datagrid
    '    Dim aFooters() As String = {"", _
    '                                "_COUNT_RECORD_", _
    '                                "", _
    '                                "_SUM_"}

    '    'the URL if you wish an item clickable, pass "" to disable.
    '    'Dim aURL() As String = {"", "", ""}

    '    'EndMODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    '    srx.Sys_Class.DataGrid_ItemCreated_v2(e, _
    '                                       aColumns, _
    '                                       aHeaders, _
    '                                       aFormats, _
    '                                       aSortKeys, _
    '                                       aFooters, _
    '                                       aEnableFields_List, _
    '                                       aEnableFields_Format, _
    '                                       aEnableFields_Footer, _
    '                                       Session("SortKey"), _
    '                                       strStoredProc, _
    '                                       Session("Sys_AccessList"), _
    '                                       "", _
    '                                       DataGrid)
    'End Sub
End Class

