Public Class SurtirProductos

    Dim consulta As Conexion = New Conexion()

    'Este contador sirve como índice para ver el número de compra ya ingresado.
    Dim contadorCompra As Byte = 0
    Dim ultimoCont As Integer = 0
    Dim backBool As Boolean = False

    'En este arraylist almaceno los productos que seran ingresados al finalizar la compra
    Dim nuevaCompra As List(Of Surtido) = New List(Of Surtido)

    Private Sub DebeProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TituloContador()
        btnVolverCompra.Visible = False
    End Sub

    Sub vaciarCampos()
        contadorCompra = 0
        ultimoCont = 0
        txtImporteCosto.Text = ""
        txtGanancia.Text = ""
        txtCodigoProducto.Text = ""
        txtCantidad.Text = ""
        lblNombre.Text = ""
        lblNombre.Visible = False
    End Sub


    Private Sub btnOtraCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtraCompra.Click
        If btnVolverCompra.Visible = False Then
            btnVolverCompra.Visible = True
        End If
        insertarCompra()
        vaciarCampos()
    End Sub


    Sub insertarCompra()

        Dim precioCosto As Integer = (Val(txtImporteCosto.Text) / Val(txtCantidad.Text))
        Dim precioVenta As Integer = (precioCosto + ((Val(txtGanancia.Text) * precioCosto) / 100))


        If Not txtImporteCosto.Text.Equals("") And Not txtCodigoProducto.Text.Equals("") Then
            nuevaCompra.Add(New Surtido(contadorCompra, txtCodigoProducto.Text, txtImporteCosto.Text, precioVenta, precioCosto, txtCantidad.Text, lblNombre.Text, txtGanancia.Text))
            contadorCompra += 1
            ultimoCont = contadorCompra
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
        If backBool = False Then
            insertarCompra()
            If Not txtImporteCosto.Equals("") And Not txtCodigoProducto.Text.Equals("") Then
                contadorCompra -= 1
            End If
            backBool = True
        End If

        vaciarCampos()

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
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteCosto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSiguienteCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteCompra.Click
        For Each item As Surtido In nuevaCompra
            If item.FuncionContador = contadorCompra Then
                txtCodigoProducto.Text = item.FuncionIdProducto
                txtImporteCosto.Text = item.FuncionCostoTotal
                lblNombre.Text = item.FuncionNombre
                txtCantidad.Text = item.FuncionStock
                txtGanancia.Text = item.FuncionPorcentaje
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
            backBool = False
        End If

    End Sub


    Private Sub btnFinalizarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarSurtido.Click
        FinalizarCompra()
    End Sub


    Sub FinalizarCompra()
        Dim ideProducto As Long
        Dim precioVenta As Integer
        Dim precioCosto As Integer
        Dim costoTotal As Integer
        Dim Porcentaje As Integer
        Dim Cantidad As Integer

        Dim stockActual As Integer

        If Not txtImporteCosto.Text.Equals("") And Not txtCodigoProducto.Text.Equals("") Then
            insertarCompra()
        End If


        For Each item As Surtido In nuevaCompra

            precioCosto = item.FuncionCosto
            precioVenta = item.FuncionVenta
            Porcentaje = item.FuncionPorcentaje
            Cantidad = item.FuncionStock
            ideProducto = item.FuncionIdProducto
            costoTotal = item.FuncionCostoTotal


            If Not txtImporteCosto.Text.Equals("0") And ideProducto <> 0 Then
                consulta.consultaHide("INSERT INTO surtidoProductos(precioCosto,precioVenta,precioTotal,porcentajeGanancia,Cantidad,fechaSurtido,idProducto) Values(" & precioCosto & "," & precioVenta & "," & costoTotal & "," & Porcentaje & "," & Cantidad & ",NOW()," & ideProducto & ");")


                'ACTUALIZA EL STOCK DE PRODUCTOS
                consulta.consultaReturnHide("SELECT Stock FROM Productos WHERE idProducto=" & ideProducto & ";")
                stockActual = consulta.valorReturn
                consulta.consultaHide("UPDATE Productos set Stock=" & (stockActual + Cantidad) & ", precioCosto=" & precioCosto & ", precioVenta=" & precioVenta & " where idProducto=" & ideProducto & ";")

            End If

            If consulta.resultado = 1 Then
                vaciarCampos()
                Me.Close()
            End If
        Next

        nuevaCompra.Clear()

    End Sub

    Private Sub txtCodigoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If txtCodigoProducto.TextLength = 13 Then
            consulta.consultaReturnHide("SELECT Nombre FROM productos where idProducto=" & txtCodigoProducto.Text & ";")
            lblNombre.Text = consulta.valorReturn
            lblNombre.Visible = True
            txtCantidad.Focus()
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
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGanancia.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

End Class