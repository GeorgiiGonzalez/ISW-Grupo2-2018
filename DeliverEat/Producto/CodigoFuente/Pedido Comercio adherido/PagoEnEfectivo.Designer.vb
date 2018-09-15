<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoEnEfectivo
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_direccion_cliente_carga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_cancelarPago = New System.Windows.Forms.Button()
        Me.btn_aceptarPago = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_direccion_cliente_carga)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btn_cancelarPago)
        Me.GroupBox3.Controls.Add(Me.btn_aceptarPago)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox3.Location = New System.Drawing.Point(27, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 176)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pago En Efectivo"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Pagaré Con:"
        '
        'txt_direccion_cliente_carga
        '
        Me.txt_direccion_cliente_carga.Enabled = False
        Me.txt_direccion_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_direccion_cliente_carga.Location = New System.Drawing.Point(198, 39)
        Me.txt_direccion_cliente_carga.Name = "txt_direccion_cliente_carga"
        Me.txt_direccion_cliente_carga.Size = New System.Drawing.Size(89, 25)
        Me.txt_direccion_cliente_carga.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Mi vuelto:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(198, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 25)
        Me.TextBox1.TabIndex = 37
        '
        'btn_cancelarPago
        '
        Me.btn_cancelarPago.BackColor = System.Drawing.Color.White
        Me.btn_cancelarPago.Enabled = False
        Me.btn_cancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelarPago.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelarPago.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancelarPago.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_cancelar_40
        Me.btn_cancelarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelarPago.Location = New System.Drawing.Point(175, 116)
        Me.btn_cancelarPago.Name = "btn_cancelarPago"
        Me.btn_cancelarPago.Size = New System.Drawing.Size(112, 45)
        Me.btn_cancelarPago.TabIndex = 33
        Me.btn_cancelarPago.Text = "Cancelar"
        Me.btn_cancelarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelarPago.UseVisualStyleBackColor = False
        Me.btn_cancelarPago.Visible = False
        '
        'btn_aceptarPago
        '
        Me.btn_aceptarPago.BackColor = System.Drawing.Color.White
        Me.btn_aceptarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptarPago.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarPago.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_aceptarPago.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_de_acuerdo_40
        Me.btn_aceptarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptarPago.Location = New System.Drawing.Point(34, 116)
        Me.btn_aceptarPago.Name = "btn_aceptarPago"
        Me.btn_aceptarPago.Size = New System.Drawing.Size(98, 45)
        Me.btn_aceptarPago.TabIndex = 31
        Me.btn_aceptarPago.Text = "Aceptar"
        Me.btn_aceptarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptarPago.UseVisualStyleBackColor = False
        '
        'PagoEnEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 239)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "PagoEnEfectivo"
        Me.Text = "PagoEnEfectivo"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_aceptarPago As Button
    Friend WithEvents btn_cancelarPago As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_direccion_cliente_carga As TextBox
End Class
