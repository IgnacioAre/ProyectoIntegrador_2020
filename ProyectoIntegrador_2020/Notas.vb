Imports System.Runtime.InteropServices
Imports System.IO

Public Class Notas

    Dim consulta As Conexion = New Conexion()
    Dim editarBool As Boolean = False
    Dim idNota As Integer
    Dim resultado As Byte


    Private Sub Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SendMessage(txtNota.Handle, EM_SETCUEBANNER, 0, "Recordatorio...")
        SendMessage(txtBuscarTexto.Handle, EM_SETCUEBANNER, 0, "Buscar por recordatorio")
    End Sub

    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    Private Sub Notas_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ActualizarTablaNotas()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Sub ActualizarTablaNotas()
        dgvNotas.DataSource = consulta.mostrarEnTabla("SELECT idNota,Texto as Recordatorio,Usuario as Usuario,fechaCreacion as Creación,importanteBool as i from Notas as n,admin as a where a.idAdmin = n.idAdmin order by importantebool desc,fechaCreacion desc;")
        dgvNotas.Columns(0).Visible = False
        dgvNotas.Columns(4).Width = 0

    End Sub

    Private Sub pbActualizarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ActualizarTablaNotas()
    End Sub

    Private Sub dgvNotas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNotas.CellFormatting
        If dgvNotas.Columns(e.ColumnIndex).Name = "i" Then

            If e.Value = "True" Then
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.IndianRed
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
                dgvNotas.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
            End If
        End If
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not txtNota.Text.Equals("") Then
            consulta.consultaReturnHide("select idadmin from Admin where logeadoBool = 1;")
            Dim idadmin As Byte = Val(consulta.valorReturn)

            If editarBool = False Then
                If chbImportanteBool.Checked Then
                    consulta.consultaHide("INSERT INTO NOTAS(TEXTO, FECHACREACION, IMPORTANTEBOOL, IDADMIN) VALUES ('" & txtNota.Text & "', NOW(),1," & idadmin & ");")
                Else
                    consulta.consultaHide("INSERT INTO NOTAS(TEXTO, FECHACREACION, IMPORTANTEBOOL, IDADMIN) VALUES ('" & txtNota.Text & "', NOW(),0," & idadmin & ");")
                End If
            Else

                If chbImportanteBool.Checked Then
                    consulta.consultaHide("Update Notas set Texto='" & txtNota.Text & "', importanteBool=1 where idNota=" & idNota & ";")
                Else
                    consulta.consultaHide("Update Notas set Texto='" & txtNota.Text & "', importanteBool=0 where idNota=" & idNota & ";")
                End If

            End If

            If consulta.resultado = 1 Then
                ActualizarTablaNotas()
                btnModificar.Enabled = True
                txtNota.Text = ""
                txtNota.Multiline = False
                SendMessage(txtNota.Handle, EM_SETCUEBANNER, 0, "Recordatorio...")
                dgvNotas.Enabled = True
                chbImportanteBool.Checked = False
                editarBool = False
            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        editarBool = True
        btnModificar.Enabled = False
        consulta.consultaReturnHide("select texto from notas where idnota =  " & idNota & ";")
        txtNota.Text = consulta.valorReturn
        dgvNotas.Enabled = False
        consulta.consultaReturnHide("select importanteBool from notas where idnota =  " & idNota & ";")

        If consulta.valorReturn = "True" Then
            chbImportanteBool.Checked = True
        Else
            chbImportanteBool.Checked = False
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        resultado = ConfirmacionMensaje.confirmacion("   ¿Seguro que desea borrar esta nota?")
        If resultado = 1 Then
            consulta.consultaHide("delete from notas where idNota =  " & idNota & ";")
            ActualizarTablaNotas()
            dgvNotas.Enabled = True
            txtNota.Text = ""
        Else
            mostrarMensaje("No se pudo eliminar la nota.")
        End If
    End Sub


    Private Sub dgvNotas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvNotas.SelectionChanged
        Dim row As DataGridViewRow = dgvNotas.CurrentRow

        If dgvNotas.SelectedCells.Count <> 0 Then
            btnEliminar.Enabled = True
            btnModificar.Enabled = True
            idNota = row.Cells(0).Value

        Else
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        End If
    End Sub



    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub


    Private Sub txtNota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNota.TextChanged
        If txtNota.Text.Count >= 27 Then
            txtNota.Multiline = True
        Else
            txtNota.Multiline = False
        End If
    End Sub

    Private Sub txtBuscarTexto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarTexto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 44 Then
            e.Handled = False

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

    Private Sub txtBuscarTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarTexto.TextChanged
        dgvNotas.DataSource = consulta.mostrarEnTabla("SELECT idNota,Texto as Recordatorio,Usuario as Usuario,fechaCreacion as Creación,importanteBool as i from Notas as n,admin as a where a.idAdmin = n.idAdmin and idNota > 1 and Texto LIKE '%" & txtBuscarTexto.Text & "%' order by importantebool desc,fechaCreacion desc;")
        dgvNotas.Columns(0).Visible = False
        dgvNotas.Columns(4).Width = 0
    End Sub

    Private Sub txtNota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNota.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 44 Then
            e.Handled = False

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


End Class