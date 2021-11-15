Imports System.IO
Public Class MenuStripExam
    Private FileName As String
    Dim sw As StreamWriter
    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub
    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub
    Private Sub REDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REDOToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub
    Private Sub CUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub
    Private Sub COPYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub
    Private Sub PASTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        With open
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Demo Open File Dialog"
        End With
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                allText = My.Computer.FileSystem.ReadAllText(open.FileName)
                RichTextBox1.Text = allText
            Catch f As Exception
                Throw f
            End Try
        End If
        open.Dispose()
        open = Nothing
    End Sub
    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Try
            With SaveFileDialog1
                .FileName = FileName
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sw = New StreamWriter(FileName)
                    sw.Write(RichTextBox1.Text)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If
        End Try
    End Sub
    Private Sub setFont()
        Try
            With FontDialog1
                RichTextBox1.Font = .Font

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        Try
            With FontDialog1
                .Font = RichTextBox1.Font

                If .ShowDialog = DialogResult.OK Then
                    setFont()
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        End Try
    End Sub

    Private Sub COLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLORToolStripMenuItem.Click
        Dim dlg As New ColorDialog
        dlg.ShowDialog()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim str As String
            str = dlg.Color.Name
            MsgBox(str)
            RichTextBox1.ForeColor = dlg.Color
        End If
    End Sub
End Class