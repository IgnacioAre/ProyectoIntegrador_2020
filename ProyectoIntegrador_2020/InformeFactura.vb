Public Class InformeFactura

    Private Sub InformeFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintPreviewControl1.AutoZoom = True
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Posicion de inicio de cada rectángulo
        Dim xPosicionSaldo As Integer = 20
        Dim xPosicionComentario As Integer = 180
        Dim xPosicionFecha As Integer = 600

        'Tamaño del ancho en cada rectángulo
        Dim xSaldo As Integer = 160
        Dim xComentario As Integer = 420
        Dim xFecha As Integer = 230
        'Tamaño del alto en cada rectángulo
        Dim yHeight As Integer = 20

        'Posicion de inicio del nombre del cliente.
        Dim yPosicionHead As Integer = 120


        '--------------------------HEADER--------------------------'


        Dim fon As New Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold)
        Dim strings As New StringFormat
        strings.Alignment = StringAlignment.Center
        strings.LineAlignment = StringAlignment.Center

        Dim rect As New Rectangle(xPosicionSaldo, yPosicionHead, xSaldo, yHeight)
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        e.Graphics.DrawString(moduloAuxiliar.headerSaldo, fon, Brushes.Black, rect, strings)

        Dim rect2 As New Rectangle(xPosicionComentario, yPosicionHead, xComentario, yHeight)
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawString(moduloAuxiliar.headerComentario, fon, Brushes.Black, rect2, strings)


        Dim rect3 As New Rectangle(xPosicionFecha, yPosicionHead, xFecha, yHeight)
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect3)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawString(moduloAuxiliar.headerFecha, fon, Brushes.Black, rect3, strings)


        '--------------------------Nombre cliente--------------------------'

        Dim fon2 As New Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold)
        Dim strings2 As New StringFormat
        strings2.Alignment = StringAlignment.Center
        strings2.LineAlignment = StringAlignment.Center

        Dim nombreRec As New Rectangle(300, 60, 300, 40)
        e.Graphics.FillRectangle(Brushes.White, nombreRec)
        e.Graphics.DrawRectangle(Pens.White, nombreRec)
        e.Graphics.DrawString(moduloAuxiliar.nombreCliente, fon2, Brushes.Black, nombreRec, strings2)

        '--------------------------VALORES--------------------------'

        Dim fon3 As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
        Dim strings3 As New StringFormat
        strings3.Alignment = StringAlignment.Center
        strings3.LineAlignment = StringAlignment.Center

        Dim yGeneral As Integer = 140

        Dim i As Integer = 1

        For Each item As valoresFactura In moduloAuxiliar.nuevoValor
            Dim rek1 As New Rectangle(xPosicionSaldo, yGeneral, xSaldo, yHeight)
            e.Graphics.DrawRectangle(Pens.Black, rek1)
            e.Graphics.DrawString(item.FuncionValueSaldo, fon3, Brushes.Black, rek1, strings3)

            Dim rek2 As New Rectangle(xPosicionComentario, yGeneral, xComentario, yHeight)
            e.Graphics.DrawRectangle(Pens.Black, rek2)
            e.Graphics.DrawString(item.FuncionValueComentario, fon3, Brushes.Black, rek2, strings3)

            Dim rek3 As New Rectangle(xPosicionFecha, yGeneral, xFecha, yHeight)
            e.Graphics.DrawRectangle(Pens.Black, rek3)
            e.Graphics.DrawString(item.FuncionValueFecha, fon3, Brushes.Black, rek3, strings3)

            yGeneral += 20
        Next

    End Sub



    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        moduloAuxiliar.nuevoValor.Clear()
        Me.Close()
    End Sub

    Private Sub btnZoomMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomMenos.Click
        PrintPreviewControl1.AutoZoom = True
    End Sub

    Private Sub btnZoomMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomMas.Click
        PrintPreviewControl1.Zoom = 1.2
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintDocument1.Print()
    End Sub

End Class