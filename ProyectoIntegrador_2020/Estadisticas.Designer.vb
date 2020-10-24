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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartGrafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbCircular = New System.Windows.Forms.RadioButton()
        Me.rbColumnas = New System.Windows.Forms.RadioButton()
        Me.rbBarras = New System.Windows.Forms.RadioButton()
        Me.barHorizontal = New System.Windows.Forms.TrackBar()
        Me.barVertical = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.chartGrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.barHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.chartGrafica.Size = New System.Drawing.Size(599, 355)
        Me.chartGrafica.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.rbCircular)
        Me.Panel1.Controls.Add(Me.rbColumnas)
        Me.Panel1.Controls.Add(Me.rbBarras)
        Me.Panel1.Controls.Add(Me.barHorizontal)
        Me.Panel1.Location = New System.Drawing.Point(0, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 94)
        Me.Panel1.TabIndex = 1
        '
        'rbCircular
        '
        Me.rbCircular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbCircular.AutoSize = True
        Me.rbCircular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCircular.ForeColor = System.Drawing.Color.White
        Me.rbCircular.Location = New System.Drawing.Point(561, 62)
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
        Me.rbColumnas.Location = New System.Drawing.Point(558, 14)
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
        Me.rbBarras.Location = New System.Drawing.Point(560, 37)
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
        Me.barHorizontal.Size = New System.Drawing.Size(438, 45)
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
        Me.barVertical.Size = New System.Drawing.Size(45, 337)
        Me.barVertical.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.chartGrafica)
        Me.Panel2.Location = New System.Drawing.Point(101, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 355)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel3.Controls.Add(Me.barVertical)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(109, 355)
        Me.Panel3.TabIndex = 3
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 449)
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
End Class
