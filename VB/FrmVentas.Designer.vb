<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Cmb = New System.Windows.Forms.ComboBox()
        Me.textCliente = New System.Windows.Forms.TextBox()
        Me.textTelefono = New System.Windows.Forms.TextBox()
        Me.textMail = New System.Windows.Forms.TextBox()
        Me.textCategoria = New System.Windows.Forms.TextBox()
        Me.textPrecio = New System.Windows.Forms.TextBox()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.Cmb2 = New System.Windows.Forms.ComboBox()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl10 = New System.Windows.Forms.Label()
        Me.Lbl9 = New System.Windows.Forms.Label()
        Me.textCantidad = New System.Windows.Forms.TextBox()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.CmdAgregar = New System.Windows.Forms.Button()
        Me.CmdConfirmar = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(22, 9)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(77, 13)
        Me.Lbl.TabIndex = 0
        Me.Lbl.Text = "Codigo cliente:"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(168, 9)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(42, 13)
        Me.Lbl2.TabIndex = 1
        Me.Lbl2.Text = "Cliente:"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(304, 9)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(52, 13)
        Me.Lbl3.TabIndex = 2
        Me.Lbl3.Text = "Telefono:"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(444, 9)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(29, 13)
        Me.Lbl4.TabIndex = 3
        Me.Lbl4.Text = "Mail:"
        '
        'Cmb
        '
        Me.Cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb.FormattingEnabled = True
        Me.Cmb.Location = New System.Drawing.Point(12, 29)
        Me.Cmb.Name = "Cmb"
        Me.Cmb.Size = New System.Drawing.Size(121, 21)
        Me.Cmb.TabIndex = 4
        '
        'textCliente
        '
        Me.textCliente.Enabled = False
        Me.textCliente.Location = New System.Drawing.Point(171, 30)
        Me.textCliente.Name = "textCliente"
        Me.textCliente.Size = New System.Drawing.Size(130, 20)
        Me.textCliente.TabIndex = 5
        '
        'textTelefono
        '
        Me.textTelefono.Enabled = False
        Me.textTelefono.Location = New System.Drawing.Point(307, 30)
        Me.textTelefono.Name = "textTelefono"
        Me.textTelefono.Size = New System.Drawing.Size(100, 20)
        Me.textTelefono.TabIndex = 6
        '
        'textMail
        '
        Me.textMail.Enabled = False
        Me.textMail.Location = New System.Drawing.Point(447, 30)
        Me.textMail.Name = "textMail"
        Me.textMail.Size = New System.Drawing.Size(202, 20)
        Me.textMail.TabIndex = 7
        '
        'textCategoria
        '
        Me.textCategoria.Enabled = False
        Me.textCategoria.Location = New System.Drawing.Point(447, 107)
        Me.textCategoria.Name = "textCategoria"
        Me.textCategoria.Size = New System.Drawing.Size(202, 20)
        Me.textCategoria.TabIndex = 15
        '
        'textPrecio
        '
        Me.textPrecio.Enabled = False
        Me.textPrecio.Location = New System.Drawing.Point(307, 107)
        Me.textPrecio.Name = "textPrecio"
        Me.textPrecio.Size = New System.Drawing.Size(100, 20)
        Me.textPrecio.TabIndex = 14
        '
        'textNombre
        '
        Me.textNombre.Enabled = False
        Me.textNombre.Location = New System.Drawing.Point(171, 107)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(130, 20)
        Me.textNombre.TabIndex = 13
        '
        'Cmb2
        '
        Me.Cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb2.FormattingEnabled = True
        Me.Cmb2.Location = New System.Drawing.Point(12, 106)
        Me.Cmb2.Name = "Cmb2"
        Me.Cmb2.Size = New System.Drawing.Size(121, 21)
        Me.Cmb2.TabIndex = 12
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Location = New System.Drawing.Point(444, 86)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(55, 13)
        Me.Lbl8.TabIndex = 11
        Me.Lbl8.Text = "Categoria:"
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Location = New System.Drawing.Point(304, 86)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(40, 13)
        Me.Lbl7.TabIndex = 10
        Me.Lbl7.Text = "Precio:"
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Location = New System.Drawing.Point(168, 86)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(47, 13)
        Me.Lbl6.TabIndex = 9
        Me.Lbl6.Text = "Nombre:"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Location = New System.Drawing.Point(22, 86)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(103, 13)
        Me.Lbl5.TabIndex = 8
        Me.Lbl5.Text = "Codigo de producto:"
        '
        'Lbl10
        '
        Me.Lbl10.AutoSize = True
        Me.Lbl10.Location = New System.Drawing.Point(162, 151)
        Me.Lbl10.Name = "Lbl10"
        Me.Lbl10.Size = New System.Drawing.Size(34, 13)
        Me.Lbl10.TabIndex = 17
        Me.Lbl10.Text = "Total:"
        '
        'Lbl9
        '
        Me.Lbl9.AutoSize = True
        Me.Lbl9.Location = New System.Drawing.Point(16, 151)
        Me.Lbl9.Name = "Lbl9"
        Me.Lbl9.Size = New System.Drawing.Size(52, 13)
        Me.Lbl9.TabIndex = 16
        Me.Lbl9.Text = "Cantidad:"
        '
        'textCantidad
        '
        Me.textCantidad.Location = New System.Drawing.Point(12, 183)
        Me.textCantidad.Name = "textCantidad"
        Me.textCantidad.Size = New System.Drawing.Size(100, 20)
        Me.textCantidad.TabIndex = 19
        '
        'textTotal
        '
        Me.textTotal.Enabled = False
        Me.textTotal.Location = New System.Drawing.Point(165, 183)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.Size = New System.Drawing.Size(100, 20)
        Me.textTotal.TabIndex = 20
        '
        'CmdAgregar
        '
        Me.CmdAgregar.Location = New System.Drawing.Point(19, 246)
        Me.CmdAgregar.Name = "CmdAgregar"
        Me.CmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.CmdAgregar.TabIndex = 22
        Me.CmdAgregar.Text = "Agregar"
        Me.CmdAgregar.UseVisualStyleBackColor = True
        '
        'CmdConfirmar
        '
        Me.CmdConfirmar.Location = New System.Drawing.Point(165, 246)
        Me.CmdConfirmar.Name = "CmdConfirmar"
        Me.CmdConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.CmdConfirmar.TabIndex = 23
        Me.CmdConfirmar.Text = "Confirmar"
        Me.CmdConfirmar.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(307, 246)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 24
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(670, 9)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(342, 194)
        Me.Grilla.TabIndex = 25
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 272)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdConfirmar)
        Me.Controls.Add(Me.CmdAgregar)
        Me.Controls.Add(Me.textTotal)
        Me.Controls.Add(Me.textCantidad)
        Me.Controls.Add(Me.Lbl10)
        Me.Controls.Add(Me.Lbl9)
        Me.Controls.Add(Me.textCategoria)
        Me.Controls.Add(Me.textPrecio)
        Me.Controls.Add(Me.textNombre)
        Me.Controls.Add(Me.Cmb2)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.textMail)
        Me.Controls.Add(Me.textTelefono)
        Me.Controls.Add(Me.textCliente)
        Me.Controls.Add(Me.Cmb)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Cmb As ComboBox
    Friend WithEvents textCliente As TextBox
    Friend WithEvents textTelefono As TextBox
    Friend WithEvents textMail As TextBox
    Friend WithEvents textCategoria As TextBox
    Friend WithEvents textPrecio As TextBox
    Friend WithEvents textNombre As TextBox
    Friend WithEvents Cmb2 As ComboBox
    Friend WithEvents Lbl8 As Label
    Friend WithEvents Lbl7 As Label
    Friend WithEvents Lbl6 As Label
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Lbl10 As Label
    Friend WithEvents Lbl9 As Label
    Friend WithEvents textCantidad As TextBox
    Friend WithEvents textTotal As TextBox
    Friend WithEvents CmdAgregar As Button
    Friend WithEvents CmdConfirmar As Button
    Friend WithEvents CmdSalir As Button
    Friend WithEvents Grilla As DataGridView
End Class
