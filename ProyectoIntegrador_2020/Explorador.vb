Imports System.Runtime.InteropServices

Public Class Explorador

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Integer
    Dim activo As Byte
    Dim permitido As Byte
    Dim resultado As Byte

    '----INICIO DEL FORMULARIO----'

    Private Sub Explorador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        ActualizarTabla()
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
    End Sub

    '----CIERRE DEL FORMULARIO----'

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
        MenuPrincipal.lblTituloVentana.Text = "Menú Principal"
    End Sub


    '----MOSTRAR FORMULARIO "NUEVO" EN EL MENÚ PRINCIPAL----'

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo.lblTitulo.Text = "Nuevo Cliente"
        Nuevo.ShowDialog()
        Nuevo.txtNombreCliente.Select()
        Nuevo.txtNombreCliente.Focus()
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    '----MÉTODO PARA BUSCAR LOS CLIENTES POR NOMBRE----'

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, fechaIngreso,Telefono As Teléfono, Direccion As Dirección, estadoBool As Activo, Historial, maxPermitidoBool As p FROM clientes WHERE Nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub

    '----MUESTRA EL FORMULARIO PARA MÓDIFICAR LOS DATOS DEL CLIENTE----'

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        gpInformacion.Visible = True
    End Sub


    '----MÉTODO PARA OBTENER EL ID Y LOS DEMÁS DATOS DE LA TABLA CLIENTES Y LOS PONE EN LOS CAMPOS DEL FORMULARIO MODIFICAR CLIENTE----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        Dim row As DataGridViewRow = dgvClientes.CurrentRow

        If dgvClientes.SelectedCells.Count <> 0 Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            idCliente = dgvClientes.SelectedCells(0).Value

            txtID.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString
            txtDeuda.Text = row.Cells(2).Value.ToString
            mskFechaIngreso.Text = row.Cells(3).Value.ToString
            txtTel.Text = row.Cells(4).Value.ToString
            txtDireccion.Text = row.Cells(5).Value.ToString
            If row.Cells(6).Value.ToString.Equals("True") Then
                chbActivo.Checked = True
            Else
                chbActivo.Checked = False
            End If
            txtHistorial.Text = row.Cells(7).Value.ToString
            If row.Cells(8).Value.ToString.Equals("True") Then
                chbPermitido.Checked = True
            Else
                chbPermitido.Checked = False
            End If
        End If
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If chbActivo.Checked Then
            activo = 1
        Else
            activo = 0
        End If

        If chbPermitido.Checked Then
            permitido = 1
        Else
            permitido = 0
        End If

        consultas.consultaHide("UPDATE Clientes SET Nombre= '" & txtNombre.Text & "', Deuda=" & txtDeuda.Text & ", Historial='" & txtHistorial.Text & "', Telefono='" & txtTel.Text & "', Direccion='" & txtDireccion.Text & "', estadoBool=" & activo & ", maxPermitidoBool=" & permitido & " WHERE idCliente=" & idCliente & ";")

        If consultas.resultado = 1 Then
            gpInformacion.Visible = False
            mostrarMensaje("Base de datos actualizada.")
        End If

        ActualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        resultado = ConfirmacionMensaje.confirmacion("   ¿Seguro que desea eliminar este cliente?")
        If resultado = 1 Then
            consultas.consultaHide("DELETE FROM Clientes where idCliente=" & idCliente & ";")
            If consultas.resultado = 1 Then
                mostrarMensaje("Base de datos actualizada.")
            End If
            ActualizarTabla()

        End If
        
    End Sub

    Private Sub ActualizarTabla()
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo, fechaIngreso,Telefono As Teléfono, Direccion As Dirección, estadoBool As Activo, Historial, maxPermitidoBool As p FROM clientes;")
        dgvClientes.Columns(7).Visible = False
        dgvClientes.Columns(8).Width = 0
    End Sub

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        ActualizarTabla()
        txtBuscarClientes.Text = ""
        txtBuscarClientes.Focus()
    End Sub

    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub

    '----CIERRA EL FORMULARIO DE MODIFICAR CLIENTE.----'

    Private Sub btnCerrarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInfo.Click
        gpInformacion.Visible = False
    End Sub

    '----CAMBIA EL COLOR DE LA CELDA "SALDO"----'

    Private Sub dgvClientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvClientes.CellFormatting
        If dgvClientes.Columns(e.ColumnIndex).Name = "p" Then

            If e.Value = "False" Then
                dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex - 6).Style.ForeColor = Color.Red
                dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex - 6).Style.SelectionForeColor = Color.Red
            End If
        End If
    End Sub

    '----SI SE CAMBIA EL SALDO ACTUAL, TAMBIEN DEBERÁ CAMBIAR EL HISTORIAL PARA QUE NO HAYA CONFUSIÓN ENTRE ESTOS (ES RECOMENDABLE HACERLO)----'

    Private Sub txtDeuda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeuda.TextChanged
        If deudaActual <> Val(txtDeuda.Text) Then
            btnActualizar.Enabled = False
            txtHistorial.BackColor = Color.Coral
        End If

    End Sub

    '----OBTIENE EL SALDO ACTUAL CUANDO LE DAS CLICK AL CAMPO----'

    Dim deudaActual As Integer = 0

    Private Sub txtDeuda_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDeuda.MouseDown
        deudaActual = Val(txtDeuda.Text)
    End Sub


    '----AL MODIFICAR EL CAMPO DEL HISTORIAL; YA SE PUEDE GUARDAR LOS CAMBIOS.----'

    Private Sub txtHistorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHistorial.TextChanged
        txtHistorial.BackColor = Color.White
        btnActualizar.Enabled = True
    End Sub

    '----ADMITE SOLO NÚMEROS Y TECLA RETROCESO.----'

    Private Sub txtDeuda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeuda.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    '----AL MODIFICAR EL CAMPO DEL HISTORIAL; YA SE PUEDE GUARDAR LOS CAMBIOS.----'

    Private Sub txtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Not Char.IsWhiteSpace(e.KeyChar) And Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarClientes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            dgvClientes.Focus()
        End If
    End Sub

End Class