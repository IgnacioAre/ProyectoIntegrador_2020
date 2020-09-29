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

        consultas.consultaReturnHide("SELECT SUM(saldo) FROM compraCliente as cc,Clientes as c where c.idCliente = cc.idCliente and c.idCliente=" & idCliente & ";")
        Dim Total As Integer = consultas.valorReturn

        If Not txtDinero.Text.Equals("") And Not txtDinero.Text.Equals("0") Then

            '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL DEBE----'

            If gbDinero.Text.Equals("Debe") Then

                If txtDetalle.Text.Equals("") Then
                    consultas.consultaHide("INSERT INTO compraCliente(Saldo,fechaCompra,adeudoBool,idCliente) Values(" & txtDinero.Text & ",now(),1," & idCliente & ");")
                Else
                    consultas.consultaHide("INSERT INTO compraCliente(Saldo,Detalle,fechaCompra,adeudoBool,idCliente) Values(" & txtDinero.Text & ",'" & txtDetalle.Text & "'" & ",now(),1," & idCliente & ");")
                End If

                actualizarTablaConId()
                ActualizarTablaRegistroCompra()


                '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL HABER----'

            Else


                Do
                    If txtDinero.Text.Equals(Total) Then
                        ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                        ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                        mostrarMensajeInput("Ingrese el nombre del cobrador:")
                    End If
                Loop While resultadosEntrada = ""



                If txtDetalle.Text.Equals("") Then
                    If txtDinero.Text.Equals(Total) Then
                        If confirmacion = 1 Then
                            nombreCobrador = resultadosEntrada
                            consultas.consultaHide("INSERT compraCliente ()")
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

                If txtDinero.Text.Equals(total) Then
                    resetGBDinero()
                    consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
                    mostrarMensaje(consultas.valorReturn & vbCrLf & "El saldo actual es $" & dineroResultado)
                    actualizarTablaConId()
                    txtBuscarClientes.Focus()
                Else
                    resetGBDinero()
                    consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
                    mostrarMensaje(consultas.valorReturn & vbCrLf & "Cuenta saldada exitosamente.")
                    consultas.consultaHide("UPDATE Clientes SET maxPermitidoBool= 1 WHERE idCliente=" & idCliente & ";")
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

        ActualizarTablaRegistroCompra()
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
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT c.idCliente As ID, Nombre, SUM(Saldo) As Saldo, maxPermitidoBool As p FROM Clientes As c,compraCliente As cc WHERE c.idCliente = cc.idCliente group by(cc.idCliente);")
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



    Sub ActualizarTablaRegistroCompra()
        dgvRegistroCompras.DataSource = consultas.mostrarEnTabla("SELECT Saldo,Detalle,fechaCompra As Fecha FROM compraCliente,Clientes WHERE compraCliente.idCliente = Clientes.idCliente AND adeudoBool=1 AND Clientes.idCliente=" & idCliente & ";")
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
    End Sub

    Private Sub mostrarMensajeInput(ByVal mensaje As String)
        resultadosEntrada = ConfirmacionMensaje.entradaDatos(mensaje)
        confirmacion = ConfirmacionMensaje.confirmacionResult
    End Sub

    Private Sub btnCerrarGBDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        resetGBDinero()
    End Sub

    Private Sub resetGBDinero()
        gbDinero.Visible = False
        txtDinero.Text = ""
        txtDetalle.Text = ""
        txtDetalle.Visible = False
    End Sub

    Private Sub btnPagarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTotal.Click
        consultas.consultaReturnHide("SELECT SUM(saldo) FROM compraCliente as cc,Clientes as c where c.idCliente = cc.idCliente and c.idCliente=" & idCliente & ";")
        txtDinero.Text = consultas.valorReturn
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


    Private Sub btnVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalle.Click
        txtDetalle.Visible = True
        txtDetalle.Text = ""
        btnVerDetalle.Visible = False
        btnOcultarDetalle.Visible = True
        txtDetalle.Focus()
    End Sub

    Private Sub btnOcultarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarDetalle.Click
        txtDetalle.Visible = False
        txtDetalle.Text = ""
        btnVerDetalle.Visible = True
        btnOcultarDetalle.Visible = False
    End Sub

    Private Sub txtDetalle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalle.KeyPress

    End Sub

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        resetGBDinero()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub
End Class