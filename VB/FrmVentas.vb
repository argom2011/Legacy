

Public Class FrmVentas
    Private categoriaController As New Controlador()
    Dim cargargrilla As New List(Of ClsModeloVenta)()

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combinados() : CargarGrillas()
    End Sub

    Private Sub Combinados()

        Dim clientes As List(Of ClsModeloClientes) = categoriaController.ObtenerClientes()

        Cmb.DataSource = clientes
        Cmb.DisplayMember = "Cliente"
        Cmb.ValueMember = "Id"

        Dim categorias As List(Of ClsModeloProductos) = categoriaController.ObtenerCategoriasProductos()

        Cmb2.DataSource = categorias
        Cmb2.DisplayMember = "Nombre"
        Cmb2.ValueMember = "Id"

    End Sub

    Private Sub CargarGrillas()

        Grilla.RowHeadersWidth = 20
        Grilla.AllowUserToAddRows = False
        Grilla.ColumnCount = 4
        Grilla.Columns.Item(0).HeaderText = "Producto"
        Grilla.Columns.Item(0).Name = "idproducto"
        Grilla.Columns.Item(0).Width = 60
        Grilla.Columns.Item(1).HeaderText = "Precio unitario"
        Grilla.Columns.Item(1).Name = "preciounitario"
        Grilla.Columns.Item(1).Width = 100
        Grilla.Columns.Item(2).HeaderText = "Cantidad"
        Grilla.Columns.Item(2).Name = "cantidad"
        Grilla.Columns.Item(2).Width = 90
        Grilla.Columns.Item(3).HeaderText = "Precio Total"
        Grilla.Columns.Item(3).Width = 90
        Grilla.Columns.Item(3).Name = "preciototal"
        Grilla.Columns.Item(3).SortMode = True

    End Sub
    Private Sub Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb.SelectedIndexChanged


        Dim Cliente As ClsModeloClientes = categoriaController.ObtenerDatosCliente(Val(Cmb.Text))

        textCliente.Text = Cliente.cliente
        textTelefono.Text = Cliente.telefono
        textMail.Text = Cliente.correo
    End Sub

    Private Sub Cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb2.SelectedIndexChanged

        Dim Producto As ClsModeloProductos = categoriaController.ObtenerDatosProductos(Val(Cmb2.Text))

        textNombre.Text = Producto.nombre
        textPrecio.Text = Producto.precio
        textCategoria.Text = Producto.categoria

    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub textCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCantidad.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub CmdAgregar_Click(sender As Object, e As EventArgs) Handles CmdAgregar.Click

        If Val(textCantidad.Text) = 0 Then
            MsgBox("Ingrese cantidad", vbInformation, "Sistemas")
            textCantidad.Select()
            Exit Sub
        End If

        textTotal.Text = textPrecio.Text * Val(textCantidad.Text)

        Grilla.Rows.Add(Val(Cmb2.Text), textPrecio.Text, Val(textCantidad.Text), textTotal.Text) : textCantidad.Text = 0

    End Sub

    Private Sub CmdConfirmar_Click(sender As Object, e As EventArgs) Handles CmdConfirmar.Click

        If MsgBox("¿Confirma?", vbYesNo, "Sistemas") = vbYes Then

            For Each fila As DataGridViewRow In Grilla.Rows
                ' Crea una nueva instancia de Persona y asigna los valores de las celdas
                Dim nuevaVenta As New ClsModeloVenta()
                nuevaVenta.id = Val(Cmb.Text)
                nuevaVenta.idproducto = Val(fila.Cells("idproducto").Value.ToString())
                nuevaVenta.preciounitario = Val(fila.Cells("preciounitario").Value)
                nuevaVenta.cantidad = Val(fila.Cells("cantidad").Value.ToString())
                nuevaVenta.preciototal = Val(fila.Cells("preciototal").Value.ToString())

                ' Agrega la nueva persona a la lista de personas en el Modelo
                cargargrilla.Add(nuevaVenta)
            Next
            categoriaController.GuardarVenta(Val(Cmb.Text), cargargrilla)

            Grilla.Rows.Clear()

            CargarGrillas()
        End If

    End Sub
End Class