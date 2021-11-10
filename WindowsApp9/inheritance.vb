Public Class inheritance
    Public Class abc
        Public p As Integer
        Public Sub display()
            MsgBox("hello how r u")
        End Sub
    End Class
    Class abcd
        Inherits abc
        Public q As Integer
        Public Sub display1()
            p = 10
            q = p
            MsgBox(q)
        End Sub
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p1 As New abcd
        p1.display()
        p1.display1()
    End Sub
End Class