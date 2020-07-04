Public Class NewTicket
    Private Sub NewTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoFill()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Public Sub AutoFill()
        Dim s As String = "0123456789"
        Dim sb As New System.Text.StringBuilder
        Dim r As New Random
        Dim cnt As Integer = r.Next(8, 8)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next

        TicketNoBox.Text = sb.ToString

    End Sub

    Private Sub ProceedButton_Click(sender As Object, e As EventArgs) Handles ProceedButton.Click
        MainInterface.FilterList(True)
        Dim NewListItem As New ListViewItem '
        Dim StringAppend = ""

        'NewListItem.Text = TicketProperties(0) 'Ticket Numer
        'NewListItem.SubItems.Add(TicketProperties(1)) 'Issue Time
        'NewListItem.SubItems.Add(TicketProperties(2)) 'Status
        'NewListItem.SubItems.Add(TicketProperties(3)) 'Service
        'NewListItem.SubItems.Add(TicketProperties(4)) 'Holder
        'NewListItem.SubItems.Add(TicketProperties(5)) 'Company
        'NewListItem.SubItems.Add(TicketProperties(6)) 'Seat
        'NewListItem.SubItems.Add(TicketProperties(7)) 'Location
        'NewListItem.SubItems.Add(TicketProperties(8)) 'Price

        NewListItem.Text = TicketNoBox.Text
        StringAppend += TicketNoBox.Text + "|"
        NewListItem.SubItems.Add(DateTime.Now.ToString("dd-MM-yy@HH:mm"))
        StringAppend += DateTime.Now.ToString("dd-MM-yy@HH:mm|")
        NewListItem.SubItems.Add("Issued")
        StringAppend += "Issued|"
        NewListItem.SubItems.Add(ServiceBox.Text)
        StringAppend += ServiceBox.Text + "|"
        NewListItem.SubItems.Add(HolderBox.Text)
        StringAppend += HolderBox.Text + "|"
        NewListItem.SubItems.Add(CompanyBox.Text)
        StringAppend += CompanyBox.Text + "|"
        NewListItem.SubItems.Add(SeatBox.Text)
        StringAppend += SeatBox.Text + "|"
        NewListItem.SubItems.Add(LocationBox.Text)
        StringAppend += LocationBox.Text + "|"
        NewListItem.SubItems.Add(PaidBox.Text)
        StringAppend += PaidBox.Text
        StringAppend += "^"

        My.Settings.FileTickets += StringAppend

        MainInterface.TicketListFront.Items.Add(NewListItem)
    End Sub
End Class