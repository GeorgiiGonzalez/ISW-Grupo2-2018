<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.txt_totalVENTA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Tarjeta = New System.Windows.Forms.Button()
        Me.btn_Efectivo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bnt_horaProgramada = New System.Windows.Forms.Button()
        Me.bnt_antesPosible = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.txt_direccion_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_direccion_cliente_carga.Location = New System.Drawing.Point(188, 41)
        Me.txt_direccion_cliente_carga.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion_cliente_carga.Name = "txt_direccion_cliente_carga"
        Me.txt_direccion_cliente_carga.Size = New System.Drawing.Size(288, 29)
        Me.txt_direccion_cliente_carga.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(52, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción (*)"
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(540, 198)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lugar de Entrega"
        '
        'lbl_documentoERROR
        '
        Me.lbl_documentoERROR.AutoSize = True
        Me.lbl_documentoERROR.Location = New System.Drawing.Point(485, 159)
        Me.lbl_documentoERROR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_documentoERROR.Name = "lbl_documentoERROR"
        Me.lbl_documentoERROR.Size = New System.Drawing.Size(25, 23)
        Me.lbl_documentoERROR.TabIndex = 27
        Me.lbl_documentoERROR.Text = "   "
        Me.lbl_documentoERROR.Visible = False
        '
        'txt_descipcion_cliente_carga
        '
        Me.txt_descipcion_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descipcion_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_descipcion_cliente_carga.Location = New System.Drawing.Point(188, 79)
        Me.txt_descipcion_cliente_carga.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descipcion_cliente_carga.Name = "txt_descipcion_cliente_carga"
        Me.txt_descipcion_cliente_carga.Size = New System.Drawing.Size(288, 29)
        Me.txt_descipcion_cliente_carga.TabIndex = 1
        '
        'lbl_tipodocERROR
        '
        Me.lbl_tipodocERROR.AutoSize = True
        Me.lbl_tipodocERROR.Location = New System.Drawing.Point(485, 121)
        Me.lbl_tipodocERROR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tipodocERROR.Name = "lbl_tipodocERROR"
        Me.lbl_tipodocERROR.Size = New System.Drawing.Size(25, 23)
        Me.lbl_tipodocERROR.TabIndex = 27
        Me.lbl_tipodocERROR.Text = "   "
        Me.lbl_tipodocERROR.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dirección (*)"
        '
        'lbl_apellidoERROR
        '
        Me.lbl_apellidoERROR.AutoSize = True
        Me.lbl_apellidoERROR.Location = New System.Drawing.Point(485, 71)
        Me.lbl_apellidoERROR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_apellidoERROR.Name = "lbl_apellidoERROR"
        Me.lbl_apellidoERROR.Size = New System.Drawing.Size(25, 23)
        Me.lbl_apellidoERROR.TabIndex = 27
        Me.lbl_apellidoERROR.Text = "   "
        Me.lbl_apellidoERROR.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(39, 159)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(448, 23)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(99, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Teléfono"
        '
        'txt_telefono_cliente_carga
        '
        Me.txt_telefono_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_telefono_cliente_carga.Location = New System.Drawing.Point(188, 117)
        Me.txt_telefono_cliente_carga.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefono_cliente_carga.Mask = "999999999"
        Me.txt_telefono_cliente_carga.Name = "txt_telefono_cliente_carga"
        Me.txt_telefono_cliente_carga.Size = New System.Drawing.Size(120, 29)
        Me.txt_telefono_cliente_carga.TabIndex = 5
        Me.txt_telefono_cliente_carga.ValidatingType = GetType(Integer)
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1203, 58)
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
        Me.GroupBox1.Location = New System.Drawing.Point(644, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(552, 372)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mi carrito"
        '
        'txt_totalVENTA
        '
        Me.txt_totalVENTA.Enabled = False
        Me.txt_totalVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalVENTA.ForeColor = System.Drawing.Color.Black
        Me.txt_totalVENTA.Location = New System.Drawing.Point(205, 316)
        Me.txt_totalVENTA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_totalVENTA.Name = "txt_totalVENTA"
        Me.txt_totalVENTA.Size = New System.Drawing.Size(139, 29)
        Me.txt_totalVENTA.TabIndex = 15
        Me.txt_totalVENTA.Text = "0"
        Me.txt_totalVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 320)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total a Pagar: "
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_clientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_clientes.Location = New System.Drawing.Point(24, 41)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(4)
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
        Me.dgv_clientes.Size = New System.Drawing.Size(500, 242)
        Me.dgv_clientes.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_Tarjeta)
        Me.GroupBox3.Controls.Add(Me.btn_Efectivo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox3.Location = New System.Drawing.Point(16, 267)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(540, 137)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'btn_Tarjeta
        '
        Me.btn_Tarjeta.BackColor = System.Drawing.Color.White
        Me.btn_Tarjeta.Enabled = False
        Me.btn_Tarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Tarjeta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tarjeta.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_Tarjeta.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_tarjetas_bancarias_40
        Me.btn_Tarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Tarjeta.Location = New System.Drawing.Point(280, 37)
        Me.btn_Tarjeta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Tarjeta.Name = "btn_Tarjeta"
        Me.btn_Tarjeta.Size = New System.Drawing.Size(161, 55)
        Me.btn_Tarjeta.TabIndex = 29
        Me.btn_Tarjeta.Text = "Tarjeta"
        Me.btn_Tarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Tarjeta.UseVisualStyleBackColor = False
        '
        'btn_Efectivo
        '
        Me.btn_Efectivo.BackColor = System.Drawing.Color.White
        Me.btn_Efectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Efectivo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Efectivo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_Efectivo.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_efectivo_en_mano_40
        Me.btn_Efectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Efectivo.Location = New System.Drawing.Point(71, 37)
        Me.btn_Efectivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Efectivo.Name = "btn_Efectivo"
        Me.btn_Efectivo.Size = New System.Drawing.Size(161, 55)
        Me.btn_Efectivo.TabIndex = 28
        Me.btn_Efectivo.Text = "Efectivo"
        Me.btn_Efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Efectivo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 159)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "   "
        Me.Label5.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bnt_horaProgramada)
        Me.GroupBox4.Controls.Add(Me.bnt_antesPosible)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox4.Location = New System.Drawing.Point(16, 436)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(540, 137)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hora de Entrega"
        '
        'bnt_horaProgramada
        '
        Me.bnt_horaProgramada.BackColor = System.Drawing.Color.White
        Me.bnt_horaProgramada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_horaProgramada.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_horaProgramada.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bnt_horaProgramada.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_reloj_40
        Me.bnt_horaProgramada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_horaProgramada.Location = New System.Drawing.Point(280, 37)
        Me.bnt_horaProgramada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bnt_horaProgramada.Name = "bnt_horaProgramada"
        Me.bnt_horaProgramada.Size = New System.Drawing.Size(217, 55)
        Me.bnt_horaProgramada.TabIndex = 29
        Me.bnt_horaProgramada.Text = "Hora programada"
        Me.bnt_horaProgramada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_horaProgramada.UseVisualStyleBackColor = False
        '
        'bnt_antesPosible
        '
        Me.bnt_antesPosible.BackColor = System.Drawing.Color.White
        Me.bnt_antesPosible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_antesPosible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_antesPosible.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bnt_antesPosible.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_ejercicio_40
        Me.bnt_antesPosible.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnt_antesPosible.Location = New System.Drawing.Point(27, 37)
        Me.bnt_antesPosible.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bnt_antesPosible.Name = "bnt_antesPosible"
        Me.bnt_antesPosible.Size = New System.Drawing.Size(205, 55)
        Me.bnt_antesPosible.TabIndex = 28
        Me.bnt_antesPosible.Text = "Lo antes posible"
        Me.bnt_antesPosible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_antesPosible.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "   "
        Me.Label4.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(485, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "   "
        Me.Label10.Visible = False
        '
        'btn_cancelarPedido
        '
        Me.btn_cancelarPedido.BackColor = System.Drawing.Color.White
        Me.btn_cancelarPedido.Enabled = False
        Me.btn_cancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelarPedido.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancelarPedido.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_cancelar_40
        Me.btn_cancelarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelarPedido.Location = New System.Drawing.Point(928, 436)
        Me.btn_cancelarPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelarPedido.Name = "btn_cancelarPedido"
        Me.btn_cancelarPedido.Size = New System.Drawing.Size(131, 55)
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
        Me.btn_aceptarPedido.Location = New System.Drawing.Point(701, 436)
        Me.btn_aceptarPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_aceptarPedido.Name = "btn_aceptarPedido"
        Me.btn_aceptarPedido.Size = New System.Drawing.Size(131, 55)
        Me.btn_aceptarPedido.TabIndex = 30
        Me.btn_aceptarPedido.Text = "Aceptar"
        Me.btn_aceptarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptarPedido.UseVisualStyleBackColor = False
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1203, 587)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelarPedido)
        Me.Controls.Add(Me.btn_aceptarPedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pedido"
        Me.Text = "Pedido"
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
    Friend WithEvents txt_totalVENTA As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Tarjeta As Button
    Friend WithEvents btn_Efectivo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents bnt_horaProgramada As Button
    Friend WithEvents bnt_antesPosible As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
End Class
