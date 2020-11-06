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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentaCorriente))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscarNombreCli = New System.Windows.Forms.TextBox()
        Me.btnDebe = New System.Windows.Forms.Button()
        Me.btnHaber = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvClientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbDebe = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCerrarInfo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetalleDebe = New System.Windows.Forms.TextBox()
        Me.btnActualizarDeuda = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDineroDebe = New System.Windows.Forms.TextBox()
        Me.dgvRegistroVentas = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbRegistroCompras = New System.Windows.Forms.GroupBox()
        Me.chkRegistroCompleto = New System.Windows.Forms.CheckBox()
        Me.btnPagarTodoRegistro = New System.Windows.Forms.Button()
        Me.gbHaber = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDescontarHaber = New System.Windows.Forms.Button()
        Me.txtDetalleHaber = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDineroHaber = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtBuscarCodigoCli = New System.Windows.Forms.TextBox()
        Me.lblUltimaCompra = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDebe.SuspendLayout()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistroCompras.SuspendLayout()
        Me.gbHaber.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarNombreCli
        '
        Me.txtBuscarNombreCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombreCli.Location = New System.Drawing.Point(86, 21)
        Me.txtBuscarNombreCli.Name = "txtBuscarNombreCli"
        Me.txtBuscarNombreCli.Size = New System.Drawing.Size(299, 26)
        Me.txtBuscarNombreCli.TabIndex = 0
        '
        'btnDebe
        '
        Me.btnDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebe.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebe.ForeColor = System.Drawing.Color.Black
        Me.btnDebe.Location = New System.Drawing.Point(793, 63)
        Me.btnDebe.Name = "btnDebe"
        Me.btnDebe.Size = New System.Drawing.Size(157, 44)
        Me.btnDebe.TabIndex = 11
        Me.btnDebe.Text = "Debe"
        Me.btnDebe.UseVisualStyleBackColor = False
        '
        'btnHaber
        '
        Me.btnHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHaber.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHaber.ForeColor = System.Drawing.Color.Black
        Me.btnHaber.Location = New System.Drawing.Point(793, 125)
        Me.btnHaber.Name = "btnHaber"
        Me.btnHaber.Size = New System.Drawing.Size(157, 44)
        Me.btnHaber.TabIndex = 12
        Me.btnHaber.Text = "Haber"
        Me.btnHaber.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvClientes.Location = New System.Drawing.Point(41, 62)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(721, 180)
        Me.dgvClientes.TabIndex = 18
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
        'gbDebe
        '
        Me.gbDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDebe.Controls.Add(Me.Label6)
        Me.gbDebe.Controls.Add(Me.btnCerrarInfo)
        Me.gbDebe.Controls.Add(Me.Label2)
        Me.gbDebe.Controls.Add(Me.txtDetalleDebe)
        Me.gbDebe.Controls.Add(Me.btnActualizarDeuda)
        Me.gbDebe.Controls.Add(Me.CheckBox1)
        Me.gbDebe.Controls.Add(Me.Label1)
        Me.gbDebe.Controls.Add(Me.txtDineroDebe)
        Me.gbDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDebe.ForeColor = System.Drawing.Color.Maroon
        Me.gbDebe.Location = New System.Drawing.Point(653, 248)
        Me.gbDebe.Name = "gbDebe"
        Me.gbDebe.Size = New System.Drawing.Size(345, 253)
        Me.gbDebe.TabIndex = 19
        Me.gbDebe.TabStop = False
        Me.gbDebe.Text = "Debe"
        Me.gbDebe.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Comentario"
        '
        'btnCerrarInfo
        '
        Me.btnCerrarInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnCerrarInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarInfo.FlatAppearance.BorderSize = 0
        Me.btnCerrarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarInfo.ForeColor = System.Drawing.Color.White
        Me.btnCerrarInfo.Location = New System.Drawing.Point(311, 16)
        Me.btnCerrarInfo.Name = "btnCerrarInfo"
        Me.btnCerrarInfo.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrarInfo.TabIndex = 29
        Me.btnCerrarInfo.Text = "X"
        Me.btnCerrarInfo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "$"
        '
        'txtDetalleDebe
        '
        Me.txtDetalleDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleDebe.Location = New System.Drawing.Point(32, 157)
        Me.txtDetalleDebe.Name = "txtDetalleDebe"
        Me.txtDetalleDebe.Size = New System.Drawing.Size(292, 26)
        Me.txtDetalleDebe.TabIndex = 5
        '
        'btnActualizarDeuda
        '
        Me.btnActualizarDeuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnActualizarDeuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarDeuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnActualizarDeuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnActualizarDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarDeuda.ForeColor = System.Drawing.Color.White
        Me.btnActualizarDeuda.Location = New System.Drawing.Point(245, 210)
        Me.btnActualizarDeuda.Name = "btnActualizarDeuda"
        Me.btnActualizarDeuda.Size = New System.Drawing.Size(94, 37)
        Me.btnActualizarDeuda.TabIndex = 3
        Me.btnActualizarDeuda.Text = "Guardar"
        Me.btnActualizarDeuda.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(32, 221)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(155, 20)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Importante (Notas)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dinero"
        '
        'txtDineroDebe
        '
        Me.txtDineroDebe.Location = New System.Drawing.Point(46, 59)
        Me.txtDineroDebe.MaxLength = 10
        Me.txtDineroDebe.Name = "txtDineroDebe"
        Me.txtDineroDebe.Size = New System.Drawing.Size(133, 26)
        Me.txtDineroDebe.TabIndex = 0
        '
        'dgvRegistroVentas
        '
        Me.dgvRegistroVentas.AllowUserToAddRows = False
        Me.dgvRegistroVentas.AllowUserToDeleteRows = False
        Me.dgvRegistroVentas.AllowUserToResizeColumns = False
        Me.dgvRegistroVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRegistroVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistroVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroVentas.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvRegistroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistroVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroVentas.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRegistroVentas.EnableHeadersVisualStyles = False
        Me.dgvRegistroVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroVentas.Location = New System.Drawing.Point(14, 80)
        Me.dgvRegistroVentas.Name = "dgvRegistroVentas"
        Me.dgvRegistroVentas.ReadOnly = True
        Me.dgvRegistroVentas.RowHeadersVisible = False
        Me.dgvRegistroVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroVentas.Size = New System.Drawing.Size(490, 379)
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
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvRegistroVentas.ThemeStyle.ReadOnly = True
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'gbRegistroCompras
        '
        Me.gbRegistroCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRegistroCompras.Controls.Add(Me.chkRegistroCompleto)
        Me.gbRegistroCompras.Controls.Add(Me.dgvRegistroVentas)
        Me.gbRegistroCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroCompras.Location = New System.Drawing.Point(27, 264)
        Me.gbRegistroCompras.Name = "gbRegistroCompras"
        Me.gbRegistroCompras.Size = New System.Drawing.Size(517, 474)
        Me.gbRegistroCompras.TabIndex = 25
        Me.gbRegistroCompras.TabStop = False
        Me.gbRegistroCompras.Text = "Registro de Compras"
        '
        'chkRegistroCompleto
        '
        Me.chkRegistroCompleto.AutoSize = True
        Me.chkRegistroCompleto.ForeColor = System.Drawing.Color.Navy
        Me.chkRegistroCompleto.Location = New System.Drawing.Point(14, 46)
        Me.chkRegistroCompleto.Name = "chkRegistroCompleto"
        Me.chkRegistroCompleto.Size = New System.Drawing.Size(219, 28)
        Me.chkRegistroCompleto.TabIndex = 36
        Me.chkRegistroCompleto.Text = "Ver Registro Completo"
        Me.chkRegistroCompleto.UseVisualStyleBackColor = True
        '
        'btnPagarTodoRegistro
        '
        Me.btnPagarTodoRegistro.BackColor = System.Drawing.Color.Red
        Me.btnPagarTodoRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagarTodoRegistro.Enabled = False
        Me.btnPagarTodoRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnPagarTodoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPagarTodoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagarTodoRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarTodoRegistro.ForeColor = System.Drawing.Color.White
        Me.btnPagarTodoRegistro.Image = CType(resources.GetObject("btnPagarTodoRegistro.Image"), System.Drawing.Image)
        Me.btnPagarTodoRegistro.Location = New System.Drawing.Point(239, 222)
        Me.btnPagarTodoRegistro.Name = "btnPagarTodoRegistro"
        Me.btnPagarTodoRegistro.Size = New System.Drawing.Size(142, 54)
        Me.btnPagarTodoRegistro.TabIndex = 32
        Me.btnPagarTodoRegistro.Text = "Pagar TODO"
        Me.btnPagarTodoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagarTodoRegistro.UseVisualStyleBackColor = False
        '
        'gbHaber
        '
        Me.gbHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbHaber.Controls.Add(Me.Label5)
        Me.gbHaber.Controls.Add(Me.btnDescontarHaber)
        Me.gbHaber.Controls.Add(Me.txtDetalleHaber)
        Me.gbHaber.Controls.Add(Me.CheckBox2)
        Me.gbHaber.Controls.Add(Me.Button1)
        Me.gbHaber.Controls.Add(Me.Label3)
        Me.gbHaber.Controls.Add(Me.Label4)
        Me.gbHaber.Controls.Add(Me.txtDineroHaber)
        Me.gbHaber.Controls.Add(Me.btnPagarTodoRegistro)
        Me.gbHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHaber.ForeColor = System.Drawing.Color.Green
        Me.gbHaber.Location = New System.Drawing.Point(589, 450)
        Me.gbHaber.Name = "gbHaber"
        Me.gbHaber.Size = New System.Drawing.Size(388, 288)
        Me.gbHaber.TabIndex = 33
        Me.gbHaber.TabStop = False
        Me.gbHaber.Text = "Haber"
        Me.gbHaber.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Comentario"
        '
        'btnDescontarHaber
        '
        Me.btnDescontarHaber.BackColor = System.Drawing.Color.Crimson
        Me.btnDescontarHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescontarHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDescontarHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDescontarHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescontarHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescontarHaber.ForeColor = System.Drawing.Color.White
        Me.btnDescontarHaber.Location = New System.Drawing.Point(231, 71)
        Me.btnDescontarHaber.Name = "btnDescontarHaber"
        Me.btnDescontarHaber.Size = New System.Drawing.Size(130, 49)
        Me.btnDescontarHaber.TabIndex = 42
        Me.btnDescontarHaber.Text = "Descontar"
        Me.btnDescontarHaber.UseVisualStyleBackColor = False
        '
        'txtDetalleHaber
        '
        Me.txtDetalleHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleHaber.Location = New System.Drawing.Point(38, 172)
        Me.txtDetalleHaber.Name = "txtDetalleHaber"
        Me.txtDetalleHaber.Size = New System.Drawing.Size(296, 26)
        Me.txtDetalleHaber.TabIndex = 39
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(18, 256)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(155, 20)
        Me.CheckBox2.TabIndex = 37
        Me.CheckBox2.Text = "Importante (Notas)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(353, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 27)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(19, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Saldo"
        '
        'txtDineroHaber
        '
        Me.txtDineroHaber.Location = New System.Drawing.Point(39, 82)
        Me.txtDineroHaber.MaxLength = 10
        Me.txtDineroHaber.Name = "txtDineroHaber"
        Me.txtDineroHaber.Size = New System.Drawing.Size(122, 26)
        Me.txtDineroHaber.TabIndex = 33
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(391, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 58
        Me.PictureBox4.TabStop = False
        '
        'txtBuscarCodigoCli
        '
        Me.txtBuscarCodigoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCodigoCli.Location = New System.Drawing.Point(86, 22)
        Me.txtBuscarCodigoCli.MaxLength = 13
        Me.txtBuscarCodigoCli.Name = "txtBuscarCodigoCli"
        Me.txtBuscarCodigoCli.Size = New System.Drawing.Size(299, 26)
        Me.txtBuscarCodigoCli.TabIndex = 57
        Me.txtBuscarCodigoCli.Visible = False
        '
        'lblUltimaCompra
        '
        Me.lblUltimaCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUltimaCompra.AutoSize = True
        Me.lblUltimaCompra.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaCompra.ForeColor = System.Drawing.Color.Black
        Me.lblUltimaCompra.Location = New System.Drawing.Point(681, 9)
        Me.lblUltimaCompra.Name = "lblUltimaCompra"
        Me.lblUltimaCompra.Size = New System.Drawing.Size(219, 19)
        Me.lblUltimaCompra.TabIndex = 59
        Me.lblUltimaCompra.Text = "Última compra: 05/11/2020"
        '
        'CuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 750)
        Me.Controls.Add(Me.lblUltimaCompra)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtBuscarCodigoCli)
        Me.Controls.Add(Me.gbHaber)
        Me.Controls.Add(Me.gbRegistroCompras)
        Me.Controls.Add(Me.gbDebe)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHaber)
        Me.Controls.Add(Me.btnDebe)
        Me.Controls.Add(Me.txtBuscarNombreCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuentaCorriente"
        Me.Text = "Pruebas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDebe.ResumeLayout(False)
        Me.gbDebe.PerformLayout()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistroCompras.ResumeLayout(False)
        Me.gbRegistroCompras.PerformLayout()
        Me.gbHaber.ResumeLayout(False)
        Me.gbHaber.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarNombreCli As System.Windows.Forms.TextBox
    Friend WithEvents btnDebe As System.Windows.Forms.Button
    Friend WithEvents btnHaber As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvClientes As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents gbDebe As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetalleDebe As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizarDeuda As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDineroDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvRegistroVentas As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents gbRegistroCompras As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrarInfo As System.Windows.Forms.Button
    Friend WithEvents btnPagarTodoRegistro As System.Windows.Forms.Button
    Friend WithEvents gbHaber As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDineroHaber As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDetalleHaber As System.Windows.Forms.TextBox
    Friend WithEvents btnDescontarHaber As System.Windows.Forms.Button
    Friend WithEvents chkRegistroCompleto As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscarCodigoCli As System.Windows.Forms.TextBox
    Friend WithEvents lblUltimaCompra As System.Windows.Forms.Label
End Class
