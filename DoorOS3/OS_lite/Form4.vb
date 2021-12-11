Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer3.Enabled = True
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Timer1.Start()
        Label1.Text = "Defragment... Don't shutdown your computer!!"
        If ProgressBar1.Value = (100) Then
            Label1.Text = "Defragment complete!!"
            ProgressBar1.Value = (0)
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = (100) Then
            Label1.Text = "Defragment completed!"
            ProgressBar1.Value = (0)
            Timer1.Stop()
        End If
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Me.Hide()
        Form5.Show()
        Form5.Label6.Text = "Error code: 00" & vbNewLine & "Manual crash"
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        Dim closeMsg = MessageBox.Show("Which calculator do you want? Yes = Scientific; No = Standard; Cancel = Nothing", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If closeMsg = DialogResult.Yes Then
            Form7.Show()
        End If

        If closeMsg = DialogResult.No Then
            Form8.Show()
        End If

        If closeMsg = DialogResult.Cancel Then
            Form1.Hide()
        End If
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Form9.Show()
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Timer2.Start()
        Label1.Text = "Scaning... Don't shutdown your computer!!"
        If ProgressBar1.Value = (100) Then
            Label1.Text = "No viruses!"
            ProgressBar1.Value = (0)
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = (100) Then
            Label1.Text = "No viruses!"
            ProgressBar1.Value = (0)
            Timer2.Stop()
        End If
    End Sub

    Private Sub RadioButton12_Click(sender As Object, e As EventArgs) Handles RadioButton12.Click
        TextBox1.Text = "Enabled."
    End Sub

    Private Sub RadioButton18_Click(sender As Object, e As EventArgs) Handles RadioButton18.Click
        Label1.Text = "Progress"
        Me.BackColor = Color.FromArgb(0, 0, 192)

        Label5.Text = "Battery"
        TextBox2.Text = "%"
    End Sub

    Private Sub RadioButton10_Click(sender As Object, e As EventArgs) Handles RadioButton10.Click
        TextBox1.Text = My.Computer.Name
    End Sub

    Private Sub RadioButton15_Click(sender As Object, e As EventArgs) Handles RadioButton15.Click
        Label5.Text = "User name"
        TextBox1.Text = My.User.Name

        Label5.Text = "False user name"
        TextBox2.Text = My.User.Name

        If TextBox1.Text = "DESKTOP-K9KQ86E\Bartulin" Then
            TextBox1.Text = "DESKTOP-K9KQ86E\VanGutan"
        End If
    End Sub

    Private Sub RadioButton14_Click(sender As Object, e As EventArgs) Handles RadioButton14.Click
        Me.BackColor = Color.Gold
    End Sub

    Private Sub RadioButton13_Click(sender As Object, e As EventArgs) Handles RadioButton13.Click
        TextBox1.Text = My.Computer.Screen.DeviceName
    End Sub

    Private Sub RadioButton7_Click(sender As Object, e As EventArgs) Handles RadioButton7.Click
        Label2.Text = "OS"
        TextBox1.Text = My.Computer.Info.OSFullName()

        Label5.Text = "Battery"
        TextBox2.Text = "%"
    End Sub

    Private Sub RadioButton8_Click(sender As Object, e As EventArgs) Handles RadioButton8.Click
        TextBox1.Text = My.Computer.Info.OSVersion()
    End Sub

    Private Sub RadioButton9_Click(sender As Object, e As EventArgs) Handles RadioButton9.Click
        TextBox1.Text = My.Computer.Info.OSPlatform()
    End Sub

    Private Sub RadioButton16_Click(sender As Object, e As EventArgs)
        Label2.Text = "Total Virtual Memory (KB)"
        TextBox1.Text = My.Computer.Info.TotalVirtualMemory

        Label5.Text = "Avabible Virtual Memory (KB)"
        TextBox2.Text = My.Computer.Info.AvailableVirtualMemory
    End Sub

    Private Sub RadioButton17_Click(sender As Object, e As EventArgs) Handles RadioButton17.Click
        Label2.Text = "Total Physical Memory (bajt)"
        TextBox1.Text = My.Computer.Info.TotalPhysicalMemory

        Label5.Text = "Avabible Physical Memory (bajt)"
        TextBox2.Text = My.Computer.Info.AvailablePhysicalMemory
    End Sub

    Private Sub RadioButton19_Click(sender As Object, e As EventArgs) Handles RadioButton19.Click
        If My.Computer.FileSystem.DirectoryExists("C:\Door") Then
            Label1.Text = "Can't delete file... Delete from Windows interface."
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim psBattery As PowerStatus = SystemInformation.PowerStatus
        Dim perFull As Single = psBattery.BatteryLifePercent

        If perFull * 100 > 100 Then
            ProgressBar2.Value = 100
        ElseIf perFull * 100 < 100 Then
            ProgressBar2.Value = perFull * 100
        End If

        If psBattery.PowerLineStatus = PowerLineStatus.Online Then
            TextBox3.Text = "Battinfo - " & perFull * 100 & "%" & " charging!"
        ElseIf psBattery.PowerLineStatus = PowerLineStatus.Offline Then
            TextBox3.Text = "Battinfo - " & perFull * 100 & "%" & "don't charging!"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Form10.Show()
    End Sub

    Private Sub RadioButton20_Click(sender As Object, e As EventArgs) Handles RadioButton20.Click
        TextBox4.Visible = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "me.char" Then
            TextBox4.UseSystemPasswordChar = True
        End If

        If TextBox4.Text = "start-notepad" Then
            Form12.Show()
        End If
    End Sub
End Class