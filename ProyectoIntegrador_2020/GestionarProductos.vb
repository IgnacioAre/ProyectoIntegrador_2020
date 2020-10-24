Imports System.Runtime.InteropServices

Public Class GestionarProductos

    Dim consulta As Conexion = New Conexion()

    Dim idProducto As Long
    Dim idSurtido As Integer
    Dim minimoStock As Integer
    Dim stockAux As Integer
    Dim cantidadAux As Integer
    Dim resultado As Byte

    Private Sub GestionarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SendMessage(txtBuscarProductos.Handle, EM_SETCUEBANNER, 0, "Ingrese el nombre")
        SendMessage(txtBuscarCodigo.Handle, EM_SETCUEBANNER, 0, "Ingrese el código")
        panelEditarRegistro.Width = 0
        ActualizarMinimoStock()
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    Private Sub GestionarProductos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ActualizarTablaProductos()
    End Sub

    Private Sub btnSurtir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurtir.Click
        Dim surtir As SurtirProductos = New SurtirProductos()
        surtir.soloNuevoBool = False
        surtir.txtCodigoProducto.Select()
        surtir.txtCodigoProducto.Focus()
        surtir.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvProveedores_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.SelectionChanged
        Dim row As DataGridViewRow = dgvProductos.CurrentRow

        If dgvProductos.SelectedCells.Count <> 0 Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnAgregarProd.Enabled = True

            If panelEditarRegistro.Width >= 349 Then
                tmrOcultarEditarRegistro.Enabled = True
            End If
            idProducto = dgvProductos.SelectedCells(0).Value

            txtID.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString
            txtCantidadUnidad.Text = row.Cells(2).Value.ToString
            txtStock.Text = row.Cells(6).Value.ToString

            cbxMedida.SelectedItem = row.Cells(3).Value.ToString

            ActualizarTablaRegistro()

        End If

    End Sub

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        txtNombre.Text = ""
        ActualizarTablaProductos()
        ActualizarTablaProductos()
    End Sub

    'ACTUALIZA LA TABLA DE PRODUCTOS

    Public Sub ActualizarTablaProductos()
        dgvProductos.DataSource = consulta.mostrarEnTabla("SELECT idProducto As Código, nombre as Nombre, REPLACE(cantidadUnidad,',','.') as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock FROM Productos where existenteBool = 1 order by(nombre) asc;")

    End Sub


    'ACTUALIZA LA TABLA CON UN YA ID SELECCIONADO

    Private Sub actualizarTablaConId()
        Dim idTemp As Long = idProducto
        ActualizarTablaProductos()

        'SELECCIONA EN LA TABLA AL CLIENTE EN idTemp
        For i As Integer = 0 To dgvProductos.Rows.Count - 1
            If dgvProductos.Rows(i).Cells(0).Value = idTemp Then

                dgvProductos.CurrentCell = dgvProductos.Item(0, i)

                dgvProductos.Rows(i).Selected = True
                Exit For
            End If
        Next

        ActualizarTablaRegistro()

    End Sub

    'ACTUALIZA LA TABLA DEL REGISTRO DE SURTIDO

    Sub ActualizarTablaRegistro()
        dgvRegistroSurtido.DataSource = consulta.mostrarEnTabla("SELECT idSurtido, sp.precioCosto as Costo, sp.precioVenta as Venta, Cantidad, porcentajeGanancia as Porcentaje, fechaSurtido as Fecha from surtidoProductos as sp,Productos as p where sp.idProducto = p.idProducto and  p.idProducto=" & idProducto & " order by(idSurtido) desc;")
        dgvRegistroSurtido.Columns(0).Visible = False
    End Sub


    Dim buscarBool As Boolean = False


    Sub ActualizarMinimoStock()
        consulta.consultaReturnHide("SELECT minimoStock from Productos limit 1;")
        minimoStock = Val(consulta.valorReturn)
    End Sub


    Private Sub txtBuscarProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarProductos.TextChanged
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, REPLACE(cantidadUnidad,',','.') as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e FROM Productos where existenteBool = 1 and nombre LIKE '%" & txtBuscarProductos.Text & "%' order by(nombre) asc;")
        dgvProductos.Columns(7).Width = 0
        txtBuscarCodigo.Text = ""
    End Sub

    Private Sub txtBuscarProductos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarProductos.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            dgvProductos.Focus()
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

    Private Sub txtBuscarCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigo.TextChanged
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, REPLACE(cantidadUnidad,',','.') as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e FROM Productos where existenteBool = 1 and idProducto LIKE '%" & txtBuscarCodigo.Text & "%' order by(nombre) asc;")
        dgvProductos.Columns(7).Width = 0
        txtBuscarProductos.Text = ""
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        gpInformacion.Visible = True
    End Sub

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        gpInformacion.Visible = False
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If Not txtNombre.Text.Equals("") And Not txtStock.Text.Equals("") And Not txtCantidadUnidad.Text.Equals("") Then
            
            consulta.consultaHide("UPDATE Productos SET Nombre='" & txtNombre.Text.ToUpper & "', Stock=" & txtStock.Text & ", cantidadUnidad=" & txtCantidadUnidad.Text & ", unidad='" & cbxMedida.SelectedItem.ToString.ToUpper & "' where idProducto=" & idProducto & ";")

            actualizarTablaConId()
            gpInformacion.Visible = False
        Else
            mostrarMensaje("Debe rellenar los campos vacios.")
        End If

    End Sub

    Private Sub btnEditarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarRegistro.Click
        If dgvRegistroSurtido.SelectedCells.Count <> 0 Then
            btnEditarRegistro.Enabled = True
            idSurtido = dgvRegistroSurtido.CurrentRow.Cells(0).Value.ToString
            txtPrecioCosto.Text = dgvRegistroSurtido.CurrentRow.Cells(1).Value.ToString
            txtCantidad.Text = dgvRegistroSurtido.CurrentRow.Cells(3).Value.ToString
            txtPorcentaje.Text = dgvRegistroSurtido.CurrentRow.Cells(4).Value.ToString

            consulta.consultaReturnHide("SELECT Stock from productos where idProducto=" & idProducto & ";")
            stockAux = Val(consulta.valorReturn)
            cantidadAux = Val(txtCantidad.Text)


            tmrMostrarEditarRegistro.Enabled = True
        Else
            btnEditarRegistro.Enabled = False
        End If
    End Sub


    Private Sub btnAjustarMinimoStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjustarMinimoStock.Click
        ajustarMinimoStock()
    End Sub


    Sub ajustarMinimoStock()
        If Not txtMinimoStock.Text.Equals("") Then
            consulta.consultaHide("UPDATE Productos SET minimoStock=" & txtMinimoStock.Text & ";")
            txtMinimoStock.Text = ""
            ActualizarMinimoStock()
            ActualizarTablaProductos()
        Else
            txtMinimoStock.BackColor = Color.Red
        End If
    End Sub

    Private Sub txtMinimoStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinimoStock.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                ajustarMinimoStock()
            End If
        End If
    End Sub

    Private Sub btnVerRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerRegistro.Click
        gpRegistro.Visible = True
        btnVerRegistro.Visible = False
        btnOcultarRegistro.Visible = True
    End Sub

    Private Sub btnOcultarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarRegistro.Click
        gpRegistro.Visible = False
        btnVerRegistro.Visible = True
        btnOcultarRegistro.Visible = False
    End Sub


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub


    Private Sub tmrMostrarEditarRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarEditarRegistro.Tick
        If panelEditarRegistro.Width >= 349 Then
            tmrMostrarEditarRegistro.Enabled = False
        Else
            panelEditarRegistro.Width = panelEditarRegistro.Width + 10
        End If
    End Sub


    Private Sub tmrOcultarEditarRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarEditarRegistro.Tick
        If panelEditarRegistro.Width <= 0 Then
            tmrOcultarEditarRegistro.Enabled = False
        Else
            panelEditarRegistro.Width = panelEditarRegistro.Width - 10

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        tmrOcultarEditarRegistro.Enabled = True
    End Sub


    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadUnidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadUnidad.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCosto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPorcentaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRegistro.Click
        If Val(txtPrecioCosto.Text) > 0 And Val(txtCantidad.Text) > 0 And Val(txtPorcentaje.Text) > 0 Then

            Dim precioCosto As Integer = Val(txtPrecioCosto.Text)
            Dim precioVenta As Integer = (precioCosto + ((Val(txtPorcentaje.Text) * precioCosto) / 100))

            consulta.consultaHide("UPDATE surtidoProductos set precioCosto=" & precioCosto & ", precioVenta=" & precioVenta & ", Cantidad=" & txtCantidad.Text & ", porcentajeGanancia=" & txtPorcentaje.Text & " where idSurtido=" & idSurtido & ";")

            'Primero restamos la cantidad anterior.
            stockAux = stockAux - cantidadAux
            consulta.consultaHide("UPDATE Productos set Stock=" & stockAux & " where idProducto=" & idProducto & ";")

            stockAux = stockAux + Val(txtCantidad.Text)
            'Agregamos los demás datos y ahora sumamos la cantidad actual.
            consulta.consultaHide("UPDATE Productos set precioCosto=" & precioCosto & ", precioVenta =" & precioVenta & ", Stock=" & stockAux & " where idProducto=" & idProducto & ";")

            actualizarTablaConId()
            tmrOcultarEditarRegistro.Enabled = True
        Else
            mostrarMensaje("Los campos no pueden estar vacios o valer 0.")
        End If
    End Sub

    Private Sub txtBuscarCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarCodigo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                dgvProductos.Focus()
            End If
        End If
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim nuevo As SurtirProductos = New SurtirProductos()

        nuevo.soloNuevoBool = True
        nuevo.txtCodigo.Select()
        nuevo.txtCodigo.Focus()
        nuevo.ShowDialog()
    End Sub

    Private Sub chkNoActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        resultado = ConfirmacionMensaje.confirmacion("   ¿Seguro que desea quitar este producto?")
        If resultado = 1 Then
            consulta.consultaHide("UPDATE Productos set existenteBool = 0 where idProducto=" & idProducto & ";")

            ActualizarTablaProductos()

        End If
    End Sub


    Private Sub chbProdNoActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbProdNoActivos.CheckedChanged
        If chbProdNoActivos.Checked Then
            dgvProductos.DataSource = consulta.mostrarEnTabla("SELECT idProducto As Código, nombre as Nombre, REPLACE(cantidadUnidad,',','.') as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e, minimoStock as m FROM Productos where existenteBool = 0 order by(nombre) asc;")
            dgvProductos.Columns(7).Visible = False
            dgvProductos.Columns(8).Width = 0
            btnEliminar.Visible = False
            btnAgregarProd.Visible = True
        Else
            ActualizarTablaProductos()
            btnEliminar.Visible = True
            btnAgregarProd.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProd.Click
        consulta.consultaHide("UPDATE Productos set existenteBool = 1 where idProducto=" & idProducto & ";")
        dgvProductos.DataSource = consulta.mostrarEnTabla("SELECT idProducto As Código, nombre as Nombre, REPLACE(cantidadUnidad,',','.') as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta, Stock, existenteBool as e, minimoStock as m FROM Productos where existenteBool = 0 order by(nombre) asc;")
        dgvProductos.Columns(7).Visible = False
        dgvProductos.Columns(8).Width = 0
    End Sub

    Private Sub txtMinimoStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinimoStock.TextChanged
        If txtMinimoStock.BackColor = Color.Red Then
            txtMinimoStock.BackColor = Color.White
        End If
    End Sub

    Private Sub dgvProductos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProductos.CellFormatting
        If dgvProductos.Columns(e.ColumnIndex).Name = "Stock" Then

            Dim valor As Integer = e.Value

            If valor <= minimoStock Then
                dgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Red
                dgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ActualizarTablaProductos()
        If txtBuscarProductos.Visible Then
            txtBuscarCodigo.Visible = True
            txtBuscarProductos.Visible = False
        Else
            txtBuscarProductos.Visible = True
            txtBuscarCodigo.Visible = False
        End If
    End Sub
End Class