Public Class buscarInforme

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer
    Dim nombreClientes As String

    Public guardarValorFactura As List(Of valoresFactura) = New List(Of valoresFactura)

    Private Sub Informe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarTabla()
        ActualizarTablaRegistro()
    End Sub


    Private Sub txtBuscarClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1 AND Nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub


    Sub ActualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1 order by(nombre) desc;")
    End Sub


    Sub ActualizarTablaRegistro()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,cc.Saldo,Detalle as Comentario,fechaCompra As Fecha FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND c.idCliente=" & idCliente & " order by(idCompra) desc;")
        dgvRegistroVentas.Columns(0).Visible = False
    End Sub


    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
            nombreCliente = dgvClientes.SelectedCells(1).Value
        End If


        ActualizarTablaRegistro()
    End Sub

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        Dim saldo As Integer
        Dim comentario As String
        Dim fecha As String

        'Guardar los header del dgvRegistroVentas
        moduloAuxiliar.headerSaldo = dgvRegistroVentas.Columns(1).HeaderText
        moduloAuxiliar.headerComentario = dgvRegistroVentas.Columns(2).HeaderText
        moduloAuxiliar.headerFecha = dgvRegistroVentas.Columns(3).HeaderText
        moduloAuxiliar.nombreCliente = nombreCliente

        consultas.consultaReturnHide("SELECT COUNT(idCompra) from compraCliente as cc,Clientes as c where cc.idCliente = c.idCliente and cc.idCliente=" & idCliente)
        Dim j As Integer = 0

        For i As Integer = 1 To Val(consultas.valorReturn)
            'Guardar los valores de cada columna.
            saldo = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(1).HeaderText, j).Value
            comentario = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(2).HeaderText, j).Value.ToString
            fecha = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(3).HeaderText, j).Value.ToString
            moduloAuxiliar.nuevoValor.Add(New valoresFactura(saldo, comentario, fecha))

            If j < i Then
                j += 1
            End If
        Next

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