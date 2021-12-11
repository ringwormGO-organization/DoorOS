Public Class Form7
    Dim results As Double = 0
    Dim operation As String = ""
    Dim enter_value As Boolean = False
    Dim iCelsius, iFahrenheit, iKevin As Single
    Dim iOperation As Char

    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim Opera As String

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Width = 326
        txtDisplay.Width = 286
        lblBroj.Visible = False
        GroupBox1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Width = 644
        txtDisplay.Width = 587
        lblBroj.Visible = True
        lblNula.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub MultiplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplyToolStripMenuItem.Click
        Me.Width = 1183
        GroupBox1.Visible = True
    End Sub

    Private Sub ColorChangebackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorChangebackgroundToolStripMenuItem.Click
        button40.Show()
    End Sub

    Private Sub button40_Click(sender As Object, e As EventArgs) Handles button40.Click
        colorDialog1.Color = Me.BackColor
        If colorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = colorDialog1.Color
        End If
    End Sub

    Private Sub button41_Click(sender As Object, e As EventArgs) Handles button41.Click
        colorDialog1.Color = lblBroj.BackColor
        If colorDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblBroj.BackColor = colorDialog2.Color
        End If

        colorDialog1.Color = lblNula.BackColor
        If colorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblNula.BackColor = colorDialog1.Color
        End If
    End Sub

    Private Sub HideColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideColorToolStripMenuItem.Click
        button40.Visible = False
        button41.Visible = False
    End Sub

    Private Sub CleanMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanMessageToolStripMenuItem.Click
        lblBroj.Visible = False
        lblNula.Visible = False
    End Sub

    Private Sub BackMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackMessageToolStripMenuItem.Click
        lblNula.Visible = True
        lblBroj.Visible = True
    End Sub

    Private Sub MojaRodicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MojaRodicaToolStripMenuItem.Click
        lblKamenje.Visible = True
        lblGit.Visible = True
    End Sub

    Private Sub radioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub radioButton4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub radioButton5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub button31_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub button22_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub button37_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button39_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Aritmethic_Click(sender As Object, e As EventArgs) Handles btn20.Click

    End Sub

    Private Sub button34_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn6.Click, btn11.Click, btn5.Click, btn17.Click, btn14.Click, btn15.Click, btn13.Click, btn10.Click, btn7.Click
        Dim b As Button = sender
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = b.Text
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button30_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button31_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button32_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "1" Then
            Label2.Text = "1×1=1"
            Label3.Text = "2×1=2"
            Label4.Text = "3×1=3"
            Label5.Text = "4×1=4"
            Label6.Text = "5×1=5"
            Label7.Text = "6×1=6"
            Label8.Text = "7×1=7"
            Label9.Text = "8×1=8"
            Label10.Text = "9×1=9"
            Label11.Text = "10×1=10"
            Label17.Text = "11×1=11"
            Label18.Text = "12×1=12"
        End If

        If TextBox1.Text = "2" Then
            Label2.Text = "2×1=2"
            Label3.Text = "2×2=4"
            Label4.Text = "2×3=6"
            Label5.Text = "2×4=8"
            Label6.Text = "2×5=10"
            Label7.Text = "2×6=12"
            Label8.Text = "2×7=14"
            Label9.Text = "2×8=16"
            Label10.Text = "2×9=18"
            Label11.Text = "2×10=20"
            Label17.Text = "2×11=22"
            Label18.Text = "2×12=24"
        End If

        If TextBox1.Text = "3" Then
            Label2.Text = "3×1=3"
            Label3.Text = "3×2=6"
            Label4.Text = "3×3=9"
            Label5.Text = "3×4=12"
            Label6.Text = "3×5=15"
            Label7.Text = "3×6=18"
            Label8.Text = "3×7=21"
            Label9.Text = "3×8=24"
            Label10.Text = "3×9=27"
            Label11.Text = "3×10=30"
            Label17.Text = "3×1=33"
            Label18.Text = "3×1=36"
        End If

        If TextBox1.Text = "4" Then
            Label2.Text = "4×1=4"
            Label3.Text = "4×2=8"
            Label4.Text = "4×3=12"
            Label5.Text = "4×4=16"
            Label6.Text = "4×5=20"
            Label7.Text = "4×6=24"
            Label8.Text = "4×7=28"
            Label9.Text = "4×8=32"
            Label10.Text = "4×9=36"
            Label11.Text = "4×10=40"
            Label17.Text = "4×11=44"
            Label18.Text = "4×12=48"
        End If

        If TextBox1.Text = "5" Then
            Label2.Text = "5×1=5"
            Label3.Text = "5×2=10"
            Label4.Text = "5×3=15"
            Label5.Text = "5×4=20"
            Label6.Text = "5×5=25"
            Label7.Text = "5×6=30"
            Label8.Text = "5×7=35"
            Label9.Text = "5×8=40"
            Label10.Text = "5×9=45"
            Label11.Text = "5×10=50"
            Label17.Text = "5×11=55"
            Label18.Text = "5×12=60"
        End If

        If TextBox1.Text = "6" Then
            Label2.Text = "6×1=6"
            Label3.Text = "6×2=12"
            Label4.Text = "6×3=18"
            Label5.Text = "6×4=24"
            Label6.Text = "6×5=30"
            Label7.Text = "6×6=36"
            Label8.Text = "6×7=42"
            Label9.Text = "6×8=48"
            Label10.Text = "6×9=54"
            Label11.Text = "6×10=60"
            Label17.Text = "6×11=66"
            Label18.Text = "6×12=72"
        End If

        If TextBox1.Text = "7" Then
            Label2.Text = "7×1=7"
            Label3.Text = "7×2=14"
            Label4.Text = "7×3=21"
            Label5.Text = "7×4=28"
            Label6.Text = "7×5=35"
            Label7.Text = "7×6=42"
            Label8.Text = "7×7=49"
            Label9.Text = "7×8=56"
            Label10.Text = "7×9=63"
            Label11.Text = "7×10=70"
            Label17.Text = "7×11=77"
            Label18.Text = "7×12=84"
        End If

        If TextBox1.Text = "8" Then
            Label2.Text = "8×1=5"
            Label3.Text = "8×2=10"
            Label4.Text = "8×3=15"
            Label5.Text = "8×4=20"
            Label6.Text = "8×5=25"
            Label7.Text = "8×6=30"
            Label8.Text = "8×7=35"
            Label9.Text = "8×8=40"
            Label10.Text = "8×9=45"
            Label11.Text = "8×10=50"
            Label17.Text = "8×11=55"
            Label18.Text = "8×12=60"
        End If

        If TextBox1.Text = "9" Then
            Label2.Text = "9×1=9"
            Label3.Text = "9×2=18"
            Label4.Text = "9×3=27"
            Label5.Text = "9×4=36"
            Label6.Text = "9×5=45"
            Label7.Text = "9×6=54"
            Label8.Text = "9×7=63"
            Label9.Text = "9×8=72"
            Label10.Text = "9×9=81"
            Label11.Text = "9×10=90"
            Label17.Text = "9×11=99"
            Label18.Text = "9×12=108"
        End If

        If TextBox1.Text = "10" Then
            Label2.Text = "10×1=10"
            Label3.Text = "10×2=20"
            Label4.Text = "10×3=30"
            Label5.Text = "10×4=40"
            Label6.Text = "10×5=50"
            Label7.Text = "10×6=60"
            Label8.Text = "10×7=70"
            Label9.Text = "10×8=80"
            Label10.Text = "10×9=90"
            Label11.Text = "10×10=100"
            Label17.Text = "10×11=110"
            Label18.Text = "10×12=120"
        End If

        If TextBox1.Text = "11" Then
            Label2.Text = "11×1=11"
            Label3.Text = "11×2=22"
            Label4.Text = "11×3=33"
            Label5.Text = "11×4=44"
            Label6.Text = "11×5=55"
            Label7.Text = "11×6=66"
            Label8.Text = "11×7=77"
            Label9.Text = "11×8=88"
            Label10.Text = "11×9=99"
            Label11.Text = "11×10=110"
            Label17.Text = "11×11=121"
            Label18.Text = "11×12=132"
        End If

        If TextBox1.Text = "12" Then
            Label2.Text = "12×1=12"
            Label3.Text = "12×2=24"
            Label4.Text = "12×3=36"
            Label5.Text = "12×4=48"
            Label6.Text = "12×5=60"
            Label7.Text = "12×6=72"
            Label8.Text = "12×7=84"
            Label9.Text = "12×8=96"
            Label10.Text = "12×9=108"
            Label11.Text = "12×10=120"
            Label17.Text = "12×11=132"
            Label18.Text = "12×12=144"
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 326
        txtDisplay.Width = 286
        lblBroj.Visible = False
        GroupBox1.Visible = False
    End Sub

    Private Sub Arithmetic_Operator(sender As Object, e As EventArgs) Handles btn8.Click, btn16.Click, btn12.Click, btn20.Click
        Dim ops As Button = sender
        firstnum = txtDisplay.Text
        lblHistory.Text = txtDisplay.Text
        txtDisplay.Text = ""
        Opera = ops.Text
        lblHistory.Text = lblHistory.Text + "" + Opera
    End Sub

    Private Sub Button31_Click_2(sender As Object, e As EventArgs) Handles btn19.Click
        secondnum = txtDisplay.Text
        If Opera = "+" Then
            answer = firstnum + secondnum
            txtDisplay.Text = answer
            lblHistory.Text = ""
        ElseIf Opera = "-" Then
            answer = firstnum - secondnum
            txtDisplay.Text = answer
            lblHistory.Text = ""
        ElseIf Opera = "×" Then
            answer = firstnum * secondnum
            txtDisplay.Text = answer
            lblHistory.Text = ""
        ElseIf Opera = "/" Then
            answer = firstnum / secondnum
            txtDisplay.Text = answer
            lblHistory.Text = ""
        ElseIf Opera = "Mod" Then
            answer = firstnum Mod secondnum
            txtDisplay.Text = answer
            lblHistory.Text = ""
        ElseIf Opera = "Exp" Then
            answer = firstnum ^ secondnum
            txtDisplay.Text = answer
            lblHistory.Text = ""
        End If
    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles btn1.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles btn18.Click
        If InStr(txtDisplay.Text, ",") = 0 Then
            txtDisplay.Text = txtDisplay.Text + ","
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = "0"
        lblHistory.Text = ""
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = "0"
        lblHistory.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (txtDisplay.Text.Contains("-")) Then

            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)

        Else

            txtDisplay.Text = "" + txtDisplay.Text

        End If
    End Sub

    Private Sub button32_Click_1(sender As Object, e As EventArgs) Handles button32.Click
        txtDisplay.Text = "3.141592653589976323"
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim ilog As Double

        ilog = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
        ilog = Math.Log10(ilog)
        txtDisplay.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub Sqrt_Click(sender As Object, e As EventArgs) Handles Sqrt.Click
        Dim iSqrt As Double

        iSqrt = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")")
        iSqrt = Math.Sqrt(iSqrt)
        txtDisplay.Text = System.Convert.ToString(iSqrt)
    End Sub

    Private Sub button26_Click_1(sender As Object, e As EventArgs) Handles button26.Click
        Dim iSinh As Double

        iSinh = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")")
        iSinh = Math.Sinh(iSinh)
        txtDisplay.Text = System.Convert.ToString(iSinh)
    End Sub

    Private Sub button25_Click_1(sender As Object, e As EventArgs) Handles button25.Click
        Dim iSin As Double

        iSin = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("Sin" + "(" + (txtDisplay.Text) + ")")
        iSin = Math.Sin(iSin)
        txtDisplay.Text = System.Convert.ToString(iSin)
    End Sub

    Private Sub button30_Click_1(sender As Object, e As EventArgs) Handles button30.Click
        Dim iCosh As Double

        iCosh = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("Cosh" + "(" + (txtDisplay.Text) + ")")
        iCosh = Math.Cosh(iCosh)
        txtDisplay.Text = System.Convert.ToString(iCosh)
    End Sub

    Private Sub button29_Click_1(sender As Object, e As EventArgs) Handles button29.Click
        Dim iCos As Double

        iCos = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")")
        iCos = Math.Cos(iCos)
        txtDisplay.Text = System.Convert.ToString(iCos)
    End Sub

    Private Sub button20_Click_1(sender As Object, e As EventArgs) Handles button20.Click
        Dim iTanh As Double

        iTanh = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")")
        iTanh = Math.Tanh(iTanh)
        txtDisplay.Text = System.Convert.ToString(iTanh)
    End Sub

    Private Sub button17_Click_1(sender As Object, e As EventArgs) Handles button17.Click
        Dim iTan As Double

        iTan = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")")
        iTan = Math.Tan(iTan)
        txtDisplay.Text = System.Convert.ToString(iTan)
    End Sub

    Private Sub button38_Click(sender As Object, e As EventArgs) Handles button38.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 8)
    End Sub

    Private Sub button18_Click_1(sender As Object, e As EventArgs) Handles button18.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 16)
    End Sub

    Private Sub button21_Click_1(sender As Object, e As EventArgs) Handles button21.Click
        Dim a As Double

        lblHistory.Text = System.Convert.ToString("X*X*X" + "(" + (txtDisplay.Text) + ")")
        a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub button23_Click_1(sender As Object, e As EventArgs) Handles button23.Click
        Dim a As Double

        lblHistory.Text = System.Convert.ToString("X*X*X" + "(" + (txtDisplay.Text) + ")")
        a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub button28_Click_1(sender As Object, e As EventArgs) Handles button28.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 2)
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button24_Click_1(sender As Object, e As EventArgs) Handles button24.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub button27_Click_1(sender As Object, e As EventArgs) Handles button27.Click
        Dim a As Double
        a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text))
        txtDisplay.Text = Convert.ToString(a)
    End Sub

    Private Sub button19_Click_1(sender As Object, e As EventArgs) Handles button19.Click
        Dim ilog As Double

        ilog = Double.Parse(txtDisplay.Text)
        lblHistory.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
        ilog = Math.Log(ilog)
        txtDisplay.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub button37_Click_1(sender As Object, e As EventArgs) Handles button37.Click
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub lblKamenje_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblKamenje.LinkClicked

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisplay.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class