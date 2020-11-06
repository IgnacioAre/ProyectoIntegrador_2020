Public Class buscarInforme

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer

    Private Sub Informe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarTabla()
        ActualizarTablaRegistro()
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim xWidth As Integer = 160
        Dim yHeight As Integer = 20

        Dim fon As New Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold)

        Dim rect As New Rectangle(170, 10, xWidth, yHeight)
        Dim strings As New StringFormat
        strings.Alignment = StringAlignment.Center
        strings.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        e.Graphics.DrawString(dgvRegistroVentas.Columns(1).HeaderText, fon, Brushes.Black, rect, strings)

        Dim rect2 As New Rectangle(330, 10, xWidth, yHeight)
        Dim strings2 As New StringFormat
        strings2.Alignment = StringAlignment.Center
        strings2.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawString(dgvRegistroVentas.Columns(2).HeaderText, fon, Brushes.Black, rect2, strings2)


        Dim rect3 As New Rectangle(490, 10, 230, yHeight)
        Dim strings3 As New StringFormat
        strings3.Alignment = StringAlignment.Center
        strings3.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect3)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawString(dgvRegistroVentas.Columns(3).HeaderText, fon, Brushes.Black, rect3, strings3)

        '----------------------------------------------------------------------------------------------------------'

        Dim fon2 As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)

        Dim rek As New Rectangle(170, 30, xWidth, yHeight)
        e.Graphics.DrawRectangle(Pens.Black, rek)
        Dim row = dgvRegistroVentas.CurrentCell.RowIndex
        e.Graphics.DrawString(dgvRegistroVentas.Item(dgvRegistroVentas.Columns(1).HeaderText, row).Value.ToString, fon2, Brushes.Black, 230, 32)

        Dim rek2 As New Rectangle(330, 30, xWidth, yHeight)
        e.Graphics.DrawRectangle(Pens.Black, rek2)
        Dim row2 = dgvRegistroVentas.CurrentCell.RowIndex
        e.Graphics.DrawString(dgvRegistroVentas.Item(dgvRegistroVentas.Columns(2).HeaderText, row).Value.ToString, fon2, Brushes.Black, 390, 32)

        Dim rek3 As New Rectangle(490, 30, 230, yHeight)
        e.Graphics.DrawRectangle(Pens.Black, rek3)
        Dim row3 = dgvRegistroVentas.CurrentCell.RowIndex
        e.Graphics.DrawString(dgvRegistroVentas.Item(dgvRegistroVentas.Columns(3).HeaderText, row).Value.ToString, fon2, Brushes.Black, 510, 32)


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
        moduloFactura.headerSaldo = dgvRegistroVentas.Columns(1).HeaderText
        moduloFactura.headerComentario = dgvRegistroVentas.Columns(2).HeaderText
        moduloFactura.headerFecha = dgvRegistroVentas.Columns(3).HeaderText

        'Guardar los valores de cada columna.
        Dim row = dgvRegistroVentas.CurrentCell.RowIndex
        moduloFactura.valueSaldo = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(1).HeaderText, row).Value.ToString
        moduloFactura.valuesComentario = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(2).HeaderText, row).Value.ToString
        moduloFactura.valuesFecha = dgvRegistroVentas.Item(dgvRegistroVentas.Columns(3).HeaderText, row).Value.ToString

        InformeFactura.ShowDialog()
    End Sub


    Private Sub dgvRegistroVentas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistroVentas.SelectionChanged
        If dgvRegistroVentas.SelectedCells.Count <> 0 Then
            btnFacturar.Enabled = True
        Else
            btnFacturar.Enabled = False
        End If
    End Sub


End Class