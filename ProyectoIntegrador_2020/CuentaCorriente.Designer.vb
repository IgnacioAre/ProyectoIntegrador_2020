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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.btnDebe = New System.Windows.Forms.Button()
        Me.btnHaber = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvClientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbDebe = New System.Windows.Forms.GroupBox()
        Me.btnCerrarInfo = New System.Windows.Forms.Button()
        Me.btnVerDetalleDebe = New System.Windows.Forms.Button()
        Me.btnOcultarDetalleDebe = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetalleDebe = New System.Windows.Forms.TextBox()
        Me.btnActualizarDeuda = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDineroDebe = New System.Windows.Forms.TextBox()
        Me.pbActualizarTabla = New System.Windows.Forms.PictureBox()
        Me.dgvRegistroVentas = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbRegistroCompras = New System.Windows.Forms.GroupBox()
        Me.chkRegistroCompleto = New System.Windows.Forms.CheckBox()
        Me.btnVerRegistro = New System.Windows.Forms.Button()
        Me.btnOcultarRegistro = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnPagarTodoRegistro = New System.Windows.Forms.Button()
        Me.gbHaber = New System.Windows.Forms.GroupBox()
        Me.btnDescontarHaber = New System.Windows.Forms.Button()
        Me.btnVerDetalleHaber = New System.Windows.Forms.Button()
        Me.btnOcultarDetalleHaber = New System.Windows.Forms.Button()
        Me.txtDetalleHaber = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDineroHaber = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDebe.SuspendLayout()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistroCompras.SuspendLayout()
        Me.gbHaber.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(135, 22)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(244, 26)
        Me.txtBuscarClientes.TabIndex = 0
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
        Me.PictureBox1.Location = New System.Drawing.Point(88, 13)
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
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle27
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvClientes.Location = New System.Drawing.Point(89, 62)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(673, 180)
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
        Me.gbDebe.Controls.Add(Me.btnCerrarInfo)
        Me.gbDebe.Controls.Add(Me.btnVerDetalleDebe)
        Me.gbDebe.Controls.Add(Me.btnOcultarDetalleDebe)
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
        'btnCerrarInfo
        '
        Me.btnCerrarInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnCerrarInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
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
        'btnVerDetalleDebe
        '
        Me.btnVerDetalleDebe.BackColor = System.Drawing.Color.Teal
        Me.btnVerDetalleDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDetalleDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerDetalleDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerDetalleDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleDebe.ForeColor = System.Drawing.Color.White
        Me.btnVerDetalleDebe.Image = CType(resources.GetObject("btnVerDetalleDebe.Image"), System.Drawing.Image)
        Me.btnVerDetalleDebe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalleDebe.Location = New System.Drawing.Point(32, 104)
        Me.btnVerDetalleDebe.Name = "btnVerDetalleDebe"
        Me.btnVerDetalleDebe.Size = New System.Drawing.Size(147, 47)
        Me.btnVerDetalleDebe.TabIndex = 28
        Me.btnVerDetalleDebe.Text = "  Comentario"
        Me.btnVerDetalleDebe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerDetalleDebe.UseVisualStyleBackColor = False
        '
        'btnOcultarDetalleDebe
        '
        Me.btnOcultarDetalleDebe.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOcultarDetalleDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarDetalleDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarDetalleDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarDetalleDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarDetalleDebe.ForeColor = System.Drawing.Color.White
        Me.btnOcultarDetalleDebe.Image = CType(resources.GetObject("btnOcultarDetalleDebe.Image"), System.Drawing.Image)
        Me.btnOcultarDetalleDebe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarDetalleDebe.Location = New System.Drawing.Point(32, 105)
        Me.btnOcultarDetalleDebe.Name = "btnOcultarDetalleDebe"
        Me.btnOcultarDetalleDebe.Size = New System.Drawing.Size(147, 47)
        Me.btnOcultarDetalleDebe.TabIndex = 28
        Me.btnOcultarDetalleDebe.Text = "  Comentario"
        Me.btnOcultarDetalleDebe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarDetalleDebe.UseVisualStyleBackColor = False
        Me.btnOcultarDetalleDebe.Visible = False
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
        Me.txtDetalleDebe.Visible = False
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
        Me.txtDineroDebe.MaxLength = 7
        Me.txtDineroDebe.Name = "txtDineroDebe"
        Me.txtDineroDebe.Size = New System.Drawing.Size(133, 26)
        Me.txtDineroDebe.TabIndex = 0
        '
        'pbActualizarTabla
        '
        Me.pbActualizarTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbActualizarTabla.Image = CType(resources.GetObject("pbActualizarTabla.Image"), System.Drawing.Image)
        Me.pbActualizarTabla.Location = New System.Drawing.Point(16, 103)
        Me.pbActualizarTabla.Name = "pbActualizarTabla"
        Me.pbActualizarTabla.Size = New System.Drawing.Size(32, 32)
        Me.pbActualizarTabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbActualizarTabla.TabIndex = 23
        Me.pbActualizarTabla.TabStop = False
        '
        'dgvRegistroVentas
        '
        Me.dgvRegistroVentas.AllowUserToAddRows = False
        Me.dgvRegistroVentas.AllowUserToDeleteRows = False
        Me.dgvRegistroVentas.AllowUserToResizeColumns = False
        Me.dgvRegistroVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvRegistroVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistroVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroVentas.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvRegistroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistroVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroVentas.DefaultCellStyle = DataGridViewCellStyle30
        Me.dgvRegistroVentas.EnableHeadersVisualStyles = False
        Me.dgvRegistroVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroVentas.Location = New System.Drawing.Point(14, 93)
        Me.dgvRegistroVentas.Name = "dgvRegistroVentas"
        Me.dgvRegistroVentas.ReadOnly = True
        Me.dgvRegistroVentas.RowHeadersVisible = False
        Me.dgvRegistroVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroVentas.Size = New System.Drawing.Size(490, 291)
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
        Me.gbRegistroCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRegistroCompras.Controls.Add(Me.chkRegistroCompleto)
        Me.gbRegistroCompras.Controls.Add(Me.dgvRegistroVentas)
        Me.gbRegistroCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroCompras.Location = New System.Drawing.Point(27, 339)
        Me.gbRegistroCompras.Name = "gbRegistroCompras"
        Me.gbRegistroCompras.Size = New System.Drawing.Size(517, 399)
        Me.gbRegistroCompras.TabIndex = 25
        Me.gbRegistroCompras.TabStop = False
        Me.gbRegistroCompras.Text = "Registro de Compras"
        Me.gbRegistroCompras.Visible = False
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
        'btnVerRegistro
        '
        Me.btnVerRegistro.BackColor = System.Drawing.Color.Teal
        Me.btnVerRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerRegistro.Enabled = False
        Me.btnVerRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRegistro.ForeColor = System.Drawing.Color.White
        Me.btnVerRegistro.Image = CType(resources.GetObject("btnVerRegistro.Image"), System.Drawing.Image)
        Me.btnVerRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerRegistro.Location = New System.Drawing.Point(27, 268)
        Me.btnVerRegistro.Name = "btnVerRegistro"
        Me.btnVerRegistro.Size = New System.Drawing.Size(132, 47)
        Me.btnVerRegistro.TabIndex = 26
        Me.btnVerRegistro.Text = "  Ver Registro"
        Me.btnVerRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerRegistro.UseVisualStyleBackColor = False
        '
        'btnOcultarRegistro
        '
        Me.btnOcultarRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOcultarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarRegistro.ForeColor = System.Drawing.Color.White
        Me.btnOcultarRegistro.Image = CType(resources.GetObject("btnOcultarRegistro.Image"), System.Drawing.Image)
        Me.btnOcultarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarRegistro.Location = New System.Drawing.Point(27, 268)
        Me.btnOcultarRegistro.Name = "btnOcultarRegistro"
        Me.btnOcultarRegistro.Size = New System.Drawing.Size(167, 47)
        Me.btnOcultarRegistro.TabIndex = 27
        Me.btnOcultarRegistro.Text = "  Ocultar Registro"
        Me.btnOcultarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarRegistro.UseVisualStyleBackColor = False
        Me.btnOcultarRegistro.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(6, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrar.TabIndex = 30
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
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
        Me.gbHaber.Controls.Add(Me.btnDescontarHaber)
        Me.gbHaber.Controls.Add(Me.btnVerDetalleHaber)
        Me.gbHaber.Controls.Add(Me.btnOcultarDetalleHaber)
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
        'btnVerDetalleHaber
        '
        Me.btnVerDetalleHaber.BackColor = System.Drawing.Color.Teal
        Me.btnVerDetalleHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDetalleHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerDetalleHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerDetalleHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleHaber.ForeColor = System.Drawing.Color.White
        Me.btnVerDetalleHaber.Image = CType(resources.GetObject("btnVerDetalleHaber.Image"), System.Drawing.Image)
        Me.btnVerDetalleHaber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalleHaber.Location = New System.Drawing.Point(39, 119)
        Me.btnVerDetalleHaber.Name = "btnVerDetalleHaber"
        Me.btnVerDetalleHaber.Size = New System.Drawing.Size(106, 47)
        Me.btnVerDetalleHaber.TabIndex = 40
        Me.btnVerDetalleHaber.Text = "  Detalle"
        Me.btnVerDetalleHaber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerDetalleHaber.UseVisualStyleBackColor = False
        Me.btnVerDetalleHaber.Visible = False
        '
        'btnOcultarDetalleHaber
        '
        Me.btnOcultarDetalleHaber.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOcultarDetalleHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarDetalleHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarDetalleHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarDetalleHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarDetalleHaber.ForeColor = System.Drawing.Color.White
        Me.btnOcultarDetalleHaber.Image = CType(resources.GetObject("btnOcultarDetalleHaber.Image"), System.Drawing.Image)
        Me.btnOcultarDetalleHaber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarDetalleHaber.Location = New System.Drawing.Point(38, 120)
        Me.btnOcultarDetalleHaber.Name = "btnOcultarDetalleHaber"
        Me.btnOcultarDetalleHaber.Size = New System.Drawing.Size(107, 47)
        Me.btnOcultarDetalleHaber.TabIndex = 41
        Me.btnOcultarDetalleHaber.Text = "  Detalle"
        Me.btnOcultarDetalleHaber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarDetalleHaber.UseVisualStyleBackColor = False
        Me.btnOcultarDetalleHaber.Visible = False
        '
        'txtDetalleHaber
        '
        Me.txtDetalleHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleHaber.Location = New System.Drawing.Point(38, 172)
        Me.txtDetalleHaber.Name = "txtDetalleHaber"
        Me.txtDetalleHaber.Size = New System.Drawing.Size(296, 26)
        Me.txtDetalleHaber.TabIndex = 39
        Me.txtDetalleHaber.Visible = False
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
        Me.txtDineroHaber.MaxLength = 7
        Me.txtDineroHaber.Name = "txtDineroHaber"
        Me.txtDineroHaber.Size = New System.Drawing.Size(122, 26)
        Me.txtDineroHaber.TabIndex = 33
        '
        'CuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 750)
        Me.Controls.Add(Me.gbHaber)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnOcultarRegistro)
        Me.Controls.Add(Me.btnVerRegistro)
        Me.Controls.Add(Me.gbRegistroCompras)
        Me.Controls.Add(Me.pbActualizarTabla)
        Me.Controls.Add(Me.gbDebe)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHaber)
        Me.Controls.Add(Me.btnDebe)
        Me.Controls.Add(Me.txtBuscarClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuentaCorriente"
        Me.Text = "Pruebas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDebe.ResumeLayout(False)
        Me.gbDebe.PerformLayout()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistroCompras.ResumeLayout(False)
        Me.gbRegistroCompras.PerformLayout()
        Me.gbHaber.ResumeLayout(False)
        Me.gbHaber.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarClientes As System.Windows.Forms.TextBox
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
    Friend WithEvents pbActualizarTabla As System.Windows.Forms.PictureBox
    Friend WithEvents dgvRegistroVentas As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents gbRegistroCompras As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerRegistro As System.Windows.Forms.Button
    Friend WithEvents btnOcultarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnVerDetalleDebe As System.Windows.Forms.Button
    Friend WithEvents btnOcultarDetalleDebe As System.Windows.Forms.Button
    Friend WithEvents btnCerrarInfo As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnPagarTodoRegistro As System.Windows.Forms.Button
    Friend WithEvents gbHaber As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDineroHaber As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnVerDetalleHaber As System.Windows.Forms.Button
    Friend WithEvents btnOcultarDetalleHaber As System.Windows.Forms.Button
    Friend WithEvents txtDetalleHaber As System.Windows.Forms.TextBox
    Friend WithEvents btnDescontarHaber As System.Windows.Forms.Button
    Friend WithEvents chkRegistroCompleto As System.Windows.Forms.CheckBox
End Class
