Module Globals

    Structure Player
        Public Name As String
        Public Wins As UInt16
        Public Losses As UInt16
        Public WinPercent As Double
        Public Symbol As Char
        Public Picture As Image
    End Structure

    Public Const PLAYER_X As Char = "X"
    Public Const PLAYER_O As Char = "O"

    Public Const PLAYER_ONE As UInt16 = 0
    Public Const PLAYER_TWO As UInt16 = 1

    Public AI As Boolean = False


End Module
