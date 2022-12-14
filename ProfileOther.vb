Public Class ProfileOther
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim ldb As New Leaderboard
        ldb.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hmo As New Home
        hmo.Show()
        Me.Close()
    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles Button1.VisibleChanged
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderColor = Color.Lime
    End Sub

    Private Sub ButtonBack_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonBack.VisibleChanged
        ButtonBack.FlatStyle = FlatStyle.Flat
        ButtonBack.FlatAppearance.BorderColor = Color.Lime
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = "********"
    End Sub
End Class