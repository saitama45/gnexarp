Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.Web.Mail

Public Class item_search
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents lblCompanyName As System.Web.UI.WebControls.Label
    Protected WithEvents lblName As System.Web.UI.WebControls.Label
    Protected WithEvents TopMenuCategories As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblTotalItemSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItemCount As System.Web.UI.WebControls.Label
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents CategoryPages As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents btnPrev As System.Web.UI.WebControls.Button
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents txtCurrentPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPageTotal As System.Web.UI.WebControls.Label

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

            Sys_Class.TopMenu(lblCompanyName, _
                               TopMenuCategories, _
                               Session("NoLoginClient_Cookie"), _
                               lblTotalItemSRP, _
                               lblTotalItemCount)

            lblName.Text = Request("char")

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            objConnection.Open()

            Dim objCommand As New SqlCommand("Web_ItemsSearch_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@page_num", 0)
            objCommand.Parameters.Add("@search_char", Request("char"))

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            Dim newArrivalItems As String = String.Empty
            Dim counter As Integer = 1

            While objReader.Read

                Dim className As String = ""
                Dim classPrice As String = ""

                If counter = 1 Then
                    className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.5s'>"
                ElseIf counter = 2 Then
                    className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.7s'>"
                ElseIf counter = 3 Then
                    className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.9s'>"
                ElseIf counter = 4 Then
                    className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='1.1s'>"
                End If

                If Trim(objReader("orig_srp")) = 0 Then
                    classPrice = ("<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
                Else
                    classPrice = ("<p class='pric1'><del>&#8369;" & Trim(objReader("orig_srp")) & "</del></p>" & _
                                  "<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
                End If

                newArrivalItems &= (className & _
                                        "<div class='new-top'>" & _
                                            "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' offer-img><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''>" & _
                                        "</div>" & _
                                        "<div class='new-bottom'>" & _
                                            "<h4><a class='name' href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "'>" & Trim(objReader("item")) & "</a></h4>" & _
                                            "<div class='rating'>" & _
                                                "<span></span>" & _
                                            "</div>" & _
                                            "<div class='ofr'>" & _
                                                classPrice & _
                                            "</div>" & _
                                        "</div>" & _
                                    "</div>")

                counter = counter + 1

                If counter > 4 Then
                    counter = 1
                End If

            End While

            Div1.InnerHtml = newArrivalItems

            objReader.Close()

            objCommand = New SqlCommand("Web_ItemsSearchPageCount_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.Add("@search_char", Request("char"))

            objReader = objCommand.ExecuteReader
            objReader.Read()

            lblPageTotal.Text = Trim(objReader("page_total"))

            objReader.Close()
            objConnection.Close()

            Refresh_PagingButton()

        End If

    End Sub
    Private Sub Refresh_PagingButton()
        If lblPageTotal.Text = txtCurrentPage.Text Then
            btnNext.Enabled = False
            btnPrev.Enabled = True
        End If

        If txtCurrentPage.Text = 1 Then
            btnPrev.Enabled = False

            If lblPageTotal.Text = txtCurrentPage.Text Then
                btnNext.Enabled = False
            Else
                btnNext.Enabled = True
            End If
        End If
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Response.Redirect("item_search?char=" & txtSearch.Text)
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Refresh_NextPage()
        Refresh_PagingButton()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        Refresh_PrevPage()
        Refresh_PagingButton()
    End Sub
    Private Sub Refresh_NextPage()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsSearch_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text + 1)
        objCommand.Parameters.Add("@search_char", Request("char"))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim newArrivalItems As String = String.Empty
        Dim counter As Integer = 1

        While objReader.Read

            Dim className As String = ""
            Dim classPrice As String = ""

            If counter = 1 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.5s'>"
            ElseIf counter = 2 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.7s'>"
            ElseIf counter = 3 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.9s'>"
            ElseIf counter = 4 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='1.1s'>"
            End If

            If Trim(objReader("orig_srp")) = 0 Then
                classPrice = ("<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            Else
                classPrice = ("<p class='pric1'><del>&#8369;" & Trim(objReader("orig_srp")) & "</del></p>" & _
                              "<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            End If

            newArrivalItems &= (className & _
                                    "<div class='new-top'>" & _
                                        "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' offer-img><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''>" & _
                                    "</div>" & _
                                    "<div class='new-bottom'>" & _
                                        "<h4><a class='name' href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "'>" & Trim(objReader("item")) & "</a></h4>" & _
                                        "<div class='rating'>" & _
                                            "<span></span>" & _
                                        "</div>" & _
                                        "<div class='ofr'>" & _
                                            classPrice & _
                                        "</div>" & _
                                    "</div>" & _
                                "</div>")

            counter = counter + 1

            If counter > 4 Then
                counter = 1
            End If

        End While

        Div1.InnerHtml = newArrivalItems

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text + 1

    End Sub
    Private Sub Refresh_PrevPage()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsSearch_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text - 1)
        objCommand.Parameters.Add("@search_char", Request("char"))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim newArrivalItems As String = String.Empty
        Dim counter As Integer = 1

        While objReader.Read

            Dim className As String = ""
            Dim classPrice As String = ""

            If counter = 1 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.5s'>"
            ElseIf counter = 2 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.7s'>"
            ElseIf counter = 3 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.9s'>"
            ElseIf counter = 4 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='1.1s'>"
            End If

            If Trim(objReader("orig_srp")) = 0 Then
                classPrice = ("<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            Else
                classPrice = ("<p class='pric1'><del>&#8369;" & Trim(objReader("orig_srp")) & "</del></p>" & _
                              "<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            End If

            newArrivalItems &= (className & _
                                    "<div class='new-top'>" & _
                                        "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' offer-img><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''>" & _
                                    "</div>" & _
                                    "<div class='new-bottom'>" & _
                                        "<h4><a class='name' href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "'>" & Trim(objReader("item")) & "</a></h4>" & _
                                        "<div class='rating'>" & _
                                            "<span></span>" & _
                                        "</div>" & _
                                        "<div class='ofr'>" & _
                                            classPrice & _
                                        "</div>" & _
                                    "</div>" & _
                                "</div>")

            counter = counter + 1

            If counter > 4 Then
                counter = 1
            End If

        End While

        Div1.InnerHtml = newArrivalItems

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text - 1

    End Sub
    '****DO NOT TOUCH THIS ****
    Private Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "<SCRIPT language='javascript'>document.getElementById('" & ctrl.ID & "').focus() </SCRIPT>"
        RegisterStartupScript("focus", s)
    End Sub

    Private Sub txtCurrentPage_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentPage.TextChanged
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsSearch_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@page_num", txtCurrentPage.Text)
        objCommand.Parameters.Add("@search_char", Request("char"))

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim newArrivalItems As String = String.Empty
        Dim counter As Integer = 1

        While objReader.Read

            Dim className As String = ""
            Dim classPrice As String = ""

            If counter = 1 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.5s'>"
            ElseIf counter = 2 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.7s'>"
            ElseIf counter = 3 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.9s'>"
            ElseIf counter = 4 Then
                className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='1.1s'>"
            End If

            If Trim(objReader("orig_srp")) = 0 Then
                classPrice = ("<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            Else
                classPrice = ("<p class='pric1'><del>&#8369;" & Trim(objReader("orig_srp")) & "</del></p>" & _
                              "<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            End If

            newArrivalItems &= (className & _
                                    "<div class='new-top'>" & _
                                        "<a href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "' offer-img><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''>" & _
                                    "</div>" & _
                                    "<div class='new-bottom'>" & _
                                        "<h4><a class='name' href='item?&code=" & Trim(objReader("code")) & "&item=" & Trim(objReader("item_fullname")) & "'>" & Trim(objReader("item")) & "</a></h4>" & _
                                        "<div class='rating'>" & _
                                            "<span></span>" & _
                                        "</div>" & _
                                        "<div class='ofr'>" & _
                                            classPrice & _
                                        "</div>" & _
                                    "</div>" & _
                                "</div>")

            counter = counter + 1

            If counter > 4 Then
                counter = 1
            End If

        End While

        Div1.InnerHtml = newArrivalItems

        objReader.Close()
        objConnection.Close()

        txtCurrentPage.Text = txtCurrentPage.Text

        Refresh_PagingButton()
    End Sub
End Class
