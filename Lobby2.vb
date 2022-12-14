Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Lobby2
    Private Sub Lobby2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonStartChat2.Click
        Chatroom2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBoxHomeLobby2.Click
        Dim hm As New Home
        hm.Show()
        Me.Close()

    End Sub

    Private Sub ButtonStartChat2_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonStartChat2.VisibleChanged
        ButtonStartChat2.FlatStyle = FlatStyle.Flat
        ButtonStartChat2.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub PictureBoxPlayerIcon1_Click(sender As Object, e As EventArgs) Handles PictureBoxPlayerIcon1.Click

    End Sub
End Class