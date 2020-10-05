﻿Imports System.Runtime.InteropServices

Public Class CuentaCorriente

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer
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
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT c.idCliente As ID, Nombre, Saldo, maxPermitidoBool As p FROM Clientes As c,compraCliente As cc WHERE c.idCliente = cc.idCliente And Nombre LIKE '%" & txtBuscarClientes.Text & "%'  group by(cc.idCliente);")
        dgvClientes.Columns(3).Width = 0
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

            consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
            Dim nombre As String = consultas.valorReturn
            consultas.consultaReturnHide("SELECT SUM(Saldo) FROM compraCliente WHERE idCliente=" & idCliente & ";")
            Dim dinero As String = consultas.valorReturn
            resetGBDinero()

            mostrarMensaje(nombre & vbCrLf & "El saldo actual es $" & dinero)
            actualizarTablaConId()
            ActualizarTablaRegistroVenta()

            txtBuscarClientes.Focus()
        Else
            mostrarMensaje("Error. Verifique el dinero ingresado.")
        End If

    End Sub

    '----HACE VISIBLE LA SECCIÓN DE ACTUALIZAR SALDO----'

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        resetGBDinero()
        gbDebe.Visible = True
        gbHaber.Visible = False
        txtDineroDebe.Focus()
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        gbRegistroCompras.Visible = True
        btnVerRegistro.Visible = False
        btnOcultarRegistro.Visible = True
        dgvRegistroVentas.Focus()

        gbHaber.Visible = True
        gbDebe.Visible = False
    End Sub


    '----OBTIENE EL ID DEL CLIENTE SELECCIONADO----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        resetGBDinero()
        txtDineroHaber.Text = ""
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
        End If

        btnDebe.Enabled = True
        btnHaber.Enabled = True

        ActualizarTablaRegistroVenta()
    End Sub


    '----MUESTRA O ESCONDE CAMPO DE AGREGAR DETALLE----'


    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        actualizarTabla()
        resetGBDinero()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MÉTODO QUE ACTUALIZA LA TABLA----'

    Private Sub actualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT c.idCliente As ID, Nombre, SUM(Saldo) As Saldo, maxPermitidoBool As p FROM Clientes As c,compraCliente As cc WHERE c.idCliente = cc.idCliente AND adeudoBool=1 group by(cc.idCliente);")
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
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idCompra,Saldo,Detalle,fechaCompra As Fecha FROM compraCliente,Clientes WHERE compraCliente.idCliente = Clientes.idCliente AND adeudoBool=1 AND Saldo > 0 AND Clientes.idCliente=" & idCliente & ";")
        dgvRegistroVentas.Columns(0).Visible = False
    End Sub




    '----MÉTODO QUE SOLO DEJA INGRESAR NÚMEROS Y TECLA RETROCESO----'

    Private Sub txtDinero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDineroDebe.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                actualizarDeuda()
            Else
                e.Handled = True
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
            e.Handled = True

            dgvClientes.Focus()
        End If
    End Sub

    '----MOSTRAR MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub


    Private Sub btnCerrarGBDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        resetGBDinero()
    End Sub

    Private Sub resetGBDinero()
        gbDebe.Visible = False
        txtDineroDebe.Text = ""
        txtDetalleDebe.Text = ""
        txtDetalleDebe.Visible = False
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
        resetGBDinero()
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

    End Sub

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        resetGBDinero()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gbHaber.Visible = False
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
            consultas.consultaReturnHide("SELECT COUNT(idCompra) from compraCliente where adeudoBool=1 AND idCliente=" & idCliente & ";")
            If consultas.valorReturn = "1" Then
                consultas.consultaHide("UPDATE compraCliente set adeudoBool=0 where idCompra=" & idCompra & ";")
                consultas.consultaHide("UPDATE compraCliente set adeudoBool=1 where Saldo=0 AND idCliente=" & idCliente & ";")
            Else
                consultas.consultaHide("UPDATE compraCliente set adeudoBool=0 where idCompra=" & idCompra & ";")
            End If
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

            consultas.consultaHide("UPDATE compraCliente set adeudoBool=0 where idCliente=" & idCliente & ";")
            consultas.consultaHide("UPDATE compraCliente set adeudoBool=1 where Saldo=0 AND idCliente=" & idCliente & ";")
            If txtDetalleHaber.Text.Equals("") Then
                consultas.consultaHide("INSERT INTO compraCliente (Saldo,Cobrador,fechaCompra,adeudoBool,idCliente) VALUES (" & txtDineroHaber.Text & ",'" & resultadosEntrada & "',NOW(),2," & idCliente & ");")
            Else
                consultas.consultaHide("INSERT INTO compraCliente (Saldo,Detalle,Cobrador,fechaCompra,adeudoBool,idCliente) VALUES (" & txtDineroHaber.Text & ",'" & txtDetalleHaber.Text & "','" & resultadosEntrada & "',NOW(),2," & idCliente & ");")
            End If
            ActualizarTablaRegistroVenta()
            actualizarTablaConId()
            txtBuscarClientes.Focus()
        End If
    End Sub

    Private Sub btnPagarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTodo.Click
        btnEliminarTodoRegistro.Enabled = True
        btnOcultarDetalleHaber.Visible = True
        btnVerDetalleHaber.Visible = True
        txtDetalleHaber.Visible = True

        consultas.consultaReturnHide("SELECT SUM(Saldo) FROM compraCliente where idCliente=" & idCliente & ";")
        txtDineroHaber.Text = consultas.valorReturn
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
End Class