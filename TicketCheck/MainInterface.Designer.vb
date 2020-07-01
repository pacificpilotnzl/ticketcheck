<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInterface))
        Me.BuildString = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDatabaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDatabaseFromExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetExcelTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNewSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDatabaseAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileOpenSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDatabaseAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSaveSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileReloadSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabasePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DebugItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetTCDXFileAssociationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReviewTCDXFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptPasswordDialogRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthMenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolMenu = New System.Windows.Forms.ToolStrip()
        Me.NewTicketButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FilterTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TicketListFront = New System.Windows.Forms.ListView()
        Me.TicketNumberColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IssueTimeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServiceColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HolderColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompanyColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SeatColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LocationColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValidFromColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValidToColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PriceColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DecryptOutput = New System.Windows.Forms.TextBox()
        Me.DecryptBtn = New System.Windows.Forms.Button()
        Me.DecryptData = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DecryptKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EncryptOutput = New System.Windows.Forms.TextBox()
        Me.EncryptBtn = New System.Windows.Forms.Button()
        Me.EncryptData = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EncryptKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.TitleMenuStrip.SuspendLayout()
        Me.ToolMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BuildString
        '
        Me.BuildString.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuildString.BackColor = System.Drawing.Color.White
        Me.BuildString.ForeColor = System.Drawing.Color.Gray
        Me.BuildString.Location = New System.Drawing.Point(909, 2)
        Me.BuildString.Name = "BuildString"
        Me.BuildString.Size = New System.Drawing.Size(353, 20)
        Me.BuildString.TabIndex = 3
        Me.BuildString.Text = "BuildString"
        Me.BuildString.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuildString.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDatabaseToolStripMenuItem, Me.FileNewSeperator, Me.OpenDatabaseToolStripMenuItem, Me.OpenDatabaseAsToolStripMenuItem, Me.FileOpenSeperator, Me.SaveToolStripMenuItem, Me.SaveDatabaseAsToolStripMenuItem, Me.FileSaveSeperator, Me.ReloadToolStripMenuItem, Me.FileReloadSeperator, Me.PreferencesToolStripMenuItem, Me.QuitToolStripMenuItem, Me.WidthMenuItemFile})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewDatabaseToolStripMenuItem
        '
        Me.NewDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDatabaseToolStripMenuItem1, Me.NewDatabaseFromExcelToolStripMenuItem, Me.ToolStripMenuItem1, Me.GetExcelTemplateToolStripMenuItem})
        Me.NewDatabaseToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_databasecreate
        Me.NewDatabaseToolStripMenuItem.Name = "NewDatabaseToolStripMenuItem"
        Me.NewDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewDatabaseToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.NewDatabaseToolStripMenuItem.Text = "&New Database"
        '
        'NewDatabaseToolStripMenuItem1
        '
        Me.NewDatabaseToolStripMenuItem1.Name = "NewDatabaseToolStripMenuItem1"
        Me.NewDatabaseToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.NewDatabaseToolStripMenuItem1.Text = "&New Database"
        '
        'NewDatabaseFromExcelToolStripMenuItem
        '
        Me.NewDatabaseFromExcelToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_fromexcel
        Me.NewDatabaseFromExcelToolStripMenuItem.Name = "NewDatabaseFromExcelToolStripMenuItem"
        Me.NewDatabaseFromExcelToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.NewDatabaseFromExcelToolStripMenuItem.Text = "New Database from &Excel"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(205, 6)
        '
        'GetExcelTemplateToolStripMenuItem
        '
        Me.GetExcelTemplateToolStripMenuItem.Name = "GetExcelTemplateToolStripMenuItem"
        Me.GetExcelTemplateToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GetExcelTemplateToolStripMenuItem.Text = "Get Excel &Template"
        '
        'FileNewSeperator
        '
        Me.FileNewSeperator.Name = "FileNewSeperator"
        Me.FileNewSeperator.Size = New System.Drawing.Size(221, 6)
        '
        'OpenDatabaseToolStripMenuItem
        '
        Me.OpenDatabaseToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_databaseopen
        Me.OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem"
        Me.OpenDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenDatabaseToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.OpenDatabaseToolStripMenuItem.Text = "&Open Database"
        '
        'OpenDatabaseAsToolStripMenuItem
        '
        Me.OpenDatabaseAsToolStripMenuItem.Name = "OpenDatabaseAsToolStripMenuItem"
        Me.OpenDatabaseAsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.OpenDatabaseAsToolStripMenuItem.Text = "Open Database &As"
        '
        'FileOpenSeperator
        '
        Me.FileOpenSeperator.Name = "FileOpenSeperator"
        Me.FileOpenSeperator.Size = New System.Drawing.Size(221, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_databasesave
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SaveToolStripMenuItem.Text = "&Save Database"
        '
        'SaveDatabaseAsToolStripMenuItem
        '
        Me.SaveDatabaseAsToolStripMenuItem.Name = "SaveDatabaseAsToolStripMenuItem"
        Me.SaveDatabaseAsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SaveDatabaseAsToolStripMenuItem.Text = "Save Databas&e As"
        '
        'FileSaveSeperator
        '
        Me.FileSaveSeperator.Name = "FileSaveSeperator"
        Me.FileSaveSeperator.Size = New System.Drawing.Size(221, 6)
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_refresh
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ReloadToolStripMenuItem.Text = "&Reload"
        '
        'FileReloadSeperator
        '
        Me.FileReloadSeperator.Name = "FileReloadSeperator"
        Me.FileReloadSeperator.Size = New System.Drawing.Size(221, 6)
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_preferences
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'WidthMenuItemFile
        '
        Me.WidthMenuItemFile.Name = "WidthMenuItemFile"
        Me.WidthMenuItemFile.Size = New System.Drawing.Size(224, 22)
        Me.WidthMenuItemFile.Text = "------------------------------"
        Me.WidthMenuItemFile.Visible = False
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabasePropertiesToolStripMenuItem, Me.WidthMenuItemEdit})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DatabasePropertiesToolStripMenuItem
        '
        Me.DatabasePropertiesToolStripMenuItem.Image = Global.TicketCheck.My.Resources.Resources.icn_properties
        Me.DatabasePropertiesToolStripMenuItem.Name = "DatabasePropertiesToolStripMenuItem"
        Me.DatabasePropertiesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.DatabasePropertiesToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DatabasePropertiesToolStripMenuItem.Text = "Database &Properties"
        '
        'WidthMenuItemEdit
        '
        Me.WidthMenuItemEdit.Name = "WidthMenuItemEdit"
        Me.WidthMenuItemEdit.Size = New System.Drawing.Size(224, 22)
        Me.WidthMenuItemEdit.Text = "------------------------------"
        Me.WidthMenuItemEdit.Visible = False
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.TicketsToolStripMenuItem.Text = "&Tickets"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem2, Me.DebugItemsToolStripMenuItem, Me.WidthMenuItemHelp})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Image = Global.TicketCheck.My.Resources.Resources.icn_help
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 6)
        '
        'DebugItemsToolStripMenuItem
        '
        Me.DebugItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetTCDXFileAssociationToolStripMenuItem, Me.ReviewTCDXFileToolStripMenuItem, Me.DecryptPasswordDialogRequestToolStripMenuItem})
        Me.DebugItemsToolStripMenuItem.Name = "DebugItemsToolStripMenuItem"
        Me.DebugItemsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DebugItemsToolStripMenuItem.Text = "Debug &Items"
        '
        'SetTCDXFileAssociationToolStripMenuItem
        '
        Me.SetTCDXFileAssociationToolStripMenuItem.Name = "SetTCDXFileAssociationToolStripMenuItem"
        Me.SetTCDXFileAssociationToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.SetTCDXFileAssociationToolStripMenuItem.Text = "Set .TCDX File Association"
        '
        'ReviewTCDXFileToolStripMenuItem
        '
        Me.ReviewTCDXFileToolStripMenuItem.Name = "ReviewTCDXFileToolStripMenuItem"
        Me.ReviewTCDXFileToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ReviewTCDXFileToolStripMenuItem.Text = "Review .TCDX File"
        '
        'DecryptPasswordDialogRequestToolStripMenuItem
        '
        Me.DecryptPasswordDialogRequestToolStripMenuItem.Name = "DecryptPasswordDialogRequestToolStripMenuItem"
        Me.DecryptPasswordDialogRequestToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.DecryptPasswordDialogRequestToolStripMenuItem.Text = "Decrypt Password Dialog Request"
        '
        'WidthMenuItemHelp
        '
        Me.WidthMenuItemHelp.Name = "WidthMenuItemHelp"
        Me.WidthMenuItemHelp.Size = New System.Drawing.Size(224, 22)
        Me.WidthMenuItemHelp.Text = "------------------------------"
        Me.WidthMenuItemHelp.Visible = False
        '
        'TitleMenuStrip
        '
        Me.TitleMenuStrip.BackColor = System.Drawing.Color.White
        Me.TitleMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.TicketsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TitleMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TitleMenuStrip.Name = "TitleMenuStrip"
        Me.TitleMenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.TitleMenuStrip.Size = New System.Drawing.Size(1264, 24)
        Me.TitleMenuStrip.TabIndex = 0
        Me.TitleMenuStrip.Text = "MenuStrip1"
        '
        'ToolMenu
        '
        Me.ToolMenu.BackColor = System.Drawing.Color.White
        Me.ToolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTicketButton, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.FilterTextBox})
        Me.ToolMenu.Location = New System.Drawing.Point(0, 24)
        Me.ToolMenu.Name = "ToolMenu"
        Me.ToolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolMenu.Size = New System.Drawing.Size(1264, 33)
        Me.ToolMenu.TabIndex = 4
        Me.ToolMenu.Text = "ToolStrip1"
        '
        'NewTicketButton
        '
        Me.NewTicketButton.AutoToolTip = False
        Me.NewTicketButton.Image = CType(resources.GetObject("NewTicketButton.Image"), System.Drawing.Image)
        Me.NewTicketButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewTicketButton.Margin = New System.Windows.Forms.Padding(14, 1, 0, 2)
        Me.NewTicketButton.Name = "NewTicketButton"
        Me.NewTicketButton.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.NewTicketButton.Size = New System.Drawing.Size(85, 30)
        Me.NewTicketButton.Text = "New Ticket"
        Me.NewTicketButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoToolTip = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripButton3.Size = New System.Drawing.Size(94, 30)
        Me.ToolStripButton3.Text = "Delete Ticket"
        Me.ToolStripButton3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoToolTip = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripButton2.Size = New System.Drawing.Size(124, 30)
        Me.ToolStripButton2.Text = "Ticket Information"
        Me.ToolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoToolTip = False
        Me.ToolStripButton4.Image = Global.TicketCheck.My.Resources.Resources.icn_fromexcel
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripButton4.Size = New System.Drawing.Size(122, 30)
        Me.ToolStripButton4.Text = "Import from Excel"
        Me.ToolStripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 30)
        Me.ToolStripLabel1.Text = "Filter:"
        '
        'FilterTextBox
        '
        Me.FilterTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FilterTextBox.Name = "FilterTextBox"
        Me.FilterTextBox.Size = New System.Drawing.Size(160, 33)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 57)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TicketListFront)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.DecryptOutput)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DecryptBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DecryptData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DecryptKey)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EncryptOutput)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EncryptBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EncryptData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EncryptKey)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.InstructionLabel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 624)
        Me.SplitContainer1.SplitterDistance = 900
        Me.SplitContainer1.TabIndex = 6
        '
        'TicketListFront
        '
        Me.TicketListFront.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TicketListFront.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TicketNumberColumn, Me.IssueTimeColumn, Me.StatusColumn, Me.ServiceColumn, Me.HolderColumn, Me.CompanyColumn, Me.SeatColumn, Me.LocationColumn, Me.ValidFromColumn, Me.ValidToColumn, Me.PriceColumn})
        Me.TicketListFront.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TicketListFront.FullRowSelect = True
        Me.TicketListFront.HideSelection = False
        Me.TicketListFront.Location = New System.Drawing.Point(0, 0)
        Me.TicketListFront.Name = "TicketListFront"
        Me.TicketListFront.Size = New System.Drawing.Size(896, 620)
        Me.TicketListFront.TabIndex = 7
        Me.TicketListFront.UseCompatibleStateImageBehavior = False
        Me.TicketListFront.View = System.Windows.Forms.View.Details
        '
        'TicketNumberColumn
        '
        Me.TicketNumberColumn.Text = "Number"
        Me.TicketNumberColumn.Width = 80
        '
        'IssueTimeColumn
        '
        Me.IssueTimeColumn.Text = "Issued at"
        Me.IssueTimeColumn.Width = 100
        '
        'StatusColumn
        '
        Me.StatusColumn.Text = "Status"
        Me.StatusColumn.Width = 75
        '
        'ServiceColumn
        '
        Me.ServiceColumn.Text = "Service"
        Me.ServiceColumn.Width = 75
        '
        'HolderColumn
        '
        Me.HolderColumn.Text = "Holder"
        Me.HolderColumn.Width = 120
        '
        'CompanyColumn
        '
        Me.CompanyColumn.Text = "Company"
        Me.CompanyColumn.Width = 120
        '
        'SeatColumn
        '
        Me.SeatColumn.Text = "Seat"
        Me.SeatColumn.Width = 75
        '
        'LocationColumn
        '
        Me.LocationColumn.Text = "Location"
        Me.LocationColumn.Width = 75
        '
        'ValidFromColumn
        '
        Me.ValidFromColumn.Text = "Valid from"
        Me.ValidFromColumn.Width = 100
        '
        'ValidToColumn
        '
        Me.ValidToColumn.Text = "Valid to"
        Me.ValidToColumn.Width = 100
        '
        'PriceColumn
        '
        Me.PriceColumn.Text = "Paid"
        Me.PriceColumn.Width = 75
        '
        'DecryptOutput
        '
        Me.DecryptOutput.Location = New System.Drawing.Point(89, 235)
        Me.DecryptOutput.Multiline = True
        Me.DecryptOutput.Name = "DecryptOutput"
        Me.DecryptOutput.Size = New System.Drawing.Size(192, 23)
        Me.DecryptOutput.TabIndex = 16
        '
        'DecryptBtn
        '
        Me.DecryptBtn.Location = New System.Drawing.Point(13, 235)
        Me.DecryptBtn.Name = "DecryptBtn"
        Me.DecryptBtn.Size = New System.Drawing.Size(75, 25)
        Me.DecryptBtn.TabIndex = 15
        Me.DecryptBtn.Text = "Decrypt"
        Me.DecryptBtn.UseVisualStyleBackColor = True
        '
        'DecryptData
        '
        Me.DecryptData.Location = New System.Drawing.Point(106, 207)
        Me.DecryptData.Multiline = True
        Me.DecryptData.Name = "DecryptData"
        Me.DecryptData.Size = New System.Drawing.Size(175, 23)
        Me.DecryptData.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Data to Decrypt:"
        '
        'DecryptKey
        '
        Me.DecryptKey.Location = New System.Drawing.Point(106, 179)
        Me.DecryptKey.Name = "DecryptKey"
        Me.DecryptKey.Size = New System.Drawing.Size(175, 23)
        Me.DecryptKey.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Encryption Key:"
        '
        'EncryptOutput
        '
        Me.EncryptOutput.Location = New System.Drawing.Point(89, 131)
        Me.EncryptOutput.Multiline = True
        Me.EncryptOutput.Name = "EncryptOutput"
        Me.EncryptOutput.Size = New System.Drawing.Size(192, 23)
        Me.EncryptOutput.TabIndex = 10
        '
        'EncryptBtn
        '
        Me.EncryptBtn.Location = New System.Drawing.Point(13, 131)
        Me.EncryptBtn.Name = "EncryptBtn"
        Me.EncryptBtn.Size = New System.Drawing.Size(75, 25)
        Me.EncryptBtn.TabIndex = 9
        Me.EncryptBtn.Text = "Encrypt"
        Me.EncryptBtn.UseVisualStyleBackColor = True
        '
        'EncryptData
        '
        Me.EncryptData.Location = New System.Drawing.Point(106, 103)
        Me.EncryptData.Multiline = True
        Me.EncryptData.Name = "EncryptData"
        Me.EncryptData.Size = New System.Drawing.Size(175, 23)
        Me.EncryptData.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Data to Encrypt:"
        '
        'EncryptKey
        '
        Me.EncryptKey.Location = New System.Drawing.Point(106, 75)
        Me.EncryptKey.Name = "EncryptKey"
        Me.EncryptKey.Size = New System.Drawing.Size(175, 23)
        Me.EncryptKey.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Encryption Key:"
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Location = New System.Drawing.Point(11, 47)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(165, 15)
        Me.TextLabel.TabIndex = 4
        Me.TextLabel.Text = "Debug the encryption system."
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.InstructionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InstructionLabel.Location = New System.Drawing.Point(9, 12)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(181, 20)
        Me.InstructionLabel.TabIndex = 3
        Me.InstructionLabel.Text = "String Encryption (Debug)"
        '
        'MainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolMenu)
        Me.Controls.Add(Me.BuildString)
        Me.Controls.Add(Me.TitleMenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.TitleMenuStrip
        Me.Name = "MainInterface"
        Me.Text = " TicketCheck"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitleMenuStrip.ResumeLayout(False)
        Me.TitleMenuStrip.PerformLayout()
        Me.ToolMenu.ResumeLayout(False)
        Me.ToolMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuildString As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDatabaseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewDatabaseFromExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents GetExcelTemplateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileNewSeperator As ToolStripSeparator
    Friend WithEvents OpenDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDatabaseAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileOpenSeperator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveDatabaseAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileSaveSeperator As ToolStripSeparator
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileReloadSeperator As ToolStripSeparator
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WidthMenuItemFile As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabasePropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WidthMenuItemEdit As ToolStripMenuItem
    Friend WithEvents TicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents DebugItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetTCDXFileAssociationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReviewTCDXFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WidthMenuItemHelp As ToolStripMenuItem
    Friend WithEvents TitleMenuStrip As MenuStrip
    Friend WithEvents ToolMenu As ToolStrip
    Friend WithEvents NewTicketButton As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents FilterTextBox As ToolStripTextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TicketListFront As ListView
    Friend WithEvents TicketNumberColumn As ColumnHeader
    Friend WithEvents IssueTimeColumn As ColumnHeader
    Friend WithEvents StatusColumn As ColumnHeader
    Friend WithEvents ServiceColumn As ColumnHeader
    Friend WithEvents HolderColumn As ColumnHeader
    Friend WithEvents CompanyColumn As ColumnHeader
    Friend WithEvents SeatColumn As ColumnHeader
    Friend WithEvents LocationColumn As ColumnHeader
    Friend WithEvents ValidFromColumn As ColumnHeader
    Friend WithEvents ValidToColumn As ColumnHeader
    Friend WithEvents PriceColumn As ColumnHeader
    Friend WithEvents TextLabel As Label
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents DecryptOutput As TextBox
    Friend WithEvents DecryptBtn As Button
    Friend WithEvents DecryptData As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DecryptKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EncryptOutput As TextBox
    Friend WithEvents EncryptBtn As Button
    Friend WithEvents EncryptData As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EncryptKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DecryptPasswordDialogRequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
