Public Class XOSelectionForm
    'Use RNG on this form so that a random player will get to choose his symbol
    'Remember to change the top label in order to reflect who is choosing
    'Use HTML or something to format the label to bold who is selecting
    'Potentially use another way to emphasize the selector as well

    Private Random As Integer

    Private Sub XOSelectionForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim MessageString As String = ", " & "please select which symbol you want. " & _
            "Remember, X always goes first."
        Dim PlayerName As String
        If AI Then
            PlayerName = GameForm.Players(PLAYER_ONE).Name
            Random = 1
        Else
            Random = Math.Floor((2 - 1 + 1) * Rnd() + 1)

            If Random = 1 Then
                PlayerName = GameForm.Players(PLAYER_ONE).Name
            Else
                PlayerName = GameForm.Players(PLAYER_TWO).Name
            End If
        End If

        MessageLabel.Text = PlayerName & MessageString
    End Sub

    Private Sub XButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XButton.Click
        If Random = 1 Then
            GameForm.Players(PLAYER_ONE).Symbol = PLAYER_X
            GameForm.Players(PLAYER_ONE).Picture = My.Resources.X
            GameForm.Players(PLAYER_TWO).Symbol = PLAYER_O
            GameForm.Players(PLAYER_TWO).Picture = My.Resources.Circle
        Else
            GameForm.Players(PLAYER_TWO).Symbol = PLAYER_X
            GameForm.Players(PLAYER_TWO).Picture = My.Resources.X
            GameForm.Players(PLAYER_ONE).Symbol = PLAYER_O
            GameForm.Players(PLAYER_ONE).Picture = My.Resources.Circle
        End If

        GameForm.Show()
        Me.Close()
    End Sub

    Private Sub OButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OButton.Click
        If Random = 1 Then
            GameForm.Players(PLAYER_ONE).Symbol = PLAYER_O
            GameForm.Players(PLAYER_ONE).Picture = My.Resources.Circle
            Gameform.Players(PLAYER_TWO).Symbol = PLAYER_X
            Gameform.Players(PLAYER_TWO).Picture = My.Resources.X
        Else
            Gameform.Players(PLAYER_TWO).Symbol = PLAYER_O
            Gameform.Players(PLAYER_TWO).Picture = My.Resources.Circle
            GameForm.Players(PLAYER_ONE).Symbol = PLAYER_X
            GameForm.Players(PLAYER_ONE).Picture = My.Resources.X
        End If

        GameForm.Show()
        Me.Close()
    End Sub

End Class