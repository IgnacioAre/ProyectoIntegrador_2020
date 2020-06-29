Imports System.Runtime.InteropServices
Public Class Menu

    Dim resizeBool = False

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
        resizeBool = False
    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
        resizeBool = True
    End Sub

    Private Sub tmrGif_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGif.Tick
        If tmrGif.Interval = 5600 Then
            gifCofre.Visible = False
            imgCofre.Visible = True
            tmrGif.Stop()
        End If
    End Sub



    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        TablaInicio.Hide()
    End Sub

    ''Llamamos a los metodos de mover el formulario
    Private Sub panelSuperior_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseMove
        If resizeBool Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
            panelSuperior.Cursor = Cursors.SizeAll
        Else
            panelSuperior.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub tmrOcultarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarMenu.Tick
        If Me.panelMenu.Width <= 60 Then
            Me.tmrOcultarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 10
        End If
    End Sub

    Private Sub tmrMostrarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarMenu.Tick
        If Me.panelMenu.Width >= 200 Then
            Me.tmrMostrarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 10
        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If Me.panelMenu.Width = 200 Then
            tmrOcultarMenu.Enabled = True
            imgLogo.Width = 249
        Else
            tmrMostrarMenu.Enabled = True
            imgLogo.Width = 291
        End If

    End Sub

    Private Sub btnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedores.Click
        Pruebas.Show()
    End Sub
End Class
