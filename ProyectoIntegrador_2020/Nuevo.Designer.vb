<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMenosTel4 = New System.Windows.Forms.PictureBox()
        Me.btnMenosTel3 = New System.Windows.Forms.PictureBox()
        Me.btnMenosTel2 = New System.Windows.Forms.PictureBox()
        Me.btnMenosTel1 = New System.Windows.Forms.PictureBox()
        Me.txtTelefono5 = New System.Windows.Forms.TextBox()
        Me.btnMasTel4 = New System.Windows.Forms.PictureBox()
        Me.txtTelefono4 = New System.Windows.Forms.TextBox()
        Me.btnMasTel3 = New System.Windows.Forms.PictureBox()
        Me.txtTelefono3 = New System.Windows.Forms.TextBox()
        Me.btnMasTel2 = New System.Windows.Forms.PictureBox()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.btnMasTel1 = New System.Windows.Forms.PictureBox()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnMenosTel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenosTel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenosTel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenosTel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMasTel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMasTel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMasTel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMasTel1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelTitulo.Size = New System.Drawing.Size(639, 40)
        Me.panelTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(56, 18)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Nuevo"
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
        Me.btnCerrar.Location = New System.Drawing.Point(602, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMenosTel4)
        Me.Panel1.Controls.Add(Me.btnMenosTel3)
        Me.Panel1.Controls.Add(Me.btnMenosTel2)
        Me.Panel1.Controls.Add(Me.btnMenosTel1)
        Me.Panel1.Controls.Add(Me.txtTelefono5)
        Me.Panel1.Controls.Add(Me.btnMasTel4)
        Me.Panel1.Controls.Add(Me.txtTelefono4)
        Me.Panel1.Controls.Add(Me.btnMasTel3)
        Me.Panel1.Controls.Add(Me.txtTelefono3)
        Me.Panel1.Controls.Add(Me.btnMasTel2)
        Me.Panel1.Controls.Add(Me.txtTelefono2)
        Me.Panel1.Controls.Add(Me.btnMasTel1)
        Me.Panel1.Controls.Add(Me.btnRegistrarCliente)
        Me.Panel1.Controls.Add(Me.txtTelefono1)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.lblDireccion)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 386)
        Me.Panel1.TabIndex = 2
        '
        'btnMenosTel4
        '
        Me.btnMenosTel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenosTel4.Image = CType(resources.GetObject("btnMenosTel4.Image"), System.Drawing.Image)
        Me.btnMenosTel4.Location = New System.Drawing.Point(602, 221)
        Me.btnMenosTel4.Name = "btnMenosTel4"
        Me.btnMenosTel4.Size = New System.Drawing.Size(24, 24)
        Me.btnMenosTel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMenosTel4.TabIndex = 22
        Me.btnMenosTel4.TabStop = False
        Me.btnMenosTel4.Visible = False
        '
        'btnMenosTel3
        '
        Me.btnMenosTel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenosTel3.Image = CType(resources.GetObject("btnMenosTel3.Image"), System.Drawing.Image)
        Me.btnMenosTel3.Location = New System.Drawing.Point(602, 174)
        Me.btnMenosTel3.Name = "btnMenosTel3"
        Me.btnMenosTel3.Size = New System.Drawing.Size(24, 24)
        Me.btnMenosTel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMenosTel3.TabIndex = 21
        Me.btnMenosTel3.TabStop = False
        Me.btnMenosTel3.Visible = False
        '
        'btnMenosTel2
        '
        Me.btnMenosTel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenosTel2.Image = CType(resources.GetObject("btnMenosTel2.Image"), System.Drawing.Image)
        Me.btnMenosTel2.Location = New System.Drawing.Point(602, 126)
        Me.btnMenosTel2.Name = "btnMenosTel2"
        Me.btnMenosTel2.Size = New System.Drawing.Size(24, 24)
        Me.btnMenosTel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMenosTel2.TabIndex = 20
        Me.btnMenosTel2.TabStop = False
        Me.btnMenosTel2.Visible = False
        '
        'btnMenosTel1
        '
        Me.btnMenosTel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenosTel1.Image = CType(resources.GetObject("btnMenosTel1.Image"), System.Drawing.Image)
        Me.btnMenosTel1.Location = New System.Drawing.Point(603, 76)
        Me.btnMenosTel1.Name = "btnMenosTel1"
        Me.btnMenosTel1.Size = New System.Drawing.Size(24, 24)
        Me.btnMenosTel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMenosTel1.TabIndex = 19
        Me.btnMenosTel1.TabStop = False
        Me.btnMenosTel1.Visible = False
        '
        'txtTelefono5
        '
        Me.txtTelefono5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono5.Location = New System.Drawing.Point(371, 270)
        Me.txtTelefono5.MaxLength = 15
        Me.txtTelefono5.Name = "txtTelefono5"
        Me.txtTelefono5.Size = New System.Drawing.Size(215, 26)
        Me.txtTelefono5.TabIndex = 18
        Me.txtTelefono5.Visible = False
        '
        'btnMasTel4
        '
        Me.btnMasTel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasTel4.Image = CType(resources.GetObject("btnMasTel4.Image"), System.Drawing.Image)
        Me.btnMasTel4.Location = New System.Drawing.Point(602, 221)
        Me.btnMasTel4.Name = "btnMasTel4"
        Me.btnMasTel4.Size = New System.Drawing.Size(24, 24)
        Me.btnMasTel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMasTel4.TabIndex = 17
        Me.btnMasTel4.TabStop = False
        Me.btnMasTel4.Visible = False
        '
        'txtTelefono4
        '
        Me.txtTelefono4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono4.Location = New System.Drawing.Point(371, 221)
        Me.txtTelefono4.MaxLength = 15
        Me.txtTelefono4.Name = "txtTelefono4"
        Me.txtTelefono4.Size = New System.Drawing.Size(215, 26)
        Me.txtTelefono4.TabIndex = 16
        Me.txtTelefono4.Visible = False
        '
        'btnMasTel3
        '
        Me.btnMasTel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasTel3.Image = CType(resources.GetObject("btnMasTel3.Image"), System.Drawing.Image)
        Me.btnMasTel3.Location = New System.Drawing.Point(602, 174)
        Me.btnMasTel3.Name = "btnMasTel3"
        Me.btnMasTel3.Size = New System.Drawing.Size(24, 24)
        Me.btnMasTel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMasTel3.TabIndex = 15
        Me.btnMasTel3.TabStop = False
        Me.btnMasTel3.Visible = False
        '
        'txtTelefono3
        '
        Me.txtTelefono3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono3.Location = New System.Drawing.Point(371, 174)
        Me.txtTelefono3.MaxLength = 15
        Me.txtTelefono3.Name = "txtTelefono3"
        Me.txtTelefono3.Size = New System.Drawing.Size(215, 26)
        Me.txtTelefono3.TabIndex = 14
        Me.txtTelefono3.Visible = False
        '
        'btnMasTel2
        '
        Me.btnMasTel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasTel2.Image = CType(resources.GetObject("btnMasTel2.Image"), System.Drawing.Image)
        Me.btnMasTel2.Location = New System.Drawing.Point(602, 126)
        Me.btnMasTel2.Name = "btnMasTel2"
        Me.btnMasTel2.Size = New System.Drawing.Size(24, 24)
        Me.btnMasTel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMasTel2.TabIndex = 13
        Me.btnMasTel2.TabStop = False
        Me.btnMasTel2.Visible = False
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono2.Location = New System.Drawing.Point(371, 126)
        Me.txtTelefono2.MaxLength = 15
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(215, 26)
        Me.txtTelefono2.TabIndex = 12
        Me.txtTelefono2.Visible = False
        '
        'btnMasTel1
        '
        Me.btnMasTel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasTel1.Image = CType(resources.GetObject("btnMasTel1.Image"), System.Drawing.Image)
        Me.btnMasTel1.Location = New System.Drawing.Point(602, 76)
        Me.btnMasTel1.Name = "btnMasTel1"
        Me.btnMasTel1.Size = New System.Drawing.Size(24, 24)
        Me.btnMasTel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMasTel1.TabIndex = 11
        Me.btnMasTel1.TabStop = False
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(246, 325)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(133, 49)
        Me.btnRegistrarCliente.TabIndex = 10
        Me.btnRegistrarCliente.Text = "Registrar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'txtTelefono1
        '
        Me.txtTelefono1.BackColor = System.Drawing.Color.White
        Me.txtTelefono1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono1.Location = New System.Drawing.Point(371, 76)
        Me.txtTelefono1.MaxLength = 15
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(215, 26)
        Me.txtTelefono1.TabIndex = 9
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(329, 32)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(93, 24)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(64, 184)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(215, 26)
        Me.txtDireccion.TabIndex = 7
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(15, 140)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(99, 24)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Dirección"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(64, 76)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(215, 26)
        Me.txtNombre.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(15, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(185, 24)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre completo*"
        '
        'Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 426)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo"
        Me.TopMost = True
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnMenosTel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenosTel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenosTel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenosTel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMasTel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMasTel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMasTel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMasTel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarCliente As System.Windows.Forms.Button
    Friend WithEvents txtTelefono5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents btnMasTel1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMasTel4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMasTel3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMasTel2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenosTel4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenosTel3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenosTel2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenosTel1 As System.Windows.Forms.PictureBox
End Class
