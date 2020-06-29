Public Class Pruebas
    Dim consultas As Conexion = New Conexion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView.DataSource = consultas.mostrarClientesEnTabla
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView.DataSource = consultas.mostrarProveedoresEnTabla
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView.DataSource = consultas.mostrarProductosEnTabla
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DataGridView.DataSource = consultas.mostrarBusquedaClientesEnTabla(TextBox1.Text)
    End Sub
End Class