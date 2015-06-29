Public Class GameForm

    Dim ButtonImages(2, 2) As Image
    Dim CurPlayer As Player
    Dim GameBoard(2, 2) As Char
    Dim Moves As Integer = 0
    Private Stalemates As Integer = 0
    Private GamesThisSession As Integer = 0
    Friend Players(1) As Player

    Private Sub GameForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Initialize_Game()
        Players(PLAYER_ONE).Wins = 0
        Players(PLAYER_TWO).Wins = 0

        With Players(PLAYER_ONE)
            PlayerOneNameLabel.Text = .Name
            PlayerOneSymbolLabel.Text = .Symbol
        End With

        With Players(PLAYER_TWO)
            PlayerTwoNameLabel.Text = .Name
            PlayerTwoSymbolLabel.Text = .Symbol
        End With

        RefreshStats()
    End Sub

    Private Sub Initialize_Game()
        Dim DefaultBG As Image = My.Resources.defaultbg
        Moves = 0

        Button00.Enabled = True
        Button00.BackgroundImage = DefaultBG
        Button01.Enabled = True
        Button01.BackgroundImage = DefaultBG
        Button02.Enabled = True
        Button02.BackgroundImage = DefaultBG
        Button10.Enabled = True
        Button10.BackgroundImage = DefaultBG
        Button11.Enabled = True
        Button11.BackgroundImage = DefaultBG
        Button12.Enabled = True
        Button12.BackgroundImage = DefaultBG
        Button20.Enabled = True
        Button20.BackgroundImage = DefaultBG
        Button21.Enabled = True
        Button21.BackgroundImage = DefaultBG
        Button22.Enabled = True
        Button22.BackgroundImage = DefaultBG

        If Players(PLAYER_ONE).Symbol = PLAYER_X Then
            CurPlayer = Players(PLAYER_ONE)
        Else
            CurPlayer = Players(PLAYER_TWO)
        End If

        For row As Integer = 0 To 2
            For column As Integer = 0 To 2
                ButtonImages(row, column) = DefaultBG
            Next column
        Next row

        For row As Integer = 0 To 2
            For column As Integer = 0 To 2
                GameBoard(row, column) = "N"
            Next column
        Next row

        CurPlayerLabel.Text = CurPlayer.Name
        CurPlayerPictureBox.Image = CurPlayer.Picture

        If AI And Players(PLAYER_TWO).Symbol = PLAYER_X Then
            AIMove()
        End If
    End Sub

    Private Sub RefreshStats()
        'PlayerOne Stats
        With Players(PLAYER_ONE)
            PlayerOneWinsLabel.Text = .Wins
            PlayerOneLossesLabel.Text = .Losses
            If GamesThisSession <> 0 Then
                Players(PLAYER_ONE).WinPercent = (.Wins / GamesThisSession)
                PlayerOneWinPercentLabel.Text = Players(PLAYER_ONE).WinPercent.ToString("P")
            Else
                PlayerOneWinPercentLabel.Text = GamesThisSession.ToString("P")
            End If
        End With
        'PlayerTwo Stats
        With Players(PLAYER_TWO)
            PlayerTwoWinsLabel.Text = .Wins
            PlayerTwoLossesLabel.Text = .Losses
            If GamesThisSession <> 0 Then
                Players(PLAYER_TWO).WinPercent = (.Wins / GamesThisSession)
                PlayerTwoWinPercentLabel.Text = Players(PLAYER_TWO).WinPercent.ToString("P")
            Else
                PlayerTwoWinPercentLabel.Text = GamesThisSession.ToString("P")
            End If
        End With
        'Game Stats
        GamesPlayedLabel.Text = GamesThisSession
        StalematesLabel.Text = Stalemates
        If GamesThisSession <> 0 Then
            StalematePercentLabel.Text = (Stalemates / GamesThisSession).ToString("P")
        Else
            StalematePercentLabel.Text = GamesThisSession.ToString("P")
        End If
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As System.EventArgs) Handles Button00.MouseHover, Button01.MouseHover, _
        Button02.MouseHover, Button10.MouseHover, Button11.MouseHover, Button12.MouseHover, Button20.MouseHover, _
        Button21.MouseHover, Button22.MouseHover

        Dim btn As Button = sender
        Dim btnName As String = btn.Name
        Dim btnRow As Integer = Integer.Parse(btnName.Substring(6, 1))
        Dim btnCol As Integer = Integer.Parse(btnName.Substring(7, 1))

        Select Case btnRow
            Case 0
                Select Case btnCol
                    Case 0
                        Button00.BackgroundImage = CurPlayer.Picture
                    Case 1
                        Button01.BackgroundImage = CurPlayer.Picture
                    Case 2
                        Button02.BackgroundImage = CurPlayer.Picture
                End Select
            Case 1
                Select Case btnCol
                    Case 0
                        Button10.BackgroundImage = CurPlayer.Picture
                    Case 1
                        Button11.BackgroundImage = CurPlayer.Picture
                    Case 2
                        Button12.BackgroundImage = CurPlayer.Picture
                End Select
            Case 2
                Select Case btnCol
                    Case 0
                        Button20.BackgroundImage = CurPlayer.Picture
                    Case 1
                        Button21.BackgroundImage = CurPlayer.Picture
                    Case 2
                        Button22.BackgroundImage = CurPlayer.Picture
                End Select
        End Select
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As System.EventArgs) Handles Button00.MouseLeave, Button01.MouseLeave, _
        Button02.MouseLeave, Button10.MouseLeave, Button11.MouseLeave, Button12.MouseLeave, Button20.MouseLeave, _
        Button21.MouseLeave, Button22.MouseLeave

        Dim btn As Button = sender
        Dim btnName As String = btn.Name
        Dim btnRow As Integer = Integer.Parse(btnName.Substring(6, 1))
        Dim btnCol As Integer = Integer.Parse(btnName.Substring(7, 1))

        Select Case btnRow
            Case 0
                Select Case btnCol
                    Case 0
                        Button00.BackgroundImage = ButtonImages(btnRow, btnCol)
                    Case 1
                        Button01.BackgroundImage = ButtonImages(btnRow, btnCol)
                    Case 2
                        Button02.BackgroundImage = ButtonImages(btnRow, btnCol)
                End Select
            Case 1
                Select Case btnCol
                    Case 0
                        Button10.BackgroundImage = ButtonImages(btnRow, btnCol)
                    Case 1
                        Button11.BackgroundImage = ButtonImages(btnRow, btnCol)
                    Case 2
                        Button12.BackgroundImage = ButtonImages(btnRow, btnCol)
                End Select
            Case 2
                Select Case btnCol
                    Case 0
                        Button20.BackgroundImage = ButtonImages(btnRow, btnCol)
                    Case 1
                        Button21.BackgroundImage = ButtonImages(btnRow, btnCol)
                    Case 2
                        Button22.BackgroundImage = ButtonImages(btnRow, btnCol)
                End Select
        End Select
    End Sub

    Private Sub Button_Click(sender As Object, e As System.EventArgs) Handles Button00.Click, Button01.Click, _
        Button02.Click, Button10.Click, Button11.Click, Button12.Click, Button20.Click, _
        Button21.Click, Button22.Click

        Dim btn As Button = sender
        Dim btnName As String = btn.Name
        Dim btnRow As Integer = Integer.Parse(btnName.Substring(6, 1))
        Dim btnCol As Integer = Integer.Parse(btnName.Substring(7, 1))

        Select Case btnRow
            Case 0
                Select Case btnCol
                    Case 0
                        Button00.BackgroundImage = CurPlayer.Picture
                        Button00.Enabled = False
                    Case 1
                        Button01.BackgroundImage = CurPlayer.Picture
                        Button01.Enabled = False
                    Case 2
                        Button02.BackgroundImage = CurPlayer.Picture
                        Button02.Enabled = False
                End Select
            Case 1
                Select Case btnCol
                    Case 0
                        Button10.BackgroundImage = CurPlayer.Picture
                        Button10.Enabled = False
                    Case 1
                        Button11.BackgroundImage = CurPlayer.Picture
                        Button11.Enabled = False
                    Case 2
                        Button12.BackgroundImage = CurPlayer.Picture
                        Button12.Enabled = False
                End Select
            Case 2
                Select Case btnCol
                    Case 0
                        Button20.BackgroundImage = CurPlayer.Picture
                        Button20.Enabled = False
                    Case 1
                        Button21.BackgroundImage = CurPlayer.Picture
                        Button21.Enabled = False
                    Case 2
                        Button22.BackgroundImage = CurPlayer.Picture
                        Button22.Enabled = False
                End Select
        End Select

        ButtonImages(btnRow, btnCol) = CurPlayer.Picture
        GameBoard(btnRow, btnCol) = CurPlayer.Symbol
        Moves += 1

        If CheckForWinner() Then
            GamesThisSession += 1
            ProcessWin()
            RefreshStats()
        ElseIf Moves >= 9 Then
            MessageBox.Show("Sorry, your game was a stalemate. Resetting the board.", "Stalemate!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Stalemates += 1
            GamesThisSession += 1
            Initialize_Game()
            RefreshStats()
        Else
            SwapPlayer()
        End If

    End Sub

    Private Sub SwapPlayer()
        If CurPlayer.Symbol = Players(PLAYER_ONE).Symbol Then
            CurPlayer = Players(PLAYER_TWO)
        Else
            CurPlayer = Players(PLAYER_ONE)
        End If

        CurPlayerLabel.Text = CurPlayer.Name
        CurPlayerPictureBox.Image = CurPlayer.Picture

        If AI And CurPlayer.Symbol = Players(PLAYER_TWO).Symbol Then
            AIMove()
        End If
    End Sub

    Private Function CheckForWinner() As Boolean
        Dim Winner As Boolean = False

        'check by row
        For Row As Integer = 0 To 2
            If GameBoard(Row, 0) = CurPlayer.Symbol And
                GameBoard(Row, 1) = CurPlayer.Symbol And
                GameBoard(Row, 2) = CurPlayer.Symbol Then

                Winner = True
            End If
        Next Row

        'check by column
        For Column As Integer = 0 To 2
            If GameBoard(0, Column) = CurPlayer.Symbol And
                GameBoard(1, Column) = CurPlayer.Symbol And
                GameBoard(2, Column) = CurPlayer.Symbol Then

                Winner = True
            End If
        Next Column

        'Check First Diagonal
        If GameBoard(0, 0) = CurPlayer.Symbol And
            GameBoard(1, 1) = CurPlayer.Symbol And
            GameBoard(2, 2) = CurPlayer.Symbol Then

            Winner = True
        End If

        'Check Second Diagonal
        If GameBoard(0, 2) = CurPlayer.Symbol And
            GameBoard(1, 1) = CurPlayer.Symbol And
            GameBoard(2, 0) = CurPlayer.Symbol Then

            Winner = True
        End If

        Return Winner
    End Function

    Private Sub ProcessWin()
        Dim Winner As Player
        Dim Loser As Player

        If CurPlayer.Symbol = Players(PLAYER_ONE).Symbol Then
            Players(PLAYER_ONE).Wins += 1
            Players(PLAYER_TWO).Losses += 1
            Winner = Players(PLAYER_ONE)
            Loser = Players(PLAYER_TWO)
        Else
            Players(PLAYER_TWO).Wins += 1
            Players(PLAYER_ONE).Losses += 1
            Winner = Players(PLAYER_TWO)
            Loser = Players(PLAYER_ONE)
        End If

        MessageBox.Show("Congratulations, " & Winner.Name & ", you won the game!" & Environment.NewLine &
                        "The game board will now reset.", "Game Winner!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Initialize_Game()
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 12, FontStyle.Regular)
        Dim HeaderFont As New Font("Arial", 16, FontStyle.Bold)
        Dim LineHeight As Single = PrintFont.GetHeight + 2
        Dim HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        'Print Header
        PrintLineString = "Match Statistics"
        e.Graphics.DrawString(PrintLineString, HeaderFont, Brushes.Black,
                              HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeight * 3
        'Print Statistics
        For i As Integer = 0 To Players.Length - 1
            PrintLineString = "Name: " & vbTab & Players(i).Name & Environment.NewLine &
                "Symbol: " & Players(i).Symbol & Environment.NewLine &
                "Wins: " & vbTab & Players(i).Wins & Environment.NewLine &
                "Losses: " & vbTab & Players(i).Losses & Environment.NewLine &
                "Win %: " & vbTab & Players(i).WinPercent.ToString("P") & Environment.NewLine
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                                  HorizontalLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeight * 6
        Next
        'Print Totals at bottom
        VerticalPrintLocationSingle += LineHeight 'For Double Spacing
        PrintLineString = "Totals"
        e.Graphics.DrawString(PrintLineString, HeaderFont, Brushes.Black,
                              HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeight * 2

        PrintLineString = "Total Games: " & vbTab & GamesThisSession & Environment.NewLine &
            "Stalemates: " & vbTab & Stalemates & Environment.NewLine &
            "Stalemate %: " & vbTab & StalematePercentLabel.Text & Environment.NewLine
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                              HorizontalLocationSingle, VerticalPrintLocationSingle)
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        Dim Message As String = "Connect three of the same symbol in a line to win." & Environment.NewLine &
            "What, haven't you played this before?"
        MessageBox.Show(Message, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub AIMove()
        Dim Row As Integer
        Dim Column As Integer
        Dim Valid As Boolean = False

        Do While Not Valid
            Row = Math.Floor(3 * Rnd())
            Column = Math.Floor(3 * Rnd())

            If GameBoard(Row, Column) = "N" Then
                Valid = True
            End If
        Loop

        Select Case Row
            Case 0
                Select Case Column
                    Case 0
                        Button00.PerformClick()
                    Case 1
                        Button01.PerformClick()
                    Case 2
                        Button02.PerformClick()
                End Select
            Case 1
                Select Case Column
                    Case 0
                        Button10.PerformClick()
                    Case 1
                        Button11.PerformClick()
                    Case 2
                        Button12.PerformClick()
                End Select
            Case 2
                Select Case Column
                    Case 0
                        Button20.PerformClick()
                    Case 1
                        Button21.PerformClick()
                    Case 2
                        Button22.PerformClick()
                End Select
        End Select
    End Sub

End Class