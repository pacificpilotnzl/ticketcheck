Imports Microsoft.WindowsAPICodePack.Dialogs
Public Class DatabasePropertiesWindow
    Private Sub CancelChangesButton_Click(sender As Object, e As EventArgs) Handles CancelChangesButton.Click
        Me.Close()
    End Sub

    Private Sub DatabasePropertiesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AuthorTextBox.Text = My.Settings.FileAuthor
        NameTextBox.Text = My.Settings.FileName
        CreatedTextBox.Text = My.Settings.FileCreated

        If Not My.Settings.FileCryptoKey = "tcdefault" Then
            TextBox2.Text = My.Settings.FileCryptoKey
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        My.Settings.FileAuthor = AuthorTextBox.Text
        My.Settings.FileName = NameTextBox.Text
        If CheckBox1.Checked Then
            If TextBox2.Text = "" Then
                Dim ErrorDialog As New TaskDialog
                ErrorDialog.Caption = "File Encryption"
                ErrorDialog.InstructionText = "File Encryption"
                ErrorDialog.Text = "You must set a value for the password."
                ErrorDialog.Icon = TaskDialogStandardIcon.Error
                ErrorDialog.Show()
                Return
            End If
            My.Settings.FileCryptoKey = TextBox2.Text
        Else
            My.Settings.FileCryptoKey = "tcdefault"
        End If

        Me.Close()
    End Sub

    Private Sub AuthorTextBox_TextChanged(sender As Object, e As EventArgs) Handles AuthorTextBox.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.Enabled = True
        Else
            TextBox2.Text = ""
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            Dim ErrorDialog As New TaskDialog
            ErrorDialog.Caption = "File Encryption"
            ErrorDialog.InstructionText = "File Encryption"
            ErrorDialog.Text = "When file encryption is enabled, there is no way to recover the data without the password. Make sure to keep your password in a safe place."
            ErrorDialog.Icon = TaskDialogStandardIcon.Warning
            ErrorDialog.Show()
        End If
    End Sub
End Class