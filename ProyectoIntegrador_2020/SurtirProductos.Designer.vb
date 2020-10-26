<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurtirProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurtirProductos))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtImporteCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFinalizarSurtido = New System.Windows.Forms.Button()
        Me.btnOtraCompra = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.PictureBox()
        Me.btnAgregar = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVolverCompra = New System.Windows.Forms.PictureBox()
        Me.btnSiguienteCompra = New System.Windows.Forms.PictureBox()
        Me.lblNumProducto = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tmrMostrarBuscar = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarBuscar = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarAgregar = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarAgregar = New System.Windows.Forms.Timer(Me.components)
        Me.panelAgregar = New System.Windows.Forms.Panel()
        Me.txtVentaIngreso = New System.Windows.Forms.TextBox()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGananciaIngreso = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCostoIngreso = New System.Windows.Forms.TextBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevoProd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxMedida = New System.Windows.Forms.ComboBox()
        Me.txtCantidadUnidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCerrarAgregar = New System.Windows.Forms.Button()
        Me.dgvProductos = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnVolverBusqueda = New System.Windows.Forms.PictureBox()
        Me.btnAnotarBusqueda = New System.Windows.Forms.Button()
        Me.panelBuscar = New System.Windows.Forms.Panel()
        Me.panelSurtido = New System.Windows.Forms.Panel()
        Me.lblAyudaCampos = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnVolverCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSiguienteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAgregar.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolverBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBuscar.SuspendLayout()
        Me.panelSurtido.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(384, 40)
        Me.panelTitulo.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(163, 18)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Surtiendo Productos"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(347, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtImporteCosto
        '
        Me.txtImporteCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteCosto.Location = New System.Drawing.Point(81, 241)
        Me.txtImporteCosto.Name = "txtImporteCosto"
        Me.txtImporteCosto.Size = New System.Drawing.Size(119, 26)
        Me.txtImporteCosto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(50, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Importe"
        '
        'btnFinalizarSurtido
        '
        Me.btnFinalizarSurtido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizarSurtido.BackColor = System.Drawing.Color.Black
        Me.btnFinalizarSurtido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizarSurtido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnFinalizarSurtido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFinalizarSurtido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinalizarSurtido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarSurtido.ForeColor = System.Drawing.Color.White
        Me.btnFinalizarSurtido.Location = New System.Drawing.Point(204, 427)
        Me.btnFinalizarSurtido.Name = "btnFinalizarSurtido"
        Me.btnFinalizarSurtido.Size = New System.Drawing.Size(169, 44)
        Me.btnFinalizarSurtido.TabIndex = 11
        Me.btnFinalizarSurtido.Text = "Finalizar Surtido"
        Me.btnFinalizarSurtido.UseVisualStyleBackColor = False
        '
        'btnOtraCompra
        '
        Me.btnOtraCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOtraCompra.BackColor = System.Drawing.Color.ForestGreen
        Me.btnOtraCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOtraCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOtraCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOtraCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOtraCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtraCompra.ForeColor = System.Drawing.Color.White
        Me.btnOtraCompra.Location = New System.Drawing.Point(19, 427)
        Me.btnOtraCompra.Name = "btnOtraCompra"
        Me.btnOtraCompra.Size = New System.Drawing.Size(132, 44)
        Me.btnOtraCompra.TabIndex = 12
        Me.btnOtraCompra.Text = "Otro Producto"
        Me.btnOtraCompra.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Código del Producto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(350, 109)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(350, 147)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(32, 32)
        Me.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(59, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "$"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(67, 115)
        Me.txtCodigoProducto.MaxLength = 13
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(208, 26)
        Me.txtCodigoProducto.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Red
        Me.lblNombre.Location = New System.Drawing.Point(2, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(179, 21)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre del producto"
        Me.lblNombre.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Location = New System.Drawing.Point(31, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 50)
        Me.Panel1.TabIndex = 39
        '
        'btnVolverCompra
        '
        Me.btnVolverCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVolverCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolverCompra.Image = CType(resources.GetObject("btnVolverCompra.Image"), System.Drawing.Image)
        Me.btnVolverCompra.Location = New System.Drawing.Point(19, 389)
        Me.btnVolverCompra.Name = "btnVolverCompra"
        Me.btnVolverCompra.Size = New System.Drawing.Size(32, 32)
        Me.btnVolverCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnVolverCompra.TabIndex = 40
        Me.btnVolverCompra.TabStop = False
        '
        'btnSiguienteCompra
        '
        Me.btnSiguienteCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSiguienteCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguienteCompra.Image = CType(resources.GetObject("btnSiguienteCompra.Image"), System.Drawing.Image)
        Me.btnSiguienteCompra.Location = New System.Drawing.Point(119, 389)
        Me.btnSiguienteCompra.Name = "btnSiguienteCompra"
        Me.btnSiguienteCompra.Size = New System.Drawing.Size(32, 32)
        Me.btnSiguienteCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnSiguienteCompra.TabIndex = 41
        Me.btnSiguienteCompra.TabStop = False
        Me.btnSiguienteCompra.Visible = False
        '
        'lblNumProducto
        '
        Me.lblNumProducto.AutoSize = True
        Me.lblNumProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumProducto.ForeColor = System.Drawing.Color.Maroon
        Me.lblNumProducto.Location = New System.Drawing.Point(14, 24)
        Me.lblNumProducto.Name = "lblNumProducto"
        Me.lblNumProducto.Size = New System.Drawing.Size(109, 20)
        Me.lblNumProducto.TabIndex = 42
        Me.lblNumProducto.Text = "Producto N° "
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(81, 300)
        Me.txtCantidad.MaxLength = 13
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(119, 26)
        Me.txtCantidad.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(50, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 21)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Cantidad"
        '
        'txtGanancia
        '
        Me.txtGanancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGanancia.Location = New System.Drawing.Point(291, 281)
        Me.txtGanancia.MaxLength = 13
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(62, 26)
        Me.txtGanancia.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(243, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Ganancia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(264, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "%"
        '
        'tmrMostrarBuscar
        '
        Me.tmrMostrarBuscar.Interval = 1
        '
        'tmrOcultarBuscar
        '
        Me.tmrOcultarBuscar.Interval = 1
        '
        'tmrMostrarAgregar
        '
        Me.tmrMostrarAgregar.Interval = 1
        '
        'tmrOcultarAgregar
        '
        Me.tmrOcultarAgregar.Interval = 1
        '
        'panelAgregar
        '
        Me.panelAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelAgregar.BackColor = System.Drawing.Color.Teal
        Me.panelAgregar.Controls.Add(Me.lblAyudaCampos)
        Me.panelAgregar.Controls.Add(Me.txtVentaIngreso)
        Me.panelAgregar.Controls.Add(Me.lblVenta)
        Me.panelAgregar.Controls.Add(Me.Label13)
        Me.panelAgregar.Controls.Add(Me.txtGananciaIngreso)
        Me.panelAgregar.Controls.Add(Me.Label12)
        Me.panelAgregar.Controls.Add(Me.txtCostoIngreso)
        Me.panelAgregar.Controls.Add(Me.lblCosto)
        Me.panelAgregar.Controls.Add(Me.Label2)
        Me.panelAgregar.Controls.Add(Me.btnNuevoProd)
        Me.panelAgregar.Controls.Add(Me.Label10)
        Me.panelAgregar.Controls.Add(Me.cbxMedida)
        Me.panelAgregar.Controls.Add(Me.txtCantidadUnidad)
        Me.panelAgregar.Controls.Add(Me.txtNombre)
        Me.panelAgregar.Controls.Add(Me.Label5)
        Me.panelAgregar.Controls.Add(Me.txtCodigo)
        Me.panelAgregar.Controls.Add(Me.Label9)
        Me.panelAgregar.Controls.Add(Me.btnCerrarAgregar)
        Me.panelAgregar.Location = New System.Drawing.Point(0, 40)
        Me.panelAgregar.Name = "panelAgregar"
        Me.panelAgregar.Size = New System.Drawing.Size(384, 477)
        Me.panelAgregar.TabIndex = 51
        '
        'txtVentaIngreso
        '
        Me.txtVentaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaIngreso.Location = New System.Drawing.Point(185, 316)
        Me.txtVentaIngreso.MaxLength = 4
        Me.txtVentaIngreso.Name = "txtVentaIngreso"
        Me.txtVentaIngreso.Size = New System.Drawing.Size(69, 26)
        Me.txtVentaIngreso.TabIndex = 51
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.ForeColor = System.Drawing.Color.White
        Me.lblVenta.Location = New System.Drawing.Point(144, 287)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(110, 21)
        Me.lblVenta.TabIndex = 50
        Me.lblVenta.Text = "Precio Venta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(294, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "%"
        '
        'txtGananciaIngreso
        '
        Me.txtGananciaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGananciaIngreso.Location = New System.Drawing.Point(319, 316)
        Me.txtGananciaIngreso.MaxLength = 2
        Me.txtGananciaIngreso.Name = "txtGananciaIngreso"
        Me.txtGananciaIngreso.Size = New System.Drawing.Size(45, 26)
        Me.txtGananciaIngreso.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(280, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 21)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Ganancia"
        '
        'txtCostoIngreso
        '
        Me.txtCostoIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoIngreso.Location = New System.Drawing.Point(54, 316)
        Me.txtCostoIngreso.MaxLength = 4
        Me.txtCostoIngreso.Name = "txtCostoIngreso"
        Me.txtCostoIngreso.Size = New System.Drawing.Size(69, 26)
        Me.txtCostoIngreso.TabIndex = 43
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.ForeColor = System.Drawing.Color.White
        Me.lblCosto.Location = New System.Drawing.Point(13, 287)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(107, 21)
        Me.lblCosto.TabIndex = 42
        Me.lblCosto.Text = "Precio Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(104, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Ej: 2 Litros"
        '
        'btnNuevoProd
        '
        Me.btnNuevoProd.BackColor = System.Drawing.Color.DarkBlue
        Me.btnNuevoProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoProd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevoProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNuevoProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnNuevoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProd.ForeColor = System.Drawing.Color.White
        Me.btnNuevoProd.Image = CType(resources.GetObject("btnNuevoProd.Image"), System.Drawing.Image)
        Me.btnNuevoProd.Location = New System.Drawing.Point(107, 415)
        Me.btnNuevoProd.Name = "btnNuevoProd"
        Me.btnNuevoProd.Size = New System.Drawing.Size(148, 48)
        Me.btnNuevoProd.TabIndex = 40
        Me.btnNuevoProd.Text = "  Guardar"
        Me.btnNuevoProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevoProd.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(73, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 23)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Medida"
        '
        'cbxMedida
        '
        Me.cbxMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMedida.FormattingEnabled = True
        Me.cbxMedida.Items.AddRange(New Object() {"UNIDADES", "KILOGRAMOS", "GRAMOS", "LITROS", "MILILITROS"})
        Me.cbxMedida.Location = New System.Drawing.Point(154, 203)
        Me.cbxMedida.Name = "cbxMedida"
        Me.cbxMedida.Size = New System.Drawing.Size(121, 28)
        Me.cbxMedida.TabIndex = 36
        '
        'txtCantidadUnidad
        '
        Me.txtCantidadUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadUnidad.Location = New System.Drawing.Point(102, 203)
        Me.txtCantidadUnidad.MaxLength = 5
        Me.txtCantidadUnidad.Name = "txtCantidadUnidad"
        Me.txtCantidadUnidad.Size = New System.Drawing.Size(42, 26)
        Me.txtCantidadUnidad.TabIndex = 38
        Me.txtCantidadUnidad.Text = "1"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(95, 130)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(214, 26)
        Me.txtNombre.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(69, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(99, 61)
        Me.txtCodigo.MaxLength = 13
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(214, 26)
        Me.txtCodigo.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(73, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Código"
        '
        'btnCerrarAgregar
        '
        Me.btnCerrarAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarAgregar.BackColor = System.Drawing.Color.Black
        Me.btnCerrarAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarAgregar.FlatAppearance.BorderSize = 0
        Me.btnCerrarAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrarAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarAgregar.ForeColor = System.Drawing.Color.White
        Me.btnCerrarAgregar.Location = New System.Drawing.Point(12, 10)
        Me.btnCerrarAgregar.Name = "btnCerrarAgregar"
        Me.btnCerrarAgregar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrarAgregar.TabIndex = 18
        Me.btnCerrarAgregar.Text = "X"
        Me.btnCerrarAgregar.UseVisualStyleBackColor = False
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvProductos.Location = New System.Drawing.Point(16, 69)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(348, 327)
        Me.dgvProductos.TabIndex = 33
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
        Me.dgvProductos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductos.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvProductos.ThemeStyle.ReadOnly = True
        Me.dgvProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProductos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'txtBuscarProductos
        '
        Me.txtBuscarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProductos.Location = New System.Drawing.Point(78, 18)
        Me.txtBuscarProductos.Name = "txtBuscarProductos"
        Me.txtBuscarProductos.Size = New System.Drawing.Size(244, 26)
        Me.txtBuscarProductos.TabIndex = 35
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'btnVolverBusqueda
        '
        Me.btnVolverBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolverBusqueda.Image = CType(resources.GetObject("btnVolverBusqueda.Image"), System.Drawing.Image)
        Me.btnVolverBusqueda.Location = New System.Drawing.Point(6, 432)
        Me.btnVolverBusqueda.Name = "btnVolverBusqueda"
        Me.btnVolverBusqueda.Size = New System.Drawing.Size(43, 31)
        Me.btnVolverBusqueda.TabIndex = 45
        Me.btnVolverBusqueda.TabStop = False
        '
        'btnAnotarBusqueda
        '
        Me.btnAnotarBusqueda.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAnotarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnotarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAnotarBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAnotarBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnAnotarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnotarBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnotarBusqueda.ForeColor = System.Drawing.Color.Black
        Me.btnAnotarBusqueda.Image = CType(resources.GetObject("btnAnotarBusqueda.Image"), System.Drawing.Image)
        Me.btnAnotarBusqueda.Location = New System.Drawing.Point(238, 415)
        Me.btnAnotarBusqueda.Name = "btnAnotarBusqueda"
        Me.btnAnotarBusqueda.Size = New System.Drawing.Size(134, 48)
        Me.btnAnotarBusqueda.TabIndex = 50
        Me.btnAnotarBusqueda.Text = "  Anotar"
        Me.btnAnotarBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAnotarBusqueda.UseVisualStyleBackColor = False
        '
        'panelBuscar
        '
        Me.panelBuscar.BackColor = System.Drawing.Color.Gold
        Me.panelBuscar.Controls.Add(Me.btnAnotarBusqueda)
        Me.panelBuscar.Controls.Add(Me.btnVolverBusqueda)
        Me.panelBuscar.Controls.Add(Me.PictureBox3)
        Me.panelBuscar.Controls.Add(Me.txtBuscarProductos)
        Me.panelBuscar.Controls.Add(Me.dgvProductos)
        Me.panelBuscar.Location = New System.Drawing.Point(0, 40)
        Me.panelBuscar.Name = "panelBuscar"
        Me.panelBuscar.Size = New System.Drawing.Size(384, 477)
        Me.panelBuscar.TabIndex = 48
        '
        'panelSurtido
        '
        Me.panelSurtido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelSurtido.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.panelSurtido.Controls.Add(Me.btnBuscar)
        Me.panelSurtido.Controls.Add(Me.txtImporteCosto)
        Me.panelSurtido.Controls.Add(Me.Label1)
        Me.panelSurtido.Controls.Add(Me.Label8)
        Me.panelSurtido.Controls.Add(Me.Label3)
        Me.panelSurtido.Controls.Add(Me.txtGanancia)
        Me.panelSurtido.Controls.Add(Me.btnAgregar)
        Me.panelSurtido.Controls.Add(Me.Label7)
        Me.panelSurtido.Controls.Add(Me.btnFinalizarSurtido)
        Me.panelSurtido.Controls.Add(Me.txtCantidad)
        Me.panelSurtido.Controls.Add(Me.btnOtraCompra)
        Me.panelSurtido.Controls.Add(Me.Label6)
        Me.panelSurtido.Controls.Add(Me.Label4)
        Me.panelSurtido.Controls.Add(Me.lblNumProducto)
        Me.panelSurtido.Controls.Add(Me.txtCodigoProducto)
        Me.panelSurtido.Controls.Add(Me.btnSiguienteCompra)
        Me.panelSurtido.Controls.Add(Me.Panel1)
        Me.panelSurtido.Controls.Add(Me.btnVolverCompra)
        Me.panelSurtido.Location = New System.Drawing.Point(0, 40)
        Me.panelSurtido.Name = "panelSurtido"
        Me.panelSurtido.Size = New System.Drawing.Size(384, 477)
        Me.panelSurtido.TabIndex = 52
        '
        'lblAyudaCampos
        '
        Me.lblAyudaCampos.AutoSize = True
        Me.lblAyudaCampos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyudaCampos.ForeColor = System.Drawing.Color.White
        Me.lblAyudaCampos.Location = New System.Drawing.Point(55, 361)
        Me.lblAyudaCampos.Name = "lblAyudaCampos"
        Me.lblAyudaCampos.Size = New System.Drawing.Size(0, 17)
        Me.lblAyudaCampos.TabIndex = 52
        Me.lblAyudaCampos.Visible = False
        '
        'SurtirProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(384, 516)
        Me.Controls.Add(Me.panelSurtido)
        Me.Controls.Add(Me.panelAgregar)
        Me.Controls.Add(Me.panelBuscar)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SurtirProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Compra"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnVolverCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSiguienteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAgregar.ResumeLayout(False)
        Me.panelAgregar.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolverBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBuscar.ResumeLayout(False)
        Me.panelBuscar.PerformLayout()
        Me.panelSurtido.ResumeLayout(False)
        Me.panelSurtido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtImporteCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFinalizarSurtido As System.Windows.Forms.Button
    Friend WithEvents btnOtraCompra As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents btnAgregar As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVolverCompra As System.Windows.Forms.PictureBox
    Friend WithEvents btnSiguienteCompra As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumProducto As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGanancia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tmrMostrarBuscar As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarBuscar As System.Windows.Forms.Timer
    Friend WithEvents tmrMostrarAgregar As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarAgregar As System.Windows.Forms.Timer
    Friend WithEvents panelAgregar As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoProd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxMedida As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidadUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCerrarAgregar As System.Windows.Forms.Button
    Public WithEvents dgvProductos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtBuscarProductos As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolverBusqueda As System.Windows.Forms.PictureBox
    Friend WithEvents btnAnotarBusqueda As System.Windows.Forms.Button
    Friend WithEvents panelBuscar As System.Windows.Forms.Panel
    Friend WithEvents panelSurtido As System.Windows.Forms.Panel
    Friend WithEvents txtGananciaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCostoIngreso As System.Windows.Forms.TextBox
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtVentaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents lblVenta As System.Windows.Forms.Label
    Friend WithEvents lblAyudaCampos As System.Windows.Forms.Label
End Class
