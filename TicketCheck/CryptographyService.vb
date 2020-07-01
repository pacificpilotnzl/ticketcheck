Imports System.Security.Cryptography
Public NotInheritable Class CryptograpghyService
    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(ByVal Key As String, ByVal Length As Integer) As Byte()
        Dim Sha1 As New SHA1CryptoServiceProvider
        Dim KeyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Key)
        Dim Hash() As Byte = Sha1.ComputeHash(KeyBytes)

        ReDim Preserve Hash(Length - 1)
        Return Hash
    End Function

    Sub New(ByVal key As String)
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8)
    End Sub

    Public Function EncryptData(ByVal PlainText As String) As String
        Dim PlainTextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(PlainText)
        Dim MS As New System.IO.MemoryStream
        Dim EncStream As New CryptoStream(MS, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        EncStream.Write(PlainTextBytes, 0, PlainTextBytes.Length)
        EncStream.FlushFinalBlock()

        Return Convert.ToBase64String(MS.ToArray)
    End Function

    Public Function DecryptData(ByVal EncryptedText As String) As String
        Dim EncryptBytes() As Byte = Convert.FromBase64String(EncryptedText)
        Dim MS As New System.IO.MemoryStream
        Dim DecStream As New CryptoStream(MS, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        DecStream.Write(EncryptBytes, 0, EncryptBytes.Length)
        DecStream.FlushFinalBlock()

        Return System.Text.Encoding.Unicode.GetString(MS.ToArray)
    End Function
End Class