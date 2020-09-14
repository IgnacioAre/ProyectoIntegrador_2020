﻿Imports System.Runtime.InteropServices

Public Class Nuevo

    Dim consultas As Conexion = New Conexion
    Public idIngresoAdmin As Byte

    '----INICIO DEL FORMULARIO----'

    Private Sub Nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        txtNombreCliente.Select()
        txtNombreCliente.Focus()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    '----REGISTRO A UN NUEVO CLIENTE----'

    Private Sub btnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCliente.Click
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        If txtNombreCliente.Text.Equals("") Then
            mostrarMensaje("El nombre del cliente no puede estar vacío.")
        Else
            If txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Direccion, estadoBool, maxPermitidoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtDireccionCliente.Text & "', 1, 1," & idIngresoAdmin & ");")
            If Not txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, estadoBool, maxPermitidoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtTelefonoCliente.Text & "', 1, 1," & idIngresoAdmin & ");")
            If Not txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, Direccion, estadoBool, maxPermitidoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtTelefonoCliente.Text & "', '" & txtDireccionCliente.Text & "', 1, 1," & idIngresoAdmin & ");")
            If txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, estadoBool, maxPermitidoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW()," & " 1, 1," & idIngresoAdmin & ");")

            If consultas.resultado = 1 Then
                mostrarMensaje("Cliente registrado correctamente!")
                txtNombreCliente.Text = ""
                txtDireccionCliente.Text = ""
                txtTelefonoCliente.Text = ""
                Me.Hide()
            End If
        End If
    End Sub


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub

    '----CAMBIAR FOCO EN LOS CAMPOS DE TEXTO----'

    Private Sub txtNombreCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtDireccionCliente.Focus()
        End If
    End Sub

    Private Sub txtDireccionCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccionCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtTelefonoCliente.Focus()
        End If
    End Sub

    Private Sub txtTelefonoCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            If txtNombreCliente.Text.Equals("") Then
                mostrarMensaje("El nombre del cliente no puede estar vacío.")
            Else
                If txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Direccion, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtDireccionCliente.Text & "', 1," & idIngresoAdmin & ");")
                If Not txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtTelefonoCliente.Text & "', 1," & idIngresoAdmin & ");")
                If Not txtTelefonoCliente.Text.Equals("") And Not txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, Telefono, Direccion, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW(),'" & txtTelefonoCliente.Text & "', '" & txtDireccionCliente.Text & "', 1," & idIngresoAdmin & ");")
                If txtTelefonoCliente.Text.Equals("") And txtDireccionCliente.Text.Equals("") Then consultas.consultaHide("INSERT INTO Clientes (Nombre, Deuda, Historial, fechaIngreso, estadoBool, idAdmin) VALUES ('" & txtNombreCliente.Text & "', 0," & "'Usuario Creado " & fechaActual & "', NOW()," & " 1, " & idIngresoAdmin & ");")

                If consultas.resultado = 1 Then
                    mostrarMensaje("Cliente creado correctamente!")
                    txtNombreCliente.Text = ""
                    txtDireccionCliente.Text = ""
                    txtTelefonoCliente.Text = ""
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

End Class