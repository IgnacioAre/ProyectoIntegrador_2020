Imports System.Runtime.InteropServices

Public Class Explorador

    Dim consultas As Conexion = New Conexion


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        '----MOSTRAR FORMULARIO "NUEVO" EN EL MENÚ PRINCIPAL----'
        Nuevo.lblTitulo.Text = "Nuevo Cliente"
        Nuevo.Show()
    End Sub

    Private Sub Explorador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.establecerConexion()
        dgvCientes.DataSource = consultas.mostrarBusquedaClientesEnTabla(txtBuscarClientes.Text)
        SendMessage(txtBuscarClientes.Handle, EM_SETCUEBANNER, 0, "Buscar cliente por nombre")
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub txtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarClientes.TextChanged
        dgvCientes.DataSource = consultas.mostrarBusquedaClientesEnTabla(txtBuscarClientes.Text)
    End Sub
End Class