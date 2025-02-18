Public Class Sys_ErrorPage
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents lblErrorMessage As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Put user code to initialize the page here

    '    lblErrorMessage.Text = "An error was encountered.<br>Please report the ff.:<br>Error description : " & Err.Description & _
    '   " <br> Line number of the last executed statement : " & Err.Erl & _
    '   " <br> Error number : " & Err.Number & _
    '   " <br> Error source : " & Err.Source & _
    '   " <br> Source page: : " & Request("aspxerrorpath")
    'End Sub

End Class
