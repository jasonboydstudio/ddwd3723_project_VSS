Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports VSS2.login2DataSetTableAdapters
Imports System.Data.SqlClient

Public Class Register


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRegister2.Click

        Try

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO UserDatabase (sEmail, sUsername, sPassword) VALUES (@sEmail,@sUsername,@sPassword)"


                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@sEmail", System.Data.OleDb.OleDbType.VarChar, 255, Me.TextBoxEmail.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@sUsername", System.Data.OleDb.OleDbType.VarChar, 255, Me.TextBoxRegisterUsername.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@sPassword", System.Data.OleDb.OleDbType.VarChar, 255, Me.TextBoxRegisterPassword.Text))


                cm.Parameters("@sEmail").Value = Me.TextBoxEmail.Text
                cm.Parameters("@sUsername").Value = Me.TextBoxRegisterUsername.Text
                cm.Parameters("@sPassword").Value = Me.TextBoxRegisterPassword.Text


                cm.ExecuteNonQuery()
                MsgBox("Account registered.", MsgBoxStyle.Information)

                Exit Sub
            End With
        Catch
        End Try

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connection()

        For Each MECOntrol As Control In PanelRegister.Controls
            AddHandler MECOntrol.MouseEnter, AddressOf MouseEnters
        Next
        For Each MECOntrol As Control In PanelRegister.Controls
            AddHandler MECOntrol.MouseLeave, AddressOf MouseLeaves
        Next

    End Sub

    Private Sub MouseEnters(ByVal sender As Object, ByVal e As EventArgs) Handles PanelRegister.MouseEnter

        PanelRegister.BackColor = Color.FromArgb(208, 65, 75)

    End Sub


    Private Sub MouseLeaves(ByVal sender As Object, ByVal e As EventArgs) Handles PanelRegister.MouseLeave

        PanelRegister.BackColor = Color.FromArgb(203, 52, 64)

    End Sub
    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonRegister2.VisibleChanged
        ButtonRegister2.FlatStyle = FlatStyle.Flat
        ButtonRegister2.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonClear2.Click
        TextBoxEmail.Text = ""
        TextBoxRegisterUsername.Text = ""
        TextBoxRegisterPassword.Text = ""
    End Sub

    Private Sub Button2_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonClear2.VisibleChanged
        ButtonClear2.FlatStyle = FlatStyle.Flat
        ButtonClear2.FlatAppearance.BorderColor = Color.Black

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBoxEmail.Click
        TextBoxEmail.Text = ""
    End Sub


    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBoxRegisterPassword.Click
        TextBoxRegisterPassword.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBoxRegisterUsername.Click
        TextBoxRegisterUsername.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonContinue.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button3_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonContinue.VisibleChanged
        ButtonContinue.FlatStyle = FlatStyle.Flat
        ButtonContinue.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBoxRegisterPassword.GotFocus
        TextBoxRegisterPassword.PasswordChar = "*"
    End Sub

End Class