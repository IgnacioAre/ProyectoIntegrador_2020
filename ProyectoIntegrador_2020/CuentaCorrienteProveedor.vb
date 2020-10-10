Imports System.Runtime.InteropServices

Public Class CuentaCorrienteProveedor

    Dim consultas As Conexion = New Conexion
    Dim idProveedor As Integer
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
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT p.idProveedor As ID, Nombre,SUM(Saldo) As Saldo FROM Proveedores as p,ventaProveedor as vp where p.idProveedor = vp.idProveedor AND estadoBool=1 And Nombre LIKE '%" & txtBuscarClientes.Text & "%' group by(vp.idProveedor);")
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

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        txtDineroHaber.Text = ""
        If dgvClientes.SelectedCells.Count <> 0 Then
            idProveedor = dgvClientes.SelectedCells(0).Value
            nombreProveedor = dgvClientes.SelectedCells(1).Value
        End If

        btnDebe.Enabled = True
        btnHaber.Enabled = True

        chkRegistroCompleto.Checked = False
        ActualizarTablaRegistroVenta()
    End Sub


    '----MUESTRA O ESCONDE CAMPO DE AGREGAR DETALLE----'


    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        actualizarTabla()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MÉTODO QUE ACTUALIZA LA TABLA----'

    Private Sub actualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT p.idProveedor As ID, Nombre,SUM(Saldo) As Saldo FROM Proveedores as p,ventaProveedor as vp where p.idProveedor = vp.idProveedor AND adeudoBool=1 AND estadoBool=1 group by(vp.idProveedor);")
    End Sub


    Private Sub actualizarTablaConId()
        Dim idTemp As Integer = idProveedor

        actualizarTabla()

        'SELECCIONA EN LA TABLA AL CLIENTE EN idTemp
        For i As Integer = 0 To dgvClientes.Rows.Count - 1
            If dgvClientes.Rows(i).Cells(0).Value = idTemp Then

                dgvClientes.CurrentCell = dgvClientes.Item(0, i)

                dgvClientes.Rows(i).Selected = True
                Exit For
            End If
        Next

    End Sub



    Sub ActualizarTablaRegistroVenta()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,Saldo, pr.nombre as Nombre,stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND adeudoBool=1 AND Saldo > 0 AND p.idProveedor=" & idProveedor & ";")

        consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
        Dim cantCompra As Integer = Val(consultas.valorReturn)

        If cantCompra > 0 Then
            dgvRegistroVentas.Columns(0).Visible = False
        End If

    End Sub



    '----MÉTODO QUE PINTA DE ROJO LOS SALDOS QUE NO SEAN PERMITIDOS POR EL ADMINISTRADOR----'

    Private Sub dgvClientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvClientes.CellFormatting
        If dgvClientes.Columns(e.ColumnIndex).Name = "p" Then

            If e.Value = "False" Then
                dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Style.ForeColor = Color.Red
                dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Style.SelectionForeColor = Color.Red
            End If

        End If
    End Sub

    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarClientes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            dgvClientes.Focus()
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
            txtDineroHaber.Text = ""
            ActualizarTablaRegistroVenta()
            actualizarTablaConId()
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
            If txtDetalleHaber.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO ventaProveedor (Saldo,Stock,Cobrador,fechaCompra,adeudoBool,idProveedor) VALUES (" & txtDineroHaber.Text & ",0,'" & resultadosEntrada & "',NOW(),2," & idProveedor & ");")
            Else
                consultas.consultaHide("INSERT INTO ventaProveedor (Saldo,Detalle,Stock,Cobrador,fechaCompra,adeudoBool,idProveedor) VALUES (" & txtDineroHaber.Text & ",'" & txtDetalleHaber.Text & "',0,'" & resultadosEntrada & "',NOW(),2," & idProveedor & ");")
            End If
            ActualizarTablaRegistroVenta()
            actualizarTablaConId()
            txtBuscarClientes.Focus()
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
            'Aqui podrá ver el registro completo pero sin los cobros realizados.
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,Saldo, pr.nombre as Nombre,stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND Saldo > 0 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If
        Else
            'Aqui solo podrá ver los registros que estén sin cobrar.
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,Saldo, pr.nombre as Nombre,stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND adeudoBool=1 AND Saldo > 0 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If
        End If
    End Sub

    Private Sub chkCobros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCobros.CheckedChanged
        If chkCobros.Checked Then
            'Solo verá los cobros realizados
            gbHaber.Visible = False
            btnHaber.Enabled = False
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,Saldo,Cobrador,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p WHERE vp.idProveedor = p.idProveedor AND adeudoBool=2 AND Saldo > 0 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If

        Else
            'Aqui solo podrá ver los registros que estén sin cobrar.
            btnHaber.Enabled = False
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,Saldo, pr.nombre as Nombre,stock as Cantidad,Detalle as Comentario,fechaCompra As Fecha FROM ventaProveedor as vp,Proveedores as p,Productos as pr WHERE vp.idProveedor = p.idProveedor and vp.idProducto = pr.idProducto AND adeudoBool=1 AND Saldo > 0 AND p.idProveedor=" & idProveedor & ";")

            consultas.consultaReturnHide("Select count(idVenta) from ventaProveedor;")
            Dim cantCompra As Integer = Val(consultas.valorReturn)

            If cantCompra > 0 Then
                dgvRegistroVentas.Columns(0).Visible = False
            End If

        End If
    End Sub
End Class