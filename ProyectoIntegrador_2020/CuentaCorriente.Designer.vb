<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuentaCorriente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentaCorriente))
        Me.dgvCientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.btnDebe = New System.Windows.Forms.Button()
        Me.btnHaber = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvCientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCientes
        '
        Me.dgvCientes.AllowUserToAddRows = False
        Me.dgvCientes.AllowUserToDeleteRows = False
        Me.dgvCientes.AllowUserToResizeColumns = False
        Me.dgvCientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvCientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCientes.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.dgvCientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCientes.EnableHeadersVisualStyles = False
        Me.dgvCientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvCientes.Location = New System.Drawing.Point(75, 79)
        Me.dgvCientes.Name = "dgvCientes"
        Me.dgvCientes.ReadOnly = True
        Me.dgvCientes.RowHeadersVisible = False
        Me.dgvCientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCientes.Size = New System.Drawing.Size(665, 180)
        Me.dgvCientes.TabIndex = 3
        Me.dgvCientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvCientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvCientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCientes.ThemeStyle.BackColor = System.Drawing.Color.DarkOrange
        Me.dgvCientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvCientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvCientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCientes.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvCientes.ThemeStyle.ReadOnly = True
        Me.dgvCientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvCientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCientes.ThemeStyle.RowsStyle.Height = 22
        Me.dgvCientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.dgvCientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(75, 43)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(244, 27)
        Me.txtBuscarClientes.TabIndex = 4
        '
        'btnDebe
        '
        Me.btnDebe.BackColor = System.Drawing.Color.Black
        Me.btnDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebe.ForeColor = System.Drawing.Color.White
        Me.btnDebe.Location = New System.Drawing.Point(761, 79)
        Me.btnDebe.Name = "btnDebe"
        Me.btnDebe.Size = New System.Drawing.Size(157, 44)
        Me.btnDebe.TabIndex = 11
        Me.btnDebe.Text = "Debe"
        Me.btnDebe.UseVisualStyleBackColor = False
        '
        'btnHaber
        '
        Me.btnHaber.BackColor = System.Drawing.Color.Black
        Me.btnHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHaber.ForeColor = System.Drawing.Color.White
        Me.btnHaber.Location = New System.Drawing.Point(761, 129)
        Me.btnHaber.Name = "btnHaber"
        Me.btnHaber.Size = New System.Drawing.Size(157, 44)
        Me.btnHaber.TabIndex = 12
        Me.btnHaber.Text = "Haber"
        Me.btnHaber.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(48, 325)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "+ Historial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(325, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(2, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 23)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'CuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(952, 548)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnHaber)
        Me.Controls.Add(Me.btnDebe)
        Me.Controls.Add(Me.txtBuscarClientes)
        Me.Controls.Add(Me.dgvCientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuentaCorriente"
        Me.Text = "Pruebas"
        CType(Me.dgvCientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCientes As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtBuscarClientes As System.Windows.Forms.TextBox
    Friend WithEvents btnDebe As System.Windows.Forms.Button
    Friend WithEvents btnHaber As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
