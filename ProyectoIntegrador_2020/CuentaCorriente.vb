Imports System.Runtime.InteropServices

Public Class CuentaCorriente

    Dim consultas As Conexion = New Conexion
    Dim idCliente As Byte

    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscarClientes.Focus()
        btnDebe.Enabled = False
        btnHaber.Enabled = False
        btnVerHistorial.Enabled = False
        consultas.establecerConexion()
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo FROM Clientes;")
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

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvClientes.DataSource = consultas.mostrarClientesEnTabla("SELECT idCliente As ID, Nombre, Deuda As Saldo FROM Clientes WHERE nombre LIKE '%" & txtBuscarClientes.Text & "%';")
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
    End Sub


    Private Sub btnVerHistorial_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnVerHistorial.LinkClicked
        If btnVerHistorial.Text.Equals("+ Historial") Then
            btnVerHistorial.Text = "- Historial"
            txtHistorial.Visible = True
        Else
            btnVerHistorial.Text = "+ Historial"
            txtHistorial.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gbDinero.Visible = False
    End Sub

    Private Sub btnDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebe.Click
        gbDinero.Text = "Debe"
        gbDinero.Visible = True
    End Sub

    Private Sub btnHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaber.Click
        gbDinero.Text = "Haber"
        gbDinero.Visible = True
    End Sub

    Private Sub dgvClientes_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvClientes.MouseDown
        If dgvClientes.SelectedCells.Count <> 0 Then
            idCliente = dgvClientes.SelectedCells(0).Value
        End If
        If idCliente >= 0 Then
            btnDebe.Enabled = True
            btnHaber.Enabled = True
            btnVerHistorial.Enabled = True
        End If
        consultas.consultaReturnHide("SELECT Historial FROM Clientes where idCliente=" & idCliente & ";")
        txtHistorial.Text = consultas.resultadoTxt
    End Sub

    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub

End Class