<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.tmrGif = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelControles = New System.Windows.Forms.Panel()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.submenuProductos = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.submenuProveedores = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.submenuClientes = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.pbConfiguracion = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioProductos = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgCofre = New System.Windows.Forms.PictureBox()
        Me.gifCofre = New System.Windows.Forms.PictureBox()
        Me.tmrHoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarSubMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarSubMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelSuperior.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        Me.panelControles.SuspendLayout()
        Me.submenuProductos.SuspendLayout()
        Me.submenuProveedores.SuspendLayout()
        Me.submenuClientes.SuspendLayout()
        CType(Me.pbConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.imgCofre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gifCofre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.Black
        Me.panelSuperior.Controls.Add(Me.btnRestaurar)
        Me.panelSuperior.Controls.Add(Me.btnMaximizar)
        Me.panelSuperior.Controls.Add(Me.btnAyuda)
        Me.panelSuperior.Controls.Add(Me.btnMinimizar)
        Me.panelSuperior.Controls.Add(Me.btnCerrar)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1038, 34)
        Me.panelSuperior.TabIndex = 2
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRestaurar.ForeColor = System.Drawing.Color.White
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(971, 3)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 30)
        Me.btnRestaurar.TabIndex = 4
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaximizar.ForeColor = System.Drawing.Color.White
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(971, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMaximizar.TabIndex = 3
        Me.btnMaximizar.UseVisualStyleBackColor = True
        Me.btnMaximizar.Visible = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAyuda.BackColor = System.Drawing.Color.Black
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.Location = New System.Drawing.Point(901, 2)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(30, 30)
        Me.btnAyuda.TabIndex = 2
        Me.btnAyuda.Text = "?"
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Location = New System.Drawing.Point(936, 2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1006, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(-37, 0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(277, 212)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 2
        Me.imgLogo.TabStop = False
        '
        'tmrGif
        '
        Me.tmrGif.Enabled = True
        Me.tmrGif.Interval = 5600
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.Black
        Me.panelMenu.Controls.Add(Me.panelControles)
        Me.panelMenu.Controls.Add(Me.pbConfiguracion)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Controls.Add(Me.imgLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 34)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(236, 707)
        Me.panelMenu.TabIndex = 2
        '
        'panelControles
        '
        Me.panelControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelControles.AutoScroll = True
        Me.panelControles.Controls.Add(Me.btnNotas)
        Me.panelControles.Controls.Add(Me.submenuProductos)
        Me.panelControles.Controls.Add(Me.btnProductos)
        Me.panelControles.Controls.Add(Me.submenuProveedores)
        Me.panelControles.Controls.Add(Me.btnProveedores)
        Me.panelControles.Controls.Add(Me.submenuClientes)
        Me.panelControles.Controls.Add(Me.btnClientes)
        Me.panelControles.Controls.Add(Me.btnInicio)
        Me.panelControles.Location = New System.Drawing.Point(3, 146)
        Me.panelControles.Name = "panelControles"
        Me.panelControles.Size = New System.Drawing.Size(233, 511)
        Me.panelControles.TabIndex = 11
        '
        'btnNotas
        '
        Me.btnNotas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNotas.FlatAppearance.BorderSize = 0
        Me.btnNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotas.ForeColor = System.Drawing.Color.White
        Me.btnNotas.Image = CType(resources.GetObject("btnNotas.Image"), System.Drawing.Image)
        Me.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotas.Location = New System.Drawing.Point(0, 549)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnNotas.Size = New System.Drawing.Size(216, 54)
        Me.btnNotas.TabIndex = 26
        Me.btnNotas.Text = " Notas"
        Me.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'submenuProductos
        '
        Me.submenuProductos.BackColor = System.Drawing.Color.White
        Me.submenuProductos.Controls.Add(Me.Button6)
        Me.submenuProductos.Controls.Add(Me.Button7)
        Me.submenuProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuProductos.Location = New System.Drawing.Point(0, 438)
        Me.submenuProductos.Name = "submenuProductos"
        Me.submenuProductos.Size = New System.Drawing.Size(216, 111)
        Me.submenuProductos.TabIndex = 25
        Me.submenuProductos.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(3, 54)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(230, 54)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = " Gestionar"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(3, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(230, 57)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = " Listado"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 384)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(216, 54)
        Me.btnProductos.TabIndex = 24
        Me.btnProductos.Text = " Productos"
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'submenuProveedores
        '
        Me.submenuProveedores.BackColor = System.Drawing.Color.White
        Me.submenuProveedores.Controls.Add(Me.Button4)
        Me.submenuProveedores.Controls.Add(Me.Button5)
        Me.submenuProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuProveedores.Location = New System.Drawing.Point(0, 273)
        Me.submenuProveedores.Name = "submenuProveedores"
        Me.submenuProveedores.Size = New System.Drawing.Size(216, 111)
        Me.submenuProveedores.TabIndex = 22
        Me.submenuProveedores.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 54)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(230, 54)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = " Gestionar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(230, 57)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = " Nuevo"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 219)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(216, 54)
        Me.btnProveedores.TabIndex = 17
        Me.btnProveedores.Text = " Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'submenuClientes
        '
        Me.submenuClientes.BackColor = System.Drawing.Color.White
        Me.submenuClientes.Controls.Add(Me.Button3)
        Me.submenuClientes.Controls.Add(Me.Button1)
        Me.submenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuClientes.Location = New System.Drawing.Point(0, 108)
        Me.submenuClientes.Name = "submenuClientes"
        Me.submenuClientes.Size = New System.Drawing.Size(216, 111)
        Me.submenuClientes.TabIndex = 16
        Me.submenuClientes.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(230, 54)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = " Gestionar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(230, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = " Nuevo"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 54)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(216, 54)
        Me.btnClientes.TabIndex = 15
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnInicio.Size = New System.Drawing.Size(216, 54)
        Me.btnInicio.TabIndex = 14
        Me.btnInicio.Text = "     Inicio"
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'pbConfiguracion
        '
        Me.pbConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfiguracion.Image = CType(resources.GetObject("pbConfiguracion.Image"), System.Drawing.Image)
        Me.pbConfiguracion.Location = New System.Drawing.Point(12, 663)
        Me.pbConfiguracion.Name = "pbConfiguracion"
        Me.pbConfiguracion.Size = New System.Drawing.Size(32, 32)
        Me.pbConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbConfiguracion.TabIndex = 8
        Me.pbConfiguracion.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(182, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(42, 46)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.TabStop = False
        '
        'tmrOcultarMenu
        '
        Me.tmrOcultarMenu.Interval = 1
        '
        'tmrMostrarMenu
        '
        Me.tmrMostrarMenu.Interval = 1
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.White
        Me.PanelContenedor.Controls.Add(Me.Label2)
        Me.PanelContenedor.Controls.Add(Me.txtPrecioProductos)
        Me.PanelContenedor.Controls.Add(Me.lblFecha)
        Me.PanelContenedor.Controls.Add(Me.lblHora)
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Controls.Add(Me.imgCofre)
        Me.PanelContenedor.Controls.Add(Me.gifCofre)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(236, 34)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(802, 707)
        Me.PanelContenedor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "¿Qué precio necesita?"
        '
        'txtPrecioProductos
        '
        Me.txtPrecioProductos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProductos.Location = New System.Drawing.Point(38, 69)
        Me.txtPrecioProductos.Name = "txtPrecioProductos"
        Me.txtPrecioProductos.Size = New System.Drawing.Size(190, 27)
        Me.txtPrecioProductos.TabIndex = 9
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(697, 42)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 21)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "30/06/2020"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(668, 6)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(125, 36)
        Me.lblHora.TabIndex = 7
        Me.lblHora.Text = "19:44:23"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "¡Bienvenido Administrador!"
        '
        'imgCofre
        '
        Me.imgCofre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgCofre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCofre.Image = CType(resources.GetObject("imgCofre.Image"), System.Drawing.Image)
        Me.imgCofre.Location = New System.Drawing.Point(256, 282)
        Me.imgCofre.Name = "imgCofre"
        Me.imgCofre.Size = New System.Drawing.Size(249, 188)
        Me.imgCofre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCofre.TabIndex = 6
        Me.imgCofre.TabStop = False
        Me.imgCofre.Visible = False
        '
        'gifCofre
        '
        Me.gifCofre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gifCofre.Image = CType(resources.GetObject("gifCofre.Image"), System.Drawing.Image)
        Me.gifCofre.Location = New System.Drawing.Point(253, 282)
        Me.gifCofre.Name = "gifCofre"
        Me.gifCofre.Size = New System.Drawing.Size(255, 192)
        Me.gifCofre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gifCofre.TabIndex = 5
        Me.gifCofre.TabStop = False
        '
        'tmrHoraFecha
        '
        Me.tmrHoraFecha.Enabled = True
        '
        'tmrMostrarSubMenu
        '
        Me.tmrMostrarSubMenu.Interval = 20
        '
        'tmrOcultarSubMenu
        '
        Me.tmrOcultarSubMenu.Interval = 20
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1038, 741)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.Text = "El Cofre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        Me.panelControles.ResumeLayout(False)
        Me.submenuProductos.ResumeLayout(False)
        Me.submenuProveedores.ResumeLayout(False)
        Me.submenuClientes.ResumeLayout(False)
        CType(Me.pbConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.imgCofre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gifCofre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents tmrGif As System.Windows.Forms.Timer
    Friend WithEvents panelMenu As System.Windows.Forms.Panel
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents tmrHoraFecha As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents imgCofre As System.Windows.Forms.PictureBox
    Friend WithEvents gifCofre As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents txtPrecioProductos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents pbConfiguracion As System.Windows.Forms.PictureBox
    Friend WithEvents panelControles As System.Windows.Forms.Panel
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents submenuClientes As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnNotas As System.Windows.Forms.Button
    Friend WithEvents submenuProductos As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents submenuProveedores As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tmrMostrarSubMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarSubMenu As System.Windows.Forms.Timer

End Class
