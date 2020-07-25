Public Class Clientes
    Dim consultas As Conexion = New Conexion


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        dgvCientes.DataSource = consultas.mostrarBusquedaClientesEnTabla(TextBox1.Text)
    End Sub

    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvCientes.DataSource = consultas.mostrarClientesEnTabla
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        MenuPrincipal.formularioBool = False
        Me.Close()
    End Sub

End Class