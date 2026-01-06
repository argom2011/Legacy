Public Class ClsControladorVenta
    Private registros As New List(Of String)()

    Public Sub AgregarCliente(ventas As ClsModeloVenta)
        registros.Add(ventas.ToString)
    End Sub

    Public Function ObtenerRegistros() As List(Of String)
        Return registros
    End Function
End Class
