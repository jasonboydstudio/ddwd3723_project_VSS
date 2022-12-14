Public Class LobbySelect
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLobby1.Click
        Chatroom1.Show()
        Me.Close()


    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonLobby1.VisibleChanged
        ButtonLobby1.FlatStyle = FlatStyle.Flat
        ButtonLobby1.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonLobby2.Click
        Lobby2.Show()
        Me.Close()


    End Sub

    Private Sub Button2_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonLobby2.VisibleChanged
        ButtonLobby2.FlatStyle = FlatStyle.Flat
        ButtonLobby2.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub LobbySelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hom As New Home
        hom.Show()
    End Sub
End Class