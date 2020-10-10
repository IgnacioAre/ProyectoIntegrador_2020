<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuentaCorrienteProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentaCorrienteProveedor))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.btnDebe = New System.Windows.Forms.Button()
        Me.btnHaber = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvClientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.pbActualizarTabla = New System.Windows.Forms.PictureBox()
        Me.dgvRegistroVentas = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbRegistroCompras = New System.Windows.Forms.GroupBox()
        Me.chkCobros = New System.Windows.Forms.CheckBox()
        Me.chkRegistroCompleto = New System.Windows.Forms.CheckBox()
        Me.btnVerRegistro = New System.Windows.Forms.Button()
        Me.btnOcultarRegistro = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEliminarRegistro = New System.Windows.Forms.Button()
        Me.btnEliminarTodoRegistro = New System.Windows.Forms.Button()
        Me.gbHaber = New System.Windows.Forms.GroupBox()
        Me.btnVerDetalleHaber = New System.Windows.Forms.Button()
        Me.btnOcultarDetalleHaber = New System.Windows.Forms.Button()
        Me.txtDetalleHaber = New System.Windows.Forms.TextBox()
        Me.btnPagarTodo = New System.Windows.Forms.PictureBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDineroHaber = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistroCompras.SuspendLayout()
        Me.gbHaber.SuspendLayout()
        CType(Me.btnPagarTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(95, 26)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(244, 26)
        Me.txtBuscarClientes.TabIndex = 0
        '
        'btnDebe
        '
        Me.btnDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebe.BackColor = System.Drawing.Color.MistyRose
        Me.btnDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebe.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebe.ForeColor = System.Drawing.Color.Black
        Me.btnDebe.Location = New System.Drawing.Point(793, 63)
        Me.btnDebe.Name = "btnDebe"
        Me.btnDebe.Size = New System.Drawing.Size(157, 56)
        Me.btnDebe.TabIndex = 11
        Me.btnDebe.Text = "Nueva Compra"
        Me.btnDebe.UseVisualStyleBackColor = False
        '
        'btnHaber
        '
        Me.btnHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHaber.BackColor = System.Drawing.Color.LightGreen
        Me.btnHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHaber.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.PictureBox1.Location = New System.Drawing.Point(48, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
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
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgvClientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'pbActualizarTabla
        '
        Me.pbActualizarTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbActualizarTabla.Image = CType(resources.GetObject("pbActualizarTabla.Image"), System.Drawing.Image)
        Me.pbActualizarTabla.Location = New System.Drawing.Point(16, 103)
        Me.pbActualizarTabla.Name = "pbActualizarTabla"
        Me.pbActualizarTabla.Size = New System.Drawing.Size(35, 35)
        Me.pbActualizarTabla.TabIndex = 23
        Me.pbActualizarTabla.TabStop = False
        '
        'dgvRegistroVentas
        '
        Me.dgvRegistroVentas.AllowUserToAddRows = False
        Me.dgvRegistroVentas.AllowUserToDeleteRows = False
        Me.dgvRegistroVentas.AllowUserToResizeColumns = False
        Me.dgvRegistroVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRegistroVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistroVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroVentas.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvRegistroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistroVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroVentas.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRegistroVentas.EnableHeadersVisualStyles = False
        Me.dgvRegistroVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroVentas.Location = New System.Drawing.Point(14, 60)
        Me.dgvRegistroVentas.Name = "dgvRegistroVentas"
        Me.dgvRegistroVentas.ReadOnly = True
        Me.dgvRegistroVentas.RowHeadersVisible = False
        Me.dgvRegistroVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroVentas.Size = New System.Drawing.Size(529, 324)
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
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroVentas.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvRegistroVentas.ThemeStyle.ReadOnly = True
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvRegistroVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'gbRegistroCompras
        '
        Me.gbRegistroCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRegistroCompras.Controls.Add(Me.chkCobros)
        Me.gbRegistroCompras.Controls.Add(Me.chkRegistroCompleto)
        Me.gbRegistroCompras.Controls.Add(Me.dgvRegistroVentas)
        Me.gbRegistroCompras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroCompras.ForeColor = System.Drawing.Color.White
        Me.gbRegistroCompras.Location = New System.Drawing.Point(27, 339)
        Me.gbRegistroCompras.Name = "gbRegistroCompras"
        Me.gbRegistroCompras.Size = New System.Drawing.Size(556, 399)
        Me.gbRegistroCompras.TabIndex = 25
        Me.gbRegistroCompras.TabStop = False
        Me.gbRegistroCompras.Text = "Registro de Compras"
        Me.gbRegistroCompras.Visible = False
        '
        'chkCobros
        '
        Me.chkCobros.AutoSize = True
        Me.chkCobros.ForeColor = System.Drawing.Color.Navy
        Me.chkCobros.Location = New System.Drawing.Point(21, 25)
        Me.chkCobros.Name = "chkCobros"
        Me.chkCobros.Size = New System.Drawing.Size(132, 26)
        Me.chkCobros.TabIndex = 35
        Me.chkCobros.Text = "Ver Cobros"
        Me.chkCobros.UseVisualStyleBackColor = True
        '
        'chkRegistroCompleto
        '
        Me.chkRegistroCompleto.AutoSize = True
        Me.chkRegistroCompleto.ForeColor = System.Drawing.Color.Navy
        Me.chkRegistroCompleto.Location = New System.Drawing.Point(297, 25)
        Me.chkRegistroCompleto.Name = "chkRegistroCompleto"
        Me.chkRegistroCompleto.Size = New System.Drawing.Size(235, 26)
        Me.chkRegistroCompleto.TabIndex = 34
        Me.chkRegistroCompleto.Text = "Ver Registro Completo"
        Me.chkRegistroCompleto.UseVisualStyleBackColor = True
        '
        'btnVerRegistro
        '
        Me.btnVerRegistro.BackColor = System.Drawing.Color.Teal
        Me.btnVerRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOcultarRegistro.BackColor = System.Drawing.Color.Teal
        Me.btnOcultarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnCerrar.BackColor = System.Drawing.Color.Black
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(6, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrar.TabIndex = 30
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.BackColor = System.Drawing.Color.Crimson
        Me.btnEliminarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEliminarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRegistro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegistro.ForeColor = System.Drawing.Color.White
        Me.btnEliminarRegistro.Image = CType(resources.GetObject("btnEliminarRegistro.Image"), System.Drawing.Image)
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(239, 49)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(142, 54)
        Me.btnEliminarRegistro.TabIndex = 31
        Me.btnEliminarRegistro.Text = "Eliminar Registro"
        Me.btnEliminarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarRegistro.UseVisualStyleBackColor = False
        '
        'btnEliminarTodoRegistro
        '
        Me.btnEliminarTodoRegistro.BackColor = System.Drawing.Color.Red
        Me.btnEliminarTodoRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarTodoRegistro.Enabled = False
        Me.btnEliminarTodoRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEliminarTodoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEliminarTodoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTodoRegistro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTodoRegistro.ForeColor = System.Drawing.Color.White
        Me.btnEliminarTodoRegistro.Image = CType(resources.GetObject("btnEliminarTodoRegistro.Image"), System.Drawing.Image)
        Me.btnEliminarTodoRegistro.Location = New System.Drawing.Point(239, 196)
        Me.btnEliminarTodoRegistro.Name = "btnEliminarTodoRegistro"
        Me.btnEliminarTodoRegistro.Size = New System.Drawing.Size(142, 54)
        Me.btnEliminarTodoRegistro.TabIndex = 32
        Me.btnEliminarTodoRegistro.Text = "Eliminar TODO"
        Me.btnEliminarTodoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarTodoRegistro.UseVisualStyleBackColor = False
        '
        'gbHaber
        '
        Me.gbHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbHaber.Controls.Add(Me.btnVerDetalleHaber)
        Me.gbHaber.Controls.Add(Me.btnOcultarDetalleHaber)
        Me.gbHaber.Controls.Add(Me.txtDetalleHaber)
        Me.gbHaber.Controls.Add(Me.btnPagarTodo)
        Me.gbHaber.Controls.Add(Me.CheckBox2)
        Me.gbHaber.Controls.Add(Me.Button1)
        Me.gbHaber.Controls.Add(Me.Label3)
        Me.gbHaber.Controls.Add(Me.Label4)
        Me.gbHaber.Controls.Add(Me.txtDineroHaber)
        Me.gbHaber.Controls.Add(Me.btnEliminarTodoRegistro)
        Me.gbHaber.Controls.Add(Me.btnEliminarRegistro)
        Me.gbHaber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHaber.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbHaber.Location = New System.Drawing.Point(589, 473)
        Me.gbHaber.Name = "gbHaber"
        Me.gbHaber.Size = New System.Drawing.Size(388, 265)
        Me.gbHaber.TabIndex = 33
        Me.gbHaber.TabStop = False
        Me.gbHaber.Text = "Haber"
        Me.gbHaber.Visible = False
        '
        'btnVerDetalleHaber
        '
        Me.btnVerDetalleHaber.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnVerDetalleHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDetalleHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerDetalleHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerDetalleHaber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleHaber.ForeColor = System.Drawing.Color.White
        Me.btnVerDetalleHaber.Image = CType(resources.GetObject("btnVerDetalleHaber.Image"), System.Drawing.Image)
        Me.btnVerDetalleHaber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalleHaber.Location = New System.Drawing.Point(39, 93)
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
        Me.btnOcultarDetalleHaber.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOcultarDetalleHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarDetalleHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarDetalleHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarDetalleHaber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarDetalleHaber.ForeColor = System.Drawing.Color.White
        Me.btnOcultarDetalleHaber.Image = CType(resources.GetObject("btnOcultarDetalleHaber.Image"), System.Drawing.Image)
        Me.btnOcultarDetalleHaber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarDetalleHaber.Location = New System.Drawing.Point(38, 94)
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
        Me.txtDetalleHaber.Location = New System.Drawing.Point(38, 146)
        Me.txtDetalleHaber.Name = "txtDetalleHaber"
        Me.txtDetalleHaber.Size = New System.Drawing.Size(296, 26)
        Me.txtDetalleHaber.TabIndex = 39
        Me.txtDetalleHaber.Visible = False
        '
        'btnPagarTodo
        '
        Me.btnPagarTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagarTodo.Image = CType(resources.GetObject("btnPagarTodo.Image"), System.Drawing.Image)
        Me.btnPagarTodo.Location = New System.Drawing.Point(184, 51)
        Me.btnPagarTodo.Name = "btnPagarTodo"
        Me.btnPagarTodo.Size = New System.Drawing.Size(32, 32)
        Me.btnPagarTodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnPagarTodo.TabIndex = 38
        Me.btnPagarTodo.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(18, 230)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(155, 20)
        Me.CheckBox2.TabIndex = 37
        Me.CheckBox2.Text = "Importante (Notas)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(19, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Saldo"
        '
        'txtDineroHaber
        '
        Me.txtDineroHaber.Location = New System.Drawing.Point(39, 56)
        Me.txtDineroHaber.MaxLength = 7
        Me.txtDineroHaber.Name = "txtDineroHaber"
        Me.txtDineroHaber.ReadOnly = True
        Me.txtDineroHaber.Size = New System.Drawing.Size(133, 27)
        Me.txtDineroHaber.TabIndex = 33
        '
        'CuentaCorrienteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1010, 750)
        Me.Controls.Add(Me.gbHaber)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnOcultarRegistro)
        Me.Controls.Add(Me.btnVerRegistro)
        Me.Controls.Add(Me.gbRegistroCompras)
        Me.Controls.Add(Me.pbActualizarTabla)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHaber)
        Me.Controls.Add(Me.btnDebe)
        Me.Controls.Add(Me.txtBuscarClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuentaCorrienteProveedor"
        Me.Text = "Pruebas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRegistroVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistroCompras.ResumeLayout(False)
        Me.gbRegistroCompras.PerformLayout()
        Me.gbHaber.ResumeLayout(False)
        Me.gbHaber.PerformLayout()
        CType(Me.btnPagarTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarClientes As System.Windows.Forms.TextBox
    Friend WithEvents btnDebe As System.Windows.Forms.Button
    Friend WithEvents btnHaber As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvClientes As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents pbActualizarTabla As System.Windows.Forms.PictureBox
    Friend WithEvents dgvRegistroVentas As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents gbRegistroCompras As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerRegistro As System.Windows.Forms.Button
    Friend WithEvents btnOcultarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnEliminarTodoRegistro As System.Windows.Forms.Button
    Friend WithEvents gbHaber As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDineroHaber As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnPagarTodo As System.Windows.Forms.PictureBox
    Friend WithEvents btnVerDetalleHaber As System.Windows.Forms.Button
    Friend WithEvents btnOcultarDetalleHaber As System.Windows.Forms.Button
    Friend WithEvents txtDetalleHaber As System.Windows.Forms.TextBox
    Friend WithEvents chkRegistroCompleto As System.Windows.Forms.CheckBox
    Friend WithEvents chkCobros As System.Windows.Forms.CheckBox
End Class
