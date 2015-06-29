<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XOSelectionForm
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
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.XButton = New System.Windows.Forms.Button()
        Me.OButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.Transparent
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Gold
        Me.MessageLabel.Location = New System.Drawing.Point(12, 9)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(335, 39)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "<PH>Filled at runtime"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XButton
        '
        Me.XButton.BackgroundImage = Global.Testing_1.My.Resources.Resources.X
        Me.XButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.XButton.Location = New System.Drawing.Point(26, 71)
        Me.XButton.Name = "XButton"
        Me.XButton.Size = New System.Drawing.Size(150, 150)
        Me.XButton.TabIndex = 1
        Me.XButton.UseVisualStyleBackColor = True
        '
        'OButton
        '
        Me.OButton.BackgroundImage = Global.Testing_1.My.Resources.Resources.Circle2
        Me.OButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OButton.Location = New System.Drawing.Point(182, 72)
        Me.OButton.Name = "OButton"
        Me.OButton.Size = New System.Drawing.Size(150, 150)
        Me.OButton.TabIndex = 2
        Me.OButton.UseVisualStyleBackColor = True
        '
        'XOSelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Testing_1.My.Resources.Resources.stone_wall_copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(359, 234)
        Me.Controls.Add(Me.OButton)
        Me.Controls.Add(Me.XButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "XOSelectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step 2: Select Your Symbols"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents XButton As System.Windows.Forms.Button
    Friend WithEvents OButton As System.Windows.Forms.Button
End Class
