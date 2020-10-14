Imports System.Runtime.InteropServices

Public Class CuentaCorrienteProveedor

    Public consultas As Conexion = New Conexion
    Public idProveedor As Integer
    Dim nombreProveedor As String
    Dim idCompra As Integer
    Dim resultadosEntrada As String
    Dim confirmacion As Byte


    '----INICIO DEL FORMULARIO----'

    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscarClientes.Focus()
        btnDebe.Enabled = False
        btnHaber.Enabled = False
        consultas.establecerConexion()
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
        actualizarTabla()
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----MÉTODO PARA BUSCAR LOS CLIENTES POR NOMBRE----'

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo FROM Proveedores where estadoBool=1 And Nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    '----HACE VISIBLE LA SECCIÓN DE UNA NUEVA COMPRA----'

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        DebeProveedor.idProveedor = idProveedor
        DebeProveedor.lblNombreProv.Text = nombreProveedor
        DebeProveedor.ShowDialog()
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        gbRegistroCompras.Visible = True
        btnVerRegistro.Visible = False
        btnOcultarRegistro.Visible = True
        dgvRegistroVentas.Focus()

        gbHaber.Visible = True
    End Sub


    '----OBTIENE EL ID DEL CLIENTE SELECCIONADO----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProveedores.SelectionChanged
        txtDineroHaber.Text = ""
        If dgvProveedores.SelectedCells.Count <> 0 Then
            idProveedor = dgvProveedores.SelectedCells(0).Value
            nombreProveedor = dgvProveedores.SelectedCells(1).Value
        End If

        btnDebe.Enabled = True
        btnHaber.Enabled = True
        btnVerRegistro.Enabled = True

        chkRegistroCompleto.Checked = False
        ActualizarTablaRegistroVenta()
    End Sub


    '----MUESTRA O ESCONDE CAMPO DE AGREGAR DETALLE----'


    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        actualizarTabla()
        ActualizarTablaRegistroVenta()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MÉTODO QUE ACTUALIZA LA TABLA----'

    Public Sub actualizarTabla()
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo FROM Proveedores where estadoBool=1;")
    End Sub


    Public Sub actualizarTablaConId()
        Dim idTemp As Integer = idProveedor

        actualizarTabla()

        'SELECCIONA EN LA TABLA AL CLIENTE EN idTemp
        For i As Integer = 0 To dgvProveedores.Rows.Count - 1
            If dgvProveedores.Rows(i).Cells(0).Value = idTemp Then

                dgvProveedores.CurrentCell = dgvProveedores.Item(0, i)

                dgvProveedores.Rows(i).Selected = True
                Exit For
            End If
        Next

    End Sub



    Public Sub ActualizarTablaRegistroVenta()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo, pr.nombre as Nombre,vp.stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND adeudoBool=1 AND p.idProveedor=" & idProveedor & ";")

        dgvRegistroVentas.Columns(0).Visible = False

    End Sub



    '----MÉTODO QUE PINTA DE ROJO LOS SALDOS QUE NO SEAN PERMITIDOS POR EL ADMINISTRADOR----'

    Private Sub dgvClientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProveedores.CellFormatting
        If dgvProveedores.Columns(e.ColumnIndex).Name = "p" Then

            If e.Value = "False" Then
                dgvProveedores.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Style.ForeColor = Color.Red
                dgvProveedores.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Style.SelectionForeColor = Color.Red
            End If

        End If
    End Sub

    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarClientes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            dgvProveedores.Focus()
        End If
    End Sub

    '----MOSTRAR MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub



    Private Sub btnVerRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerRegistro.Click
        gbRegistroCompras.Visible = True
        btnVerRegistro.Visible = False
        btnOcultarRegistro.Visible = True
    End Sub

    Private Sub btnOcultarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarRegistro.Click
        gbRegistroCompras.Visible = False
        btnVerRegistro.Visible = True
        btnOcultarRegistro.Visible = False
    End Sub



    Private Sub dgvRegistroCompras_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistroVentas.SelectionChanged
        Dim row As DataGridViewRow = dgvRegistroVentas.CurrentRow
        btnEliminarTodoRegistro.Enabled = False
        btnOcultarDetalleHaber.Visible = False
        btnVerDetalleHaber.Visible = False
        txtDetalleHaber.Visible = False

        If dgvRegistroVentas.SelectedCells.Count <> 0 Then
            idCompra = dgvRegistroVentas.SelectedCells(0).Value

            txtDineroHaber.Text = row.Cells(1).Value.ToString
        End If

        If txtDineroHaber.Text.Equals("") Then
            btnPagarTodo.Enabled = False
            btnEliminarRegistro.Enabled = False
        Else
            btnPagarTodo.Enabled = True
            btnEliminarRegistro.Enabled = True
        End If

    End Sub

    Private Sub btnEliminarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRegistro.Click
        If Not txtDineroHaber.Text.Equals("") Then
            MsgBox(idCompra)
            consultas.consultaHide("UPDATE ventaProveedor set adeudoBool=0 where Saldo>0 AND idVenta=" & idCompra & ";")

            If consultas.resultado = 1 Then
                'ACTUALIZO LA DEUDA EN EL PROVEEDOR

                consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
                Dim saldoActual As Integer = Val(consultas.valorReturn)

                consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual - Val(txtDineroHaber.Text)) & " where idProveedor=" & idProveedor & ";")

                txtDineroHaber.Text = ""
                ActualizarTablaRegistroVenta()
                actualizarTablaConId()
            End If
            
        End If
    End Sub

    Private Sub btnEliminarTodoRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarTodoRegistro.Click
        confirmacion = ConfirmacionMensaje.confirmacion("             ¿Seguro que desea eliminar" & vbCrLf & "              todo el registro de ventas?")
        If confirmacion = 1 Then

            Do
                ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                ConfirmacionMensaje.entradaDatos("Ingrese el nombre del cobrador:")
                resultadosEntrada = ConfirmacionMensaje.resultadoTxt
            Loop While resultadosEntrada = ""

            idCompra = dgvRegistroVentas.CurrentRow.Cells(0).Value.ToString

            consultas.consultaHide("UPDATE ventaProveedor set adeudoBool=0 where Saldo>0 AND adeudoBool <> 2 AND idProveedor=" & idProveedor & ";")

            If consultas.resultado = 1 Then
                'ACTUALIZO LA DEUDA EN EL PROVEEDOR

                consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
                Dim saldoActual As Integer = Val(consultas.valorReturn)

                consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual - Val(txtDineroHaber.Text)) & " where idProveedor=" & idProveedor & ";")
                If txtDetalleHaber.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO ventaProveedor (Saldo,Stock,Cobrador,fechaCompra,adeudoBool,idProveedor) VALUES (" & txtDineroHaber.Text & ",0,'" & resultadosEntrada & "',NOW(),2," & idProveedor & ");")
                Else
                    consultas.consultaHide("INSERT INTO ventaProveedor (Saldo,Detalle,Stock,Cobrador,fechaCompra,adeudoBool,idProveedor) VALUES (" & txtDineroHaber.Text & ",'" & txtDetalleHaber.Text & "',0,'" & resultadosEntrada & "',NOW(),2," & idProveedor & ");")
                End If
                ActualizarTablaRegistroVenta()
                actualizarTablaConId()
                txtBuscarClientes.Focus()
                
            End If
            
        End If
    End Sub

    Private Sub btnPagarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTodo.Click


        consultas.consultaReturnHide("SELECT SUM(Saldo) FROM ventaProveedor where adeudoBool=1 AND idProveedor=" & idProveedor & ";")
        If consultas.valorReturn = "0" Then

            btnEliminarTodoRegistro.Enabled = False
            btnOcultarDetalleHaber.Visible = False
            btnVerDetalleHaber.Visible = False
            txtDetalleHaber.Visible = False
        Else

            txtDineroHaber.Text = consultas.valorReturn
            btnEliminarTodoRegistro.Enabled = True
            btnOcultarDetalleHaber.Visible = True
            btnVerDetalleHaber.Visible = True
            txtDetalleHaber.Visible = True
        End If

    End Sub



    Private Sub btnOcultarDetalleHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarDetalleHaber.Click
        txtDetalleHaber.Visible = False
        btnVerDetalleHaber.Visible = True
        btnOcultarDetalleHaber.Visible = False
    End Sub

    Private Sub btnVerDetalleHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalleHaber.Click
        txtDetalleHaber.Visible = True
        txtDetalleHaber.Text = ""
        btnVerDetalleHaber.Visible = False
        btnOcultarDetalleHaber.Visible = True
        txtDetalleHaber.Focus()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub

    Private Sub txtDineroHaber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDineroHaber.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub


    Private Sub chkRegistroCompleto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegistroCompleto.CheckedChanged
        If chkRegistroCompleto.Checked Then
            gbHaber.Visible = False
            btnHaber.Enabled = False
            chkCobros.Checked = False
            'Aqui podrá ver el registro completo pero sin los cobros realizados.
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo, pr.nombre as Nombre,vp.stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If
        Else
            btnHaber.Enabled = True
            'Aqui solo podrá ver los registros que estén sin cobrar.
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo, pr.nombre as Nombre,vp.stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND adeudoBool=1 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If
        End If
    End Sub

    Private Sub chkCobros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCobros.CheckedChanged
        If chkCobros.Checked Then

            gbHaber.Visible = False
            btnHaber.Enabled = False
            chkRegistroCompleto.Checked = False

            'Solo verá los cobros realizados

            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo,Cobrador,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p WHERE vp.idProveedor = p.idProveedor AND adeudoBool=2 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If

        Else
            'Aqui solo podrá ver los registros que estén sin cobrar.
            btnHaber.Enabled = True

            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo, pr.nombre as Nombre,vp.stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND adeudoBool=1 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If

        End If
    End Sub

    Private Sub btnCerrarHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarHaber.Click
        gbHaber.Visible = False
    End Sub
End Class