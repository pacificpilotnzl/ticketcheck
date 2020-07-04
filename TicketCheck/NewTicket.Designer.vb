<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTicket))
        Me.Seperator = New System.Windows.Forms.Panel()
        Me.FormContext = New System.Windows.Forms.Label()
        Me.FormInstruction = New System.Windows.Forms.Label()
        Me.TicketNoBox = New System.Windows.Forms.TextBox()
        Me.TicketNumberLabel = New System.Windows.Forms.Label()
        Me.PaidBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HolderBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServiceBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CompanyBox = New System.Windows.Forms.DomainUpDown()
        Me.SeatBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LocationBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonPanelForeground = New System.Windows.Forms.Panel()
        Me.BuildString = New System.Windows.Forms.Label()
        Me.ProceedButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ButtonPanelBackground = New System.Windows.Forms.Panel()
        Me.ButtonPanelForeground.SuspendLayout()
        Me.ButtonPanelBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'Seperator
        '
        Me.Seperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Seperator.Location = New System.Drawing.Point(15, 58)
        Me.Seperator.Name = "Seperator"
        Me.Seperator.Size = New System.Drawing.Size(320, 1)
        Me.Seperator.TabIndex = 1
        '
        'FormContext
        '
        Me.FormContext.AutoSize = True
        Me.FormContext.Location = New System.Drawing.Point(12, 33)
        Me.FormContext.Name = "FormContext"
        Me.FormContext.Size = New System.Drawing.Size(283, 15)
        Me.FormContext.TabIndex = 2
        Me.FormContext.Text = "Use this window to add a new ticket to the database."
        '
        'FormInstruction
        '
        Me.FormInstruction.AutoSize = True
        Me.FormInstruction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormInstruction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.FormInstruction.Location = New System.Drawing.Point(11, 10)
        Me.FormInstruction.Name = "FormInstruction"
        Me.FormInstruction.Size = New System.Drawing.Size(108, 21)
        Me.FormInstruction.TabIndex = 3
        Me.FormInstruction.Text = "Create a ticket"
        '
        'TicketNoBox
        '
        Me.TicketNoBox.Location = New System.Drawing.Point(15, 85)
        Me.TicketNoBox.Name = "TicketNoBox"
        Me.TicketNoBox.Size = New System.Drawing.Size(157, 23)
        Me.TicketNoBox.TabIndex = 5
        '
        'TicketNumberLabel
        '
        Me.TicketNumberLabel.AutoSize = True
        Me.TicketNumberLabel.Location = New System.Drawing.Point(11, 67)
        Me.TicketNumberLabel.Name = "TicketNumberLabel"
        Me.TicketNumberLabel.Size = New System.Drawing.Size(88, 15)
        Me.TicketNumberLabel.TabIndex = 4
        Me.TicketNumberLabel.Text = "Ticket Number:"
        '
        'PaidBox
        '
        Me.PaidBox.Location = New System.Drawing.Point(178, 85)
        Me.PaidBox.Name = "PaidBox"
        Me.PaidBox.Size = New System.Drawing.Size(157, 23)
        Me.PaidBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Paid Amount:"
        '
        'HolderBox
        '
        Me.HolderBox.Location = New System.Drawing.Point(16, 130)
        Me.HolderBox.Name = "HolderBox"
        Me.HolderBox.Size = New System.Drawing.Size(156, 23)
        Me.HolderBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Holder:"
        '
        'ServiceBox
        '
        Me.ServiceBox.Location = New System.Drawing.Point(179, 130)
        Me.ServiceBox.Name = "ServiceBox"
        Me.ServiceBox.Size = New System.Drawing.Size(157, 23)
        Me.ServiceBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Service:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Company:"
        '
        'CompanyBox
        '
        Me.CompanyBox.Items.Add("None")
        Me.CompanyBox.Items.Add("1")
        Me.CompanyBox.Items.Add("2")
        Me.CompanyBox.Items.Add("3")
        Me.CompanyBox.Items.Add("4")
        Me.CompanyBox.Items.Add("5")
        Me.CompanyBox.Items.Add("6")
        Me.CompanyBox.Items.Add("7")
        Me.CompanyBox.Items.Add("8")
        Me.CompanyBox.Items.Add("9")
        Me.CompanyBox.Items.Add("10")
        Me.CompanyBox.Items.Add("11")
        Me.CompanyBox.Items.Add("12")
        Me.CompanyBox.Items.Add("13")
        Me.CompanyBox.Items.Add("14")
        Me.CompanyBox.Items.Add("15")
        Me.CompanyBox.Items.Add("16")
        Me.CompanyBox.Items.Add("17")
        Me.CompanyBox.Items.Add("18")
        Me.CompanyBox.Items.Add("19")
        Me.CompanyBox.Items.Add("20")
        Me.CompanyBox.Items.Add("21")
        Me.CompanyBox.Items.Add("22")
        Me.CompanyBox.Items.Add("23")
        Me.CompanyBox.Items.Add("24")
        Me.CompanyBox.Items.Add("25")
        Me.CompanyBox.Items.Add("26")
        Me.CompanyBox.Items.Add("27")
        Me.CompanyBox.Items.Add("28")
        Me.CompanyBox.Items.Add("29")
        Me.CompanyBox.Items.Add("30")
        Me.CompanyBox.Items.Add("31")
        Me.CompanyBox.Items.Add("32")
        Me.CompanyBox.Items.Add("33")
        Me.CompanyBox.Items.Add("34")
        Me.CompanyBox.Items.Add("35")
        Me.CompanyBox.Items.Add("36")
        Me.CompanyBox.Items.Add("37")
        Me.CompanyBox.Items.Add("38")
        Me.CompanyBox.Items.Add("39")
        Me.CompanyBox.Items.Add("40")
        Me.CompanyBox.Items.Add("41")
        Me.CompanyBox.Items.Add("42")
        Me.CompanyBox.Items.Add("43")
        Me.CompanyBox.Items.Add("44")
        Me.CompanyBox.Items.Add("45")
        Me.CompanyBox.Items.Add("46")
        Me.CompanyBox.Items.Add("47")
        Me.CompanyBox.Items.Add("48")
        Me.CompanyBox.Items.Add("49")
        Me.CompanyBox.Items.Add("50")
        Me.CompanyBox.Items.Add("51")
        Me.CompanyBox.Items.Add("52")
        Me.CompanyBox.Items.Add("53")
        Me.CompanyBox.Items.Add("54")
        Me.CompanyBox.Items.Add("55")
        Me.CompanyBox.Items.Add("56")
        Me.CompanyBox.Items.Add("57")
        Me.CompanyBox.Items.Add("58")
        Me.CompanyBox.Items.Add("59")
        Me.CompanyBox.Items.Add("60")
        Me.CompanyBox.Location = New System.Drawing.Point(16, 175)
        Me.CompanyBox.Name = "CompanyBox"
        Me.CompanyBox.Size = New System.Drawing.Size(157, 23)
        Me.CompanyBox.TabIndex = 14
        Me.CompanyBox.Text = "None"
        '
        'SeatBox
        '
        Me.SeatBox.Location = New System.Drawing.Point(180, 175)
        Me.SeatBox.Name = "SeatBox"
        Me.SeatBox.Size = New System.Drawing.Size(74, 23)
        Me.SeatBox.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Seat:"
        '
        'LocationBox
        '
        Me.LocationBox.Location = New System.Drawing.Point(262, 175)
        Me.LocationBox.Name = "LocationBox"
        Me.LocationBox.Size = New System.Drawing.Size(75, 23)
        Me.LocationBox.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Location:"
        '
        'ButtonPanelForeground
        '
        Me.ButtonPanelForeground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPanelForeground.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ButtonPanelForeground.Controls.Add(Me.BuildString)
        Me.ButtonPanelForeground.Controls.Add(Me.ProceedButton)
        Me.ButtonPanelForeground.Controls.Add(Me.CloseButton)
        Me.ButtonPanelForeground.Location = New System.Drawing.Point(0, 1)
        Me.ButtonPanelForeground.Name = "ButtonPanelForeground"
        Me.ButtonPanelForeground.Size = New System.Drawing.Size(351, 40)
        Me.ButtonPanelForeground.TabIndex = 0
        '
        'BuildString
        '
        Me.BuildString.AutoSize = True
        Me.BuildString.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.BuildString.Location = New System.Drawing.Point(12, 12)
        Me.BuildString.Name = "BuildString"
        Me.BuildString.Size = New System.Drawing.Size(0, 15)
        Me.BuildString.TabIndex = 6
        '
        'ProceedButton
        '
        Me.ProceedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProceedButton.Location = New System.Drawing.Point(191, 8)
        Me.ProceedButton.Name = "ProceedButton"
        Me.ProceedButton.Size = New System.Drawing.Size(72, 23)
        Me.ProceedButton.TabIndex = 4
        Me.ProceedButton.TabStop = False
        Me.ProceedButton.Text = "&OK"
        Me.ProceedButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(269, 8)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(72, 23)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.TabStop = False
        Me.CloseButton.Text = "&Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ButtonPanelBackground
        '
        Me.ButtonPanelBackground.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ButtonPanelBackground.Controls.Add(Me.ButtonPanelForeground)
        Me.ButtonPanelBackground.Location = New System.Drawing.Point(0, 215)
        Me.ButtonPanelBackground.Name = "ButtonPanelBackground"
        Me.ButtonPanelBackground.Size = New System.Drawing.Size(351, 41)
        Me.ButtonPanelBackground.TabIndex = 24
        '
        'NewTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(351, 256)
        Me.Controls.Add(Me.ButtonPanelBackground)
        Me.Controls.Add(Me.LocationBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SeatBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CompanyBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ServiceBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HolderBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PaidBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TicketNoBox)
        Me.Controls.Add(Me.TicketNumberLabel)
        Me.Controls.Add(Me.Seperator)
        Me.Controls.Add(Me.FormContext)
        Me.Controls.Add(Me.FormInstruction)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create a ticket"
        Me.ButtonPanelForeground.ResumeLayout(False)
        Me.ButtonPanelForeground.PerformLayout()
        Me.ButtonPanelBackground.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Seperator As Panel
    Friend WithEvents FormContext As Label
    Friend WithEvents FormInstruction As Label
    Friend WithEvents TicketNoBox As TextBox
    Friend WithEvents TicketNumberLabel As Label
    Friend WithEvents PaidBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HolderBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ServiceBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CompanyBox As DomainUpDown
    Friend WithEvents SeatBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LocationBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonPanelForeground As Panel
    Friend WithEvents BuildString As Label
    Friend WithEvents ProceedButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ButtonPanelBackground As Panel
End Class
