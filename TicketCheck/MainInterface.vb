Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Input
Imports Microsoft.WindowsAPICodePack.Dialogs
Public Class MainInterface

    Dim Mains As New MainClass

    Private Sub OpenDatabaseAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseAsToolStripMenuItem.Click
        If Keyboard.IsKeyDown(Key.G) And Keyboard.IsKeyDown(Key.D8) And Keyboard.IsKeyDown(Key.LeftCtrl) Then
            My.Settings.EggA = True
            Mains.Log("Egg Part One unlocked.")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Mains.ThrowError("User thrown")
    End Sub

    Private Sub listView1_DrawColumnHeader(ByVal sender As Object, ByVal e As DrawListViewColumnHeaderEventArgs)
        e.Graphics.FillRectangle(SystemBrushes.Menu, e.Bounds)
        e.Graphics.DrawRectangle(SystemPens.GradientInactiveCaption, New Rectangle(e.Bounds.X, 0, e.Bounds.Width, e.Bounds.Height))
        Dim text As String = TicketListFront.Columns(e.ColumnIndex).Text
        Dim cFlag As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter
        TextRenderer.DrawText(e.Graphics, text, TicketListFront.Font, e.Bounds, Color.Black, cFlag)
    End Sub

    Private Sub listView1_DrawItem(ByVal sender As Object, ByVal e As DrawListViewItemEventArgs)
        e.DrawDefault = True
    End Sub

    Private Sub listView1_DrawSubItem(ByVal sender As Object, ByVal e As DrawListViewSubItemEventArgs)
        e.DrawDefault = True
    End Sub

    Private Sub SetTCDXFileAssociationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetTCDXFileAssociationToolStripMenuItem.Click
        Try
            If Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(".TCDX\shell\open\command", True) Is Nothing Then
                Dim icotouse As String = "C:\Program Files (x86)\PBYW\TicketCheck\res\tcdx.ico"
                My.Computer.Registry.ClassesRoot.CreateSubKey(".TCDX").SetValue("", "TCDX", Microsoft.Win32.RegistryValueKind.String)
                My.Computer.Registry.ClassesRoot.CreateSubKey("TCDX\shell\open\command").SetValue("", "C:\Program Files (x86)\PBYW\TicketCheck\tc32.exe" & " ""&#37;l"" ", Microsoft.Win32.RegistryValueKind.String)
                My.Computer.Registry.ClassesRoot.CreateSubKey("TCDX\DefaultIcon").SetValue("", icotouse)

                For Each proc As Process In Process.GetProcessesByName("explorer")

                    proc.Kill()

                    Do Until proc.HasExited
                        Application.DoEvents()
                    Loop
                Next

                MsgBox("All set!")
            Else
                MsgBox("File Preferences already exist!")
            End If
        Catch
            Dim ErrorDialog As New TaskDialog
            ErrorDialog.Caption = "Administrator Required"
            ErrorDialog.InstructionText = "Administrator Required"
            ErrorDialog.Text = "The application cannot proceed with the requested task. Elevated permissions are required, so please use the 'Restart' button below, or click 'Cancel' to stop this task."
            ErrorDialog.Icon = TaskDialogStandardIcon.Shield
            Dim RestartButton As New TaskDialogButton("customButtonRestart", "&Restart")
            RestartButton.UseElevationIcon = True
            Dim CancelButton As New TaskDialogButton("customButtonRestart", "Cancel")
            AddHandler RestartButton.Click, Sub()
                                                ErrorDialog.Close()
                                                Me.Hide()

                                                Dim procStartInfo As New ProcessStartInfo
                                                Dim procExecuting As New Process

                                                With procStartInfo
                                                    .UseShellExecute = True
                                                    .FileName = Application.ExecutablePath
                                                    .WindowStyle = ProcessWindowStyle.Normal
                                                    .Verb = "runas" 'add this to prompt for elevation
                                                End With

                                                Try
                                                    procExecuting = Process.Start(procStartInfo)
                                                Catch
                                                    End
                                                End Try


                                                Application.Exit()
                                            End Sub
            AddHandler CancelButton.Click, Sub()
                                               ErrorDialog.Close()
                                           End Sub

            ErrorDialog.Controls.Add(RestartButton)
            ErrorDialog.Controls.Add(CancelButton)
            ErrorDialog.Show()
        End Try
    End Sub

    Private Sub ReviewTCDXFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewTCDXFileToolStripMenuItem.Click
        Dim OpenDialog As New OpenFileDialog
        OpenDialog.Title = "Open File"
        OpenDialog.Filter = "TicketCheck Database|*.tcdx"
        OpenDialog.FileName = ""
        OpenDialog.ShowDialog()
        Try
            MsgBox(My.Computer.FileSystem.ReadAllText(OpenDialog.FileName))
        Catch
        End Try
    End Sub

    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mains.Init()
    End Sub

    Private Sub DatabasePropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabasePropertiesToolStripMenuItem.Click
        DatabasePropertiesWindow.Show()
    End Sub

    Private Sub OpenDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseToolStripMenuItem.Click
        Dim OpenDialog As New OpenFileDialog
        OpenDialog.Title = "Open File"
        OpenDialog.Filter = "TicketCheck Database|*.tcdx"
        OpenDialog.FileName = ""
        OpenDialog.ShowDialog()
        Try
            Mains.OpenFile(OpenDialog.FileName)
        Catch
        End Try
    End Sub

    Dim StorageListView As New ListView

    Private Sub FilterTextBox_TextChanged(sender As Object, e As EventArgs) Handles FilterTextBox.TextChanged
        FilterList(False)
    End Sub

    Public Sub FilterList(ByVal ResetIt As Boolean)
        If ResetIt Then
            FilterTextBox.Clear()
            For Each ReAddItem As ListViewItem In StorageListView.Items
                ReAddItem.Remove()
                TicketListFront.Items.Add(ReAddItem)
            Next

            Try
                For Each ListItem As ListViewItem In TicketListFront.Items
                    If ListItem.Text.ToLower.Contains(FilterTextBox.Text.ToLower) Or ListItem.SubItems(4).Text.ToLower.Contains(FilterTextBox.Text.ToLower) Then
                    Else
                        ListItem.Remove()
                        StorageListView.Items.Add(ListItem)
                    End If
                Next
            Catch ex As Exception
                For Each ListItem As ListViewItem In TicketListFront.Items
                    If ListItem.Text.ToLower.Contains(FilterTextBox.Text.ToLower) Then
                    Else
                        ListItem.Remove()
                        StorageListView.Items.Add(ListItem)
                    End If
                Next
            End Try
        Else
            For Each ReAddItem As ListViewItem In StorageListView.Items
                ReAddItem.Remove()
                TicketListFront.Items.Add(ReAddItem)
            Next

            Try
                For Each ListItem As ListViewItem In TicketListFront.Items
                    If ListItem.Text.ToLower.Contains(FilterTextBox.Text.ToLower) Or ListItem.SubItems(4).Text.ToLower.Contains(FilterTextBox.Text.ToLower) Then
                    Else
                        ListItem.Remove()
                        StorageListView.Items.Add(ListItem)
                    End If
                Next
            Catch ex As Exception
                For Each ListItem As ListViewItem In TicketListFront.Items
                    If ListItem.Text.ToLower.Contains(FilterTextBox.Text.ToLower) Then
                    Else
                        ListItem.Remove()
                        StorageListView.Items.Add(ListItem)
                    End If
                Next
            End Try
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        FilterList(True)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        EncryptionFileRequest.Show()
    End Sub

    Private Sub DecryptPasswordDialogRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecryptPasswordDialogRequestToolStripMenuItem.Click
        Dim PasswordDialog As New EncryptionFileRequest
        If PasswordDialog.ShowDialog() = DialogResult.OK Then
            MsgBox(PasswordDialog.PasswordInputBox.Text)
        Else
            MsgBox("Cancelled loading file.")
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Mains.SaveFile("")
    End Sub

    Private Sub CryptoTestingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CryptoTestingToolStripMenuItem.Click
        EncryptionTestForm.Show()
    End Sub

    Private Sub NewTicketButton_Click(sender As Object, e As EventArgs) Handles NewTicketButton.Click
        NewTicket.Show()
    End Sub
End Class