Module Pricing
    'Global Constants'
    Public Const g_tax As Decimal = 0.06D
    Public g_ship As Decimal = 2D

    Public P1 As New BookSell("I did It Your Way (Print)", 11.95D)
    Public P2 As New BookSell("The History of Scotland (Print)", 14.5D)
    Public P3 As New BookSell("Learn Calculus in One Day (Print)", 29.95D)
    Public P4 As New BookSell("Feel the Stress (Print)", 18.5D)
    Public A1 As New BookSell("Learn Calculus in One Day (Audio)", 29.95D)
    Public A2 As New BookSell("The History of Scotland (Audio)", 14.5D)
    Public A3 As New BookSell("The Science of Body Language (Audio)", 12.95D)
    Public A4 As New BookSell("Relaxation Techniques (Audio)", 11.5D)

    Sub CalcAll()
        Dim stotal As Decimal = calcSubtotal()
        Dim tax As Decimal = CalcTax(stotal)
        Dim ship As Decimal = CalcShip()
        Dim total As Decimal = stotal + tax + ship
        Form1.lblSub.Text = stotal.ToString
        Form1.lblTax.Text = tax.ToString
        Form1.lblShip.Text = ship.ToString
        Form1.lblTotal.Text = total.ToString
    End Sub

    Public Function calcSubtotal() As Decimal
        Dim array() As BookSell = {P1, P2, P3, P4, A1, A2, A3, A4}
        Dim total As Decimal = 0.0D
        For i = 0 To Form1.listCart.Items.Count - 1
            For j = 0 To array.Count - 1
                If Form1.listCart.Items(i).ToString = array(j).getTitle Then
                    total += array(j).getValue
                End If
            Next
        Next
        Return total
    End Function

    Public Function CalcTax(ByVal s As Decimal) As Decimal
        Return s * g_tax
    End Function

    Public Function CalcShip() As Decimal
        Return Form1.listCart.Items.Count * g_ship
    End Function

End Module
