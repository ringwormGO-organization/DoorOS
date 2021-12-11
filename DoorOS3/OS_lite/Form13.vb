Imports System.Net.NetworkInformation

Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim host As String = "93.141.227.194"

        Dim ping As New Ping
        Dim reply As PingReply = ping.Send(TextBox2.Text)
        MessageBox.Show(reply.Status.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim host2 As String = "google.com"

        Dim ping As New Ping
        Dim reply As PingReply = ping.Send(host2)
        MessageBox.Show(reply.Status.ToString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim host3 As String = "bing.com"

        Dim ping As New Ping
        Dim reply As PingReply = ping.Send(host3)
        MessageBox.Show(reply.Status.ToString)
    End Sub
End Class