<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebeProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DebeProveedor))
        Me.lblNombreProv = New System.Windows.Forms.Label()
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFinalizarCompra = New System.Windows.Forms.Button()
        Me.btnOtraCompra = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVolverCompra = New System.Windows.Forms.PictureBox()
        Me.btnSiguienteCompra = New System.Windows.Forms.PictureBox()
        Me.lblNumProducto = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnVolverCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSiguienteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreProv
        '
        Me.lblNombreProv.AutoSize = True
        Me.lblNombreProv.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProv.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblNombreProv.Location = New System.Drawing.Point(12, 60)
        Me.lblNombreProv.Name = "lblNombreProv"
        Me.lblNombreProv.Size = New System.Drawing.Size(185, 19)
        Me.lblNombreProv.TabIndex = 0
        Me.lblNombreProv.Text = "Nombre del Proveedor"
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
        Me.lblTitulo.Size = New System.Drawing.Size(121, 18)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Nueva Compra"
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
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(78, 143)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(119, 26)
        Me.txtImporte.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Importe"
        '
        'txtComentario
        '
        Me.txtComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Location = New System.Drawing.Point(78, 405)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(239, 97)
        Me.txtComentario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Comentario"
        '
        'btnFinalizarCompra
        '
        Me.btnFinalizarCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizarCompra.BackColor = System.Drawing.Color.Black
        Me.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizarCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnFinalizarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinalizarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarCompra.ForeColor = System.Drawing.Color.White
        Me.btnFinalizarCompra.Location = New System.Drawing.Point(201, 560)
        Me.btnFinalizarCompra.Name = "btnFinalizarCompra"
        Me.btnFinalizarCompra.Size = New System.Drawing.Size(169, 44)
        Me.btnFinalizarCompra.TabIndex = 11
        Me.btnFinalizarCompra.Text = "Finalizar Compra"
        Me.btnFinalizarCompra.UseVisualStyleBackColor = False
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
        Me.btnOtraCompra.Location = New System.Drawing.Point(16, 560)
        Me.btnOtraCompra.Name = "btnOtraCompra"
        Me.btnOtraCompra.Size = New System.Drawing.Size(121, 44)
        Me.btnOtraCompra.TabIndex = 12
        Me.btnOtraCompra.Text = "Otra Compra"
        Me.btnOtraCompra.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Código del Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(338, 207)
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
        Me.PictureBox2.Location = New System.Drawing.Point(338, 245)
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
        Me.Label4.Location = New System.Drawing.Point(56, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "$"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(78, 214)
        Me.txtCodigoProducto.MaxLength = 13
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(208, 26)
        Me.txtCodigoProducto.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nombre del producto"
        Me.Label5.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(78, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 50)
        Me.Panel1.TabIndex = 39
        '
        'btnVolverCompra
        '
        Me.btnVolverCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVolverCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolverCompra.Image = CType(resources.GetObject("btnVolverCompra.Image"), System.Drawing.Image)
        Me.btnVolverCompra.Location = New System.Drawing.Point(16, 522)
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
        Me.btnSiguienteCompra.Location = New System.Drawing.Point(105, 522)
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
        Me.lblNumProducto.Location = New System.Drawing.Point(254, 60)
        Me.lblNumProducto.Name = "lblNumProducto"
        Me.lblNumProducto.Size = New System.Drawing.Size(104, 19)
        Me.lblNumProducto.TabIndex = 42
        Me.lblNumProducto.Text = "Producto N° "
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(83, 334)
        Me.txtCantidad.MaxLength = 13
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(96, 26)
        Me.txtCantidad.TabIndex = 43
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
        'DebeProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 616)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNumProducto)
        Me.Controls.Add(Me.btnSiguienteCompra)
        Me.Controls.Add(Me.btnVolverCompra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOtraCompra)
        Me.Controls.Add(Me.btnFinalizarCompra)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.panelTitulo)
        Me.Controls.Add(Me.lblNombreProv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DebeProveedor"
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
    Friend WithEvents lblNombreProv As System.Windows.Forms.Label
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFinalizarCompra As System.Windows.Forms.Button
    Friend WithEvents btnOtraCompra As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVolverCompra As System.Windows.Forms.PictureBox
    Friend WithEvents btnSiguienteCompra As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumProducto As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
