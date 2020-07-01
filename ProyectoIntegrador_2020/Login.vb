Imports System.Runtime.InteropServices
Public Class Login

    '----CLAVE PARA CREAR UN USUARIO ADMIN----'
    Dim claveAdmin As String = "7r7w7x"


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----INICIO DEL FORMULARIO----'

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SendMessage(txtUsuario.Handle, EM_SETCUEBANNER, 0, "Nombre de usuario")
        SendMessage(txtContraseña.Handle, EM_SETCUEBANNER, 0, "*******************")
    End Sub

    '----CAMBIAR FOCO A LA CONTRASEÑA----'

    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtContraseña.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        panelLogin.Visible = False
        panelRegistro.Visible = True
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        panelLogin.Visible = True
        panelRegistro.Visible = False
    End Sub

    '----CAMBIAR TAMAÑO DEL pbRegresar----'

    Private Sub pbRegresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.MouseHover
        pbRegresar.Size = New Size(34, 36)
    End Sub

    Private Sub pbRegresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.MouseLeave
        pbRegresar.Size = New Size(31, 32)
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub
End Class