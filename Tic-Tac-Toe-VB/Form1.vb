Public Class TTTVB

    Dim player As Boolean = True
    Dim player_turn As Integer = 0

    Private Sub TTTVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClick(sender As Object, e As EventArgs) Handles Btn9.Click, Btn8.Click, Btn7.Click, Btn6.Click, Btn5.Click, Btn4.Click, Btn3.Click, Btn2.Click, Btn1.Click
        Dim BtnClick As Button = sender
        If player Then
            BtnClick.Text = "X"
        Else
            BtnClick.Text = "O"
        End If

        player = Not player
        BtnClick.Enabled = False
        player_turn += 1
        Checker()

    End Sub

    Private Sub Checker()
        Dim Winner As Boolean = False


    End Sub


End Class
