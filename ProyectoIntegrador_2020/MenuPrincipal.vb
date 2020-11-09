Imports System.Runtime.InteropServices
Imports System.IO

Public Class MenuPrincipal

    Dim consulta As moduloConexion = New moduloConexion
    Dim moverMenuBool As Boolean = False
    Dim submenuClienteBool As Boolean = False
    Dim submenuProveedorBool As Boolean = False
    Dim submenuProductoBool As Boolean = False
    Public resultado As Byte
    Public resultadoTxt As String
    Dim rutaBackup As String
    Dim hora As Byte
    Dim resultadoEntrada As String

    Dim yPanelAviso As Integer
    Dim YfijaPanelAviso As Integer
    Dim nombreAdmin As String

    '----FORMULARIO QUE SE VA A MOSTRAR ENCIMA DEL FORMULARIO PRINCIPAL----'
    Public formulario As Form
    Public formularioBool As Boolean = False


    '----INICIO DEL FORMULARIO----'

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panelAbout.Width = 0
        ActualizarPanelMinimoStock()
        My.Computer.Audio.Play("./audio/dinero.wav", AudioPlayMode.Background)
        SendMessage(txtPrecioProductos.Handle, EM_SETCUEBANNER, 0, "Nombre del producto")
        panelAvisoStock.SendToBack()
        obtenerNombreAdmin()
        YfijaPanelAviso = panelAvisoStock.Location.Y
    End Sub



    Sub obtenerNombreAdmin()
        consulta.consultaReturnHide("SELECT Usuario FROM Admin where logeadoBool=1;")
        Dim result As String = consulta.valorReturn
        Dim primeraLetra As String = result.Substring(0, 1).ToUpper

        Dim otrasLetras As String = result.Substring(1, result.Count - 1).ToLower

        nombreAdmin = primeraLetra & otrasLetras
    End Sub



    Private Sub MenuPrincipal_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If resultado = 1 Then
            If formularioBool Then
                formulario.Close()
                formularioBool = False
            End If
        Else
            e.Cancel = True
            resultado = 0
        End If
    End Sub


    '----CIERRA EL FORUMULARIO DEL MENÚ (Y FINALIZA SU EJECUCIÓN)----'
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        ConfirmacionMensaje.btnAceptar.Text = "Si"
        ConfirmacionMensaje.btnCancelar.Text = "No"
        resultado = ConfirmacionMensaje.confirmacion("                            ¿Desea Salir?")

        If resultado = 1 Then
            backupAutomatico()
            Me.Close()
            End
        End If
    End Sub

    '----MINIMIZA EL FORUMULARIO DEL MENÚ----'

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    '----TIEMPO QUE SE EJECUTA EL GIF DEL COFRE----'

    Private Sub tmrGif_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGif.Tick
        If tmrGif.Interval = 5550 Then
            gifCofre.Visible = False
            imgCofre.Visible = True
            tmrGif.Stop()
        End If
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----DESLPEGAR Y CONTRAER MENÚ LATERAL----'

    Private Sub moverMenuLateral()
        If Me.panelMenu.Width = 210 Then
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
            lblTituloVentana.Location = New Point(206, 6)

        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        moverMenuLateral()
    End Sub

    Private Sub tmrMostrarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarMenu.Tick
        If Me.panelMenu.Width >= 210 Then
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
        lblTituloVentana.Location = New Point(206, 6)
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

        lblTituloVentana.Location = New Point(206, 6)
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        mostrarProductos()
    End Sub


    Sub mostrarProductos()
        '----MOSTRAR FORMULARIO "Productos" EN EL MENÚ PRINCIPAL----'
        lblTituloVentana.Text = "Actualizar Productos"
        submenuFalse()
        tmrOcultarSubMenu.Enabled = True
        tmrOcultarAbout.Enabled = True
        If formularioBool = True Then formulario.Close()
        openFromOnPanel(Of GestionarProductos)()
        formularioBool = True
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
        End If
    End Sub


    '----MÉTODO PARA MOSTRAR FORMULARIOS EN UN PANEL----'

    Public Sub openFromOnPanel(Of FormH As {Form, New})()
        formulario = PanelContenedor.Controls.OfType(Of FormH)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New FormH()
            formulario.TopLevel = False
            formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(formulario)
            PanelContenedor.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub

    '----MUESTRA LA HORA Y FECHA EN EL FORMULARIO----'
    Dim inicioBool As Boolean = True
    Private Sub tmrHoraFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHoraFecha.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        hora = Val(DateTime.Now.ToString("HH"))

    End Sub


    '----OCULTAR SUBMENUS----'

    Private Sub ocultarSubMenus()
        submenuClientes.Visible = False
        submenuProveedores.Visible = False
    End Sub

    '----PONER BOOLEANOS DE SUBMENUS EN FALSO----'

    Public Sub submenuFalse()
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
        resultado = ConfirmacionMensaje.confirmacion("                   ¿Desea Cerrar Sesión?")
        If resultado = 1 Then
            backupAutomatico()
            inicioSesion.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtPrecioProductos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioProductos.KeyUp
        Dim conectar = New moduloConexion
        dgvPreciosRapidos.DataSource = conectar.mostrarRapidoProductoEnTabla()
        dgvPreciosRapidos.Columns(2).Width = 100

        If txtPrecioProductos.Text.Equals("") Then
            dgvPreciosRapidos.Visible = False
        Else
            dgvPreciosRapidos.Visible = True
        End If

    End Sub


    '----EVENTO BOTÓN CLIENTES----'

    Private Sub btnExploradorClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExploradorClientes.Click
        mostrarExploradorClientes()
    End Sub


    Sub mostrarExploradorClientes()
        '----MOSTRAR FORMULARIO "Explorador de Clientes" EN EL MENÚ PRINCIPAL----'
        lblTituloVentana.Text = "Explorador de Clientes"
        If formularioBool = True Then formulario.Close()
        openFromOnPanel(Of ExploradorClientes)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub


    Private Sub btnCuentaCorrienteClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentaCorrienteClientes.Click
        '----MOSTRAR FORMULARIO "Cuenta Corriente" EN EL MENÚ PRINCIPAL----'
        lblTituloVentana.Text = "Cuenta Corriente de Clientes"
        If formularioBool = True Then formulario.Close()
        openFromOnPanel(Of CuentaCorrienteCliente)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub

    '----MOSTRAR MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.ShowDialog()
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        ActualizarPanelMinimoStock()
        panelAvisoStock.Location = New Point(panelAvisoStock.Location.X, YfijaPanelAviso)
        If formularioBool Then formulario.Close()
        formularioBool = False
        lblTituloVentana.Text = "Menú Principal"
        tmrOcultarAbout.Enabled = True
    End Sub

    Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExploradorProveedores.Click
        mostrarExploradorProveedores()
    End Sub

    Sub mostrarExploradorProveedores()
        '----MOSTRAR FORMULARIO "Explorador de Proveedores" EN EL MENÚ PRINCIPAL----'
        lblTituloVentana.Text = "Explorador de Proveedores"
        If formularioBool Then formulario.Close()
        openFromOnPanel(Of ExploradorProveedores)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub

    Private Sub btnGestionarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionarProveedor.Click
        lblTituloVentana.Text = "Cuanta Corriente de Proveedores"
        If formularioBool Then formulario.Close()
        openFromOnPanel(Of CuentaCorrienteProveedor)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub




    Private Sub btnActualizarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTituloVentana.Text = "Actualizar Productos"
        If formularioBool Then formulario.Close()
        openFromOnPanel(Of GestionarProductos)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub


    Private Sub tmrMostrarAbout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarAbout.Tick
        btnAyuda.Enabled = False
        If Me.panelAbout.Width >= 549 Then
            tmrMostrarAbout.Enabled = False
            btnAyuda.Enabled = True
        Else
            panelAbout.Width = panelAbout.Width + 10
        End If
    End Sub

    Private Sub tmrOcultarAbout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarAbout.Tick
        btnAyuda.Enabled = False
        If Me.panelAbout.Width <= 0 Then
            Me.tmrOcultarAbout.Enabled = False
            btnAyuda.Enabled = True
        Else
            Me.panelAbout.Width = panelAbout.Width - 10
        End If
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click

        If formularioBool Then
            ConfirmacionMensaje.btnAceptar.Text = "Si"
            ConfirmacionMensaje.btnCancelar.Text = "No"
            resultado = ConfirmacionMensaje.confirmacion("   ¿Desea cerrar este formulario para" & vbCrLf & "   abrir el menú de ayuda?")

            If resultado = 1 Then
                formulario.Close()
                formularioBool = False
                lblTituloVentana.Text = "Menú Principal"

                If panelAbout.Width = 0 Then
                    tmrMostrarAbout.Enabled = True
                Else
                    tmrOcultarAbout.Enabled = True
                End If
            End If
        Else
            If panelAbout.Width = 0 Then
                tmrMostrarAbout.Enabled = True
            Else
                tmrOcultarAbout.Enabled = True
            End If
        End If

    End Sub


    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        If Not panelAbout.Width = 0 Then
            tmrOcultarAbout.Enabled = True
        End If
    End Sub


    Private Sub btnNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotas.Click
        lblTituloVentana.Text = "Notas"
        submenuFalse()
        tmrOcultarSubMenu.Enabled = True
        If formularioBool Then formulario.Close()
        openFromOnPanel(Of Notas)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub


    Private Sub btnEstadistica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadistica.Click
        lblTituloVentana.Text = "Estadísticas"
        If formularioBool Then formulario.Close()
        openFromOnPanel(Of Estadisticas)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub


    Sub ActualizarPanelMinimoStock()
        consulta.consultaReturnHide("select count(idProducto) from productos where stock <= minimoStock and existenteBool = 1;")
        Dim numCount As Integer = Val(consulta.valorReturn)
        If numCount = 0 Then
            panelAvisoStock.Visible = False
        Else


            Dim Amarillo As Integer = 5
            Dim Naranja As Integer = 10

            If numCount = 0 Then
                panelAvisoStock.Height = 0
            Else

                If numCount <= Amarillo Then
                    panelAvisoStock.BackColor = Color.Yellow
                    lblAvisoStock.BackColor = Color.Yellow
                    lblAvisoStock.ForeColor = Color.Black
                ElseIf numCount <= Naranja Then
                    btnOcultarAvisoNegro.Visible = True
                    panelAvisoStock.BackColor = Color.DarkOrange
                    lblAvisoStock.BackColor = Color.DarkOrange
                    lblAvisoStock.ForeColor = Color.White
                Else
                    panelAvisoStock.BackColor = Color.Crimson
                    lblAvisoStock.BackColor = Color.Crimson
                    lblAvisoStock.ForeColor = Color.White
                End If

                panelAvisoStock.Visible = True
                lblAvisoStock.Text = "Tienes " & numCount & " productos por debajo del limite de stock."

            End If

        End If

    End Sub


    Private Sub tmrOcultarAviso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarAviso.Tick
        If yPanelAviso >= (YfijaPanelAviso + 101) Then
            tmrOcultarAviso.Enabled = False

        Else

            yPanelAviso += 3
            panelAvisoStock.Location = New Point(panelAvisoStock.Location.X, yPanelAviso)
        End If
    End Sub

    Private Sub btnOcultarAvisoNegro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarAvisoNegro.Click
        yPanelAviso = panelAvisoStock.Location.Y
        YfijaPanelAviso = panelAvisoStock.Location.Y
        tmrOcultarAviso.Enabled = True
    End Sub

    Private Sub btnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme.Click
        lblTituloVentana.Text = "Informe"
        submenuFalse()
        tmrOcultarSubMenu.Enabled = True
        If formularioBool Then formulario.Close()
        openFromOnPanel(Of buscarInforme)()
        formularioBool = True
        tmrOcultarAbout.Enabled = True
    End Sub


    Private Sub MenuPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        hora = Val(DateTime.Now.ToString("HH"))

        If hora > 6 And hora <= 12 Then
            lblBienvenida.Text = "    ¡Buen día!" & vbCrLf & "Bienvenido " & nombreAdmin
        ElseIf hora >= 13 And hora <= 18 Then
            lblBienvenida.Text = " ¡Buenas Tardes!" & vbCrLf & "Bienvenido " & nombreAdmin
        Else
            lblBienvenida.Text = " ¡Buenas Noches!" & vbCrLf & "Bienvenido " & nombreAdmin
        End If
    End Sub

    Private Sub txtPrecioProductos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioProductos.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Do
            ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
            ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
            ConfirmacionMensaje.txtEntrada.PasswordChar = "*"
            ConfirmacionMensaje.entradaDatos("Ingrese la clave de administrador:")
            resultadoEntrada = ConfirmacionMensaje.resultadoTxt
        Loop While resultadoEntrada = "" And ConfirmacionMensaje.resultado = 1

        If resultadoEntrada = "7r7w7x" Then
            ConfirmacionMensaje.resultadoTxt = ""
            ConfirmacionMensaje.txtEntrada.PasswordChar = ""
            Try
                If Not Directory.Exists("C:\Backups") Then
                    Directory.CreateDirectory("C:\Backups")
                End If
            Catch ex As Exception

            End Try

            SaveFileDialog1.Filter = "SQL Backup Files|*.sql"
            SaveFileDialog1.FileName = "elcofre_" & Today.Date.ToString("dd-MM-yyyy") & ".sql"

            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                rutaBackup = SaveFileDialog1.FileName

                Try
                    'Process.Start("cmd", "start /b & /C cd C:\")
                    Process.Start("cmd", "/C cd C:\xampp\mysql\bin & " & " mysqldump -h localhost -u proyecto -pproyecto2020 elcofre>" & rutaBackup & " & exit")
                Catch ex As Exception
                    mostrarMensaje("No se pudo hacer un backup. " & ex.Message)
                End Try
            End If
        End If

    End Sub

    Sub backupAutomatico()
        Try
            If Not Directory.Exists("C:\Backups") Then
                Directory.CreateDirectory("C:\Backups")
            End If

            Process.Start("cmd", "/k cd C:\xampp\mysql\bin & " & " mysqldump -h localhost -u proyecto -pproyecto2020 elcofre>C:\Backups\elcofre.sql" & " & exit")
        Catch ex As Exception
            mostrarMensaje("No se pudo hacer un backup. " & ex.Message)
        End Try
    End Sub


End Class
