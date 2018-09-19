<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hora
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_direccion_cliente_carga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cancelarHora = New System.Windows.Forms.Button()
        Me.btn_aceptarHora = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.GroupBox3.Controls.Add(Me.btn_cancelarHora)
        Me.GroupBox3.Controls.Add(Me.btn_aceptarHora)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox3.Location = New System.Drawing.Point(32, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 176)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "¿Cuándo quieres recibirlo?"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(187, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 25)
        Me.TextBox1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Horario:"
        '
        'txt_direccion_cliente_carga
        '
        Me.txt_direccion_cliente_carga.Enabled = False
        Me.txt_direccion_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_direccion_cliente_carga.Location = New System.Drawing.Point(187, 39)
        Me.txt_direccion_cliente_carga.Name = "txt_direccion_cliente_carga"
        Me.txt_direccion_cliente_carga.Size = New System.Drawing.Size(89, 25)
        Me.txt_direccion_cliente_carga.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Dia:"
        '
        'btn_cancelarHora
        '
        Me.btn_cancelarHora.BackColor = System.Drawing.Color.White
        Me.btn_cancelarHora.Enabled = False
        Me.btn_cancelarHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelarHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelarHora.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancelarHora.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_cancelar_40
        Me.btn_cancelarHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelarHora.Location = New System.Drawing.Point(187, 118)
        Me.btn_cancelarHora.Name = "btn_cancelarHora"
        Me.btn_cancelarHora.Size = New System.Drawing.Size(103, 45)
        Me.btn_cancelarHora.TabIndex = 33
        Me.btn_cancelarHora.Text = "Cancelar"
        Me.btn_cancelarHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelarHora.UseVisualStyleBackColor = False
        Me.btn_cancelarHora.Visible = False
        '
        'btn_aceptarHora
        '
        Me.btn_aceptarHora.BackColor = System.Drawing.Color.White
        Me.btn_aceptarHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptarHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarHora.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_aceptarHora.Image = Global.Pedido_Comercio_adherido.My.Resources.Resources.icons8_de_acuerdo_40
        Me.btn_aceptarHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptarHora.Location = New System.Drawing.Point(34, 118)
        Me.btn_aceptarHora.Name = "btn_aceptarHora"
        Me.btn_aceptarHora.Size = New System.Drawing.Size(103, 45)
        Me.btn_aceptarHora.TabIndex = 31
        Me.btn_aceptarHora.Text = "Aceptar"
        Me.btn_aceptarHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptarHora.UseVisualStyleBackColor = False
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
        'Hora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 235)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Hora"
        Me.Text = "Hora"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_direccion_cliente_carga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cancelarHora As Button
    Friend WithEvents btn_aceptarHora As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
