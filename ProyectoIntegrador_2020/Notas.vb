Public Class Notas

    Dim consulta As Conexion = New Conexion()


    Private Sub Notas_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ActualizarTablaNotas()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Sub ActualizarTablaNotas()
        dgvNotas.DataSource = consulta.mostrarEnTabla("SELECT idNota,Texto as Recordatorio,Usuario as Usuario,fechaCreacion as Creación,importanteBool as i from Notas as n,admin as a where a.idAdmin = n.idAdmin;")

        consulta.consultaReturnHide("Select count(idNota) from Notas;")
        Dim cantNotas As Integer = Val(consulta.valorReturn)
        If cantNotas > 0 Then
            dgvNotas.Columns(0).Visible = False
            dgvNotas.Columns(4).Width = 0
        End If

    End Sub

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActualizarTabla.Click
        ActualizarTablaNotas()
    End Sub

    Private Sub dgvNotas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNotas.CellFormatting
        If dgvNotas.Columns(e.ColumnIndex).Name = "i" Then

            If e.Value = "True" Then
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.Red
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
            End If
        End If
    End Sub


End Class