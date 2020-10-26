<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionarProductos))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.dgvProductos = New Guna.UI.WinForms.GunaDataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.gpInformacion = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxMedida = New System.Windows.Forms.ComboBox()
        Me.txtCantidadUnidad = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrarInfo = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSurtir = New System.Windows.Forms.Button()
        Me.pbActualizarTabla = New System.Windows.Forms.PictureBox()
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtMinimoStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAjustarMinimoStock = New System.Windows.Forms.PictureBox()
        Me.dgvRegistroSurtido = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnEditarRegistro = New System.Windows.Forms.PictureBox()
        Me.panelEditarRegistro = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardarRegistro = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioCosto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gpRegistro = New System.Windows.Forms.GroupBox()
        Me.btnOcultarRegistro = New System.Windows.Forms.Button()
        Me.btnVerRegistro = New System.Windows.Forms.Button()
        Me.tmrOcultarEditarRegistro = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarEditarRegistro = New System.Windows.Forms.Timer(Me.components)
        Me.chbProdNoActivos = New System.Windows.Forms.CheckBox()
        Me.btnAgregarProd = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpInformacion.SuspendLayout()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAjustarMinimoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRegistroSurtido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditarRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEditarRegistro.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpRegistro.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(12, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrar.TabIndex = 31
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvProductos.Location = New System.Drawing.Point(12, 105)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(821, 180)
        Me.dgvProductos.TabIndex = 32
        Me.dgvProductos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvProductos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvProductos.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProductos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductos.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvProductos.ThemeStyle.ReadOnly = True
        Me.dgvProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProductos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'txtBuscarProductos
        '
        Me.txtBuscarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProductos.Location = New System.Drawing.Point(59, 63)
        Me.txtBuscarProductos.Name = "txtBuscarProductos"
        Me.txtBuscarProductos.Size = New System.Drawing.Size(244, 26)
        Me.txtBuscarProductos.TabIndex = 33
        '
        'gpInformacion
        '
        Me.gpInformacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpInformacion.Controls.Add(Me.Label10)
        Me.gpInformacion.Controls.Add(Me.cbxMedida)
        Me.gpInformacion.Controls.Add(Me.txtCantidadUnidad)
        Me.gpInformacion.Controls.Add(Me.txtStock)
        Me.gpInformacion.Controls.Add(Me.Label4)
        Me.gpInformacion.Controls.Add(Me.btnCerrarInfo)
        Me.gpInformacion.Controls.Add(Me.btnActualizar)
        Me.gpInformacion.Controls.Add(Me.txtNombre)
        Me.gpInformacion.Controls.Add(Me.Label2)
        Me.gpInformacion.Controls.Add(Me.txtID)
        Me.gpInformacion.Controls.Add(Me.Label1)
        Me.gpInformacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpInformacion.ForeColor = System.Drawing.Color.White
        Me.gpInformacion.Location = New System.Drawing.Point(36, 421)
        Me.gpInformacion.Name = "gpInformacion"
        Me.gpInformacion.Size = New System.Drawing.Size(316, 355)
        Me.gpInformacion.TabIndex = 37
        Me.gpInformacion.TabStop = False
        Me.gpInformacion.Text = "Información del Producto"
        Me.gpInformacion.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Medida"
        '
        'cbxMedida
        '
        Me.cbxMedida.FormattingEnabled = True
        Me.cbxMedida.Items.AddRange(New Object() {"UNIDADES", "KILOGRAMOS", "GRAMOS", "LITROS", "MILILITROS"})
        Me.cbxMedida.Location = New System.Drawing.Point(95, 234)
        Me.cbxMedida.Name = "cbxMedida"
        Me.cbxMedida.Size = New System.Drawing.Size(145, 29)
        Me.cbxMedida.TabIndex = 21
        '
        'txtCantidadUnidad
        '
        Me.txtCantidadUnidad.Location = New System.Drawing.Point(45, 234)
        Me.txtCantidadUnidad.MaxLength = 5
        Me.txtCantidadUnidad.Name = "txtCantidadUnidad"
        Me.txtCantidadUnidad.Size = New System.Drawing.Size(39, 27)
        Me.txtCantidadUnidad.TabIndex = 30
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(45, 175)
        Me.txtStock.MaxLength = 4
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(112, 27)
        Me.txtStock.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Stock"
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
        Me.btnCerrarInfo.Location = New System.Drawing.Point(282, 17)
        Me.btnCerrarInfo.Name = "btnCerrarInfo"
        Me.btnCerrarInfo.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrarInfo.TabIndex = 17
        Me.btnCerrarInfo.Text = "X"
        Me.btnCerrarInfo.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(77, 288)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(139, 48)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = " Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(42, 108)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(214, 27)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(42, 54)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(214, 27)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(178, 304)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 54)
        Me.btnModificar.TabIndex = 36
        Me.btnModificar.Text = "   Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(10, 304)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(150, 54)
        Me.btnNuevo.TabIndex = 35
        Me.btnNuevo.Text = "    Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSurtir
        '
        Me.btnSurtir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSurtir.BackColor = System.Drawing.Color.Black
        Me.btnSurtir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurtir.FlatAppearance.BorderSize = 0
        Me.btnSurtir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnSurtir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSurtir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSurtir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurtir.ForeColor = System.Drawing.Color.White
        Me.btnSurtir.Image = CType(resources.GetObject("btnSurtir.Image"), System.Drawing.Image)
        Me.btnSurtir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSurtir.Location = New System.Drawing.Point(720, 304)
        Me.btnSurtir.Name = "btnSurtir"
        Me.btnSurtir.Size = New System.Drawing.Size(113, 54)
        Me.btnSurtir.TabIndex = 38
        Me.btnSurtir.Text = "   Surtir"
        Me.btnSurtir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSurtir.UseVisualStyleBackColor = False
        '
        'pbActualizarTabla
        '
        Me.pbActualizarTabla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbActualizarTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbActualizarTabla.Image = CType(resources.GetObject("pbActualizarTabla.Image"), System.Drawing.Image)
        Me.pbActualizarTabla.Location = New System.Drawing.Point(858, 250)
        Me.pbActualizarTabla.Name = "pbActualizarTabla"
        Me.pbActualizarTabla.Size = New System.Drawing.Size(35, 35)
        Me.pbActualizarTabla.TabIndex = 39
        Me.pbActualizarTabla.TabStop = False
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(59, 64)
        Me.txtBuscarCodigo.MaxLength = 13
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(244, 26)
        Me.txtBuscarCodigo.TabIndex = 40
        Me.txtBuscarCodigo.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(344, 304)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 54)
        Me.btnEliminar.TabIndex = 41
        Me.btnEliminar.Text = "   Quitar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtMinimoStock
        '
        Me.txtMinimoStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinimoStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimoStock.Location = New System.Drawing.Point(869, 127)
        Me.txtMinimoStock.MaxLength = 3
        Me.txtMinimoStock.Name = "txtMinimoStock"
        Me.txtMinimoStock.Size = New System.Drawing.Size(55, 26)
        Me.txtMinimoStock.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(854, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Stock mínimio"
        '
        'btnAjustarMinimoStock
        '
        Me.btnAjustarMinimoStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjustarMinimoStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAjustarMinimoStock.Image = CType(resources.GetObject("btnAjustarMinimoStock.Image"), System.Drawing.Image)
        Me.btnAjustarMinimoStock.Location = New System.Drawing.Point(937, 127)
        Me.btnAjustarMinimoStock.Name = "btnAjustarMinimoStock"
        Me.btnAjustarMinimoStock.Size = New System.Drawing.Size(24, 24)
        Me.btnAjustarMinimoStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAjustarMinimoStock.TabIndex = 45
        Me.btnAjustarMinimoStock.TabStop = False
        '
        'dgvRegistroSurtido
        '
        Me.dgvRegistroSurtido.AllowUserToAddRows = False
        Me.dgvRegistroSurtido.AllowUserToDeleteRows = False
        Me.dgvRegistroSurtido.AllowUserToResizeColumns = False
        Me.dgvRegistroSurtido.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroSurtido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRegistroSurtido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistroSurtido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroSurtido.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvRegistroSurtido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistroSurtido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroSurtido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroSurtido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRegistroSurtido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroSurtido.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRegistroSurtido.EnableHeadersVisualStyles = False
        Me.dgvRegistroSurtido.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroSurtido.Location = New System.Drawing.Point(10, 27)
        Me.dgvRegistroSurtido.Name = "dgvRegistroSurtido"
        Me.dgvRegistroSurtido.ReadOnly = True
        Me.dgvRegistroSurtido.RowHeadersVisible = False
        Me.dgvRegistroSurtido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroSurtido.Size = New System.Drawing.Size(587, 218)
        Me.dgvRegistroSurtido.TabIndex = 24
        Me.dgvRegistroSurtido.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvRegistroSurtido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroSurtido.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRegistroSurtido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRegistroSurtido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRegistroSurtido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRegistroSurtido.ThemeStyle.BackColor = System.Drawing.Color.Khaki
        Me.dgvRegistroSurtido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroSurtido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvRegistroSurtido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRegistroSurtido.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroSurtido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroSurtido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroSurtido.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvRegistroSurtido.ThemeStyle.ReadOnly = True
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvRegistroSurtido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'btnEditarRegistro
        '
        Me.btnEditarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarRegistro.Image = CType(resources.GetObject("btnEditarRegistro.Image"), System.Drawing.Image)
        Me.btnEditarRegistro.Location = New System.Drawing.Point(10, 251)
        Me.btnEditarRegistro.Name = "btnEditarRegistro"
        Me.btnEditarRegistro.Size = New System.Drawing.Size(28, 27)
        Me.btnEditarRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEditarRegistro.TabIndex = 27
        Me.btnEditarRegistro.TabStop = False
        '
        'panelEditarRegistro
        '
        Me.panelEditarRegistro.BackColor = System.Drawing.Color.Gainsboro
        Me.panelEditarRegistro.Controls.Add(Me.Label9)
        Me.panelEditarRegistro.Controls.Add(Me.txtCantidad)
        Me.panelEditarRegistro.Controls.Add(Me.Label8)
        Me.panelEditarRegistro.Controls.Add(Me.btnGuardarRegistro)
        Me.panelEditarRegistro.Controls.Add(Me.PictureBox2)
        Me.panelEditarRegistro.Controls.Add(Me.txtPorcentaje)
        Me.panelEditarRegistro.Controls.Add(Me.Label7)
        Me.panelEditarRegistro.Controls.Add(Me.txtPrecioCosto)
        Me.panelEditarRegistro.Controls.Add(Me.Label5)
        Me.panelEditarRegistro.Location = New System.Drawing.Point(10, 27)
        Me.panelEditarRegistro.Name = "panelEditarRegistro"
        Me.panelEditarRegistro.Size = New System.Drawing.Size(338, 218)
        Me.panelEditarRegistro.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(273, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "%"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(31, 141)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(84, 27)
        Me.txtCantidad.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(27, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cantidad"
        '
        'btnGuardarRegistro
        '
        Me.btnGuardarRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnGuardarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarRegistro.Image = CType(resources.GetObject("btnGuardarRegistro.Image"), System.Drawing.Image)
        Me.btnGuardarRegistro.Location = New System.Drawing.Point(277, 166)
        Me.btnGuardarRegistro.Name = "btnGuardarRegistro"
        Me.btnGuardarRegistro.Size = New System.Drawing.Size(43, 48)
        Me.btnGuardarRegistro.TabIndex = 17
        Me.btnGuardarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarRegistro.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 177)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 31)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(201, 65)
        Me.txtPorcentaje.MaxLength = 2
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(65, 27)
        Me.txtPorcentaje.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(180, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Porcentaje"
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Location = New System.Drawing.Point(31, 63)
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(84, 27)
        Me.txtPrecioCosto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio Costo"
        '
        'gpRegistro
        '
        Me.gpRegistro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpRegistro.Controls.Add(Me.panelEditarRegistro)
        Me.gpRegistro.Controls.Add(Me.btnEditarRegistro)
        Me.gpRegistro.Controls.Add(Me.dgvRegistroSurtido)
        Me.gpRegistro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpRegistro.ForeColor = System.Drawing.Color.White
        Me.gpRegistro.Location = New System.Drawing.Point(358, 491)
        Me.gpRegistro.Name = "gpRegistro"
        Me.gpRegistro.Size = New System.Drawing.Size(612, 285)
        Me.gpRegistro.TabIndex = 26
        Me.gpRegistro.TabStop = False
        Me.gpRegistro.Text = "Registro de Surtido"
        Me.gpRegistro.Visible = False
        '
        'btnOcultarRegistro
        '
        Me.btnOcultarRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultarRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOcultarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarRegistro.ForeColor = System.Drawing.Color.White
        Me.btnOcultarRegistro.Image = CType(resources.GetObject("btnOcultarRegistro.Image"), System.Drawing.Image)
        Me.btnOcultarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarRegistro.Location = New System.Drawing.Point(803, 449)
        Me.btnOcultarRegistro.Name = "btnOcultarRegistro"
        Me.btnOcultarRegistro.Size = New System.Drawing.Size(167, 47)
        Me.btnOcultarRegistro.TabIndex = 47
        Me.btnOcultarRegistro.Text = "  Ocultar Registro"
        Me.btnOcultarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarRegistro.UseVisualStyleBackColor = False
        Me.btnOcultarRegistro.Visible = False
        '
        'btnVerRegistro
        '
        Me.btnVerRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerRegistro.BackColor = System.Drawing.Color.Teal
        Me.btnVerRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRegistro.ForeColor = System.Drawing.Color.White
        Me.btnVerRegistro.Image = CType(resources.GetObject("btnVerRegistro.Image"), System.Drawing.Image)
        Me.btnVerRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerRegistro.Location = New System.Drawing.Point(803, 449)
        Me.btnVerRegistro.Name = "btnVerRegistro"
        Me.btnVerRegistro.Size = New System.Drawing.Size(132, 47)
        Me.btnVerRegistro.TabIndex = 46
        Me.btnVerRegistro.Text = "  Ver Registro"
        Me.btnVerRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerRegistro.UseVisualStyleBackColor = False
        '
        'tmrOcultarEditarRegistro
        '
        Me.tmrOcultarEditarRegistro.Interval = 1
        '
        'tmrMostrarEditarRegistro
        '
        Me.tmrMostrarEditarRegistro.Interval = 1
        '
        'chbProdNoActivos
        '
        Me.chbProdNoActivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbProdNoActivos.AutoSize = True
        Me.chbProdNoActivos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbProdNoActivos.ForeColor = System.Drawing.Color.White
        Me.chbProdNoActivos.Location = New System.Drawing.Point(645, 65)
        Me.chbProdNoActivos.Name = "chbProdNoActivos"
        Me.chbProdNoActivos.Size = New System.Drawing.Size(192, 25)
        Me.chbProdNoActivos.TabIndex = 48
        Me.chbProdNoActivos.Text = "Productos no activos"
        Me.chbProdNoActivos.UseVisualStyleBackColor = True
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAgregarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd.Enabled = False
        Me.btnAgregarProd.FlatAppearance.BorderSize = 0
        Me.btnAgregarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAgregarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProd.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProd.Image = CType(resources.GetObject("btnAgregarProd.Image"), System.Drawing.Image)
        Me.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarProd.Location = New System.Drawing.Point(344, 304)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(150, 54)
        Me.btnAgregarProd.TabIndex = 49
        Me.btnAgregarProd.Text = "   Agregar"
        Me.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarProd.UseVisualStyleBackColor = False
        Me.btnAgregarProd.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(320, 55)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 50
        Me.PictureBox4.TabStop = False
        '
        'GestionarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 788)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnAgregarProd)
        Me.Controls.Add(Me.chbProdNoActivos)
        Me.Controls.Add(Me.btnOcultarRegistro)
        Me.Controls.Add(Me.btnVerRegistro)
        Me.Controls.Add(Me.btnAjustarMinimoStock)
        Me.Controls.Add(Me.txtMinimoStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtBuscarCodigo)
        Me.Controls.Add(Me.pbActualizarTabla)
        Me.Controls.Add(Me.btnSurtir)
        Me.Controls.Add(Me.gpInformacion)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gpRegistro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBuscarProductos)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarProductos"
        Me.Text = "Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpInformacion.ResumeLayout(False)
        Me.gpInformacion.PerformLayout()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAjustarMinimoStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRegistroSurtido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditarRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEditarRegistro.ResumeLayout(False)
        Me.panelEditarRegistro.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpRegistro.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Public WithEvents dgvProductos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscarProductos As System.Windows.Forms.TextBox
    Friend WithEvents gpInformacion As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrarInfo As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtCantidadUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSurtir As System.Windows.Forms.Button
    Friend WithEvents pbActualizarTabla As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxMedida As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtMinimoStock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAjustarMinimoStock As System.Windows.Forms.PictureBox
    Friend WithEvents dgvRegistroSurtido As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnEditarRegistro As System.Windows.Forms.PictureBox
    Friend WithEvents panelEditarRegistro As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarRegistro As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents btnOcultarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnVerRegistro As System.Windows.Forms.Button
    Friend WithEvents tmrOcultarEditarRegistro As System.Windows.Forms.Timer
    Friend WithEvents tmrMostrarEditarRegistro As System.Windows.Forms.Timer
    Friend WithEvents chbProdNoActivos As System.Windows.Forms.CheckBox
    Friend WithEvents btnAgregarProd As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
