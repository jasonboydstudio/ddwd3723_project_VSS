Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Lobby1
    Private Sub Lobby1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_VisibleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonStartChat1.VisibleChanged
        ButtonStartChat1.FlatStyle = FlatStyle.Flat
        ButtonStartChat1.FlatAppearance.BorderColor = Color.Lime
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonStartChat1.Click




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_VisibleChanged(sender As Object, e As EventArgs) Handles Label1.VisibleChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBoxHomeLobby1.Click
        Dim hm As New Home
        hm.Show()
        Me.Close()

    End Sub
End Class