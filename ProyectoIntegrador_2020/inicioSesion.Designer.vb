<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicioSesion))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.txtContraseñaLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuarioLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkCrearUsuario = New System.Windows.Forms.LinkLabel()
        Me.lblCheckUsuario = New System.Windows.Forms.Label()
        Me.chbGuardarUsuario = New System.Windows.Forms.CheckBox()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.pbEsconder = New System.Windows.Forms.PictureBox()
        Me.pbMostrar = New System.Windows.Forms.PictureBox()
        Me.panelRegistro = New System.Windows.Forms.Panel()
        Me.lblAceptable2 = New System.Windows.Forms.Label()
        Me.lblAceptable1 = New System.Windows.Forms.Label()
        Me.pbRegresar = New System.Windows.Forms.PictureBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtClaveAdminRegistro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRepContraseñaRegistro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContraseñaRegistro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuarioRegistro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpAdmin = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin.SuspendLayout()
        CType(Me.pbEsconder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegistro.SuspendLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Controls.Add(Me.btnMinimizar)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(402, 40)
        Me.panelTitulo.TabIndex = 10
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(198, 18)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Iniciar Sesión  |  El Cofre"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Location = New System.Drawing.Point(325, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 34)
        Me.btnMinimizar.TabIndex = 21
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimizar.UseVisualStyleBackColor = True
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
        Me.btnCerrar.Location = New System.Drawing.Point(365, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(148, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(83, 364)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(202, 62)
        Me.btnEntrar.TabIndex = 12
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'txtContraseñaLogin
        '
        Me.txtContraseñaLogin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtContraseñaLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtContraseñaLogin.Location = New System.Drawing.Point(83, 268)
        Me.txtContraseñaLogin.Name = "txtContraseñaLogin"
        Me.txtContraseñaLogin.Size = New System.Drawing.Size(202, 26)
        Me.txtContraseñaLogin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(64, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña"
        '
        'txtUsuarioLogin
        '
        Me.txtUsuarioLogin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUsuarioLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtUsuarioLogin.Location = New System.Drawing.Point(83, 160)
        Me.txtUsuarioLogin.MaxLength = 30
        Me.txtUsuarioLogin.Name = "txtUsuarioLogin"
        Me.txtUsuarioLogin.Size = New System.Drawing.Size(202, 26)
        Me.txtUsuarioLogin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(39, 445)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 1)
        Me.Panel1.TabIndex = 14
        '
        'linkCrearUsuario
        '
        Me.linkCrearUsuario.ActiveLinkColor = System.Drawing.Color.Turquoise
        Me.linkCrearUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.linkCrearUsuario.AutoSize = True
        Me.linkCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkCrearUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.linkCrearUsuario.LinkColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.linkCrearUsuario.Location = New System.Drawing.Point(36, 470)
        Me.linkCrearUsuario.Name = "linkCrearUsuario"
        Me.linkCrearUsuario.Size = New System.Drawing.Size(91, 16)
        Me.linkCrearUsuario.TabIndex = 15
        Me.linkCrearUsuario.TabStop = True
        Me.linkCrearUsuario.Text = "Crear Usuario"
        '
        'lblCheckUsuario
        '
        Me.lblCheckUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCheckUsuario.AutoSize = True
        Me.lblCheckUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblCheckUsuario.Location = New System.Drawing.Point(104, 321)
        Me.lblCheckUsuario.Name = "lblCheckUsuario"
        Me.lblCheckUsuario.Size = New System.Drawing.Size(112, 16)
        Me.lblCheckUsuario.TabIndex = 17
        Me.lblCheckUsuario.Text = "Recordar usuario"
        '
        'chbGuardarUsuario
        '
        Me.chbGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chbGuardarUsuario.AutoSize = True
        Me.chbGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chbGuardarUsuario.Location = New System.Drawing.Point(83, 321)
        Me.chbGuardarUsuario.Name = "chbGuardarUsuario"
        Me.chbGuardarUsuario.Size = New System.Drawing.Size(15, 14)
        Me.chbGuardarUsuario.TabIndex = 18
        Me.chbGuardarUsuario.UseVisualStyleBackColor = True
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLogin.Controls.Add(Me.pbEsconder)
        Me.panelLogin.Controls.Add(Me.pbMostrar)
        Me.panelLogin.Controls.Add(Me.PictureBox1)
        Me.panelLogin.Controls.Add(Me.chbGuardarUsuario)
        Me.panelLogin.Controls.Add(Me.Label1)
        Me.panelLogin.Controls.Add(Me.lblCheckUsuario)
        Me.panelLogin.Controls.Add(Me.txtUsuarioLogin)
        Me.panelLogin.Controls.Add(Me.Label2)
        Me.panelLogin.Controls.Add(Me.linkCrearUsuario)
        Me.panelLogin.Controls.Add(Me.txtContraseñaLogin)
        Me.panelLogin.Controls.Add(Me.Panel1)
        Me.panelLogin.Controls.Add(Me.btnEntrar)
        Me.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin.Location = New System.Drawing.Point(0, 40)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(402, 513)
        Me.panelLogin.TabIndex = 19
        '
        'pbEsconder
        '
        Me.pbEsconder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEsconder.Image = CType(resources.GetObject("pbEsconder.Image"), System.Drawing.Image)
        Me.pbEsconder.Location = New System.Drawing.Point(305, 268)
        Me.pbEsconder.Name = "pbEsconder"
        Me.pbEsconder.Size = New System.Drawing.Size(27, 27)
        Me.pbEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEsconder.TabIndex = 20
        Me.pbEsconder.TabStop = False
        Me.pbEsconder.Visible = False
        '
        'pbMostrar
        '
        Me.pbMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMostrar.Image = CType(resources.GetObject("pbMostrar.Image"), System.Drawing.Image)
        Me.pbMostrar.Location = New System.Drawing.Point(305, 268)
        Me.pbMostrar.Name = "pbMostrar"
        Me.pbMostrar.Size = New System.Drawing.Size(27, 27)
        Me.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMostrar.TabIndex = 19
        Me.pbMostrar.TabStop = False
        '
        'panelRegistro
        '
        Me.panelRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.panelRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRegistro.Controls.Add(Me.lblAceptable2)
        Me.panelRegistro.Controls.Add(Me.lblAceptable1)
        Me.panelRegistro.Controls.Add(Me.pbRegresar)
        Me.panelRegistro.Controls.Add(Me.btnRegistrar)
        Me.panelRegistro.Controls.Add(Me.txtClaveAdminRegistro)
        Me.panelRegistro.Controls.Add(Me.Label8)
        Me.panelRegistro.Controls.Add(Me.txtRepContraseñaRegistro)
        Me.panelRegistro.Controls.Add(Me.Label7)
        Me.panelRegistro.Controls.Add(Me.txtContraseñaRegistro)
        Me.panelRegistro.Controls.Add(Me.Label6)
        Me.panelRegistro.Controls.Add(Me.txtUsuarioRegistro)
        Me.panelRegistro.Controls.Add(Me.Label5)
        Me.panelRegistro.Controls.Add(Me.Label4)
        Me.panelRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRegistro.Location = New System.Drawing.Point(0, 40)
        Me.panelRegistro.Name = "panelRegistro"
        Me.panelRegistro.Size = New System.Drawing.Size(402, 513)
        Me.panelRegistro.TabIndex = 19
        Me.panelRegistro.Visible = False
        '
        'lblAceptable2
        '
        Me.lblAceptable2.AutoSize = True
        Me.lblAceptable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAceptable2.ForeColor = System.Drawing.Color.Red
        Me.lblAceptable2.Location = New System.Drawing.Point(304, 324)
        Me.lblAceptable2.Name = "lblAceptable2"
        Me.lblAceptable2.Size = New System.Drawing.Size(27, 25)
        Me.lblAceptable2.TabIndex = 12
        Me.lblAceptable2.Tag = ""
        Me.lblAceptable2.Text = "X"
        Me.lblAceptable2.Visible = False
        '
        'lblAceptable1
        '
        Me.lblAceptable1.AutoSize = True
        Me.lblAceptable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAceptable1.ForeColor = System.Drawing.Color.Red
        Me.lblAceptable1.Location = New System.Drawing.Point(304, 235)
        Me.lblAceptable1.Name = "lblAceptable1"
        Me.lblAceptable1.Size = New System.Drawing.Size(27, 25)
        Me.lblAceptable1.TabIndex = 11
        Me.lblAceptable1.Tag = ""
        Me.lblAceptable1.Text = "X"
        Me.lblAceptable1.Visible = False
        '
        'pbRegresar
        '
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Image = CType(resources.GetObject("pbRegresar.Image"), System.Drawing.Image)
        Me.pbRegresar.Location = New System.Drawing.Point(12, 462)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(31, 32)
        Me.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRegresar.TabIndex = 10
        Me.pbRegresar.TabStop = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(278, 451)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(112, 44)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtClaveAdminRegistro
        '
        Me.txtClaveAdminRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveAdminRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtClaveAdminRegistro.Location = New System.Drawing.Point(83, 408)
        Me.txtClaveAdminRegistro.MaxLength = 30
        Me.txtClaveAdminRegistro.Name = "txtClaveAdminRegistro"
        Me.txtClaveAdminRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAdminRegistro.Size = New System.Drawing.Size(215, 26)
        Me.txtClaveAdminRegistro.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(34, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Clave de admin"
        '
        'txtRepContraseñaRegistro
        '
        Me.txtRepContraseñaRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepContraseñaRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtRepContraseñaRegistro.Location = New System.Drawing.Point(83, 324)
        Me.txtRepContraseñaRegistro.MaxLength = 30
        Me.txtRepContraseñaRegistro.Name = "txtRepContraseñaRegistro"
        Me.txtRepContraseñaRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepContraseñaRegistro.Size = New System.Drawing.Size(215, 26)
        Me.txtRepContraseñaRegistro.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(34, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Repetir contraseña"
        '
        'txtContraseñaRegistro
        '
        Me.txtContraseñaRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtContraseñaRegistro.Location = New System.Drawing.Point(83, 234)
        Me.txtContraseñaRegistro.MaxLength = 30
        Me.txtContraseñaRegistro.Name = "txtContraseñaRegistro"
        Me.txtContraseñaRegistro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaRegistro.Size = New System.Drawing.Size(215, 26)
        Me.txtContraseñaRegistro.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(34, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Contraseña"
        '
        'txtUsuarioRegistro
        '
        Me.txtUsuarioRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtUsuarioRegistro.Location = New System.Drawing.Point(83, 143)
        Me.txtUsuarioRegistro.MaxLength = 30
        Me.txtUsuarioRegistro.Name = "txtUsuarioRegistro"
        Me.txtUsuarioRegistro.Size = New System.Drawing.Size(215, 26)
        Me.txtUsuarioRegistro.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(34, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nombre de usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(356, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CREAR USUARIO ADMIN"
        '
        'inicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(402, 553)
        Me.Controls.Add(Me.panelRegistro)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "inicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.pbEsconder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegistro.ResumeLayout(False)
        Me.panelRegistro.PerformLayout()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents txtContraseñaLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents linkCrearUsuario As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCheckUsuario As System.Windows.Forms.Label
    Friend WithEvents chbGuardarUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents panelLogin As System.Windows.Forms.Panel
    Friend WithEvents panelRegistro As System.Windows.Forms.Panel
    Friend WithEvents txtContraseñaRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtClaveAdminRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRepContraseñaRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents lblAceptable2 As System.Windows.Forms.Label
    Friend WithEvents lblAceptable1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents pbEsconder As System.Windows.Forms.PictureBox
    Friend WithEvents pbMostrar As System.Windows.Forms.PictureBox
    Friend WithEvents ttpAdmin As System.Windows.Forms.ToolTip
End Class
