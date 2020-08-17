Public Class AllRentals
    Private Sub AllRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet.KayakTypes)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dgvRentals_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentals.CellContentClick

    End Sub
End Class