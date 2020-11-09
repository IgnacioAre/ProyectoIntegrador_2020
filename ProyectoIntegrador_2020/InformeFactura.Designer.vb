<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeFactura))
        Me.panelFactura = New System.Windows.Forms.Panel()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.contadorPagina = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbRegresar = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnZoomMas = New System.Windows.Forms.Button()
        Me.btnZoomMenos = New System.Windows.Forms.Button()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.panelFactura.SuspendLayout()
        Me.panelSuperior.SuspendLayout()
        CType(Me.contadorPagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFactura
        '
        Me.panelFactura.BackColor = System.Drawing.SystemColors.Highlight
        Me.panelFactura.Controls.Add(Me.panelSuperior)
        Me.panelFactura.Controls.Add(Me.PrintPreviewControl1)
        Me.panelFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFactura.Location = New System.Drawing.Point(0, 0)
        Me.panelFactura.Name = "panelFactura"
        Me.panelFactura.Size = New System.Drawing.Size(607, 532)
        Me.panelFactura.TabIndex = 8
        '
        'panelSuperior
        '
        Me.panelSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSuperior.BackColor = System.Drawing.SystemColors.Highlight
        Me.panelSuperior.Controls.Add(Me.contadorPagina)
        Me.panelSuperior.Controls.Add(Me.Label1)
        Me.panelSuperior.Controls.Add(Me.pbRegresar)
        Me.panelSuperior.Controls.Add(Me.btnImprimir)
        Me.panelSuperior.Controls.Add(Me.btnZoomMas)
        Me.panelSuperior.Controls.Add(Me.btnZoomMenos)
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(607, 56)
        Me.panelSuperior.TabIndex = 4
        '
        'contadorPagina
        '
        Me.contadorPagina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contadorPagina.Location = New System.Drawing.Point(289, 31)
        Me.contadorPagina.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.contadorPagina.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.contadorPagina.Name = "contadorPagina"
        Me.contadorPagina.Size = New System.Drawing.Size(60, 22)
        Me.contadorPagina.TabIndex = 14
        Me.contadorPagina.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(285, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Página:"
        '
        'pbRegresar
        '
        Me.pbRegresar.BackColor = System.Drawing.Color.Crimson
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Image = CType(resources.GetObject("pbRegresar.Image"), System.Drawing.Image)
        Me.pbRegresar.Location = New System.Drawing.Point(0, 0)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(32, 32)
        Me.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRegresar.TabIndex = 11
        Me.pbRegresar.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Indigo
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(76, 3)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(143, 50)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "  Guardar"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnZoomMas
        '
        Me.btnZoomMas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomMas.BackColor = System.Drawing.Color.SteelBlue
        Me.btnZoomMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZoomMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomMas.ForeColor = System.Drawing.Color.White
        Me.btnZoomMas.Location = New System.Drawing.Point(518, 11)
        Me.btnZoomMas.Name = "btnZoomMas"
        Me.btnZoomMas.Size = New System.Drawing.Size(75, 31)
        Me.btnZoomMas.TabIndex = 3
        Me.btnZoomMas.Text = "Zoom +"
        Me.btnZoomMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnZoomMas.UseVisualStyleBackColor = False
        '
        'btnZoomMenos
        '
        Me.btnZoomMenos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomMenos.BackColor = System.Drawing.Color.SteelBlue
        Me.btnZoomMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZoomMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMenos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomMenos.ForeColor = System.Drawing.Color.White
        Me.btnZoomMenos.Location = New System.Drawing.Point(419, 11)
        Me.btnZoomMenos.Name = "btnZoomMenos"
        Me.btnZoomMenos.Size = New System.Drawing.Size(75, 31)
        Me.btnZoomMenos.TabIndex = 2
        Me.btnZoomMenos.Text = "Zoom -"
        Me.btnZoomMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnZoomMenos.UseVisualStyleBackColor = False
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.BackColor = System.Drawing.Color.SteelBlue
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 62)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(607, 467)
        Me.PrintPreviewControl1.TabIndex = 5
        Me.PrintPreviewControl1.Zoom = 0.37363636363636366R
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'InformeFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 532)
        Me.Controls.Add(Me.panelFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InformeFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelFactura.ResumeLayout(False)
        Me.panelSuperior.ResumeLayout(False)
        Me.panelSuperior.PerformLayout()
        CType(Me.contadorPagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelFactura As System.Windows.Forms.Panel
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnZoomMas As System.Windows.Forms.Button
    Friend WithEvents btnZoomMenos As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contadorPagina As System.Windows.Forms.NumericUpDown
End Class
