Public Class Form5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = (100) Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Timer1.Start()
        If ProgressBar1.Value = (100) Then
            Timer2.Start()
        End If
    End Sub
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Timer2.Start()
        If ProgressBar2.Value = (100) Then
            Me.Close()
            Cursor.Show()
            Form3.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = (100) Then
            Me.Close()
            Cursor.Show()
            Form3.Show()
        End If
    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Timer1.Enabled = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class