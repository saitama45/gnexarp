Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class checkout
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
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl    
    Protected WithEvents lblOrderNo As System.Web.UI.WebControls.Label
    Protected WithEvents txtFullname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFirstname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtLastname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtHomeDetails As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBarangay As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCity As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtPostalCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMobileNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNotes As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCartTotalShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblCartTotal As System.Web.UI.WebControls.Label
    Protected WithEvents lblShippingFeeShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblShippingFee As System.Web.UI.WebControls.Label
    Protected WithEvents lblOrderTotalShow As System.Web.UI.WebControls.Label
    Protected WithEvents lblOrderTotal As System.Web.UI.WebControls.Label
    Protected WithEvents btnPlaceOrder As System.Web.UI.WebControls.Button
    Protected WithEvents txtFrom As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPass As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMailServer As System.Web.UI.WebControls.TextBox    
    Protected WithEvents ddlPaymentOption As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtRefNo As System.Web.UI.WebControls.TextBox    
    Protected WithEvents ddlEntity As System.Web.UI.WebControls.DropDownList
    Protected WithEvents panelRefNo As System.Web.UI.WebControls.Panel
    Protected WithEvents panelGCASH As System.Web.UI.WebControls.Panel
    Protected WithEvents panelBank As System.Web.UI.WebControls.Panel
    Protected WithEvents panelCompany As System.Web.UI.WebControls.Panel
    Protected WithEvents panelIndividual As System.Web.UI.WebControls.Panel

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

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand("Web_ItemsCart_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@FormAction", Request("FormAction"))
            objCommand.Parameters.Add("@id", Request("id"))
            objCommand.Parameters.Add("@Qty", Request("Qty"))
            objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))

            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader

            Dim myItemsCart As String = String.Empty
            Dim counter As Integer = 1

            While objReader.Read

                myItemsCart &= ("<tr>" & _
                                    "<td>" & _
                                        "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' class='at-in'>" & _
                                        "<h5>" & Trim(objReader("item_fullname")) & "</h5>" & _
                                        "<div class=clearfix'></div>" & _
                                    "</td>" & _
                                    "<td>&#8369;" & Trim(objReader("srp_show")) & "</td>" & _
                                    "<td>" & _
                                        Trim(objReader("qty")) & _
                                    "</td>" & _
                                    "<td>&#8369;" & Trim(objReader("total_srp_show")) & "</td>" & _
                                "</tr>")
            End While

            Div1.InnerHtml = myItemsCart

            objReader.Close()

            objCommand = New SqlCommand("Web_ItemsCartTotal_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))
            objCommand.Parameters.Add("@city", ddlCity.SelectedValue)

            objReader = objCommand.ExecuteReader
            objReader.Read()

            lblOrderNo.Text = Trim(objReader("order_no"))
            lblCartTotalShow.Text = Trim(objReader("total_show"))
            lblCartTotal.Text = Trim(objReader("total"))
            lblOrderTotalShow.Text = Trim(objReader("grand_total_show"))
            lblOrderTotal.Text = Trim(objReader("grand_total"))

            objReader.Close()

            objCommand = New SqlCommand("Ref_City_Get_droplist", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objReader = objCommand.ExecuteReader
            ddlCity.DataSource = objReader
            ddlCity.DataValueField = "code"
            ddlCity.DataTextField = "name"
            ddlCity.DataBind()
            ddlCity.Items.Insert(0, "")
            ddlCity.SelectedIndex = 0

            objReader.Close()
            objConnection.Close()
        End If

    End Sub

    Private Sub ddlCity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCity.SelectedIndexChanged

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        Dim objCommand As New SqlCommand("Ref_City_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@id", ddlCity.SelectedValue)

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        lblShippingFeeShow.Text = Trim(objReader("shipping_fee_show"))
        lblShippingFee.Text = Trim(objReader("shipping_fee"))

        objReader.Close()

        objCommand = New SqlCommand("Web_ItemsCartTotal_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))
        objCommand.Parameters.Add("@city", ddlCity.SelectedValue)

        objReader = objCommand.ExecuteReader
        objReader.Read()

        lblOrderTotalShow.Text = Trim(objReader("grand_total_show"))
        lblOrderTotal.Text = Trim(objReader("grand_total"))

        objReader.Close()
        objConnection.Close()

        SetFocus(txtPostalCode)
    End Sub
    Private Sub btnPlaceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        
        'Save_Shipping()

        'Save_Shipping2()

    End Sub

    Private Sub ddlPaymentOption_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPaymentOption.SelectedIndexChanged
        If ddlPaymentOption.SelectedValue = "GCASH" Then
            panelRefNo.Visible = True
            panelGCASH.Visible = True
            panelBank.Visible = False

        ElseIf ddlPaymentOption.SelectedValue = "BANK" Then
            panelRefNo.Visible = True
            panelBank.Visible = True
            panelGCASH.Visible = False

        Else
            panelRefNo.Visible = False
            panelGCASH.Visible = False
            panelBank.Visible = False

        End If

    End Sub

    Private Sub ddlEntity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlEntity.SelectedIndexChanged
        If ddlEntity.SelectedValue = "2" Then
            panelCompany.Visible = True
            panelIndividual.Visible = False
        Else
            panelCompany.Visible = False
            panelIndividual.Visible = True
        End If
    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').select() </SCRIPT>"
        RegisterStartupScript("select", s)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Response.Redirect("item_search?char=" & txtSearch.Text)
    End Sub
End Class
