Imports System.Runtime.InteropServices

Public Class Nuevo

    Dim consultas As Conexion = New Conexion
    Public idIngresoAdmin As Byte

    '----INICIO DEL FORMULARIO----'

    Private Sub Nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        txtNombre.Select()
        txtNombre.Focus()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        limpiarCampos()
        Me.Close()
    End Sub

    '----REGISTRO A UN NUEVO CLIENTE----'

    Private Sub btnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCliente.Click
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        If txtNombre.Text.Equals("") Then
            mostrarMensaje("El nombre del cliente no puede estar vacío.")
        Else
            If txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, fechaIngreso, Direccion, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text & "', NOW(),'" & txtDireccion.Text & "', 1, 1);")

            If Not txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO Clientes (Nombre, fechaIngreso, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text & "', NOW(), 1, 1);")
                InsertarTelClientes()
            End If

            If Not txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO Clientes (Nombre, Direccion, fechaIngreso, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text & "','" & txtDireccion.Text & "', NOW(), 1, 1);")
                InsertarTelClientes()
            End If

            If txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, fechaIngreso, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text & "', NOW()," & " 1, 1);")


            If consultas.resultado = 1 Then
                mostrarMensaje("Cliente registrado correctamente!")

                consultas.consultaReturnHide("SELECT MAX(idCliente) FROM Clientes;")
                Dim idClienteRegistro As Integer = Val(consultas.valorReturn)

                consultas.consultaHide("INSERT INTO ventaCliente (Saldo,fechaCompra,adeudoBool,idCliente) VALUES (0,NOW(),0," & idClienteRegistro & ");")
                
                limpiarCampos()
                Me.Hide()
            End If
        End If
    End Sub



    Sub limpiarCampos()

        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono1.Text = ""
        txtTelefono2.Text = ""
        txtTelefono3.Text = ""
        txtTelefono4.Text = ""
        txtTelefono5.Text = ""

        txtTelefono2.Visible = False
        txtTelefono3.Visible = False
        txtTelefono4.Visible = False
        txtTelefono5.Visible = False

        pbMasTel2.Visible = False
        pbMasTel3.Visible = False
        pbMasTel4.Visible = False
    End Sub



    '----CONSULTAS PARA INGRESAR NÚMEROS DE TELÉFONO----'

    Private Sub InsertarTelClientes()

        consultas.consultaReturnHide("SELECT MAX(idCliente) FROM Clientes;")
        Dim idClienteRegistro As Integer = Val(consultas.valorReturn)

        consultas.consultaHide("INSERT INTO telefonoCliente (numeroTel, idCliente) VALUES ('" & txtTelefono1.Text & "'," & idClienteRegistro & ");")
        If Not txtTelefono2.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoCliente (numeroTel, idCliente) VALUES ('" & txtTelefono2.Text & "'," & idClienteRegistro & ");")
        End If
        If Not txtTelefono3.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoCliente (numeroTel, idCliente) VALUES ('" & txtTelefono3.Text & "'," & idClienteRegistro & ");")
        End If
        If Not txtTelefono4.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoCliente (numeroTel, idCliente) VALUES ('" & txtTelefono4.Text & "'," & idClienteRegistro & ");")
        End If
        If Not txtTelefono5.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoCliente (numeroTel, idCliente) VALUES ('" & txtTelefono5.Text & "'," & idClienteRegistro & ");")
        End If
    End Sub


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub

    '----CAMBIAR FOCO EN LOS CAMPOS DE TEXTO----'

    Private Sub txtNombreCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccionCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtTelefono1.Focus()
        End If
    End Sub

    Private Sub txtTelefonoCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            If txtNombre.Text.Equals("") Then
                mostrarMensaje("El nombre del cliente no puede estar vacío.")
            Else
                If txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Direccion, estadoBool, idAdmin) VALUES ('" & txtNombre.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtDireccion.Text & "', 1," & idIngresoAdmin & ");")
                If Not txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, estadoBool, idAdmin) VALUES ('" & txtNombre.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtTelefono1.Text & "', 1," & idIngresoAdmin & ");")
                If Not txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, Direccion, estadoBool, idAdmin) VALUES ('" & txtNombre.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtTelefono1.Text & "', '" & txtDireccion.Text & "', 1," & idIngresoAdmin & ");")
                If txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, estadoBool, idAdmin) VALUES ('" & txtNombre.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW()," & " 1, " & idIngresoAdmin & ");")

                If consultas.resultado = 1 Then
                    mostrarMensaje("Cliente creado correctamente!")
                    txtNombre.Text = ""
                    txtDireccion.Text = ""
                    txtTelefono1.Text = ""
                    Me.Hide()
                End If
            End If

        End If
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

    Private Sub pbMasTel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMasTel1.Click
        txtTelefono2.Visible = True
        pbMasTel2.Visible = True
    End Sub

    Private Sub pbMasTel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMasTel2.Click
        txtTelefono3.Visible = True
        pbMasTel3.Visible = True
    End Sub

    Private Sub pbMasTel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMasTel3.Click
        txtTelefono4.Visible = True
        pbMasTel4.Visible = True
    End Sub

    Private Sub pbMasTel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMasTel4.Click
        txtTelefono5.Visible = True
    End Sub
End Class