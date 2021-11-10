Public Class constructor
    Public Class abcde
        Public p, q, r As Integer
        Public Sub New(ByVal a As Integer, ByVal b As Integer)
            p = a
            q = b
            r = p + q
            MsgBox(r)
        End Sub
        Public Sub New(ByVal a As Integer)
            p = a
            MsgBox(p)
        End Sub
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As New abcde(10)
        Dim o As New abcde(20, 30)
    End Sub
End Class