Public Class Audio
    Public Sub audio_Initialize()
        listPrint.Items.Clear()
        listPrint.Items.Add(A1.getTitle())
        listPrint.Items.Add(A2.getTitle())
        listPrint.Items.Add(A3.getTitle())
        listPrint.Items.Add(A4.getTitle())
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.listCart.Items.Add(listPrint.SelectedItem)
        CalcAll()
    End Sub
End Class