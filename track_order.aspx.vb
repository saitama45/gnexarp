Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Public Class track_order
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
    Protected WithEvents txtOrderNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnTrack As System.Web.UI.WebControls.Button
    Protected WithEvents panelTimeline As System.Web.UI.WebControls.Panel
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label


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
           

        End If

    End Sub

    Private Sub btnTrack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTrack.Click        

        panelTimeline.Visible = True

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsShipping_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@order_no", txtOrderNo.text)      

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()

        Dim myItemsCart As String = String.Empty
        Dim preparing As String = String.Empty
        Dim preparing_msg As String = String.Empty
        Dim preparing_date As String = String.Empty

        Dim inTransit As String = String.Empty
        Dim inTransit_msg As String = String.Empty
        Dim inTransit_date As String = String.Empty

        Dim delivered As String = String.Empty
        Dim delivered_msg As String = String.Empty
        Dim delivered_date As String = String.Empty

        If Trim(objReader("approved_date")) <> "1/1/1900" Then
            preparing = "<li class='active'>"
            preparing_msg = "Started preparing your order."
            preparing_date = Trim(objReader("approved_date"))
        Else
            preparing = "<li class='inactive'>"
            preparing_msg = ""
            preparing_date = ""
        End If

        If Trim(objReader("dr_date")) <> "1/1/1900" Then
            inTransit = "<li class='active'>"
            inTransit_msg = "Yehey! Your order is on its way."
            inTransit_date = Trim(objReader("dr_date"))
        Else
            inTransit = "<li class='inactive'>"
            inTransit_msg = ""
            inTransit_date = ""
        End If

        If Trim(objReader("delivered_date")) <> "1/1/1900" Then
            delivered = "<li class='active'>"
            delivered_msg = "Thank you! We're excited to serve you again."
            delivered_date = Trim(objReader("delivered_date"))
        Else
            delivered = "<li class='inactive'>"
            delivered_msg = ""
            delivered_date = ""
        End If

        If Trim(objReader("order_no")) = "" Then
           
            myItemsCart &= ("<h4>I'm sorry, but the order number you provided does not exist.</h4>")

        Else            

            myItemsCart &= ("<ul class='timeline'>" & _
                                "<li class='active'>" & _
                                    "<h4><b>ON PROCESS</b></h4>" & _
                                    "<h5 class='mb-0 text-muted'>Order received.</h5>" & _
                                    "<h6 class='text-muted'>" & Trim(objReader("order_date")) & "</h6>" & _
                                "</li>" & _
                                preparing & _
                                    "<h4><b>PREPARING</b></h4>" & _
                                    "<h5 class='mb-0 text-muted'>" & preparing_msg & "</h5>" & _
                                    "<h6 class='text-muted'>" & preparing_date & "</h6>" & _
                                "</li>" & _
                                inTransit & _
                                    "<h4><b>IN TRANSIT</b></h4>" & _
                                    "<h5 class='mb-0 text-muted'>" & inTransit_msg & "</h5>" & _
                                    "<h6 class='text-muted'>" & inTransit_date & "</h6>" & _
                                "</li>" & _
                                delivered & _
                                    "<h4><b>DELIVERED</b></h4>" & _
                                    "<h5 class='mb-0 text-muted'>" & delivered_msg & "</h5>" & _
                                    "<h6 class='text-muted'>" & delivered_date & "</h6>" & _
                                "</li>" & _
                            "</ul>")
        End If

        Div1.InnerHtml = myItemsCart

        objReader.Close()
        objConnection.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Response.Redirect("item_search?char=" & txtSearch.Text)
    End Sub
End Class
