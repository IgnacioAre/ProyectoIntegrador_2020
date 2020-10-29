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
        ActualizarTablaProductos()
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

    Private Sub dgvProductos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.SelectionChanged
        actualizarPanelMod()
    End Sub


    Sub actualizarPanelMod()
        Dim row As DataGridViewRow = dgvProductos.CurrentRow
        Dim rowSurtido As DataGridViewRow = dgvProductos.CurrentRow

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
            cbxMedida.SelectedItem = row.Cells(3).Value.ToString
            txtStock.Text = row.Cells(7).Value.ToString


            ActualizarTablaRegistro()

            If dgvRegistroSurtido.SelectedCells.Count <> 0 Then
                panelPreciosMod.Visible = False
                txtCostoMod.Text = ""
                txtVentaMod.Text = ""
                txtGananciaMod.Text = ""
            Else
                panelPreciosMod.Visible = True
                If dgvProductos.SelectedCells.Count <> 0 Then
                    txtCostoMod.Text = row.Cells(4).Value.ToString
                    txtVentaMod.Text = row.Cells(5).Value.ToString
                    txtGananciaMod.Text = row.Cells(6).Value.ToString
                End If
            End If

        Else

            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnAgregarProd.Enabled = False

        End If

    End Sub



    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        txtNombre.Text = ""
        ActualizarTablaProductos()
    End Sub

    'ACTUALIZA LA TABLA DE PRODUCTOS

    Public Sub ActualizarTablaProductos()
        dgvProductos.DataSource = consulta.mostrarEnTabla("SELECT idProducto As Código, nombre as Nombre, REPLACE(cantidadUnidad,',','.') as Cantidad, unidad as Medida, precioCosto as Costo, precioVenta as Venta,ganancia as '%', Stock FROM Productos where existenteBool = 1 order by(nombre) asc;")
        dgvProductos.Columns(6).Width = 50

        chbProdNoActivos.Checked = False
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
        actualizarPanelMod()

    End Sub

    'ACTUALIZA LA TABLA DEL REGISTRO DE SURTIDO

    Sub ActualizarTablaRegistro()
        dgvRegistroSurtido.DataSource = consulta.mostrarEnTabla("SELECT idSurtido, sp.precioCosto as Costo, sp.precioVenta as Venta, Cantidad, porcentajeGanancia as Porcentaje, fechaSurtido as Fecha from surtidoProductos as sp,Productos as p where sp.idProducto = p.idProducto and  p.idProducto=" & idProducto & " order by(idSurtido) desc;")
        dgvRegistroSurtido.Columns(0).Visible = False
    End Sub


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
        ActualizarTablaRegistro()

        Dim rowSurtido As DataGridViewRow = dgvProductos.CurrentRow
        
        If dgvRegistroSurtido.SelectedCells.Count <> 0 Then
            panelPreciosMod.Visible = False
            txtCostoMod.Text = ""
            txtVentaMod.Text = ""
            txtGananciaMod.Text = ""
        Else
            panelPreciosMod.Visible = True
        End If
        
    End Sub

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        gpInformacion.Visible = False
        limpiarPreciosMod()
    End Sub


    Sub limpiarPreciosMod()
        rbCosto.Checked = False
        rbVenta.Checked = False
        txtCostoMod.Text = ""
        txtVentaMod.Text = ""
        txtGananciaMod.Text = ""
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If Not txtNombre.Text.Equals("") And Not txtStock.Text.Equals("") And Not txtCantidadUnidad.Text.Equals("") And Not cbxMedida.SelectedItem.ToString.Equals("") Then

            If Val(txtGananciaMod.Text) >= 1 Then
                If Not txtCostoMod.Text.Equals("") And Not txtVentaMod.Text.Equals("") Then
                    txtVentaMod.Text = ""
                Else
                    If txtCostoMod.Text.Equals("") And txtVentaMod.Text.Equals("") And Not (txtGananciaMod.Text) >= 1 Then
                        consulta.consultaHide("UPDATE Productos SET Nombre='" & txtNombre.Text.ToUpper & "', Stock=" & txtStock.Text & ", cantidadUnidad=" & txtCantidadUnidad.Text & ", unidad='" & cbxMedida.SelectedItem.ToString & "' where idProducto=" & idProducto & ";")
                    Else
                        If Not txtCostoMod.Text.Equals("") Then
                            Dim precioCosto = Val(txtCostoMod.Text)
                            Dim precioVenta As Integer = (precioCosto + ((Val(txtGananciaMod.Text) * precioCosto) / 100))
                            consulta.consultaHide("UPDATE Productos SET Nombre='" & txtNombre.Text.ToUpper & "', Stock=" & txtStock.Text & ", cantidadUnidad=" & txtCantidadUnidad.Text & ", unidad='" & cbxMedida.SelectedItem.ToString & "', precioCosto=" & precioCosto & ", precioVenta=" & precioVenta & ", ganancia=" & txtGananciaMod.Text & " where idProducto=" & idProducto & ";")
                        Else
                            If Not txtVentaMod.Text.Equals("") Then
                                Dim precioCosto As Integer = (Val(txtVentaMod.Text) / ((Val(txtGananciaMod.Text) / 100) + 1))
                                consulta.consultaHide("UPDATE Productos SET Nombre='" & txtNombre.Text.ToUpper & "', Stock=" & txtStock.Text & ", cantidadUnidad=" & txtCantidadUnidad.Text & ", unidad='" & cbxMedida.SelectedItem.ToString & "', precioCosto=" & precioCosto & ", precioVenta=" & txtVentaMod.Text & ", ganancia=" & txtGananciaMod.Text & " where idProducto=" & idProducto & ";")
                            Else
                                mostrarMensaje("El precio de costo o de venta está vacio" & vbCrLf & "y no es posible hacer el cálculo.")
                            End If
                        End If

                    End If
                End If
            Else
                If txtCostoMod.Text.Equals("") Or txtVentaMod.Text.Equals("") Then
                    Dim rowSurtido As DataGridViewRow = dgvProductos.CurrentRow

                    If dgvRegistroSurtido.SelectedCells.Count <> 0 Then
                        consulta.consultaHide("UPDATE Productos SET Nombre='" & txtNombre.Text.ToUpper & "', Stock=" & txtStock.Text & ", cantidadUnidad=" & txtCantidadUnidad.Text & ", unidad='" & cbxMedida.SelectedItem.ToString & "' where idProducto=" & idProducto & ";")
                    Else
                        consulta.consultaHide("UPDATE Productos SET Nombre='" & txtNombre.Text.ToUpper & "', Stock=" & txtStock.Text & ", cantidadUnidad=" & txtCantidadUnidad.Text & ", unidad='" & cbxMedida.SelectedItem.ToString & "', precioCosto=0, precioVenta=0, ganancia=" & txtGananciaMod.Text & " where idProducto=" & idProducto & ";")
                    End If



                Else
                    mostrarMensaje("El porcentaje de ganancia tiene que ser mayor a 1")
                End If
            End If

        Else
            mostrarMensaje("Debe rellenar los campos vacios.")
        End If

        If consulta.resultado = 1 Then
            gpInformacion.Visible = False
            limpiarPreciosMod()
            actualizarTablaConId()
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

    Private Sub txtCostoMod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostoMod.TextChanged
        If txtCostoMod.Text.Equals("") Then
            txtVentaMod.Enabled = True
            lblVenta.Enabled = True
            lblAyudaCampos.Visible = False
        ElseIf Not txtVentaMod.Text.Equals("") And Not txtCostoMod.Text.Equals("") Then
            lblAyudaCampos.Visible = False
        Else
            lblAyudaCampos.Visible = True
            lblAyudaCampos.Text = "El campo de ventas se calculará automaticamente."
            txtVentaMod.Enabled = False
            lblVenta.Enabled = False
        End If
    End Sub

    Private Sub txtVentaMod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVentaMod.TextChanged
        If txtVentaMod.Text.Equals("") Then
            lblAyudaCampos.Visible = False
            txtCostoMod.Enabled = True
            lblCosto.Enabled = True
        ElseIf Not txtVentaMod.Text.Equals("") And Not txtCostoMod.Text.Equals("") Then
            lblAyudaCampos.Visible = False
        Else
            lblAyudaCampos.Visible = True
            lblAyudaCampos.Text = "El campo de costo se calculará automaticamente."
            txtCostoMod.Enabled = False
            lblCosto.Enabled = False
        End If
    End Sub

    Private Sub rbCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCosto.CheckedChanged
        txtCostoMod.Enabled = True
        txtVentaMod.Text = ""
        txtVentaMod.Enabled = False
    End Sub

    Private Sub rbVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVenta.CheckedChanged
        txtVentaMod.Enabled = True
        txtCostoMod.Text = ""
        txtCostoMod.Enabled = False
    End Sub


    Private Sub txtCostoMod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVentaMod.KeyPress, txtGananciaMod.KeyPress, txtCostoMod.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                ajustarMinimoStock()
            End If
        End If
    End Sub
End Class