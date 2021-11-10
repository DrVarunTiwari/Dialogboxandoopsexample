Public Class overriding
    Public Class abc
        Public p As Integer
        Public Overridable Sub display()
            MsgBox("hello how r u")
        End Sub
    End Class
    Class abcd
        Inherits abc
        Public q As Integer
        Public Shadows Sub display()
            p = 10
            q = p
            MsgBox(q)
        End Sub
        'Public Overrides Sub display()
        '    p = 10
        '    q = p
        '    MsgBox(q)
        'End Sub
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'use for shadows case
        ' Dim p1 As abc = New abcd
        ' p1.display()
        ' Dim p2 As New abcd
        ' p2.display()
        'use for overrides
        Dim p1 As New abcd
        p1.display()
    End Sub
End Class