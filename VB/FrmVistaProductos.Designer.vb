<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaProductos
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
        Me.CmdEliminar = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Cmb = New System.Windows.Forms.ComboBox()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Location = New System.Drawing.Point(677, 215)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(75, 23)
        Me.CmdEliminar.TabIndex = 5
        Me.CmdEliminar.Text = "Eliminar"
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(677, 243)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 6
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Location = New System.Drawing.Point(677, 186)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CmdGuardar.TabIndex = 4
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(67, 240)
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TextPrecio.TabIndex = 2
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(318, 186)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(326, 20)
        Me.TextNombre.TabIndex = 1
        '
        'TextID
        '
        Me.TextID.Enabled = False
        Me.TextID.Location = New System.Drawing.Point(67, 186)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(100, 20)
        Me.TextID.TabIndex = 0
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(204, 243)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.LblCategoria.TabIndex = 16
        Me.LblCategoria.Text = "Categoria:"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(9, 243)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LblPrecio.TabIndex = 14
        Me.LblPrecio.Text = "Precio"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(205, 186)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 12
        Me.LblNombre.Text = "Nombre:"
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(23, 186)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(21, 13)
        Me.LblId.TabIndex = 10
        Me.LblId.Text = "ID:"
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(12, 12)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(776, 150)
        Me.Grilla.TabIndex = 8
        '
        'Cmb
        '
        Me.Cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb.FormattingEnabled = True
        Me.Cmb.Location = New System.Drawing.Point(318, 234)
        Me.Cmb.Name = "Cmb"
        Me.Cmb.Size = New System.Drawing.Size(121, 21)
        Me.Cmb.TabIndex = 3
        '
        'FrmVistaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 271)
        Me.Controls.Add(Me.Cmb)
        Me.Controls.Add(Me.CmdEliminar)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Controls.Add(Me.TextPrecio)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.Grilla)
        Me.Name = "FrmVistaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM de Productos"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdEliminar As Button
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdGuardar As Button
    Friend WithEvents TextPrecio As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextID As TextBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblId As Label
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents Cmb As ComboBox
End Class
