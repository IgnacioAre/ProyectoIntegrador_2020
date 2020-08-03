<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmacionMensaje
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.panelMensaje = New System.Windows.Forms.Panel()
        Me.PanelEntrada = New System.Windows.Forms.Panel()
        Me.lblMensajeEntrada = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelTitulo.SuspendLayout()
        Me.panelMensaje.SuspendLayout()
        Me.PanelEntrada.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(99, 103)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.Black
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "No"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.OK_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Si"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.Black
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.ForeColor = System.Drawing.Color.White
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(356, 30)
        Me.panelTitulo.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(109, 18)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Confirmación"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(3, 47)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(75, 21)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Mensaje"
        '
        'panelMensaje
        '
        Me.panelMensaje.Controls.Add(Me.lblMensaje)
        Me.panelMensaje.Location = New System.Drawing.Point(0, 0)
        Me.panelMensaje.Name = "panelMensaje"
        Me.panelMensaje.Size = New System.Drawing.Size(356, 97)
        Me.panelMensaje.TabIndex = 4
        Me.panelMensaje.Visible = False
        '
        'PanelEntrada
        '
        Me.PanelEntrada.Controls.Add(Me.txtEntrada)
        Me.PanelEntrada.Controls.Add(Me.lblMensajeEntrada)
        Me.PanelEntrada.Location = New System.Drawing.Point(0, 0)
        Me.PanelEntrada.Name = "PanelEntrada"
        Me.PanelEntrada.Size = New System.Drawing.Size(356, 97)
        Me.PanelEntrada.TabIndex = 5
        Me.PanelEntrada.Visible = False
        '
        'lblMensajeEntrada
        '
        Me.lblMensajeEntrada.AutoSize = True
        Me.lblMensajeEntrada.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeEntrada.Location = New System.Drawing.Point(11, 14)
        Me.lblMensajeEntrada.Name = "lblMensajeEntrada"
        Me.lblMensajeEntrada.Size = New System.Drawing.Size(75, 21)
        Me.lblMensajeEntrada.TabIndex = 1
        Me.lblMensajeEntrada.Text = "Mensaje"
        '
        'txtEntrada
        '
        Me.txtEntrada.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.Location = New System.Drawing.Point(39, 59)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(262, 26)
        Me.txtEntrada.TabIndex = 2
        '
        'panelContenedor
        '
        Me.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.panelContenedor.Controls.Add(Me.panelMensaje)
        Me.panelContenedor.Controls.Add(Me.PanelEntrada)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 30)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(356, 143)
        Me.panelContenedor.TabIndex = 6
        '
        'ConfirmacionMensaje
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(356, 173)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfirmacionMensaje"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.panelMensaje.ResumeLayout(False)
        Me.panelMensaje.PerformLayout()
        Me.PanelEntrada.ResumeLayout(False)
        Me.PanelEntrada.PerformLayout()
        Me.panelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents panelMensaje As System.Windows.Forms.Panel
    Friend WithEvents PanelEntrada As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeEntrada As System.Windows.Forms.Label
    Friend WithEvents txtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents panelContenedor As System.Windows.Forms.Panel

End Class
