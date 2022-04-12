Public Class Form1
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Dim Spins As Short
        Dim Wins As Short
        Wins = Wins + 1
        lblWins.Text = "Wins: " & Wins
        PictureBox1.Visible = False 'hide picture
        Label1.Text = CStr(Int(Rnd() * 10)) 'pick number
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        Spins = Spins + 1
        ' if any number is 7 display picture and deep
        If (Label1.Text = "7") Or (Label2.Text = "7") _
            Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
        lblRate.Text = HitRate(Wins, Spins)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Function HitRate(ByVal Hits As Short, ByVal Tries As Short) As _
    String
        Dim Percent As Single
        Percent = Hits / Tries
        Return Format(Percent, "0.0%")
    End Function
End Class
