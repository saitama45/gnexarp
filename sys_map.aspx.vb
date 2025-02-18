Imports System.Web.Mail
Public Class sys_map
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        'Dim oMessage As New System.Web.Mail.MailMessage


        'oMessage.To = "gmcloud45@gmail.com"

        'oMessage.From = "genermagbanua45@gmail.com"

        'oMessage.Subject = "Test message sent using System.Web.Mail"

        'oMessage.Body = "This is a test message."

        'oMessage.Fields.Item("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        'oMessage.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "smtp.gmail.com"

        'oMessage.Fields.Item("http://schemas.microsoft.com/cdo/configuration/sendusername") = "gmcloud45@gmail.com"

        'oMessage.Fields.Item("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "omygymsmzyfenskl"

        'oMessage.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = 1

        'System.Web.Mail.SmtpMail.SmtpServer = "smtp.gmail.com"



        'Try

        '    System.Web.Mail.SmtpMail.Send(oMessage)

        '    Response.Write("Email sent!")

        'Catch Ex As Exception

        '    Response.Write("Unable to send mail!  " & Ex.Message)

        'End Try

        'Dim MyMail As Object

        'MyMail = Server.CreateObject("Persits.MailSender")

        'MyMail.Host = "smtp.gmail.com"

        'MyMail.body = "This is a test message."

        'MyMail.IsHTML = True

        'MyMail.From = "gmcloud45@gmail.com"

        'MyMail.Username = "gmcloud45@gmail.com"

        'MyMail.Password = "omygymsmzyfenskl"

        'MyMail.AddAddress("genermagbanua45@gmail.com")

        'MyMail.Subject = "Test message sent using the ASPEmail component"



        'If MyMail.Send Then

        '    Response.Write("Message Sent")

        'Else

        '    Response.Write("Message Not Sent")

        'End If

        'MyMail = Nothing
    End Sub

End Class
