Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class ConfirmacionMensaje

    Public confirmacionResult As Byte = 0

    Public Function confirmacion(ByVal mensaje As String)
        lblMensaje.Text = mensaje
        Return DialogResult
    End Function

    Public Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        confirmacionResult = 1
        Me.Hide()
        If MenuPrincipal.cerrarMenuP Then MenuPrincipal.Close()
    End Sub

    Public Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        confirmacionResult = 0
        Me.Close()
    End Sub

    '----MÉTODOS PARA MOVER EL FORMULARIO----'

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelTitulo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblTitulo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrada.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Not Char.IsWhiteSpace(e.KeyChar) And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub
End Class
