Imports Microsoft.VisualBasic
Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class clsEmail

    'Public Shared Function SendEmail(ByVal emailx As String, ByVal subjectx As String, ByVal filex As String, ByVal messageLink As String, ByVal controlx As Control) As String


    '    Try
    '        'Dim fromaddr As String = "test@gmail.com"
    '        'Dim password As String = "pword"
    '        'Dim strHostName As String = "smtp.gmail.com"
    '        'Dim intPort As Integer = 587

    '        '  Dim fromaddr As String = "donotreply@systems.easyways.co.uk"
    '        '  Dim password As String = "d7jh6kH4J2HG"
    '        '  Dim strHostName As String = "mail.systems.easyways.co.uk"
    '        '  Dim intPort As Integer = 25

    '        If emailx <> "" Then
    '            'Dim fromaddr As String = "donotreply@systems.easyways.co.uk"
    '            'Dim password As String = "d7jh6kH4J2HG"
    '            'Dim strHostName As String = "mail.placetheball.com"

    '            Dim fromaddr As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFrom"))
    '            Dim password As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFromPass"))
    '            Dim strHostName As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailHost"))

    '            Dim Message As New MailMessage()
    '            Dim smtp As SmtpClient

    '            Message.From = New MailAddress(fromaddr)
    '            smtp = New SmtpClient()
    '            smtp.Host = strHostName
    '            smtp.Port = 587
    '            smtp.EnableSsl = True
    '            ' smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
    '            ' smtp.UseDefaultCredentials = False
    '            smtp.Credentials = New NetworkCredential(fromaddr, password)
    '            smtp.TargetName = "STARTTLS/smtp.gmail.com"
    '            Dim attch As Attachment = New Attachment(messageLink)
    '            Message.IsBodyHtml = True
    '            Message.Body = filex
    '            Message.Subject = subjectx
    '            Message.Attachments.Add(attch)
    '            Message.[To].Add(emailx)
    '            smtp.Send(Message)
    '            Return "Success"
    '        Else
    '            Return "Email Id Not Available"
    '        End If
    '    Catch ex As Exception
    '        HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
    '        HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
    '    End Try
    '    Return "Error in mail sending"
    'End Function
    Public Shared Function SendEmail(ByVal emailx As String, ByVal subjectx As String, ByVal filex As String, ByVal messageLink As Byte(), ByVal controlx As Control) As String


        Try

            If emailx <> "" Then

                Dim fromaddr As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFrom"))
                Dim password As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFromPass"))
                Dim strHostName As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailHost"))
                Dim intPort As Integer = 0
                Integer.TryParse(System.Configuration.ConfigurationManager.AppSettings("MailPort"), intPort)
                Dim strEnableSsl As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("EnableSsl"))

                Dim Message As New MailMessage()
                Dim smtp As SmtpClient

                Message.From = New MailAddress(fromaddr)
                smtp = New SmtpClient()
                smtp.Host = strHostName
                'smtp.Port = 587
                If intPort > 0 Then
                    smtp.Port = intPort
                End If
                If strEnableSsl = "True" Then
                    smtp.EnableSsl = True
                End If
                ' smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
                ' smtp.UseDefaultCredentials = False
                smtp.Credentials = New NetworkCredential(fromaddr, password)
                'smtp.TargetName = "STARTTLS/smtp.gmail.com"
                Dim MemoryStream As MemoryStream = New MemoryStream(messageLink)
                Dim attch As Attachment = New Attachment(MemoryStream, "Invoice.pdf")

                Message.IsBodyHtml = True
                Message.Body = filex
                Message.Subject = subjectx
                Message.Attachments.Add(attch)
                Message.[To].Add(emailx)
                smtp.Send(Message)
                Return "Success"
            Else
                Return "Email Id Not Available"
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return "Error in mail sending"
    End Function
    Public Shared Function SendPassword(ByVal emailx As String, ByVal subjectx As String, ByVal filex As String, ByVal controlx As Control) As String


        Try

            If emailx <> "" Then

                Dim fromaddr As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFrom"))
                Dim password As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFromPass"))
                Dim strHostName As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailHost"))
                Dim intPort As Integer = 0
                Integer.TryParse(System.Configuration.ConfigurationManager.AppSettings("MailPort"), intPort)
                Dim strEnableSsl As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("EnableSsl"))

                Dim Message As New MailMessage()
                Dim smtp As SmtpClient

                Message.From = New MailAddress(fromaddr)
                smtp = New SmtpClient()
                smtp.Host = strHostName
                'smtp.Port = 587
                If intPort > 0 Then
                    smtp.Port = intPort
                End If
                If strEnableSsl = "True" Then
                    smtp.EnableSsl = True
                End If
                ' smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
                ' smtp.UseDefaultCredentials = False
                smtp.Credentials = New NetworkCredential(fromaddr, password)
                'smtp.TargetName = "STARTTLS/smtp.gmail.com"


                Message.IsBodyHtml = True
                Message.Body = filex
                Message.Subject = subjectx
                Message.[To].Add(emailx)
                smtp.Send(Message)
                Return "Success"
            Else
                Return "Email Id Not Available"
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return "Error in mail sending"
    End Function

    Public Shared Function SendReport(ByVal emailx As String, ByVal subjectx As String, ByVal filex As String, ByVal Attachfilex As String, ByVal messageLink As Byte(), ByVal controlx As Control) As String


        Try

            If emailx <> "" Then

                Dim fromaddr As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFrom"))
                Dim password As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailFromPass"))
                Dim strHostName As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("MailHost"))
                Dim intPort As Integer = 0
                Integer.TryParse(System.Configuration.ConfigurationManager.AppSettings("MailPort"), intPort)
                Dim strEnableSsl As String = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("EnableSsl"))

                Dim Message As New MailMessage()
                Dim smtp As SmtpClient

                Message.From = New MailAddress(fromaddr)
                smtp = New SmtpClient()
                smtp.Host = strHostName
                'smtp.Port = 587
                If intPort > 0 Then
                    smtp.Port = intPort
                End If
                If strEnableSsl = "True" Then
                    smtp.EnableSsl = True
                End If
                ' smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
                ' smtp.UseDefaultCredentials = False
                smtp.Credentials = New NetworkCredential(fromaddr, password)
                'smtp.TargetName = "STARTTLS/smtp.gmail.com"
                Dim MemoryStream As MemoryStream = New MemoryStream(messageLink)
                Dim attch As Attachment = New Attachment(MemoryStream, Attachfilex)

                Message.IsBodyHtml = True
                Message.Body = filex
                Message.Subject = subjectx
                Message.Attachments.Add(attch)
                Message.[To].Add(emailx)
                smtp.Send(Message)
                Return "Success"
            Else
                Return "Email Id Not Available"
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return "Error in mail sending"
    End Function




End Class
