Imports System.Runtime.InteropServices
Public Class MenuPrincipal

    Dim moverMenuBool As Boolean = False
    Dim submenuClienteBool As Boolean = False
    Dim submenuProveedorBool As Boolean = False
    Dim submenuProductoBool As Boolean = False
    Public resultado As Byte
    Public resultadoTxt As String
    Public idIngresoAdmin As Byte

    '----FORMULARIO QUE SE VA A MOSTRAR ENCIMA DEL FORMULARIO PRINCIPAL----'
    Private formulario As Form
    Public formularioBool As Boolean = False


    '----INICIO DEL FORMULARIO----'

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("./audio/dinero.wav", AudioPlayMode.Background)
        SendMessage(txtPrecioProductos.Handle, EM_SETCUEBANNER, 0, "Nombre del producto")
    End Sub

    Public confirmacionResult As Byte = 0
    Private Sub MenuPrincipal_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        ConfirmacionMensaje.Show()
        ConfirmacionMensaje.confirmacion("                     ¿Desea Salir?")

        If confirmacionResult = 1 Then
            confirmacion()
        Else
            e.Cancel = True
        End If
    End Sub


    '----CIERRA EL FORUMULARIO DEL MENÚ (Y FINALIZA SU EJECUCIÓN)----'
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        ConfirmacionMensaje.Show()
        ConfirmacionMensaje.confirmacion("                     ¿Desea Salir?")
    End Sub

    Public Sub confirmacion()
        If formularioBool Then formulario.Close()
        formularioBool = False
    End Sub


    '----MINIMIZA EL FORUMULARIO DEL MENÚ----'

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '----MAXIMIZA EL FORUMULARIO DEL MENÚ----'

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
        moverMenuBool = False
    End Sub

    '----RESTAURA EL FORUMULARIO DEL MENÚ----'

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
        moverMenuBool = True
    End Sub

    '----TIEMPO QUE SE EJECUTA EL GIF DEL COFRE----'

    Private Sub tmrGif_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGif.Tick
        If tmrGif.Interval = 5600 Then
            gifCofre.Visible = False
            imgCofre.Visible = True
            tmrGif.Stop()
        End If
    End Sub

    '----MÉTODOS PARA MOVER EL FORMULARIO----'

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelSuperior_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseMove
        If moverMenuBool Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        End If
    End Sub

    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----DESLPEGAR Y CONTRAER MENÚ LATERAL----'

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If Me.panelMenu.Width = 236 Then
            tmrOcultarMenu.Enabled = True
            imgLogo.Width = 249
            lblTituloVentana.Location = New Point(64, 6)
            If submenuClienteBool Then
                submenuClienteBool = False
                tmrOcultarSubMenu.Enabled = True
            ElseIf submenuProductoBool Then
                submenuProductoBool = False
                tmrOcultarSubMenu.Enabled = True
            ElseIf submenuProveedorBool Then
                submenuProveedorBool = False
                tmrOcultarSubMenu.Enabled = True
            End If

        Else
            tmrMostrarMenu.Enabled = True
            imgLogo.Width = 291
            lblTituloVentana.Location = New Point(241, 6)
        End If
    End Sub

    Private Sub tmrMostrarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarMenu.Tick
        If Me.panelMenu.Width >= 236 Then
            Me.tmrMostrarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 10
        End If
    End Sub

    Private Sub tmrOcultarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarMenu.Tick
        If Me.panelMenu.Width <= 60 Then
            Me.tmrOcultarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 10
        End If
    End Sub

    '----DESLPEGAR Y CONTRAER SUBMENUS----'

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        If Not submenuClienteBool Then
            submenuClientes.Height = 1
            submenuClientes.Visible = True

            If Me.panelMenu.Width < 236 Then
                tmrMostrarMenu.Enabled = True
                imgLogo.Width = 291
            End If

            submenuFalse()
            submenuClienteBool = True

            tmrOcultarSubMenu.Enabled = True
            tmrMostrarSubMenu.Enabled = True
        Else
            submenuClienteBool = False

            tmrOcultarSubMenu.Enabled = True
        End If
    End Sub

    Private Sub btnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedores.Click
        If Not submenuProveedorBool Then
            submenuProveedores.Height = 1
            submenuProveedores.Visible = True

            If Me.panelMenu.Width < 236 Then
                tmrMostrarMenu.Enabled = True
                imgLogo.Width = 291
            End If

            submenuFalse()
            submenuProveedorBool = True

            tmrOcultarSubMenu.Enabled = True
            tmrMostrarSubMenu.Enabled = True
        Else
            submenuProveedorBool = False

            tmrOcultarSubMenu.Enabled = True
        End If
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        If Not submenuProductoBool Then
            submenuProductos.Height = 1
            submenuProductos.Visible = True

            If Me.panelMenu.Width < 236 Then
                tmrMostrarMenu.Enabled = True
                imgLogo.Width = 291
            End If

            submenuFalse()
            submenuProductoBool = True

            tmrOcultarSubMenu.Enabled = True
            tmrMostrarSubMenu.Enabled = True
        Else
            submenuProductoBool = False

            tmrOcultarSubMenu.Enabled = True
        End If
    End Sub

    Private Sub tmrMostrarSubMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarSubMenu.Tick
        If submenuClienteBool Then
            If submenuClientes.Height >= 102 Then
                tmrMostrarSubMenu.Enabled = False
            Else
                submenuClientes.Height = submenuClientes.Height + 10
            End If
        ElseIf submenuProveedorBool Then
            If submenuProveedores.Height >= 102 Then
                tmrMostrarSubMenu.Enabled = False
            Else
                submenuProveedores.Height = submenuProveedores.Height + 10
            End If
        ElseIf submenuProductoBool Then
            If submenuProductos.Height >= 102 Then
                tmrMostrarSubMenu.Enabled = False
            Else
                submenuProductos.Height = submenuProductos.Height + 10
            End If
        End If
    End Sub

    Private Sub tmrOcultarSubMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarSubMenu.Tick
        If submenuClientes.Visible And Not submenuClienteBool Then
            If submenuClientes.Height <= 1 Then
                tmrOcultarSubMenu.Enabled = False
                submenuClientes.Visible = False
            Else
                submenuClientes.Height = submenuClientes.Height - 10
            End If
        ElseIf submenuProveedores.Visible And Not submenuProveedorBool Then
            If submenuProveedores.Height <= 1 Then
                tmrOcultarSubMenu.Enabled = False
                submenuProveedores.Visible = False
            Else
                submenuProveedores.Height = submenuProveedores.Height - 10
            End If
        ElseIf submenuProductos.Visible And Not submenuProductoBool Then
            If submenuProductos.Height <= 1 Then
                tmrOcultarSubMenu.Enabled = False
                submenuProductos.Visible = False
            Else
                submenuProductos.Height = submenuProductos.Height - 10
            End If
        End If
    End Sub


    '----MÉTODO PARA MOSTRAR FORMULARIOS EN UN PANEL----'

    Private Sub openFromOnPanel(Of FormH As {Form, New})()
        Formulario = PanelContenedor.Controls.OfType(Of FormH)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New FormH()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(Formulario)
            PanelContenedor.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    '----MUESTRA LA HORA Y FECHA EN EL FORMULARIO----'

    Private Sub tmrHoraFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHoraFecha.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Dim hora As Byte = Val(DateTime.Now.ToString("HH"))
        If hora > 6 And hora < 12 Then
            lblBienvenida.Text = "     ¡Buen día!" & vbCrLf & "    Bienvenido"
        ElseIf hora >= 13 And hora <= 18 Then
            lblBienvenida.Text = "¡Buenas Tardes!" & vbCrLf & "    Bienvenido"
        Else
            lblBienvenida.Text = "¡Buenas Noches!" & vbCrLf & "   Bienvenido"
        End If

    End Sub


    '----OCULTAR SUBMENUS----'

    Private Sub ocultarSubMenus()
        submenuClientes.Visible = False
        submenuProveedores.Visible = False
        submenuProductos.Visible = False
    End Sub

    '----PONER BOOLEANOS DE SUBMENUS EN FALSO----'

    Private Sub submenuFalse()
        submenuClienteBool = False
        submenuProveedorBool = False
        submenuProductoBool = False
    End Sub

    '----SONIDO DEL COFRE----'

    Private Sub imgCofre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgCofre.Click
        My.Computer.Audio.Play("./audio/dinero.wav", AudioPlayMode.Background)
    End Sub

    '----BOTÓN CERRAR SESIÓN----'

    Private Sub pbCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCerrarSesion.Click
        If formularioBool Then formulario.Close()
        formularioBool = False
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtPrecioProductos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioProductos.KeyUp
        Dim conectar = New Conexion
        dgvPreciosRapidos.DataSource = conectar.mostrarRapidoProductoEnTabla()
        dgvPreciosRapidos.Columns(1).Width = 60
    End Sub

    '----EVENTO BOTÓN CLIENTES----'

    Private Sub btnExploradorClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExploradorClientes.Click
        '----MOSTRAR FORMULARIO "Explorador" EN EL MENÚ PRINCIPAL----'
        lblTituloVentana.Text = "Explorador de Clientes"
        If formularioBool = True Then formulario.Close()
        openFromOnPanel(Of Explorador)()
        formularioBool = True
    End Sub

    Private Sub btnGestionarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionarCliente.Click
        '----MOSTRAR FORMULARIO "CLIENTES" EN EL MENÚ PRINCIPAL----'
        lblTituloVentana.Text = "Cuenta Corriente de Clientes"
        If formularioBool = True Then formulario.Close()
        openFromOnPanel(Of CuentaCorriente)()
        formularioBool = True
    End Sub

    '----MOSTRAR MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        formulario.Close()
        lblTituloVentana.Text = "Menú Principal"
    End Sub

    Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProveedor.Click
        lblTituloVentana.Text = "Explorador de Proveedores"
    End Sub

    Private Sub btnGestionarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionarProveedor.Click
        lblTituloVentana.Text = "Cuanta Corriente de Proveedores"
    End Sub

    
    Private Sub btnActualizarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarProducto.Click
        lblTituloVentana.Text = "Actualizar Productos"
    End Sub

    Private Sub btnListadoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoProducto.Click
        lblTituloVentana.Text = "Listado de Productos y Stock"
    End Sub

End Class
