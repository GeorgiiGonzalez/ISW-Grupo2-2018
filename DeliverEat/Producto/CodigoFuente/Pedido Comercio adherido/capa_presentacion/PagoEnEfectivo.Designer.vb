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
        Me.txt_vuelto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pago = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cancelarPago = New System.Windows.Forms.Button()
        Me.btn_aceptarPago = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.txt_vuelto)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_pago)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btn_cancelarPago)
        Me.GroupBox3.Controls.Add(Me.btn_aceptarPago)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox3.Location = New System.Drawing.Point(36, 30)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(445, 217)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pago En Efectivo"
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Enabled = False
        Me.txt_vuelto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vuelto.ForeColor = System.Drawing.Color.Black
        Me.txt_vuelto.Location = New System.Drawing.Point(264, 91)
        Me.txt_vuelto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Size = New System.Drawing.Size(117, 29)
        Me.txt_vuelto.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Mi vuelto:"
        '
        'txt_pago
        '
        Me.txt_pago.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pago.ForeColor = System.Drawing.Color.Black
        Me.txt_pago.Location = New System.Drawing.Point(264, 48)
        Me.txt_pago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pago.Name = "txt_pago"
        Me.txt_pago.Size = New System.Drawing.Size(117, 29)
        Me.txt_pago.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Pagaré Con:"
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
        Me.btn_cancelarPago.Location = New System.Drawing.Point(233, 143)
        Me.btn_cancelarPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelarPago.Name = "btn_cancelarPago"
        Me.btn_cancelarPago.Size = New System.Drawing.Size(149, 55)
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
        Me.btn_aceptarPago.Location = New System.Drawing.Point(45, 143)
        Me.btn_aceptarPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_aceptarPago.Name = "btn_aceptarPago"
        Me.btn_aceptarPago.Size = New System.Drawing.Size(131, 55)
        Me.btn_aceptarPago.TabIndex = 31
        Me.btn_aceptarPago.Text = "Aceptar"
        Me.btn_aceptarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptarPago.UseVisualStyleBackColor = False
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(485, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "   "
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(485, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 23)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "   "
        Me.Label9.Visible = False
        '
        'PagoEnEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 294)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents txt_vuelto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pago As TextBox
End Class
