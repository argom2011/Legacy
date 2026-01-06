Public Class FrmVentasArticulos
    Dim controlador As Controlador

    Public Sub New()

        InitializeComponent()
        controlador = New Controlador()
        CargarDatos()

    End Sub

    Private Sub CargarDatos()

        Dim contactos As List(Of ClsModeloFacturaArticulo) = controlador.ObtenerVentasArticulos()
        Grilla.DataSource = contactos

    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
        Dim Clase As New ClsImprimir(Grilla)
        Clase.Imprimir()
        Clase = Nothing
    End Sub


End Class