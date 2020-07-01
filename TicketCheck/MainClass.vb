Imports Microsoft.WindowsAPICodePack.Dialogs
Public Class MainClass

    Public Sub SaveFile(ByVal Path As String)
        Dim FileDataRaw As String
        FileDataRaw = "file-name=" & My.Settings.FileName
        FileDataRaw += vbNewLine & "file-author=" & My.Settings.FileAuthor
        FileDataRaw += vbNewLine & "file-created=" & My.Settings.FileCreated
        FileDataRaw += vbNewLine & "file-tickets=" & My.Settings.FileTickets

        MsgBox(My.Settings.FileCryptoKey)

        Dim WrapperService As New CryptograpghyService(My.Settings.FileCryptoKey)

        MsgBox(FileDataRaw)

        Dim WrittenData = "<tcdx>"
        Dim EncryptedData = WrapperService.EncryptData(FileDataRaw)

        WrittenData += (EncryptedData)
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\filedat.tcdx", WrittenData, False)
        MsgBox("Done!")

    End Sub

    Public Sub Init()
        My.Settings.SoftwareLog = "TicketCheck Version " & My.Resources.ReleaseVersion & "Starting..." & "$$" & "Log started " & DateTime.Now.ToShortTimeString & " " & DateTime.Now.ToShortDateString & "$$"
        MainInterface.BuildString.Visible = My.Settings.ShowBuildString
        MainInterface.BuildString.Text = My.Settings.BuildString
    End Sub

    Public Sub OpenFile(ByVal FilePath As String)
        Dim RawData As String = vbNull

        If My.Computer.FileSystem.ReadAllText(FilePath).StartsWith("<tcdx>") Then
            Try
                Dim Cryptography As New CryptograpghyService("tcdefault")
                RawData = Cryptography.DecryptData(My.Computer.FileSystem.ReadAllText(FilePath).Substring(6))
                My.Settings.FileCryptoKey = "tcdefault"
            Catch
RedoKey:
                Dim CryptoKey = "tcdefault"
                Dim KeyRequest As New EncryptionFileRequest
                If KeyRequest.ShowDialog() = DialogResult.OK Then
                    CryptoKey = KeyRequest.PasswordInputBox.Text
                    Try
                        Dim Cryptography As New CryptograpghyService(CryptoKey)
                        RawData = Cryptography.DecryptData(My.Computer.FileSystem.ReadAllText(FilePath).Substring(6))
                        My.Settings.FileCryptoKey = CryptoKey
                    Catch
                        Dim ErrorDialog As New TaskDialog
                        ErrorDialog.Caption = "Incorrect Password"
                        ErrorDialog.InstructionText = "Incorrect Password"
                        ErrorDialog.Text = "You have entered an incorrect password. Please try again."
                        ErrorDialog.Icon = TaskDialogStandardIcon.Error
                        ErrorDialog.Show()
                        GoTo RedoKey
                    End Try
                End If
            End Try
        Else
            Dim ErrorDialog As New TaskDialog
            ErrorDialog.Caption = "Invalid File"
            ErrorDialog.InstructionText = "Invalid File"
            ErrorDialog.Text = "The file you have chosen is not in a valid format. Please select a different file."
            ErrorDialog.Icon = TaskDialogStandardIcon.Error
            ErrorDialog.Show()
            Return
        End If

        LoadRawData(RawData, FilePath)
    End Sub

    Public Sub LoadFile(ByVal InPath As String)
        LoadRawData(My.Computer.FileSystem.ReadAllText(InPath), InPath)
    End Sub

    Public Sub LoadRawData(ByVal Input As String, ByVal Path As String)
        Dim Properties = Input.Split(vbNewLine)

        My.Settings.FileName = "Untitled"

        For Each FileProperty As String In Properties
            Try
                Dim ObjectProp = FileProperty.Split("=")
                My.Settings.FilePath = Path

                If ObjectProp(0).Contains("file-name") = True Then
                    My.Settings.FileName = ObjectProp(1)
                End If

                If ObjectProp(0).Contains("file-author") = True Then
                    My.Settings.FileAuthor = ObjectProp(1)
                End If

                If ObjectProp(0).Contains("file-created") = True Then
                    My.Settings.FileCreated = ObjectProp(1)
                End If

                If ObjectProp(0).Contains("file-tickets") = True Then
                    My.Settings.FileTickets = ObjectProp(1)
                End If
            Catch
                Dim ErrorDialog As New TaskDialog
                ErrorDialog.Caption = "Broken File"
                ErrorDialog.InstructionText = "Broken File"
                ErrorDialog.Text = "The file you have chosen is broken. Please select a different file."
                ErrorDialog.Icon = TaskDialogStandardIcon.Error
                ErrorDialog.Show()
                Return
            End Try
        Next

        MainInterface.Text = "TicketCheck - " & My.Settings.FileName & " (" & Path & ")"
        MainInterface.FilterTextBox.Clear()
        MainInterface.TicketListFront.Items.Clear()
        LoadTickets()

    End Sub

    Public Sub LoadTickets()
        Dim IndividalTickets As Array = My.Settings.FileTickets.Split("^")
        For Each Ticket As String In IndividalTickets
            Dim TicketProperties As Array = Ticket.Split("|")
            Dim NewListItem As New ListViewItem
            NewListItem.Text = TicketProperties(0) 'Ticket Numer
            NewListItem.SubItems.Add(TicketProperties(1))  'Issue Time
            NewListItem.SubItems.Add(TicketProperties(2))  'Status
            NewListItem.SubItems.Add(TicketProperties(3))  'Service
            NewListItem.SubItems.Add(TicketProperties(4))  'Holder
            NewListItem.SubItems.Add(TicketProperties(5))  'Company
            NewListItem.SubItems.Add(TicketProperties(6))  'Seat
            NewListItem.SubItems.Add(TicketProperties(7))  'Location
            NewListItem.SubItems.Add(TicketProperties(8))  'Valid From
            NewListItem.SubItems.Add(TicketProperties(9))  'Valid To
            NewListItem.SubItems.Add(TicketProperties(10)) 'Price
            MainInterface.TicketListFront.Items.Add(NewListItem)
        Next
    End Sub

    Public Sub ThrowError(ByVal ExceptionInformation As String)
        Log("EXCEPTION Code: " & ExceptionInformation)
        Dim ErrorDialog As New TaskDialog
        ErrorDialog.Caption = "Application Error"
        ErrorDialog.InstructionText = "Application Error"
        ErrorDialog.Text = "TicketCheck has run into an error. Continuing to use the software it's current state may cause data loss. Please save your work and restart the software."
        ErrorDialog.Icon = TaskDialogStandardIcon.Error
        ErrorDialog.DetailsExpanded = False
        ErrorDialog.DetailsCollapsedLabel = "Show More Information"
        ErrorDialog.DetailsExpandedLabel = "Show Less Information"
        ErrorDialog.DetailsExpandedText = ExceptionInformation
        ErrorDialog.ExpansionMode = TaskDialogExpandedDetailsLocation.ExpandFooter
        Dim SendFeedbackButton As New TaskDialogCommandLinkEx("ButtonSendFeedback", "Send Feedback", "Report this error and system log to TicketCheck.")
        Dim DontSendFeedback As New TaskDialogCommandLinkEx("ButtonDontSendFeedback", "Don't Send", Nothing)
        AddHandler DontSendFeedback.Click, Sub()
                                               MainInterface.Show()
                                               ErrorDialog.Close()
                                           End Sub
        AddHandler SendFeedbackButton.Click, Sub()
                                                 Dim EmailLaunchString As String = "mailto:reports@pbyw.net?subject=Application%20Crash%3A%20software-id&body=Please%20explain%20what%20you%20were%20doing%20when%20this%20crash%20occurred%3A%0D%0A%0D%0AWhat%20happened%20when%20the%20crash%20happened%3A%0D%0A%0D%0ASystem%20Log%3A%0D%0Aloghere"
                                                 EmailLaunchString = EmailLaunchString.Replace("software-id", My.Resources.SoftwareID)
                                                 EmailLaunchString = EmailLaunchString.Replace("loghere", My.Settings.SoftwareLog)
                                                 Process.Start(EmailLaunchString)
                                                 ErrorDialog.Close()
                                             End Sub
        ErrorDialog.Controls.Add(SendFeedbackButton)
        ErrorDialog.Controls.Add(DontSendFeedback)
        ErrorDialog.Show()
    End Sub

    Public Sub Log(ByVal LogData As String)
        My.Settings.SoftwareLog += (vbNewLine & DateTime.Now.ToShortTimeString & " " & DateTime.Now.ToShortDateString & " >> " & LogData & "$$")
    End Sub
End Class
