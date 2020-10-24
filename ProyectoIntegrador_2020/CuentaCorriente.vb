﻿Imports System.Runtime.InteropServices

Public Class CuentaCorriente

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer
    Dim idCompra As Integer
    Dim resultadosEntrada As String
    Dim confirmacion As Byte
    Dim saldo As Integer

    '----INICIO DEL FORMULARIO----'

    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
        limpiarHaber()
        limpiarDebe()
    End Sub

    Private Sub CuentaCorriente_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        txtBuscarClientes.Focus()
        btnDebe.Enabled = False
        btnHaber.Enabled = False
        actualizarTabla()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipal.formularioBool = False
        Me.Close()
    End Sub

    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----MÉTODO PARA BUSCAR LOS CLIENTES POR NOMBRE----'

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged

        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo, maxPermitidoBool As p FROM Clientes WHERE estadoBool=1 AND Nombre LIKE '%" & txtBuscarClientes.Text & "%';")

        consultas.consultaReturnHide("Select count(idCliente) from Clientes;")
        Dim cantClientes As Integer = Val(consultas.valorReturn)

        If cantClientes > 0 Then
            dgvClientes.Columns(3).Width = 0
        End If
    End Sub

    Private Sub btnActualizarDeuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDeuda.Click
        actualizarDeuda()
    End Sub


    '----ACTUALIZA EL SALDO DEL CLIENTE SELECCIONADO----'

    Private Sub actualizarDeuda()
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        If Not txtDineroDebe.Text.Equals("") And Not txtDineroDebe.Text.Equals("0") Then

            '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL DEBE----'


            If txtDetalleDebe.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO compraCliente(Saldo,fechaCompra,adeudoBool,idCliente) Values(" & txtDineroDebe.Text & ",now(),1," & idCliente & ");")
            Else
                consultas.consultaHide("INSERT INTO compraCliente(Saldo,Detalle,fechaCompra,adeudoBool,idCliente) Values(" & txtDineroDebe.Text & ",'" & txtDetalleDebe.Text & "'" & ",now(),1," & idCliente & ");")
            End If


        End If


        If consultas.resultado = 1 Then

            consultas.consultaReturnHide("SELECT SUM(Saldo) FROM compraCliente WHERE adeudoBool=1 AND idCliente=" & idCliente & ";")
            Dim dinero As String = consultas.valorReturn
            consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
            Dim nombre As String = consultas.valorReturn

            'ACTUALIZO LA DEUDA EN EL CLIENTE

            consultas.consultaReturnHide("SELECT Saldo from Clientes where idCliente=" & idCliente & ";")
            Dim saldoActual As Integer = Val(consultas.valorReturn)

            consultas.consultaHide("UPDATE Clientes set Saldo=" & (saldoActual + Val(txtDineroDebe.Text)) & " where idCliente=" & idCliente & ";")

            actualizarTablaConId()
            ActualizarTablaRegistroVenta()
            limpiarDebe()
            txtBuscarClientes.Focus()
            limpiarDebe()

        Else
            mostrarMensaje("Error. Verifique el dinero ingresado.")
        End If

    End Sub

    '----HACE VISIBLE LA SECCIÓN DE ACTUALIZAR SALDO----'

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        limpiarDebe()
        gbDebe.Visible = True
        gbHaber.Visible = False
        txtDineroDebe.Focus()
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        limpiarHaber()
        gbHaber.Visible = True
        gbDebe.Visible = False
        btnPagarTodoRegistro.Enabled = True
        txtDineroHaber.Focus()
    End Sub


    '----OBTIENE EL ID DEL CLIENTE SELECCIONADO----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
            saldo = dgvClientes.SelectedCells(2).Value
        End If

        btnDebe.Enabled = True
        btnHaber.Enabled = True
        btnVerRegistro.Enabled = True

        ActualizarTablaRegistroVenta()
    End Sub


    '----MUESTRA O ESCONDE CAMPO DE AGREGAR DETALLE----'


    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        actualizarTabla()
        limpiarDebe()
        limpiarHaber()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MÉTODO QUE ACTUALIZA LA TABLA----'

    Private Sub actualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo, maxPermitidoBool As p FROM Clientes WHERE estadoBool=1;")

        dgvClientes.Columns(3).Visible = True
        dgvClientes.Columns(3).Width = 0

    End Sub


    Private Sub actualizarTablaConId()
        Dim idTemp As Integer = idCliente

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
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,cc.Saldo,Detalle,fechaCompra As Fecha FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND adeudoBool=1 AND c.idCliente=" & idCliente & " order by(idCompra) desc;")

        dgvRegistroVentas.Columns(0).Visible = False

    End Sub




    '----MÉTODO QUE SOLO DEJA INGRESAR NÚMEROS Y TECLA RETROCESO----'

    Private Sub txtDinero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDineroDebe.KeyPress
            If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
                e.Handled = True

                If e.KeyChar = ChrW(Keys.Enter) Then
                If txtDineroDebe.Text.Equals("") Then
                    e.Handled = True
                    mostrarMensaje("El saldo no puede estar vacio.")
                Else
                    actualizarDeuda()
                End If
                End If
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
            dgvClientes.Focus()
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


    Private Sub btnCerrarGBDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarDebe()
    End Sub

    Private Sub btnPagarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        consultas.consultaReturnHide("SELECT SUM(saldo) FROM compraCliente as cc,Clientes as c where c.idCliente = cc.idCliente and c.idCliente=" & idCliente & ";")
        txtDineroDebe.Text = consultas.valorReturn
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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarDebe()
    End Sub


    Private Sub btnVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalleDebe.Click
        txtDetalleDebe.Visible = True
        txtDetalleDebe.Text = ""
        btnVerDetalleDebe.Visible = False
        btnOcultarDetalleDebe.Visible = True
        txtDetalleDebe.Focus()
    End Sub

    Private Sub btnOcultarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarDetalleDebe.Click
        txtDetalleDebe.Visible = False
        btnVerDetalleDebe.Visible = True
        btnOcultarDetalleDebe.Visible = False
    End Sub

    Private Sub txtDetalle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalleDebe.KeyPress
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

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        gbDebe.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiarHaber()
    End Sub



    Private Sub limpiarDebe()
        gbDebe.Visible = False
        txtDineroDebe.Text = ""
        txtDetalleDebe.Text = ""
        btnOcultarDetalleDebe.Visible = False
        btnVerDetalleDebe.Visible = True
        txtDetalleDebe.Visible = False
    End Sub

    Sub limpiarHaber()
        gbHaber.Visible = False
        btnOcultarDetalleHaber.Visible = False
        btnVerDetalleHaber.Visible = True
        txtDetalleHaber.Visible = False
        txtDetalleHaber.Text = ""
    End Sub


    Private Sub dgvRegistroVentas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistroVentas.SelectionChanged
        Dim row As DataGridViewRow = dgvRegistroVentas.CurrentRow

        txtDetalleHaber.Visible = False

        If dgvRegistroVentas.SelectedCells.Count <> 0 Then
            idCompra = dgvRegistroVentas.SelectedCells(0).Value
        End If

    End Sub

    Private Sub btnEliminarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not txtDineroHaber.Text.Equals("") Then

            'ACTUALIZO LA DEUDA EN EL CLIENTE

            consultas.consultaReturnHide("SELECT Saldo from Clientes where idCliente=" & idCliente & ";")
            Dim saldoActual As Integer = Val(consultas.valorReturn)

            consultas.consultaHide("UPDATE Clientes set Saldo=" & (saldoActual - Val(txtDineroHaber.Text)) & " where idCliente=" & idCliente & ";")


            txtDineroHaber.Text = ""
            ActualizarTablaRegistroVenta()
            actualizarTablaConId()
        End If
    End Sub

    Private Sub btnEliminarTodoRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTodoRegistro.Click
        confirmacion = ConfirmacionMensaje.confirmacion("             ¿Seguro que desea cobrar" & vbCrLf & "              todo el saldo?")
        If confirmacion = 1 Then


            consultas.consultaReturnHide("SELECT SUM(Saldo) FROM compraCliente where adeudoBool=1 AND idCliente=" & idCliente & ";")
            If Not consultas.valorReturn = "0" Then
                txtDineroHaber.Text = consultas.valorReturn
            End If



            Do
                ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                ConfirmacionMensaje.entradaDatos("Ingrese el nombre del cobrador:")
                resultadosEntrada = ConfirmacionMensaje.resultadoTxt
            Loop While resultadosEntrada = ""


            consultas.consultaHide("UPDATE compraCliente set adeudoBool=0 where adeudoBool != 2 AND idCliente=" & idCliente & ";")
            If consultas.resultado = 1 Then

                'ACTUALIZO LA DEUDA EN EL CLIENTE

                consultas.consultaReturnHide("SELECT Saldo from Clientes where idCliente=" & idCliente & ";")
                Dim saldoActual As Integer = Val(consultas.valorReturn)

                consultas.consultaHide("UPDATE Clientes set Saldo=" & (saldoActual - Val(txtDineroHaber.Text)) & " where idCliente=" & idCliente & ";")


                If txtDetalleHaber.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO compraCliente (Saldo,Cobrador,fechaCompra,adeudoBool,idCliente) VALUES (-" & txtDineroHaber.Text & ",'" & resultadosEntrada & "',NOW(),2," & idCliente & ");")
                Else
                    consultas.consultaHide("INSERT INTO compraCliente (Saldo,Detalle,Cobrador,fechaCompra,adeudoBool,idCliente) VALUES (-" & txtDineroHaber.Text & ",'" & txtDetalleHaber.Text & "','" & resultadosEntrada & "',NOW(),2," & idCliente & ");")
                End If
                ActualizarTablaRegistroVenta()
                actualizarTablaConId()
                txtBuscarClientes.Focus()
                limpiarHaber()
            End If

        End If
    End Sub

    Private Sub btnPagarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        consultas.consultaReturnHide("SELECT SUM(Saldo) FROM compraCliente where adeudoBool=1 AND idCliente=" & idCliente & ";")
        If Not consultas.valorReturn = "0" Then
            txtDineroHaber.Text = consultas.valorReturn
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

    Private Sub btnCobrarHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescontarHaber.Click
        pagarDeuda()
        limpiarHaber()
    End Sub


    Sub pagarDeuda()
        If Not txtDineroHaber.Text.Equals("") And Not txtDineroHaber.Text.Equals("0") Then

            If txtDetalleHaber.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO compraCliente(Saldo,fechaCompra,adeudoBool,idCliente) Values(-" & txtDineroHaber.Text & ",now(),1," & idCliente & ");")
            Else
                consultas.consultaHide("INSERT INTO compraCliente(Saldo,Detalle,fechaCompra,adeudoBool,idCliente) Values(-" & txtDineroHaber.Text & ",'" & txtDetalleHaber.Text & "'" & ",now(),1," & idCliente & ");")
            End If

            'ACTUALIZO LA DEUDA EN EL CLIENTE

            consultas.consultaReturnHide("SELECT Saldo from Clientes where idCliente=" & idCliente & ";")
            Dim saldoActual As Integer = Val(consultas.valorReturn)

            consultas.consultaHide("UPDATE Clientes set Saldo=" & (saldoActual - Val(txtDineroHaber.Text)) & " where idCliente=" & idCliente & ";")

            txtDineroHaber.Text = ""
            ActualizarTablaRegistroVenta()
            actualizarTablaConId()
            txtDineroHaber.Focus()

        End If
    End Sub


    Private Sub chkRegistroCompleto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegistroCompleto.CheckedChanged
        If chkRegistroCompleto.Checked Then
            gbHaber.Visible = False
            btnHaber.Enabled = False
            'Aqui podrá ver el registro completo pero sin los cobros realizados.
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,cc.Saldo,Detalle,Cobrador,fechaCompra As Fecha FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND c.idCliente=" & idCliente & " order by(idCompra) desc;")
            dgvRegistroVentas.Columns(0).Visible = False


        Else
            btnHaber.Enabled = True
            'Aqui solo podrá ver los registros que estén sin cobrar.
            dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,cc.Saldo,Detalle,fechaCompra As Fecha FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND adeudoBool=1 AND c.idCliente=" & idCliente & " order by(idCompra) desc;")
            dgvRegistroVentas.Columns(0).Visible = False
        End If
    End Sub


    Private Sub dgvRegistroVentas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRegistroVentas.CellFormatting
        If dgvRegistroVentas.Columns(e.ColumnIndex).Name = "Saldo" Then

            Dim valor As Integer = Val(e.Value)

            If valor < 0 Then
                dgvRegistroVentas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                dgvRegistroVentas.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.IndianRed
            End If

        End If
    End Sub

    Private Sub txtDineroHaber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDineroHaber.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtDineroDebe.Text.Equals("") Then
                    e.Handled = True
                    mostrarMensaje("El saldo no puede estar vacio.")
                Else
                    pagarDeuda()
                End If
            End If
        End If
    End Sub

    Private Sub txtDineroHaber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDineroHaber.TextChanged
        If saldo = Val(txtDineroHaber.Text) Then
            btnDescontarHaber.Enabled = False
        Else
            btnDescontarHaber.Enabled = True
        End If
    End Sub

    Private Sub txtDetalleHaber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalleHaber.KeyPress
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
End Class