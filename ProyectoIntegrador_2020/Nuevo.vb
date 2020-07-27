Public Class Nuevo

    Dim conectar = New Conexion

    '----INICIO DEL FORMULARIO----'

    Private Sub Nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar.establecerConexion()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCliente.Click
        If txtNombreCliente.Text.Equals("") Then
            mostrarMensaje("El nombre del cliente no puede estar vacío.")
        Else 'FALTA CAMPO DE DEUDA, FECHA INGRESO...
            If Not txtDireccionCliente.Text.Equals("") And txtTelefonoCliente.Text.Equals("") Then conectar.consultaHide("INSERT INTO Clientes (Nombre, Direccion) VALUES ('" & txtNombreCliente.Text & "', '" & txtDireccionCliente.Text & "');")
            If Not txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then conectar.consultaHide("INSERT INTO Clientes (Nombre, Telefono) VALUES ('" & txtNombreCliente.Text & "', '" & txtTelefonoCliente.Text & "');")
            If Not txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then conectar.consultaHide("INSERT INTO Clientes (Nombre, Direccion, Telefono) VALUES ('" & txtNombreCliente.Text & "', '" & txtDireccionCliente.Text & "', '" & txtTelefonoCliente.Text & "');")

            If conectar.resultado = 1 Then
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