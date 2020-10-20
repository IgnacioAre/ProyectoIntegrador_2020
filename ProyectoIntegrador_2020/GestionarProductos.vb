Public Class GestionarProductos

    Dim consulta As Conexion = New Conexion()

    Dim idProducto As Integer

    Private Sub GestionarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub GestionarProductos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ActualizarTablaProductos()
    End Sub

    Private Sub btnSurtir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurtir.Click
        SurtirProductos.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvProveedores_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.SelectionChanged
        Dim row As DataGridViewRow = dgvProductos.CurrentRow

        If dgvProductos.SelectedCells.Count <> 0 Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            idProducto = dgvProductos.SelectedCells(0).Value

            txtID.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString



        End If

    End Sub

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        ActualizarTablaProductos()
    End Sub


    Public Sub ActualizarTablaProductos()
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, cantidadUnidad as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e FROM Productos where existenteBool = 1 order by(nombre) asc;")
        dgvProductos.Columns(0).Visible = False
        dgvProductos.Columns(7).Width = 0
    End Sub

    Dim buscarBool As Boolean = False

    Private Sub txtBuscarProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarProductos.TextChanged
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, cantidadUnidad as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e FROM Productos where existenteBool = 1 and nombre LIKE '%" & txtBuscarProductos.Text & "%' order by(nombre) asc;")
        dgvProductos.Columns(0).Visible = False
        dgvProductos.Columns(7).Width = 0
        txtBuscarCodigo.Text = ""
    End Sub

    Private Sub txtBuscarProductos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarProductos.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True

        End If


    End Sub

    Private Sub txtBuscarCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigo.TextChanged
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, cantidadUnidad as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e FROM Productos where existenteBool = 1 and idProducto LIKE '%" & txtBuscarCodigo.Text & "%' order by(nombre) asc;")
        dgvProductos.Columns(0).Visible = False
        dgvProductos.Columns(7).Width = 0
        txtBuscarProductos.Text = ""
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        gpInformacion.Visible = True
    End Sub

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        gpInformacion.Visible = True
    End Sub
End Class