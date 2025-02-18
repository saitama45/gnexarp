Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Configuration
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Web
Imports System.Web.Mail
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Net.WebClient

Public Class SendEmail
    Inherits System.Web.UI.Page
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents pnlContentMgmt As System.Web.UI.WebControls.Panel
    Protected WithEvents txtcc As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtbcc As System.Web.UI.WebControls.TextBox
    Protected WithEvents attachFile1 As System.Web.UI.HtmlControls.HtmlInputFile
    Protected hdnmsg As System.Web.UI.HtmlControls.HtmlInputHidden

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()


    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        attachFile1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Attributes.Add("onClick", "javascript:fillTxt();")
        Dim attach1 As String = ""
        Dim strFileName As String = ""
        Dim message As New MailMessage
        If (attachFile1.PostedFile.FileName <> "") Then
            Dim ulFile As HttpPostedFile = attachFile1.PostedFile
            Dim nFileLen As Int64 = ulFile.ContentLength
            If (nFileLen > 0) Then
                strFileName = Path.GetFileName(attachFile1.PostedFile.FileName)
                strFileName = "Uploads/" + strFileName
                attachFile1.PostedFile.SaveAs(Server.MapPath(strFileName))
                Dim attach As MailAttachment = New MailAttachment(Server.MapPath(strFileName))
                message.Attachments.Add(attach)
                attach1 = strFileName
            End If
        End If
        message.From = TextBox2.Text
        message.To = TextBox3.Text
        message.Cc = txtcc.Text
        message.Bcc = txtbcc.Text
        message.Subject = TextBox4.Text
        message.Body = hdnmsg.Value
        message.BodyFormat = MailFormat.Html
        SmtpMail.SmtpServer.Insert(0, "127.0.0.1")
        SmtpMail.Send(message)
        If (attach1 <> "") Then
            File.Delete(Server.MapPath(attach1))
        End If
        Response.Flush()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        txtcc.Text = ""
        txtbcc.Text = ""
        lblMessage.Visible = True
        lblMessage.ForeColor = Color.Red
        lblMessage.Text = "Your email has been sent"
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        attachFile1.Visible = True
    End Sub
End Class
