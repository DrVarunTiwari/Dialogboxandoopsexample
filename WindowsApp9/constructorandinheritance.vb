Public Class constructorandinheritance

    Public Class Printer
        Public a, b As Integer

        Public Function add() As Integer
            Return a + b
        End Function
    End Class
    Public Class Printer2
        Inherits Printer
        Public Function sus() As Integer
            Return a - b
        End Function
        Public Sub New(i As Integer, j As Integer)
            a = i
            b = j
        End Sub
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim q, l As Integer
        Dim x As Integer
        Dim y As Integer
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        Dim p1 As New Printer2(x, y)
        q = p1.add()
        l = p1.sus()
        MsgBox(q)
        MsgBox(l)
    End Sub
End Class