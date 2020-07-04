Public Class EncryptionTestForm
    Private Sub EncryptBtn_Click(sender As Object, e As EventArgs) Handles EncryptBtn.Click
        Dim WrapperService As New CryptograpghyService(EncryptKey.Text)
        EncryptOutput.Text = WrapperService.EncryptData(EncryptData.Text)
    End Sub

    Private Sub EncryptionTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        Try
            Dim WrapperService As New CryptograpghyService(DecryptKey.Text)
            DecryptOutput.Text = WrapperService.DecryptData(DecryptData.Text)
        Catch ex As Exception
            DecryptOutput.Text = "Incorrect Decryption Key"
        End Try
    End Sub
End Class