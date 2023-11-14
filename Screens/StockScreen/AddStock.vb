Imports System.Text.RegularExpressions

Public Class AddStock
    Private Sub StockAddbtn_Click(sender As Object, e As EventArgs) Handles StockAddbtn.Click

        If (IsFormValid()) Then
            qr = "Insert into tblProductInfo Values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & My.Forms.DashboardForm.LoggedUserLabel.Text & "','" & DateTime.Now & "')"
            Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
            If (logincorrect) Then
                BindGD()
                MsgBox("Stock added successfully..", MsgBoxStyle.Information)
                clr()

            Else
                MsgBox("Error record not saved", MsgBoxStyle.Critical)
            End If

        End If

    End Sub


    Private Function IsFormValid() As Boolean
        If (TextBox4.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox5.Clear()

            Return False


        End If

        If (TextBox2.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox5.Clear()

            Return False


        End If

        If (TextBox3.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox5.Clear()


            Return False


        End If

        If (TextBox5.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox5.Clear()

            Return False


        End If



        Dim prodNameRegex As New Regex("[^a-zA-Z\s]")

        If (prodNameRegex.IsMatch(TextBox2.Text)) = True Then

            MsgBox("Please enter appropriate product name")
            TextBox2.Clear()
            TextBox2.Focus()

            Return False

        End If



        Dim prodDescRegex As New Regex("[^a-zA-Z\s]")

        If (prodDescRegex.IsMatch(TextBox3.Text)) = True Then

            MsgBox("Please enter appropriate product description")
            TextBox3.Clear()
            TextBox3.Focus()

            Return False

        End If


        Dim priceRegex As New Regex("[^0-9]")

        If (priceRegex.IsMatch(TextBox4.Text)) = True Then


            MsgBox("Enter numeric data only! Do not enter spaces!")
            TextBox4.Clear()
            TextBox4.Focus()

            Return False

        End If



        Dim stockRegex As New Regex("[^0-9]")

        If (stockRegex.IsMatch(TextBox5.Text)) = True Then


            MsgBox("Enter numeric data only! Do not enter spaces!")
            TextBox5.Clear()
            TextBox5.Focus()



            Return False

        End If



        Return True



    End Function




    Public Sub BindGD()

        qr = "Select * from tblProductInfo"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        BindGD()
        StockAddbtn.Enabled = False
        StockUpdatebtn.Enabled = False
        StockDeletebtn.Enabled = False


        LoggedType.Text = My.Forms.LoginForm.ComboBox1.Text


        If LoggedType.Text = "Employee" Then

            Button1.Enabled = False
            DataGridView1.Enabled = False

            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False


        End If


    End Sub

    Public Sub clr()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            i = DataGridView1.CurrentRow.Index
            ' If (i > 0) Then
            Me.TextBox1.Text = DataGridView1.Item(0, i).Value
            Me.TextBox2.Text = DataGridView1.Item(1, i).Value
            Me.TextBox3.Text = DataGridView1.Item(2, i).Value
            Me.TextBox4.Text = DataGridView1.Item(3, i).Value
            Me.TextBox5.Text = DataGridView1.Item(4, i).Value

            StockUpdatebtn.Enabled = True
            StockDeletebtn.Enabled = True


            ' End If

        Catch ex As Exception

            MsgBox("Please select appropriate items!", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub StockUpdatebtn_Click(sender As Object, e As EventArgs) Handles StockUpdatebtn.Click



        If (IsFormValid()) Then
            qr = "Update tblProductInfo set ProductName='" & TextBox2.Text & "', ProductDesc='" & TextBox3.Text & "', ProductPrice='" & TextBox4.Text & "', ProStock='" & TextBox5.Text & "' where ProID='" & Convert.ToInt32(TextBox1.Text) & "' "
            Dim isupdateTrue As Boolean = Convert.ToBoolean(InsertData(qr))
            If (isupdateTrue) Then
                BindGD()
                MsgBox("Stock updated successfully..", MsgBoxStyle.Information)
                clr()

            Else
                MsgBox("Error record not updated", MsgBoxStyle.Critical)
            End If

        End If




    End Sub

    Private Sub StockCancelbtn_Click(sender As Object, e As EventArgs) Handles StockCancelbtn.Click


        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        clr()


        TextBox2.Focus()
        StockAddbtn.Enabled = True
        StockUpdatebtn.Enabled = False
        StockDeletebtn.Enabled = False

    End Sub

    Private Sub StockDeletebtn_Click(sender As Object, e As EventArgs) Handles StockDeletebtn.Click


        Dim result As Integer = MsgBox("Are you sure you want to delete the selected record ?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then



        ElseIf result = DialogResult.Yes Then


            If (IsFormValid2()) Then
                qr = "Delete from tblProductInfo where ProID='" & Convert.ToInt32(TextBox1.Text) & "' "
                Dim wantToDelete As Boolean = Convert.ToBoolean(InsertData(qr))
                If (wantToDelete) Then
                    BindGD()
                    MsgBox("Stock Deleted successfully..", MsgBoxStyle.Information)
                    clr()

                Else
                    MsgBox("Error record not deleted", MsgBoxStyle.Critical)
                End If

            End If



        End If




    End Sub

    Private Function IsFormValid2() As Boolean

        If (TextBox1.Text.Trim() = String.Empty) Then
            MsgBox("Product ID is required", MsgBoxStyle.Critical)


            Return False


        End If


        Return True

    End Function

    Private Sub StockSearchbtn_Click(sender As Object, e As EventArgs) Handles StockSearchbtn.Click
        qr = "Select * from tblProductInfo where ProductName='" & TextBox6.Text & "' "
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Critical)
        End If
    End Sub
End Class