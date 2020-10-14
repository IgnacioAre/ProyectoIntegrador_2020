Public Class DebeProveedor

    Public idProveedor As Integer = 0
    Dim consulta As Conexion = New Conexion()

    'Este contador sirve como índice para ver el número de compra ya ingresado.
    Dim contadorCompra As Byte = 0
    Dim ultimoCont As Integer = 0
    Dim backBool As Boolean = False

    'En este arraylist almaceno los productos que seran ingresados al finalizar la compra
    Dim nuevaCompra As List(Of compraProveedor) = New List(Of compraProveedor)

    Private Sub DebeProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNumProducto.Text = "Producto N° " & (contadorCompra + 1)
        btnVolverCompra.Visible = False
    End Sub

    Sub vaciarCampos()
        contadorCompra = 0
        txtImporte.Text = ""
        txtCodigoProducto.Text = ""
        txtCantidad.Text = ""
        txtComentario.Text = ""
    End Sub

    
    Private Sub btnOtraCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtraCompra.Click
        If btnVolverCompra.Visible = False Then
            btnVolverCompra.Visible = True
        End If
        insertarCompra()
        vaciarCampos()
    End Sub


    Sub insertarCompra()
        If Not txtImporte.Text.Equals("") And Not txtCodigoProducto.Text.Equals("") And Not txtComentario.Text.Equals("") Then
            nuevaCompra.Add(New compraProveedor(contadorCompra, txtImporte.Text, txtCantidad.Text, txtComentario.Text, txtCodigoProducto.Text, idProveedor))
            contadorCompra += 1
            ultimoCont = contadorCompra
        End If
        If Not txtImporte.Text.Equals("") And Not txtCodigoProducto.Text.Equals("") And txtComentario.Text.Equals("") Then
            nuevaCompra.Add(New compraProveedor(contadorCompra, txtImporte.Text, txtCantidad.Text, txtCodigoProducto.Text, idProveedor))
            contadorCompra += 1
            ultimoCont = contadorCompra
        End If
        lblNumProducto.Text = "Producto N° " & (contadorCompra + 1)
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
            If Not txtImporte.Equals("") And Not txtCodigoProducto.Text.Equals("") Then
                contadorCompra -= 1
            End If
            backBool = True
        End If

        vaciarCampos()

        btnOtraCompra.Enabled = False
        contadorCompra -= 1
        lblNumProducto.Text = "Producto N° " & (contadorCompra + 1)
        For Each item As compraProveedor In nuevaCompra
            If item.FuncionContador = contadorCompra Then
                txtImporte.Text = item.FuncionSaldo
                txtCantidad.Text = item.FuncionStock
                txtCodigoProducto.Text = item.FuncionIdProducto
                txtComentario.Text = item.FuncionDetalle
            End If
        Next
        btnSiguienteCompra.Visible = True
        If contadorCompra = 0 Then
            btnVolverCompra.Visible = False
        End If
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
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
        For Each item As compraProveedor In nuevaCompra
            If item.FuncionContador = contadorCompra Then
                item.FuncionSaldo = txtImporte.Text
                item.FuncionIdProducto = txtCodigoProducto.Text
                item.FuncionDetalle = txtComentario.Text
            End If
        Next
        contadorCompra += 1
        lblNumProducto.Text = "Producto N° " & (contadorCompra + 1)
        If contadorCompra > 0 Then
            btnVolverCompra.Visible = True
        End If
        vaciarCampos()
        For Each item As compraProveedor In nuevaCompra
            If item.FuncionContador = contadorCompra Then
                txtImporte.Text = item.FuncionSaldo
                txtCodigoProducto.Text = item.FuncionIdProducto
                txtComentario.Text = item.FuncionDetalle
            End If
        Next

        If ultimoCont = contadorCompra Then
            btnOtraCompra.Enabled = True
            btnSiguienteCompra.Visible = False
            backBool = False
        End If
        
    End Sub


    Private Sub btnFinalizarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarCompra.Click
        FinalizarCompra()
    End Sub


    Sub FinalizarCompra()
        Dim Saldo As Integer
        Dim Detalle As String
        Dim Cantidad As Integer
        Dim ideProveedor As Integer
        Dim ideProducto As Long
        Dim stockActual As Integer
        Dim saldoActual As Integer

        If Not txtImporte.Text.Equals("") And Not txtCodigoProducto.Text.Equals("") Then
            insertarCompra()
        End If


        For Each item As compraProveedor In nuevaCompra
            Saldo = item.FuncionSaldo
            Detalle = item.FuncionDetalle
            Cantidad = item.FuncionStock
            ideProveedor = item.FuncionIdProveedor
            ideProducto = item.FuncionIdProducto

            If Saldo <> 0 And ideProducto <> 0 And Detalle <> "" Then
                consulta.consultaHide("INSERT INTO ventaProveedor(Saldo,Detalle,Stock,fechaCompra,adeudoBool,idProveedor,idProducto) Values(" & Saldo & ",'" & Detalle & "'," & Cantidad & ",NOW(),1," & ideProveedor & "," & ideProducto & ")")

                'ACTUALIZA EL STOCK DE PRODUCTOS
                consulta.consultaReturnHide("SELECT Stock FROM Productos WHERE idProducto=" & ideProducto & ";")
                stockActual = consulta.valorReturn
                consulta.consultaHide("UPDATE Productos set Stock=" & (stockActual + Cantidad) & " where idProducto=" & ideProducto & ";")

                consulta.consultaReturnHide("SELECT Saldo FROM Proveedores WHERE idProveedor=" & ideProveedor & ";")
                saldoActual = consulta.valorReturn
                consulta.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual + Val(txtImporte.Text)) & " where idProveedor=" & ideProveedor & ";")


            End If

            If Saldo <> 0 And ideProducto <> 0 And Detalle = "" Then
                consulta.consultaHide("INSERT INTO ventaProveedor(Saldo,Stock,fechaCompra,adeudoBool,idProveedor,idProducto) Values(" & Saldo & "," & Cantidad & ",NOW(),1," & ideProveedor & "," & ideProducto & ")")

                'ACTUALIZA EL STOCK DE PRODUCTOS
                consulta.consultaReturnHide("SELECT Stock FROM Productos WHERE idProducto=" & ideProducto & ";")
                stockActual = consulta.valorReturn
                consulta.consultaHide("UPDATE Productos set Stock=" & (stockActual + Cantidad) & " where idProducto=" & ideProducto & ";")

                consulta.consultaReturnHide("SELECT Saldo FROM Proveedores WHERE idProveedor=" & ideProveedor & ";")
                saldoActual = consulta.valorReturn
                consulta.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual + Val(txtImporte.Text)) & " where idProveedor=" & ideProveedor & ";")
            End If

            If consulta.resultado = 1 Then
                Me.Close()
            End If

        Next

        nuevaCompra.Clear()

    End Sub

    Private Sub txtCodigoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If txtCodigoProducto.TextLength = 13 Then
            txtCantidad.Focus()
        End If

    End Sub

End Class