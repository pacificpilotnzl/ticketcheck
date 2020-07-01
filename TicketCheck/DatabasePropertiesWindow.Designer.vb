<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabasePropertiesWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabasePropertiesWindow))
        Me.LowerButtonPanel = New System.Windows.Forms.Panel()
        Me.CancelChangesButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.DecorationLine = New System.Windows.Forms.Panel()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.CreatedTextBox = New System.Windows.Forms.TextBox()
        Me.CreatedLabel = New System.Windows.Forms.Label()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LowerButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LowerButtonPanel
        '
        Me.LowerButtonPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LowerButtonPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LowerButtonPanel.Controls.Add(Me.CancelChangesButton)
        Me.LowerButtonPanel.Controls.Add(Me.OKButton)
        Me.LowerButtonPanel.Controls.Add(Me.DecorationLine)
        Me.LowerButtonPanel.Location = New System.Drawing.Point(0, 330)
        Me.LowerButtonPanel.Name = "LowerButtonPanel"
        Me.LowerButtonPanel.Size = New System.Drawing.Size(334, 41)
        Me.LowerButtonPanel.TabIndex = 0
        '
        'CancelChangesButton
        '
        Me.CancelChangesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelChangesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelChangesButton.Location = New System.Drawing.Point(166, 8)
        Me.CancelChangesButton.Name = "CancelChangesButton"
        Me.CancelChangesButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelChangesButton.TabIndex = 3
        Me.CancelChangesButton.Text = "&Cancel"
        Me.CancelChangesButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(247, 8)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'DecorationLine
        '
        Me.DecorationLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DecorationLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DecorationLine.Location = New System.Drawing.Point(0, 0)
        Me.DecorationLine.Name = "DecorationLine"
        Me.DecorationLine.Size = New System.Drawing.Size(334, 1)
        Me.DecorationLine.TabIndex = 1
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.InstructionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InstructionLabel.Location = New System.Drawing.Point(12, 9)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(143, 20)
        Me.InstructionLabel.TabIndex = 1
        Me.InstructionLabel.Text = "Database Properties"
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Location = New System.Drawing.Point(14, 44)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(295, 30)
        Me.TextLabel.TabIndex = 2
        Me.TextLabel.Text = "You can use this window to modify information about " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this database file."
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Location = New System.Drawing.Point(13, 120)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(68, 15)
        Me.AuthorLabel.TabIndex = 3
        Me.AuthorLabel.Text = "File Author:"
        '
        'AuthorTextBox
        '
        Me.HelpProvider.SetHelpString(Me.AuthorTextBox, "Set the name of this file's primary author.")
        Me.AuthorTextBox.Location = New System.Drawing.Point(115, 116)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.HelpProvider.SetShowHelp(Me.AuthorTextBox, True)
        Me.AuthorTextBox.Size = New System.Drawing.Size(208, 23)
        Me.AuthorTextBox.TabIndex = 4
        '
        'CreatedTextBox
        '
        Me.HelpProvider.SetHelpString(Me.CreatedTextBox, "(Read-only) The date this file was created.")
        Me.CreatedTextBox.Location = New System.Drawing.Point(115, 145)
        Me.CreatedTextBox.Name = "CreatedTextBox"
        Me.CreatedTextBox.ReadOnly = True
        Me.HelpProvider.SetShowHelp(Me.CreatedTextBox, True)
        Me.CreatedTextBox.Size = New System.Drawing.Size(208, 23)
        Me.CreatedTextBox.TabIndex = 6
        '
        'CreatedLabel
        '
        Me.CreatedLabel.AutoSize = True
        Me.CreatedLabel.Location = New System.Drawing.Point(13, 149)
        Me.CreatedLabel.Name = "CreatedLabel"
        Me.CreatedLabel.Size = New System.Drawing.Size(51, 15)
        Me.CreatedLabel.TabIndex = 5
        Me.CreatedLabel.Text = "Created:"
        '
        'NameTextBox
        '
        Me.HelpProvider.SetHelpString(Me.NameTextBox, "Set the name of the event this file is for.")
        Me.NameTextBox.Location = New System.Drawing.Point(114, 87)
        Me.NameTextBox.Name = "NameTextBox"
        Me.HelpProvider.SetShowHelp(Me.NameTextBox, True)
        Me.NameTextBox.Size = New System.Drawing.Size(208, 23)
        Me.NameTextBox.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.HelpProvider.SetHelpString(Me.TextBox2, "Set the name of this file's primary author.")
        Me.TextBox2.Location = New System.Drawing.Point(141, 294)
        Me.TextBox2.Name = "TextBox2"
        Me.HelpProvider.SetShowHelp(Me.TextBox2, True)
        Me.TextBox2.Size = New System.Drawing.Size(182, 23)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(14, 90)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(74, 15)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Event Name:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 297)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 19)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Encrypt this file"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DatabasePropertiesWindow
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelChangesButton
        Me.ClientSize = New System.Drawing.Size(334, 371)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.CreatedTextBox)
        Me.Controls.Add(Me.CreatedLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.LowerButtonPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabasePropertiesWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Properties"
        Me.LowerButtonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LowerButtonPanel As Panel
    Friend WithEvents DecorationLine As Panel
    Friend WithEvents CancelChangesButton As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents TextLabel As Label
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents CreatedTextBox As TextBox
    Friend WithEvents CreatedLabel As Label
    Friend WithEvents HelpProvider As HelpProvider
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
End Class
