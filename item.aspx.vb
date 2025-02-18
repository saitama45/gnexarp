Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.Web.Mail

Public Class item
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents lblCompanyName As System.Web.UI.WebControls.Label
    Protected WithEvents TopMenuCategories As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblTotalItemSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItemCount As System.Web.UI.WebControls.Label
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblItemName As System.Web.UI.WebControls.Label
    Protected WithEvents lblProductName As System.Web.UI.WebControls.Label
    Protected WithEvents lblItemPriceShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblItemPrice As System.Web.UI.WebControls.Label
    Protected WithEvents lblItemOrigPrice As System.Web.UI.WebControls.Label
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents CategoryPages As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents btnPrev As System.Web.UI.WebControls.Button
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents txtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageTotal As System.Web.UI.WebControls.Label
    Protected WithEvents lblSOHShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblSOH As System.Web.UI.WebControls.Label
    Protected WithEvents btnAddToCart As System.Web.UI.WebControls.Button
    Protected WithEvents lblOutOfStocks As System.Web.UI.WebControls.Label
    Protected WithEvents del As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents panelQty As System.Web.UI.WebControls.Panel

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

            'lblCompanyName.Text = Session("NoLoginClient_Cookie")

            RefreshAddToCartCount()

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand("Web_ItemsCode_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@code", Request("code"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            objReader.Read()

            lblItemName.Text = Trim(objReader("name"))
            lblProductName.Text = Trim(objReader("name"))

            Dim DelItemPrice As String = String.Empty

            If Trim(objReader("orig_srp")) = 0 Then
                lblItemOrigPrice.Visible = False
                lblItemOrigPrice.Text = Trim(objReader("orig_srp"))
            Else
                lblItemOrigPrice.Visible = True
                lblItemOrigPrice.Text = Trim(objReader("orig_srp"))
                DelItemPrice = "<del class='pric1 w3-text-gray'>&#8369;" & lblItemOrigPrice.Text & "</del>"
            End If

            del.InnerHtml = DelItemPrice

            lblItemPriceShow.Text = Trim(objReader("current_srp_show"))
            lblItemPrice.Text = Trim(objReader("current_srp"))
            lblSOHShow.Text = Trim(objReader("soh_show"))
            lblSOH.Text = Trim(objReader("soh"))

            Dim itemImage As String = String.Empty
            itemImage = "<img src='" & Trim(objReader("image_path")) & "' data-imagezoom='true' class='img-responsive' alt=''>"

            Div1.InnerHtml = itemImage

            objReader.Close()
            objConnection.Close()

            If lblSOH.Text = 0.0 Then
                btnAddToCart.Visible = False
                txtQty.Text = 0
                panelQty.Visible = False
                lblOutOfStocks.Visible = True
            Else
                btnAddToCart.Visible = True
                txtQty.Text = txtQty.Text
                panelQty.Visible = True
                lblOutOfStocks.Visible = False
            End If
        End If

    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Response.Redirect("item_search?char=" & txtSearch.Text)
    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsAddToCart_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Add")
        objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))
        objCommand.Parameters.Add("@rm_code", Request("code"))
        objCommand.Parameters.Add("@qty", txtQty.Text)
        objCommand.Parameters.Add("@srp", lblItemPrice.Text)

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

        RefreshAddToCartCount()
    End Sub

    Private Sub RefreshAddToCartCount()

        Sys_Class.TopMenu(lblCompanyName, _
                          TopMenuCategories, _
                          Session("NoLoginClient_Cookie"), _
                          lblTotalItemSRP, _
                          lblTotalItemCount)
    End Sub


End Class
