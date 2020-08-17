Public Class BookSell
    Dim title As String
    Dim value As Decimal

    Public Sub New(ByVal t As String, ByVal v As Decimal)
        title = t
        value = v
    End Sub

    Public Function getTitle() As String
        Return title
    End Function

    Public Function getValue() As Decimal
        Return value
    End Function

End Class
