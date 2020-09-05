Imports System.Runtime.InteropServices

Public Class CuentaCorriente

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Byte
    Dim dineroResultado As Integer
    Dim deudaActual As Integer
    Dim historialActual As String
    Dim nombreCobrador As String
    Dim resultadosEntrada As String
    Dim confirmacion As Byte


    '----INICIO DEL FORMULARIO----'

    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscarClientes.Focus()
        btnDebe.Enabled = False
        btnHaber.Enabled = False
        btnVerHistorial.Enabled = False
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
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, maxPermitidoBool As p FROM Clientes WHERE nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub

    '----PERMITE VER O ESCONDER EL HISTORIAL DEL CLIENTE SELECCIONADO----'

    Private Sub btnVerHistorial_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnVerHistorial.LinkClicked
        resetHistorial()
    End Sub

    Private Sub resetHistorial()
        If btnVerHistorial.Text.Equals("+ Historial") Then
            btnVerHistorial.Text = "- Historial"
            txtHistorial.Visible = True
        Else
            btnVerHistorial.Text = "+ Historial"
            txtHistorial.Visible = False
        End If

        txtHistorial.SelectionStart = txtHistorial.TextLength
        txtHistorial.ScrollToCaret()
    End Sub


    Private Sub btnActualizarDeuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDeuda.Click
        actualizarDeuda()
    End Sub


    '----ACTUALIZA EL SALDO DEL CLIENTE SELECCIONADO----'

    Private Sub actualizarDeuda()
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        If Not txtDinero.Text.Equals("") And Not txtDinero.Text.Equals("0") Then
            '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL DEBE----'

            If gbDinero.Text.Equals("Debe") Then
                consultas.consultaReturnHide("SELECT Deuda FROM Clientes WHERE idCliente=" & idCliente & ";")
                deudaActual = Val(consultas.valorReturn)

                consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
                historialActual = consultas.valorReturn

                dineroResultado = deudaActual + Val(txtDinero.Text)

                If txtDetalle.Text.Equals("") Then
                    consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "+" & txtDinero.Text & "  Fecha: " & fechaActual & "'" & " WHERE idCliente=" & idCliente & ";")
                Else
                    consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "+" & txtDinero.Text & "   """ & txtDetalle.Text & """" & "  Fecha: " & fechaActual & "'" & " WHERE idCliente=" & idCliente & ";")
                End If


                '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL HABER----'

            Else

                consultas.consultaReturnHide("SELECT Deuda FROM Clientes WHERE idCliente=" & idCliente & ";")
                deudaActual = Val(consultas.valorReturn)

                consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
                historialActual = consultas.valorReturn

                dineroResultado = deudaActual - Val(txtDinero.Text)

                If dineroResultado = 0 Then
                    ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                    ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                    mostrarMensajeInput("Ingrese el nombre del cobrador:")
                End If

                If txtDetalle.Text.Equals("") Then
                    If dineroResultado = 0 Then
                        If confirmacion = 1 Then
                            nombreCobrador = resultadosEntrada
                            consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "Saldo cobrado: $" & txtDinero.Text & vbCrLf & "El saldo fue cobrado por " & nombreCobrador & "  Fecha: " & fechaActual & "'" & " WHERE idCliente=" & idCliente & ";")
                        Else
                            mostrarMensaje("Se canceló el cobro.")
                            consultas.resultado = 2
                        End If
                    Else
                        consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "-" & txtDinero.Text & "  Fecha: " & fechaActual & "'" & " WHERE idCliente=" & idCliente & ";")
                    End If
                Else
                    If dineroResultado = 0 Then
                        If confirmacion = 1 Then
                            nombreCobrador = resultadosEntrada(1)
                            consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "Saldo cobrado: $" & txtDinero.Text & vbCrLf & "El saldo fue cobrado por " & nombreCobrador & "   """ & txtDetalle.Text & """" & "  Fecha: " & fechaActual & "'" & " WHERE idCliente=" & idCliente & ";")
                        Else
                            mostrarMensaje("Se canceló el cobro.")
                            consultas.resultado = 2
                        End If
                    Else
                        consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "-" & txtDinero.Text & "   """ & txtDetalle.Text & """" & "  Fecha: " & fechaActual & "'" & " WHERE idCliente=" & idCliente & ";")
                    End If
                End If


            End If

            If consultas.resultado = 1 Then
                If dineroResultado <> 0 Then
                    resetGBDinero()
                    consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
                    mostrarMensaje(consultas.valorReturn & vbCrLf & "El saldo actual es $" & dineroResultado)
                    actualizarTablaConId()
                    txtBuscarClientes.Focus()
                Else
                    resetGBDinero()
                    consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
                    mostrarMensaje(consultas.valorReturn & vbCrLf & "Cuenta saldada exitosamente.")
                    actualizarTablaConId()
                    txtBuscarClientes.Focus()
                End If
            End If

        Else
            mostrarMensaje("Error. Verifique el dinero ingresado.")
        End If

    End Sub

    '----HACE VISIBLE LA SECCIÓN DE ACTUALIZAR SALDO----'

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        resetGBDinero()
        gbDinero.Text = "Debe"
        gbDinero.Visible = True
        btnPagarTotal.Visible = False
        txtDinero.Focus()
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        resetGBDinero()
        gbDinero.Text = "Haber"
        gbDinero.Visible = True
        btnPagarTotal.Visible = True
        txtDinero.Focus()
    End Sub


    '----OBTIENE EL ID DEL CLIENTE SELECCIONADO----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        resetGBDinero()
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
        End If

        btnDebe.Enabled = True
        btnHaber.Enabled = True
        btnVerHistorial.Enabled = True

        consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
        txtHistorial.Text = consultas.valorReturn
        txtHistorial.SelectionStart = txtHistorial.TextLength
        txtHistorial.ScrollToCaret()
    End Sub


    '----MUESTRA O ESCONDE CAMPO DE AGREGAR DETALLE----'

    Private Sub btnAgregarDetalle_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnAgregarDetalle.LinkClicked
        If btnAgregarDetalle.Text.Equals("+ Detalle") Then
            btnAgregarDetalle.Text = "- Detalle"
            txtDetalle.Visible = True
            txtDetalle.Focus()
        Else
            btnAgregarDetalle.Text = "+ Detalle"
            txtDetalle.Visible = False
        End If
    End Sub

    '----ACTUAIZA LA TABLA AL DARLE CLICK AL BOTON----'

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        actualizarTabla()
        resetGBDinero()
        resetHistorial()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MÉTODO QUE ACTUALIZA LA TABLA----'

    Private Sub actualizarTabla()
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, maxPermitidoBool As p FROM Clientes;")
        dgvClientes.Columns(3).Width = 0
    End Sub

    Private Sub actualizarTablaConId()
        Dim idTemp As Integer = idCliente

        consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
        txtHistorial.Text = consultas.valorReturn

        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, maxPermitidoBool As p FROM Clientes;")
        dgvClientes.Columns(3).Width = 0
        'SELECCIONA EN LA TABLA AL CLIENTE EN idTemp
        For i As Integer = 0 To dgvClientes.Rows.Count - 1
            If dgvClientes.Rows(i).Cells(0).Value = idTemp Then

                dgvClientes.CurrentCell = dgvClientes.Item(0, i)

                dgvClientes.Rows(i).Selected = True
                Exit For
            End If
        Next

    End Sub


    '----MÉTODO QUE SOLO DEJA INGRESAR NÚMEROS Y TECLA RETROCESO----'

    Private Sub txtDinero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDinero.KeyPress
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
        mensaje.ShowDialog()
    End Sub

    Private Sub mostrarMensajeInput(ByVal mensaje As String)
        resultadosEntrada = ConfirmacionMensaje.entradaDatos(mensaje)
        confirmacion = ConfirmacionMensaje.confirmacionResult
    End Sub

    Private Sub btnCerrarGBDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarGBDinero.Click
        resetGBDinero()
    End Sub

    Private Sub resetGBDinero()
        gbDinero.Visible = False
        txtDinero.Text = ""
        txtDetalle.Text = ""
        If btnAgregarDetalle.Text.Equals("- Detalle") Then
            btnAgregarDetalle.Text = "+ Detalle"
            txtDetalle.Visible = False
        End If
    End Sub

    Private Sub btnPagarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTotal.Click
        consultas.consultaReturnHide("SELECT deuda FROM Clientes where idCliente=" & idCliente & ";")
        txtDinero.Text = consultas.valorReturn
    End Sub

End Class