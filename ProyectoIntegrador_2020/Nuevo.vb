Public Class Nuevo

    Dim consultas As Conexion = New Conexion

    '----INICIO DEL FORMULARIO----'

    Private Sub Nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCliente.Click
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        If txtNombreCliente.Text.Equals("") Then
            mostrarMensaje("El nombre del cliente no puede estar vacío.")
        Else
            If txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Direccion, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtDireccionCliente.Text & "', 1,  1);")
            If Not txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW()," & txtTelefonoCliente.Text & ", 1,  1);")
            If Not txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, Direccion, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW()," & txtTelefonoCliente.Text & ", '" & txtDireccionCliente.Text & "', 1,  1);")
            If txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW()," & " 1,  1);")

            If consultas.resultado = 1 Then
                mostrarMensaje("Cliente creado correctamente!")
                txtNombreCliente.Text = ""
                txtDireccionCliente.Text = ""
                txtTelefonoCliente.Text = ""
                Me.Close()
            End If
        End If
    End Sub


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub
End Class