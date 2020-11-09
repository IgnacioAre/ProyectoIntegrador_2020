Imports System.Net.Mail
Imports System.Net

Module moduloCorreo

    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String)
        Try
            correos.To.Clear()
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "diagonal.dnsrou.com" 'Google: "smtp.gmail.com"
            envios.Port = 587 'Google: 465
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria | New Visual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox("En caso de no poder recibir el correo puede crearse otra cuenta de usuario administrador o contactese con el desarrollador.")
        End Try
    End Sub


End Module