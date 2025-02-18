
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class inv_itemdtl_list
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
    Protected WithEvents panelCost As System.Web.UI.WebControls.Panel
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
    Protected WithEvents btnPrevItem As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnNextItem As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lblItem As System.Web.UI.WebControls.Label
    Protected WithEvents txtSerial As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEngineNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFrameNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtColor As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtModelNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtChasisNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRemarks As System.Web.UI.WebControls.TextBox
    Protected WithEvents calReceivedDate As eWorld.UI.CalendarPopup
    Protected WithEvents calExpiryDate As eWorld.UI.CalendarPopup
    Protected WithEvents lblPRCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblIsPO As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRDate As System.Web.UI.WebControls.Label
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarehouse As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorName As System.Web.UI.WebControls.Label
    Protected WithEvents lblVendorCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblItemName As System.Web.UI.WebControls.Label
    Protected WithEvents lblItemCode As System.Web.UI.WebControls.Label
    Protected WithEvents lblPOQty As System.Web.UI.WebControls.Label    
    Protected WithEvents lblTotalReceivedQty As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalFreeQty As System.Web.UI.WebControls.Label
    Protected WithEvents lblNetPayable As System.Web.UI.WebControls.Label
    Protected WithEvents txtNote As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPO_Qty As System.Web.UI.WebControls.Label
    Protected WithEvents lblPO_Date As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalReceived_Qty As System.Web.UI.WebControls.Label
    Protected WithEvents chbNoExpiryDate As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtActualQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFreeQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblPRID As System.Web.UI.WebControls.Label
    Protected WithEvents lblPRStatus As System.Web.UI.WebControls.Label

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
    Public strStoredProc As String = "inv_itemdtl_list"
    Public strSubMenuName As String = "inv_itemdtl_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "pr_code"
    Public strKeyField As String = "id"

    Private Sub ReadyEdit()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ItemDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = lblStatus.Text <> "RECEIVED"

        If Session("group") = "ADMIN" Then

            lblID.Text = Trim(objReader("id"))
            lblItem.Text = Trim(objReader("rm_code"))
            lblPO_Qty.Text = lblPOQty.Text
            lblPO_Date.Text = lblPRDate.Text

            txtSerial.Text = Trim(objReader("serial"))
            txtSerial.Enabled = True

            txtEngineNo.Text = Trim(objReader("engine_no"))
            txtEngineNo.Enabled = True

            txtFrameNo.Text = Trim(objReader("frame_no"))
            txtFrameNo.Enabled = True

            txtColor.Text = Trim(objReader("color"))
            txtColor.Enabled = True

            txtModelNo.Text = Trim(objReader("model_no"))
            txtModelNo.Enabled = True

            txtChasisNo.Text = Trim(objReader("chasis_no"))
            txtChasisNo.Enabled = True

            txtRemarks.Text = Trim(objReader("note"))
            txtRemarks.Enabled = True

            calReceivedDate.SelectedDate = Trim(objReader("received_date"))
            calReceivedDate.Enabled = True

            txtActualQty.Text = Trim(objReader("actual_qty"))
            txtActualQty.Enabled = True

            txtFreeQty.Text = Trim(objReader("free_qty"))
            txtFreeQty.Enabled = True

            If Trim(objReader("expiry_date")) = "1/1/1999" Then

                chbNoExpiryDate.Enabled = True
                chbNoExpiryDate.Checked = True
                calExpiryDate.Visible = False
                calExpiryDate.Enabled = False
                calExpiryDate.SelectedDate = objReader("expiry_date")
                calExpiryDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString

            Else

                chbNoExpiryDate.Enabled = True
                chbNoExpiryDate.Checked = False
                calExpiryDate.Visible = True
                calExpiryDate.Enabled = True
                calExpiryDate.SelectedDate = objReader("expiry_date")
                calExpiryDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString

            End If

            If lblIsPO.Text = "True" Then
                panelCost.Visible = False
                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = True
            Else
                panelCost.Visible = True
                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = True
            End If

            btnSave.Visible = True

            objReader.Close()

        Else

            lblID.Text = Trim(objReader("id"))
            lblItem.Text = Trim(objReader("rm_code"))
            lblPO_Qty.Text = lblPOQty.Text
            lblPO_Date.Text = lblPRDate.Text

            txtSerial.Text = Trim(objReader("serial"))
            txtSerial.Enabled = bolChangeable

            txtEngineNo.Text = Trim(objReader("engine_no"))
            txtEngineNo.Enabled = bolChangeable

            txtFrameNo.Text = Trim(objReader("frame_no"))
            txtFrameNo.Enabled = bolChangeable

            txtColor.Text = Trim(objReader("color"))
            txtColor.Enabled = bolChangeable

            txtModelNo.Text = Trim(objReader("model_no"))
            txtModelNo.Enabled = bolChangeable

            txtChasisNo.Text = Trim(objReader("chasis_no"))
            txtChasisNo.Enabled = bolChangeable

            txtRemarks.Text = Trim(objReader("note"))
            txtRemarks.Enabled = bolChangeable

            calReceivedDate.SelectedDate = Trim(objReader("received_date"))
            calReceivedDate.Enabled = bolChangeable

            txtActualQty.Text = Trim(objReader("actual_qty"))
            txtActualQty.Enabled = bolChangeable

            txtFreeQty.Text = Trim(objReader("free_qty"))
            txtFreeQty.Enabled = bolChangeable

            If Trim(objReader("expiry_date")) = "1/1/1999" Then

                chbNoExpiryDate.Enabled = bolChangeable
                chbNoExpiryDate.Checked = True
                calExpiryDate.Visible = False
                calExpiryDate.Enabled = False
                calExpiryDate.SelectedDate = DateTime.UtcNow.AddHours(8).ToShortDateString
                calExpiryDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString

            Else

                chbNoExpiryDate.Enabled = bolChangeable
                chbNoExpiryDate.Checked = False
                calExpiryDate.Visible = bolChangeable
                calExpiryDate.Enabled = bolChangeable
                calExpiryDate.SelectedDate = objReader("expiry_date")
                calExpiryDate.VisibleDate = DateTime.UtcNow.AddHours(8).ToShortDateString

            End If

            If lblIsPO.Text = "True" Then
                panelCost.Visible = False
                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = bolChangeable
            Else
                panelCost.Visible = True
                txtCost.Text = Trim(objReader("cost"))
                txtCost.Enabled = bolChangeable
            End If

            btnSave.Visible = bolChangeable

            objReader.Close()

        End If

        objConnection.Close()

        SetFocus(txtActualQty)

        Refresh_TotalReceivedQty()

    End Sub
    Private Sub Refresh_TotalReceivedQty()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Inv_ItemDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", lblID.Text)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblTotalReceived_Qty.Text = Trim(objReader("total_received_qty"))

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub Refresh_Cost()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@code", lblItemCode.Text)
        objCommand.Parameters.Add("@Session_username", Session("username"))

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        txtCost.Text = Trim(objReader("cost"))

        objReader.Close()
        objConnection.Close()
    End Sub
    Private Sub ReadyDelete()

        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ItemDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim bolChangeable As Boolean = lblStatus.Text <> "RECEIVED"

        lblID.Text = Trim(objReader("id"))
        lblItem.Text = Trim(objReader("rm_code"))
        lblPO_Qty.Text = lblPOQty.Text
        lblPO_Date.Text = lblPRDate.Text

        txtSerial.Text = Trim(objReader("serial"))
        txtSerial.Enabled = False

        txtEngineNo.Text = Trim(objReader("engine_no"))
        txtEngineNo.Enabled = False

        txtFrameNo.Text = Trim(objReader("frame_no"))
        txtFrameNo.Enabled = False

        txtColor.Text = Trim(objReader("color"))
        txtColor.Enabled = False

        txtModelNo.Text = Trim(objReader("model_no"))
        txtModelNo.Enabled = False

        txtChasisNo.Text = Trim(objReader("chasis_no"))
        txtChasisNo.Enabled = False

        txtRemarks.Text = Trim(objReader("note"))
        txtRemarks.Enabled = False

        calReceivedDate.SelectedDate = Trim(objReader("received_date"))
        calReceivedDate.Enabled = False

        txtActualQty.Text = Trim(objReader("actual_qty"))
        txtActualQty.Enabled = False

        txtFreeQty.Text = Trim(objReader("free_qty"))
        txtFreeQty.Enabled = False

        chbNoExpiryDate.Enabled = False
        calExpiryDate.SelectedDate = objReader("expiry_date")
        calExpiryDate.Visible = False
        calExpiryDate.Enabled = False

        If lblIsPO.Text = "True" Then
            panelCost.Visible = False
            txtCost.Text = Trim(objReader("cost"))
            txtCost.Enabled = False
        Else
            panelCost.Visible = True
            txtCost.Text = Trim(objReader("cost"))
            txtCost.Enabled = False
        End If

        objReader.Close()

        objConnection.Close()

        SetFocus(btnSave)
        Refresh_TotalReceivedQty()

    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ItemDTLPO_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@pritems_id", Request("id"))
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objCommand.Parameters.Add("@pr_code", lblPRCode.Text)
        objCommand.Parameters.Add("@warehouse", lblWarehouse.Text)
        objCommand.Parameters.Add("@code", lblItemCode.Text)

        If chbNoExpiryDate.Checked = True Then
            objCommand.Parameters.Add("@expiry_date", "1/1/1999")
        Else
            objCommand.Parameters.Add("@expiry_date", calExpiryDate.SelectedDate)
        End If

        objCommand.Parameters.Add("@received_date", calReceivedDate.SelectedDate)
        objCommand.Parameters.Add("@serial", txtSerial.Text)
        objCommand.Parameters.Add("@engine_no", txtEngineNo.Text)
        objCommand.Parameters.Add("@frame_no", txtFrameNo.Text)
        objCommand.Parameters.Add("@color", txtColor.Text)
        objCommand.Parameters.Add("@model_no", txtModelNo.Text)
        objCommand.Parameters.Add("@chasis_no", txtChasisNo.Text)
        objCommand.Parameters.Add("@note", txtRemarks.Text)
        objCommand.Parameters.Add("@actual_qty", txtActualQty.Text)
        objCommand.Parameters.Add("@free_qty", txtFreeQty.Text)        
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))
        objCommand.Parameters.Add("@isPO", lblIsPO.Text)

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
                                        "ReceivedDate: " + calReceivedDate.SelectedDate + " > ActualQty: " + txtActualQty.Text + " > FreeQty: " + txtFreeQty.Text, _
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
        Dim objCommand As New SqlCommand("Inv_ItemDTL_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@warehouse", lblWarehouse.Text)

        If chbNoExpiryDate.Checked = True Then
            objCommand.Parameters.Add("@expiry_date", "1/1/1999")
        Else
            objCommand.Parameters.Add("@expiry_date", calExpiryDate.SelectedDate)
        End If

        objCommand.Parameters.Add("@received_date", calReceivedDate.SelectedDate)
        objCommand.Parameters.Add("@serial", txtSerial.Text)
        objCommand.Parameters.Add("@code", lblItemCode.Text)
        objCommand.Parameters.Add("@actual_qty", txtActualQty.Text)
        objCommand.Parameters.Add("@po_qty", lblPO_Qty.Text)
        objCommand.Parameters.Add("@po_date", lblPO_Date.Text)
        objCommand.Parameters.Add("@total_received_qty", lblTotalReceived_Qty.Text)
        objCommand.Parameters.Add("@isPO", lblIsPO.Text)

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
                                    "status", _
                                    "", _
                                    "", _
                                    "expiry_date", _
                                    "serial", _
                                    "engine_no", _
                                    "frame_no", _
                                    "color", _
                                    "model_no", _
                                    "chasis_no", _
                                    "note", _
                                    "actual_qty", _
                                    "free_qty", _
                                    "", _
                                    "", _
                                    "received_date", _
                                    "received_by", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "PO #", _
                                    "Status", _
                                    "Warehouse", _
                                    "Code", _
                                    "Expiry Date", _
                                    "Serial #", _
                                    "Engine #", _
                                    "Frame #", _
                                    "Color", _
                                    "Model #", _
                                    "Chasis #", _
                                    "Note", _
                                    "Received Qty", _
                                    "Free Qty", _
                                    "Cost", _
                                    "Total Payable", _
                                    "Received Date", _
                                    "Received By", _
                                    "Created By", _
                                    "Created Date", _
                                    "Modified By", _
                                    "Modified Date"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "", _
                                    "_COUNT_RECORD_", _
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
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "DS", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "N2", _
                                    "DS", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
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
            DisplayHeader2()
            DisplayHeader()
            GridBind()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False
            txtSearch.Visible = False
            btnSearch.Visible = False
            btnPrint.Visible = False

            If lblStatus.Text = "RECEIVED" Then
                btnAddImg.Visible = False
                btnAddImg.Enabled = False
            Else
                btnAddImg.Visible = True
                btnAddImg.Enabled = True
            End If
           
            'btnAddRecord.Text = "Add Item"

            'is this module in the list of accessable menus?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
                'go somewhere
                Response.Redirect("sys_errorpage")
            End If

            'is the user allowed to add record?
            If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_add") < 0 Then
                'disable the add button
                btnAddImg.Visible = False
            End If

        End If

    End Sub

    Sub GridBind()

        'this condition must only run once. initialize session(module) variables
        If strStoredProc <> Session("Current_Module") Then
            Session("Current_Module") = strStoredProc
            Session("SortKey") = strDefaultSortKey
        End If

        Sys_Class.BindGrid_SetDisplay_v4(DataGrid, _
                                    strStoredProc, _
                                    lblPRID.Text, _
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
        'lblItemCode.Text)

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
                    GridBind()
                    DisplayHeader()
                    ReadyAdd()
                    'reset and rebind       
                    txtPageNo.Text = 1


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

        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)
      
        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ItemDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()       

        lblPRStatus.Text = Trim(objReader("pr_status"))

        objReader.Close()
        objConnection.Close()

        If lblPRStatus.Text = "RECEIVED" Then
            Response.Write("<script language=""javascript"">alert('Cannot Proceed! This item was already " + lblPRStatus.Text + "! Please add new item.');</script>")
        Else
            txtFormAction.Text = "Edit"
            lblMode.ForeColor = Color.Orange
            lblID.Visible = True
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
        End If

    End Sub

    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.DeleteCommand

        'mark the selected item 
        DataGrid.SelectedIndex = e.Item.ItemIndex

        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_ItemDTL_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblPRStatus.Text = Trim(objReader("pr_status"))

        objReader.Close()
        objConnection.Close()

        If lblPRStatus.Text = "RECEIVED" Then
            Response.Write("<script language=""javascript"">alert('Cannot Proceed! This item was already " + lblPRStatus.Text + "! Please add new item.');</script>")
        Else
            If lblStatus.Text <> "RECEIVED" Then
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
                btnSave.Visible = False
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If
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
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblItemCode.Text = Trim(objReader("rm_code"))
        lblItemName.Text = Trim(objReader("rm_name"))
        lblPOQty.Text = Trim(objReader("qty"))
        lblTotalReceivedQty.Text = Trim(objReader("total_received_qty"))
        lblTotalFreeQty.Text = Trim(objReader("total_free_qty"))
        lblNetPayable.Text = objReader("total_payables")

        objReader.Close()
        objConnection.Close()

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub
    Sub DisplayHeader2()
        'retrieve and fill in the panel headed labels 

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_Receiving_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("lbl_id"))
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblPRID.Text = objReader("id")
        lblPRCode.Text = objReader("pr_code")
        lblIsPO.Text = objReader("isPO")
        lblPRDate.Text = objReader("pr_date")
        lblStatus.Text = objReader("status")
        lblWarehouse.Text = objReader("warehouse")
        lblVendorCode.Text = objReader("vendor_code")
        lblVendorName.Text = objReader("vendor_name")
        txtNote.Text = objReader("note")


        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("inv_receivingdtl_list?&id=" & Request("lbl_id") & "&sys_table=" & "inv_receiving_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Inv_PRItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pr_id", lblPRID.Text)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        SetEndPopup("trx_receiving_form?code=" & lblPRCode.Text & _
                " &id=" & Request("id") & _
                " &formaction=" & "Print")

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("inv_receivingdtl_list?&id=" & Request("lbl_id") & "&sys_table=" & "inv_receiving_list")

    End Sub

    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        If lblStatus.Text <> "RECEIVED" Then
            txtFormAction.Text = "Add"
            lblMode.ForeColor = Color.Green
            btnSave.Text = "Add"
            ClearInputs()

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
                ClearInputs()

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
                Response.Write("<script language=""javascript"">alert('Cannot Proceed! This record was already " + lblStatus.Text + "!');</script>")
            End If
        End If

    End Sub
    Private Sub ReadyAdd()

        ClearInputs()

        SetFocus(txtSerial)

    End Sub

    Private Sub ClearInputs()

        lblItem.Text = lblItemCode.Text + " | " + lblItemName.Text
        lblPO_Qty.Text = lblPOQty.Text
        lblPO_Date.Text = lblPRDate.Text
        lblTotalReceived_Qty.Text = lblTotalReceivedQty.Text
        txtSerial.Text = ""
        txtSerial.Enabled = True

        txtActualQty.Text = 0
        txtActualQty.Enabled = True

        txtFreeQty.Text = 0
        txtFreeQty.Enabled = True

        chbNoExpiryDate.Checked = True
        chbNoExpiryDate.Enabled = True
        calExpiryDate.Visible = False
        calExpiryDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
        calExpiryDate.Enabled = True

        calReceivedDate.SelectedDate = Date.UtcNow.AddHours(8).ToShortDateString()
        calReceivedDate.Enabled = True

        If lblIsPO.Text = "True" Then
            panelCost.Visible = False
            Refresh_Cost()
            txtCost.Enabled = True
        Else
            panelCost.Visible = True
            Refresh_Cost()
            txtCost.Enabled = True
        End If


    End Sub

    Private Sub chbNoExpiryDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbNoExpiryDate.CheckedChanged

        If chbNoExpiryDate.Checked = True Then
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calExpiryDate.Visible = False
            calExpiryDate.Enabled = False
            SetFocus(txtActualQty)
        Else
            panelInfo.Visible = False
            panelSuccess.Visible = False
            calExpiryDate.Visible = True
            calExpiryDate.Enabled = True
            SetFocus(calExpiryDate)
        End If

    End Sub
End Class

