Public Class FrmVistaClientes

    Dim controlador As Controlador

    Public Sub New()

        InitializeComponent()
        controlador = New Controlador()
        CargarDatos()

    End Sub

    Private Sub CargarDatos()

        Dim contactos As List(Of ClsModeloClientes) = controlador.ObtenerContactos()
        Grilla.DataSource = contactos

    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click

        Dim Cliente As New ClsModeloClientes

        Cliente.id = Val(TextID.Text)
        Cliente.cliente = TextCliente.Text.Trim()
        Cliente.telefono = TextTelefono.Text.Trim()
        Cliente.correo = TextCorreo.Text.Trim()

        Dim Guardar As New Controlador

        Guardar.GuardarContacto(Cliente)

        CargarDatos()
        LimpiarTextBox
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click

        Me.Close()

    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick

        ' Verifica que el clic se haya realizado en una celda válida

        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            ' Accede al valor de la celda seleccionada
            TextID.Text = Grilla.Rows(e.RowIndex).Cells(0).Value
            TextCliente.Text = Grilla.Rows(e.RowIndex).Cells(1).Value
            TextTelefono.Text = Grilla.Rows(e.RowIndex).Cells(2).Value
            TextCorreo.Text = Grilla.Rows(e.RowIndex).Cells(3).Value
        End If

    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles CmdEliminar.Click

        If MsgBox("¿Esta seguro de eliminar el dato seleccionado?", vbYesNo, "Sistemas") = vbYes Then

            Dim Cliente As New ClsModeloClientes

            Cliente.id = Val(TextID.Text)

            Dim Eliminar As New Controlador

            Eliminar.EliminarContacto(Cliente)

        End If

        CargarDatos() : LimpiarTextBox()
    End Sub

    Private Sub LimpiarTextBox()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                ' Borra el contenido del TextBox
                DirectCast(control, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub FrmVistaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick

    End Sub
End Class