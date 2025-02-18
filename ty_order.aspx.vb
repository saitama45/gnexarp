Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class ty_order
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblCompanyName As System.Web.UI.WebControls.Label
    Protected WithEvents TopMenuCategories As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblTotalItemSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItemCount As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItemCart As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalCartAmount As System.Web.UI.WebControls.Label
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblOrderNo As System.Web.UI.WebControls.Label
    Protected WithEvents btnContinueShop As System.Web.UI.WebControls.Button


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
        'Put user code to initialize the page here

        If Not Page.IsPostBack Then
            Sys_Class.TopMenu(lblCompanyName, _
                                        TopMenuCategories, _
                                        Session("NoLoginClient_Cookie"), _
                                        lblTotalItemSRP, _
                                        lblTotalItemCount)

            lblOrderNo.Text = Request("order_no")

        End If

    End Sub

    Private Sub btnContinueShop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinueShop.Click
        Response.Redirect("sys_home")
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Response.Redirect("item_search?char=" & txtSearch.Text)
    End Sub
End Class
