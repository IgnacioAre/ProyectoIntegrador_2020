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
        panelTitulo.Cursor = Cursors.SizeAll
        btnCerrar.Cursor = Cursors.Default
        btnMinimizar.Cursor = Cursors.Default
    End Sub

    '----MÉTODO PARA REDONDEAR EL BOTÓN ENTRAR----'

    Private Sub btnEntrar_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btnEntrar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnEntrar.ClientRectangle
        myRectangle.Inflate(-3, -3)
        buttonPath.AddEllipse(myRectangle)
        btnEntrar.Region = New Region(buttonPath)
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

End Class