<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncryptionTestForm
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
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.Seperator = New System.Windows.Forms.Panel()
        Me.EncryptionGroup = New System.Windows.Forms.GroupBox()
        Me.EncryptData = New System.Windows.Forms.RichTextBox()
        Me.EncryptOutput = New System.Windows.Forms.TextBox()
        Me.EncryptBtn = New System.Windows.Forms.Button()
        Me.EnDatLbl = New System.Windows.Forms.Label()
        Me.EncryptKey = New System.Windows.Forms.TextBox()
        Me.EnKeyLbl = New System.Windows.Forms.Label()
        Me.DecryptionGroup = New System.Windows.Forms.GroupBox()
        Me.DecryptData = New System.Windows.Forms.RichTextBox()
        Me.DecryptOutput = New System.Windows.Forms.TextBox()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.DeDatLabl = New System.Windows.Forms.Label()
        Me.DecryptKey = New System.Windows.Forms.TextBox()
        Me.DeKeyLbl = New System.Windows.Forms.Label()
        Me.EncryptionGroup.SuspendLayout()
        Me.DecryptionGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.InstructionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InstructionLabel.Location = New System.Drawing.Point(12, 10)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(181, 20)
        Me.InstructionLabel.TabIndex = 4
        Me.InstructionLabel.Text = "String Encryption (Debug)"
        '
        'Seperator
        '
        Me.Seperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Seperator.Location = New System.Drawing.Point(16, 39)
        Me.Seperator.Name = "Seperator"
        Me.Seperator.Size = New System.Drawing.Size(705, 1)
        Me.Seperator.TabIndex = 5
        '
        'EncryptionGroup
        '
        Me.EncryptionGroup.Controls.Add(Me.EncryptData)
        Me.EncryptionGroup.Controls.Add(Me.EncryptOutput)
        Me.EncryptionGroup.Controls.Add(Me.EncryptBtn)
        Me.EncryptionGroup.Controls.Add(Me.EnDatLbl)
        Me.EncryptionGroup.Controls.Add(Me.EncryptKey)
        Me.EncryptionGroup.Controls.Add(Me.EnKeyLbl)
        Me.EncryptionGroup.Location = New System.Drawing.Point(16, 46)
        Me.EncryptionGroup.Name = "EncryptionGroup"
        Me.EncryptionGroup.Size = New System.Drawing.Size(349, 293)
        Me.EncryptionGroup.TabIndex = 6
        Me.EncryptionGroup.TabStop = False
        Me.EncryptionGroup.Text = "Encryption"
        '
        'EncryptData
        '
        Me.EncryptData.Location = New System.Drawing.Point(9, 70)
        Me.EncryptData.Name = "EncryptData"
        Me.EncryptData.Size = New System.Drawing.Size(334, 188)
        Me.EncryptData.TabIndex = 7
        Me.EncryptData.Text = ""
        '
        'EncryptOutput
        '
        Me.EncryptOutput.Location = New System.Drawing.Point(83, 263)
        Me.EncryptOutput.Multiline = True
        Me.EncryptOutput.Name = "EncryptOutput"
        Me.EncryptOutput.Size = New System.Drawing.Size(260, 23)
        Me.EncryptOutput.TabIndex = 16
        '
        'EncryptBtn
        '
        Me.EncryptBtn.Location = New System.Drawing.Point(9, 262)
        Me.EncryptBtn.Name = "EncryptBtn"
        Me.EncryptBtn.Size = New System.Drawing.Size(70, 25)
        Me.EncryptBtn.TabIndex = 15
        Me.EncryptBtn.Text = "Encrypt"
        Me.EncryptBtn.UseVisualStyleBackColor = True
        '
        'EnDatLbl
        '
        Me.EnDatLbl.AutoSize = True
        Me.EnDatLbl.Location = New System.Drawing.Point(6, 50)
        Me.EnDatLbl.Name = "EnDatLbl"
        Me.EnDatLbl.Size = New System.Drawing.Size(91, 15)
        Me.EnDatLbl.TabIndex = 13
        Me.EnDatLbl.Text = "Data to Encrypt:"
        '
        'EncryptKey
        '
        Me.EncryptKey.Location = New System.Drawing.Point(101, 21)
        Me.EncryptKey.Name = "EncryptKey"
        Me.EncryptKey.Size = New System.Drawing.Size(242, 23)
        Me.EncryptKey.TabIndex = 12
        '
        'EnKeyLbl
        '
        Me.EnKeyLbl.AutoSize = True
        Me.EnKeyLbl.Location = New System.Drawing.Point(6, 24)
        Me.EnKeyLbl.Name = "EnKeyLbl"
        Me.EnKeyLbl.Size = New System.Drawing.Size(89, 15)
        Me.EnKeyLbl.TabIndex = 11
        Me.EnKeyLbl.Text = "Encryption Key:"
        '
        'DecryptionGroup
        '
        Me.DecryptionGroup.Controls.Add(Me.DecryptData)
        Me.DecryptionGroup.Controls.Add(Me.DecryptOutput)
        Me.DecryptionGroup.Controls.Add(Me.DecryptButton)
        Me.DecryptionGroup.Controls.Add(Me.DeDatLabl)
        Me.DecryptionGroup.Controls.Add(Me.DecryptKey)
        Me.DecryptionGroup.Controls.Add(Me.DeKeyLbl)
        Me.DecryptionGroup.Location = New System.Drawing.Point(371, 46)
        Me.DecryptionGroup.Name = "DecryptionGroup"
        Me.DecryptionGroup.Size = New System.Drawing.Size(349, 293)
        Me.DecryptionGroup.TabIndex = 17
        Me.DecryptionGroup.TabStop = False
        Me.DecryptionGroup.Text = "Decryption"
        '
        'DecryptData
        '
        Me.DecryptData.Location = New System.Drawing.Point(9, 70)
        Me.DecryptData.Name = "DecryptData"
        Me.DecryptData.Size = New System.Drawing.Size(334, 188)
        Me.DecryptData.TabIndex = 7
        Me.DecryptData.Text = ""
        '
        'DecryptOutput
        '
        Me.DecryptOutput.Location = New System.Drawing.Point(83, 262)
        Me.DecryptOutput.Multiline = True
        Me.DecryptOutput.Name = "DecryptOutput"
        Me.DecryptOutput.Size = New System.Drawing.Size(260, 23)
        Me.DecryptOutput.TabIndex = 16
        '
        'DecryptButton
        '
        Me.DecryptButton.Location = New System.Drawing.Point(9, 261)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(70, 25)
        Me.DecryptButton.TabIndex = 15
        Me.DecryptButton.Text = "Decrypt"
        Me.DecryptButton.UseVisualStyleBackColor = True
        '
        'DeDatLabl
        '
        Me.DeDatLabl.AutoSize = True
        Me.DeDatLabl.Location = New System.Drawing.Point(6, 50)
        Me.DeDatLabl.Name = "DeDatLabl"
        Me.DeDatLabl.Size = New System.Drawing.Size(92, 15)
        Me.DeDatLabl.TabIndex = 13
        Me.DeDatLabl.Text = "Data to Decrypt:"
        '
        'DecryptKey
        '
        Me.DecryptKey.Location = New System.Drawing.Point(101, 21)
        Me.DecryptKey.Name = "DecryptKey"
        Me.DecryptKey.Size = New System.Drawing.Size(242, 23)
        Me.DecryptKey.TabIndex = 12
        '
        'DeKeyLbl
        '
        Me.DeKeyLbl.AutoSize = True
        Me.DeKeyLbl.Location = New System.Drawing.Point(6, 24)
        Me.DeKeyLbl.Name = "DeKeyLbl"
        Me.DeKeyLbl.Size = New System.Drawing.Size(90, 15)
        Me.DeKeyLbl.TabIndex = 11
        Me.DeKeyLbl.Text = "Decryption Key:"
        '
        'EncryptionTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(733, 353)
        Me.Controls.Add(Me.DecryptionGroup)
        Me.Controls.Add(Me.EncryptionGroup)
        Me.Controls.Add(Me.Seperator)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EncryptionTestForm"
        Me.Text = "Encryption"
        Me.EncryptionGroup.ResumeLayout(False)
        Me.EncryptionGroup.PerformLayout()
        Me.DecryptionGroup.ResumeLayout(False)
        Me.DecryptionGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InstructionLabel As Label
    Friend WithEvents Seperator As Panel
    Friend WithEvents EncryptionGroup As GroupBox
    Friend WithEvents EncryptData As RichTextBox
    Friend WithEvents EncryptOutput As TextBox
    Friend WithEvents EncryptBtn As Button
    Friend WithEvents EnDatLbl As Label
    Friend WithEvents EncryptKey As TextBox
    Friend WithEvents EnKeyLbl As Label
    Friend WithEvents DecryptionGroup As GroupBox
    Friend WithEvents DecryptData As RichTextBox
    Friend WithEvents DecryptOutput As TextBox
    Friend WithEvents DecryptButton As Button
    Friend WithEvents DeDatLabl As Label
    Friend WithEvents DecryptKey As TextBox
    Friend WithEvents DeKeyLbl As Label
End Class
