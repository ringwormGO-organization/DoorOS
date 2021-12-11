Public Class Form2
    Private Sub ENGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENGToolStripMenuItem.Click

    End Sub

    Private Sub HideFirstFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideFirstFormToolStripMenuItem.Click
        Form1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim closeMsg = MessageBox.Show("Do you really want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If closeMsg = DialogResult.Yes Then
            Form1.Close()
        End If

        If closeMsg = DialogResult.No Then
            Form1.Hide()
        End If
    End Sub

    Private Sub HRVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HRVToolStripMenuItem.Click
        InstallDirectoryToolStripMenuItem.Text = "Intaliraj direktorij"
        ContinueWithoutInstallToolStripMenuItem.Text = "Nastavi bez instalacije"
        HideFirstFormToolStripMenuItem.Text = "Sakrij prvi prozor"
    End Sub

    Private Sub InstallDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallDirectoryToolStripMenuItem.Click
        My.Computer.FileSystem.CreateDirectory("C:\Door")

        GroupBox1.Visible = True

        If My.Computer.FileSystem.FileExists("C:\Door") Then
            Form3.Show()
        End If
    End Sub

    Private Sub ContinueWithoutInstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContinueWithoutInstallToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Form3.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class