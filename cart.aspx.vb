Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports Microsoft.VisualBasic.CompilerServices

Public Class cart
    Inherits System.Web.UI.Page
    Dim counter As Integer = 1 ' Declare counter at class level

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
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents btnContinueShop As System.Web.UI.WebControls.Button
    Protected WithEvents btnCheckout As System.Web.UI.WebControls.Button

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
        'Refresh_Cart()

        If Not Page.IsPostBack Then




        End If

    End Sub
    'Private Sub Refresh_Cart()

    '    Sys_Class.TopMenu(lblCompanyName, _
    '                        TopMenuCategories, _
    '                        Session("NoLoginClient_Cookie"), _
    '                        lblTotalItemSRP, _
    '                        lblTotalItemCount)

    '    Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

    '    Dim objCommand As New SqlCommand("Web_ItemsCount_Get", objConnection)
    '    objCommand.CommandType = CommandType.StoredProcedure
    '    objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

    '    objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))

    '    objConnection.Open()

    '    Dim objReader As SqlDataReader = objCommand.ExecuteReader
    '    objReader.Read()

    '    lblTotalItemCart.Text = Trim(objReader("totalItemCount"))

    '    objReader.Close()

    '    objCommand = New SqlCommand("Web_ItemsCart_Get", objConnection)
    '    objCommand.CommandType = CommandType.StoredProcedure

    '    objCommand.Parameters.Add("@FormAction", Request("FormAction"))
    '    objCommand.Parameters.Add("@id", Request("id"))
    '    objCommand.Parameters.Add("@Qty", Request("Qty"))
    '    objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))

    '    objReader = objCommand.ExecuteReader

    '    Dim myItemsCart As String = String.Empty

    '    While objReader.Read

    '        'Dim className As String = ""
    '        'Dim classPrice As String = ""

    '        'If counter = 1 Then
    '        '    className = "<div class='close1'>"
    '        'ElseIf counter = 2 Then
    '        '    className = "<div class='close2'>"
    '        'ElseIf counter = 3 Then
    '        '    className = "<div class='close3'>"
    '        'End If

    '        myItemsCart &= ("<tr>" & _
    '                            "<td>" & _
    '                                "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' class='at-in'>" & _
    '                                "<img src='" & Trim(objReader("image_path")) & "' class='img-responsive' alt=''>" & _
    '                            "</td>" & _
    '                            "<td class='w3-left-align'>" & _
    '                                "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' class='at-in'>" & _
    '                                "<h5>" & Trim(objReader("item_fullname")) & "</h5>" & _
    '                                "<div class=clearfix'></div>" & _
    '                            "</td>" & _
    '                            "<td class='w3-center'>&#8369;" & Trim(objReader("srp_show")) & "</td>" & _
    '                            "<td class='w3-center'>" & _
    '                                "<div class='quantity'>" & _
    '                                    "<input id='txtQty" & counter & "' min='1' type='number' value='" & Trim(objReader("qty")) & "' style='border:1px solid white;width: 110px;' class='w3-padding w3-center w3-text-black w3-border-deep-orange w3-hover-border-blue'>" & _
    '                                "</div>" & _
    '                            "</td>" & _
    '                            "<td class='w3-center'>&#8369;" & Trim(objReader("total_srp_show")) & "</td>" & _
    '                            "<td class='w3-center'>" & _
    '                                "<input type='submit' runat='server' class='btnUpdate w3-margin' name='" & Trim(objReader("id")) & "' value='UPDATE' id='btnUpdate" & counter & "' OnClick='btnUpdate_Click'>" & _
    '                                "<input type='submit' runat='server' class='btnDelete' name='" & Trim(objReader("id")) & "' value='Remove' id='btnDelete" & counter & "' OnClick='btnDelete_Click'>" & _
    '                            "</td>" & _
    '                            "<div style='display:none'><label id='lblSOH" & counter & "'>" & Trim(objReader("soh")) & "</label></div>" & _
    '                            "<label id='lblQty" & counter & "' style='display:none'>" & Trim(objReader("qty")) & "</label>" & _
    '                        "</tr>")

    '        counter = counter + 1

    '        'If counter > 3 Then
    '        '    counter = 1
    '        'End If

    '    End While

    '    Div1.InnerHtml = myItemsCart

    '    objReader.Close()

    '    objCommand = New SqlCommand("Web_ItemsCartTotal_Get", objConnection)
    '    objCommand.CommandType = CommandType.StoredProcedure

    '    objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))

    '    objReader = objCommand.ExecuteReader
    '    objReader.Read()

    '    lblTotalCartAmount.Text = Trim(objReader("total"))

    '    If lblTotalCartAmount.Text <> "0.00" Then
    '        btnCheckout.Visible = True
    '    Else
    '        btnCheckout.Visible = False
    '    End If

    '    objReader.Close()
    '    objConnection.Close()
    'End Sub

    Private Sub btnContinueShop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinueShop.Click
        Response.Redirect("sys_home")
    End Sub

    Private Sub btnCheckout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckout.Click
        Response.Redirect("checkout")
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Response.Redirect("item_search?char=" & txtSearch.Text)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        ' get the ID and Qty values from the button and input field
        Dim id As String = DirectCast(sender, Button).Attributes("name")
        Dim txtQty As TextBox = DirectCast(DirectCast(sender, Button).NamingContainer.FindControl("txtQty" & counter), TextBox)
        Dim qty As String = txtQty.Text

        ' redirect the user to the URL
        Response.Redirect("cart?&id=" & id & "&FormAction=Update&Qty=" & qty)
        'Refresh_Cart()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub
End Class
