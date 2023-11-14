Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class Registration
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub createAccBtn_Click(sender As Object, e As EventArgs) Handles createAccBtn.Click

        Try

            If (IsFormValid()) Then
                qr = "Insert into UserLogin Values('" & fnameText.Text & "','" & LnameText.Text & "','" & userNameText.Text & "','" & passwordText.Text & "','" & userTypeComboText.Text & "')"
                Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
                If (logincorrect) Then

                    MsgBox("Account Created", MsgBoxStyle.Information)
                    clr()

                Else
                    MsgBox("Username already exists! Please enter another username")
                End If

            End If

        Catch ex As Exception



        End Try


    End Sub

    Private Sub clr()



        fnameText.Clear()
        LnameText.Clear()
        userNameText.Clear()
        passwordText.Clear()
        userTypeComboText.SelectedIndex = -1



    End Sub






    Private Function IsFormValid() As Boolean



        If (fnameText.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            fnameText.Clear()
            LnameText.Clear()
            userNameText.Clear()
            passwordText.Clear()

            Return False


        End If

        If (LnameText.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            fnameText.Clear()
            LnameText.Clear()
            userNameText.Clear()
            passwordText.Clear()

            Return False


        End If

        If (userNameText.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            fnameText.Clear()
            LnameText.Clear()
            userNameText.Clear()
            passwordText.Clear()

            Return False


        End If

        If (passwordText.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            fnameText.Clear()
            LnameText.Clear()
            userNameText.Clear()
            passwordText.Clear()

            Return False


        End If

        If (userTypeComboText.SelectedIndex = -1) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            fnameText.Clear()
            LnameText.Clear()
            userNameText.Clear()
            passwordText.Clear()

            Return False


        End If


        Dim nameRegex As New Regex("[^a-zA-Z]")

        If (nameRegex.IsMatch(fnameText.Text)) = True Then

            MsgBox("Please enter appropriate first name")
            fnameText.Clear()

            Return False

        End If

        If (nameRegex.IsMatch(LnameText.Text)) = True Then

            MsgBox("Please enter appropriate last name")
            LnameText.Clear()

            Return False

        End If



        Dim userRegex As New Regex("[a-zA-Z]{4}[@_\.]{1}[0-9]{3,4}")
        If (userRegex.IsMatch(userNameText.Text)) = False Then

            MsgBox("Username should have special characters like (@_.) and characters, numbers must be at least 3 length should be of more than 5 characters!")
            userNameText.Clear()


            Return False
        End If



        Dim passRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$")
        If (passRegex.IsMatch(passwordText.Text)) = False Then

            MsgBox("Password must contain minimum 6 characters, at least one uppercase letter, one lowercase letter and one number")
            passwordText.Clear()

            Return False

        End If



        'input validation code for registration module code



        'Dim usernameRegex As New Regex("^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9]){6,}[a-zA-Z0-9]$")
        'If (usernameRegex.IsMatch(userNameText.Text)) = False Then

        '    MsgBox("Username must contain capital and small characters, may contain numbers and special characters like(@_) and length maximum than 6 characters", MsgBoxStyle.Critical)

        '    'fnameText.Clear()
        '    'LnameText.Clear()
        '    'userNameText.Clear()
        '    'passwordText.Clear()

        '    Return False

        'End If



        'Dim passwordRegex As New Regex("^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$")
        'If (passwordRegex.IsMatch(passwordText.Text)) = False Then

        '    MsgBox("Password must contain capital and small characters, numbers and may contain special characters like and length must be greater than 6 characters", MsgBoxStyle.Critical)

        '    fnameText.Clear()
        '    LnameText.Clear()
        '    userNameText.Clear()
        '    passwordText.Clear()


        '    Return False

        'End If




        ' Dim firstNameRegex As New Regex("^1234567890~`!@#\$%\^&\*\(\)_-\+=/\*\|\]\[]{}''"":;><,\.\?/$")


        'If (fnameText.Text.Contains("abcdefghijklmnopqrstuvwxyz")) = False Then
        '    MsgBox("Please enter your correct name", MsgBoxStyle.Critical)

        '    'fnameText.Clear()
        '    'LnameText.Clear()
        '    'userNameText.Clear()
        '    'passwordText.Clear()


        '    Return False

        'End If



        'input validation code ends



        Return True



    End Function

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        DashboardForm.Show()

    End Sub
End Class