Public Class classandobject
    Class abcd
        Public p As Integer
        Public q As Integer
        Public k As Integer
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l As New abcd
        l.p = 10
        l.q = 21
        l.k = l.p + l.q
        MsgBox(l.k)

    End Sub
End Class