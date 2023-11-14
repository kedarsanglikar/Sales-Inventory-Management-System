Public Class DashboardForm


    Public q As String


    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        LoggedUserLabel.Text = My.Forms.LoginForm.TextBox1.Text + " - "
        LoggedTypeLabel.Text = My.Forms.LoginForm.ComboBox1.Text

        If LoggedTypeLabel.Text = "Employee" Then

            Registrationbtn.Enabled = False

        End If


    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Stockbtn_Click(sender As Object, e As EventArgs) Handles Stockbtn.Click
        AddStock.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        EditUser()
    End Sub

    Private Sub EditUser()


        q = "Insert into UserLoginAudit Values('" & My.Forms.LoginForm.LoginUser & "','" & My.Forms.LoginForm.loginPass & "','" & My.Forms.LoginForm.usertype & "' ,' OUT ' , '" & DateTime.Now & "')"
        Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(q))
            If (logincorrect) Then

            ' MsgBox("Logout successfully...", MsgBoxStyle.Information)
            LoginForm.Show()
            Me.Close()


        Else


        End If




    End Sub

    Private Sub Registrationbtn_Click(sender As Object, e As EventArgs) Handles Registrationbtn.Click

        Registration.Show()

    End Sub

    Private Sub Sellbtn_Click(sender As Object, e As EventArgs) Handles Sellbtn.Click
        SellItem.Show()

    End Sub
End Class