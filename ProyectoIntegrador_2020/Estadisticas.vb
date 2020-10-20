Public Class Estadisticas

    Dim consulta As Conexion = New Conexion()

    Private Sub Estadisticas_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ActualizarGrafica()
    End Sub


    Sub ActualizarGrafica()
        Dim ds As DataSet

        'RESOLVER CONSULTA POR FECHA Y HACER JOIN CON NOMBRE DE CLIENTE
        ds = consulta.consultarGrafica("SELECT count(idCliente) as Cliente, SUM(saldo) from compraCliente group by idCliente limit 15;")

        chatGrafica.Size = New Size(600, 200)
        chatGrafica.Series("Series1").XValueMember = "Cliente"
        chatGrafica.Series("Series1").YValueMembers = "saldo"

        chatGrafica.DataSource = ds
    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        chatGrafica.ChartAreas(0).Area3DStyle.Rotation = chatGrafica.ChartAreas(0).Area3DStyle.Rotation + 20
    End Sub
End Class