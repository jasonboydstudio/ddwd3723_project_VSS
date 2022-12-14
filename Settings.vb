Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub GroupBox3_Click(sender As Object, e As EventArgs) Handles GroupBox3.Click


    End Sub

    Private Sub GroupBox4_Click(sender As Object, e As EventArgs) Handles GroupBox4.Click
        MessageBox.Show("This is the Latest Version")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim lgn As New Login
        lgn.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MsgBox("You are on the latest version")
        ' will implement in the future
    End Sub

    Private Sub homeBtnSet_Click(sender As Object, e As EventArgs) Handles homeBtnSet.Click
        Dim hmo As New Home
        hmo.Show()
        Me.Close()
    End Sub
End Class