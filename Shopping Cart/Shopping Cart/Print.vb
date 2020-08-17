Public Class Print
    Public Sub print_Initialize()
        listPrint.Items.Clear()
        listPrint.Items.Add(P1.getTitle())
        listPrint.Items.Add(P2.getTitle())
        listPrint.Items.Add(P3.getTitle())
        listPrint.Items.Add(P4.getTitle())
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.listCart.Items.Add(listPrint.SelectedItem)
        CalcAll()
    End Sub
End Class