Imports System.Configuration
Imports System.Data.SqlClient

Public Class Controlador
    Private conexion As SqlConnection
    Private cadenaConexion As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Public Sub New()
        conexion = New SqlConnection(cadenaConexion)
        conexion.Open()
    End Sub
    'Clientes
    Public Function ObtenerContactos() As List(Of ClsModeloClientes)
        Dim contactos As New List(Of ClsModeloClientes)

        Try
            Using cmd As New SqlCommand("SELECT ID, Cliente, Telefono, Correo FROM pruebademo.dbo.clientes", conexion)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        contactos.Add(New ClsModeloClientes() With {
                        .id = CInt(reader("ID")),
                        .cliente = reader("Cliente").ToString(),
                        .telefono = reader("Telefono").ToString(),
                        .correo = reader("Correo").ToString()
                    })
                    End While
                End Using
            End Using

        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")

        End Try

        Return contactos
    End Function

    Public Sub GuardarContacto(contacto As ClsModeloClientes)

        Dim query As String

        If contacto.cliente = "" Then
            MsgBox("Ingrese un nombre", vbInformation, "Sistemas")
            Exit Sub
        End If

        If contacto.id = 0 Then
            query = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
        Else
            query = "update clientes set Cliente=@Cliente, Telefono=@Telefono, Correo=@Correo where id=@Id"
        End If

        Try
            Using cmd As New SqlCommand(query, conexion)

                If contacto.id <> 0 Then
                    cmd.Parameters.AddWithValue("@Id", contacto.id)
                End If

                cmd.Parameters.AddWithValue("@Cliente", contacto.cliente)
                cmd.Parameters.AddWithValue("@Telefono", contacto.telefono)
                cmd.Parameters.AddWithValue("@Correo", contacto.correo)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")


        End Try

    End Sub


    Public Sub EliminarContacto(contacto As ClsModeloClientes)

        Dim query As String = "Delete from clientes where id=@Id"
        Try
            Using cmd As New SqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@Id", contacto.id)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")

        End Try

    End Sub


    Public Function ObtenerClientes() As List(Of ClsModeloClientes)

        Dim clientes As New List(Of ClsModeloClientes)()

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                Dim query As String = "select Id,(Convert(varchar,ID) + '-' + Cliente) As Cliente from clientes"

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim cliente As New ClsModeloClientes()
                            cliente.id = Convert.ToInt32(reader("Id"))
                            cliente.cliente = reader("Cliente").ToString()
                            clientes.Add(cliente)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return clientes
    End Function

    Public Function ObtenerDatosCliente(ByVal Valor As Integer) As ClsModeloClientes
        Dim cliente As New ClsModeloClientes()

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                Dim query As String = "SELECT * FROM Clientes WHERE Id = @ClienteId"

                Using command As New SqlCommand(query, connection)
                    ' Puedes establecer el valor del parámetro Id según el cliente que deseas obtener
                    command.Parameters.AddWithValue("@ClienteId", Valor) ' Reemplaza 1 con el ID del cliente deseado

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            cliente.id = Convert.ToInt32(reader("Id"))
                            cliente.cliente = reader("Cliente").ToString()
                            cliente.telefono = reader("Telefono").ToString()
                            cliente.correo = reader("Correo").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return cliente
    End Function

    'Productos

    Public Function ObtenerProductos() As List(Of ClsModeloProductos)
        Dim contactos As New List(Of ClsModeloProductos)

        Try
            Using cmd As New SqlCommand("select * from productos", conexion)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        contactos.Add(New ClsModeloProductos() With {
                        .id = CInt(reader("ID")),
                        .nombre = reader("Nombre").ToString(),
                        .precio = reader("Precio").ToString(),
                        .categoria = reader("Categoria").ToString()
                    })
                    End While
                End Using
            End Using

        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")

        End Try

        Return contactos
    End Function

    Public Sub GuardarProducto(producto As ClsModeloProductos)

        Dim query As String

        If producto.nombre = "" Then
            MsgBox("Ingrese un nombre", vbInformation, "Sistemas")
            Exit Sub
        End If


        If producto.id = 0 Then
            query = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
        Else
            query = "update productos set Nombre=@Nombre, Precio=@Precio, Categoria=@Categoria where id=@Id"
        End If

        Try
            Using cmd As New SqlCommand(query, conexion)

                If producto.id <> 0 Then
                    cmd.Parameters.AddWithValue("@Id", producto.id)
                End If

                cmd.Parameters.AddWithValue("@Nombre", producto.nombre)
                cmd.Parameters.AddWithValue("@Precio", producto.precio)
                cmd.Parameters.AddWithValue("@Categoria", producto.categoria)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")


        End Try

    End Sub


    Public Sub EliminarProducto(producto As ClsModeloProductos)

        Dim query As String = "Delete from productos where id=@Id"
        Try
            Using cmd As New SqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@Id", producto.id)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")

        End Try

    End Sub


    Public Function ObtenerCategoriasProductos() As List(Of ClsModeloProductos)

        Dim categorias As New List(Of ClsModeloProductos)()

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                Dim query As String = "select Id,(Convert(varchar,ID) + '-' + Nombre) As Nombre from productos"

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim categoria As New ClsModeloProductos()
                            categoria.id = Convert.ToInt32(reader("Id"))
                            categoria.nombre = reader("Nombre").ToString()
                            categorias.Add(categoria)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return categorias
    End Function


    Public Function ObtenerDatosProductos(ByVal Valor As Integer) As ClsModeloProductos
        Dim producto As New ClsModeloProductos()

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                Dim query As String = "select * from productos WHERE Id = @ClienteId"

                Using command As New SqlCommand(query, connection)
                    ' Puedes establecer el valor del parámetro Id según el cliente que deseas obtener
                    command.Parameters.AddWithValue("@ClienteId", Valor) ' Reemplaza 1 con el ID del cliente deseado

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            producto.id = Convert.ToInt32(reader("Id"))
                            producto.nombre = reader("Nombre").ToString()
                            producto.precio = reader("Precio").ToString()
                            producto.categoria = reader("Categoria").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return producto
    End Function
    'Ventas

    Public Sub GuardarVenta(ByVal Cliente As Double, venta As List(Of ClsModeloVenta))

        Dim query As String, query2 As String, Total As Double

        query = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total)"

        query2 = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario,Cantidad,PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Try
            For Each ventasTotal As ClsModeloVenta In venta

                Total = Total + Convert.ToDouble(ventasTotal.preciototal)

            Next

            Using cmd As New SqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@IDCliente", Cliente)
                cmd.Parameters.AddWithValue("@Fecha", Date.Now)
                cmd.Parameters.AddWithValue("@Total", Total)
                cmd.ExecuteNonQuery()
            End Using

            Dim IdVenta As ClsModeloProductos = ObtenerMaximoVentas()

            For Each ventas As ClsModeloVenta In venta

                Using cmd As New SqlCommand(query2, conexion)
                    cmd.Parameters.AddWithValue("@IdVenta", IdVenta.id)
                    cmd.Parameters.AddWithValue("@IDProducto", ventas.idproducto)
                    cmd.Parameters.AddWithValue("@PrecioUnitario", ventas.preciounitario)
                    cmd.Parameters.AddWithValue("@Cantidad", ventas.cantidad)
                    cmd.Parameters.AddWithValue("@PrecioTotal", ventas.preciototal)
                    cmd.ExecuteNonQuery()
                End Using

            Next

        Catch ex As Exception

            MsgBox("Error por " & ex.Message, vbExclamation, "Sistemas")

        End Try

    End Sub


    Private Function ObtenerMaximoVentas() As ClsModeloProductos
        Dim Ventas As New ClsModeloProductos()

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                Dim query As String = "select max(id) As Maximo from ventas"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Ventas.id = Convert.ToInt32(reader("Maximo"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return Ventas
    End Function

    Public Function ObtenerVentas() As List(Of ClsModeloFacturaVenta)

        Dim ventas As New List(Of ClsModeloFacturaVenta)()
        Dim query As String

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                query = "select A.ID As Nro,A.IDCliente,C.Cliente, D.Nombre,sum(B.PrecioTotal) As Total from  "
                query = query & "ventas A inner join ventasitems B on A.ID=B.IDVenta inner join clientes c on A.IDCliente=C.ID "
                query = query & "inner join productos D on B.IDProducto=D.ID group by A.ID,A.IDCliente,C.Cliente,D.Nombre"

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim venta As New ClsModeloFacturaVenta()
                            venta.idfactura = reader("Nro")
                            venta.idcliente = reader("IDCliente")
                            venta.cliente = Trim(reader("Cliente"))
                            venta.nombre = Trim(reader("Nombre"))
                            venta.total = reader("Total")
                            ventas.Add(venta)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return ventas
    End Function

    Public Function ObtenerVentasArticulos() As List(Of ClsModeloFacturaArticulo)

        Dim ventas As New List(Of ClsModeloFacturaArticulo)()
        Dim query As String

        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                query = "select A.ID,A.Nombre,count(B.Cantidad) As Cantidad,sum(B.PrecioTotal) As PrecioTotal from  "
                query = query & "productos A inner join ventasitems B on A.ID=B.IDProducto group by  A.ID,A.Nombre"

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim venta As New ClsModeloFacturaArticulo()
                            venta.id = reader("ID")
                            venta.nombre = reader("Nombre")
                            venta.cantidad = Trim(reader("Cantidad"))
                            venta.preciototal = Trim(reader("PrecioTotal"))
                            ventas.Add(venta)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Sistemas")
        End Try

        Return ventas
    End Function

End Class
