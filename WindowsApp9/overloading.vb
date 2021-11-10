Public Class overloading
    Public Class addition
        Public Function Sum(ByVal a As Integer, ByVal b As Integer) As Integer
            Dim result = a + b
            Return result
        End Function
        Public Function Sum(ByVal a As Long, ByVal b As Long) As Long
            Dim result = a + b
            Return result
        End Function
        Public Function Sum(ByVal a As Double, ByVal b As Double) As Double
            Dim result = a + b
            Return result
        End Function
    End Class


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As addition = New addition()
        Dim t = obj.Sum(10, 10)
        MessageBox.Show(t.ToString())
        Dim D = obj.Sum(10.2, 10.2)
        MessageBox.Show(D.ToString())
    End Sub
End Class