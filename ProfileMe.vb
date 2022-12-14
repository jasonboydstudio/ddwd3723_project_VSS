Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Data.OleDb
Imports System.Data
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class ProfileMe
    Private Sub ProfileMe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With cm
                cm = New OleDb.OleDbCommand("SELECT sUsername, sPassword, sEmail, Fullname, Date of Birth, Date of Birth FROM UserProfile where sUsername =Dragon", cn)
                dr = .ExecuteReader
            End With
            While dr.Read()
                usernameBox.Text = dr(1).ToString()
                pwBox.Text = dr(2).ToString()
                emailBox.Text = dr(3).ToString()
                fnameBox.Text = dr(4).ToString()
                dobBox.Text = dr(5).ToString()
                phoneBox.Text = dr(6).ToString()
            End While

        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

    End Sub
    Private Sub ButtonHomeProfileMe_Click(sender As Object, e As EventArgs) Handles ButtonHomeProfileMe.Click
        Dim hmo As New Home
        hmo.Show()
        Me.Close()
    End Sub

    Private Sub usernameBox_TextChanged(sender As Object, e As EventArgs) Handles usernameBox.TextChanged

    End Sub

    Private Sub emailBox_TextChanged(sender As Object, e As EventArgs) Handles emailBox.TextChanged

    End Sub

    Private Sub pwBox_TextChanged(sender As Object, e As EventArgs) Handles pwBox.TextChanged

    End Sub

    Private Sub fnameBox_TextChanged(sender As Object, e As EventArgs) Handles fnameBox.TextChanged

    End Sub

    Private Sub dobBox_TextChanged(sender As Object, e As EventArgs) Handles dobBox.TextChanged

    End Sub

    Private Sub phoneBox_TextChanged(sender As Object, e As EventArgs) Handles phoneBox.TextChanged

    End Sub

    Private Sub UserProfileBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles UserProfileBindingSource1.CurrentChanged

    End Sub
End Class