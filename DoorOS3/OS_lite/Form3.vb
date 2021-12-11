
Public Class Form3
    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Form1.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click

    End Sub

    Private Sub RestartInVBIOSModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartInVBIOSModeToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub NormalRestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalRestartToolStripMenuItem.Click
        Me.Close()
        Form2.Close()
        Form1.Show()
    End Sub

    Private Sub HideAnotherBackgroundWinodwsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideAnotherBackgroundWinodwsToolStripMenuItem.Click
        Form1.Hide()
        Form2.Hide()
    End Sub

    Private Sub CrashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrashToolStripMenuItem.Click
        Form5.Show()
        Form5.Label6.Text = "Error code: 00" & vbNewLine & "Manual crash from GUI"
    End Sub

    Private Sub CommandPromptToolStripMenuItem_Click(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CommandPromptToolStripMenuItem.Click

    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub CursorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursorToolStripMenuItem.Click
        Dim closeMsg = MessageBox.Show("Do you really want to hide mouse?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If closeMsg = DialogResult.Yes Then
            Cursor.Hide()
        End If

        If closeMsg = DialogResult.No Then
            Form1.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub PuzzleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuzzleToolStripMenuItem.Click
        Form9.Show()

        If Form9.WindowState = FormWindowState.Minimized Then
            Form9.Visible = True
        End If
    End Sub

    Private Sub WindowsStateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowsStateToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Form2.WindowState = FormWindowState.Normal
    End Sub

    Private Sub InternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click
        Form12.Show()
    End Sub

    Private Sub MOREToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MOREStripMenuItem2.Click
        Dim closeMsg = MessageBox.Show("What's you want to open?" & vbNewLine & "Yes = Python runner; No = Ping window; Cancel = App information", "Message App manager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If closeMsg = DialogResult.Yes Then
            Form5.Show()

            Form5.Label6.Text = "Error code: 02" & vbNewLine & "App not found"
        End If

        If closeMsg = DialogResult.No Then
            Form13.Show()
        End If

        If closeMsg = DialogResult.Cancel Then
            MessageBox.Show("If you want to play WaterBox game or drawing, visit our GitHub and downlod WaterBox VB game.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Shell("notepad")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Shell("cmd")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Shell("mspaint")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerToolStripMenuItem.Click

    End Sub

    Private Sub MENUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem.Click

    End Sub

    Private Sub CMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMDToolStripMenuItem.Click
        Shell("cmd")
    End Sub
End Class