Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intSpeed, intTime, intDistance As Integer
        intDistance = 0
        intSpeed = CInt(InputBox("Input the speed"))
        intTime = CInt(InputBox("Input the hours traveled"))

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Vehicle Speed: " + intSpeed.ToString)
        lstDisplay.Items.Add("Time Traveled : " + intTime.ToString)
        lstDisplay.Items.Add("Hours" + vbTab + "Distance Traveled")
        lstDisplay.Items.Add("-------------------------------------")
        For intCount = 1 To intTime
            intDistance = intCount * intSpeed
            lstDisplay.Items.Add(intCount.ToString + vbTab + intDistance.ToString)
        Next
        lstDisplay.Items.Add("Total Distance: " + intDistance.ToString)
    End Sub
End Class
