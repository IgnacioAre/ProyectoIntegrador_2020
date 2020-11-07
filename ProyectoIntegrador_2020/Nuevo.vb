Imports System.Runtime.InteropServices

Public Class Nuevo

    Dim consultas As Conexion = New Conexion
    Public idIngresoAdmin As Byte
    Dim resultado As Byte

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


    Public Sub btnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCliente.Click
        Registrar()
    End Sub

    Sub Registrar()

        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        If Me.lblTitulo.Text.Equals("Nuevo Cliente") Then


            'AGREGAMOS CLIENTES


            If txtNombre.Text.Equals("") Then
                mostrarMensaje("El nombre del cliente no puede estar vacío.")



            Else
                If txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Saldo, fechaIngreso, Direccion, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0, NOW(),'" & txtDireccion.Text.ToUpper & "', 1, 1);")

                If Not txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO Clientes (Nombre, Saldo, fechaIngreso, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0, NOW(),1, 1);")
                    InsertarTelClientes()
                End If

                If Not txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO Clientes (Nombre, Saldo, fechaIngreso, Direccion, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0, NOW(),'" & txtDireccion.Text.ToUpper & "', 1, 1);")
                    InsertarTelClientes()
                End If

                If txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Saldo, fechaIngreso, estadoBool, maxPermitidoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0, NOW(),1, 1);")

                If consultas.resultado = 1 Then
                    mostrarMensaje("Cliente " & txtNombre.Text & " registrado correctamente!")
                    limpiarCampos()
                    Me.Close()
                    moduloAuxiliar.cargarExploradorClientes()
                End If
            End If


        Else

            'AGREGAMOS PROVEEDORES

            If txtNombre.Text.Equals("") Then
                mostrarMensaje("El nombre del proveedor no puede estar vacío.")
            Else



                If txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Proveedores (Nombre, Saldo, Direccion, fechaIngreso, estadoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0,'" & txtDireccion.Text.ToUpper & "', NOW(), 1);")

                If Not txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO Proveedores (Nombre, Saldo, fechaIngreso, estadoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0, NOW(), 1);")
                    InsertarTelProveedores()
                End If

                If Not txtTelefono1.Text.Equals("") And Not txtDireccion.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO Proveedores (Nombre, Saldo, Direccion, fechaIngreso, estadoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0,'" & txtDireccion.Text.ToUpper & "', NOW(), 1);")
                    InsertarTelProveedores()
                End If

                If txtTelefono1.Text.Equals("") And txtDireccion.Text.Equals("") Then consultas.consultaHide("INSERT INTO Proveedores (Nombre, Saldo, fechaIngreso, estadoBool) VALUES ('" & txtNombre.Text.ToUpper & "', 0, NOW(),1);")



                If consultas.resultado = 1 Then
                    mostrarMensaje("Proveedor " & txtNombre.Text & " registrado correctamente!")
                    limpiarCampos()
                    moduloAuxiliar.cargarExploradorProveedores()
                    Me.Close()
                End If

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
        txtTelefono1.ReadOnly = False
        txtTelefono2.ReadOnly = False
        txtTelefono3.ReadOnly = False
        txtTelefono4.ReadOnly = False

        btnMasTel1.Visible = True
        btnMasTel2.Visible = False
        btnMasTel3.Visible = False
        btnMasTel4.Visible = False

        btnMenosTel1.Visible = False
        btnMenosTel2.Visible = False
        btnMenosTel3.Visible = False
        btnMenosTel4.Visible = False
    End Sub



    '----CONSULTAS PARA INGRESAR NÚMEROS DE TELÉFONO----'

    Private Sub InsertarTelProveedores()

        consultas.consultaReturnHide("SELECT MAX(idProveedor) FROM Proveedores;")
        Dim idProveedorRegistro As Integer = Val(consultas.valorReturn)

        consultas.consultaHide("INSERT INTO telefonoProveedor (numeroTel, idProveedor) VALUES ('" & txtTelefono1.Text & "'," & idProveedorRegistro & ");")
        If Not txtTelefono2.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoProveedor (numeroTel, idProveedor) VALUES ('" & txtTelefono2.Text & "'," & idProveedorRegistro & ");")
        End If
        If Not txtTelefono3.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoProveedor (numeroTel, idProveedor) VALUES ('" & txtTelefono3.Text & "'," & idProveedorRegistro & ");")
        End If
        If Not txtTelefono4.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoProveedor (numeroTel, idProveedor) VALUES ('" & txtTelefono4.Text & "'," & idProveedorRegistro & ");")
        End If
        If Not txtTelefono5.Text.Equals("") Then
            consultas.consultaHide("INSERT INTO telefonoProveedor (numeroTel, idProveedor) VALUES ('" & txtTelefono5.Text & "'," & idProveedorRegistro & ");")
        End If
    End Sub


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
        Else
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDireccionCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtTelefono1.Focus()
        Else
            If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 44 Then
                e.Handled = False

                If Char.IsLetter(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsSeparator(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
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

    Private Sub pbMasTel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasTel1.Click
        If Not txtTelefono1.Text = "" Then
            txtTelefono1.Enabled = False
            txtTelefono2.Visible = True
            txtTelefono2.Focus()
            btnMasTel1.Visible = False
            btnMenosTel1.Visible = True
            btnMasTel2.Visible = True
        Else
            txtTelefono1.BackColor = Color.Red
        End If
    End Sub

    Private Sub pbMasTel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasTel2.Click
        If Not txtTelefono2.Text = "" Then
            txtTelefono2.Enabled = False
            txtTelefono3.Visible = True
            txtTelefono3.Focus()
            btnMasTel2.Visible = False
            btnMenosTel2.Visible = True
            btnMasTel3.Visible = True
        Else
            txtTelefono2.BackColor = Color.Red
        End If
    End Sub

    Private Sub pbMasTel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasTel3.Click
        If Not txtTelefono3.Text = "" Then
            txtTelefono3.Enabled = False
            txtTelefono4.Visible = True
            txtTelefono4.Focus()
            btnMasTel3.Visible = False
            btnMenosTel3.Visible = True
            btnMasTel4.Visible = True
        Else
            txtTelefono3.BackColor = Color.Red
        End If
    End Sub

    Private Sub pbMasTel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasTel4.Click
        If Not txtTelefono4.Text = "" Then
            txtTelefono4.Enabled = False
            txtTelefono5.Visible = True
            txtTelefono5.Focus()
            btnMasTel4.Visible = False
            btnMenosTel4.Visible = True
        Else
            txtTelefono4.BackColor = Color.Red
        End If
    End Sub



    Private Sub txtTelefono1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono1.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If Not txtTelefono1.Text = "" Then
                    txtTelefono1.Enabled = False
                    txtTelefono2.Visible = True
                    txtTelefono2.Focus()
                    btnMasTel1.Visible = False
                    btnMenosTel1.Visible = True
                    btnMasTel2.Visible = True
                Else
                    txtTelefono1.BackColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub txtTelefono2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono2.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If Not txtTelefono2.Text = "" Then
                    txtTelefono2.Enabled = False
                    txtTelefono3.Visible = True
                    txtTelefono3.Focus()
                    btnMasTel2.Visible = False
                    btnMenosTel2.Visible = True
                    btnMasTel3.Visible = True
                Else
                    txtTelefono2.BackColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub txtTelefono3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono3.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If Not txtTelefono3.Text = "" Then
                    txtTelefono3.Enabled = False
                    txtTelefono4.Visible = True
                    txtTelefono4.Focus()
                    btnMasTel3.Visible = False
                    btnMenosTel3.Visible = True
                    btnMasTel4.Visible = True
                Else
                    txtTelefono3.BackColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub txtTelefono4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono4.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If Not txtTelefono4.Text = "" Then
                    txtTelefono4.Enabled = False
                    txtTelefono5.Visible = True
                    txtTelefono5.Focus()
                    btnMasTel4.Visible = False
                    btnMenosTel4.Visible = True
                Else
                    txtTelefono4.BackColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub txtTelefono5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono5.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnMenosTel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenosTel1.Click
        If Not txtTelefono3.Text.Equals("") Then
            ConfirmacionMensaje.btnAceptar.Text = "Si"
            ConfirmacionMensaje.btnCancelar.Text = "No"
            resultado = ConfirmacionMensaje.confirmacion("Se eliminaran los demás teléfonos regisrados." & vbCrLf & "                         ¿Está seguro?")

            If resultado = 1 Then
                txtTelefono1.Enabled = True
                btnMasTel1.Visible = True
                btnMenosTel1.Visible = False

                ocultarTel2()
                ocultarTel3()
                ocultarTel4()
                ocultarTel5()
            End If
        Else
            txtTelefono1.Enabled = True
            btnMasTel1.Visible = True
            btnMenosTel1.Visible = False

            ocultarTel2()
            ocultarTel3()
        End If
        

    End Sub

    Private Sub btnMenosTel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenosTel2.Click

        If Not txtTelefono4.Text.Equals("") Then
            ConfirmacionMensaje.btnAceptar.Text = "Si"
            ConfirmacionMensaje.btnCancelar.Text = "No"
            resultado = ConfirmacionMensaje.confirmacion("Se eliminaran los demás teléfonos regisrados." & vbCrLf & "                         ¿Está seguro?")

            If resultado = 1 Then
                txtTelefono2.Enabled = True
                btnMasTel2.Visible = True
                btnMenosTel2.Visible = False

                ocultarTel3()
                ocultarTel4()
                ocultarTel5()
            End If
        Else
            txtTelefono2.Enabled = True
            btnMasTel2.Visible = True
            btnMenosTel2.Visible = False

            ocultarTel3()
            ocultarTel4()
        End If

    End Sub

    Private Sub btnMenosTel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenosTel3.Click
        If Not txtTelefono4.Text.Equals("") Then
            ConfirmacionMensaje.btnAceptar.Text = "Si"
            ConfirmacionMensaje.btnCancelar.Text = "No"
            resultado = ConfirmacionMensaje.confirmacion("Se eliminaran los demás teléfonos regisrados." & vbCrLf & "                         ¿Está seguro?")

            If resultado = 1 Then
                txtTelefono3.Enabled = True
                btnMasTel3.Visible = True
                btnMenosTel3.Visible = False

                ocultarTel4()
                ocultarTel5()
            End If
        Else
            txtTelefono3.Enabled = True
            btnMasTel3.Visible = True
            btnMenosTel3.Visible = False

            ocultarTel4()
            ocultarTel5()
        End If

    End Sub

    Private Sub btnMenosTel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenosTel4.Click
        txtTelefono4.Enabled = True
        btnMasTel4.Visible = True
        btnMenosTel4.Visible = False

        ocultarTel5()

    End Sub



    Sub ocultarTel2()
        txtTelefono2.Visible = False
        txtTelefono2.Text = ""
        txtTelefono2.Enabled = True
        btnMasTel2.Visible = False
        btnMenosTel2.Visible = False
    End Sub

    Sub ocultarTel3()
        txtTelefono3.Visible = False
        txtTelefono3.Text = ""
        txtTelefono3.Enabled = True
        btnMasTel3.Visible = False
        btnMenosTel3.Visible = False
    End Sub

    Sub ocultarTel4()
        txtTelefono4.Visible = False
        txtTelefono4.Text = ""
        txtTelefono4.Enabled = True
        btnMasTel4.Visible = False
        btnMenosTel4.Visible = False
    End Sub

    Sub ocultarTel5()
        txtTelefono5.Text = ""
        txtTelefono5.Visible = False
    End Sub

    Private Sub txtTelefono1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono1.TextChanged
        txtTelefono1.BackColor = Color.White
    End Sub

    Private Sub txtTelefono2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono2.TextChanged
        txtTelefono2.BackColor = Color.White
    End Sub

    Private Sub txtTelefono3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono3.TextChanged
        txtTelefono3.BackColor = Color.White
    End Sub

    Private Sub txtTelefono4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono4.TextChanged
        txtTelefono4.BackColor = Color.White
    End Sub

End Class