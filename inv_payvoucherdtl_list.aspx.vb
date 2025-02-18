
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_payvoucherdtl_list
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
    Protected WithEvents btnSave2 As System.Web.UI.WebControls.Button
    Protected WithEvents btnX As System.Web.UI.WebControls.Button
    Protected WithEvents btnX2 As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFormAction2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode2 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents lblID2 As System.Web.UI.WebControls.Label
    Protected WithEvents hlViewFullHistory As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelPOForm As System.Web.UI.WebControls.Panel
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
    Protected WithEvents btnPrint As System.Web.UI.WebControls.Button            
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddPOImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnReplicateImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblPVID As System.Web.UI.WebControls.Label
    Protected WithEvents lblVoucherNo As System.Web.UI.WebControls.Label
    Protected WithEvents calDate As eWorld.UI.CalendarPopup
    Protected WithEvents calDueDate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlVendor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtParticulars As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblDebitHDR As System.Web.UI.WebControls.Label
    Protected WithEvents lblCreditHDR As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayable As System.Web.UI.WebControls.Label
    Protected WithEvents ddlCostCenter As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCOA As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtParticularsDTL As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDebit As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCredit As System.Web.UI.WebControls.TextBox
    Protected WithEvents chbMultipleCostCenter As System.Web.UI.WebControls.CheckBox
    Protected WithEvents ddlVendorPO As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtAmountToPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPONo As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorSINo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPOBalance As System.Web.UI.WebControls.Label
    Protected WithEvents txtSONo As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCustomer As System.Web.UI.WebControls.Label
    Protected WithEvents lblCustomerCode As System.Web.UI.WebControls.Label
    Protected WithEvents chbIsCustomer As System.Web.UI.WebControls.CheckBox

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
    Public strStoredProc As String = "inv_payvoucherdtl_list"
    Public strStoredProc2 As String = "Inv_PayVoucherPO_List"
    Public strSubMenuName As String = "inv_payvoucherdtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblStatus.Text = "ON PROCESS" Then
            txtFormAction.Text = "Add"
            lblMode.ForeColor = Color.Green
            'panelGrid.Visible = False
            btnSave.Text = "Add"

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
                'panelGrid.Visible = False
                btnSave.Text = "Add"

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
                btnAddImg.Visible = False
            End If
        End If

    End Sub
    Private Sub btnAddPOImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddPOImg.Click

        txtFormAction2.Text = "Add"
        lblMode2.ForeColor = Color.Green
        'panelGrid.Visible = False
        btnSave2.Text = "Add"

        'show the form panel
        panelPOForm.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'set the value based on desired action
        lblMode2.Text = txtFormAction2.Text & " Record"

        ReadyAdd2()
    End Sub
    Private Sub ReadyAdd()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_CostCenter_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlCostCenter.DataSource = objReader
        ddlCostCenter.DataValueField = "code"
        ddlCostCenter.DataTextField = "name"
        ddlCostCenter.DataBind()
        ddlCostCenter.Items.Insert(0, "")
        ddlCostCenter.SelectedIndex = 0
        objReader.Close()

        objCommand = New SqlCommand("Ref_COA_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCOA.DataSource = objReader
        ddlCOA.DataValueField = "code"
        ddlCOA.DataTextField = "name"
        ddlCOA.DataBind()
        ddlCOA.Items.Insert(0, "")
        ddlCOA.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        ClearInputs()
    End Sub
    Private Sub ReadyAdd2()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_VenPO_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)        
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        ddlVendorPO.DataSource = objReader
        ddlVendorPO.DataValueField = "code"
        ddlVendorPO.DataTextField = "name"
        ddlVendorPO.DataBind()
        ddlVendorPO.Items.Insert(0, "")
        ddlVendorPO.SelectedIndex = 0
        objReader.Close()

        objConnection.Close()

        ClearInputs2()

    End Sub
    Private Sub ClearInputs()
        lblID.Text = 0

        txtParticularsDTL.Text = ""
        txtParticularsDTL.Enabled = True

        txtDebit.Text = "0"
        txtDebit.Enabled = True

        txtCredit.Text = "0"
        txtCredit.Enabled = True

        chbMultipleCostCenter.Visible = True

        SetFocus(ddlCostCenter)

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
    End Sub
    Private Sub ClearInputs2()

        lblID2.Text = 0

        txtAmountToPay.Text = "0"
        txtAmountToPay.Enabled = True

        lblPONo.Text = ""
        lblVendorSINo.Text = ""
        lblPOBalance.Text = 0

        ddlVendorPO.Enabled = True

        SetFocus(txtAmountToPay)

        'reset the selected index in case of edit modes and rebind
        DataGrid2.SelectedIndex = -1
        GridBind2()

    End Sub

    Private Sub ReadyEdit()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strCostCenter = Trim(objReader("cost_center"))
        Dim strCOA As String = objReader("coa_id")

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        lblID.Text = Trim(objReader("id"))

        txtParticularsDTL.Text = Trim(objReader("particulars"))
        txtParticularsDTL.Enabled = True

        txtDebit.Text = Trim(objReader("debit"))
        txtDebit.Enabled = True

        txtCredit.Text = Trim(objReader("credit"))
        txtCredit.Enabled = True

        chbMultipleCostCenter.Visible = True

        objReader.Close()

        objCommand = New SqlCommand("Ref_CostCenter_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCostCenter.DataSource = objReader
        ddlCostCenter.DataValueField = "code"
        ddlCostCenter.DataTextField = "name"
        ddlCostCenter.DataBind()
        ddlCostCenter.Enabled = True
        objReader.Close()

        ddlCostCenter.SelectedIndex = ddlCostCenter.Items.IndexOf(ddlCostCenter.Items.FindByValue(strCostCenter.ToString))

        objCommand = New SqlCommand("Ref_COA_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCOA.DataSource = objReader
        ddlCOA.DataValueField = "code"
        ddlCOA.DataTextField = "name"
        ddlCOA.DataBind()
        ddlCOA.Enabled = True
        objReader.Close()

        ddlCOA.SelectedIndex = ddlCOA.Items.IndexOf(ddlCOA.Items.FindByValue(strCOA.ToString))

        objConnection.Close()

        SetFocus(ddlCostCenter)
    End Sub
    Private Sub ReadyEdit2()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid2.DataKeys(DataGrid2.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherPO_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strVendorPO = Trim(objReader("pr_id"))

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        lblID2.Text = Trim(objReader("id"))

        txtAmountToPay.Text = Trim(objReader("paid_amount"))
        txtAmountToPay.Enabled = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_VenPO_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)        
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)

        objReader = objCommand.ExecuteReader
        ddlVendorPO.DataSource = objReader
        ddlVendorPO.DataValueField = "code"
        ddlVendorPO.DataTextField = "name"
        ddlVendorPO.DataBind()
        ddlVendorPO.Enabled = bolChangeable
        objReader.Close()

        ddlVendorPO.SelectedIndex = ddlVendorPO.Items.IndexOf(ddlVendorPO.Items.FindByValue(strVendorPO.ToString))

        objConnection.Close()

        SetFocus(txtAmountToPay)
    End Sub

    Private Sub ReadyDelete()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strCostCenter = Trim(objReader("cost_center"))
        Dim strCOA As String = objReader("Account_Title")

        Dim bolChangeable As Boolean = lblStatus.Text = "ON PROCESS"

        lblID.Text = Trim(objReader("id"))

        txtParticularsDTL.Text = Trim(objReader("particulars"))
        txtParticularsDTL.Enabled = False

        txtDebit.Text = Trim(objReader("debit"))
        txtDebit.Enabled = False

        txtCredit.Text = Trim(objReader("credit"))
        txtCredit.Enabled = False

        chbMultipleCostCenter.Visible = False

        objReader.Close()

        objCommand = New SqlCommand("Ref_CostCenter_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCostCenter.DataSource = objReader
        ddlCostCenter.DataValueField = "code"
        ddlCostCenter.DataTextField = "name"
        ddlCostCenter.DataBind()
        ddlCostCenter.Enabled = False
        objReader.Close()

        ddlCostCenter.SelectedIndex = ddlCostCenter.Items.IndexOf(ddlCostCenter.Items.FindByValue(strCostCenter.ToString))

        objCommand = New SqlCommand("Ref_COA_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCOA.DataSource = objReader
        ddlCOA.DataValueField = "code"
        ddlCOA.DataTextField = "name"
        ddlCOA.DataBind()
        ddlCOA.Enabled = False
        objReader.Close()

        ddlCOA.SelectedIndex = ddlCOA.Items.IndexOf(ddlCOA.Items.FindByValue(strCOA.ToString))

        objConnection.Close()

    End Sub
    Private Sub ReadyDelete2()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid2.DataKeys(DataGrid2.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherPO_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strVendorPO = Trim(objReader("pr_id"))

        lblID2.Text = Trim(objReader("id"))

        txtAmountToPay.Text = Trim(objReader("paid_amount"))
        txtAmountToPay.Enabled = False

        objReader.Close()

        objCommand = New SqlCommand("Ref_VenPO_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)        
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)

        objReader = objCommand.ExecuteReader
        ddlVendorPO.DataSource = objReader
        ddlVendorPO.DataValueField = "code"
        ddlVendorPO.DataTextField = "name"
        ddlVendorPO.DataBind()
        ddlVendorPO.Enabled = False
        objReader.Close()

        ddlVendorPO.SelectedIndex = ddlVendorPO.Items.IndexOf(ddlVendorPO.Items.FindByValue(strVendorPO.ToString))

        objConnection.Close()

        SetFocus(txtAmountToPay)

    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherDTL_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@pv_id", lblPVID.Text)
        objCommand.Parameters.Add("@coa_id", ddlCOA.SelectedValue)
        objCommand.Parameters.Add("@particulars", txtParticularsDTL.Text)
        objCommand.Parameters.Add("@debit", txtDebit.Text)
        objCommand.Parameters.Add("@credit", txtCredit.Text)
        objCommand.Parameters.Add("@cost_center", ddlCostCenter.SelectedValue)
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
                                        Request("sys_table"), _
                                        "COA: " + ddlCOA.SelectedValue, _
                                        Request("id"), _
                                        0)

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
    Private Function SaveInput2()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput2 = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherPO_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)
        objCommand.Parameters.Add("@id", lblID2.Text)
        objCommand.Parameters.Add("@pv_id", lblPVID.Text)
        objCommand.Parameters.Add("@pr_id", ddlVendorPO.SelectedValue)
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@paid_amount", txtAmountToPay.Text)
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
                                        Request("sys_table"), _
                                        "VendorPO: " + ddlCOA.SelectedValue, _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            If txtFormAction2.Text = "Delete" Then
                SaveInput2 = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveInput2 = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
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
        Dim objCommand As New SqlCommand("Inv_PayVoucherDTL_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@pv_id", lblPVID.Text)
        objCommand.Parameters.Add("@coa_id", ddlCOA.SelectedValue)
        objCommand.Parameters.Add("@debit", txtDebit.Text)
        objCommand.Parameters.Add("@credit", txtCredit.Text)

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
    Private Function ValidateInput2()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput2 = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherPO_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction2.Text)
        objCommand.Parameters.Add("@id", lblID2.Text)
        objCommand.Parameters.Add("@paid_amount", txtAmountToPay.Text)

        'open the connection and execute the reader 
        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                ValidateInput2 = objReader("Error_Message")
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
                                            strStoredProc, _
                                            Session("Sys_AccessList"), _
                                            lblStatus.Text, _
                                            DataGrid)
    End Sub

    Private Sub DataGrid2_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemCreated
        'handles for each item(ROW) created

        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"", _
                                    "pr_code", _
                                    "vendor_si_no", _
                                    "paid_amount", _
                                    "owing"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "PO #", _
                                    "Vendor Invoice #", _
                                    "Paid Amount", _
                                    "Balance"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_"}

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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
                                            strSubMenuName, _
                                            Session("Sys_AccessList"), _
                                            lblStatus.Text, _
                                            DataGrid2)
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
            GridBind2()

            txtFormAction.Visible = False 'always hide this
            txtFormAction2.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False
            txtSearch.Visible = False
            btnSearch.Visible = False

            If lblStatus.Text = "ON PROCESS" Then
                btnAddImg.Visible = True
                btnAddPOImg.Visible = True
                'btnPrintImg.Visible = True
            Else
                btnAddImg.Visible = False
                btnAddPOImg.Visible = False
                'btnPrintImg.Visible = False
            End If

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddImg.Visible = False
                btnAddPOImg.Visible = False
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
                                    lblPVID.Text)

    End Sub
    Sub GridBind2()
        'this condition must only run once. initialize session(module) variables
        If strStoredProc2 <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc2
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay(DataGrid2, _
                                    strStoredProc2, _
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
                                    lblPVID.Text)
    End Sub
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub
    Private Sub DataGrid2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid2.ItemDataBound
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
                    SetFocus(ddlCostCenter)

                    If chbMultipleCostCenter.Checked = False Then
                        ddlCOA.SelectedIndex = 0
                        txtParticularsDTL.Text = ""
                        txtDebit.Text = 0
                        txtCredit.Text = 0
                    Else
                        ddlCostCenter.SelectedIndex = 0
                        txtDebit.Text = 0
                        txtCredit.Text = 0
                    End If

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
    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSave2.Click
        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput2()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput2()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                If txtFormAction2.Text = "Add" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelPOForm.Visible = True

                    ReadyAdd2()
                    SetFocus(txtAmountToPay)

                    DataGrid.SelectedIndex = -1
                    DataGrid2.SelectedIndex = -1
                    DisplayHeader()
                    txtPageNo.Text = 1
                    GridBind()
                    GridBind2()

                ElseIf txtFormAction2.Text = "Delete" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    panelPOForm.Visible = False
                    panelGrid.Visible = True

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    DataGrid2.SelectedIndex = -1
                    txtPageNo.Text = 1
                    GridBind()
                    GridBind2()
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

        If lblStatus.Text = "ON PROCESS" Then

            'mark the selected item 
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Edit"
            lblMode.ForeColor = Color.Orange
            'panelGrid.Visible = False
            btnSave.Text = "Save"

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)

            ReadyEdit() 'retrive and fill the text box for editing
        Else
            If Session("group") = "ADMIN" Then
                'mark the selected item 
                DataGrid.SelectedIndex = e.Item.ItemIndex

                txtFormAction.Text = "Edit"
                lblMode.ForeColor = Color.Orange
                'panelGrid.Visible = False
                btnSave.Text = "Save"

                'show the Form panel
                Sys_Class.ReadyForm(panelForm, _
                                        panelSuccess, _
                                        panelInfo, _
                                        lblMessage, _
                                        ValidationSummary1, _
                                        lblMode, _
                                        txtFormAction)

                ReadyEdit() 'retrive and fill the text box for editing
            Else
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If

        End If

    End Sub
    
    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

        If lblStatus.Text = "ON PROCESS" Then
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
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If
        End If

    End Sub
    Private Sub DataGrid2_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid2.DeleteCommand

        DataGrid2.SelectedIndex = e.Item.ItemIndex

        txtFormAction2.Text = "Delete"
        lblMode2.ForeColor = Color.Red
        'panelGrid.Visible = False
        btnSave2.Text = "Delete"

        'show the form panel
        panelPOForm.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False

        'set the value based on desired action
        lblMode2.Text = txtFormAction2.Text & " Record"

        ReadyDelete2() 'retrive and fill the text box for editing
    End Sub

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').select() </SCRIPT>"
        RegisterStartupScript("select", s)
    End Sub

    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucher_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strVendor As String = objReader("vendor_code")

        Dim bolChangeable As Boolean = objReader("status") = "ON PROCESS"

        lblPVID.Text = objReader("id")

        lblStatus.Text = objReader("status")

        txtSONo.Text = Trim(objReader("so_no"))
        txtSONo.Enabled = bolChangeable
        lblCustomer.Text = Trim(objReader("customer_name"))
        lblCustomerCode.Text = Trim(objReader("customer"))

        If Session("group") = "GENADMIN" Then
            lblStatus.Visible = False
            ddlStatus.Visible = True
            ddlStatus.SelectedValue = objReader("status")
        Else
            ddlStatus.Visible = False
            lblStatus.Visible = True
        End If

        If lblStatus.Text = "POSTED" Then
            btnReplicateImg.Visible = True
        Else
            btnReplicateImg.Visible = False
        End If

        lblVoucherNo.Text = objReader("voucher_no")

        calDate.SelectedDate = objReader("voucher_date")
        calDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calDate.Enabled = bolChangeable

        calDueDate.SelectedDate = objReader("due_date")
        calDueDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString
        calDueDate.Enabled = bolChangeable

        txtParticulars.Text = objReader("particulars")
        txtParticulars.Enabled = bolChangeable

        lblDebitHDR.Text = objReader("debit_show")
        lblCreditHDR.Text = objReader("credit_show")

        lblPayable.Text = objReader("payable_amount_show")

        If Trim(objReader("total_PO_item")) > 0 Or Trim(objReader("total_item")) > 0 Then
            ddlVendor.Enabled = False
        Else
            ddlVendor.Enabled = bolChangeable
        End If

        objReader.Close()

        objCommand = New SqlCommand("Ref_Vendors_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlVendor.DataSource = objReader
        ddlVendor.DataValueField = "code"
        ddlVendor.DataTextField = "name"
        ddlVendor.DataBind()
        ddlVendor.SelectedIndex = ddlVendor.Items.IndexOf(ddlVendor.Items.FindByValue(strVendor.ToString))
        objReader.Close()

        objConnection.Close()

        btnSave.Visible = bolChangeable

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_payvoucher_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrintImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintImg.Click

        panelSuccess.Visible = False
        panelInfo.Visible = False

        If lblPayable.Text <> 0 And lblDebitHDR.Text <> lblPayable.Text Then

            Response.Write("<script language=""javascript"">alert('Cannot Proceed! AP and PO Payable is not yet balance!');</script>")

        ElseIf lblDebitHDR.Text <> lblCreditHDR.Text Then

            Response.Write("<script language=""javascript"">alert('Cannot Proceed! AP is not yet balance!');</script>")

        Else
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            Dim objCommand As New SqlCommand("Inv_PayVoucherDTL_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@pv_id", lblPVID.Text)
            objConnection.Open()
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            If Session("company_code") = "FIXUS" Then

                SetEndPopup("trx_cv_print_fixus?code=" & lblPVID.Text & _
                                    " &id=" & Request("id") & _
                                    " &formaction=" & "Print")
            Else
                SetEndPopup("trx_cv_print?code=" & lblPVID.Text & _
                                    " &id=" & Request("id") & _
                                    " &formaction=" & "Print")
            End If


            objReader.Close()
            objConnection.Close()
        End If

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_payvoucherdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = False
        panelPOForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub btnX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX2.Click
        Response.Redirect("inv_payvoucherdtl_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = False
        panelPOForm.Visible = False
        panelSuccess.Visible = False
        panelInfo.Visible = False
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
                lblValidate.Visible = False
                panelGrid.Visible = True

                'reset and rebind       
                DataGrid.SelectedIndex = -1
                GridBind()
                DisplayHeader()
                txtPageNo.Text = 1

            Else
                'notify unsucessful and the reason
                panelSuccess.Visible = False
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
        Dim objCommand As New SqlCommand("Inv_PayVoucher_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@voucher_date", calDate.SelectedDate)
        objCommand.Parameters.Add("@due_date", calDueDate.SelectedDate)
        objCommand.Parameters.Add("@debit", lblDebitHDR.Text)
        objCommand.Parameters.Add("@credit", lblCreditHDR.Text)
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@payable_amount", lblPayable.Text)

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
        Dim objCommand As New SqlCommand("Inv_PayVoucher_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@so_no", txtSONo.Text)
        objCommand.Parameters.Add("@customer", lblCustomerCode.Text)
        objCommand.Parameters.Add("@voucher_date", calDate.SelectedDate)
        objCommand.Parameters.Add("@due_date", calDueDate.SelectedDate)
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)
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
                                        "Ref# " + lblID.Text, _
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

    Private Sub calDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDate.DateChanged
        SaveHeaderClick()
    End Sub

    Private Sub calDueDate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDueDate.DateChanged
        SaveHeaderClick()
    End Sub

    Private Sub ddlVendor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlVendor.SelectedIndexChanged
        SaveHeaderClick()
    End Sub

    Private Sub txtParticulars_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParticulars.TextChanged
        SaveHeaderClick()
    End Sub

    Private Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlStatus.SelectedIndexChanged
        SaveHeaderClick()
    End Sub

    Private Sub btnReplicateImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnReplicateImg.Click
        Dim SaveInput As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PayVoucherReplicate_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@particularshdr", txtParticulars.Text)
        objCommand.Parameters.Add("@pv_id", lblPVID.Text)
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
                                        "inv_prequests_list", _
                                        "Ref# " + lblID.Text, _
                                        Request("id"), _
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

        Response.Redirect("inv_payvoucherdtl_list?&id=" & Session("objNewID") & "&sys_table=inv_payvoucher_list")
        panelSuccess.Visible = True
    End Sub

    Private Sub ddlVendorPO_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlVendorPO.SelectedIndexChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False
        Refresh_AmountToPay()
    End Sub
    Private Sub Refresh_AmountToPay()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Inv_PRequests_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", ddlVendorPO.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtAmountToPay.Text = Trim(objReader("owing"))
        lblPONo.Text = Trim(objReader("pr_code"))
        lblVendorSINo.Text = Trim(objReader("vendor_si_no"))
        lblPOBalance.Text = Trim(objReader("owing_show"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub txtSONo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSONo.TextChanged
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Inv_PayVoucher_SONoGet", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@so_no", txtSONo.Text)
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

        SaveHeaderClick()
    End Sub

    Private Sub chbIsCustomer_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbIsCustomer.CheckedChanged
        If chbIsCustomer.Checked = True Then
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            Dim objCommand As New SqlCommand("Ref_CostCenter_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@Session_username", Session("username"))
            objCommand.Parameters.Add("@is_customer", 1)

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            ddlCostCenter.DataSource = objReader
            ddlCostCenter.DataValueField = "code"
            ddlCostCenter.DataTextField = "name"
            ddlCostCenter.DataBind()
            ddlCostCenter.Items.Insert(0, "")
            ddlCostCenter.SelectedIndex = 0
            objReader.Close()

            objConnection.Close()
        Else
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            Dim objCommand As New SqlCommand("Ref_CostCenter_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@Session_username", Session("username"))
            objCommand.Parameters.Add("@is_customer", 0)

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            ddlCostCenter.DataSource = objReader
            ddlCostCenter.DataValueField = "code"
            ddlCostCenter.DataTextField = "name"
            ddlCostCenter.DataBind()
            ddlCostCenter.Items.Insert(0, "")
            ddlCostCenter.SelectedIndex = 0
            objReader.Close()

            objConnection.Close()
        End If
    End Sub
End Class

