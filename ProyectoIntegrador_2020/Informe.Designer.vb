<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informe))
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnZoomMenos = New System.Windows.Forms.Button()
        Me.btnZoomMas = New System.Windows.Forms.Button()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.panelBuscarCliente = New System.Windows.Forms.Panel()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRegistroVentas = New Guna.UI.WinForms.GunaDataGridView()
        Me.dgvClientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.pbRegresar = New System.Windows.Forms.PictureBox()
        Me.panelSuperior.SuspendLayout()
        Me.panelBuscarCliente.SuspendLayout()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.MediumBlue
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(76, 14)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 31)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Guardar"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnZoomMenos
        '
        Me.btnZoomMenos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomMenos.BackColor = System.Drawing.Color.SteelBlue
        Me.btnZoomMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMenos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomMenos.ForeColor = System.Drawing.Color.White
        Me.btnZoomMenos.Location = New System.Drawing.Point(574, 11)
        Me.btnZoomMenos.Name = "btnZoomMenos"
        Me.btnZoomMenos.Size = New System.Drawing.Size(75, 31)
        Me.btnZoomMenos.TabIndex = 2
        Me.btnZoomMenos.Text = "Zoom -"
        Me.btnZoomMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnZoomMenos.UseVisualStyleBackColor = False
        '
        'btnZoomMas
        '
        Me.btnZoomMas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomMas.BackColor = System.Drawing.Color.SteelBlue
        Me.btnZoomMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomMas.ForeColor = System.Drawing.Color.White
        Me.btnZoomMas.Location = New System.Drawing.Point(673, 11)
        Me.btnZoomMas.Name = "btnZoomMas"
        Me.btnZoomMas.Size = New System.Drawing.Size(75, 31)
        Me.btnZoomMas.TabIndex = 3
        Me.btnZoomMas.Text = "Zoom +"
        Me.btnZoomMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnZoomMas.UseVisualStyleBackColor = False
        '
        'panelSuperior
        '
        Me.panelSuperior.Controls.Add(Me.pbRegresar)
        Me.panelSuperior.Controls.Add(Me.btnImprimir)
        Me.panelSuperior.Controls.Add(Me.btnZoomMas)
        Me.panelSuperior.Controls.Add(Me.btnZoomMenos)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(762, 56)
        Me.panelSuperior.TabIndex = 4
        '
        'PrintDocument1
        '
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 56)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(762, 422)
        Me.PrintPreviewControl1.TabIndex = 5
        Me.PrintPreviewControl1.Zoom = 0.37363636363636366R
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'panelBuscarCliente
        '
        Me.panelBuscarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBuscarCliente.Controls.Add(Me.btnFacturar)
        Me.panelBuscarCliente.Controls.Add(Me.Label1)
        Me.panelBuscarCliente.Controls.Add(Me.dgvRegistroVentas)
        Me.panelBuscarCliente.Controls.Add(Me.dgvClientes)
        Me.panelBuscarCliente.Controls.Add(Me.PictureBox1)
        Me.panelBuscarCliente.Controls.Add(Me.txtBuscarClientes)
        Me.panelBuscarCliente.Location = New System.Drawing.Point(0, 3)
        Me.panelBuscarCliente.Name = "panelBuscarCliente"
        Me.panelBuscarCliente.Size = New System.Drawing.Size(762, 475)
        Me.panelBuscarCliente.TabIndex = 6
        '
        'btnFacturar
        '
        Me.btnFacturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacturar.BackColor = System.Drawing.Color.Crimson
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.ForeColor = System.Drawing.Color.White
        Me.btnFacturar.Location = New System.Drawing.Point(601, 432)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(119, 31)
        Me.btnFacturar.TabIndex = 30
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 22)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Registro de compras"
        '
        'dgvRegistroVentas
        '
        Me.dgvRegistroVentas.AllowUserToAddRows = False
        Me.dgvRegistroVentas.AllowUserToDeleteRows = False
        Me.dgvRegistroVentas.AllowUserToResizeColumns = False
        Me.dgvRegistroVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistroVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroVentas.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvRegistroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistroVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroVentas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegistroVentas.EnableHeadersVisualStyles = False
        Me.dgvRegistroVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroVentas.Location = New System.Drawing.Point(52, 221)
        Me.dgvRegistroVentas.Name = "dgvRegistroVentas"
        Me.dgvRegistroVentas.ReadOnly = True
        Me.dgvRegistroVentas.RowHeadersVisible = False
        Me.dgvRegistroVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroVentas.Size = New System.Drawing.Size(668, 194)
        Me.dgvRegistroVentas.TabIndex = 24
        Me.dgvRegistroVentas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvRegistroVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroVentas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRegistroVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRegistroVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRegistroVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRegistroVentas.ThemeStyle.BackColor = System.Drawing.Color.Khaki
        Me.dgvRegistroVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvRegistroVentas.ThemeStyle.ReadOnly = True
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvClientes.Location = New System.Drawing.Point(52, 62)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(668, 91)
        Me.dgvClientes.TabIndex = 28
        Me.dgvClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvClientes.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvClientes.ThemeStyle.ReadOnly = True
        Me.dgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvClientes.ThemeStyle.RowsStyle.Height = 22
        Me.dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(52, 21)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(282, 26)
        Me.txtBuscarClientes.TabIndex = 26
        '
        'pbRegresar
        '
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Image = CType(resources.GetObject("pbRegresar.Image"), System.Drawing.Image)
        Me.pbRegresar.Location = New System.Drawing.Point(12, 13)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(31, 32)
        Me.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRegresar.TabIndex = 11
        Me.pbRegresar.TabStop = False
        '
        'Informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 478)
        Me.Controls.Add(Me.panelBuscarCliente)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Informe"
        Me.Text = "Informe"
        Me.panelSuperior.ResumeLayout(False)
        Me.panelBuscarCliente.ResumeLayout(False)
        Me.panelBuscarCliente.PerformLayout()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnZoomMenos As System.Windows.Forms.Button
    Friend WithEvents btnZoomMas As System.Windows.Forms.Button
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents panelBuscarCliente As System.Windows.Forms.Panel
    Friend WithEvents dgvRegistroVentas As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents dgvClientes As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscarClientes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
End Class
