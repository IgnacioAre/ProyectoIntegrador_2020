﻿Imports System.Runtime.InteropServices

Public Class ExploradorClientes

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer
    Dim activo As Byte
    Dim permitido As Byte
    Dim resultado As Byte
    Dim resultadosTxt As String
    Dim idCompra As String

    '----INICIO DEL FORMULARIO----'

    Private Sub Explorador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        panelEditarRegistro.Width = 0
        ActualizarTabla()
        ActualizarTablaTelefono()
        ActualizarTablaRegistroCompras()
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
    End Sub



    '----MOSTRAR FORMULARIO "NUEVO" EN EL MENÚ PRINCIPAL----'

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo.lblTitulo.Text = "Nuevo Cliente"
        Nuevo.ShowDialog()
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----MÉTODO PARA BUSCAR LOS CLIENTES POR NOMBRE----'

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT c.idCliente As ID, Nombre, SUM(Saldo) As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo,maxPermitidoBool As p FROM Clientes As c,compraCliente As cc WHERE c.idCliente = cc.idCliente AND estadoBool=1 AND Nombre LIKE '%" & txtBuscarClientes.Text & "%' group by(cc.idCliente);")
        dgvClientes.Columns(5).Visible = False
        dgvClientes.Columns(6).Width = 0

    End Sub

    '----MUESTRA EL FORMULARIO PARA MÓDIFICAR LOS DATOS DEL CLIENTE----'

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        gpInformacion.Visible = True
    End Sub


    '----MÉTODO PARA OBTENER EL ID Y LOS DEMÁS DATOS DE LA TABLA CLIENTES Y LOS PONE EN LOS CAMPOS DEL FORMULARIO MODIFICAR CLIENTE----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        ActualizarInformacionCliente()
    End Sub


    Sub ActualizarInformacionCliente()
        Dim row As DataGridViewRow = dgvClientes.CurrentRow

        If dgvClientes.SelectedCells.Count <> 0 Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            idCliente = dgvClientes.SelectedCells(0).Value

            txtID.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString
            txtDeuda.Text = row.Cells(2).Value.ToString
            mskFechaIngreso.Text = row.Cells(3).Value.ToString

            txtDireccion.Text = row.Cells(4).Value.ToString
            If row.Cells(5).Value.ToString.Equals("True") Then
                chbActivo.Checked = True
            Else
                chbActivo.Checked = False
            End If

            If row.Cells(6).Value.ToString.Equals("True") Then
                chbPermitido.Checked = True
            Else
                chbPermitido.Checked = False
            End If
        End If

        ActualizarTablaRegistroCompras()
        ActualizarTablaTelefono()
    End Sub



    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If chbActivo.Checked Then
            activo = 1
        Else
            activo = 0
        End If

        If chbPermitido.Checked Then
            permitido = 1
        Else
            permitido = 0
        End If

        consultas.consultaHide("UPDATE Clientes SET Nombre= '" & txtNombre.Text & "', Direccion='" & txtDireccion.Text & "', estadoBool=" & activo & ", maxPermitidoBool=" & permitido & " WHERE idCliente=" & idCliente & ";")

        If consultas.resultado = 1 Then
            gpInformacion.Visible = False
        End If

        actualizarTablaConId()
        chkNoActivos.Checked = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        resultado = ConfirmacionMensaje.confirmacion("   ¿Seguro que desea quitar este cliente?")
        If resultado = 1 Then
            consultas.consultaHide("UPDATE Clientes set estadoBool = 0 where idCliente=" & idCliente & ";")
            
            ActualizarTabla()

        End If

    End Sub

    Sub ActualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT c.idCliente As ID, Nombre, SUM(Saldo) As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo,maxPermitidoBool As p FROM clientes as c,compracliente as cc WHERE c.idcliente = cc.idcliente AND estadoBool=1 and adeudoBool=1 group by(cc.idCliente);")
        If consultas.resultado = 1 Then
            dgvClientes.Columns(5).Visible = False
            dgvClientes.Columns(6).Width = 0
        End If

    End Sub

    Private Sub actualizarTablaConId()
        Dim idTemp As Integer = idCliente
        ActualizarTabla()

        'SELECCIONA EN LA TABLA AL CLIENTE EN idTemp
        For i As Integer = 0 To dgvClientes.Rows.Count - 1
            If dgvClientes.Rows(i).Cells(0).Value = idTemp Then

                dgvClientes.CurrentCell = dgvClientes.Item(0, i)

                dgvClientes.Rows(i).Selected = True
                Exit For
            End If
        Next

        ActualizarInformacionCliente()
    End Sub


    Sub ActualizarTablaTelefono()
        dgvTelefono.DataSource = consultas.mostrarEnTabla("SELECT idTelefono,numeroTel As Número FROM telefonoCliente,Clientes WHERE telefonoCliente.idCliente = Clientes.idCliente and Clientes.idCliente=" & txtID.Text & ";")
        dgvTelefono.Columns(0).Visible = False
    End Sub


    Sub ActualizarTablaRegistroCompras()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,Saldo,Detalle,fechaCompra As Fecha FROM compraCliente,Clientes WHERE compraCliente.idCliente = Clientes.idCliente AND adeudoBool = 1 AND Saldo > 0 AND Clientes.idCliente=" & txtID.Text & ";")
        dgvRegistroVentas.Columns(0).Visible = False
    End Sub




    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        ActualizarTabla()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub



    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub

    '----CIERRA EL FORMULARIO DE MODIFICAR CLIENTE.----'

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        gpInformacion.Visible = False
    End Sub

    '----CAMBIA EL COLOR DE LA CELDA "SALDO"----'

    Private Sub dgvClientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvClientes.CellFormatting
        If dgvClientes.Columns(e.ColumnIndex).Name = "p" Then

            If e.Value = "False" Then
                dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Style.ForeColor = Color.Red
                dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Style.SelectionForeColor = Color.Red
            End If
        End If
    End Sub


    '----ADMITE SOLO NÚMEROS Y TECLA RETROCESO.----'

    Private Sub txtDeuda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeuda.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    '----AL MODIFICAR EL CAMPO DEL HISTORIAL; YA SE PUEDE GUARDAR LOS CAMBIOS.----'

    Private Sub txtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Not Char.IsWhiteSpace(e.KeyChar) And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarClientes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            dgvClientes.Focus()
        End If
    End Sub


    Private Sub btnAgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTel.Click
        resultadosTxt = ConfirmacionMensaje.entradaDatos("Nuevo número telfónico:")

        consultas.consultaHide("INSERT INTO telefonoCliente (numeroTel, idCliente) VALUES ('" & resultadosTxt & "'," & idCliente & ");")
        ActualizarTablaTelefono()
    End Sub


    Private Sub btnEliminarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarTel.Click
        Dim idTel As String
        idTel = dgvTelefono.CurrentRow.Cells(0).Value.ToString

        consultas.consultaHide("DELETE FROM telefonoCliente where idTelefono=" & idTel & ";")
        ActualizarTablaTelefono()
    End Sub




    Private Sub btnEditarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarTel.Click

        Dim idTel As String
        Dim num As String
        idTel = dgvTelefono.CurrentRow.Cells(0).Value.ToString
        num = dgvTelefono.CurrentRow.Cells(1).Value.ToString

        ConfirmacionMensaje.txtEntrada.Text = num
        resultadosTxt = ConfirmacionMensaje.entradaDatos("Modificar número telfónico:")

        If ConfirmacionMensaje.resultado = 1 Then
            consultas.consultaHide("UPDATE telefonoCliente set numeroTel='" & resultadosTxt & "' where idTelefono=" & idTel & ";")
            ActualizarTablaTelefono()
        End If

    End Sub

    Private Sub btnEditarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarRegistro.Click
        idCompra = dgvRegistroVentas.CurrentRow.Cells(0).Value.ToString
        txtSaldoRegistro.Text = dgvRegistroVentas.CurrentRow.Cells(1).Value.ToString
        txtDetalleRegistro.Text = dgvRegistroVentas.CurrentRow.Cells(2).Value.ToString

        tmrMostrarEditarRegistro.Enabled = True
    End Sub


    Private Sub tmrMostrarEditarRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarEditarRegistro.Tick
        If panelEditarRegistro.Width <= 0 Then
            tmrOcultarEditarRegistro.Enabled = False
        Else
            panelEditarRegistro.Width = panelEditarRegistro.Width - 10

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        tmrOcultarEditarRegistro.Enabled = True
    End Sub

    Private Sub tmrMostrarEditarRegistro_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarEditarRegistro.Tick
        If panelEditarRegistro.Width >= 349 Then
            tmrMostrarEditarRegistro.Enabled = False
        Else
            panelEditarRegistro.Width = panelEditarRegistro.Width + 10
        End If
    End Sub

    Private Sub btnGuardarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRegistro.Click
        If txtSaldoRegistro.Text <> "" Then
            consultas.consultaHide("UPDATE compraCliente set saldo = " & txtSaldoRegistro.Text & ", detalle = '" & txtDetalleRegistro.Text & "' where idCompra=" & idCompra & ";")
            actualizarTablaConId()
            tmrOcultarEditarRegistro.Enabled = True
        End If
    End Sub


    Private Sub chkNoActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoActivos.CheckedChanged
        If chkNoActivos.Checked Then

            dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT c.idCliente As ID, Nombre, SUM(Saldo) As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo,maxPermitidoBool As p FROM clientes as c,compracliente as cc WHERE c.idcliente = cc.idcliente AND estadoBool=0 group by(cc.idCliente);")
            If consultas.resultado = 1 Then
                dgvClientes.Columns(5).Visible = False
                dgvClientes.Columns(6).Width = 0
            End If
        Else
            ActualizarTabla()
        End If
    End Sub
End Class