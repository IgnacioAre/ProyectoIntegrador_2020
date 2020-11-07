Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class ConfirmacionMensaje

    Public resultado As Byte = 0
    Public resultadoTxt As String
    Public soloNumBool As Boolean = False


    Function entradaDatos(ByVal mensaje As String)

        lblMensajeEntrada.Text = mensaje
        panelMensaje.Visible = False
        PanelEntrada.Visible = True
        Me.ShowDialog()

        Return resultadoTxt
    End Function

    Function confirmacion(ByVal mensaje As String)
        lblMensaje.Text = mensaje
        panelMensaje.Visible = True
        PanelEntrada.Visible = False
        Me.ShowDialog()

        Return resultado
    End Function


    Public Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        resultado = 1
        If Not txtEntrada.Text.Equals("") Then resultadoTxt = txtEntrada.Text
        txtEntrada.Text = ""
        Me.Close()
    End Sub

    Public Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        resultado = 0
        resultadoTxt = ""
        txtEntrada.Text = ""
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
        If soloNumBool Then

            If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
            txtEntrada.MaxLength = 15

        Else
            txtEntrada.MaxLength = 50
            If Not Char.IsLetter(e.KeyChar) And Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Not Char.IsWhiteSpace(e.KeyChar) And Asc(e.KeyChar) <> 46 Then
                If e.KeyChar = ChrW(Keys.Enter) Then
                    resultado = 1
                    If Not txtEntrada.Text.Equals("") Then resultadoTxt = txtEntrada.Text
                    txtEntrada.Text = ""
                    Me.Close()
                Else
                    e.Handled = True
                End If
            End If

        End If
        
    End Sub

    Private Sub ConfirmacionMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEntrada.Select()
        txtEntrada.Focus()
    End Sub
End Class
