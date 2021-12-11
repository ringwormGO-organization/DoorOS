Module Module1
    Sub EmptySpotChecker(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = "" Then
            Butt2.Text = Butt1.Text
            Butt1.Text = ""
        End If
    End Sub

    Sub SolutionChecker()
        If Form9.Button1.Text = "1" And Form9.Button2.Text = "2" And Form9.Button3.Text = "3" And
            Form9.Button4.Text = "4" And Form9.Button5.Text = "5" And Form9.Button6.Text = "6" And
            Form9.Button7.Text = "7" And Form9.Button8.Text = "8" And Form9.Button9.Text = "9" And
            Form9.Button10.Text = "10" And Form9.Button11.Text = "11" And Form9.Button12.Text = "12" And
            Form9.Button13.Text = "13" And Form9.Button14.Text = "14" And Form9.Button15.Text = "15" Then
            MessageBox.Show("Well done!! Your expert!", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Form9.Counter = Form9.Counter + 1
        Form9.TextBox1.Text = "Number of clicks: " & Form9.Counter
    End Sub

    Sub shuffle()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False

        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False

            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        Form9.Button1.Text = a(1)
        Form9.Button1.Text = a(2)
        Form9.Button1.Text = a(3)
        Form9.Button1.Text = a(4)
        Form9.Button1.Text = a(5)
        Form9.Button1.Text = a(6)
        Form9.Button1.Text = a(7)
        Form9.Button1.Text = a(8)
        Form9.Button1.Text = a(9)
        Form9.Button1.Text = a(10)
        Form9.Button1.Text = a(11)
        Form9.Button1.Text = a(12)
        Form9.Button1.Text = a(13)
        Form9.Button1.Text = a(14)
        Form9.Button1.Text = a(15)
        Form9.Button1.Text = ""

    End Sub
End Module

Module Module2
    Sub Test()
        Form1.Close()
    End Sub
End Module