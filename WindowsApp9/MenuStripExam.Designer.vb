<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuStripExam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PASTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORMATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.FORMATToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NEWToolStripMenuItem.Text = "NEW"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OPENToolStripMenuItem.Text = "OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UNDOToolStripMenuItem, Me.REDOToolStripMenuItem, Me.CUTToolStripMenuItem, Me.COPYToolStripMenuItem, Me.PASTEToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EDITToolStripMenuItem.Text = "&EDIT"
        '
        'UNDOToolStripMenuItem
        '
        Me.UNDOToolStripMenuItem.Name = "UNDOToolStripMenuItem"
        Me.UNDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UNDOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UNDOToolStripMenuItem.Text = "UNDO"
        '
        'REDOToolStripMenuItem
        '
        Me.REDOToolStripMenuItem.Name = "REDOToolStripMenuItem"
        Me.REDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.REDOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.REDOToolStripMenuItem.Text = "REDO"
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CUTToolStripMenuItem.Text = "CUT"
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.COPYToolStripMenuItem.Text = "COPY"
        '
        'PASTEToolStripMenuItem
        '
        Me.PASTEToolStripMenuItem.Name = "PASTEToolStripMenuItem"
        Me.PASTEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PASTEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PASTEToolStripMenuItem.Text = "PASTE"
        '
        'FORMATToolStripMenuItem
        '
        Me.FORMATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FONTToolStripMenuItem, Me.COLORToolStripMenuItem})
        Me.FORMATToolStripMenuItem.Name = "FORMATToolStripMenuItem"
        Me.FORMATToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FORMATToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.FORMATToolStripMenuItem.Text = "FORMAT"
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FONTToolStripMenuItem.Text = "FONT"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.COLORToolStripMenuItem.Text = "COLOR"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1500, 1000)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'MenuStripExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 528)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuStripExam"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UNDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PASTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORMATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
