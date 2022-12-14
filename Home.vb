Imports System.Reflection.Emit
Imports System.Security.Principal
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        MessageBox.Show("You are already at home tab")
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ButtonProfileMe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("You are already at home tab")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ButtonProfile.Click
        If accLvl = "admin" Then
            ProfileAdmin.Show()
        Else

            ProfileMe.Show()
        End If


        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonChatLobby.Click
        LobbySelect.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonChatLobbyChanged(sender As Object, e As EventArgs) Handles ButtonChatLobby.VisibleChanged
        ButtonChatLobby.FlatStyle = FlatStyle.Flat
        ButtonChatLobby.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonLeaderBoard.Click
        Leaderboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonSetting.Click
        Settings.Show()
        Me.Hide()
    End Sub



    Private Sub Button11_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonProfile.VisibleChanged
        ButtonProfile.FlatStyle = FlatStyle.Flat
        ButtonProfile.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button6_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonChatLobby.VisibleChanged
        ButtonChatLobby.FlatStyle = FlatStyle.Flat
        ButtonChatLobby.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button10_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonLeaderBoard.VisibleChanged
        ButtonLeaderBoard.FlatStyle = FlatStyle.Flat
        ButtonLeaderBoard.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button8_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonSetting.VisibleChanged
        ButtonSetting.FlatStyle = FlatStyle.Flat
        ButtonSetting.FlatAppearance.BorderColor = Color.Black
    End Sub


    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        About.Show()
        Me.Close()

    End Sub
End Class