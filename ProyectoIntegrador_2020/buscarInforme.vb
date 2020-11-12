Imports System.Runtime.InteropServices
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class buscarInforme

    Dim consultas As moduloConexion = New moduloConexion
    Dim idCliente As Integer
    Dim nombreClientes As String


    Private Sub Informe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarTabla()
        ActualizarTablaRegistro()
        SendMessage(txtBuscarNombreCli.Handle, EM_SETCUEBANNER, 0, "Buscar proveedor por nombre")
        SendMessage(txtBuscarCodigoCli.Handle, EM_SETCUEBANNER, 0, "Buscar proveedor por código")
    End Sub

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    Private Sub txtBuscarClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNombreCli.TextChanged
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1 AND Nombre LIKE '%" & txtBuscarNombreCli.Text & "%';")
    End Sub


    Sub ActualizarTabla()
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1 order by(nombre) desc;")
    End Sub


    Sub ActualizarTablaRegistro()
        dgvRegistroVentas.DataSource = consultas.mostrarEnTabla("SELECT cc.Saldo,Detalle as Comentario,fechaCompra As Fecha,idCompra FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND c.idCliente=" & idCliente & " order by(idCompra) desc;")
        dgvRegistroVentas.Columns(3).Visible = False
    End Sub

    Sub ActualizarTablaRegistroOculto()
        dgvRegistroVentasOculto.DataSource = consultas.mostrarEnTabla("SELECT cc.Saldo,Detalle as Comentario,fechaCompra As Fecha FROM compraCliente as cc,Clientes as c WHERE cc.idCliente = c.idCliente AND c.idCliente=" & idCliente & " order by(idCompra) desc;")
    End Sub


    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedCells.Count <> 0 Then
            btnFacturar.Enabled = True
            idCliente = dgvClientes.SelectedCells(0).Value
            nombreClientes = dgvClientes.SelectedCells(1).Value
        Else
            btnFacturar.Enabled = False
        End If


        ActualizarTablaRegistro()
    End Sub

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click

        ActualizarTablaRegistroOculto()

        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)

            Dim ruta As String = String.Empty

            SaveFileDialog1.Filter = "PDF|*.pdf"
            SaveFileDialog1.FileName = "Factura del cliente " & nombreClientes & ".pdf"

            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = SaveFileDialog1.FileName
                Dim file As New FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                PdfWriter.GetInstance(doc, file)
                doc.Open()
                crearPDF(doc)
                doc.Close()
            End If


        Catch ex As Exception
            MsgBox("No se puede generar el documento PDF." & ex.Message)
        End Try




    End Sub



    Public Function ObtenerCantidadColumnas(ByVal dg As DataGridView) As Single()
        Dim valores As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            valores(i) = CSng(dg.Columns(i).Width)
        Next
        Return valores
    End Function



    Sub crearPDF(ByVal document As Document)
        'Se crea un pdfTable con el número de columnas del DataGridView
        Dim datatable As New PdfPTable(dgvRegistroVentasOculto.ColumnCount)

        'Se asignan las propiedades para el PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = ObtenerCantidadColumnas(dgvRegistroVentasOculto)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("Reporte de ventas" & "              El Cofre", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha " & Now.Date() & vbCrLf & "Nombre del cliente: " & nombreClientes, New Font(Font.Name = "Tahoma", 14, Font.Bold))

        'Se capturan los nombres de las columnas del DGV
        datatable.AddCell(dgvRegistroVentas.Columns(0).HeaderText)
        datatable.AddCell(dgvRegistroVentas.Columns(1).HeaderText)
        datatable.AddCell(dgvRegistroVentas.Columns(2).HeaderText)

        For i As Integer = 0 To dgvRegistroVentasOculto.RowCount - 1
            For j As Integer = 0 To dgvRegistroVentasOculto.ColumnCount - 1
                datatable.AddCell(dgvRegistroVentasOculto(j, i).Value.ToString)
            Next
        Next

        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)

    End Sub



    Private Sub dgvRegistroVentas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistroVentas.SelectionChanged
        If dgvRegistroVentas.SelectedCells.Count <> 0 Then
            btnFacturar.Enabled = True

        Else
            btnFacturar.Enabled = False
        End If
    End Sub


    Private Sub txtBuscarClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNombreCli.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            dgvClientes.Focus()
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

    Private Sub txtBuscarCodigoCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigoCli.TextChanged
        dgvClientes.DataSource = consultas.mostrarEnTabla("SELECT idCliente As ID, Nombre, Saldo FROM Clientes WHERE estadoBool=1 AND idCliente LIKE '%" & txtBuscarCodigoCli.Text & "%';")
    End Sub

    Private Sub txtBuscarCodigoCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarCodigoCli.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                dgvClientes.Focus()
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ActualizarTabla()
        If txtBuscarNombreCli.Visible Then
            txtBuscarCodigoCli.Visible = True
            txtBuscarNombreCli.Visible = False
        Else
            txtBuscarNombreCli.Visible = True
            txtBuscarCodigoCli.Visible = False
        End If
    End Sub
End Class