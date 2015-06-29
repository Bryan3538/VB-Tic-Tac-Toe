<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button00 = New System.Windows.Forms.Button()
        Me.Button01 = New System.Windows.Forms.Button()
        Me.Button02 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PlayerOneWinPercentLabel = New System.Windows.Forms.Label()
        Me.PlayerOneWinsLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PlayerOneLossesLabel = New System.Windows.Forms.Label()
        Me.PlayerOneSymbolLabel = New System.Windows.Forms.Label()
        Me.PlayerOneNameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StalematePercentLabel = New System.Windows.Forms.Label()
        Me.StalematesLabel = New System.Windows.Forms.Label()
        Me.GamesPlayedLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PlayerTwoWinPercentLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoWinsLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PlayerTwoLossesLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoSymbolLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoNameLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CurPlayerLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CurPlayerPictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CurPlayerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button00, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button01, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button02, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button11, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button12, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button20, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button21, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button22, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(295, 36)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(553, 474)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button00
        '
        Me.Button00.BackgroundImage = Global.Testing_1.My.Resources.Resources.defaultbg
        Me.Button00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button00.Location = New System.Drawing.Point(3, 3)
        Me.Button00.Name = "Button00"
        Me.Button00.Size = New System.Drawing.Size(175, 150)
        Me.Button00.TabIndex = 0
        Me.Button00.UseVisualStyleBackColor = True
        '
        'Button01
        '
        Me.Button01.BackgroundImage = CType(resources.GetObject("Button01.BackgroundImage"), System.Drawing.Image)
        Me.Button01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button01.Location = New System.Drawing.Point(187, 3)
        Me.Button01.Name = "Button01"
        Me.Button01.Size = New System.Drawing.Size(175, 150)
        Me.Button01.TabIndex = 1
        Me.Button01.UseVisualStyleBackColor = True
        '
        'Button02
        '
        Me.Button02.BackgroundImage = CType(resources.GetObject("Button02.BackgroundImage"), System.Drawing.Image)
        Me.Button02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button02.Location = New System.Drawing.Point(371, 3)
        Me.Button02.Name = "Button02"
        Me.Button02.Size = New System.Drawing.Size(175, 150)
        Me.Button02.TabIndex = 2
        Me.Button02.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(3, 161)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(175, 150)
        Me.Button10.TabIndex = 3
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(187, 161)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(175, 150)
        Me.Button11.TabIndex = 4
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(371, 161)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(175, 150)
        Me.Button12.TabIndex = 5
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.Location = New System.Drawing.Point(3, 319)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(175, 150)
        Me.Button20.TabIndex = 6
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.Location = New System.Drawing.Point(187, 319)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(175, 150)
        Me.Button21.TabIndex = 7
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.BackgroundImage = CType(resources.GetObject("Button22.BackgroundImage"), System.Drawing.Image)
        Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button22.Location = New System.Drawing.Point(371, 319)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(175, 150)
        Me.Button22.TabIndex = 8
        Me.Button22.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.PlayerOneWinPercentLabel)
        Me.GroupBox1.Controls.Add(Me.PlayerOneWinsLabel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PlayerOneLossesLabel)
        Me.GroupBox1.Controls.Add(Me.PlayerOneSymbolLabel)
        Me.GroupBox1.Controls.Add(Me.PlayerOneNameLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 174)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player One Stats"
        '
        'PlayerOneWinPercentLabel
        '
        Me.PlayerOneWinPercentLabel.AutoSize = True
        Me.PlayerOneWinPercentLabel.Location = New System.Drawing.Point(108, 150)
        Me.PlayerOneWinPercentLabel.Name = "PlayerOneWinPercentLabel"
        Me.PlayerOneWinPercentLabel.Size = New System.Drawing.Size(52, 13)
        Me.PlayerOneWinPercentLabel.TabIndex = 9
        Me.PlayerOneWinPercentLabel.Text = "Label10"
        '
        'PlayerOneWinsLabel
        '
        Me.PlayerOneWinsLabel.AutoSize = True
        Me.PlayerOneWinsLabel.Location = New System.Drawing.Point(108, 98)
        Me.PlayerOneWinsLabel.Name = "PlayerOneWinsLabel"
        Me.PlayerOneWinsLabel.Size = New System.Drawing.Size(45, 13)
        Me.PlayerOneWinsLabel.TabIndex = 8
        Me.PlayerOneWinsLabel.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Win %: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Losses: "
        '
        'PlayerOneLossesLabel
        '
        Me.PlayerOneLossesLabel.AutoSize = True
        Me.PlayerOneLossesLabel.Location = New System.Drawing.Point(108, 124)
        Me.PlayerOneLossesLabel.Name = "PlayerOneLossesLabel"
        Me.PlayerOneLossesLabel.Size = New System.Drawing.Size(45, 13)
        Me.PlayerOneLossesLabel.TabIndex = 5
        Me.PlayerOneLossesLabel.Text = "Label6"
        '
        'PlayerOneSymbolLabel
        '
        Me.PlayerOneSymbolLabel.AutoSize = True
        Me.PlayerOneSymbolLabel.Location = New System.Drawing.Point(108, 72)
        Me.PlayerOneSymbolLabel.Name = "PlayerOneSymbolLabel"
        Me.PlayerOneSymbolLabel.Size = New System.Drawing.Size(45, 13)
        Me.PlayerOneSymbolLabel.TabIndex = 4
        Me.PlayerOneSymbolLabel.Text = "Label5"
        '
        'PlayerOneNameLabel
        '
        Me.PlayerOneNameLabel.Location = New System.Drawing.Point(69, 16)
        Me.PlayerOneNameLabel.Name = "PlayerOneNameLabel"
        Me.PlayerOneNameLabel.Size = New System.Drawing.Size(157, 45)
        Me.PlayerOneNameLabel.TabIndex = 3
        Me.PlayerOneNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wins: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Symbol: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.StalematePercentLabel)
        Me.GroupBox3.Controls.Add(Me.StalematesLabel)
        Me.GroupBox3.Controls.Add(Me.GamesPlayedLabel)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 116)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Session Stats"
        '
        'StalematePercentLabel
        '
        Me.StalematePercentLabel.AutoSize = True
        Me.StalematePercentLabel.Location = New System.Drawing.Point(108, 86)
        Me.StalematePercentLabel.Name = "StalematePercentLabel"
        Me.StalematePercentLabel.Size = New System.Drawing.Size(52, 13)
        Me.StalematePercentLabel.TabIndex = 5
        Me.StalematePercentLabel.Text = "Label17"
        '
        'StalematesLabel
        '
        Me.StalematesLabel.AutoSize = True
        Me.StalematesLabel.Location = New System.Drawing.Point(108, 57)
        Me.StalematesLabel.Name = "StalematesLabel"
        Me.StalematesLabel.Size = New System.Drawing.Size(52, 13)
        Me.StalematesLabel.TabIndex = 4
        Me.StalematesLabel.Text = "Label13"
        '
        'GamesPlayedLabel
        '
        Me.GamesPlayedLabel.AutoSize = True
        Me.GamesPlayedLabel.Location = New System.Drawing.Point(108, 28)
        Me.GamesPlayedLabel.Name = "GamesPlayedLabel"
        Me.GamesPlayedLabel.Size = New System.Drawing.Size(52, 13)
        Me.GamesPlayedLabel.TabIndex = 3
        Me.GamesPlayedLabel.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Stalemate %: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Stalemates: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Games Played: "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PlayerTwoWinPercentLabel)
        Me.GroupBox2.Controls.Add(Me.PlayerTwoWinsLabel)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.PlayerTwoLossesLabel)
        Me.GroupBox2.Controls.Add(Me.PlayerTwoSymbolLabel)
        Me.GroupBox2.Controls.Add(Me.PlayerTwoNameLabel)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 174)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player Two Stats"
        '
        'PlayerTwoWinPercentLabel
        '
        Me.PlayerTwoWinPercentLabel.AutoSize = True
        Me.PlayerTwoWinPercentLabel.Location = New System.Drawing.Point(108, 150)
        Me.PlayerTwoWinPercentLabel.Name = "PlayerTwoWinPercentLabel"
        Me.PlayerTwoWinPercentLabel.Size = New System.Drawing.Size(52, 13)
        Me.PlayerTwoWinPercentLabel.TabIndex = 9
        Me.PlayerTwoWinPercentLabel.Text = "Label10"
        '
        'PlayerTwoWinsLabel
        '
        Me.PlayerTwoWinsLabel.AutoSize = True
        Me.PlayerTwoWinsLabel.Location = New System.Drawing.Point(108, 98)
        Me.PlayerTwoWinsLabel.Name = "PlayerTwoWinsLabel"
        Me.PlayerTwoWinsLabel.Size = New System.Drawing.Size(45, 13)
        Me.PlayerTwoWinsLabel.TabIndex = 8
        Me.PlayerTwoWinsLabel.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Win %: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Losses: "
        '
        'PlayerTwoLossesLabel
        '
        Me.PlayerTwoLossesLabel.AutoSize = True
        Me.PlayerTwoLossesLabel.Location = New System.Drawing.Point(108, 124)
        Me.PlayerTwoLossesLabel.Name = "PlayerTwoLossesLabel"
        Me.PlayerTwoLossesLabel.Size = New System.Drawing.Size(45, 13)
        Me.PlayerTwoLossesLabel.TabIndex = 5
        Me.PlayerTwoLossesLabel.Text = "Label6"
        '
        'PlayerTwoSymbolLabel
        '
        Me.PlayerTwoSymbolLabel.AutoSize = True
        Me.PlayerTwoSymbolLabel.Location = New System.Drawing.Point(108, 72)
        Me.PlayerTwoSymbolLabel.Name = "PlayerTwoSymbolLabel"
        Me.PlayerTwoSymbolLabel.Size = New System.Drawing.Size(45, 13)
        Me.PlayerTwoSymbolLabel.TabIndex = 4
        Me.PlayerTwoSymbolLabel.Text = "Label5"
        '
        'PlayerTwoNameLabel
        '
        Me.PlayerTwoNameLabel.Location = New System.Drawing.Point(69, 16)
        Me.PlayerTwoNameLabel.Name = "PlayerTwoNameLabel"
        Me.PlayerTwoNameLabel.Size = New System.Drawing.Size(157, 45)
        Me.PlayerTwoNameLabel.TabIndex = 3
        Me.PlayerTwoNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Wins: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Symbol: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Name: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(936, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Current Turn"
        '
        'CurPlayerLabel
        '
        Me.CurPlayerLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurPlayerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurPlayerLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurPlayerLabel.Location = New System.Drawing.Point(855, 98)
        Me.CurPlayerLabel.Name = "CurPlayerLabel"
        Me.CurPlayerLabel.Size = New System.Drawing.Size(282, 59)
        Me.CurPlayerLabel.TabIndex = 6
        Me.CurPlayerLabel.Text = "sdf"
        Me.CurPlayerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ExitButton
        '
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Location = New System.Drawing.Point(966, 455)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(87, 50)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CurPlayerPictureBox
        '
        Me.CurPlayerPictureBox.BackColor = System.Drawing.SystemColors.Control
        Me.CurPlayerPictureBox.Location = New System.Drawing.Point(915, 160)
        Me.CurPlayerPictureBox.Name = "CurPlayerPictureBox"
        Me.CurPlayerPictureBox.Size = New System.Drawing.Size(175, 150)
        Me.CurPlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CurPlayerPictureBox.TabIndex = 7
        Me.CurPlayerPictureBox.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1151, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem1})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "P&rint Preview..."
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem1.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(96, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.InstructionsToolStripMenuItem.Text = "&Instructions..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Testing_1.My.Resources.Resources.Warp_thing_gif
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1151, 521)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CurPlayerPictureBox)
        Me.Controls.Add(Me.CurPlayerLabel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bryan's Tic Tac Toe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CurPlayerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button00 As System.Windows.Forms.Button
    Friend WithEvents Button01 As System.Windows.Forms.Button
    Friend WithEvents Button02 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PlayerOneWinPercentLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerOneWinsLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PlayerOneLossesLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerOneSymbolLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerOneNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StalematePercentLabel As System.Windows.Forms.Label
    Friend WithEvents StalematesLabel As System.Windows.Forms.Label
    Friend WithEvents GamesPlayedLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PlayerTwoWinPercentLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerTwoWinsLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlayerTwoLossesLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerTwoSymbolLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerTwoNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CurPlayerLabel As System.Windows.Forms.Label
    Friend WithEvents CurPlayerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
