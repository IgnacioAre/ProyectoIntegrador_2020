Imports System.Drawing.Printing

Public Class InformeFactura

    Private Sub InformeFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintPreviewControl1.AutoZoom = True
    End Sub


    'Posicion de inicio de cada rectángulo
    Dim xPosicionSaldo As Integer = 20
    Dim xPosicionComentario As Integer = 180
    Dim xPosicionFecha As Integer = 600
    Dim yPosicionHead As Integer = 120

    'Tamaño del ancho en cada rectángulo
    Dim xSaldo As Integer = 160
    Dim xComentario As Integer = 420
    Dim xFecha As Integer = 230
    'Tamaño del alto en cada rectángulo
    Dim yHeight As Integer = 20
    Dim yGeneral As Integer = 140


    Dim filaActual As Integer = 0
    Dim filasPorPagina = 45
    Dim calculo As Integer = 0
    Dim cantPaginas As Integer = 1
    Dim cantFilas As Integer = moduloAuxiliar.cantidadFilas
    Dim paginaActual As Integer = 1


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


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


        '--------------------------Cabecera--------------------------'

        Dim strings2 As New StringFormat
        strings2.Alignment = StringAlignment.Center
        strings2.LineAlignment = StringAlignment.Center

        Dim fon4 As New Font(FontFamily.GenericSansSerif, 15, FontStyle.Underline)
        Dim subtituloCliente As New Rectangle(10, 10, 200, 30)
        e.Graphics.FillRectangle(Brushes.White, subtituloCliente)
        e.Graphics.DrawRectangle(Pens.White, subtituloCliente)
        e.Graphics.DrawString("Nombre del cliente:", fon4, Brushes.Black, subtituloCliente, strings2)

        Dim fon5 As New Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold)
        Dim nombreCliente As New Rectangle(10, 60, 400, 40)
        e.Graphics.FillRectangle(Brushes.White, nombreCliente)
        e.Graphics.DrawRectangle(Pens.White, nombreCliente)
        e.Graphics.DrawString(moduloAuxiliar.nombreCliente, fon5, Brushes.Black, nombreCliente, strings2)

        Dim subtituloComercio As New Rectangle(530, 10, 250, 30)
        e.Graphics.FillRectangle(Brushes.White, subtituloComercio)
        e.Graphics.DrawRectangle(Pens.White, subtituloComercio)
        e.Graphics.DrawString("Nombre del comercio:", fon4, Brushes.Black, subtituloComercio, strings2)

        Dim fon2 As New Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold)
        Dim nombreComercio As New Rectangle(600, 60, 250, 40)
        e.Graphics.FillRectangle(Brushes.White, nombreComercio)
        e.Graphics.DrawRectangle(Pens.White, nombreComercio)
        e.Graphics.DrawString("EL COFRE", fon2, Brushes.Black, nombreComercio, strings2)

        '--------------------------VALORES--------------------------'

        Dim fon3 As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
        Dim strings3 As New StringFormat
        strings3.Alignment = StringAlignment.Center
        strings3.LineAlignment = StringAlignment.Center


        If moduloAuxiliar.cantidadFilas > 45 Then
            cantPaginas = Math.Ceiling(moduloAuxiliar.cantidadFilas / filasPorPagina)
        End If

        Try
            If cantPaginas = 1 Then
                For i As Integer = 0 To cantFilas - 1
                    Dim rek1 As New Rectangle(xPosicionSaldo, yGeneral, xSaldo, yHeight)
                    e.Graphics.DrawRectangle(Pens.Black, rek1)
                    e.Graphics.DrawString(moduloAuxiliar.nuevoValor(i).FuncionValueSaldo, fon3, Brushes.Black, rek1, strings3)

                    Dim rek2 As New Rectangle(xPosicionComentario, yGeneral, xComentario, yHeight)
                    e.Graphics.DrawRectangle(Pens.Black, rek2)
                    e.Graphics.DrawString(moduloAuxiliar.nuevoValor(i).FuncionValueComentario, fon3, Brushes.Black, rek2, strings3)

                    Dim rek3 As New Rectangle(xPosicionFecha, yGeneral, xFecha, yHeight)
                    e.Graphics.DrawRectangle(Pens.Black, rek3)
                    e.Graphics.DrawString(moduloAuxiliar.nuevoValor(i).FuncionValueFecha, fon3, Brushes.Black, rek3, strings3)

                    yGeneral += 20
                Next
            Else

                '-----------------------Algoritmo para generar varios documentos-------------------------------------'

                For j = paginaActual To cantPaginas


                    If j = cantPaginas Then
                        calculo = filasPorPagina * (cantPaginas - 1)
                        filasPorPagina = cantFilas - calculo
                    End If

                    For i As Integer = filaActual To (filaActual + filasPorPagina) - 1
                        Dim rek1 As New Rectangle(xPosicionSaldo, yGeneral, xSaldo, yHeight)
                        e.Graphics.DrawRectangle(Pens.Black, rek1)
                        e.Graphics.DrawString(moduloAuxiliar.nuevoValor(i).FuncionValueSaldo, fon3, Brushes.Black, rek1, strings3)

                        Dim rek2 As New Rectangle(xPosicionComentario, yGeneral, xComentario, yHeight)
                        e.Graphics.DrawRectangle(Pens.Black, rek2)
                        e.Graphics.DrawString(moduloAuxiliar.nuevoValor(i).FuncionValueComentario, fon3, Brushes.Black, rek2, strings3)

                        Dim rek3 As New Rectangle(xPosicionFecha, yGeneral, xFecha, yHeight)
                        e.Graphics.DrawRectangle(Pens.Black, rek3)
                        e.Graphics.DrawString(moduloAuxiliar.nuevoValor(i).FuncionValueFecha, fon3, Brushes.Black, rek3, strings3)

                        yGeneral += 20
                    Next
                    filaActual += filasPorPagina
                    paginaActual += 1

                    If j < cantPaginas Then
                        e.HasMorePages = True
                        yGeneral = 140
                        Exit Sub
                    Else
                        e.HasMorePages = False
                    End If

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        contadorPagina.Maximum = cantPaginas

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
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub contadorPagina_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contadorPagina.ValueChanged
        PrintPreviewControl1.StartPage = contadorPagina.Value - 1
    End Sub

End Class