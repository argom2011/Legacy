Imports System.Drawing.Printing

Public Class ClsImprimir
    Private printDocument As New PrintDocument()
    Private dataPedidos As DataGridView

    Public Sub New(dataGridView As DataGridView)

        dataPedidos = dataGridView

        AddHandler printDocument.PrintPage, AddressOf printDocument_PrintPage
    End Sub

    ' Método para iniciar la impresión
    Public Sub Imprimir()

        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As PrintPageEventArgs)

        Dim printFont As System.Drawing.Font = New Font("Courier New", 12)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Integer = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim fmt As String = ""
        Dim linea As String = ""
        Dim encabezado As String = ""
        Dim xlen As Integer
        Dim i As Integer = 0
        Dim row As System.Windows.Forms.DataGridViewRow
        ' Calculamos el número de líneas que caben en cada página
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        ' Armamos el encabezado
        Dim header As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In dataPedidos.Columns
            header = column.HeaderCell
            If column.Index = 0 Then
                fmt = header.FormattedValue.ToString + Space(3)
            ElseIf column.Index = 1 Then
                fmt = header.FormattedValue.ToString + Space(7)
            ElseIf column.Index = 2 Then
                fmt = header.FormattedValue.ToString + Space(19)
            Else
                fmt = header.FormattedValue.ToString + Space(2)
            End If
            encabezado += fmt
        Next
        cabecera(yPos, topMargin, count, printFont, e, encabezado)
        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < dataPedidos.Rows.Count
            row = dataPedidos.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In
            row.Cells
                'Comprobamos que la celda tenga algún valor.
                If celda.Value IsNot Nothing Then
                    If celda.ColumnIndex = 0 Then
                        xlen = 3 - Len(celda.Value.ToString())
                        fmt = Space(xlen) + celda.Value.ToString() + Space(2)
                    ElseIf celda.ColumnIndex = 1 Then
                        fmt = celda.Value.ToString() + Space(5)
                    ElseIf celda.ColumnIndex = 2 Then
                        xlen = 25 - Len(celda.Value.ToString())
                        fmt = celda.Value.ToString() + Space(xlen)
                    Else
                        xlen = 25 - Len(celda.Value.ToString())
                        fmt = celda.Value.ToString() + Space(xlen)
                    End If
                    texto += fmt
                End If
            Next
            ' Calculamos la posición en la que se escribe la línea
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
            ' Escribimos la línea con el objeto Graphics
            e.Graphics.DrawString(texto, printFont,
            System.Drawing.Brushes.Black, 10, yPos)
            ' Incrementamos los contadores
            count += 1
            i += 1
        End While
        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(linea, printFont,
        System.Drawing.Brushes.Black, 10, yPos)
        If i < dataPedidos.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            i = 0
        End If

    End Sub

    Private Sub cabecera(yPos As Double, topMargin As Double, ByRef count As Integer, printFont As System.Drawing.Font, e As PrintPageEventArgs, encabezado As String)

        Dim linea As String = ""
        linea = StrDup(60, "-")
        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(linea, printFont,
        System.Drawing.Brushes.Black, 10, yPos)
        count += 1
        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(encabezado, printFont,
        System.Drawing.Brushes.Black, 10, yPos)
        count += 1
        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(linea, printFont,
        System.Drawing.Brushes.Black, 10, yPos)
        count += 1

    End Sub
End Class
