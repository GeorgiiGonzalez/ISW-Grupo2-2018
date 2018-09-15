<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_direccion_cliente_carga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_documentoERROR = New System.Windows.Forms.Label()
        Me.txt_descipcion_cliente_carga = New System.Windows.Forms.TextBox()
        Me.lbl_tipodocERROR = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_apellidoERROR = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telefono_cliente_carga = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.col_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_totalVENTA = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnt_horaProgramada = New System.Windows.Forms.Button()
        Me.bnt_antesPosible = New System.Windows.Forms.Button()
        Me.btn_Tarjeta = New System.Windows.Forms.Button()
        Me.btn_Efectivo = New System.Windows.Forms.Button()
        Me.btn_cancelarPedido = New System.Windows.Forms.Button()
        Me.btn_aceptarPedido = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_direccion_cliente_carga
        '
        Me.txt_direccion_cliente_carga.Enabled = False
        Me.txt_direccion_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_direccion_cliente_carga.Location = New System.Drawing.Point(141, 33)
        Me.txt_direccion_cliente_carga.Name = "txt_direccion_cliente_carga"
        Me.txt_direccion_cliente_carga.Size = New System.Drawing.Size(217, 25)
        Me.txt_direccion_cliente_carga.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción: (*)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_direccion_cliente_carga)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_documentoERROR)
        Me.GroupBox2.Controls.Add(Me.txt_descipcion_cliente_carga)
        Me.GroupBox2.Controls.Add(Me.lbl_tipodocERROR)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_apellidoERROR)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_telefono_cliente_carga)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 161)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lugar de Entrega"
        '
        'lbl_documentoERROR
        '
        Me.lbl_documentoERROR.AutoSize = True
        Me.lbl_documentoERROR.Location = New System.Drawing.Point(364, 129)
        Me.lbl_documentoERROR.Name = "lbl_documentoERROR"
        Me.lbl_documentoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_documentoERROR.TabIndex = 27
        Me.lbl_documentoERROR.Text = "   "
        Me.lbl_documentoERROR.Visible = False
        '
        'txt_descipcion_cliente_carga
        '
        Me.txt_descipcion_cliente_carga.Enabled = False
        Me.txt_descipcion_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descipcion_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_descipcion_cliente_carga.Location = New System.Drawing.Point(141, 64)
        Me.txt_descipcion_cliente_carga.Name = "txt_descipcion_cliente_carga"
        Me.txt_descipcion_cliente_carga.Size = New System.Drawing.Size(217, 25)
        Me.txt_descipcion_cliente_carga.TabIndex = 1
        '
        'lbl_tipodocERROR
        '
        Me.lbl_tipodocERROR.AutoSize = True
        Me.lbl_tipodocERROR.Location = New System.Drawing.Point(364, 98)
        Me.lbl_tipodocERROR.Name = "lbl_tipodocERROR"
        Me.lbl_tipodocERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_tipodocERROR.TabIndex = 27
        Me.lbl_tipodocERROR.Text = "   "
        Me.lbl_tipodocERROR.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dirección: (*)"
        '
        'lbl_apellidoERROR
        '
        Me.lbl_apellidoERROR.AutoSize = True
        Me.lbl_apellidoERROR.Location = New System.Drawing.Point(364, 58)
        Me.lbl_apellidoERROR.Name = "lbl_apellidoERROR"
        Me.lbl_apellidoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_apellidoERROR.TabIndex = 27
        Me.lbl_apellidoERROR.Text = "   "
        Me.lbl_apellidoERROR.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(29, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(344, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(81, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Teléfono:"
        '
        'txt_telefono_cliente_carga
        '
        Me.txt_telefono_cliente_carga.Enabled = False
        Me.txt_telefono_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_telefono_cliente_carga.Location = New System.Drawing.Point(165, 98)
        Me.txt_telefono_cliente_carga.Mask = "99999999999"
        Me.txt_telefono_cliente_carga.Name = "txt_telefono_cliente_carga"
        Me.txt_telefono_cliente_carga.Size = New System.Drawing.Size(91, 25)
        Me.txt_telefono_cliente_carga.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(902, 47)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Pedido a Comercio Adherido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_totalVENTA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgv_clientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(483, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 302)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mi carrito"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Producto, Me.col_Precio, Me.col_Cantidad})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_clientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_clientes.Location = New System.Drawing.Point(18, 33)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_clientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_clientes.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_clientes.Size = New System.Drawing.Size(375, 197)
        Me.dgv_clientes.TabIndex = 3
        '
        'col_Producto
        '
        Me.col_Producto.HeaderText = "Producto"
        Me.col_Producto.Name = "col_Producto"
        Me.col_Producto.ReadOnly = True
        Me.col_Producto.Width = 120
        '
        'col_Precio
        '
        Me.col_Precio.HeaderText = "Precio"
        Me.col_Precio.Name = "col_Precio"
        Me.col_Precio.ReadOnly = True
        Me.col_Precio.Width = 120
        '
        'col_Cantidad
        '
        Me.col_Cantidad.HeaderText = "Cantidad"
        Me.col_Cantidad.Name = "col_Cantidad"
        Me.col_Cantidad.ReadOnly = True
        Me.col_Cantidad.Width = 95
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total a Pagar: "
        '
        'txt_totalVENTA
        '
        Me.txt_totalVENTA.Enabled = False
        Me.txt_totalVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalVENTA.ForeColor = System.Drawing.Color.Black
        Me.txt_totalVENTA.Location = New System.Drawing.Point(154, 257)
        Me.txt_totalVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalVENTA.Name = "txt_totalVENTA"
        Me.txt_totalVENTA.Size = New System.Drawing.Size(105, 25)
        Me.txt_totalVENTA.TabIndex = 15
        Me.txt_totalVENTA.Text = "0"
        Me.txt_totalVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_Tarjeta)
        Me.GroupBox3.Controls.Add(Me.btn_Efectivo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox3.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(405, 111)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "   "
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "   "
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "   "
        Me.Label9.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bnt_horaProgramada)
        Me.GroupBox4.Controls.Add(Me.bnt_antesPosible)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 354)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(405, 111)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hora de Entrega"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "   "
        Me.Label4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "   "
        Me.Label8.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(364, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "   "
        Me.Label10.Visible = False
        '
        'bnt_horaProgramada
        '
        Me.bnt_horaProgramada.BackColor = System.Drawing.Color.White
        Me.bnt_horaProgramada.Enabled = False
        Me.bnt_horaProgramada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_horaProgramada.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_horaProgramada.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bnt_horaProgramada.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_reloj_40
        Me.bnt_horaProgramada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_horaProgramada.Location = New System.Drawing.Point(210, 30)
        Me.bnt_horaProgramada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bnt_horaProgramada.Name = "bnt_horaProgramada"
        Me.bnt_horaProgramada.Size = New System.Drawing.Size(163, 45)
        Me.bnt_horaProgramada.TabIndex = 29
        Me.bnt_horaProgramada.Text = "Hora programada"
        Me.bnt_horaProgramada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_horaProgramada.UseVisualStyleBackColor = False
        '
        'bnt_antesPosible
        '
        Me.bnt_antesPosible.BackColor = System.Drawing.Color.White
        Me.bnt_antesPosible.Enabled = False
        Me.bnt_antesPosible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_antesPosible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_antesPosible.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bnt_antesPosible.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_ejercicio_40
        Me.bnt_antesPosible.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_antesPosible.Location = New System.Drawing.Point(20, 30)
        Me.bnt_antesPosible.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bnt_antesPosible.Name = "bnt_antesPosible"
        Me.bnt_antesPosible.Size = New System.Drawing.Size(154, 45)
        Me.bnt_antesPosible.TabIndex = 28
        Me.bnt_antesPosible.Text = "Lo antes posible"
        Me.bnt_antesPosible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_antesPosible.UseVisualStyleBackColor = False
        '
        'btn_Tarjeta
        '
        Me.btn_Tarjeta.BackColor = System.Drawing.Color.White
        Me.btn_Tarjeta.Enabled = False
        Me.btn_Tarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Tarjeta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tarjeta.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_Tarjeta.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_efectivo_en_mano_40
        Me.btn_Tarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Tarjeta.Location = New System.Drawing.Point(210, 30)
        Me.btn_Tarjeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Tarjeta.Name = "btn_Tarjeta"
        Me.btn_Tarjeta.Size = New System.Drawing.Size(121, 45)
        Me.btn_Tarjeta.TabIndex = 29
        Me.btn_Tarjeta.Text = "Tarjeta"
        Me.btn_Tarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Tarjeta.UseVisualStyleBackColor = False
        '
        'btn_Efectivo
        '
        Me.btn_Efectivo.BackColor = System.Drawing.Color.White
        Me.btn_Efectivo.Enabled = False
        Me.btn_Efectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Efectivo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Efectivo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_Efectivo.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_tarjetas_bancarias_40
        Me.btn_Efectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Efectivo.Location = New System.Drawing.Point(53, 30)
        Me.btn_Efectivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Efectivo.Name = "btn_Efectivo"
        Me.btn_Efectivo.Size = New System.Drawing.Size(121, 45)
        Me.btn_Efectivo.TabIndex = 28
        Me.btn_Efectivo.Text = "Efectivo"
        Me.btn_Efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Efectivo.UseVisualStyleBackColor = False
        '
        'btn_cancelarPedido
        '
        Me.btn_cancelarPedido.BackColor = System.Drawing.Color.White
        Me.btn_cancelarPedido.Enabled = False
        Me.btn_cancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelarPedido.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancelarPedido.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_cancelar_40
        Me.btn_cancelarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelarPedido.Location = New System.Drawing.Point(696, 354)
        Me.btn_cancelarPedido.Name = "btn_cancelarPedido"
        Me.btn_cancelarPedido.Size = New System.Drawing.Size(98, 45)
        Me.btn_cancelarPedido.TabIndex = 32
        Me.btn_cancelarPedido.Text = "Cancelar"
        Me.btn_cancelarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelarPedido.UseVisualStyleBackColor = False
        Me.btn_cancelarPedido.Visible = False
        '
        'btn_aceptarPedido
        '
        Me.btn_aceptarPedido.BackColor = System.Drawing.Color.White
        Me.btn_aceptarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptarPedido.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_aceptarPedido.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_de_acuerdo_40
        Me.btn_aceptarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptarPedido.Location = New System.Drawing.Point(526, 354)
        Me.btn_aceptarPedido.Name = "btn_aceptarPedido"
        Me.btn_aceptarPedido.Size = New System.Drawing.Size(98, 45)
        Me.btn_aceptarPedido.TabIndex = 30
        Me.btn_aceptarPedido.Text = "Aceptar"
        Me.btn_aceptarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptarPedido.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(902, 477)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelarPedido)
        Me.Controls.Add(Me.btn_aceptarPedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancelarPedido As Button
    Friend WithEvents btn_aceptarPedido As Button
    Friend WithEvents txt_direccion_cliente_carga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_documentoERROR As Label
    Friend WithEvents txt_descipcion_cliente_carga As TextBox
    Friend WithEvents lbl_tipodocERROR As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_apellidoERROR As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_telefono_cliente_carga As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents col_Producto As DataGridViewTextBoxColumn
    Friend WithEvents col_Precio As DataGridViewTextBoxColumn
    Friend WithEvents col_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents txt_totalVENTA As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Tarjeta As Button
    Friend WithEvents btn_Efectivo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents bnt_horaProgramada As Button
    Friend WithEvents bnt_antesPosible As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
End Class
