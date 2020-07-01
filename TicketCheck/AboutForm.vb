Public Class AboutForm
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelVersion.Text = My.Resources.ReleaseVersion
        If My.Settings.EggB Then
            TextBoxDescription.Text = "I made this as a project for my L1 Digital Science class, so thanks to Mr Walker aka Craigy Waigey, Finn, Griffin, Tyrone, Cameron, Aston, Caleb, Matt, Luka, Travis, David, Ashan, Ben, and everyone else in Digital Science Daycare!! Sorry I forgot most of your names. If you found this easter egg on accident, how?"
            My.Settings.EggA = False
            My.Settings.EggB = False
        End If
    End Sub
    Private Sub LogoPictureBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LogoPictureBox.MouseDoubleClick
        If e.Button = MouseButtons.Right And My.Computer.Keyboard.AltKeyDown And My.Settings.EggA Then
            My.Settings.EggB = True
        End If
    End Sub
End Class
