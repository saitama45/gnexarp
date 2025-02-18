Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.Web.Mail
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography


Public Class sys_home
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
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Div2 As System.Web.UI.HtmlControls.HtmlGenericControl
   
    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()

        ' Check if cookie exists
        Dim objCookie As HttpCookie = Request.Cookies(ConfigurationSettings.AppSettings("userShop"))

        If Not IsNothing(objCookie) Then
            ' Cookie exists, do something            
            Session("NoLoginClient_Cookie") = objCookie.Value
            ' ...
        Else
            ' Cookie does not exist, create it
            Dim randomBytes(15) As Byte
            Dim rng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider
            rng.GetBytes(randomBytes)

            Dim randomString As String = Convert.ToBase64String(randomBytes)
            Dim cookieValue As String = HttpUtility.UrlEncode(randomString)

            Dim objNewCookie As HttpCookie = New HttpCookie(ConfigurationSettings.AppSettings("userShop"), cookieValue)

            objNewCookie.Expires = DateTime.UtcNow.AddMonths(6)
            Response.Cookies.Add(objNewCookie)            

            Session("NoLoginClient_Cookie") = objNewCookie.Value
        End If
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    

        If Not Page.IsPostBack Then

            Sys_Class.TopMenu(lblCompanyName, _
                              TopMenuCategories, _
                              Session("NoLoginClient_Cookie"), _
                              lblTotalItemSRP, _
                              lblTotalItemCount)

            'Dim myMail As MailMessage
            'myMail = New MailMessage
            'myMail.From = "gen@mykey.ph"
            'myMail.To = "genermagbanua45@gmail.com"
            'myMail.Subject = "UtilMailMessage001"
            'myMail.Priority = MailPriority.Low
            'myMail.BodyFormat = MailFormat.Html
            'myMail.Body = "<html><body>UtilMailMessage001 - success</body></html>"

            '' set SMTP server name
            'myMail.Fields(("http://schemas.microsoft.com/cdo/configuration/smtpserver")) = "mail5006.site4now.net"
            '' set SMTP server port
            'myMail.Fields(("http://schemas.microsoft.com/cdo/configuration/smtpserverport")) = 25
            ''myMail.Fields(("http://schemas.microsoft.com/" + "cdo/configuration/sendusing")) = 2
            ''myMail.Fields(("http://schemas.microsoft.com/cdo/" + "configuration/smtpauthenticate")) = 1
            '' set SMTP username
            'myMail.Fields(("http://schemas.microsoft.com/cdo/configuration/sendusername")) = "gen@mykey.ph"
            '' set SMTP user password
            'myMail.Fields(("http://schemas.microsoft.com/cdo/configuration/sendpassword")) = "myPassword"

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

            Dim objCommand As New SqlCommand("Web_ItemsPromo_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

            objCommand.Parameters.Add("@id", 0)

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

                'newArrivalItems &= (className & _
                '                        "<div class='w3-tag w3-round w3-red' style='padding:3px'>" & _
                '                            "<div class='w3-tag w3-round w3-red w3-border w3-border-white'>" & _
                '                                "Sale" & _
                '                            "</div>" & _
                '                        "</div>" & _
                '                        "<div class='new-top'>" & _
                '                            "<a href='item?&code=" & Trim(objReader("rm_code")) & "&item=" & Trim(objReader("item_fullname")) & "' offer-img><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''>" & _
                '                        "</div>" & _
                '                        "<div class='new-bottom'>" & _
                '                            "<h4><a class='name' href='item?&code=" & Trim(objReader("rm_code")) & "&item=" & Trim(objReader("item_fullname")) & "'>" & Trim(objReader("item")) & "</a></h4>" & _
                '                            "<div class='rating'>" & _
                '                                "<span></span>" & _
                '                            "</div>" & _
                '                            "<div class='ofr'>" & _
                '                                classPrice & _
                '                            "</div>" & _
                '                        "</div>" & _
                '                    "</div>")

                newArrivalItems &= (className & _                                       
                                       "<div class='new-top'>" & _
                                           "<a href='item?&code=" & Trim(objReader("rm_code")) & "&item=" & Trim(objReader("item_fullname")) & "' offer-img><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''>" & _
                                       "</div>" & _
                                       "<div class='new-bottom'>" & _
                                           "<h4><a class='name' href='item?&code=" & Trim(objReader("rm_code")) & "&item=" & Trim(objReader("item_fullname")) & "'>" & Trim(objReader("item")) & "</a></h4>" & _
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

            'Dim newArrivalItems As New StringBuilder
            'Dim counter As Integer = 1

            'While objReader.Read()
            '    ' ... your existing code ...
            '    Dim className As String = ""
            '    Dim classPrice As String = ""

            '    If counter = 1 Then
            '        className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.5s'>"
            '    ElseIf counter = 2 Then
            '        className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.7s'>"
            '    ElseIf counter = 3 Then
            '        className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='.9s'>"
            '    ElseIf counter = 4 Then
            '        className = "<div class='w3-col l3 m3 s6 w3-border w3-border-blue simpleCart_shelfItem wow flipInY animated' data-wow-delay='1.1s'>"
            '    End If

            '    If Trim(objReader("orig_srp")) = 0 Then
            '        classPrice = ("<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            '    Else
            '        classPrice = ("<p class='pric1'><del>&#8369;" & Trim(objReader("orig_srp")) & "</del></p>" & _
            '                      "<p><span class='item_price'>&#8369;" & Trim(objReader("current_srp")) & "</span></p>")
            '    End If

            '    newArrivalItems.Append(className)
            '    newArrivalItems.Append("<div class='new-top'>")
            '    newArrivalItems.AppendFormat("<a href='item?&code={0}&item={1}' offer-img><img src='{2}' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''></a>", Trim(objReader("rm_code")), Trim(objReader("item_fullname")), Trim(objReader("image_path")))
            '    newArrivalItems.Append("</div>")
            '    newArrivalItems.Append("<div class='new-bottom'>")
            '    newArrivalItems.AppendFormat("<h4><a class='name' href='item?&code={0}&item={1}'>{2}</a></h4>", Trim(objReader("rm_code")), Trim(objReader("item_fullname")), Trim(objReader("item")))
            '    newArrivalItems.Append("<div class='rating'>")
            '    newArrivalItems.Append("<span></span>")
            '    newArrivalItems.Append("</div>")
            '    newArrivalItems.Append("<div class='ofr'>")
            '    newArrivalItems.Append(classPrice)
            '    newArrivalItems.Append("<br/><p class='pric1'>")

            '    ' Add the button with a unique ID
            '    Dim btnAddToCart As New System.Web.UI.WebControls.Button
            '    btnAddToCart.ID = "btnAddToCart_" & counter
            '    btnAddToCart.CssClass = "w3-btn w3-blue"
            '    btnAddToCart.Text = "Add to Cart"
            '    'btnAddToCart.Attributes("AutoPostBack") = True
            '    btnAddToCart.Attributes("OnClick") = "btnAddToCart_Click();"
            '    btnAddToCart.Attributes("runat") = "server"
            '    'AddHandler btnAddToCart.Click, AddressOf btnAddToCart_Click

            '    ' Render the button
            '    Dim writer As New StringWriter
            '    Dim htmlWriter As New HtmlTextWriter(writer)
            '    btnAddToCart.RenderControl(htmlWriter)
            '    newArrivalItems.Append(writer.ToString())

            '    newArrivalItems.Append("</p>")
            '    newArrivalItems.Append("</div>")
            '    newArrivalItems.Append("</div>")
            '    newArrivalItems.Append("</div>")

            '    counter += 1

            '    If counter > 4 Then
            '        counter = 1
            '    End If
            'End While

            'Div1.InnerHtml = newArrivalItems.ToString()

            objReader.Close()

            objCommand = New SqlCommand("Ref_Categories_Get", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objReader = objCommand.ExecuteReader

            Dim Categories As String = String.Empty
            Dim cat_counter As Integer = 1

            While objReader.Read

                Dim className As String = ""
                Dim classPrice As String = ""

                If cat_counter = 1 Then
                    className = "<div class='col-md-3 gallery-grid wow flipInY animated' data-wow-delay='.5s'>"
                ElseIf cat_counter = 2 Then
                    className = "<div class='col-md-3 gallery-grid gallery-grid1 wow flipInY animated' data-wow-delay='.7s'>"
                ElseIf cat_counter = 3 Then
                    className = "<div class='col-md-3 gallery-grid gallery-grid2 wow flipInY animated' data-wow-delay='.9s'>"
                ElseIf cat_counter = 4 Then
                    className = "<div class='col-md-3 gallery-grid wow flipInY animated' data-wow-delay='1.1s'>"
                End If

                Categories &= (className & _
                                "<a href='item_category?&id=" & Trim(objReader("id")) & "'><img src='" & Trim(objReader("image_path")) & "' style='object-fit: cover;width: 200px; height: 200px' class='img-responsive' alt=''/></a>" & _
                                    "<div class='gallery-text simpleCart_shelfItem'>" & _
                                    "<h5><a class='name' href='item_category?&id=" & Trim(objReader("id")) & "'>" & Trim(objReader("name")) & "</a></h5>" & _
                                "</div>" & _
                              "</div>")

                cat_counter = cat_counter + 1

                If cat_counter > 4 Then
                    cat_counter = 1
                End If

            End While

            Div2.InnerHtml = Categories

            objReader.Close()
            objConnection.Close()

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


End Class
