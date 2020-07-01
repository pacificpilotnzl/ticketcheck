<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EncryptionFileRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UnlockButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.PasswordInputBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 41)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Controls.Add(Me.UnlockButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 40)
        Me.Panel2.TabIndex = 1
        '
        'UnlockButton
        '
        Me.UnlockButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.UnlockButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlockButton.Location = New System.Drawing.Point(189, 8)
        Me.UnlockButton.Name = "UnlockButton"
        Me.UnlockButton.Size = New System.Drawing.Size(72, 23)
        Me.UnlockButton.TabIndex = 1
        Me.UnlockButton.Text = "&Unlock"
        Me.UnlockButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(267, 8)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(72, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLabel.Location = New System.Drawing.Point(10, 39)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(313, 30)
        Me.TextLabel.TabIndex = 4
        Me.TextLabel.Text = "This file has been encrypted with a password. Please enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the password to load" &
    " it in TicketCheck."
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.InstructionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InstructionLabel.Location = New System.Drawing.Point(9, 11)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(134, 20)
        Me.InstructionLabel.TabIndex = 3
        Me.InstructionLabel.Text = "Password Required"
        '
        'PasswordInputBox
        '
        Me.PasswordInputBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordInputBox.Location = New System.Drawing.Point(13, 81)
        Me.PasswordInputBox.Name = "PasswordInputBox"
        Me.PasswordInputBox.Size = New System.Drawing.Size(260, 23)
        Me.PasswordInputBox.TabIndex = 0
        Me.PasswordInputBox.UseSystemPasswordChar = True
        '
        'EncryptionFileRequest
        '
        Me.AcceptButton = Me.UnlockButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 162)
        Me.Controls.Add(Me.PasswordInputBox)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EncryptionFileRequest"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Required"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CancelButton As Button
    Friend WithEvents UnlockButton As Button
    Friend WithEvents TextLabel As Label
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents PasswordInputBox As TextBox
End Class
