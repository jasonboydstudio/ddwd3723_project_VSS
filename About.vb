Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class About
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonHomeAbt.VisibleChanged
        ButtonHomeAbt.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        Dim hm As New Home
        hm.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class