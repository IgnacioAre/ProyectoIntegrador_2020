﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.lblTituloVentana = New System.Windows.Forms.Label()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.tmrGif = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnEstadistica = New System.Windows.Forms.PictureBox()
        Me.panelControles = New System.Windows.Forms.Panel()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnInforme = New System.Windows.Forms.Button()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.submenuProveedores = New System.Windows.Forms.Panel()
        Me.btnGestionarProveedor = New System.Windows.Forms.Button()
        Me.btnExploradorProveedores = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.submenuClientes = New System.Windows.Forms.Panel()
        Me.btnCuentaCorrienteClientes = New System.Windows.Forms.Button()
        Me.btnExploradorClientes = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.pbCerrarSesion = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.panelAvisoStock = New System.Windows.Forms.Panel()
        Me.btnOcultarAvisoNegro = New System.Windows.Forms.PictureBox()
        Me.lblAvisoStock = New System.Windows.Forms.Label()
        Me.panelAbout = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrarInfo = New System.Windows.Forms.Button()
        Me.dgvPreciosRapidos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioProductos = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.imgCofre = New System.Windows.Forms.PictureBox()
        Me.gifCofre = New System.Windows.Forms.PictureBox()
        Me.tmrHoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarSubMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarSubMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarAbout = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarAbout = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarAviso = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.panelSuperior.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        CType(Me.btnEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControles.SuspendLayout()
        Me.submenuProveedores.SuspendLayout()
        Me.submenuClientes.SuspendLayout()
        CType(Me.pbCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.panelAvisoStock.SuspendLayout()
        CType(Me.btnOcultarAvisoNegro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAbout.SuspendLayout()
        CType(Me.dgvPreciosRapidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCofre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gifCofre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelSuperior.Controls.Add(Me.lblTituloVentana)
        Me.panelSuperior.Controls.Add(Me.btnAyuda)
        Me.panelSuperior.Controls.Add(Me.btnMinimizar)
        Me.panelSuperior.Controls.Add(Me.btnCerrar)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1038, 34)
        Me.panelSuperior.TabIndex = 2
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.AutoSize = True
        Me.lblTituloVentana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.Color.White
        Me.lblTituloVentana.Location = New System.Drawing.Point(206, 5)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(126, 20)
        Me.lblTituloVentana.TabIndex = 5
        Me.lblTituloVentana.Text = "Menú Principal"
        '
        'btnAyuda
        '
        Me.btnAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.Location = New System.Drawing.Point(930, 0)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(32, 33)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(968, 1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(32, 33)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1006, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 33)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
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
        Me.tmrGif.Interval = 5550
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnEstadistica)
        Me.panelMenu.Controls.Add(Me.panelControles)
        Me.panelMenu.Controls.Add(Me.pbCerrarSesion)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Controls.Add(Me.imgLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 34)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(210, 707)
        Me.panelMenu.TabIndex = 2
        '
        'btnEstadistica
        '
        Me.btnEstadistica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEstadistica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstadistica.Image = CType(resources.GetObject("btnEstadistica.Image"), System.Drawing.Image)
        Me.btnEstadistica.Location = New System.Drawing.Point(158, 654)
        Me.btnEstadistica.Name = "btnEstadistica"
        Me.btnEstadistica.Size = New System.Drawing.Size(50, 50)
        Me.btnEstadistica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnEstadistica.TabIndex = 12
        Me.btnEstadistica.TabStop = False
        '
        'panelControles
        '
        Me.panelControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelControles.AutoScroll = True
        Me.panelControles.Controls.Add(Me.btnBackup)
        Me.panelControles.Controls.Add(Me.btnInforme)
        Me.panelControles.Controls.Add(Me.btnNotas)
        Me.panelControles.Controls.Add(Me.btnProductos)
        Me.panelControles.Controls.Add(Me.submenuProveedores)
        Me.panelControles.Controls.Add(Me.btnProveedores)
        Me.panelControles.Controls.Add(Me.submenuClientes)
        Me.panelControles.Controls.Add(Me.btnClientes)
        Me.panelControles.Controls.Add(Me.btnInicio)
        Me.panelControles.Location = New System.Drawing.Point(3, 146)
        Me.panelControles.Name = "panelControles"
        Me.panelControles.Size = New System.Drawing.Size(205, 419)
        Me.panelControles.TabIndex = 11
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(0, 546)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnBackup.Size = New System.Drawing.Size(188, 54)
        Me.btnBackup.TabIndex = 28
        Me.btnBackup.Text = "    Backup"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnInforme
        '
        Me.btnInforme.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnInforme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInforme.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInforme.FlatAppearance.BorderSize = 0
        Me.btnInforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInforme.ForeColor = System.Drawing.Color.White
        Me.btnInforme.Image = CType(resources.GetObject("btnInforme.Image"), System.Drawing.Image)
        Me.btnInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInforme.Location = New System.Drawing.Point(0, 492)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnInforme.Size = New System.Drawing.Size(188, 54)
        Me.btnInforme.TabIndex = 27
        Me.btnInforme.Text = "    Informes"
        Me.btnInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInforme.UseVisualStyleBackColor = False
        '
        'btnNotas
        '
        Me.btnNotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnNotas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNotas.FlatAppearance.BorderSize = 0
        Me.btnNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotas.ForeColor = System.Drawing.Color.White
        Me.btnNotas.Image = CType(resources.GetObject("btnNotas.Image"), System.Drawing.Image)
        Me.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotas.Location = New System.Drawing.Point(0, 438)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnNotas.Size = New System.Drawing.Size(188, 54)
        Me.btnNotas.TabIndex = 26
        Me.btnNotas.Text = " Notas"
        Me.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotas.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 384)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(188, 54)
        Me.btnProductos.TabIndex = 24
        Me.btnProductos.Text = " Productos"
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'submenuProveedores
        '
        Me.submenuProveedores.BackColor = System.Drawing.Color.White
        Me.submenuProveedores.Controls.Add(Me.btnGestionarProveedor)
        Me.submenuProveedores.Controls.Add(Me.btnExploradorProveedores)
        Me.submenuProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuProveedores.Location = New System.Drawing.Point(0, 273)
        Me.submenuProveedores.Name = "submenuProveedores"
        Me.submenuProveedores.Size = New System.Drawing.Size(188, 111)
        Me.submenuProveedores.TabIndex = 22
        Me.submenuProveedores.Visible = False
        '
        'btnGestionarProveedor
        '
        Me.btnGestionarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGestionarProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionarProveedor.FlatAppearance.BorderSize = 0
        Me.btnGestionarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnGestionarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnGestionarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionarProveedor.ForeColor = System.Drawing.Color.White
        Me.btnGestionarProveedor.Image = CType(resources.GetObject("btnGestionarProveedor.Image"), System.Drawing.Image)
        Me.btnGestionarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionarProveedor.Location = New System.Drawing.Point(3, 54)
        Me.btnGestionarProveedor.Name = "btnGestionarProveedor"
        Me.btnGestionarProveedor.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnGestionarProveedor.Size = New System.Drawing.Size(204, 54)
        Me.btnGestionarProveedor.TabIndex = 5
        Me.btnGestionarProveedor.Text = " Cuenta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Corriente"
        Me.btnGestionarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGestionarProveedor.UseVisualStyleBackColor = False
        '
        'btnExploradorProveedores
        '
        Me.btnExploradorProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnExploradorProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExploradorProveedores.FlatAppearance.BorderSize = 0
        Me.btnExploradorProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnExploradorProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExploradorProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExploradorProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExploradorProveedores.ForeColor = System.Drawing.Color.White
        Me.btnExploradorProveedores.Image = CType(resources.GetObject("btnExploradorProveedores.Image"), System.Drawing.Image)
        Me.btnExploradorProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExploradorProveedores.Location = New System.Drawing.Point(3, 0)
        Me.btnExploradorProveedores.Name = "btnExploradorProveedores"
        Me.btnExploradorProveedores.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.btnExploradorProveedores.Size = New System.Drawing.Size(204, 54)
        Me.btnExploradorProveedores.TabIndex = 4
        Me.btnExploradorProveedores.Text = " Explorador de Proveedores"
        Me.btnExploradorProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExploradorProveedores.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 219)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(188, 54)
        Me.btnProveedores.TabIndex = 17
        Me.btnProveedores.Text = " Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'submenuClientes
        '
        Me.submenuClientes.BackColor = System.Drawing.Color.White
        Me.submenuClientes.Controls.Add(Me.btnCuentaCorrienteClientes)
        Me.submenuClientes.Controls.Add(Me.btnExploradorClientes)
        Me.submenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuClientes.Location = New System.Drawing.Point(0, 108)
        Me.submenuClientes.Name = "submenuClientes"
        Me.submenuClientes.Size = New System.Drawing.Size(188, 111)
        Me.submenuClientes.TabIndex = 16
        Me.submenuClientes.Visible = False
        '
        'btnCuentaCorrienteClientes
        '
        Me.btnCuentaCorrienteClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCuentaCorrienteClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuentaCorrienteClientes.FlatAppearance.BorderSize = 0
        Me.btnCuentaCorrienteClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCuentaCorrienteClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCuentaCorrienteClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaCorrienteClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaCorrienteClientes.ForeColor = System.Drawing.Color.White
        Me.btnCuentaCorrienteClientes.Image = CType(resources.GetObject("btnCuentaCorrienteClientes.Image"), System.Drawing.Image)
        Me.btnCuentaCorrienteClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentaCorrienteClientes.Location = New System.Drawing.Point(3, 54)
        Me.btnCuentaCorrienteClientes.Name = "btnCuentaCorrienteClientes"
        Me.btnCuentaCorrienteClientes.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnCuentaCorrienteClientes.Size = New System.Drawing.Size(204, 54)
        Me.btnCuentaCorrienteClientes.TabIndex = 5
        Me.btnCuentaCorrienteClientes.Text = " Cuenta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Corriente"
        Me.btnCuentaCorrienteClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCuentaCorrienteClientes.UseVisualStyleBackColor = False
        '
        'btnExploradorClientes
        '
        Me.btnExploradorClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnExploradorClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExploradorClientes.FlatAppearance.BorderSize = 0
        Me.btnExploradorClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnExploradorClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExploradorClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExploradorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExploradorClientes.ForeColor = System.Drawing.Color.White
        Me.btnExploradorClientes.Image = CType(resources.GetObject("btnExploradorClientes.Image"), System.Drawing.Image)
        Me.btnExploradorClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExploradorClientes.Location = New System.Drawing.Point(3, 0)
        Me.btnExploradorClientes.Name = "btnExploradorClientes"
        Me.btnExploradorClientes.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.btnExploradorClientes.Size = New System.Drawing.Size(204, 57)
        Me.btnExploradorClientes.TabIndex = 4
        Me.btnExploradorClientes.Text = " Explorador de Clientes"
        Me.btnExploradorClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExploradorClientes.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 54)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(188, 54)
        Me.btnClientes.TabIndex = 15
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnInicio.Size = New System.Drawing.Size(188, 54)
        Me.btnInicio.TabIndex = 14
        Me.btnInicio.Text = "     Inicio"
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'pbCerrarSesion
        '
        Me.pbCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCerrarSesion.Image = CType(resources.GetObject("pbCerrarSesion.Image"), System.Drawing.Image)
        Me.pbCerrarSesion.Location = New System.Drawing.Point(6, 660)
        Me.pbCerrarSesion.Name = "pbCerrarSesion"
        Me.pbCerrarSesion.Size = New System.Drawing.Size(36, 35)
        Me.pbCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCerrarSesion.TabIndex = 8
        Me.pbCerrarSesion.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(156, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(51, 46)
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
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Window
        Me.PanelContenedor.Controls.Add(Me.panelAvisoStock)
        Me.PanelContenedor.Controls.Add(Me.panelAbout)
        Me.PanelContenedor.Controls.Add(Me.dgvPreciosRapidos)
        Me.PanelContenedor.Controls.Add(Me.Label2)
        Me.PanelContenedor.Controls.Add(Me.txtPrecioProductos)
        Me.PanelContenedor.Controls.Add(Me.lblFecha)
        Me.PanelContenedor.Controls.Add(Me.lblHora)
        Me.PanelContenedor.Controls.Add(Me.lblBienvenida)
        Me.PanelContenedor.Controls.Add(Me.imgCofre)
        Me.PanelContenedor.Controls.Add(Me.gifCofre)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(210, 34)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(828, 707)
        Me.PanelContenedor.TabIndex = 3
        '
        'panelAvisoStock
        '
        Me.panelAvisoStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelAvisoStock.BackColor = System.Drawing.Color.Yellow
        Me.panelAvisoStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAvisoStock.Controls.Add(Me.btnOcultarAvisoNegro)
        Me.panelAvisoStock.Controls.Add(Me.lblAvisoStock)
        Me.panelAvisoStock.Location = New System.Drawing.Point(239, 607)
        Me.panelAvisoStock.Name = "panelAvisoStock"
        Me.panelAvisoStock.Size = New System.Drawing.Size(589, 100)
        Me.panelAvisoStock.TabIndex = 35
        '
        'btnOcultarAvisoNegro
        '
        Me.btnOcultarAvisoNegro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarAvisoNegro.Image = CType(resources.GetObject("btnOcultarAvisoNegro.Image"), System.Drawing.Image)
        Me.btnOcultarAvisoNegro.Location = New System.Drawing.Point(549, 3)
        Me.btnOcultarAvisoNegro.Name = "btnOcultarAvisoNegro"
        Me.btnOcultarAvisoNegro.Size = New System.Drawing.Size(32, 32)
        Me.btnOcultarAvisoNegro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnOcultarAvisoNegro.TabIndex = 36
        Me.btnOcultarAvisoNegro.TabStop = False
        '
        'lblAvisoStock
        '
        Me.lblAvisoStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvisoStock.AutoSize = True
        Me.lblAvisoStock.BackColor = System.Drawing.Color.Yellow
        Me.lblAvisoStock.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisoStock.ForeColor = System.Drawing.Color.Black
        Me.lblAvisoStock.Location = New System.Drawing.Point(36, 36)
        Me.lblAvisoStock.Name = "lblAvisoStock"
        Me.lblAvisoStock.Size = New System.Drawing.Size(514, 24)
        Me.lblAvisoStock.TabIndex = 34
        Me.lblAvisoStock.Text = "Tienes 2 productos por debajo del limite de stock." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'panelAbout
        '
        Me.panelAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.panelAbout.Controls.Add(Me.Label5)
        Me.panelAbout.Controls.Add(Me.Label4)
        Me.panelAbout.Controls.Add(Me.Label3)
        Me.panelAbout.Controls.Add(Me.Label1)
        Me.panelAbout.Controls.Add(Me.btnCerrarInfo)
        Me.panelAbout.Location = New System.Drawing.Point(279, 0)
        Me.panelAbout.Name = "panelAbout"
        Me.panelAbout.Size = New System.Drawing.Size(549, 704)
        Me.panelAbout.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(509, 240)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(163, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Acerca de nosotros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(478, 216)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(203, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "About us"
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
        Me.btnCerrarInfo.Location = New System.Drawing.Point(15, 6)
        Me.btnCerrarInfo.Name = "btnCerrarInfo"
        Me.btnCerrarInfo.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrarInfo.TabIndex = 18
        Me.btnCerrarInfo.Text = "X"
        Me.btnCerrarInfo.UseVisualStyleBackColor = False
        '
        'dgvPreciosRapidos
        '
        Me.dgvPreciosRapidos.AllowUserToAddRows = False
        Me.dgvPreciosRapidos.AllowUserToDeleteRows = False
        Me.dgvPreciosRapidos.AllowUserToResizeColumns = False
        Me.dgvPreciosRapidos.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvPreciosRapidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPreciosRapidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPreciosRapidos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPreciosRapidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPreciosRapidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPreciosRapidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPreciosRapidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPreciosRapidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPreciosRapidos.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPreciosRapidos.EnableHeadersVisualStyles = False
        Me.dgvPreciosRapidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvPreciosRapidos.Location = New System.Drawing.Point(38, 97)
        Me.dgvPreciosRapidos.Name = "dgvPreciosRapidos"
        Me.dgvPreciosRapidos.ReadOnly = True
        Me.dgvPreciosRapidos.RowHeadersVisible = False
        Me.dgvPreciosRapidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreciosRapidos.Size = New System.Drawing.Size(327, 138)
        Me.dgvPreciosRapidos.TabIndex = 12
        Me.dgvPreciosRapidos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightBlue
        Me.dgvPreciosRapidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvPreciosRapidos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPreciosRapidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPreciosRapidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPreciosRapidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPreciosRapidos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPreciosRapidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvPreciosRapidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvPreciosRapidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPreciosRapidos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvPreciosRapidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPreciosRapidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPreciosRapidos.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvPreciosRapidos.ThemeStyle.ReadOnly = True
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.Height = 22
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvPreciosRapidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPreciosRapidos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "¿Qué precio necesita?"
        '
        'txtPrecioProductos
        '
        Me.txtPrecioProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtPrecioProductos.Location = New System.Drawing.Point(38, 69)
        Me.txtPrecioProductos.Name = "txtPrecioProductos"
        Me.txtPrecioProductos.Size = New System.Drawing.Size(190, 26)
        Me.txtPrecioProductos.TabIndex = 9
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(723, 42)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(89, 20)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "30/06/2020"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(694, 6)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(127, 33)
        Me.lblHora.TabIndex = 7
        Me.lblHora.Text = "19:44:23"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(275, 202)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(0, 33)
        Me.lblBienvenida.TabIndex = 4
        '
        'imgCofre
        '
        Me.imgCofre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgCofre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCofre.Image = CType(resources.GetObject("imgCofre.Image"), System.Drawing.Image)
        Me.imgCofre.Location = New System.Drawing.Point(269, 282)
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
        Me.gifCofre.Location = New System.Drawing.Point(266, 282)
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
        'tmrMostrarAbout
        '
        Me.tmrMostrarAbout.Interval = 1
        '
        'tmrOcultarAbout
        '
        Me.tmrOcultarAbout.Interval = 1
        '
        'tmrOcultarAviso
        '
        Me.tmrOcultarAviso.Interval = 1
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
        Me.panelSuperior.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.btnEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControles.ResumeLayout(False)
        Me.submenuProveedores.ResumeLayout(False)
        Me.submenuClientes.ResumeLayout(False)
        CType(Me.pbCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.panelAvisoStock.ResumeLayout(False)
        Me.panelAvisoStock.PerformLayout()
        CType(Me.btnOcultarAvisoNegro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAbout.ResumeLayout(False)
        Me.panelAbout.PerformLayout()
        CType(Me.dgvPreciosRapidos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents tmrHoraFecha As System.Windows.Forms.Timer
    Friend WithEvents lblBienvenida As System.Windows.Forms.Label
    Friend WithEvents imgCofre As System.Windows.Forms.PictureBox
    Friend WithEvents gifCofre As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents txtPrecioProductos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents pbCerrarSesion As System.Windows.Forms.PictureBox
    Friend WithEvents panelControles As System.Windows.Forms.Panel
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents submenuClientes As System.Windows.Forms.Panel
    Friend WithEvents btnCuentaCorrienteClientes As System.Windows.Forms.Button
    Friend WithEvents btnExploradorClientes As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnNotas As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents submenuProveedores As System.Windows.Forms.Panel
    Friend WithEvents btnGestionarProveedor As System.Windows.Forms.Button
    Friend WithEvents btnExploradorProveedores As System.Windows.Forms.Button
    Friend WithEvents tmrMostrarSubMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarSubMenu As System.Windows.Forms.Timer
    Friend WithEvents dgvPreciosRapidos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents lblTituloVentana As System.Windows.Forms.Label
    Friend WithEvents panelAbout As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrarInfo As System.Windows.Forms.Button
    Friend WithEvents tmrMostrarAbout As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarAbout As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEstadistica As System.Windows.Forms.PictureBox
    Friend WithEvents tmrOcultarAviso As System.Windows.Forms.Timer
    Friend WithEvents lblAvisoStock As System.Windows.Forms.Label
    Friend WithEvents panelAvisoStock As System.Windows.Forms.Panel
    Friend WithEvents btnOcultarAvisoNegro As System.Windows.Forms.PictureBox
    Friend WithEvents btnInforme As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
