Imports System.Runtime.InteropServices

Public Class Explorador

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Byte


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        '----MOSTRAR FORMULARIO "NUEVO" EN EL MENÚ PRINCIPAL----'
        Nuevo.lblTitulo.Text = "Nuevo Cliente"
        Nuevo.Show()
    End Sub

    Private Sub Explorador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        ActualizarTabla()
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, fechaIngreso,Telefono As Teléfono, Direccion As Dirección, estadoBool As Activo, Historial, estadoBool FROM Clientes WHERE Nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        gpInformacion.Visible = True
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        Dim row As DataGridViewRow = dgvClientes.CurrentRow

        If dgvClientes.SelectedCells.Count <> 0 Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            idCliente = dgvClientes.SelectedCells(0).Value

            txtID.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString
            txtDeuda.Text = row.Cells(2).Value.ToString
            mskFechaIngreso.Text = row.Cells(3).Value.ToString
            txtTel.Text = row.Cells(4).Value.ToString
            txtDireccion.Text = row.Cells(5).Value.ToString
            If row.Cells(6).Value.ToString.Equals("True") Then
                chbActivo.Checked = True
            Else
                chbActivo.Checked = False
            End If
            txtHistorial.Text = row.Cells(7).Value.ToString
        End If
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim activo As Byte
        If chbActivo.Checked Then
            activo = 1
        Else
            activo = 0
        End If

        consultas.consultaHide("UPDATE Clientes SET Nombre= '" & txtNombre.Text & "', Deuda=" & txtDeuda.Text & ", Historial='" & txtHistorial.Text & "', Telefono=" & txtTel.Text & ", Direccion='" & txtDireccion.Text & "', estadoBool=" & activo & " where idCliente=" & idCliente & ";")

        ActualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        consultas.consultaHide("DELETE FROM Clientes where idCliente=" & idCliente & ";")
        ActualizarTabla()
    End Sub

    Private Sub ActualizarTabla()
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, fechaIngreso,Telefono As Teléfono, Direccion As Dirección, estadoBool As Activo, Historial, estadoBool FROM clientes;")
        dgvClientes.Columns(7).Visible = False
        dgvClientes.Columns(8).Visible = False
        dgvClientes.Columns(0).Width = 40
        dgvClientes.Columns(2).Width = 70
        dgvClientes.Columns(6).Width = 60
    End Sub

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        ActualizarTabla()
    End Sub
End Class