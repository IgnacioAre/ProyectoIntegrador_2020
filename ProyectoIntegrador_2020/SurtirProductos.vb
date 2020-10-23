Imports System.Runtime.InteropServices

Public Class SurtirProductos

    Dim consulta As Conexion = New Conexion()

    'Este contador sirve como índice para ver el número de compra ya ingresado.
    Dim contadorCompra As Byte = 0
    Dim ultimoCont As Integer = 0
    Dim oneBackBool As Boolean = False
    Public soloNuevoBool As Boolean = False

    'En este arraylist almaceno los productos que seran ingresados al finalizar la compra
    Dim nuevaCompra As List(Of Surtido) = New List(Of Surtido)


    Private Sub SurtitProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panelSurtido.SendToBack()

        If soloNuevoBool Then
            soloNuevo()
        Else
            lblTitulo.Text = "Surtiendo Productos"
            panelAgregar.Height = 0
            TituloContador()
            btnVolverCompra.Visible = False
            ActualizarTablaProd()
        End If
        panelBuscar.Width = 0

    End Sub


    Sub vaciarCampos()
        txtImporteCosto.Text = ""
        txtGanancia.Text = ""
        txtCodigoProducto.Text = ""
        txtCantidad.Text = ""
        lblNombre.Text = ""
        lblNombre.Visible = False
    End Sub


    Sub ActualizarTablaProd()
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, Stock FROM Productos where existenteBool = 1 order by(nombre) asc;")
    End Sub


    Private Sub btnOtraCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtraCompra.Click
        If Val(txtImporteCosto.Text) > 0 And txtCodigoProducto.Text.Count = 13 And Val(txtCantidad.Text) > 0 And Val(txtGanancia.Text) > 0 Then
            If btnVolverCompra.Visible = False Then
                btnVolverCompra.Visible = True
            End If
            insertarCompra()
            txtCodigoProducto.Focus()
        Else
            mostrarMensaje("Debe rellenar todos los campos.")
        End If
    End Sub


    Sub insertarCompra()

        If Val(txtImporteCosto.Text) > 0 And txtCodigoProducto.Text.Count = 13 And Val(txtCantidad.Text) > 0 And Val(txtGanancia.Text) > 0 Then
            Dim precioCosto As Integer = (Val(txtImporteCosto.Text) / Val(txtCantidad.Text))
            Dim precioVenta As Integer = (precioCosto + ((Val(txtGanancia.Text) * precioCosto) / 100))
            nuevaCompra.Add(New Surtido(contadorCompra, txtCodigoProducto.Text, txtImporteCosto.Text, precioVenta, precioCosto, txtCantidad.Text, lblNombre.Text, txtGanancia.Text))
            contadorCompra += 1
            ultimoCont = contadorCompra
            vaciarCampos()
        Else
            mostrarMensaje("Debe completar todos los campos.")
        End If

        TituloContador()
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        If nuevaCompra.Count > 0 Then
            ConfirmacionMensaje.btnAceptar.Text = "Si"
            ConfirmacionMensaje.btnCancelar.Text = "No"
            Dim resultado As Byte = ConfirmacionMensaje.confirmacion("   Si cierra este formulario perderá los productos" & vbCrLf & "   ya registrados.")
            If resultado = 1 Then
                vaciarCampos()
                nuevaCompra.Clear()
                Me.Close()
            End If
        Else
            vaciarCampos()
            nuevaCompra.Clear()
            Me.Close()
        End If

    End Sub


    Private Sub btnVolverCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCompra.Click

        If Val(txtImporteCosto.Text) > 0 And txtCodigoProducto.Text.Count = 13 And Val(txtCantidad.Text) > 0 And Val(txtGanancia.Text) > 0 Then
            For Each item As Surtido In nuevaCompra
                If item.FuncionContador = contadorCompra Then
                    item.FuncionIdProducto = txtCodigoProducto.Text
                    item.FuncionCostoTotal = txtImporteCosto.Text
                    item.FuncionNombre = lblNombre.Text
                    item.FuncionStock = txtCantidad.Text
                    item.FuncionPorcentaje = txtGanancia.Text
                End If
            Next
            contadorCompra -= 1
            TituloContador()
            If contadorCompra > 0 Then
                btnVolverCompra.Visible = True
            End If


            vaciarCampos()

            btnOtraCompra.Enabled = False
            For Each item As Surtido In nuevaCompra
                If item.FuncionContador = contadorCompra Then
                    txtCodigoProducto.Text = item.FuncionIdProducto
                    txtImporteCosto.Text = item.FuncionCostoTotal
                    lblNombre.Text = item.FuncionNombre
                    txtCantidad.Text = item.FuncionStock
                    txtGanancia.Text = item.FuncionPorcentaje
                End If
            Next
            btnSiguienteCompra.Visible = True
            If contadorCompra = 0 Then
                btnVolverCompra.Visible = False
            End If

        Else
            If oneBackBool = False Then
                btnOtraCompra.Enabled = False
                contadorCompra -= 1
                TituloContador()
                For Each item As Surtido In nuevaCompra
                    If item.FuncionContador = contadorCompra Then
                        txtCodigoProducto.Text = item.FuncionIdProducto
                        txtImporteCosto.Text = item.FuncionCostoTotal
                        lblNombre.Text = item.FuncionNombre
                        txtCantidad.Text = item.FuncionStock
                        txtGanancia.Text = item.FuncionPorcentaje
                    End If
                Next
                btnSiguienteCompra.Visible = True
                If contadorCompra = 0 Then
                    btnVolverCompra.Visible = False
                End If
            Else
                mostrarMensaje("Debe completar todos los campos antes de continuar.")
            End If

        End If


    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteCosto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                txtCantidad.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigoProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSiguienteCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteCompra.Click

        If Val(txtImporteCosto.Text) > 0 And txtCodigoProducto.Text.Count = 13 And Val(txtCantidad.Text) > 0 And Val(txtGanancia.Text) > 0 Then
            For Each item As Surtido In nuevaCompra
                If item.FuncionContador = contadorCompra Then
                    item.FuncionIdProducto = txtCodigoProducto.Text
                    item.FuncionCostoTotal = txtImporteCosto.Text
                    item.FuncionNombre = lblNombre.Text
                    item.FuncionStock = txtCantidad.Text
                    item.FuncionPorcentaje = txtGanancia.Text
                End If
            Next
            contadorCompra += 1
            TituloContador()
            If contadorCompra > 0 Then
                btnVolverCompra.Visible = True
            End If


            vaciarCampos()
            For Each item As Surtido In nuevaCompra
                If item.FuncionContador = contadorCompra Then
                    txtCodigoProducto.Text = item.FuncionIdProducto
                    txtImporteCosto.Text = item.FuncionCostoTotal
                    lblNombre.Text = item.FuncionNombre
                    txtCantidad.Text = item.FuncionStock
                    txtGanancia.Text = item.FuncionPorcentaje
                End If
            Next

            If ultimoCont = contadorCompra Then
                btnOtraCompra.Enabled = True
                btnSiguienteCompra.Visible = False
                oneBackBool = False
                txtCodigoProducto.Focus()
            End If

        Else
            mostrarMensaje("Debe completar todos los campos antes de continuar.")

        End If


    End Sub


    Private Sub btnFinalizarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarSurtido.Click
        If Val(txtImporteCosto.Text) > 0 And txtCodigoProducto.Text.Count = 13 And Val(txtCantidad.Text) > 0 And Val(txtGanancia.Text) > 0 Then
            FinalizarCompra()
        Else
            mostrarMensaje("Debe rellenar todos los campos.")
        End If
    End Sub


    Sub FinalizarCompra()
        Dim ideProducto As Long
        Dim precioVenta As Integer
        Dim precioCosto As Integer
        Dim costoTotal As Integer
        Dim Porcentaje As Integer
        Dim Cantidad As Integer

        Dim stockActual As Integer
        Dim existeProd As Boolean = False


        For Each item As Surtido In nuevaCompra

            ideProducto = item.FuncionIdProducto

            If ideProducto = Val(txtCodigoProducto.Text) Then
                existeProd = True
            End If

        Next

        If existeProd = False Then
            insertarCompra()
        End If

        For Each item As Surtido In nuevaCompra

            precioCosto = item.FuncionCosto
            precioVenta = item.FuncionVenta
            Porcentaje = item.FuncionPorcentaje
            Cantidad = item.FuncionStock
            ideProducto = item.FuncionIdProducto
            costoTotal = item.FuncionCostoTotal


            consulta.consultaHide("INSERT INTO surtidoProductos(precioCosto,precioVenta,porcentajeGanancia,Cantidad,fechaSurtido,idProducto) Values(" & precioCosto & "," & precioVenta & "," & Porcentaje & "," & Cantidad & ",NOW()," & ideProducto & ");")


            'ACTUALIZA EL STOCK DE PRODUCTOS
            consulta.consultaReturnHide("SELECT Stock FROM Productos WHERE idProducto=" & ideProducto & ";")
            stockActual = consulta.valorReturn
            consulta.consultaHide("UPDATE Productos set Stock=" & (stockActual + Cantidad) & ", precioCosto=" & precioCosto & ", precioVenta=" & precioVenta & " where idProducto=" & ideProducto & ";")


            If consulta.resultado = 1 Then
                vaciarCampos()
                contadorCompra = 0
                ultimoCont = 0
                TituloContador()
                Me.Close()
            Else
                mostrarMensaje("Ocurrió un error al intentar surtir el producto " & ideProducto)
            End If
        Next

        nuevaCompra.Clear()

    End Sub

    Private Sub txtCodigoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If txtCodigoProducto.TextLength = 13 Then
            consulta.consultaReturnHide("SELECT Nombre FROM productos where idProducto=" & txtCodigoProducto.Text & ";")
            lblNombre.Text = consulta.valorReturn
            consulta.consultaReturnHide("SELECT cantidadUnidad FROM productos where idProducto=" & txtCodigoProducto.Text & ";")
            lblNombre.Text = lblNombre.Text & " " & consulta.valorReturn
            consulta.consultaReturnHide("SELECT unidad FROM productos where idProducto=" & txtCodigoProducto.Text & ";")
            lblNombre.Text = lblNombre.Text & " " & consulta.valorReturn


            consulta.consultaReturnHide("SELECT porcentajeGanancia FROM surtidoProductos where idProducto=" & txtCodigoProducto.Text & " order by(idSurtido) desc limit 1;")
            txtGanancia.Text = consulta.valorReturn

            lblNombre.Visible = True
            txtImporteCosto.Focus()
        Else
            lblNombre.Text = ""
            lblNombre.Visible = False
        End If

    End Sub



    Sub TituloContador()

        lblNumProducto.Text = "Producto N° " & (contadorCompra + 1) & " de " & (ultimoCont + 1)
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                txtGanancia.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGanancia.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
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

    Private Sub txtBuscarProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarProductos.TextChanged
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, Stock FROM Productos where existenteBool = 1 and nombre LIKE '%" & txtBuscarProductos.Text & "%' order by(nombre) asc;")
        txtBuscarCodigo.Text = ""
    End Sub

    Private Sub txtBuscarCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigo.TextChanged
        dgvProductos.DataSource = consulta.mostrarEnTabla("Select idProducto As Código, nombre as Nombre, Stock FROM Productos where existenteBool = 1 and idProducto LIKE '%" & txtBuscarCodigo.Text & "%' order by(nombre) asc;")
        txtBuscarProductos.Text = ""
    End Sub

    Private Sub tmrOcultarBuscar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarBuscar.Tick
        If panelBuscar.Width <= 0 Then
            tmrOcultarBuscar.Enabled = False
        Else
            panelBuscar.Width = panelBuscar.Width - 10

        End If
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        panelSurtido.Visible = False
        tmrMostrarBuscar.Enabled = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        tmrOcultarBuscar.Enabled = True
    End Sub

    Private Sub tmrMostrarBuscar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarBuscar.Tick
        If panelBuscar.Width >= 384 Then
            tmrMostrarBuscar.Enabled = False
        Else
            panelBuscar.Width = panelBuscar.Width + 10
        End If
    End Sub

    Private Sub tmrMostrarAgregar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarAgregar.Tick
        If panelAgregar.Height >= 433 Then
            tmrMostrarAgregar.Enabled = False
        Else
            panelAgregar.Height = panelAgregar.Height + 10
        End If
    End Sub

    Private Sub tmrOcultarAgregar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarAgregar.Tick
        If panelBuscar.Height <= 0 Then
            tmrOcultarAgregar.Enabled = False
            panelSurtido.Visible = True
        Else
            panelAgregar.Height = panelAgregar.Height - 10

        End If
    End Sub

    Private Sub btnAnotarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnotarBusqueda.Click
        If dgvProductos.SelectedCells.Count <> 0 Then
            txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells(0).Value.ToString
        End If
        panelSurtido.Visible = True
        txtImporteCosto.Focus()
        tmrOcultarBuscar.Enabled = True
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not e.KeyChar = ChrW(Keys.Space) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True

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

    Private Sub txtBuscarProductos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarProductos.KeyPress
        If Not e.KeyChar = ChrW(Keys.Space) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                dgvProductos.Focus()
            End If

        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        panelSurtido.Visible = False
        tmrMostrarAgregar.Enabled = True
    End Sub

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarAgregar.Click
        tmrOcultarAgregar.Enabled = True
    End Sub



    Sub soloNuevo()
        lblTitulo.Text = "Nuevo Producto"
        panelAgregar.Height = 433
        btnCerrarAgregar.Visible = False
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProd.Click
        If soloNuevoBool Then
            consulta.consultaReturnHide("SELECT idProducto FROM Productos WHERE idProducto=" & txtCodigo.Text & ";")

            If Not consulta.valorReturn = "" Then
                mostrarMensaje("Ya existe un producto registrado con ese código." & vbCrLf & "No olvide fijarse si el producto se encuentra inactivo.")

            Else
                consulta.consultaReturnHide("SELECT minimoStock from productos limit 1;")
                Dim limiteStock As Integer = Val(consulta.valorReturn)

                consulta.consultaHide("INSERT INTO Productos (idProducto, nombre, cantidadUnidad, unidad, Stock,existenteBool,minimoStock) VALUES(" & txtCodigo.Text & ",'" & txtNombre.Text & "'," & txtCantidadUnidad.Text & ",'" & cbxMedida.SelectedItem.ToString & "',0,1," & limiteStock & ");")

                If consulta.resultado = 1 Then
                    Me.Close()
                Else
                    mostrarMensaje("Ocurrió un error al ingresar el producto.")
                End If
            End If

        Else
            tmrOcultarAgregar.Enabled = True
            txtCodigoProducto.Text = txtCodigo.Text
            lblNombre.Text = txtNombre.Text & " " & txtCantidadUnidad.Text & " " & cbxMedida.SelectedItem.ToString
        End If
        panelSurtido.Visible = True
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.TextLength = 13 Then
            txtNombre.Focus()
        End If
    End Sub
End Class