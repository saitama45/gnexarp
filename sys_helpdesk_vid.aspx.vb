Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Public Class sys_helpdesk_vid
    Inherits System.Web.UI.Page
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents lblUserTab As System.Web.UI.WebControls.Label
    Protected WithEvents lblDashboard As System.Web.UI.WebControls.Label
    Protected WithEvents panelDashboard As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDashboard As System.Web.UI.WebControls.Table
    Protected WithEvents lblAR As System.Web.UI.WebControls.Label
    Protected WithEvents panelAR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblAR As System.Web.UI.WebControls.Table
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
    Protected WithEvents Span1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents btnCopyToServer As System.Web.UI.WebControls.Button
    Protected WithEvents btnBulkInsert As System.Web.UI.WebControls.Button
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents btnUploadBilling As System.Web.UI.WebControls.Button
    Protected WithEvents FileUploadBilling As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents panelSuccess As System.Web.UI.WebControls.Panel
    Protected WithEvents panelInfo As System.Web.UI.WebControls.Panel
    Protected WithEvents lblValidate As System.Web.UI.WebControls.Label
    Protected WithEvents rdoUpload As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents panelBilling As System.Web.UI.WebControls.Panel
    Protected WithEvents btnUploadCollection As System.Web.UI.WebControls.Button
    Protected WithEvents panelCollection As System.Web.UI.WebControls.Panel
    Protected WithEvents btnUploadMatching As System.Web.UI.WebControls.Button
    Protected WithEvents panelMatching As System.Web.UI.WebControls.Panel
    Protected WithEvents FileUploadCollection As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents FileUploadMatching As System.Web.UI.HtmlControls.HtmlInputFile

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'the stored proc to call
    Public strSubMenuName As String = "inv_uploading_facility"

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sys_Class.DisplaySideBarMenu(lblUser, _
                                            lblUserTab, _
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
        If Session("Sys_AccessList").indexof(strSubMenuName.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage.aspx")
        End If

        If rdoUpload.SelectedIndex = 0 Then
            panelBilling.Visible = True
            panelCollection.Visible = False
            panelMatching.Visible = False

        ElseIf rdoUpload.SelectedIndex = 1 Then
            panelBilling.Visible = False
            panelCollection.Visible = True
            panelMatching.Visible = False

        ElseIf rdoUpload.SelectedIndex = 2 Then
            panelBilling.Visible = False
            panelCollection.Visible = False
            panelMatching.Visible = True
        End If

        If Not Page.IsPostBack Then
            panelSuccess.Visible = False
            panelInfo.Visible = False
        End If
    End Sub

    Protected Sub UploadBilling(ByVal sender As Object, ByVal e As EventArgs)

        Dim csvPath As String = Server.MapPath("~/Uploads/") + "uploadedbilling.txt"
        'Dim FileName As String = System.IO.Path.GetFileName(FileUploadBilling.PostedFile.FileName)
        'Dim csvPath As String = Server.MapPath("~/Uploads/") + FileName + ".txt"

        If (Not FileUploadBilling.PostedFile Is Nothing) AndAlso (FileUploadBilling.PostedFile.ContentLength > 0) Then

            Try
                'Upload and save the File.
                FileUploadBilling.PostedFile.SaveAs(csvPath)
                panelSuccess.Visible = True

                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                Dim objCommand As New SqlCommand("upl_ImportBillingCSV", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objConnection.Open()
                Dim objReader As SqlDataReader = objCommand.ExecuteReader
                objReader.Read()

                objReader.Close()
                objConnection.Close()

                'Delete the temporary file
                File.Delete(csvPath)
            Catch ex As Exception

                panelInfo.Visible = True
                lblValidate.Text = ex.ToString()
            End Try
        Else
            panelInfo.Visible = True
            lblValidate.Text = "Please select a file to upload."
        End If

    End Sub

    Protected Sub UploadCollection(ByVal sender As Object, ByVal e As EventArgs)

        Dim csvPath As String = Server.MapPath("~/Uploads/") + "uploadedcollection.txt"
        'Dim FileName As String = System.IO.Path.GetFileName(FileUploadBilling.PostedFile.FileName)
        'Dim csvPath As String = Server.MapPath("~/Uploads/") + FileName + ".txt"

        If (Not FileUploadCollection.PostedFile Is Nothing) AndAlso (FileUploadCollection.PostedFile.ContentLength > 0) Then

            Try
                'Upload and save the File.
                FileUploadCollection.PostedFile.SaveAs(csvPath)
                panelSuccess.Visible = True

                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                Dim objCommand As New SqlCommand("upl_ImportCollectionCSV", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objConnection.Open()
                Dim objReader As SqlDataReader = objCommand.ExecuteReader
                objReader.Read()

                objReader.Close()
                objConnection.Close()

                'Delete the temporary file
                File.Delete(csvPath)
            Catch ex As Exception

                panelInfo.Visible = True
                lblValidate.Text = ex.ToString()
            End Try
        Else
            panelInfo.Visible = True
            lblValidate.Text = "Please select a file to upload."
        End If

    End Sub

    Protected Sub UploadMatching(ByVal sender As Object, ByVal e As EventArgs)

        Dim csvPath As String = Server.MapPath("~/Uploads/") + "uploadedmatching.txt"
        'Dim FileName As String = System.IO.Path.GetFileName(FileUploadBilling.PostedFile.FileName)
        'Dim csvPath As String = Server.MapPath("~/Uploads/") + FileName + ".txt"

        If (Not FileUploadMatching.PostedFile Is Nothing) AndAlso (FileUploadMatching.PostedFile.ContentLength > 0) Then

            Try
                'Upload and save the File.
                FileUploadMatching.PostedFile.SaveAs(csvPath)
                panelSuccess.Visible = True

                Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
                Dim objCommand As New SqlCommand("upl_ImportMatchingCSV", objConnection)
                objCommand.CommandType = CommandType.StoredProcedure
                objConnection.Open()
                Dim objReader As SqlDataReader = objCommand.ExecuteReader
                objReader.Read()

                objReader.Close()
                objConnection.Close()

                'Delete the temporary file
                File.Delete(csvPath)
            Catch ex As Exception

                panelInfo.Visible = True
                lblValidate.Text = ex.ToString()
            End Try
        Else
            panelInfo.Visible = True
            lblValidate.Text = "Please select a file to upload."
        End If

    End Sub

    Private Sub rdoUpload_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoUpload.SelectedIndexChanged
        panelSuccess.Visible = False
        panelInfo.Visible = False
    End Sub
End Class
