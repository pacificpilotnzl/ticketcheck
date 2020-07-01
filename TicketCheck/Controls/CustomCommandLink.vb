Imports Microsoft.WindowsAPICodePack.Dialogs
Friend Class TaskDialogCommandLinkEx
    Inherits TaskDialogCommandLink

    Public Sub New(name As String, text As String, instruction As String)
        MyBase.New(name, text, instruction)
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String
        Dim noLabel = String.IsNullOrEmpty(Text)
        Dim noInstruction = String.IsNullOrEmpty(Instruction)

        If noLabel And noInstruction Then
            str = String.Empty
        ElseIf Not noLabel And noInstruction Then
            str = Text
        ElseIf noLabel And Not noInstruction Then
            str = Instruction
        Else
            str = Text & vbLf + Instruction
        End If

        Return str
    End Function
End Class