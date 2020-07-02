<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensaje
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.Black
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(356, 122)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 32)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.Black
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.ForeColor = System.Drawing.Color.White
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(443, 30)
        Me.panelTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(71, 18)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mensaje"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 157)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.lblMensaje)
        Me.Panel2.Location = New System.Drawing.Point(0, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 100)
        Me.Panel2.TabIndex = 1
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(12, 26)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 21)
        Me.lblMensaje.TabIndex = 0
        '
        'Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 187)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mensaje"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje"
        Me.TopMost = True
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
