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

        If Btn1.Text = Btn4.Text And Btn4.Text = Btn7.Text And Not Btn1.Enabled Then
            Winner = True

        ElseIf Btn2.Text = Btn5.Text And Btn5.Text = Btn8.Text And Not Btn2.Enabled Then
            Winner = True

        ElseIf Btn3.Text = Btn6.Text And Btn6.Text = Btn9.Text And Not Btn3.Enabled Then
            Winner = True

        ElseIf Btn1.Text = Btn5.Text And Btn5.Text = Btn9.Text And Not Btn1.Enabled Then
            Winner = True

        ElseIf Btn3.Text = Btn5.Text And Btn5.Text = Btn7.Text And Not Btn3.Enabled Then
            Winner = True

        ElseIf Btn1.Text = Btn2.Text And Btn2.Text = Btn3.Text And Not Btn1.Enabled Then
            Winner = True

        ElseIf Btn4.Text = Btn5.Text And Btn5.Text = Btn6.Text And Not Btn4.Enabled Then
            Winner = True

        ElseIf Btn7.Text = Btn8.Text And Btn7.Text = Btn9.Text And Not Btn7.Enabled Then
            Winner = True

        End If

        If Winner Then
            disBtn()
            Dim pwinner As String = ""

            If player Then
                pwinner = "Player 0"
            Else
                pwinner = "Player X"
            End If

            MessageBox.Show(pwinner + " Wins! ")
        Else
            If player_turn = 9 Then
                MessageBox.Show("Game is Draw!")
            End If

        End If

    End Sub

    Private Sub disBtn()
        Dim ctrl As Control
        Try
            For Each ctrl In Controls
                Dim x As Button = ctrl
                x.Enabled = False
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        Btn1.Text = ""
        Btn2.Text = ""
        Btn3.Text = ""
        Btn4.Text = ""
        Btn5.Text = ""
        Btn6.Text = ""
        Btn7.Text = ""
        Btn8.Text = ""
        Btn9.Text = ""

        player_turn = 0

        Btn1.Enabled = True
        Btn2.Enabled = True
        Btn3.Enabled = True
        Btn4.Enabled = True
        Btn5.Enabled = True
        Btn6.Enabled = True
        Btn7.Enabled = True
        Btn8.Enabled = True
        Btn9.Enabled = True

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.exit()
    End Sub
End Class
