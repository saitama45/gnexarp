
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_receivingdtl_nonpob
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
    Protected WithEvents btnPrint As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnBackToList As System.Web.UI.WebControls.Button
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPRRefNo As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorName As System.Web.UI.WebControls.Label
    Protected WithEvents lblRequestedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblApprovedDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblCancelledBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblCancelledDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblFulfilledBy As System.Web.UI.WebControls.Label
    Protected WithEvents lblFulfilledDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblItem As System.Web.UI.WebControls.Label
    Protected WithEvents lblPOQty As System.Web.UI.WebControls.Label
    Protected WithEvents lblPOCost As System.Web.UI.WebControls.Label
    Protected WithEvents txtActualQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFreeQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDetailedReason As System.Web.UI.WebControls.TextBox
    Protected WithEvents calReceivedDate As eWorld.UI.CalendarPopup
    Protected WithEvents calExpirationDate As eWorld.UI.CalendarPopup
    Protected WithEvents lblEmail As System.Web.UI.WebControls.Label
    Protected WithEvents lblTerms As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalCost As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscount As System.Web.UI.WebControls.Label
    Protected WithEvents lblDiscountedAmount As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalPayable As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetPayable As System.Web.UI.WebControls.Label
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnNoVariance As System.Web.UI.WebControls.LinkButton
    Protected WithEvents ddlWarehouse As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblSelectWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblIsPO As System.Web.UI.WebControls.Label
    Protected WithEvents btnPrintWOPO As System.Web.UI.WebControls.LinkButton
    Protected WithEvents panelRPO As System.Web.UI.WebControls.Panel
    Protected WithEvents panelNPO As System.Web.UI.WebControls.Panel
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents calPODate As eWorld.UI.CalendarPopup
    Protected WithEvents ddlVendor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtRequestedBy As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDiscount As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnPrevItem As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnNextItem As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnPrintWOPOImg As System.Web.UI.WebControls.ImageButton


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
    Public strStoredProc As String = "inv_receivingdtl_list"
    Public strSubMenuName As String = "inv_receivingdtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strRawMats As String = objReader("rm_code")

        Dim bolChangeable As Boolean = lblStatus.Text = "PENDING"

        If Session("group") = "ADMIN" Then

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))

                txtFreeQty.Text = Trim(objReader("free_qty"))

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                objReader.Close()
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
                calReceivedDate.Enabled = True

                txtBarcode.Text = Trim(objReader("barcode"))
                txtBarcode.Enabled = True

                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = True

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = True

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = True

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = True

                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                ddlRawMats.Enabled = True
                objReader.Close()
            End If

        Else

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = bolChangeable

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If            
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = bolChangeable

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = bolChangeable

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = bolChangeable
                objReader.Close()

                btnSave.Visible = bolChangeable
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = bolChangeable

                txtBarcode.Text = Trim(objReader("barcode"))
                txtBarcode.Enabled = bolChangeable

                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = bolChangeable

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = bolChangeable

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = bolChangeable

                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                ddlRawMats.Enabled = bolChangeable
                objReader.Close()
                btnSave.Visible = bolChangeable
            End If

        End If

        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

        SetFocus(txtActualQty)


    End Sub
    Private Sub ReadyDelete()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strRawMats As String = objReader("rm_code")

        Dim bolChangeable As Boolean = lblStatus.Text = "PENDING"

        If Session("group") = "ADMIN" Then

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))

                txtFreeQty.Text = Trim(objReader("free_qty"))

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                objReader.Close()
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = False

                txtBarcode.Text = Trim(objReader("barcode"))
                txtBarcode.Enabled = False

                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = False

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = False

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = False

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = False

                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                ddlRawMats.Enabled = False
                objReader.Close()
            End If

        Else

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = False

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If            
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = False

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = False

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = False
                objReader.Close()

            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = False

                txtBarcode.Text = Trim(objReader("barcode"))
                txtBarcode.Enabled = False

                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = False

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = False

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = False

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = False
                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                ddlRawMats.Enabled = False
                objReader.Close()

            End If

        End If

        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

        SetFocus(txtActualQty)


    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReceivingItems_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        If panelNPO.Visible = True And txtFormAction.Text = "Edit" Then
            objCommand.Parameters.Add("@FormAction", "EditNPO")

        Else
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        End If

        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)

        If panelNPO.Visible = True Then
            objCommand.Parameters.Add("@cost", txtCost.Text)
        Else
            objCommand.Parameters.Add("@cost", 0)
        End If

        objCommand.Parameters.Add("@ReceivedDate", calReceivedDate.SelectedDate)
        'objCommand.Parameters.Add("@ExpirationDate", calExpirationDate.SelectedDate)
        objCommand.Parameters.Add("@ActualQty", txtActualQty.Text)
        objCommand.Parameters.Add("@FreeQty", txtFreeQty.Text)
        objCommand.Parameters.Add("@DetailedReason", txtDetailedReason.Text)
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
                                        "ReceivedDate: " + calReceivedDate.SelectedDate + " > ActualQty: " + txtActualQty.Text + " > FreeQty: " + txtFreeQty.Text + " > Notes: " + txtDetailedReason.Text, _
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


    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReceivingItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@warehouse", lblWarehouse.Text)
        objCommand.Parameters.Add("@po_num", lblPRCode.Text)
        objCommand.Parameters.Add("@received_date", calReceivedDate.SelectedDate)
        objCommand.Parameters.Add("@actual_qty", txtActualQty.Text)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@rm_code", ddlRawMats.SelectedValue)

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
                                    "", _
                                    "rm_code", _
                                    "rm_name", _
                                    "uom", _
                                    "", _
                                    "cost", _
                                    "total_cost", _
                                    "actual_qty", _
                                    "free_qty", _
                                    "total_payable", _
                                    "detailed_reason", _
                                    "received_date", _
                                    "received_by"}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "PO #", _
                                    "Item Code", _
                                    "Item", _
                                    "UOM", _
                                    "P.O. Qty", _
                                    "Cost", _
                                    "Total Cost", _
                                    "Received Qty", _
                                    "Free Qty Received", _
                                    "Total Payable", _
                                    "Notes", _
                                    "Received Date", _
                                    "Received By"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "", _
                                    "_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "D", _
                                    "DS", _
                                    ""}


        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
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

        ems.Sys_Class.DataGrid_ItemCreated_v2(e, _
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
            txtSearch.Visible = False
            btnSearch.Visible = False

            If lblIsPO.Text = "True" Then

                'btnPrint.Visible = True
                btnPrintWOPOImg.Visible = False
                btnAddImg.Visible = False

            Else
                'btnPrint.Visible = False
                btnPrintWOPOImg.Visible = True
                btnAddImg.Visible = True
               
            End If

            If lblStatus.Text = "RECEIVED" Then
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Visible = False
                btnSaveImg.Visible = False
                btnAddImg.Visible = False

            Else
                lblSelectWarehouse.Visible = True
                ddlWarehouse.Visible = True
                btnSaveImg.Visible = True
                btnAddImg.Visible = True

            End If

            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            'the stored procedure and parameters
            Dim objCommand As New SqlCommand("Inv_PRequests_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@Session_username", Session("username"))

            'open the connection and execute the reader 
            objConnection.Open()
            Dim objReader As SqlDataReader = objCommand.ExecuteReader

            'read and fill the boxes
            objReader.Read()

            Dim strWarehouse = Trim(objReader("warehouse"))

            objReader.Close()

            objCommand = New SqlCommand("Ref_Warehouse_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@Session_username", Session("username"))
            objReader = objCommand.ExecuteReader
            ddlWarehouse.DataSource = objReader
            ddlWarehouse.DataValueField = "code"
            ddlWarehouse.DataTextField = "code"
            ddlWarehouse.DataBind()
            ddlWarehouse.Items.Insert(0, "")
            ddlWarehouse.SelectedIndex = 0
            objReader.Close()

            objConnection.Close()

            ddlWarehouse.SelectedIndex = ddlWarehouse.Items.IndexOf(ddlWarehouse.Items.FindByValue(strWarehouse.ToString))

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddImg.Visible = False
                btnsaveimg.Visible = False
                'btnPrint.Visible = False
                btnPrintWOPOImg.Visible = False
                'btnNoVariance.Visible = False
                lblSelectWarehouse.Visible = False
                ddlWarehouse.Visible = False
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
                                    lblPRCode.Text)

    End Sub
    Private Sub DataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid.ItemDataBound
        ems.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
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

                If txtFormAction.Text = "Add" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    ReadyAdd()
                    'reset and rebind       
                    txtPageNo.Text = 1
                    DisplayHeader()
                    GridBind()

                ElseIf txtFormAction.Text = "Edit" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    'panelForm.Visible = False
                    lblValidate.Visible = False
                    'panelGrid.Visible = True
                    Refresh_Next()

                    'reset and rebind       
                    txtPageNo.Text = 1
                    DisplayHeader()
                    GridBind()

                ElseIf txtFormAction.Text = "EditNPO" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    'panelForm.Visible = False
                    lblValidate.Visible = False
                    'panelGrid.Visible = True

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

                    'reset and rebind       
                    txtPageNo.Text = 1
                    DisplayHeader()
                    GridBind()

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
        lblID.Visible = True
        btnPrevItem.Visible = True
        btnNextItem.Visible = True
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

    End Sub

    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.DeleteCommand

        If lblIsPO.Text = "False" Then

            If lblStatus.Text = "PENDING" Then
                DataGrid.SelectedIndex = e.Item.ItemIndex

                txtFormAction.Text = "Delete"
                lblMode.ForeColor = Color.Red
                btnPrevItem.Visible = False
                btnNextItem.Visible = False
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
                btnSave.Visible = False
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If

        Else
            Response.Write("<script language=""javascript"">alert('Cannot Proceed! Deleting record is for NON PO only!');</script>")
        End If

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
        Dim objCommand As New SqlCommand("Inv_Receiving_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strVendors As String = objReader("vendor_code")
        Dim bolChangeable As Boolean = objReader("status") = "PENDING"

        'lblPRRefNo.Text = objReader("id")
        lblStatus.Text = objReader("status")
        lblPRCode.Text = objReader("pr_code")

        lblWarehouse.Text = objReader("warehouse")
        lblIsPO.Text = objReader("isPO")

        lblPRDate.Text = objReader("pr_date")
        calPODate.SelectedDate = objReader("pr_date")
        calPODate.VisibleDate = DateTime.UtcNow
        calPODate.Enabled = bolChangeable

        lblVendorCode.Text = objReader("vendor_code")
        lblVendorName.Text = objReader("vendor_name")

        lblRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Text = objReader("requested_by")
        txtRequestedBy.Enabled = bolChangeable

        'lblDept.Text = objReader("department")
        lblTerms.Text = objReader("terms")
        txtTerms.Text = objReader("terms")
        txtTerms.Enabled = bolChangeable

        lblTotalCost.Text = objReader("total_cost")

        lblDiscount.Text = objReader("discount_show")
        txtDiscount.Text = objReader("discount_edit")
        txtDiscount.Enabled = bolChangeable

        lblDiscountedAmount.Text = objReader("discounted_amount")

        lblNetAmount.Text = objReader("net_amount")
        lblNetPayable.Text = objReader("net_payable")

        txtNote.Text = objReader("note")
        txtNote.Enabled = bolChangeable

        objReader.Close()

        objCommand = New SqlCommand("Ref_Vendors_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlVendor.DataSource = objReader
        ddlVendor.DataValueField = "code"
        ddlVendor.DataTextField = "name"
        ddlVendor.DataBind()
        ddlVendor.Enabled = bolChangeable
        objReader.Close()

        objConnection.Close()

        ddlVendor.SelectedIndex = ddlVendor.Items.IndexOf(ddlVendor.Items.FindByValue(strVendors.ToString))

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_receiving_nonpob")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_receiving_form?code=" & lblPRCode.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")

        objReader.Close()
        objConnection.Close()

    End Sub
    Private Sub btnPrintWOPOImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrintWOPOImg.Click
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_receivingWOPO_form?code=" & lblPRCode.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_receivingdtl_nonpob?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
    End Sub

    Private Sub btnNoVariance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoVariance.Click

        SaveNoVariance()
        panelSuccess.Visible = True
    End Sub
    Private Function SaveNoVariance()
        SaveNoVariance = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReceivingNoVariance_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of UOM
            objCommand = New SqlCommand("Inv_PRItems_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strVendorCode As String = objReader("code")
            objReader.Close()

            'save to audit trail 
            Sys_Class.MutliSaveToAuditTrail(Session("username"), _
                                        lblPRCode.Text, _
                                        "Edit", _
                                        Request("sys_table"), _
                                        "ReceivedDate: " + DateTime.UtcNow + " > ActualQty: " + txtActualQty.Text + " > FreeQty: " + txtFreeQty.Text + " > DetailedReason: " + txtDetailedReason.Text, _
                                        Request("id"), _
                                        0)

        Catch ex As Exception
            'in case of error
            If txtFormAction.Text = "Delete" Then
                SaveNoVariance = "Delete was not successful.<br> This record is being referenced by other master file/s or transaction/s."
            Else
                SaveNoVariance = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End If
        Finally

            objConnection.Close()
        End Try

        panelSuccess.Visible = True
        panelInfo.Visible = False
        panelForm.Visible = False
        lblValidate.Visible = False
        panelGrid.Visible = True

        'reset and rebind       
        txtPageNo.Text = 1
        DisplayHeader()
        GridBind()
    End Function

    Private Sub ddlWarehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlWarehouse.SelectedIndexChanged
        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        Dim SaveInput As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_DDLWarehouse_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@warehouse", ddlWarehouse.SelectedValue)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        Request("inv_prequests_list"), _
                                        "Warehouse: " + ddlWarehouse.SelectedValue + " > PRCode: " + lblPRCode.Text, _
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

        panelInfo.Visible = False
        panelSuccess.Visible = False
        DisplayHeader()
        btnAddImg.Visible = True
        SaveHeaderClick()

    End Sub


    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click
        If lblWarehouse.Text = "" Then
            lblValidate.Text = "Please select warehouse first."
            panelInfo.Visible = True
        Else
            If lblStatus.Text = "PENDING" Then
                txtFormAction.Text = "Add"
                lblMode.ForeColor = Color.Green
                'panelGrid.Visible = False
                panelNPO.Visible = True
                btnPrevItem.Visible = False
                btnNextItem.Visible = False
                ClearInputs()
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
                    'panelGrid.Visible = False
                    panelNPO.Visible = True
                    ClearInputs()
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
                    Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
                End If
            End If
        End If
    End Sub
    Private Sub ReadyAdd()

        ClearInputs()
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_Items_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        'open the connection and execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        ddlRawMats.DataSource = objReader
        ddlRawMats.DataValueField = "code"
        ddlRawMats.DataTextField = "name"
        ddlRawMats.DataBind()
        ddlRawMats.Items.Insert(0, "")
        ddlRawMats.SelectedIndex = 0
        objReader.Close()
        objConnection.Close()

        SetFocus(txtActualQty)


    End Sub

    Private Sub ClearInputs()

        txtBarcode.Text = ""
        txtBarcode.Enabled = True

        ddlRawMats.Enabled = True

        txtCost.Text = 0
        txtCost.Enabled = True

        calReceivedDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
        calReceivedDate.Enabled = True

        txtActualQty.Text = 0
        txtActualQty.Enabled = True

        txtFreeQty.Text = 0
        txtFreeQty.Enabled = True

        txtDetailedReason.Text = ""
        txtDetailedReason.Enabled = True
    End Sub

    Private Sub ddlRawMats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRawMats.SelectedIndexChanged
        Refresh_Cost()
    End Sub
    Private Sub Refresh_Cost()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", 999)
        objCommand.Parameters.Add("@code", ddlRawMats.SelectedValue)
        objCommand.Parameters.Add("@customer", "")
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtBarcode.Text = Trim(objReader("barcode"))
        txtCost.Text = Trim(objReader("cost"))

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnNextItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNextItem.Click
        Refresh_Next()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False
    End Sub

    Private Sub btnPrevItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevItem.Click
        Refresh_Prev()
        panelSuccess.Visible = False
        panelInfo.Visible = False
        lblValidate.Visible = False
    End Sub
    Private Sub Refresh_Next()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReceivedItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)        
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@mode", "Next")

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strRawMats As String = objReader("rm_code")

        Dim bolChangeable As Boolean = lblStatus.Text = "PENDING"

        If Session("group") = "ADMIN" Then

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblID.Text = Trim(objReader("id"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))

                txtFreeQty.Text = Trim(objReader("free_qty"))

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                objReader.Close()
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                calReceivedDate.SelectedDate = objReader("received_date")

                txtBarcode.Text = Trim(objReader("barcode"))

                txtCost.Text = Trim(objReader("cost"))

                txtActualQty.Text = Trim(objReader("actual_qty"))

                txtFreeQty.Text = Trim(objReader("free_qty"))

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))

                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                objReader.Close()
            End If

        Else

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = bolChangeable

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If            
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = bolChangeable

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = bolChangeable

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = bolChangeable
                objReader.Close()

                btnSave.Visible = bolChangeable
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = bolChangeable

                txtBarcode.Text = Trim(objReader("barcode"))
                txtBarcode.Enabled = bolChangeable

                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = bolChangeable

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = bolChangeable

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = bolChangeable
                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                ddlRawMats.Enabled = bolChangeable
                objReader.Close()
                btnSave.Visible = bolChangeable
            End If

        End If

        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

        SetFocus(txtActualQty)
    End Sub
    Private Sub Refresh_Prev()
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ReceivedItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", lblID.Text)        
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@mode", "Prev")

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strRawMats As String = objReader("rm_code")

        Dim bolChangeable As Boolean = lblStatus.Text = "PENDING"

        If Session("group") = "ADMIN" Then

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))

                txtFreeQty.Text = Trim(objReader("free_qty"))

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                objReader.Close()
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")

                txtBarcode.Text = Trim(objReader("barcode"))

                txtCost.Text = Trim(objReader("cost"))

                txtActualQty.Text = Trim(objReader("actual_qty"))

                txtFreeQty.Text = Trim(objReader("free_qty"))

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                objReader.Close()
            End If

        Else

            If lblIsPO.Text = "True" Then
                panelRPO.Visible = True
                panelNPO.Visible = False

                lblID.Text = Trim(objReader("id"))
                lblItem.Text = Trim(objReader("rm_code_name"))
                lblPOQty.Text = Trim(objReader("qty"))
                lblPOCost.Text = Trim(objReader("cost"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = bolChangeable

                'If Convert.IsDBNull(objReader("expiration_date")) Then
                '    calExpirationDate.SelectedDate = "01/01/1999"
                'Else
                '    calExpirationDate.SelectedDate = objReader("expiration_date")
                'End If            
                'calExpirationDate.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = bolChangeable

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = bolChangeable

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = bolChangeable
                objReader.Close()

                btnSave.Visible = bolChangeable
            Else
                panelRPO.Visible = False
                panelNPO.Visible = True

                lblID.Text = Trim(objReader("id"))

                calReceivedDate.SelectedDate = objReader("received_date")
                calReceivedDate.Enabled = bolChangeable

                txtBarcode.Text = Trim(objReader("barcode"))
                txtBarcode.Enabled = bolChangeable

                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = bolChangeable

                txtActualQty.Text = Trim(objReader("actual_qty"))
                txtActualQty.Enabled = bolChangeable

                txtFreeQty.Text = Trim(objReader("free_qty"))
                txtFreeQty.Enabled = bolChangeable

                txtDetailedReason.Text = Trim(objReader("detailed_reason"))
                txtDetailedReason.Enabled = bolChangeable
                objReader.Close()

                objCommand = New SqlCommand("Ref_Items_Get_droplist", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objCommand.Parameters.Add("@Session_username", Session("username"))
                objReader = objCommand.ExecuteReader
                ddlRawMats.DataSource = objReader
                ddlRawMats.DataValueField = "code"
                ddlRawMats.DataTextField = "name"
                ddlRawMats.DataBind()
                ddlRawMats.Enabled = bolChangeable
                objReader.Close()
                btnSave.Visible = bolChangeable
            End If

        End If

        objConnection.Close()

        ddlRawMats.SelectedIndex = ddlRawMats.Items.IndexOf(ddlRawMats.Items.FindByValue(strRawMats.ToString))

        SetFocus(txtActualQty)

    End Sub


    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)


        If e.CommandName = "Open" Then

            If lblStatus.Text = "PENDING" Then

                If lblWarehouse.Text = "" Then
                    lblValidate.Text = "Please select warehouse first."
                    panelInfo.Visible = True
                Else
                    Response.Redirect("inv_itemdtl_list?&id=" & strKeyFieldValue & "&lbl_id=" & Request("id") & "&pr_code=" & lblPRCode.Text & "&sys_table=" & "inv_receiving_list")
                End If
            Else
                btnAddRecord.Visible = False
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If


        End If
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
        Dim objCommand As New SqlCommand("Inv_Receiving_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")        
        objCommand.Parameters.Add("@id", Request("id"))

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
        Dim objCommand As New SqlCommand("Inv_Receiving_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@pr_date", calPODate.SelectedDate)
        objCommand.Parameters.Add("@vendor_code", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@requested_by", txtRequestedBy.Text)
        'objCommand.Parameters.Add("@department", ddlDepartment.SelectedValue)
        objCommand.Parameters.Add("@discount", txtDiscount.Text)
        objCommand.Parameters.Add("@terms", txtTerms.Text)
        objCommand.Parameters.Add("@note", txtNote.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

            'get the name of UOM
            objCommand = New SqlCommand("Ref_Vendors_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@code", ddlVendor.SelectedValue)
            objCommand.Parameters.Add("@Session_username", Session("username"))
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim strVendorCode As String = objReader("code")
            objReader.Close()


            'save to audit trail 
            Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        strSubMenuName, _
                                        "Ref# " + lblID.Text + " > PRDate: " + Date.UtcNow + " > VendorCode: " + strVendorCode + " > RequestedBy: " + txtRequestedBy.Text + " > Dept: " + lblDept.Text + " > Discount: " + txtDiscount.Text + " > Terms: " + txtTerms.Text + " > Note: " + txtNote.Text, _
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
    Private Sub ddlVendor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlVendor.SelectedIndexChanged
        Refresh_Terms()
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub Refresh_Terms()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_Vendors_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@code", ddlVendor.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtTerms.Text = Trim(objReader("terms"))

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub calPODate_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calPODate.DateChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtRequestedBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRequestedBy.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtTerms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerms.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
End Class

