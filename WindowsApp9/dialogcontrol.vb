Imports System.IO
Public Class dialogcontrol
    Private FileName As String
    Dim sw As StreamWriter
    Private Sub setFont()
        Try
            With FontDialog1
                RichTextBox1.Font = .Font

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
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

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
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

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
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
