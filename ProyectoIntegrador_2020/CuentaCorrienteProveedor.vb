Imports System.Runtime.InteropServices
Imports System.IO

Public Class CuentaCorrienteProveedor

    Dim consultas As moduloConexion = New moduloConexion
    Dim idProveedor As Integer
    Dim nombreProveedor As String
    Dim idCompra As Integer
    Dim resultadosEntrada As String
    Dim confirmacion As Byte


    '----INICIO DEL FORMULARIO----'

    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscarNombreProv.Focus()
        Me.ttpHaber.SetToolTip(btnHaber, "Aquí podrás añadir dinero a la cuenta del cliente.")
        Me.ttpHaber.SetToolTip(btnHaber, "Aquí podrás descontar o pagar todo el dinero a la cuenta del cliente.")
        btnDebe.Enabled = False
        btnHaber.Enabled = False
        consultas.establecerConexion()
        SendMessage(txtBuscarNombreProv.Handle, EM_SETCUEBANNER, 0, "Buscar proveedor por nombre")
        SendMessage(txtBuscarCodigoProv.Handle, EM_SETCUEBANNER, 0, "Buscar proveedor por código")
        actualizarTabla()
        ultimaCompra()
    End Sub

    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    Sub ultimaCompra()
        consultas.consultaReturnHide("select fechaVenta from ventaProveedor order by(fechaVenta) desc limit 1;")
        lblUltimaCompra.Text = "Última compra: " & consultas.valorReturn
    End Sub


    '----MÉTODO PARA BUSCAR LOS CLIENTES POR NOMBRE----'

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNombreProv.TextChanged
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo FROM Proveedores where estadoBool=1 And Nombre LIKE '%" & txtBuscarNombreProv.Text & "%';")
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    '----HACE VISIBLE LA SECCIÓN DE UNA NUEVA COMPRA----'

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        limpiarDebe()
        gbHaber.Visible = True
        gbDebe.Visible = False
        txtDineroHaber.Focus()
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        limpiarHaber()
        gbDebe.Visible = True
        gbHaber.Visible = False
        btnPagarTodoRegistro.Enabled = True
        txtDineroDebe.Focus()

    End Sub


    '----OBTIENE EL ID DEL CLIENTE SELECCIONADO----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProveedores.SelectionChanged
        If dgvProveedores.SelectedCells.Count <> 0 Then
            btnDebe.Enabled = True
            btnHaber.Enabled = True
            idProveedor = dgvProveedores.SelectedCells(0).Value
            nombreProveedor = dgvProveedores.SelectedCells(1).Value

        Else
            btnDebe.Enabled = False
            btnHaber.Enabled = False
        End If


        consultas.consultaReturnHide("SELECT Saldo FROM proveedores where idProveedor=" & idProveedor & ";")
        If Val(consultas.valorReturn) = 0 Then
            btnPagarTodoRegistro.Enabled = False
        Else
            btnPagarTodoRegistro.Enabled = True
        End If


        chkRegistroCompleto.Checked = False
        ActualizarTablaRegistroCompra()
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



    Public Sub ActualizarTablaRegistroCompra()
        dgvRegistroCompras.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo,Detalle as Comentario,fechaVenta As Fecha FROM ventaProveedor as vp,Proveedores as p WHERE vp.idProveedor = p.idProveedor AND adeudoBool=1 AND p.idProveedor=" & idProveedor & " order by(idVenta) desc;")
        dgvRegistroCompras.Columns(0).Visible = False
    End Sub


    Private Sub limpiarDebe()
        gbHaber.Visible = False
        txtDineroHaber.Text = ""
        txtDetalleHaber.Text = ""
    End Sub

    Sub limpiarHaber()
        gbDebe.Visible = False
        txtDineroHaber.Text = ""
        txtDetalleDebe.Text = ""
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

    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNombreProv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            dgvProveedores.Focus()
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

    '----MOSTRAR MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub


    Private Sub dgvRegistroCompras_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistroCompras.SelectionChanged
        Dim row As DataGridViewRow = dgvRegistroCompras.CurrentRow

        If dgvRegistroCompras.SelectedCells.Count <> 0 Then
            idCompra = dgvRegistroCompras.SelectedCells(0).Value
        End If

    End Sub

    Private Sub btnEliminarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not txtDineroDebe.Text.Equals("") Then
            MsgBox(idCompra)
            consultas.consultaHide("UPDATE ventaProveedor set adeudoBool=0 where Saldo>0 AND idVenta=" & idCompra & ";")

            If consultas.resultado = 1 Then
                'ACTUALIZO LA DEUDA EN EL PROVEEDOR

                consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
                Dim saldoActual As Integer = Val(consultas.valorReturn)

                consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual - Val(txtDineroDebe.Text)) & " where idProveedor=" & idProveedor & ";")

                txtDineroDebe.Text = ""
                ActualizarTablaRegistroCompra()
                actualizarTablaConId()
            End If

        End If
    End Sub

    Private Sub btnEliminarTodoRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTodoRegistro.Click
        pagarTodoDeuda()
    End Sub



    Sub pagarTodoDeuda()
        confirmacion = ConfirmacionMensaje.confirmacion("             ¿Seguro que desea pagar" & vbCrLf & "              todo el saldo?")
        If confirmacion = 1 Then

            'Cargo todo el dinero en el txtDinero
            consultas.consultaReturnHide("SELECT SUM(Saldo) FROM ventaProveedor where adeudoBool=1 AND idProveedor=" & idProveedor & ";")
            If Not consultas.valorReturn = "0" Then

                txtDineroDebe.Text = consultas.valorReturn

            End If



            Do
                ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                ConfirmacionMensaje.entradaDatos("Ingrese el nombre del cobrador:")
                resultadosEntrada = ConfirmacionMensaje.resultadoTxt
            Loop While resultadosEntrada = ""


            consultas.consultaHide("UPDATE ventaProveedor set adeudoBool=0 where adeudoBool <> 2 AND idProveedor=" & idProveedor & ";")

            If consultas.resultado = 1 Then
                'ACTUALIZO LA DEUDA EN EL PROVEEDOR

                consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
                Dim saldoActual As Long = Val(consultas.valorReturn)

                consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual - Val(txtDineroDebe.Text)) & " where idProveedor=" & idProveedor & ";")
                If txtDetalleDebe.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO ventaProveedor (Saldo,Cobrador,fechaVenta,adeudoBool,idProveedor) VALUES (-" & txtDineroDebe.Text & ",'" & resultadosEntrada & "',NOW(),2," & idProveedor & ");")
                Else
                    consultas.consultaHide("INSERT INTO ventaProveedor (Saldo,Detalle,Cobrador,fechaVenta,adeudoBool,idProveedor) VALUES (-" & txtDineroDebe.Text & ",'" & txtDetalleDebe.Text & "','" & resultadosEntrada & "',NOW(),2," & idProveedor & ");")
                End If
                ActualizarTablaRegistroCompra()
                actualizarTablaConId()
                txtBuscarNombreProv.Focus()
                limpiarHaber()
            End If

        End If
    End Sub



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub

    Private Sub txtDineroHaber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDineroDebe.KeyPress

        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtDineroDebe.Text.Equals("") Then
                    e.Handled = True
                    mostrarMensaje("Debe introducir la cantidad de dinero.")
                Else
                    consultas.consultaReturnHide("SELECT Saldo FROM Proveedores where idProveedor=" & idProveedor)
                    If txtDineroDebe.Text.Equals(consultas.valorReturn) Then
                        pagarTodoDeuda()
                    Else
                        descontarDeuda()
                    End If

                End If
            End If
        End If

    End Sub


    Private Sub chkRegistroCompleto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegistroCompleto.CheckedChanged
        If chkRegistroCompleto.Checked Then
            dgvRegistroCompras.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo,Detalle,Cobrador,fechaVenta As Fecha FROM ventaProveedor as vp,Proveedores as p WHERE vp.idProveedor = p.idProveedor AND p.idProveedor=" & idProveedor & " order by(idVenta) desc;")
            dgvRegistroCompras.Columns(0).Visible = False
        Else
            'Aqui solo podrá ver los registros que estén sin cobrar.
            dgvRegistroCompras.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo,Detalle,fechaVenta As Fecha FROM ventaProveedor as vp,Proveedores as p WHERE vp.idProveedor = p.idProveedor AND adeudoBool=1 AND p.idProveedor=" & idProveedor & " order by(idVenta) desc;")
            dgvRegistroCompras.Columns(0).Visible = False
        End If
    End Sub


    Private Sub btnCerrarHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarDebe.Click
        limpiarHaber()
        gbDebe.Visible = False
    End Sub


    Private Sub btnPagarHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescontarHaber.Click
        descontarDeuda()
    End Sub



    Sub descontarDeuda()
        If Val(txtDineroDebe.Text) > 0 Then

            If txtDetalleDebe.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO ventaProveedor(Saldo,fechaVenta,adeudoBool,idProveedor) Values(-" & txtDineroDebe.Text & ",now(),1," & idProveedor & ");")
            Else
                consultas.consultaHide("INSERT INTO ventaProveedor(Saldo,Detalle,fechaVenta,adeudoBool,idProveedor) Values(-" & txtDineroDebe.Text & ",'" & txtDetalleDebe.Text & "'" & ",now(),1," & idProveedor & ");")
            End If

            'ACTUALIZO LA DEUDA EN EL CLIENTE

            consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
            Dim saldoActual As Integer = Val(consultas.valorReturn)

            consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual - Val(txtDineroDebe.Text)) & " where idProveedor=" & idProveedor & ";")

            txtDineroDebe.Text = ""
            ActualizarTablaRegistroCompra()
            actualizarTablaConId()
            txtDineroDebe.Focus()
            limpiarHaber()
        End If
    End Sub


    Private Sub btnActualizarDeuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDeuda.Click
        actualizarSaldo()
    End Sub

    '----ACTUALIZA EL SALDO DEL CLIENTE SELECCIONADO----'

    Private Sub actualizarSaldo()
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        If Not txtDineroHaber.Text.Equals("") And Not txtDineroHaber.Text.Equals("0") Then

            '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL DEBE----'


            If txtDetalleHaber.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO ventaProveedor(Saldo,fechaVenta,adeudoBool,idProveedor) Values(" & txtDineroHaber.Text & ",now(),1," & idProveedor & ");")
            Else
                consultas.consultaHide("INSERT INTO ventaProveedor(Saldo,Detalle,fechaVenta,adeudoBool,idProveedor) Values(" & txtDineroHaber.Text & ",'" & txtDetalleHaber.Text & "'" & ",now(),1," & idProveedor & ");")
            End If

        Else
            mostrarMensaje("Error. Verifique el dinero ingresado.")
        End If


        If consultas.resultado = 1 Then

            consultas.consultaReturnHide("SELECT SUM(Saldo) FROM ventaProveedor WHERE adeudoBool=1 AND idProveedor=" & idProveedor & ";")
            Dim dinero As String = consultas.valorReturn
            consultas.consultaReturnHide("SELECT Nombre FROM Proveedores WHERE idProveedor=" & idProveedor & ";")
            Dim nombre As String = consultas.valorReturn

            'ACTUALIZO LA DEUDA EN EL CLIENTE

            consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
            Dim saldoActual As Long = Val(consultas.valorReturn)

            consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual + Val(txtDineroHaber.Text)) & " where idProveedor=" & idProveedor & ";")

            ultimaCompra()
            actualizarTablaConId()
            ActualizarTablaRegistroCompra()
            limpiarDebe()
            txtBuscarNombreProv.Focus()
        End If

    End Sub


    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarHaber.Click
        limpiarHaber()
        gbHaber.Visible = False
    End Sub


    Private Sub dgvRegistroCompras_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRegistroCompras.CellFormatting

        If dgvRegistroCompras.Columns(e.ColumnIndex).Name = "Saldo" Then

            Dim valor As Long = Val(e.Value)

            If valor < 0 Then
                dgvRegistroCompras.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                dgvRegistroCompras.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.IndianRed
            End If

        End If
    End Sub

    Private Sub txtDineroDebe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDineroHaber.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtDineroHaber.Text.Equals("") Then
                    e.Handled = True
                    mostrarMensaje("El saldo no puede estar vacio.")
                Else
                    actualizarSaldo()
                End If
            End If
        End If

    End Sub


    Private Sub txtDetalleHaber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalleHaber.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

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

    Private Sub txtDetalleDebe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalleDebe.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

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

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        actualizarTabla()
        If txtBuscarNombreProv.Visible Then
            txtBuscarCodigoProv.Visible = True
            txtBuscarNombreProv.Visible = False
        Else
            txtBuscarNombreProv.Visible = True
            txtBuscarCodigoProv.Visible = False
        End If
    End Sub

    Private Sub txtBuscarCodigoProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigoProv.TextChanged
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo FROM Proveedores where estadoBool=1 And idProveedor LIKE '%" & txtBuscarCodigoProv.Text & "%';")
    End Sub


End Class