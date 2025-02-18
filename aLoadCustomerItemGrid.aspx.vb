Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports Microsoft.VisualBasic.CompilerServices

Public Class aLoadCustomerItemGrid
    Inherits System.Web.UI.Page
    Dim counter As Integer = 1 ' Declare counter at class level

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Not Page.IsPostBack Then

            ' Your existing code to generate the HTML
            Dim CustomerItemID As String = GenerateHtmlContent()

            ' Set the response content type to text/html
            Response.ContentType = "text/html"

            ' Write the HTML string to the response
            Response.Write(CustomerItemID)

            ' End the response (important!)
            Response.End()

        End If

    End Sub

    Private Function GenerateHtmlContent()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Ref_ClientsItem_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@id", Request("id"))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'read and fill the boxes
        objReader.Read()

        Dim CustomerItemID As String = Trim(objReader("disc"))

        Div1.InnerHtml = CustomerItemID

        objReader.Close()
        objConnection.Close()

        Return CustomerItemID


    End Function

End Class
