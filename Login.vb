Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each MECOntrol As Control In PanelSignIn.Controls
            AddHandler MECOntrol.MouseEnter, AddressOf MouseEnters
        Next
        For Each MECOntrol As Control In PanelSignIn.Controls
            AddHandler MECOntrol.MouseLeave, AddressOf MouseLeaves
        Next
    End Sub

    Private Sub MouseEnters(ByVal sender As Object, ByVal e As EventArgs) Handles PanelSignIn.MouseEnter
        PanelSignIn.Size = New Size(1800, 1080)
        PanelSignIn.BackColor = Color.FromArgb(208, 65, 75)

    End Sub


    Private Sub MouseLeaves(ByVal sender As Object, ByVal e As EventArgs) Handles PanelSignIn.MouseLeave

        PanelSignIn.BackColor = Color.FromArgb(203, 52, 64)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelSignIn.Paint

    End Sub


    Private Sub Button1_load(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try

            cm = New OleDb.OleDbCommand("SELECT count(*) FROM UserDatabase where sUsername=? and sPassword=?", cn)

            cm.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBoxUsername.Text
            cm.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBoxPassword.Text
            Dim count = Convert.ToInt32(cm.ExecuteScalar())

            If (count > 0) Then
                cm = New OleDb.OleDbCommand("SELECT sAccessLvl FROM UserDatabase where sUsername= '" &
                                            TextBoxUsername.Text & "' and sPassword = '" & TextBoxPassword.Text & "'", cn)
                accLvl = TextBoxUsername.Text
                Home.Show()
                    TextBoxUsername.Clear()
                    TextBoxPassword.Clear()

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid login credentials. Try again.")
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try


    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonLogin.VisibleChanged
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
    End Sub

    Private Sub Button2_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonClear.VisibleChanged
        ButtonClear.FlatStyle = FlatStyle.Flat
        ButtonClear.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button3_VisibleChanged(sender As Object, e As EventArgs) Handles ButtonExit.VisibleChanged
        ButtonExit.FlatStyle = FlatStyle.Flat
        ButtonExit.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonRegisterHere.Click
        Register.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBoxUsername.Click
        TextBoxUsername.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBoxPassword.Click
        TextBoxPassword.Text = ""
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBoxPassword.GotFocus
        TextBoxPassword.PasswordChar = "*"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelSignin.Click

    End Sub
End Class

