Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "ME.EXIT" Then
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub
End Class