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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurtirProductos))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtImporteCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFinalizarSurtido = New System.Windows.Forms.Button()
        Me.btnOtraCompra = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.panelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnVolverCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSiguienteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.Black
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
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(153, 18)
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
        Me.txtImporteCosto.Location = New System.Drawing.Point(78, 275)
        Me.txtImporteCosto.Name = "txtImporteCosto"
        Me.txtImporteCosto.Size = New System.Drawing.Size(119, 26)
        Me.txtImporteCosto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
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
        Me.btnFinalizarSurtido.Location = New System.Drawing.Point(201, 417)
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
        Me.btnOtraCompra.Location = New System.Drawing.Point(16, 417)
        Me.btnOtraCompra.Name = "btnOtraCompra"
        Me.btnOtraCompra.Size = New System.Drawing.Size(132, 44)
        Me.btnOtraCompra.TabIndex = 12
        Me.btnOtraCompra.Text = "Otro Producto"
        Me.btnOtraCompra.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Código del Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(347, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(347, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(56, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "$"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(64, 149)
        Me.txtCodigoProducto.MaxLength = 13
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(208, 26)
        Me.txtCodigoProducto.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Red
        Me.lblNombre.Location = New System.Drawing.Point(5, 7)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(177, 19)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre del producto"
        Me.lblNombre.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Location = New System.Drawing.Point(64, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 50)
        Me.Panel1.TabIndex = 39
        '
        'btnVolverCompra
        '
        Me.btnVolverCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVolverCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolverCompra.Image = CType(resources.GetObject("btnVolverCompra.Image"), System.Drawing.Image)
        Me.btnVolverCompra.Location = New System.Drawing.Point(16, 379)
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
        Me.btnSiguienteCompra.Location = New System.Drawing.Point(116, 379)
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
        Me.lblNumProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumProducto.ForeColor = System.Drawing.Color.Maroon
        Me.lblNumProducto.Location = New System.Drawing.Point(11, 58)
        Me.lblNumProducto.Name = "lblNumProducto"
        Me.lblNumProducto.Size = New System.Drawing.Size(104, 19)
        Me.lblNumProducto.TabIndex = 42
        Me.lblNumProducto.Text = "Producto N° "
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(78, 334)
        Me.txtCantidad.MaxLength = 13
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(119, 26)
        Me.txtCantidad.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(47, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Cantidad"
        '
        'txtGanancia
        '
        Me.txtGanancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGanancia.Location = New System.Drawing.Point(288, 315)
        Me.txtGanancia.MaxLength = 13
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(62, 26)
        Me.txtGanancia.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(240, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Ganancia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(261, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "%"
        '
        'SurtirProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 473)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNumProducto)
        Me.Controls.Add(Me.btnSiguienteCompra)
        Me.Controls.Add(Me.btnVolverCompra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOtraCompra)
        Me.Controls.Add(Me.btnFinalizarSurtido)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporteCosto)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SurtirProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Compra"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnVolverCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSiguienteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtImporteCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFinalizarSurtido As System.Windows.Forms.Button
    Friend WithEvents btnOtraCompra As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
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
End Class
