<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadisticas))
        Me.chartGrafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSaldoTotal = New System.Windows.Forms.Button()
        Me.btnSaldoPersona = New System.Windows.Forms.Button()
        Me.rbCircular = New System.Windows.Forms.RadioButton()
        Me.rbColumnas = New System.Windows.Forms.RadioButton()
        Me.rbBarras = New System.Windows.Forms.RadioButton()
        Me.barHorizontal = New System.Windows.Forms.TrackBar()
        Me.barVertical = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelTotal = New System.Windows.Forms.Panel()
        Me.btnEsconderPanel = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaldoTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSaldoGrafica = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEstadisticasMes = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tmrVerTotal = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarTotal = New System.Windows.Forms.Timer(Me.components)
        CType(Me.chartGrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.barHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelTotal.SuspendLayout()
        CType(Me.btnEsconderPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chartGrafica
        '
        Me.chartGrafica.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.chartGrafica.BackSecondaryColor = System.Drawing.SystemColors.InactiveCaption
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.BackColor = System.Drawing.SystemColors.InactiveCaption
        ChartArea1.Name = "ChartArea1"
        Me.chartGrafica.ChartAreas.Add(ChartArea1)
        Me.chartGrafica.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chartGrafica.Legends.Add(Legend1)
        Me.chartGrafica.Location = New System.Drawing.Point(0, 0)
        Me.chartGrafica.Name = "chartGrafica"
        Me.chartGrafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartGrafica.Series.Add(Series1)
        Me.chartGrafica.Size = New System.Drawing.Size(846, 437)
        Me.chartGrafica.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSaldoTotal)
        Me.Panel1.Controls.Add(Me.btnSaldoPersona)
        Me.Panel1.Controls.Add(Me.rbCircular)
        Me.Panel1.Controls.Add(Me.rbColumnas)
        Me.Panel1.Controls.Add(Me.rbBarras)
        Me.Panel1.Controls.Add(Me.barHorizontal)
        Me.Panel1.Location = New System.Drawing.Point(0, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 94)
        Me.Panel1.TabIndex = 1
        '
        'btnSaldoTotal
        '
        Me.btnSaldoTotal.BackColor = System.Drawing.Color.Crimson
        Me.btnSaldoTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldoTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoTotal.ForeColor = System.Drawing.Color.White
        Me.btnSaldoTotal.Location = New System.Drawing.Point(3, 66)
        Me.btnSaldoTotal.Name = "btnSaldoTotal"
        Me.btnSaldoTotal.Size = New System.Drawing.Size(97, 25)
        Me.btnSaldoTotal.TabIndex = 10
        Me.btnSaldoTotal.Text = "Saldo/Total"
        Me.btnSaldoTotal.UseVisualStyleBackColor = False
        '
        'btnSaldoPersona
        '
        Me.btnSaldoPersona.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSaldoPersona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldoPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldoPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoPersona.ForeColor = System.Drawing.Color.White
        Me.btnSaldoPersona.Location = New System.Drawing.Point(3, 6)
        Me.btnSaldoPersona.Name = "btnSaldoPersona"
        Me.btnSaldoPersona.Size = New System.Drawing.Size(115, 25)
        Me.btnSaldoPersona.TabIndex = 9
        Me.btnSaldoPersona.Text = "Saldo/Persona"
        Me.btnSaldoPersona.UseVisualStyleBackColor = False
        '
        'rbCircular
        '
        Me.rbCircular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbCircular.AutoSize = True
        Me.rbCircular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCircular.ForeColor = System.Drawing.Color.White
        Me.rbCircular.Location = New System.Drawing.Point(808, 62)
        Me.rbCircular.Name = "rbCircular"
        Me.rbCircular.Size = New System.Drawing.Size(112, 17)
        Me.rbCircular.TabIndex = 8
        Me.rbCircular.TabStop = True
        Me.rbCircular.Text = "Gráfica circular"
        Me.rbCircular.UseVisualStyleBackColor = True
        '
        'rbColumnas
        '
        Me.rbColumnas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbColumnas.AutoSize = True
        Me.rbColumnas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbColumnas.ForeColor = System.Drawing.Color.White
        Me.rbColumnas.Location = New System.Drawing.Point(805, 14)
        Me.rbColumnas.Name = "rbColumnas"
        Me.rbColumnas.Size = New System.Drawing.Size(141, 17)
        Me.rbColumnas.TabIndex = 7
        Me.rbColumnas.TabStop = True
        Me.rbColumnas.Text = "Gráfica en columnas"
        Me.rbColumnas.UseVisualStyleBackColor = True
        '
        'rbBarras
        '
        Me.rbBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbBarras.AutoSize = True
        Me.rbBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBarras.ForeColor = System.Drawing.Color.White
        Me.rbBarras.Location = New System.Drawing.Point(807, 37)
        Me.rbBarras.Name = "rbBarras"
        Me.rbBarras.Size = New System.Drawing.Size(123, 17)
        Me.rbBarras.TabIndex = 6
        Me.rbBarras.TabStop = True
        Me.rbBarras.Text = "Gráfica en barras"
        Me.rbBarras.UseVisualStyleBackColor = True
        '
        'barHorizontal
        '
        Me.barHorizontal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barHorizontal.Location = New System.Drawing.Point(101, 34)
        Me.barHorizontal.Maximum = 180
        Me.barHorizontal.Name = "barHorizontal"
        Me.barHorizontal.Size = New System.Drawing.Size(685, 45)
        Me.barHorizontal.TabIndex = 4
        Me.barHorizontal.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'barVertical
        '
        Me.barVertical.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barVertical.Location = New System.Drawing.Point(35, 12)
        Me.barVertical.Maximum = 90
        Me.barVertical.Name = "barVertical"
        Me.barVertical.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.barVertical.Size = New System.Drawing.Size(45, 419)
        Me.barVertical.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.panelTotal)
        Me.Panel2.Controls.Add(Me.lblEstadisticasMes)
        Me.Panel2.Controls.Add(Me.chartGrafica)
        Me.Panel2.Location = New System.Drawing.Point(101, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 437)
        Me.Panel2.TabIndex = 2
        '
        'panelTotal
        '
        Me.panelTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelTotal.Controls.Add(Me.btnEsconderPanel)
        Me.panelTotal.Controls.Add(Me.Label5)
        Me.panelTotal.Controls.Add(Me.lblSaldoTotal)
        Me.panelTotal.Controls.Add(Me.Label7)
        Me.panelTotal.Controls.Add(Me.Label4)
        Me.panelTotal.Controls.Add(Me.lblSaldoGrafica)
        Me.panelTotal.Controls.Add(Me.Label1)
        Me.panelTotal.Controls.Add(Me.Label2)
        Me.panelTotal.Location = New System.Drawing.Point(654, 0)
        Me.panelTotal.Name = "panelTotal"
        Me.panelTotal.Size = New System.Drawing.Size(192, 437)
        Me.panelTotal.TabIndex = 4
        '
        'btnEsconderPanel
        '
        Me.btnEsconderPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEsconderPanel.Enabled = False
        Me.btnEsconderPanel.Image = CType(resources.GetObject("btnEsconderPanel.Image"), System.Drawing.Image)
        Me.btnEsconderPanel.Location = New System.Drawing.Point(151, 7)
        Me.btnEsconderPanel.Name = "btnEsconderPanel"
        Me.btnEsconderPanel.Size = New System.Drawing.Size(32, 32)
        Me.btnEsconderPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnEsconderPanel.TabIndex = 9
        Me.btnEsconderPanel.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "$"
        '
        'lblSaldoTotal
        '
        Me.lblSaldoTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaldoTotal.AutoSize = True
        Me.lblSaldoTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblSaldoTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoTotal.ForeColor = System.Drawing.Color.White
        Me.lblSaldoTotal.Location = New System.Drawing.Point(36, 271)
        Me.lblSaldoTotal.Name = "lblSaldoTotal"
        Me.lblSaldoTotal.Size = New System.Drawing.Size(55, 21)
        Me.lblSaldoTotal.TabIndex = 7
        Me.lblSaldoTotal.Text = "23000"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Deuda Total:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "$"
        '
        'lblSaldoGrafica
        '
        Me.lblSaldoGrafica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaldoGrafica.AutoSize = True
        Me.lblSaldoGrafica.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblSaldoGrafica.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoGrafica.ForeColor = System.Drawing.Color.White
        Me.lblSaldoGrafica.Location = New System.Drawing.Point(36, 166)
        Me.lblSaldoGrafica.Name = "lblSaldoGrafica"
        Me.lblSaldoGrafica.Size = New System.Drawing.Size(55, 21)
        Me.lblSaldoGrafica.TabIndex = 4
        Me.lblSaldoGrafica.Text = "12000"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Saldo Total"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Basado en la gráfica:"
        '
        'lblEstadisticasMes
        '
        Me.lblEstadisticasMes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstadisticasMes.AutoSize = True
        Me.lblEstadisticasMes.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblEstadisticasMes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadisticasMes.ForeColor = System.Drawing.Color.Indigo
        Me.lblEstadisticasMes.Location = New System.Drawing.Point(23, 7)
        Me.lblEstadisticasMes.Name = "lblEstadisticasMes"
        Me.lblEstadisticasMes.Size = New System.Drawing.Size(402, 21)
        Me.lblEstadisticasMes.TabIndex = 1
        Me.lblEstadisticasMes.Text = "Estadísticas desde el mes 0000/00/00 al 0000/00/00"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel3.Controls.Add(Me.barVertical)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(109, 437)
        Me.Panel3.TabIndex = 3
        '
        'tmrVerTotal
        '
        Me.tmrVerTotal.Interval = 1
        '
        'tmrOcultarTotal
        '
        Me.tmrOcultarTotal.Interval = 1
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 531)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.chartGrafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.barHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelTotal.ResumeLayout(False)
        Me.panelTotal.PerformLayout()
        CType(Me.btnEsconderPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chartGrafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents barVertical As System.Windows.Forms.TrackBar
    Friend WithEvents barHorizontal As System.Windows.Forms.TrackBar
    Friend WithEvents rbBarras As System.Windows.Forms.RadioButton
    Friend WithEvents rbCircular As System.Windows.Forms.RadioButton
    Friend WithEvents rbColumnas As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblEstadisticasMes As System.Windows.Forms.Label
    Friend WithEvents btnSaldoPersona As System.Windows.Forms.Button
    Friend WithEvents btnSaldoTotal As System.Windows.Forms.Button
    Friend WithEvents panelTotal As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoGrafica As System.Windows.Forms.Label
    Friend WithEvents btnEsconderPanel As System.Windows.Forms.PictureBox
    Friend WithEvents tmrVerTotal As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarTotal As System.Windows.Forms.Timer
End Class
