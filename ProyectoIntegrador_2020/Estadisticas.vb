Public Class Estadisticas

    Dim consulta As Conexion = New Conexion()

    Private Sub Estadisticas_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ActualizarGrafica()
        rbColumnas.Checked = True
        barVertical.Value = chartGrafica.ChartAreas(0).Area3DStyle.Inclination
        barHorizontal.Value = chartGrafica.ChartAreas(0).Area3DStyle.Rotation
    End Sub


    Sub ActualizarGrafica()
        Dim ds As DataSet

        Dim mesAnterior As Integer
        consulta.consultaReturnHide("SELECT MONTH(NOW()) as Mes;")
        mesAnterior = Val(consulta.valorReturn) - 1

        consulta.consultaReturnHide("SELECT CONCAT_WS('/',day(now()),month(NOW()) - 1,year(now()));")
        Dim mesAnteriorTxt As String = consulta.valorReturn
        consulta.consultaReturnHide("SELECT CONCAT_WS('/',day(now()),month(NOW()),year(now()));")
        Dim mesActualTxt As String = consulta.valorReturn

        lblEstadisticasMes.Text = "Estadísticas desde el mes " & mesAnteriorTxt & " al " & mesActualTxt

        'RESOLVER CONSULTA POR FECHA Y HACER JOIN CON NOMBRE DE CLIENTE
        ds = consulta.consultarGrafica("SELECT Nombre, cc.saldo as Saldo from compraCliente as cc,Clientes as c where cc.saldo > 0 and cc.idCliente = c.idCliente AND MONTH(fechaCompra) BETWEEN " & mesAnterior & " AND (Select MONTH(NOW())) group by cc.idCliente order by(SUM(cc.saldo)) desc limit 15;")

        chartGrafica.Size = New Size(600, 200)
        chartGrafica.Series.Clear()

        chartGrafica.Series.Add("Clientes")
        chartGrafica.Series("Clientes").XValueMember = "Nombre"
        chartGrafica.Series("Clientes").YValueMembers = "Saldo"

        chartGrafica.DataSource = ds
    End Sub


    Private Sub barVertical_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barVertical.Scroll
        chartGrafica.ChartAreas(0).Area3DStyle.Inclination = barVertical.Value
    End Sub

    Private Sub barHorizontal_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barHorizontal.Scroll
        chartGrafica.ChartAreas(0).Area3DStyle.Rotation = barHorizontal.Value
    End Sub

    Private Sub rbBarras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBarras.CheckedChanged
        chartGrafica.Series("Clientes").ChartType = DataVisualization.Charting.SeriesChartType.Bar
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbColumnas.CheckedChanged
        chartGrafica.Series("Clientes").ChartType = DataVisualization.Charting.SeriesChartType.Column
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCircular.CheckedChanged
        chartGrafica.Series("Clientes").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
    End Sub

End Class