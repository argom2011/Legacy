Public Class FrmVistaProductos
    Private miControlador As New Controlador
    Dim producto As Controlador

    Public Sub New()

        InitializeComponent()
        producto = New Controlador()
        CargarDatos()

        Dim items As New List(Of String)()
        items.Add("Item 1")
        items.Add("Item 2")
        items.Add("Item 3")
        Cmb.DataSource = items
    End Sub

    Private Sub CargarDatos()

        Dim productos As List(Of ClsModeloProductos) = producto.ObtenerProductos()
        Grilla.DataSource = productos

    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click

        Dim productos As New ClsModeloProductos

        productos.id = Val(TextID.Text)
        productos.nombre = TextNombre.Text.Trim()
        productos.precio = TextPrecio.Text
        productos.categoria = Cmb.Text

        Dim Guardar As New Controlador

        Guardar.GuardarProducto(productos)

        CargarDatos()
        LimpiarTextBox()
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click

        Me.Close()

    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick

        ' Verifica que el clic se haya realizado en una celda válida

        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            ' Accede al valor de la celda seleccionada
            TextID.Text = Grilla.Rows(e.RowIndex).Cells(0).Value
            TextNombre.Text = Grilla.Rows(e.RowIndex).Cells(1).Value
            TextPrecio.Text = Grilla.Rows(e.RowIndex).Cells(2).Value
            Cmb.Text = Grilla.Rows(e.RowIndex).Cells(3).Value
        End If

    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles CmdEliminar.Click

        If MsgBox("¿Esta seguro de eliminar el dato seleccionado?", vbYesNo, "Sistemas") = vbYes Then

            Dim productos As New ClsModeloProductos

            productos.id = Val(TextID.Text)

            Dim Eliminar As New Controlador

            Eliminar.EliminarProducto(productos)

        End If

        CargarDatos() : LimpiarTextBox()
    End Sub

    Private Sub TextPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPrecio.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub LimpiarTextBox()

        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                ' Borra el contenido del TextBox
                DirectCast(control, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub FrmVistaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick

    End Sub
End Class