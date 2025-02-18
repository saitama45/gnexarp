
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState


Public Class ref_clienttrail_list
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
    Protected WithEvents btnAddRecord As System.Web.UI.WebControls.Button
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents txtFormAction As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents ddlRecordsPerPage As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents btnPostTrx As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancelTrx As System.Web.UI.WebControls.Button
    Protected WithEvents btnUnpostTrx As System.Web.UI.WebControls.Button
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents lblID As System.Web.UI.WebControls.Label
    Protected WithEvents ddlSKU As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtBegBalcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBegBalpcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDelcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDelpcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAdjpcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBOpcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBOreason As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEndBalcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEndBalpcs As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDOOS As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtJanExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFebExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMarExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAprExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMayExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtJunExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtJulExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAugExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSepExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtOctExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNovExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDecExpiry As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRemarks As System.Web.UI.WebControls.TextBox
    Protected WithEvents hlViewFullHistory As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlViewFullTrail As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lblISHDRID As System.Web.UI.WebControls.Label
    Protected WithEvents lblClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientID As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientOutlet As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientOutletID As System.Web.UI.WebControls.Label
    Protected WithEvents lblDizer As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblCoverFrom As System.Web.UI.WebControls.Label
    Protected WithEvents lblCoverTo As System.Web.UI.WebControls.Label
    Protected WithEvents lblReceivedDate As System.Web.UI.WebControls.Label
    Protected WithEvents txtRemarks2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents panelForm As System.Web.UI.WebControls.Panel
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
    Protected WithEvents lblValidate As System.Web.UI.WebControls.Label
    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents lblUserTab As System.Web.UI.WebControls.Label
    Protected WithEvents lblDashboard As System.Web.UI.WebControls.Label
    Protected WithEvents panelDashboard As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDashboard As System.Web.UI.WebControls.Table
    Protected WithEvents lblAR As System.Web.UI.WebControls.Label
    Protected WithEvents panelAR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblAR As System.Web.UI.WebControls.Table
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
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAmount As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rdoBilling As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents txtGross As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblBillingID As System.Web.UI.WebControls.Label
    Protected WithEvents lblBU As System.Web.UI.WebControls.Label
    Protected WithEvents lblBUID As System.Web.UI.WebControls.Label
    Protected WithEvents lblBSDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblBSNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblBillingCategory As System.Web.UI.WebControls.Label
    Protected WithEvents lblPayoutDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblAddressee As System.Web.UI.WebControls.Label
    Protected WithEvents btnPrint As System.Web.UI.WebControls.Button
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents ddlWhereabout As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtReceivedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents Dropdownlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents calDateReceived As eWorld.UI.CalendarPopup
    Protected WithEvents calDateCommitment As eWorld.UI.CalendarPopup
    Protected WithEvents ddlWhereaboutReason As System.Web.UI.WebControls.DropDownList
    Protected WithEvents calDateLastFollowup As eWorld.UI.CalendarPopup
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblAging As System.Web.UI.WebControls.Label
    Protected WithEvents lblDueDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblDueDays As System.Web.UI.WebControls.Label
    Protected WithEvents ddlLSC As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlBP As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlBranch As System.Web.UI.WebControls.DropDownList
    Protected WithEvents calEffectivityDate As eWorld.UI.CalendarPopup
    Protected WithEvents txtTPayment As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAdminFee As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator5 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtDGA As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator6 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtDCA As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator7 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtOthers As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator8 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblClientCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblMotherClient As System.Web.UI.WebControls.Label
    Protected WithEvents lblMotherCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblClientAccountNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPaymentTerms As System.Web.UI.WebControls.Label
    Protected WithEvents lblAdminFee As System.Web.UI.WebControls.Label
    Protected WithEvents lblDGAFee As System.Web.UI.WebControls.Label
    Protected WithEvents lblDCAFee As System.Web.UI.WebControls.Label
    Protected WithEvents lblOthersFee As System.Web.UI.WebControls.Label
    Protected WithEvents lstLSC As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstBP As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstBranch As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblCTStatus As System.Web.UI.WebControls.Label

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
    Public strStoredProc As String = "ref_clienttrail_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "id"
    Public strKeyField As String = "id"

    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAddRecord.Click

        txtFormAction.Text = "Add"
        lblMode.BackColor = Color.Green

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)
        ClearInputs()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_LSC_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        lstLSC.DataSource = objReader
        lstLSC.DataValueField = "id"
        lstLSC.DataTextField = "name"
        lstLSC.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_BusinessPlatform_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBP.DataSource = objReader
        lstBP.DataValueField = "id"
        lstBP.DataTextField = "name"
        lstBP.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Branch_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objReader = objCommand.ExecuteReader
        lstBranch.DataSource = objReader
        lstBranch.DataValueField = "id"
        lstBranch.DataTextField = "name"
        lstBranch.DataBind()
        objReader.Close()

        objConnection.Close()
        SetFocus(lstLSC)

    End Sub

    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientTrail_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")
        lblCTStatus.Text = objReader("status")

        calEffectivityDate.SelectedDate = objReader("effectivity_date")
        calEffectivityDate.VisibleDate = Now

        Dim strLSC As String = objReader("lsc_id")
        Dim strBP As String = objReader("businessplatform_id")
        Dim strBranch As String = objReader("branch_id")
        objReader.Close()

        objCommand = New SqlCommand("Ref_LSC_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstLSC.DataSource = objReader
        lstLSC.DataValueField = "id"
        lstLSC.DataTextField = "name"
        lstLSC.DataBind()
        lstLSC.SelectedIndex = lstLSC.Items.IndexOf(lstLSC.Items.FindByValue(strLSC))
        objReader.Close()

        objCommand = New SqlCommand("Ref_BusinessPlatform_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBP.DataSource = objReader
        lstBP.DataValueField = "id"
        lstBP.DataTextField = "name"
        lstBP.DataBind()
        lstBP.SelectedIndex = lstBP.Items.IndexOf(lstBP.Items.FindByValue(strBP))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Branch_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBranch.DataSource = objReader
        lstBranch.DataValueField = "id"
        lstBranch.DataTextField = "name"
        lstBranch.DataBind()
        lstBranch.SelectedIndex = lstBranch.Items.IndexOf(lstBranch.Items.FindByValue(strBranch))
        objReader.Close()


        If lblCTStatus.Text = "Posted" Then
            Response.Write("<script language=""javascript"">alert('Cannot Proceed! It is already Posted...');</script>")
            panelForm.Visible = False
            btnSave.Visible = False
            btnCancel.Visible = False
            calEffectivityDate.Enabled = False
            lstLSC.Enabled = False
            lstBP.Enabled = False
            lstBranch.Enabled = False
        Else
            btnSave.Visible = True
            calEffectivityDate.Enabled = True
            lstLSC.Enabled = True
            lstBP.Enabled = True
            lstBranch.Enabled = True
        End If

        objConnection.Close()

        SetFocus(lstLSC)

    End Sub

    Private Sub ClearInputs()

        lblID.Text = 0
        SetFocus(lstLSC)

        calEffectivityDate.SelectedDate = Now
        calEffectivityDate.VisibleDate = Now

        calEffectivityDate.Enabled = True
        lstLSC.Enabled = True
        lstBP.Enabled = True
        lstBranch.Enabled = True

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
        Dim objCommand As New SqlCommand("Ref_ClientTrail_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@client_code", lblClientCode.Text)
        objCommand.Parameters.Add("@lsc", lstLSC.SelectedValue)
        objCommand.Parameters.Add("@business_platform", lstBP.SelectedValue)
        objCommand.Parameters.Add("@branch", lstBranch.SelectedValue)
        objCommand.Parameters.Add("@effectivity_date", calEffectivityDate.SelectedDate)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of LSC
            objCommand = New SqlCommand("Ref_LSC_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", lstLSC.SelectedValue)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strLSC As String = objReader("name")
            objReader.Close()

            'get the name of Business Platform
            objCommand = New SqlCommand("Ref_BusinessPlatform_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", lstBP.SelectedValue)
            objReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strBP As String = objReader("name")
            objReader.Close()

            'get the name of Branch
            objCommand = New SqlCommand("Ref_Branch_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", lstBranch.SelectedValue)
            objReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strBranch As String = objReader("name")
            objReader.Close()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        "ref_client_list", _
                                        "Client Code: " + lblClientCode.Text + " > LSC: " + strLSC + " > BusinessPlatform: " + strBP + " > Branch: " + strBranch + " > EffectivityDate: " + calEffectivityDate.SelectedDate, _
                                        lblClientCode.Text, _
                                        objNewID.Value)

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
        Dim objCommand As New SqlCommand("Ref_ClientTrail_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@client_code", lblClientCode.Text)
        objCommand.Parameters.Add("@effectivity_date", calEffectivityDate.SelectedDate)

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
        Dim aColumns() As String = {"id", _
                                    "client_code", _
                                    "status", _
                                    "bu", _
                                    "lsc_code", _
                                    "business_platform", _
                                    "branch", _
                                    "effectivity_date", _
                                    "approved_by", _
                                    "approved_date", _
                                    "posted_by", _
                                    "posted_date", _
                                    "created_by", _
                                    "created_date", _
                                    "modified_reason", _
                                    "modified_by", _
                                    "modified_date"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"ID", _
                                    "Client Code", _
                                    "Status", _
                                    "BU", _
                                    "LSC / MPC", _
                                    "Business Platform", _
                                    "Branch", _
                                    "Effectivity Date", _
                                    "Approved By", _
                                    "Approved Date", _
                                    "Posted By", _
                                    "Posted Date", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified Reason", _
                                    "Modified By", _
                                    "Modified Date"}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "DS", _
                                    "", _
                                    "D", _
                                    "", _
                                    "D", _
                                    "", _
                                    "D", _
                                    "", _
                                    "", _
                                    "", _
                                    "D"}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"id", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
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

        ibcms.Sys_Class.DataGrid_ItemCreated_v2(e, _
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


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load

        Sys_Class.DisplaySideBarMenu(lblUser, _
                                    lblUserTab, _
                                    Session("group"), _
                                    lblDashboard, _
                                    panelDashboard, _
                                    tblDashboard, _
                                    lblMyAccount, _
                                    panelMyAccount, _
                                    tblMyAccount, _
                                    lblAR, _
                                    panelAR, _
                                    tblAR, _
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
                                    tblSetting)

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage.aspx")
        End If

        'is the user allowed to add record?
        If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
            'disable the add button
            btnAddRecord.Enabled = False
        End If

        If Not Page.IsPostBack Then
            DisplayHeader()
            GridBind()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False

            btnAddRecord.Text = "Add Transfer Trail"
        End If

    End Sub

    Sub GridBind()

        'this condition must only run once. initialize session(module) variables
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay_v2(DataGrid, _
                                        strStoredProc, _
                                        Session("username"), _
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
                                        lblClientCode.Text)

    End Sub
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        ibcms.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
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
        If txtSearch.Text = "" Then
            lblPageRecordCount.Text = lblPageRecordCount.Text & " *Please enter a search key."
            Exit Sub
        End If

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnCancel.Click

        panelForm.Visible = False

        panelInfo.Visible = True
        panelSuccess.Visible = False

        'reset the selected index in case of edit modes and rebind
        DataGrid.SelectedIndex = -1
        GridBind()
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

        'always hide, but show later in this module
        lblMessage.Visible = False

        If Not Page.IsValid Then
            Exit Sub
        End If

        'validate the inputs vs. table records
        Dim strValidateInput As String = ValidateInput()

        'is the validation 
        If strValidateInput = "ok" Then
            'then save the inputs
            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes
                lblMessage.Visible = True

                If txtFormAction.Text = "Add" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblMessage.Visible = False

                    'Session("last_isdtl_sku") = ddlSKU.SelectedValue
                    ClearInputs()
                    DisplayHeader()

                ElseIf txtFormAction.Text = "Edit" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblMessage.Visible = False

                    'reset and rebind                    
                    GridBind()

                ElseIf txtFormAction.Text = "Approve" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblMessage.Visible = False

                    'reset and rebind                    
                    GridBind()
                    DisplayHeader()

                ElseIf txtFormAction.Text = "Post" Then
                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblMessage.Visible = False

                    'reset and rebind                    
                    GridBind()
                    DisplayHeader()
                End If

            Else
                'notify unsucessful and the reason
                lblMessage.Visible = True
                lblMessage.Text = strSaveInput
            End If

        Else
            'notify user and reason of invalidation
            panelSuccess.Visible = False
            lblMessage.Visible = True
            lblMessage.Text = strValidateInput
        End If

    End Sub


    Private Sub DataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.EditCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        txtFormAction.Text = "Edit"
        lblMode.BackColor = Color.Orange

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        ReadyEdit() 'retrive and fill the text box for editing
    End Sub

    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Sub DisplayHeader()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Clients_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("client_code"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblStatus.Text = objReader("status")
        lblClientCode.Text = objReader("client_code")
        lblBU.Text = objReader("bu_name")
        lblBUID.Text = objReader("bu_id")
        lblMotherClient.Text = objReader("main_client_name")
        lblMotherCode.Text = objReader("mother_code")
        lblClient.Text = objReader("name")
        lblClientAccountNo.Text = objReader("account_no")
        lblPaymentTerms.Text = objReader("payment_terms")
        lblAdminFee.Text = objReader("admin_fee")
        lblDGAFee.Text = objReader("dga_percent")
        lblDCAFee.Text = objReader("dca_percent")
        lblOthersFee.Text = objReader("others_percent")
        txtRemarks.Text = objReader("remarks")

        objReader.Close()
        objConnection.Close()

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory.aspx?sys_table=" & "ref_client_list" & "&mode=1&ID=" & lblClientCode.Text

    End Sub

    Private Sub btnBackToList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBackToList.Click
        Response.Redirect("ref_client_list.aspx")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        If e.CommandName = "Approve" Then
            'mark the selected item 
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Approve"
            lblMode.BackColor = Color.Blue

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)

            ReadyApprove() 'retrive and fill the text box for approval
        ElseIf e.CommandName = "Post" Then
            'mark the selected item 
            DataGrid.SelectedIndex = e.Item.ItemIndex

            txtFormAction.Text = "Post"
            lblMode.BackColor = Color.YellowGreen

            'show the Form panel
            Sys_Class.ReadyForm(panelForm, _
                                    panelSuccess, _
                                    panelInfo, _
                                    lblMessage, _
                                    ValidationSummary1, _
                                    lblMode, _
                                    txtFormAction)

            ReadyPost() 'retrive and fill the text box for posting
        End If
    End Sub
    Private Sub ReadyApprove()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientTrail_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")
        lblCTStatus.Text = objReader("status")

        calEffectivityDate.SelectedDate = objReader("effectivity_date")
        calEffectivityDate.VisibleDate = Now

        Dim strLSC As String = objReader("lsc_id")
        Dim strBP As String = objReader("businessplatform_id")
        Dim strBranch As String = objReader("branch_id")
        objReader.Close()

        objCommand = New SqlCommand("Ref_LSC_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstLSC.DataSource = objReader
        lstLSC.DataValueField = "id"
        lstLSC.DataTextField = "name"
        lstLSC.DataBind()
        lstLSC.SelectedIndex = lstLSC.Items.IndexOf(lstLSC.Items.FindByValue(strLSC))
        objReader.Close()

        objCommand = New SqlCommand("Ref_BusinessPlatform_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBP.DataSource = objReader
        lstBP.DataValueField = "id"
        lstBP.DataTextField = "name"
        lstBP.DataBind()
        lstBP.SelectedIndex = lstBP.Items.IndexOf(lstBP.Items.FindByValue(strBP))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Branch_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBranch.DataSource = objReader
        lstBranch.DataValueField = "id"
        lstBranch.DataTextField = "name"
        lstBranch.DataBind()
        lstBranch.SelectedIndex = lstBranch.Items.IndexOf(lstBranch.Items.FindByValue(strBranch))
        objReader.Close()

        If lblCTStatus.Text = "For Approval" Then
            btnSave.Text = "Approve"
            btnSave.Visible = True
            calEffectivityDate.Enabled = False
            lstLSC.Enabled = False
            lstBP.Enabled = False
            lstBranch.Enabled = False
        Else
            Response.Write("<script language=""javascript"">alert('Cannot Proceed! Check the status first...');</script>")
            panelForm.Visible = False
            btnSave.Visible = False
            btnCancel.Visible = False
            calEffectivityDate.Enabled = False
            lstLSC.Enabled = False
            lstBP.Enabled = False
            lstBranch.Enabled = False
        End If

        objConnection.Close()

        SetFocus(lstLSC)

    End Sub
    Private Sub ReadyPost()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_ClientTrail_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = objReader("id")
        lblCTStatus.Text = objReader("status")

        calEffectivityDate.SelectedDate = objReader("effectivity_date")
        calEffectivityDate.VisibleDate = Now

        Dim strLSC As String = objReader("lsc_id")
        Dim strBP As String = objReader("businessplatform_id")
        Dim strBranch As String = objReader("branch_id")
        objReader.Close()

        objCommand = New SqlCommand("Ref_LSC_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstLSC.DataSource = objReader
        lstLSC.DataValueField = "id"
        lstLSC.DataTextField = "name"
        lstLSC.DataBind()
        lstLSC.SelectedIndex = lstLSC.Items.IndexOf(lstLSC.Items.FindByValue(strLSC))
        objReader.Close()

        objCommand = New SqlCommand("Ref_BusinessPlatform_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBP.DataSource = objReader
        lstBP.DataValueField = "id"
        lstBP.DataTextField = "name"
        lstBP.DataBind()
        lstBP.SelectedIndex = lstBP.Items.IndexOf(lstBP.Items.FindByValue(strBP))
        objReader.Close()

        objCommand = New SqlCommand("Ref_Branch_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        lstBranch.DataSource = objReader
        lstBranch.DataValueField = "id"
        lstBranch.DataTextField = "name"
        lstBranch.DataBind()
        lstBranch.SelectedIndex = lstBranch.Items.IndexOf(lstBranch.Items.FindByValue(strBranch))
        objReader.Close()

        btnSave.Text = "Post"
        btnSave.Visible = True
        calEffectivityDate.Enabled = False
        lstLSC.Enabled = False
        lstBP.Enabled = False
        lstBranch.Enabled = False

        If lblCTStatus.Text = "For Posting" Then
            btnSave.Text = "Post"
            btnSave.Visible = True
            calEffectivityDate.Enabled = False
            lstLSC.Enabled = False
            lstBP.Enabled = False
            lstBranch.Enabled = False
        Else
            Response.Write("<script language=""javascript"">alert('Cannot Proceed! Check the status first...');</script>")
            panelForm.Visible = False
            btnSave.Visible = False
            btnCancel.Visible = False
            calEffectivityDate.Enabled = False
            lstLSC.Enabled = False
            lstBP.Enabled = False
            lstBranch.Enabled = False
        End If

        objConnection.Close()

        SetFocus(lstLSC)

    End Sub
End Class

