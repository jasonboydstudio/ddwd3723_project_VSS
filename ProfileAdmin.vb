Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Data.OleDb
Imports System.Data

Public Class ProfileAdmin
    Dim found As Boolean
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxDateofBirth_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxPhoneNo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxFullName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchProfileMe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub clearBtnMe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddInfoMe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxFullName_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxPhoneNo_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxDateofBirth_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchProfileMe_Click_1(sender As Object, e As EventArgs) Handles SearchProfileMe.Click
        Me.UserProfileBindingSource2.Filter = "sUsername='" & search_txtbx.Text & "'"

    End Sub

    Private Sub Add_BttonChanged(sender As Object, e As EventArgs) Handles Add_Btton.VisibleChanged
        Add_Btton.FlatStyle = FlatStyle.Flat
        Add_Btton.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub clearBtnMeChanged(sender As Object, e As EventArgs) Handles clearBtnMe.VisibleChanged
        SearchProfileMe.FlatStyle = FlatStyle.Flat
        SearchProfileMe.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub clearBtnMeMeChanged(sender As Object, e As EventArgs) Handles clearBtnMe.VisibleChanged
        SearchProfileMe.FlatStyle = FlatStyle.Flat
        SearchProfileMe.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ButtonHomeProfileMeChanged(sender As Object, e As EventArgs) Handles ButtonHomeProfileMe.VisibleChanged
        ButtonHomeProfileMe.FlatStyle = FlatStyle.Flat
        ButtonHomeProfileMe.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ButtonHomeProfileMe_Click(sender As Object, e As EventArgs) Handles ButtonHomeProfileMe.Click
        Dim hmo As New Home
        hmo.Show()
        Me.Close()
    End Sub

    Private Sub clearBtnMe_Click_1(sender As Object, e As EventArgs) Handles clearBtnMe.Click
        SUsernameTextBox.Clear()
        FullnameTextBox.Clear()
        SPasswordTextBox.Clear()
        SEmailTextBox.Clear()
        Phone_NoTextBox.Clear()


    End Sub

    Private Sub AddInfoMe_Click_1(sender As Object, e As EventArgs) Handles AddInfoMe.Click
        Me.Validate()
        Me.UserProfileBindingSource2.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.VSSdatabaseDataSet3)
    End Sub

    Private Sub UserProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ProfileMe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VSSdatabaseDataSet3.UserProfile' table. You can move, or remove it, as needed.
        Me.UserProfileTableAdapter2.Fill(Me.VSSdatabaseDataSet3.UserProfile)



    End Sub

    Private Sub SUsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SPasswordLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SPasswordTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEmailLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEmailTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Add_Btton_Click(sender As Object, e As EventArgs) Handles Add_Btton.Click
        Me.UserProfileBindingSource2.AddNew()
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub search_txtbx_TextChanged(sender As Object, e As EventArgs) Handles search_txtbx.TextChanged

    End Sub

    Private Sub SEmailLabel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEmailTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles SEmailTextBox.TextChanged

    End Sub

    Private Sub SUsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SUsernameTextBox.TextChanged

    End Sub
End Class