﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuentaCorrienteProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentaCorrienteProveedor))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.btnDebe = New System.Windows.Forms.Button()
        Me.btnHaber = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvProveedores = New Guna.UI.WinForms.GunaDataGridView()
        Me.pbActualizarTabla = New System.Windows.Forms.PictureBox()
        Me.dgvRegistroCompras = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbRegistroCompras = New System.Windows.Forms.GroupBox()
        Me.chkCobros = New System.Windows.Forms.CheckBox()
        Me.chkRegistroCompleto = New System.Windows.Forms.CheckBox()
        Me.btnVerRegistro = New System.Windows.Forms.Button()
        Me.btnOcultarRegistro = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnPagarTodoRegistro = New System.Windows.Forms.Button()
        Me.gbHaber = New System.Windows.Forms.GroupBox()
        Me.btnDescontarHaber = New System.Windows.Forms.Button()
        Me.btnVerDetalleHaber = New System.Windows.Forms.Button()
        Me.btnOcultarDetalleHaber = New System.Windows.Forms.Button()
        Me.txtDetalleHaber = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnCerrarHaber = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDineroHaber = New System.Windows.Forms.TextBox()
        Me.gbDebe = New System.Windows.Forms.GroupBox()
        Me.btnCerrarInfo = New System.Windows.Forms.Button()
        Me.btnVerDetalleDebe = New System.Windows.Forms.Button()
        Me.btnOcultarDetalleDebe = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetalleDebe = New System.Windows.Forms.TextBox()
        Me.btnActualizarDeuda = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDineroDebe = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRegistroCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistroCompras.SuspendLayout()
        Me.gbHaber.SuspendLayout()
        Me.gbDebe.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(136, 21)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(244, 26)
        Me.txtBuscarClientes.TabIndex = 0
        '
        'btnDebe
        '
        Me.btnDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebe.BackColor = System.Drawing.Color.MistyRose
        Me.btnDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebe.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebe.ForeColor = System.Drawing.Color.Black
        Me.btnDebe.Location = New System.Drawing.Point(793, 62)
        Me.btnDebe.Name = "btnDebe"
        Me.btnDebe.Size = New System.Drawing.Size(157, 46)
        Me.btnDebe.TabIndex = 11
        Me.btnDebe.Text = "Debe"
        Me.btnDebe.UseVisualStyleBackColor = False
        '
        'btnHaber
        '
        Me.btnHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHaber.BackColor = System.Drawing.Color.LightGreen
        Me.btnHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHaber.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHaber.ForeColor = System.Drawing.Color.Black
        Me.btnHaber.Location = New System.Drawing.Point(793, 125)
        Me.btnHaber.Name = "btnHaber"
        Me.btnHaber.Size = New System.Drawing.Size(157, 44)
        Me.btnHaber.TabIndex = 12
        Me.btnHaber.Text = "Haber"
        Me.btnHaber.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AllowUserToResizeColumns = False
        Me.dgvProveedores.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvProveedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvProveedores.EnableHeadersVisualStyles = False
        Me.dgvProveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvProveedores.Location = New System.Drawing.Point(89, 62)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RowHeadersVisible = False
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(673, 180)
        Me.dgvProveedores.TabIndex = 18
        Me.dgvProveedores.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvProveedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvProveedores.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvProveedores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvProveedores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvProveedores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvProveedores.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvProveedores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvProveedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvProveedores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProveedores.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProveedores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProveedores.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvProveedores.ThemeStyle.ReadOnly = True
        Me.dgvProveedores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvProveedores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProveedores.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProveedores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProveedores.ThemeStyle.RowsStyle.Height = 22
        Me.dgvProveedores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvProveedores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pbActualizarTabla
        '
        Me.pbActualizarTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbActualizarTabla.Image = CType(resources.GetObject("pbActualizarTabla.Image"), System.Drawing.Image)
        Me.pbActualizarTabla.Location = New System.Drawing.Point(16, 103)
        Me.pbActualizarTabla.Name = "pbActualizarTabla"
        Me.pbActualizarTabla.Size = New System.Drawing.Size(35, 35)
        Me.pbActualizarTabla.TabIndex = 23
        Me.pbActualizarTabla.TabStop = False
        '
        'dgvRegistroCompras
        '
        Me.dgvRegistroCompras.AllowUserToAddRows = False
        Me.dgvRegistroCompras.AllowUserToDeleteRows = False
        Me.dgvRegistroCompras.AllowUserToResizeColumns = False
        Me.dgvRegistroCompras.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvRegistroCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistroCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroCompras.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvRegistroCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistroCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroCompras.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvRegistroCompras.EnableHeadersVisualStyles = False
        Me.dgvRegistroCompras.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroCompras.Location = New System.Drawing.Point(14, 68)
        Me.dgvRegistroCompras.Name = "dgvRegistroCompras"
        Me.dgvRegistroCompras.ReadOnly = True
        Me.dgvRegistroCompras.RowHeadersVisible = False
        Me.dgvRegistroCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroCompras.Size = New System.Drawing.Size(544, 316)
        Me.dgvRegistroCompras.TabIndex = 24
        Me.dgvRegistroCompras.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.dgvRegistroCompras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvRegistroCompras.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRegistroCompras.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRegistroCompras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRegistroCompras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRegistroCompras.ThemeStyle.BackColor = System.Drawing.Color.Khaki
        Me.dgvRegistroCompras.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvRegistroCompras.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRegistroCompras.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroCompras.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroCompras.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvRegistroCompras.ThemeStyle.ReadOnly = True
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvRegistroCompras.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'gbRegistroCompras
        '
        Me.gbRegistroCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRegistroCompras.Controls.Add(Me.chkCobros)
        Me.gbRegistroCompras.Controls.Add(Me.chkRegistroCompleto)
        Me.gbRegistroCompras.Controls.Add(Me.dgvRegistroCompras)
        Me.gbRegistroCompras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroCompras.ForeColor = System.Drawing.Color.White
        Me.gbRegistroCompras.Location = New System.Drawing.Point(27, 339)
        Me.gbRegistroCompras.Name = "gbRegistroCompras"
        Me.gbRegistroCompras.Size = New System.Drawing.Size(556, 399)
        Me.gbRegistroCompras.TabIndex = 25
        Me.gbRegistroCompras.TabStop = False
        Me.gbRegistroCompras.Text = "Registro de Compras"
        Me.gbRegistroCompras.Visible = False
        '
        'chkCobros
        '
        Me.chkCobros.AutoSize = True
        Me.chkCobros.ForeColor = System.Drawing.Color.Navy
        Me.chkCobros.Location = New System.Drawing.Point(14, 30)
        Me.chkCobros.Name = "chkCobros"
        Me.chkCobros.Size = New System.Drawing.Size(132, 26)
        Me.chkCobros.TabIndex = 35
        Me.chkCobros.Text = "Ver Cobros"
        Me.chkCobros.UseVisualStyleBackColor = True
        '
        'chkRegistroCompleto
        '
        Me.chkRegistroCompleto.AutoSize = True
        Me.chkRegistroCompleto.ForeColor = System.Drawing.Color.Navy
        Me.chkRegistroCompleto.Location = New System.Drawing.Point(308, 30)
        Me.chkRegistroCompleto.Name = "chkRegistroCompleto"
        Me.chkRegistroCompleto.Size = New System.Drawing.Size(235, 26)
        Me.chkRegistroCompleto.TabIndex = 34
        Me.chkRegistroCompleto.Text = "Ver Registro Completo"
        Me.chkRegistroCompleto.UseVisualStyleBackColor = True
        '
        'btnVerRegistro
        '
        Me.btnVerRegistro.BackColor = System.Drawing.Color.Teal
        Me.btnVerRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerRegistro.Enabled = False
        Me.btnVerRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRegistro.ForeColor = System.Drawing.Color.White
        Me.btnVerRegistro.Image = CType(resources.GetObject("btnVerRegistro.Image"), System.Drawing.Image)
        Me.btnVerRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerRegistro.Location = New System.Drawing.Point(27, 268)
        Me.btnVerRegistro.Name = "btnVerRegistro"
        Me.btnVerRegistro.Size = New System.Drawing.Size(132, 47)
        Me.btnVerRegistro.TabIndex = 26
        Me.btnVerRegistro.Text = "  Ver Registro"
        Me.btnVerRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerRegistro.UseVisualStyleBackColor = False
        '
        'btnOcultarRegistro
        '
        Me.btnOcultarRegistro.BackColor = System.Drawing.Color.Teal
        Me.btnOcultarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarRegistro.ForeColor = System.Drawing.Color.White
        Me.btnOcultarRegistro.Image = CType(resources.GetObject("btnOcultarRegistro.Image"), System.Drawing.Image)
        Me.btnOcultarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarRegistro.Location = New System.Drawing.Point(27, 268)
        Me.btnOcultarRegistro.Name = "btnOcultarRegistro"
        Me.btnOcultarRegistro.Size = New System.Drawing.Size(167, 47)
        Me.btnOcultarRegistro.TabIndex = 27
        Me.btnOcultarRegistro.Text = "  Ocultar Registro"
        Me.btnOcultarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarRegistro.UseVisualStyleBackColor = False
        Me.btnOcultarRegistro.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Black
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(6, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrar.TabIndex = 30
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnPagarTodoRegistro
        '
        Me.btnPagarTodoRegistro.BackColor = System.Drawing.Color.Red
        Me.btnPagarTodoRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagarTodoRegistro.Enabled = False
        Me.btnPagarTodoRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnPagarTodoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPagarTodoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagarTodoRegistro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarTodoRegistro.ForeColor = System.Drawing.Color.White
        Me.btnPagarTodoRegistro.Image = CType(resources.GetObject("btnPagarTodoRegistro.Image"), System.Drawing.Image)
        Me.btnPagarTodoRegistro.Location = New System.Drawing.Point(240, 222)
        Me.btnPagarTodoRegistro.Name = "btnPagarTodoRegistro"
        Me.btnPagarTodoRegistro.Size = New System.Drawing.Size(142, 54)
        Me.btnPagarTodoRegistro.TabIndex = 32
        Me.btnPagarTodoRegistro.Text = "Pagar TODO"
        Me.btnPagarTodoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagarTodoRegistro.UseVisualStyleBackColor = False
        '
        'gbHaber
        '
        Me.gbHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbHaber.Controls.Add(Me.btnDescontarHaber)
        Me.gbHaber.Controls.Add(Me.btnVerDetalleHaber)
        Me.gbHaber.Controls.Add(Me.btnOcultarDetalleHaber)
        Me.gbHaber.Controls.Add(Me.txtDetalleHaber)
        Me.gbHaber.Controls.Add(Me.CheckBox2)
        Me.gbHaber.Controls.Add(Me.btnCerrarHaber)
        Me.gbHaber.Controls.Add(Me.Label3)
        Me.gbHaber.Controls.Add(Me.Label4)
        Me.gbHaber.Controls.Add(Me.txtDineroHaber)
        Me.gbHaber.Controls.Add(Me.btnPagarTodoRegistro)
        Me.gbHaber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHaber.ForeColor = System.Drawing.Color.White
        Me.gbHaber.Location = New System.Drawing.Point(599, 447)
        Me.gbHaber.Name = "gbHaber"
        Me.gbHaber.Size = New System.Drawing.Size(388, 291)
        Me.gbHaber.TabIndex = 33
        Me.gbHaber.TabStop = False
        Me.gbHaber.Text = "Haber"
        Me.gbHaber.Visible = False
        '
        'btnDescontarHaber
        '
        Me.btnDescontarHaber.BackColor = System.Drawing.Color.Crimson
        Me.btnDescontarHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescontarHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDescontarHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDescontarHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescontarHaber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescontarHaber.ForeColor = System.Drawing.Color.White
        Me.btnDescontarHaber.Location = New System.Drawing.Point(240, 65)
        Me.btnDescontarHaber.Name = "btnDescontarHaber"
        Me.btnDescontarHaber.Size = New System.Drawing.Size(122, 51)
        Me.btnDescontarHaber.TabIndex = 43
        Me.btnDescontarHaber.Text = "Descontar"
        Me.btnDescontarHaber.UseVisualStyleBackColor = False
        '
        'btnVerDetalleHaber
        '
        Me.btnVerDetalleHaber.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnVerDetalleHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDetalleHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerDetalleHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerDetalleHaber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleHaber.ForeColor = System.Drawing.Color.White
        Me.btnVerDetalleHaber.Image = CType(resources.GetObject("btnVerDetalleHaber.Image"), System.Drawing.Image)
        Me.btnVerDetalleHaber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalleHaber.Location = New System.Drawing.Point(40, 123)
        Me.btnVerDetalleHaber.Name = "btnVerDetalleHaber"
        Me.btnVerDetalleHaber.Size = New System.Drawing.Size(106, 47)
        Me.btnVerDetalleHaber.TabIndex = 40
        Me.btnVerDetalleHaber.Text = "  Detalle"
        Me.btnVerDetalleHaber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerDetalleHaber.UseVisualStyleBackColor = False
        Me.btnVerDetalleHaber.Visible = False
        '
        'btnOcultarDetalleHaber
        '
        Me.btnOcultarDetalleHaber.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOcultarDetalleHaber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarDetalleHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarDetalleHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarDetalleHaber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarDetalleHaber.ForeColor = System.Drawing.Color.White
        Me.btnOcultarDetalleHaber.Image = CType(resources.GetObject("btnOcultarDetalleHaber.Image"), System.Drawing.Image)
        Me.btnOcultarDetalleHaber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarDetalleHaber.Location = New System.Drawing.Point(39, 124)
        Me.btnOcultarDetalleHaber.Name = "btnOcultarDetalleHaber"
        Me.btnOcultarDetalleHaber.Size = New System.Drawing.Size(107, 47)
        Me.btnOcultarDetalleHaber.TabIndex = 41
        Me.btnOcultarDetalleHaber.Text = "  Detalle"
        Me.btnOcultarDetalleHaber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarDetalleHaber.UseVisualStyleBackColor = False
        Me.btnOcultarDetalleHaber.Visible = False
        '
        'txtDetalleHaber
        '
        Me.txtDetalleHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleHaber.Location = New System.Drawing.Point(39, 179)
        Me.txtDetalleHaber.Name = "txtDetalleHaber"
        Me.txtDetalleHaber.Size = New System.Drawing.Size(296, 26)
        Me.txtDetalleHaber.TabIndex = 39
        Me.txtDetalleHaber.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(18, 242)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(155, 20)
        Me.CheckBox2.TabIndex = 37
        Me.CheckBox2.Text = "Importante (Notas)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnCerrarHaber
        '
        Me.btnCerrarHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarHaber.BackColor = System.Drawing.Color.Black
        Me.btnCerrarHaber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarHaber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrarHaber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrarHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarHaber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarHaber.ForeColor = System.Drawing.Color.White
        Me.btnCerrarHaber.Location = New System.Drawing.Point(353, 16)
        Me.btnCerrarHaber.Name = "btnCerrarHaber"
        Me.btnCerrarHaber.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrarHaber.TabIndex = 36
        Me.btnCerrarHaber.Text = "X"
        Me.btnCerrarHaber.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(19, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Saldo"
        '
        'txtDineroHaber
        '
        Me.txtDineroHaber.Location = New System.Drawing.Point(39, 77)
        Me.txtDineroHaber.MaxLength = 7
        Me.txtDineroHaber.Name = "txtDineroHaber"
        Me.txtDineroHaber.Size = New System.Drawing.Size(133, 27)
        Me.txtDineroHaber.TabIndex = 33
        '
        'gbDebe
        '
        Me.gbDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDebe.Controls.Add(Me.btnCerrarInfo)
        Me.gbDebe.Controls.Add(Me.btnVerDetalleDebe)
        Me.gbDebe.Controls.Add(Me.btnOcultarDetalleDebe)
        Me.gbDebe.Controls.Add(Me.Label2)
        Me.gbDebe.Controls.Add(Me.txtDetalleDebe)
        Me.gbDebe.Controls.Add(Me.btnActualizarDeuda)
        Me.gbDebe.Controls.Add(Me.CheckBox1)
        Me.gbDebe.Controls.Add(Me.Label1)
        Me.gbDebe.Controls.Add(Me.txtDineroDebe)
        Me.gbDebe.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDebe.ForeColor = System.Drawing.Color.Maroon
        Me.gbDebe.Location = New System.Drawing.Point(653, 268)
        Me.gbDebe.Name = "gbDebe"
        Me.gbDebe.Size = New System.Drawing.Size(345, 253)
        Me.gbDebe.TabIndex = 34
        Me.gbDebe.TabStop = False
        Me.gbDebe.Text = "Debe"
        Me.gbDebe.Visible = False
        '
        'btnCerrarInfo
        '
        Me.btnCerrarInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarInfo.BackColor = System.Drawing.Color.Black
        Me.btnCerrarInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCerrarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarInfo.ForeColor = System.Drawing.Color.White
        Me.btnCerrarInfo.Location = New System.Drawing.Point(311, 16)
        Me.btnCerrarInfo.Name = "btnCerrarInfo"
        Me.btnCerrarInfo.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrarInfo.TabIndex = 29
        Me.btnCerrarInfo.Text = "X"
        Me.btnCerrarInfo.UseVisualStyleBackColor = False
        '
        'btnVerDetalleDebe
        '
        Me.btnVerDetalleDebe.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnVerDetalleDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDetalleDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVerDetalleDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVerDetalleDebe.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleDebe.ForeColor = System.Drawing.Color.White
        Me.btnVerDetalleDebe.Image = CType(resources.GetObject("btnVerDetalleDebe.Image"), System.Drawing.Image)
        Me.btnVerDetalleDebe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalleDebe.Location = New System.Drawing.Point(33, 104)
        Me.btnVerDetalleDebe.Name = "btnVerDetalleDebe"
        Me.btnVerDetalleDebe.Size = New System.Drawing.Size(147, 47)
        Me.btnVerDetalleDebe.TabIndex = 28
        Me.btnVerDetalleDebe.Text = "  Comentario"
        Me.btnVerDetalleDebe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerDetalleDebe.UseVisualStyleBackColor = False
        '
        'btnOcultarDetalleDebe
        '
        Me.btnOcultarDetalleDebe.BackColor = System.Drawing.Color.Crimson
        Me.btnOcultarDetalleDebe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarDetalleDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnOcultarDetalleDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOcultarDetalleDebe.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarDetalleDebe.ForeColor = System.Drawing.Color.White
        Me.btnOcultarDetalleDebe.Image = CType(resources.GetObject("btnOcultarDetalleDebe.Image"), System.Drawing.Image)
        Me.btnOcultarDetalleDebe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOcultarDetalleDebe.Location = New System.Drawing.Point(32, 105)
        Me.btnOcultarDetalleDebe.Name = "btnOcultarDetalleDebe"
        Me.btnOcultarDetalleDebe.Size = New System.Drawing.Size(147, 47)
        Me.btnOcultarDetalleDebe.TabIndex = 28
        Me.btnOcultarDetalleDebe.Text = "  Comentario"
        Me.btnOcultarDetalleDebe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOcultarDetalleDebe.UseVisualStyleBackColor = False
        Me.btnOcultarDetalleDebe.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "$"
        '
        'txtDetalleDebe
        '
        Me.txtDetalleDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleDebe.Location = New System.Drawing.Point(32, 157)
        Me.txtDetalleDebe.Name = "txtDetalleDebe"
        Me.txtDetalleDebe.Size = New System.Drawing.Size(292, 26)
        Me.txtDetalleDebe.TabIndex = 5
        Me.txtDetalleDebe.Visible = False
        '
        'btnActualizarDeuda
        '
        Me.btnActualizarDeuda.BackColor = System.Drawing.Color.Black
        Me.btnActualizarDeuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarDeuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnActualizarDeuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnActualizarDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarDeuda.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarDeuda.ForeColor = System.Drawing.Color.White
        Me.btnActualizarDeuda.Location = New System.Drawing.Point(245, 210)
        Me.btnActualizarDeuda.Name = "btnActualizarDeuda"
        Me.btnActualizarDeuda.Size = New System.Drawing.Size(94, 37)
        Me.btnActualizarDeuda.TabIndex = 3
        Me.btnActualizarDeuda.Text = "Guardar"
        Me.btnActualizarDeuda.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(32, 221)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(155, 20)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Importante (Notas)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dinero"
        '
        'txtDineroDebe
        '
        Me.txtDineroDebe.Location = New System.Drawing.Point(46, 59)
        Me.txtDineroDebe.MaxLength = 7
        Me.txtDineroDebe.Name = "txtDineroDebe"
        Me.txtDineroDebe.Size = New System.Drawing.Size(133, 27)
        Me.txtDineroDebe.TabIndex = 0
        '
        'CuentaCorrienteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1010, 750)
        Me.Controls.Add(Me.gbDebe)
        Me.Controls.Add(Me.gbHaber)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnOcultarRegistro)
        Me.Controls.Add(Me.btnVerRegistro)
        Me.Controls.Add(Me.gbRegistroCompras)
        Me.Controls.Add(Me.pbActualizarTabla)
        Me.Controls.Add(Me.dgvProveedores)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHaber)
        Me.Controls.Add(Me.btnDebe)
        Me.Controls.Add(Me.txtBuscarClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuentaCorrienteProveedor"
        Me.Text = "Pruebas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbActualizarTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRegistroCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistroCompras.ResumeLayout(False)
        Me.gbRegistroCompras.PerformLayout()
        Me.gbHaber.ResumeLayout(False)
        Me.gbHaber.PerformLayout()
        Me.gbDebe.ResumeLayout(False)
        Me.gbDebe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarClientes As System.Windows.Forms.TextBox
    Friend WithEvents btnDebe As System.Windows.Forms.Button
    Friend WithEvents btnHaber As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbActualizarTabla As System.Windows.Forms.PictureBox
    Friend WithEvents gbRegistroCompras As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerRegistro As System.Windows.Forms.Button
    Friend WithEvents btnOcultarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnPagarTodoRegistro As System.Windows.Forms.Button
    Friend WithEvents gbHaber As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDineroHaber As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrarHaber As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnVerDetalleHaber As System.Windows.Forms.Button
    Friend WithEvents btnOcultarDetalleHaber As System.Windows.Forms.Button
    Friend WithEvents txtDetalleHaber As System.Windows.Forms.TextBox
    Friend WithEvents chkRegistroCompleto As System.Windows.Forms.CheckBox
    Friend WithEvents chkCobros As System.Windows.Forms.CheckBox
    Public WithEvents dgvProveedores As Guna.UI.WinForms.GunaDataGridView
    Public WithEvents dgvRegistroCompras As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnDescontarHaber As System.Windows.Forms.Button
    Friend WithEvents gbDebe As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrarInfo As System.Windows.Forms.Button
    Friend WithEvents btnVerDetalleDebe As System.Windows.Forms.Button
    Friend WithEvents btnOcultarDetalleDebe As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDetalleDebe As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizarDeuda As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDineroDebe As System.Windows.Forms.TextBox
End Class
