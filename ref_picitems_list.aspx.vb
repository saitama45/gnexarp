
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.IO

Public Class ref_picitems_list
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
    Protected WithEvents lblItemID As System.Web.UI.WebControls.Label
    Protected WithEvents ddlStatus As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCompany As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtBarcode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtClientCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlCategory As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlSubCategory As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblCode As System.Web.UI.WebControls.Label
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSpecs As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlUOM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLandedCost As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP12 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP13 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP14 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSRP15 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSafetyLevel As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlRawMats As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnAddImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnBackImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveImg As System.Web.UI.WebControls.ImageButton
    Protected WithEvents FileUpload As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents ImgItemPic As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents panelItemPic As System.Web.UI.WebControls.Panel
    Protected WithEvents chbIsDefault As System.Web.UI.WebControls.CheckBox

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
    Public strStoredProc As String = "ref_picitems_list"
    Public strSubMenuName As String = "ref_picitems_list"

    'the default sortkey and key field
    'values must match with any of those DataGrid_ItemCreated.aSortKeys() items
    Public strDefaultSortKey As String = "rm_code"
    Public strKeyField As String = "id"

    Private Sub btnAddImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAddImg.Click

        txtFormAction.Text = "Add"
        lblMode.ForeColor = Color.Green                
        btnSave.Text = "Add"

        'show the Form panel
        Sys_Class.ReadyForm(panelForm, _
                                panelSuccess, _
                                panelInfo, _
                                lblMessage, _
                                ValidationSummary1, _
                                lblMode, _
                                txtFormAction)

        FileUpload.Visible = True
        chbIsDefault.Visible = True
        panelItemPic.Visible = False

        LoadImage()
    End Sub
    
    Private Sub ReadyDelete()

        panelItemPic.Visible = True
        FileUpload.Visible = False
        chbIsDefault.Visible = False
        'retrieve and fill in the panel record textboxes for editing

        'set the key feild value base on datagrid selected index
        Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

        'connection
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_PicItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", strKeyFieldValue)

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        lblID.Text = Trim(objReader("id"))

        objReader.Close()
        objConnection.Close()

        LoadImage()

        SetFocus(btnSave)

    End Sub

    Private Sub LoadImage()

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()
        Dim objCommand As New SqlCommand("Ref_PicItems_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", lblID.Text)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        Dim htmlForImages As String = String.Empty

        If Convert.IsDBNull(objReader("filepath")) Then
            htmlForImages = String.Empty
        Else
            htmlForImages = "<img style='width:200px; height:200px;' src=" & Trim(objReader("filepath")) & ">"
        End If

        ImgItemPic.InnerHtml = htmlForImages

        objReader.Close()
        objConnection.Close()

    End Sub

    Private Function SaveInput()

        'used to save the inputs when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status 
        SaveInput = "ok"

        If txtFormAction.Text = "Add" Then

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()
            Dim objCommand As New SqlCommand("Ref_PicItemsTotalCount_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@item_id", lblItemID.Text)

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim existingPicCount As Integer = Trim(objreader("existingPicCount"))

            objReader.Close()
            objConnection.Close()

            Dim itemCode As String = lblCode.Text
            Dim newFilename As String = String.Format("{0}-{1}", itemCode, existingPicCount + 1)

            Dim FileName As String = System.IO.Path.GetFileName(FileUpload.PostedFile.FileName)
            Dim extension As String = System.IO.Path.GetExtension(FileName)
            Dim newFileNameWithExt As String = String.Format("{0}{1}", newFilename, extension)
            Dim csvPath As String = System.IO.Path.Combine(Server.MapPath("~/Files/Items/"), newFileNameWithExt)

            Dim contentType As String = FileUpload.PostedFile.ContentType
            Dim fs As Stream = FileUpload.PostedFile.InputStream
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim size As Decimal = Math.Round((CDec(FileUpload.PostedFile.ContentLength) / CDec(1024)), 2)

            'Upload and save the File.
            FileUpload.PostedFile.SaveAs(csvPath)

            'the connection 
            objConnection = New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            'the stored procedure and parameters
            objCommand = New SqlCommand("Ref_PicItems_Save", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
            objCommand.Parameters.Add("@id", lblID.Text)
            objCommand.Parameters.Add("@item_id", lblItemID.Text)
            objCommand.Parameters.Add("@filename", newFileNameWithExt)
            objCommand.Parameters.Add("@filecontenttype", contentType)
            objCommand.Parameters.Add("@filesize", size)
            objCommand.Parameters.Add("@filepath", "Files/Items/" + newFileNameWithExt)

            If chbIsDefault.Checked = True Then
                objCommand.Parameters.Add("@is_default", 1)
            Else
                objCommand.Parameters.Add("@is_default", 0)
            End If

            objCommand.Parameters.Add("@Session_username", Session("username"))

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
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue, _
                                        Request("id"), _
                                        0)
            Catch ex As Exception
                'in case of error
                SaveInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            Finally
                objConnection.Close()
            End Try
        End If

        If txtFormAction.Text = "Delete" Then
            'the connection 
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            'the stored procedure and parameters
            Dim objCommand As New SqlCommand("Ref_PicItems_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", lblID.Text)

            objConnection.Open()
            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            Dim csvPath As String = Server.MapPath("~/Files/Items/") + objReader("filename")
            'Delete the file
            File.Delete(csvPath)

            Dim strFilename As String = objReader("filename")
            Dim strFileContentType As String = objReader("filecontenttype")
            Dim strFileSize As String = objReader("filesize")
            Dim strFilePath As String = objReader("filepath")
            objReader.Close()

            'the stored procedure and parameters
            objCommand = New SqlCommand("Ref_PicItems_Save", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
            objCommand.Parameters.Add("@id", lblID.Text)
            objCommand.Parameters.Add("@item_id", lblItemID.Text)
            objCommand.Parameters.Add("@filename", "")
            objCommand.Parameters.Add("@filecontenttype", "")
            objCommand.Parameters.Add("@filesize", "")
            objCommand.Parameters.Add("@filepath", "")
            objCommand.Parameters.Add("@Session_username", Session("username"))

            'the returned new id 
            Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
            objCommand.Parameters.Add(objNewID)
            objNewID.Direction = ParameterDirection.Output

            Try
                'open the connection and execute the query 
                objReader.Close()
                objCommand.ExecuteNonQuery()

                'save to audit trail 
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(Session("username"), _
                                        txtFormAction.Text, _
                                        Request("sys_table"), _
                                        "Items: " + ddlRawMats.SelectedValue + " > RMCode: " + ddlRawMats.SelectedValue, _
                                        Request("id"), _
                                        0)

            Catch ex As Exception
                'in case of error
                SaveInput = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            Finally

                objConnection.Close()
            End Try

        End If

    End Function


    Private Function ValidateInput()
        'used to validate when user adds or edits a record
        'called by btnSave.Click handler
        'returns a string status
        ValidateInput = "ok"

        Dim FileName As String = System.IO.Path.GetFileName(FileUpload.PostedFile.FileName)

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Ref_PicItems_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", txtFormAction.Text)
        objCommand.Parameters.Add("@id", lblID.Text)
        objCommand.Parameters.Add("@item_id", lblItemID.Text)
        objCommand.Parameters.Add("@filename", FileName)

        If chbIsDefault.Checked = True Then
            objCommand.Parameters.Add("@is_default", 1)
        Else
            objCommand.Parameters.Add("@is_default", 0)
        End If

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
                                    "filename", _
                                    "filecontenttype", _
                                    "filesize", _
                                    "is_default", _
                                    "uploaded_by", _
                                    "uploaded_date", _
                                    "lastdownload_by", _
                                    "lastdownload_date", _
                                    ""}


        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"Ref#", _
                                    "Filename", _
                                    "File Type", _
                                    "File Size (MB)", _
                                    "Is Default?", _
                                    "Uploaded By", _
                                    "Uploaded Date", _
                                    "Last Downloaded By", _
                                    "Last Downloaded Date", _
                                    "Total Downloads"}

        'display what you want below - displays if footer is specified in the datagrid
        Dim aFooters() As String = {"", _
                                    "", _
                                    "", _
                                    "_SUM_", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    "", _
                                    ""}

        Dim aFormats() As String = {"", _
                                    "", _
                                    "", _
                                    "N2", _
                                    "", _
                                    "", _
                                    "D", _
                                    "", _
                                    "D", _
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
            LoadImage()

            txtFormAction.Visible = False 'always hide this
            hlViewFullTrail.Visible = False
            btnCancel.Visible = False
            btnAddImg.Visible = True
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
                                    lblItemID.Text)

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

        If txtFormAction.Text = "Add" Then
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
                        lblValidate.Visible = False
                        panelGrid.Visible = True

                        DisplayHeader()
                        txtPageNo.Text = 1
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

        Else

            Dim strSaveInput As String = SaveInput()

            'is the saving successfull?
            If strSaveInput = "ok" Then
                'notify and clear input boxes

                If txtFormAction.Text = "Delete" Then

                    panelSuccess.Visible = True
                    panelInfo.Visible = False
                    panelForm.Visible = False
                    lblValidate.Visible = False

                    'reset the selected index in case of edit modes and rebind
                    DataGrid.SelectedIndex = -1
                    txtPageNo.Text = 1
                    GridBind()
                    DisplayHeader()
                End If

            Else
                'notify unsucessful and the reason
                panelInfo.Visible = True
                lblValidate.Text = strSaveInput
            End If
        End If


        If Not Page.IsValid Then
            Exit Sub
        End If


    End Sub

    Private Sub DataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles DataGrid.DeleteCommand

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
        Dim objCommand As New SqlCommand("Ref_Items_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@Session_username", Session("username"))

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim strCompany As String = objReader("company")
        Dim strBrand As String = objReader("brand")
        Dim strCategory As String = objReader("category")
        Dim strSubCategory As String = objReader("subcategory")
        Dim strUOM As String = objReader("uom")

        lblItemID.Text = objReader("id")
        lblCode.Text = objReader("code")

        ddlStatus.SelectedValue = Trim(objReader("status"))
        ddlType.SelectedValue = Trim(objReader("MI"))
        txtClientCode.Text = Trim(objReader("client_code"))
        txtBarcode.Text = Trim(objReader("barcode"))
        txtSpecs.Text = Trim(objReader("specs"))
        txtName.Text = Trim(objReader("name"))
        txtCost.Text = Trim(objReader("cost"))
        txtLandedCost.Text = Trim(objReader("landed_cost"))
        txtSRP.Text = Trim(objReader("srp"))
        txtSRP2.Text = Trim(objReader("srp2"))
        txtSRP3.Text = Trim(objReader("srp3"))
        txtSRP4.Text = Trim(objReader("srp4"))
        txtSRP5.Text = Trim(objReader("srp5"))
        txtSRP6.Text = Trim(objReader("srp6"))
        txtSRP7.Text = Trim(objReader("srp7"))
        txtSRP8.Text = Trim(objReader("srp8"))
        txtSRP9.Text = Trim(objReader("srp9"))
        txtSRP10.Text = Trim(objReader("srp10"))
        txtSRP11.Text = Trim(objReader("srp11"))
        txtSRP12.Text = Trim(objReader("srp12"))
        txtSRP13.Text = Trim(objReader("srp13"))
        txtSRP14.Text = Trim(objReader("srp14"))
        txtSRP15.Text = Trim(objReader("srp15"))
        txtInc1.Text = Trim(objReader("incentive1"))
        txtInc2.Text = Trim(objReader("incentive2"))
        txtInc3.Text = Trim(objReader("incentive3"))
        txtSafetyLevel.Text = Trim(objReader("safety_level"))

        objReader.Close()

        objCommand = New SqlCommand("Ref_Company_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", Session("username"))
        objReader = objCommand.ExecuteReader
        ddlCompany.DataSource = objReader
        ddlCompany.DataValueField = "code"
        ddlCompany.DataTextField = "name"
        ddlCompany.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_UOM_Get_Droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlUOM.DataSource = objReader
        ddlUOM.DataValueField = "name"
        ddlUOM.DataTextField = "name"
        ddlUOM.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Brand_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlBrand.DataSource = objReader
        ddlBrand.DataValueField = "name"
        ddlBrand.DataTextField = "name"
        ddlBrand.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_Category_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlCategory.DataSource = objReader
        ddlCategory.DataValueField = "name"
        ddlCategory.DataTextField = "name"
        ddlCategory.DataBind()
        objReader.Close()

        objCommand = New SqlCommand("Ref_SubCategory_Get_droplist", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objReader = objCommand.ExecuteReader
        ddlSubCategory.DataSource = objReader
        ddlSubCategory.DataValueField = "code"
        ddlSubCategory.DataTextField = "name"
        ddlSubCategory.DataBind()
        objReader.Close()

        objConnection.Close()

        ddlCompany.SelectedIndex = ddlCompany.Items.IndexOf(ddlCompany.Items.FindByValue(strCompany.ToString))
        ddlUOM.SelectedIndex = ddlUOM.Items.IndexOf(ddlUOM.Items.FindByValue(strUOM.ToString))
        ddlBrand.SelectedIndex = ddlBrand.Items.IndexOf(ddlBrand.Items.FindByValue(strBrand.ToString))
        ddlCategory.SelectedIndex = ddlCategory.Items.IndexOf(ddlCategory.Items.FindByValue(strCategory.ToString))
        ddlSubCategory.SelectedIndex = ddlSubCategory.Items.IndexOf(ddlSubCategory.Items.FindByValue(strSubCategory.ToString))

        hlViewFullHistory.Visible = True
        hlViewFullHistory.NavigateUrl = "trx_fullhistory?sys_table=" & Request("sys_table") & "&mode=1&id=" & Request("id")

    End Sub
    Private Sub btnX_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnX.Click
        Response.Redirect("ref_picitems_list?&id=" & Request("id") & "&sys_table=" & Request("sys_table"))
        panelGrid.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
    Private Sub btnBackImg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBackImg.Click
        Response.Redirect("ref_items_list")
    End Sub
    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
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
        Dim objCommand As New SqlCommand("Ref_Items_Validate", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", lblItemID.Text)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@client_code", txtClientCode.Text)
        objCommand.Parameters.Add("@brand", ddlBrand.SelectedValue)
        objCommand.Parameters.Add("@Session_username", Session("username"))

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
        Dim objCommand As New SqlCommand("Ref_Items_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", lblItemID.Text)
        objCommand.Parameters.Add("@status", ddlStatus.SelectedValue)
        objCommand.Parameters.Add("@company", ddlCompany.SelectedValue)
        objCommand.Parameters.Add("@client_code", txtClientCode.Text)
        objCommand.Parameters.Add("@barcode", txtBarcode.Text)
        objCommand.Parameters.Add("@type", ddlType.SelectedValue)
        objCommand.Parameters.Add("@brand", ddlBrand.SelectedValue)
        objCommand.Parameters.Add("@category", ddlCategory.SelectedValue)
        objCommand.Parameters.Add("@subcategory", ddlSubCategory.SelectedValue)
        objCommand.Parameters.Add("@name", txtName.Text)
        objCommand.Parameters.Add("@specs", txtSpecs.Text)
        objCommand.Parameters.Add("@uom", ddlUOM.SelectedValue)
        objCommand.Parameters.Add("@cost", txtCost.Text)
        objCommand.Parameters.Add("@landed_cost", txtLandedCost.Text)
        objCommand.Parameters.Add("@srp", txtSRP.Text)
        objCommand.Parameters.Add("@srp2", txtSRP2.Text)
        objCommand.Parameters.Add("@srp3", txtSRP3.Text)
        objCommand.Parameters.Add("@srp4", txtSRP4.Text)
        objCommand.Parameters.Add("@srp5", txtSRP5.Text)
        objCommand.Parameters.Add("@srp6", txtSRP6.Text)
        objCommand.Parameters.Add("@srp7", txtSRP7.Text)
        objCommand.Parameters.Add("@srp8", txtSRP8.Text)
        objCommand.Parameters.Add("@srp9", txtSRP9.Text)
        objCommand.Parameters.Add("@srp10", txtSRP10.Text)
        objCommand.Parameters.Add("@srp11", txtSRP11.Text)
        objCommand.Parameters.Add("@srp12", txtSRP12.Text)
        objCommand.Parameters.Add("@srp13", txtSRP13.Text)
        objCommand.Parameters.Add("@srp14", txtSRP14.Text)
        objCommand.Parameters.Add("@srp15", txtSRP15.Text)
        objCommand.Parameters.Add("@incentive1", txtInc1.Text)
        objCommand.Parameters.Add("@incentive2", txtInc2.Text)
        objCommand.Parameters.Add("@incentive3", txtInc3.Text)
        objCommand.Parameters.Add("@safety_level", txtSafetyLevel.Text)
        objCommand.Parameters.Add("@Session_fullname", Session("Fullname"))

        'the returned new code 
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
                                        "Ref#: " + lblID.Text, _
                                        objNewID.Value, _
                                        "0")

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

    Private Sub ddlStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlStatus.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCompany.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtClientCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClientCode.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlType.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCategory.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlSubCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSubCategory.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSpecs_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSpecs.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub ddlUOM_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlUOM.SelectedIndexChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtCost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtLandedCost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLandedCost.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP2.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP3.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP4.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP5.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP6.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP7.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP8.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP9.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP10_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP10.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP11_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP11.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP12.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP13.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP14_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP14.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSRP15_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRP15.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtInc1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInc1.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtInc2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInc2.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtInc3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInc3.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub txtSafetyLevel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSafetyLevel.TextChanged
        SaveHeaderClick()
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub

    Private Sub DataGrid_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid.ItemCommand
       

        If e.CommandName = "View" Then

            panelItemPic.Visible = True
            FileUpload.Visible = False
            chbIsDefault.Visible = False

            'retrieve and fill in the panel record textboxes for editing
            DataGrid.SelectedIndex = e.Item.ItemIndex
            Dim strKeyFieldValue As String = DataGrid.DataKeys(DataGrid.SelectedIndex)

            'connection
            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            'the stored procedure and parameters
            Dim objCommand As New SqlCommand("Ref_PicItems_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@id", strKeyFieldValue)

            'open the connection and execute the reader 
            objConnection.Open()
            Dim objReader As SqlDataReader = objCommand.ExecuteReader

            'read and fill the boxes
            objReader.Read()

            lblID.Text = Trim(objReader("id"))

            objReader.Close()
            objConnection.Close()

            LoadImage()

            SetFocus(btnSave)
            ''the connection 
            'Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            ''the stored procedure and parameters
            'Dim objCommand As New SqlCommand("Ref_PicItems_Save", objConnection)
            'objCommand.CommandType = CommandType.StoredProcedure
            'objCommand.Parameters.Add("@FormAction", "Download")
            'objCommand.Parameters.Add("@id", strKeyFieldValue)
            'objCommand.Parameters.Add("@item_id", lblItemID.Text)
            'objCommand.Parameters.Add("@filename", "")
            'objCommand.Parameters.Add("@filecontenttype", "")
            'objCommand.Parameters.Add("@filesize", "")
            'objCommand.Parameters.Add("@filepath", "")
            'objCommand.Parameters.Add("@Session_username", Session("username"))

            ''the returned new id 
            'Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
            'objCommand.Parameters.Add(objNewID)
            'objNewID.Direction = ParameterDirection.Output

            'Try
            '    'open the connection and execute the query
            '    objConnection.Open()
            '    objCommand.ExecuteNonQuery()

            '    'get the name of Clients
            '    objCommand = New SqlCommand("Ref_PicItems_Get", objConnection)
            '    objCommand.CommandType = CommandType.StoredProcedure
            '    objCommand.Parameters.Add("@id", strKeyFieldValue)
            '    Dim objReader As SqlDataReader = objCommand.ExecuteReader
            '    objReader.Read()

            '    Dim csvPath As String = Server.MapPath("~/Files/Items/") + objReader("filename")
            '    Dim strFilename As String = objReader("filename")
            '    Dim strFileContentType As String = objReader("filecontenttype")
            '    Dim strFileSize As String = objReader("filesize")
            '    Dim strFilePath As String = objReader("filepath")
            '    objReader.Close()

            '    'save to audit trail 
            '    Sys_Class.SaveToAuditTrail(Session("username"), _
            '                                txtFormAction.Text, _
            '                                strSubMenuName, _
            '                                "Ref#: " + lblID.Text, _
            '                                objNewID.Value, _
            '                                "0")

            '    Response.ContentType = strFileContentType
            '    Response.AddHeader("content-disposition", "attachment; filename=" & strFilename)
            '    Response.WriteFile(csvPath)
            '    Response.End()

            '    'reset the selected index in case of edit modes and rebind
            '    DataGrid.SelectedIndex = -1
            '    txtPageNo.Text = 1
            '    GridBind()

            'Catch ex As Exception
            '    'in case of error
            '    Dim strSaveInput As String = "There was an error while saving record(s).<br>Please report the ff.:<br> " & ex.ToString
            'Finally
            '    objConnection.Close()
            'End Try

        End If
    End Sub
End Class

