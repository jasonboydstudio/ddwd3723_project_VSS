Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Data.OleDb
Imports System.Data
Public Class Chatroom1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Chatroom1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ChatsDataSet.Chats' table. You can move, or remove it, as needed.
        Me.ChatsTableAdapter.Fill(Me.ChatsDataSet.Chats)

    End Sub

    Private Sub ChatfieldTextBox_TextChanged(sender As Object, e As EventArgs) Handles ChatfieldTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.ChatsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ChatsDataSet)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ChatsBindingSource.AddNew()
    End Sub

    Private Sub GroupBoxChatRoom1_Enter(sender As Object, e As EventArgs) Handles GroupBoxChatRoom1.Enter

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hm As New Home
        hm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_VisibleChanged(sender As Object, e As EventArgs) Handles Button3.VisibleChanged
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles clock.Tick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class