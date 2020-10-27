Imports System.Runtime.InteropServices

Public Class ExploradorProveedores

    Dim consultas As Conexion = New Conexion
    Dim idProveedor As Integer
    Dim resultado As Byte
    Dim resultadosTxt As String
    Dim idCompra As String
    Dim saldoActual As Integer
    Dim registroSaldo As Integer

    '----INICIO DEL FORMULARIO----'

    Private Sub Explorador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        panelEditarRegistro.Width = 0
        ActualizarTabla()
        SendMessage(txtBuscarNombreProv.Handle, EM_SETCUEBANNER, 0, "Buscar proveedor por nombre")
        SendMessage(txtBuscarCodigoProv.Handle, EM_SETCUEBANNER, 0, "Buscar proveedor por código")
    End Sub



    '----MOSTRAR FORMULARIO "NUEVO" EN EL MENÚ PRINCIPAL----'

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo.lblTitulo.Text = "Nuevo Proveedor"
        Nuevo.ShowDialog()
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    '----MUESTRA EL FORMULARIO PARA MÓDIFICAR LOS DATOS DEL CLIENTE----'

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        gpInformacion.Visible = True
        ActualizarTablaRegistroVentas()
        ActualizarTablaTelefono()
    End Sub


    '----MÉTODO PARA OBTENER EL ID Y LOS DEMÁS DATOS DE LA TABLA CLIENTES Y LOS PONE EN LOS CAMPOS DEL FORMULARIO MODIFICAR CLIENTE----'

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProveedores.SelectionChanged
        ActualizarInformacionProveedor()
    End Sub


    Sub ActualizarInformacionProveedor()
        Dim row As DataGridViewRow = dgvProveedores.CurrentRow

        If dgvProveedores.SelectedCells.Count <> 0 Then
            btnModificar.Enabled = True
            btnNoActivo.Enabled = True
            btnActivo.Enabled = True

            If panelEditarRegistro.Width >= 349 Then
                tmrOcultarEditarRegistro.Enabled = True
            End If

            idProveedor = dgvProveedores.SelectedCells(0).Value

            txtID.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString
            txtDeuda.Text = row.Cells(2).Value.ToString
            mskFechaIngreso.Text = row.Cells(3).Value.ToString

            txtDireccion.Text = row.Cells(4).Value.ToString
            
        End If

        ActualizarTablaRegistroVentas()
        ActualizarTablaTelefono()
    End Sub



    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        consultas.consultaHide("UPDATE Proveedores SET Nombre= '" & txtNombre.Text.ToUpper & "', Direccion='" & txtDireccion.Text.ToUpper & "' WHERE idProveedor=" & idProveedor & ";")

        If consultas.resultado = 1 Then
            gpInformacion.Visible = False
        End If

        ActualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoActivo.Click
        resultado = ConfirmacionMensaje.confirmacion("   ¿Seguro que desea quitar este proveedor?")
        If resultado = 1 Then
            consultas.consultaHide("UPDATE Proveedores set estadoBool=0 where idProveedor=" & idProveedor & ";")

            ActualizarTabla()

        End If

    End Sub

    Public Sub ActualizarTabla()
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo FROM Proveedores where estadoBool=1 order by(nombre);")
        dgvProveedores.Columns(5).Visible = False
    End Sub



    Public Sub actualizarTablaConId()
        Dim idTemp As Integer = idProveedor
        ActualizarTabla()

        'SELECCIONA EN LA TABLA AL PROVEEDOR EN idTemp
        For i As Integer = 0 To dgvProveedores.Rows.Count - 1
            If dgvProveedores.Rows(i).Cells(0).Value = idTemp Then

                dgvProveedores.CurrentCell = dgvProveedores.Item(0, i)

                dgvProveedores.Rows(i).Selected = True
                Exit For
            End If
        Next

        ActualizarInformacionProveedor()
    End Sub


    Sub ActualizarTablaTelefono()
        dgvTelefono.DataSource = consultas.mostrarEnTabla("SELECT idTelefono,numeroTel As Número FROM telefonoProveedor as tp,Proveedores as p WHERE tp.idProveedor = p.idProveedor and p.idProveedor=" & txtID.Text & ";")

        dgvTelefono.Columns(0).Visible = False

    End Sub


    Public Sub ActualizarTablaRegistroVentas()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT idVenta,vp.Saldo,Detalle,fechaVenta As Fecha FROM ventaProveedor as vp,Proveedores as p WHERE vp.idProveedor = p.idProveedor AND adeudoBool=1 AND p.idProveedor=" & idProveedor & " order by(idVenta) desc;")

        dgvRegistroVentas.Columns(0).Visible = False

    End Sub




    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ActualizarTabla()
        chkNoActivos.Checked = False
        txtBuscarNombreProv.Text = ""
        txtBuscarCodigoProv.Text = ""
        txtBuscarNombreProv.Focus()
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

    Private Sub dgvClientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProveedores.CellFormatting
        If dgvProveedores.Columns(e.ColumnIndex).Name = "p" Then

            If e.Value = "False" Then
                dgvProveedores.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Style.ForeColor = Color.Red
                dgvProveedores.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Style.SelectionForeColor = Color.Red
            End If
        End If
    End Sub


    '----ADMITE SOLO NÚMEROS Y TECLA RETROCESO.----'

    Private Sub txtDeuda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeuda.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    '----AL MODIFICAR EL CAMPO DEL HISTORIAL; YA SE PUEDE GUARDAR LOS CAMBIOS.----'

    Private Sub txtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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


    Private Sub btnAgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTel.Click
        resultadosTxt = ConfirmacionMensaje.entradaDatos("Nuevo número telfónico:")

        consultas.consultaHide("INSERT INTO telefonoProveedor (numeroTel, idProveedor) VALUES ('" & resultadosTxt & "'," & idProveedor & ");")
        ActualizarTablaTelefono()
    End Sub


    Private Sub btnEliminarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarTel.Click
        Dim idTel As String
        idTel = dgvTelefono.CurrentRow.Cells(0).Value.ToString

        consultas.consultaHide("DELETE FROM telefonoCliente where idTelefono=" & idTel & ";")
        ActualizarTablaTelefono()
    End Sub


    Private Sub btnEliminarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        resultado = ConfirmacionMensaje.confirmacion("   ¿Seguro que desea eliminar este registro?")
        If resultado = 1 Then

            idCompra = dgvRegistroVentas.CurrentRow.Cells(0).Value.ToString

            consultas.consultaHide("UPDATE FROM compraCliente set adeudoBool=0 where idCompra=" & idCompra & ";")
            ActualizarTablaRegistroVentas()

            actualizarTablaConId()
        End If

    End Sub

    Private Sub btnEditarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarTel.Click

        Dim idTel As String
        Dim num As String
        idTel = dgvTelefono.CurrentRow.Cells(0).Value.ToString
        num = dgvTelefono.CurrentRow.Cells(1).Value.ToString

        ConfirmacionMensaje.txtEntrada.Text = num
        resultadosTxt = ConfirmacionMensaje.entradaDatos("Modificar número telfónico:")

        If ConfirmacionMensaje.resultado = 1 Then
            consultas.consultaHide("UPDATE telefonoCliente set numeroTel='" & resultadosTxt & "' where idTelefono=" & idTel & ";")
            ActualizarTablaTelefono()
        End If

    End Sub

    Private Sub btnEditarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarRegistro.Click
        If dgvRegistroVentas.SelectedCells.Count <> 0 Then
            btnEditarRegistro.Enabled = True
            idCompra = dgvRegistroVentas.CurrentRow.Cells(0).Value.ToString
            txtSaldoRegistro.Text = dgvRegistroVentas.CurrentRow.Cells(1).Value.ToString
            txtDetalleRegistro.Text = dgvRegistroVentas.CurrentRow.Cells(2).Value.ToString

            restadorSaldoExplorador()

            tmrMostrarEditarRegistro.Enabled = True
        Else
            btnEditarRegistro.Enabled = False
        End If
    End Sub


    Private Sub tmrMostrarEditarRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarEditarRegistro.Tick
        If panelEditarRegistro.Width <= 0 Then
            tmrOcultarEditarRegistro.Enabled = False
        Else
            panelEditarRegistro.Width = panelEditarRegistro.Width - 10

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        tmrOcultarEditarRegistro.Enabled = True
    End Sub


    Sub restadorSaldoExplorador()

        'ACTUALIZO LA DEUDA EN EL PROVEEDOR

        consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
        saldoActual = Val(consultas.valorReturn)
        registroSaldo = Val(txtSaldoRegistro.Text)
    End Sub


    Sub sumarSaldoExplorador()
        'ACTUALIZO LA DEUDA EN EL PROVEEDOR
        consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual - registroSaldo) & " where idProveedor=" & idProveedor & ";")

        consultas.consultaReturnHide("SELECT Saldo from Proveedores where idProveedor=" & idProveedor & ";")
        saldoActual = Val(consultas.valorReturn)

        consultas.consultaHide("UPDATE Proveedores set Saldo=" & (saldoActual + Val(txtSaldoRegistro.Text)) & " where idProveedor=" & idProveedor & ";")

    End Sub



    Private Sub tmrMostrarEditarRegistro_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarEditarRegistro.Tick
        If panelEditarRegistro.Width >= 349 Then
            tmrMostrarEditarRegistro.Enabled = False
        Else
            panelEditarRegistro.Width = panelEditarRegistro.Width + 10
        End If
    End Sub

    Private Sub btnGuardarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRegistro.Click
        modificarRegistro()
    End Sub



    Sub modificarRegistro()
        If Not txtSaldoRegistro.Text.Equals("") And Not txtSaldoRegistro.Text.Equals("0") Then
            consultas.consultaHide("UPDATE ventaProveedor set saldo = " & txtSaldoRegistro.Text & ", detalle = '" & txtDetalleRegistro.Text & "' where idVenta=" & idCompra & ";")

            sumarSaldoExplorador()

            actualizarTablaConId()
            tmrOcultarEditarRegistro.Enabled = True
        Else
            mostrarMensaje("El saldo debe ser mayor a $0")
        End If
    End Sub


    Private Sub chkNoActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoActivos.CheckedChanged
        If chkNoActivos.Checked Then
            dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo FROM Proveedores where estadoBool=0 order by(nombre);")
            dgvProveedores.Columns(5).Visible = False

            btnNoActivo.Visible = False
            btnActivo.Visible = True
        Else
            ActualizarTabla()
            btnNoActivo.Visible = True
            btnActivo.Visible = False
        End If
    End Sub

    Private Sub pbActualizarTabla_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        ActualizarTabla()
        chkNoActivos.Checked = False
        txtBuscarNombreProv.Text = ""
        txtBuscarCodigoProv.Text = ""
        txtBuscarNombreProv.Focus()
    End Sub

    Private Sub txtSaldoRegistro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoRegistro.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                modificarRegistro()
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivo.Click
        consultas.consultaHide("UPDATE Proveedores set estadoBool=1 where idProveedor=" & idProveedor & ";")
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo FROM Proveedores where estadoBool=0 order by(nombre);")
        dgvProveedores.Columns(5).Visible = False
    End Sub

    Private Sub dgvTelefono_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvTelefono.SelectionChanged
        Dim row As DataGridViewRow = dgvTelefono.CurrentRow

        If dgvTelefono.SelectedCells.Count <> 0 Then
            btnEliminarTel.Enabled = True
            btnEditarTel.Enabled = True
        Else
            btnEliminarTel.Enabled = False
            btnEditarTel.Enabled = False
        End If
    End Sub

    Private Sub txtBuscarProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNombreProv.TextChanged
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo FROM Proveedores where estadoBool=1 And Nombre LIKE '%" & txtBuscarNombreProv.Text & "%';")
        dgvProveedores.Columns(5).Visible = False

    End Sub

    Private Sub txtBuscarCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigoProv.TextChanged
        dgvProveedores.DataSource = consultas.mostrarEnTabla("SELECT idProveedor As ID, Nombre,Saldo As Saldo, fechaIngreso As Ingreso, Direccion As Dirección, estadoBool As Activo FROM Proveedores where estadoBool=1 And Nombre LIKE '%" & txtBuscarCodigoProv.Text & "%';")
        dgvProveedores.Columns(5).Visible = False

    End Sub

    Private Sub txtBuscarCodigoProv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarCodigoProv.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                dgvProveedores.Focus()
            End If
        End If
    End Sub

    Private Sub txtBuscarNombreProv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNombreProv.KeyPress
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

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ActualizarTabla()
        If txtBuscarNombreProv.Visible Then
            txtBuscarCodigoProv.Visible = True
            txtBuscarNombreProv.Visible = False
        Else
            txtBuscarNombreProv.Visible = True
            txtBuscarCodigoProv.Visible = False
        End If
    End Sub
End Class