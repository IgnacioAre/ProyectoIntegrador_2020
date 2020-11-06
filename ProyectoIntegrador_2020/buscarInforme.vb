Public Class buscarInforme

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer

    Private Sub Informe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarTabla()
        ActualizarTablaRegistro()
    End Sub


    Private Sub txtBuscarClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1 AND Nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub


    Sub ActualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1;")
    End Sub


    Sub ActualizarTablaRegistro()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,cc.Saldo,Detalle as Comentario,fechaCompra As Fecha FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND adeudoBool=1 AND c.idCliente=" & idCliente & " order by(idCompra) desc;")
        dgvRegistroVentas.Columns(0).Visible = False
    End Sub


    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
        End If


        ActualizarTablaRegistro()
    End Sub

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        'Guardar los header del dgvRegistroVentas
        moduloAuxiliar.headerSaldo = dgvRegistroVentas.Columns(1).HeaderText
        moduloAuxiliar.headerComentario = dgvRegistroVentas.Columns(2).HeaderText
        moduloAuxiliar.headerFecha = dgvRegistroVentas.Columns(3).HeaderText

        'Guardar los valores de cada columna.
        Dim row = dgvRegistroVentas.CurrentCell.RowIndex
        moduloAuxiliar.valueSaldo = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(1).HeaderText, row).Value.ToString
        moduloAuxiliar.valuesComentario = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(2).HeaderText, row).Value.ToString
        moduloAuxiliar.valuesFecha = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(3).HeaderText, row).Value.ToString

        Dim informeF As New InformeFactura()
        informeF.ShowDialog()
    End Sub


    Private Sub dgvRegistroVentas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistroVentas.SelectionChanged
        If dgvRegistroVentas.SelectedCells.Count <> 0 Then
            btnFacturar.Enabled = True
        Else
            btnFacturar.Enabled = False
        End If
    End Sub


End Class