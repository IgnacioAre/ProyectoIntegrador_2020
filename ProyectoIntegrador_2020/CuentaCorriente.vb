Imports System.Runtime.InteropServices

Public Class CuentaCorriente

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Byte
    Dim dineroResultado As Integer
    Dim deudaActual As Integer
    Dim historialActual As String
    Dim nombreCobrador As String

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
        If btnVerHistorial.Text.Equals("+ Historial") Then
            btnVerHistorial.Text = "- Historial"
            txtHistorial.Visible = True
        Else
            btnVerHistorial.Text = "+ Historial"
            txtHistorial.Visible = False
        End If

    End Sub


    '----ACTUALIZA EL SALDO DEL CLIENTE SELECCIONADO----'

    Private Sub btnActualizarDeuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDeuda.Click
        Dim fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL DEBE----'

        If gbDinero.Text.Equals("Debe") Then
            consultas.consultaReturnHide("SELECT Deuda FROM Clientes WHERE idCliente=" & idCliente & ";")
            deudaActual = Val(consultas.valorReturn)

            consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
            historialActual = consultas.valorReturn

            dineroResultado = deudaActual + Val(txtDinero.Text)

            If txtDetalle.Text.Equals("") Then
                consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "+" & txtDinero.Text & "  #" & fechaActual & "#'" & " WHERE idCliente=" & idCliente & ";")
            Else
                consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "+" & txtDinero.Text & "  *" & txtDetalle.Text & "*" & "  #" & fechaActual & "#'" & " WHERE idCliente=" & idCliente & ";")
            End If


            '----FUNCION AL PRESIONAR "GUARDAR" EN LA SECCIÓN DEL HABER----'

        Else

            consultas.consultaReturnHide("SELECT Deuda FROM Clientes WHERE idCliente=" & idCliente & ";")
            deudaActual = Val(consultas.valorReturn)

            consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
            historialActual = consultas.valorReturn

            dineroResultado = deudaActual - Val(txtDinero.Text)


            'If dineroResultado = 0 Then

            '    ConfirmacionMensaje.Show()
            '    ConfirmacionMensaje.PanelEntrada.Visible = True
            '    ConfirmacionMensaje.lblMensajeEntrada.Text = "Ingrese el nombre del cobrador:"

            '    If ConfirmacionMensaje.confirmacionResult = 1 Then
            '        nombreCobrador = ConfirmacionMensaje.lblMensajeEntrada.Text
            '        ConfirmacionMensaje.lblMensajeEntrada.Text = ""
            '        ConfirmacionMensaje.PanelEntrada.Visible = False
            '    End If

            'End If


            If txtDetalle.Text.Equals("") Then
                If dineroResultado = 0 Then
                    consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "Saldo cobrado: " & txtDinero.Text & vbCrLf & "El saldo fue cobrado por " & nombreCobrador & "  #" & fechaActual & "#'" & " WHERE idCliente=" & idCliente & ";")
                Else
                    consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "-" & txtDinero.Text & "  #" & fechaActual & "#'" & " WHERE idCliente=" & idCliente & ";")
                End If
            Else
                If dineroResultado = 0 Then
                    consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "Saldo cobrado: " & txtDinero.Text & vbCrLf & "El saldo fue cobrado por " & nombreCobrador & "  *" & txtDetalle.Text & "*" & "  #" & fechaActual & "#'" & " WHERE idCliente=" & idCliente & ";")
                Else
                    consultas.consultaHide("UPDATE Clientes SET Deuda=" & dineroResultado & ", Historial='" & historialActual & vbCrLf & "-" & txtDinero.Text & "  *" & txtDetalle.Text & "*" & "  #" & fechaActual & "#'" & " WHERE idCliente=" & idCliente & ";")
                End If
            End If





        End If

        If consultas.resultado = 1 Then
            txtDinero.Text = ""
            txtDetalle.Text = ""
            gbDinero.Visible = False
            consultas.consultaReturnHide("SELECT Nombre FROM Clientes WHERE idCliente=" & idCliente & ";")
            mostrarMensaje(consultas.valorReturn & vbCrLf & "El saldo actual es $" & dineroResultado)
            actualizarTabla()
            txtBuscarClientes.Focus()
        End If

    End Sub

    '----HACE VISIBLE LA SECCIÓN DE ACTUALIZAR SALDO----'

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        gbDinero.Text = "Debe"
        gbDinero.Visible = True
        txtDinero.Focus()
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        gbDinero.Text = "Haber"
        gbDinero.Visible = True
        txtDinero.Focus()
    End Sub

    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub


    '----OBTIENE EL ID DEL CLIENTE SELECCIONADO----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
        End If
        If idCliente >= 0 Then
            btnDebe.Enabled = True
            btnHaber.Enabled = True
            btnVerHistorial.Enabled = True
        End If
        consultas.consultaReturnHide("SELECT Historial FROM Clientes WHERE idCliente=" & idCliente & ";")
        txtHistorial.Text = consultas.valorReturn
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
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MÉTODO QUE ACTUALIZA LA TABLA----'

    Private Sub actualizarTabla()
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, maxPermitidoBool As p FROM Clientes;")
        dgvClientes.Columns(3).Width = 0
    End Sub


    '----MÉTODO QUE SOLO DEJA INGRESAR NÚMEROS Y TECLA RETROCESO----'

    Private Sub txtDinero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDinero.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
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
End Class