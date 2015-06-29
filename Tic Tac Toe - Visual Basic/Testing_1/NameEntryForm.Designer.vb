<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameEntryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PlayerOneNameTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerTwoNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayerOnePrefixComboBox = New System.Windows.Forms.ComboBox()
        Me.PlayerTwoPrefixComboBox = New System.Windows.Forms.ComboBox()
        Me.PlayerOneSuffixComboBox = New System.Windows.Forms.ComboBox()
        Me.PlayerTwoSuffixComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AICheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(210, 190)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 7
        Me.NextButton.Text = "Next ->"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PlayerOneNameTextBox
        '
        Me.PlayerOneNameTextBox.Location = New System.Drawing.Point(165, 90)
        Me.PlayerOneNameTextBox.Name = "PlayerOneNameTextBox"
        Me.PlayerOneNameTextBox.Size = New System.Drawing.Size(161, 20)
        Me.PlayerOneNameTextBox.TabIndex = 1
        Me.PlayerOneNameTextBox.Text = "Player One"
        '
        'PlayerTwoNameTextBox
        '
        Me.PlayerTwoNameTextBox.Location = New System.Drawing.Point(165, 148)
        Me.PlayerTwoNameTextBox.Name = "PlayerTwoNameTextBox"
        Me.PlayerTwoNameTextBox.Size = New System.Drawing.Size(161, 20)
        Me.PlayerTwoNameTextBox.TabIndex = 4
        Me.PlayerTwoNameTextBox.Text = "Player Two"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(214, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player One:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(214, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Player Two:"
        '
        'PlayerOnePrefixComboBox
        '
        Me.PlayerOnePrefixComboBox.FormattingEnabled = True
        Me.PlayerOnePrefixComboBox.Location = New System.Drawing.Point(12, 89)
        Me.PlayerOnePrefixComboBox.Name = "PlayerOnePrefixComboBox"
        Me.PlayerOnePrefixComboBox.Size = New System.Drawing.Size(147, 21)
        Me.PlayerOnePrefixComboBox.TabIndex = 0
        '
        'PlayerTwoPrefixComboBox
        '
        Me.PlayerTwoPrefixComboBox.FormattingEnabled = True
        Me.PlayerTwoPrefixComboBox.Location = New System.Drawing.Point(12, 147)
        Me.PlayerTwoPrefixComboBox.Name = "PlayerTwoPrefixComboBox"
        Me.PlayerTwoPrefixComboBox.Size = New System.Drawing.Size(148, 21)
        Me.PlayerTwoPrefixComboBox.TabIndex = 3
        '
        'PlayerOneSuffixComboBox
        '
        Me.PlayerOneSuffixComboBox.FormattingEnabled = True
        Me.PlayerOneSuffixComboBox.Location = New System.Drawing.Point(332, 89)
        Me.PlayerOneSuffixComboBox.Name = "PlayerOneSuffixComboBox"
        Me.PlayerOneSuffixComboBox.Size = New System.Drawing.Size(150, 21)
        Me.PlayerOneSuffixComboBox.TabIndex = 2
        '
        'PlayerTwoSuffixComboBox
        '
        Me.PlayerTwoSuffixComboBox.FormattingEnabled = True
        Me.PlayerTwoSuffixComboBox.Location = New System.Drawing.Point(332, 148)
        Me.PlayerTwoSuffixComboBox.Name = "PlayerTwoSuffixComboBox"
        Me.PlayerTwoSuffixComboBox.Size = New System.Drawing.Size(150, 21)
        Me.PlayerTwoSuffixComboBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(45, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Welcome to Bryan's Tic Tac Toe Program!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select your names including any a" & _
    "dditional titles you may want."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AICheckBox
        '
        Me.AICheckBox.AutoSize = True
        Me.AICheckBox.BackColor = System.Drawing.Color.Transparent
        Me.AICheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AICheckBox.ForeColor = System.Drawing.Color.Gold
        Me.AICheckBox.Location = New System.Drawing.Point(12, 128)
        Me.AICheckBox.Name = "AICheckBox"
        Me.AICheckBox.Size = New System.Drawing.Size(129, 17)
        Me.AICheckBox.TabIndex = 6
        Me.AICheckBox.Text = "Play the Computer"
        Me.AICheckBox.UseVisualStyleBackColor = False
        '
        'NameEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Testing_1.My.Resources.Resources.stone_wall_copy
        Me.ClientSize = New System.Drawing.Size(494, 235)
        Me.Controls.Add(Me.AICheckBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PlayerTwoSuffixComboBox)
        Me.Controls.Add(Me.PlayerOneSuffixComboBox)
        Me.Controls.Add(Me.PlayerTwoPrefixComboBox)
        Me.Controls.Add(Me.PlayerOnePrefixComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayerTwoNameTextBox)
        Me.Controls.Add(Me.PlayerOneNameTextBox)
        Me.Controls.Add(Me.NextButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NameEntryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step 1: Enter Your Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents PlayerOneNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlayerTwoNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PlayerOnePrefixComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlayerTwoPrefixComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlayerOneSuffixComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlayerTwoSuffixComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AICheckBox As System.Windows.Forms.CheckBox

End Class
