<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaClientes
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
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.TextCliente = New System.Windows.Forms.TextBox()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdEliminar = New System.Windows.Forms.Button()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(12, 35)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(776, 150)
        Me.Grilla.TabIndex = 0
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(23, 209)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(21, 13)
        Me.LblId.TabIndex = 1
        Me.LblId.Text = "ID:"
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(205, 209)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(95, 13)
        Me.LblCliente.TabIndex = 2
        Me.LblCliente.Text = "Nombre y Apellido:"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(9, 266)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 3
        Me.LblTelefono.Text = "Telefono:"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(204, 266)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(96, 13)
        Me.LblCorreo.TabIndex = 4
        Me.LblCorreo.Text = "Correo electronico:"
        '
        'TextID
        '
        Me.TextID.Enabled = False
        Me.TextID.Location = New System.Drawing.Point(67, 209)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(100, 20)
        Me.TextID.TabIndex = 0
        '
        'TextCliente
        '
        Me.TextCliente.Location = New System.Drawing.Point(318, 209)
        Me.TextCliente.Name = "TextCliente"
        Me.TextCliente.Size = New System.Drawing.Size(326, 20)
        Me.TextCliente.TabIndex = 1
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(67, 263)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextTelefono.TabIndex = 2
        '
        'TextCorreo
        '
        Me.TextCorreo.Location = New System.Drawing.Point(318, 266)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(326, 20)
        Me.TextCorreo.TabIndex = 3
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Location = New System.Drawing.Point(677, 209)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CmdGuardar.TabIndex = 4
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(677, 266)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 6
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Location = New System.Drawing.Point(677, 238)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(75, 23)
        Me.CmdEliminar.TabIndex = 5
        Me.CmdEliminar.Text = "Eliminar"
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'FrmVistaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 292)
        Me.Controls.Add(Me.CmdEliminar)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Controls.Add(Me.TextCorreo)
        Me.Controls.Add(Me.TextTelefono)
        Me.Controls.Add(Me.TextCliente)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.Grilla)
        Me.Name = "FrmVistaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Clientes"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grilla As DataGridView
    Friend WithEvents LblId As Label
    Friend WithEvents LblCliente As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents TextCliente As TextBox
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents CmdGuardar As Button
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdEliminar As Button
End Class
