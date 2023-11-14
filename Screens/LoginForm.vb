Public Class LoginForm
    Public LoginUser As String
    Public loginPass As String
    Public usertype As String

    Public q As String


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (IsFormValid()) Then

            qr = "Select * from UserLogin where UserName='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "' and UserType='" & ComboBox1.Text & "' "
            ds = SearchData(qr)
            If (ds.Tables(0).Rows.Count > 0) Then
                LoginUser = TextBox1.Text
                loginPass = TextBox2.Text
                usertype = ComboBox1.Text
                EditUser()
                DashboardForm.Show()
                Me.Hide()

            Else
                MsgBox("Login error !!", MsgBoxStyle.Critical)
            End If

        End If

    End Sub

    Private Sub EditUser()

        If (IsFormValid()) Then
            q = "Insert into UserLoginAudit Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "' ,' IN ' , '" & DateTime.Now & "')"
            Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(q))
            If (logincorrect) Then

                MsgBox("Login successful", MsgBoxStyle.Information)


            Else
                MsgBox("Error login failed", MsgBoxStyle.Critical)
            End If

        End If


    End Sub

    Private Function IsFormValid() As Boolean
        If (TextBox1.Text.Trim() = String.Empty) Then
            MsgBox("User Name is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False


        End If

        If (TextBox2.Text.Trim() = String.Empty) Then
            MsgBox("Password is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False


        End If

        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("User type is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False


        End If





        Return True



    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        btnLogin.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class