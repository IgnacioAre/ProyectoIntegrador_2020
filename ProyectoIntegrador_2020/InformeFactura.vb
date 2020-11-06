﻿Public Class InformeFactura

    Private Sub InformeFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintPreviewControl1.AutoZoom = True
    End Sub

    Dim buscarInforme As buscarInforme = New buscarInforme

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim xWidth As Integer = 160
        Dim yHeight As Integer = 20

        Dim fon As New Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold)

        Dim rect As New Rectangle(170, 10, xWidth, yHeight)
        Dim strings As New StringFormat
        strings.Alignment = StringAlignment.Center
        strings.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        e.Graphics.DrawString(moduloFactura.headerSaldo, fon, Brushes.Black, rect, strings)

        Dim rect2 As New Rectangle(330, 10, xWidth, yHeight)
        Dim strings2 As New StringFormat
        strings2.Alignment = StringAlignment.Center
        strings2.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawString(moduloFactura.headerComentario, fon, Brushes.Black, rect2, strings2)


        Dim rect3 As New Rectangle(490, 10, 230, yHeight)
        Dim strings3 As New StringFormat
        strings3.Alignment = StringAlignment.Center
        strings3.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect3)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawString(moduloFactura.headerFecha, fon, Brushes.Black, rect3, strings3)

        '----------------------------------------------------------------------------------------------------------'

        Dim fon2 As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)

        Dim rek As New Rectangle(170, 30, xWidth, yHeight)
        e.Graphics.DrawRectangle(Pens.Black, rek)
        e.Graphics.DrawString(moduloFactura.valueSaldo, fon2, Brushes.Black, 230, 32)

        Dim rek2 As New Rectangle(330, 30, xWidth, yHeight)
        e.Graphics.DrawRectangle(Pens.Black, rek2)
        e.Graphics.DrawString(moduloFactura.valuesComentario, fon2, Brushes.Black, 390, 32)

        Dim rek3 As New Rectangle(490, 30, 230, yHeight)
        e.Graphics.DrawRectangle(Pens.Black, rek3)
        e.Graphics.DrawString(moduloFactura.valuesFecha, fon2, Brushes.Black, 510, 32)

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
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