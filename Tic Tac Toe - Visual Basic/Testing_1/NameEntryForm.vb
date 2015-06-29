Imports System.IO
Public Class NameEntryForm

    Dim Prefixes As New ArrayList()
    Dim Suffixes As New ArrayList()

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click

        If PlayerOneNameTextBox.Text = String.Empty Or PlayerOneNameTextBox.Text = String.Empty Then
            MessageBox.Show("Neither player name can be empty!", "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GameForm.Players(PLAYER_ONE).Name = BuildName(Prefixes(PlayerOnePrefixComboBox.SelectedIndex),
                                       PlayerOneNameTextBox.Text, Suffixes(PlayerOneSuffixComboBox.SelectedIndex))
            GameForm.Players(PLAYER_TWO).Name = BuildName(Prefixes(PlayerTwoPrefixComboBox.SelectedIndex),
                                       PlayerTwoNameTextBox.Text, Suffixes(PlayerTwoSuffixComboBox.SelectedIndex))

            XOSelectionForm.Show()
            Me.Close()
        End If
    End Sub

    Private Function BuildName(ByVal Prefix As String, ByVal Name As String, ByVal Suffix As String) As String

        Dim FinalName As String = ""

        If Prefix <> String.Empty Then
            FinalName += Prefix & " "
        End If

        FinalName += Name

        If Suffix <> String.Empty Then
            FinalName += " " & Suffix
        End If

        Return FinalName
    End Function

    Private Sub PlayerOneNameTextBox_Click(sender As Object, e As System.EventArgs) Handles PlayerOneNameTextBox.Click, PlayerOneNameTextBox.Enter
        PlayerOneNameTextBox.SelectAll()
    End Sub

    Private Sub PlayerTwoNameTextBox_Click(sender As Object, e As System.EventArgs) Handles PlayerTwoNameTextBox.Click, PlayerTwoNameTextBox.Enter
        PlayerTwoNameTextBox.SelectAll()
    End Sub

    Private Sub NameEntryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetPrefixes()
        GetSuffixes()
        Randomize()
        PlayerOnePrefixComboBox.SelectedIndex = 0
        PlayerOneSuffixComboBox.SelectedIndex = 0
        PlayerTwoPrefixComboBox.SelectedIndex = 0
        PlayerTwoSuffixComboBox.SelectedIndex = 0
    End Sub

    Private Sub GetPrefixes()
        Dim InLine As String = ""
        Dim counter As Long = 0
        Try
            Using Reader As StreamReader = New StreamReader(
                    My.Application.Info.DirectoryPath & "\Prefixes.txt")
                Do While Reader.Peek() <> -1
                    Prefixes.Add(Reader.ReadLine())
                Loop
            End Using
        Catch Fnf As FileNotFoundException
            MessageBox.Show("File Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For i As Integer = 0 To Prefixes.Count - 1
            PlayerOnePrefixComboBox.Items.Add(Prefixes(i))
            PlayerTwoPrefixComboBox.Items.Add(Prefixes(i))
        Next

    End Sub

    Private Sub GetSuffixes()
        Dim InLine As String = ""
        'get list of suffixes"
        Using Reader As StreamReader = New StreamReader(
                    My.Application.Info.DirectoryPath & "\Suffixes.txt")
            Do While Reader.Peek() <> -1
                Suffixes.Add(Reader.ReadLine())
            Loop
        End Using

        For i As Integer = 0 To Suffixes.Count - 1
            PlayerOneSuffixComboBox.Items.Add(Suffixes(i))
            PlayerTwoSuffixComboBox.Items.Add(Suffixes(i))
        Next
    End Sub

    Private Sub AICheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AICheckBox.CheckedChanged
        AI = AICheckBox.Checked

        If AI Then
            PlayerTwoPrefixComboBox.Enabled = False
            PlayerTwoNameTextBox.Enabled = False
            PlayerTwoSuffixComboBox.Enabled = False

            PlayerTwoPrefixComboBox.SelectedIndex = Math.Floor(((PlayerTwoPrefixComboBox.Items.Count - 1) - 1 + 1) * Rnd() + 1)
            PlayerTwoSuffixComboBox.SelectedIndex = Math.Floor(((PlayerTwoSuffixComboBox.Items.Count - 1) - 1 + 1) * Rnd() + 1)
            PlayerTwoNameTextBox.Text = "Wiggles"
        Else
            PlayerTwoPrefixComboBox.Enabled = True
            PlayerTwoNameTextBox.Enabled = True
            PlayerTwoSuffixComboBox.Enabled = True
        End If
    End Sub
End Class
