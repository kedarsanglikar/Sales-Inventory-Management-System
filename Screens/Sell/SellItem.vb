Public Class SellItem
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        DashboardForm.Show()
        Me.Hide()

    End Sub

    Private Sub SellItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        BindGD()

        ProIdTextBox.Enabled = False
        ProNameTextBox.Enabled = False
        ProDescTextBox.Enabled = False
        PriceTextBox.Enabled = False
        StockTextBox.Enabled = False
        totalPriceTextBox.Enabled = False

        printBillBtn.Enabled = False
        printPreviewBtn.Enabled = False


        changeTextBox.Enabled = False



    End Sub

    Public Sub BindGD()

        qr = "Select * from tblProductInfo"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then

            DataGridView1.DataSource = ds.Tables(0)

        Else

            MsgBox("Record not found", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click

        qr = "Select * from tblProductInfo where ProductName='" & CategoryTextBox.Text & "'  and ProductDesc='" & BrandNameTextBox.Text & "'  "
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)

            i = DataGridView1.CurrentRow.Index

            Me.ProIdTextBox.Text = DataGridView1.Item(0, i).Value
            Me.ProNameTextBox.Text = DataGridView1.Item(1, i).Value
            Me.ProDescTextBox.Text = DataGridView1.Item(2, i).Value
            Me.PriceTextBox.Text = DataGridView1.Item(3, i).Value
            Me.StockTextBox.Text = DataGridView1.Item(4, i).Value




        Else
            MsgBox("Record Not Found", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            i = DataGridView1.CurrentRow.Index

            Me.ProIdTextBox.Text = DataGridView1.Item(0, i).Value
            Me.ProNameTextBox.Text = DataGridView1.Item(1, i).Value
            Me.ProDescTextBox.Text = DataGridView1.Item(2, i).Value
            Me.PriceTextBox.Text = DataGridView1.Item(3, i).Value
            Me.StockTextBox.Text = DataGridView1.Item(4, i).Value
        Catch ex As Exception

            MsgBox("Please select appropriate items!", MsgBoxStyle.Critical)


        End Try

    End Sub

    Private Sub receiveCashTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles receiveCashTextBox.KeyUp

        Dim tot, rcvCash, num As Integer

        tot = Val(totalPriceTextBox.Text)

        rcvCash = Val(receiveCashTextBox.Text)

        If rcvCash = tot Then

            changeTextBox.Text = 0

            sellBtn.Enabled = True

        ElseIf rcvCash > tot Then

            num = rcvCash - tot
            changeTextBox.Text = num.ToString()

            sellBtn.Enabled = False


        ElseIf rcvCash < tot Then

            num = rcvCash - tot

            changeTextBox.Text = num.ToString()
            sellBtn.Enabled = False

        End If


    End Sub

    Private Sub unitTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles unitTextBox.KeyUp


        Dim unit, prodPrice, totPrice As Integer
        unit = Val(unitTextBox.Text)
        prodPrice = Val(PriceTextBox.Text)


        totPrice = prodPrice * unit
        totalPriceTextBox.Text = totPrice.ToString()


    End Sub




    Private Sub sellBtn_Click(sender As Object, e As EventArgs) Handles sellBtn.Click


        Dim unit As Integer = Val(unitTextBox.Text)
        Dim stock As Integer = Val(StockTextBox.Text)



        If unit > stock Then

            MsgBox("Please enter valid quantity!", MsgBoxStyle.Critical)
            unitTextBox.Clear()
            receiveCashTextBox.Clear()



        Else






            If (IsFormValid()) Then


                qr = "Insert into ProSale Values('" & Convert.ToInt32(ProIdTextBox.Text) & "','" & ProNameTextBox.Text & "','" & ProDescTextBox.Text & "','" & totalPriceTextBox.Text & "','" & PriceTextBox.Text & "','" & unitTextBox.Text & "','" & DateTime.Now & "','" & My.Forms.DashboardForm.LoggedUserLabel.Text + My.Forms.DashboardForm.LoggedTypeLabel.Text & "')"
                Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
                If (logincorrect) Then
                    '   BindGD()
                    MsgBox("Product sold successfully..", MsgBoxStyle.Information)
                    updateStock()

                    printBillBtn.Enabled = True
                    printPreviewBtn.Enabled = True

                Else
                    MsgBox("Error stock not updated", MsgBoxStyle.Critical)
                End If

            End If



        End If



        ' If (IsFormValid()) Then

        ' End If


    End Sub



    Public Sub updateStock()
        If (IsFormValid()) Then

            Dim a As String
            a = Val(StockTextBox.Text) - Val(unitTextBox.Text)

            qr = "Update tblProductInfo set  ProStock='" & a & "' where ProID='" & Convert.ToInt32(ProIdTextBox.Text) & "' "
            Dim isupdateTrue As Boolean = Convert.ToBoolean(InsertData(qr))
            If (isupdateTrue) Then
                BindGD()
                MsgBox("Stock updated successfully..", MsgBoxStyle.Information)


            Else
                MsgBox("Error record not updated", MsgBoxStyle.Critical)
            End If

        End If
    End Sub




    Private Function IsFormValid() As Boolean



        If (unitTextBox.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            unitTextBox.Clear()
            totalPriceTextBox.Clear()
            receiveCashTextBox.Clear()
            'TextBox5.Clear()

            Return False


        End If

        If (totalPriceTextBox.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            unitTextBox.Clear()
            totalPriceTextBox.Clear()
            receiveCashTextBox.Clear()
            ''TextBox5.Clear()

            Return False


        End If

        If (receiveCashTextBox.Text.Trim() = String.Empty) Then
            MsgBox("All Details are required", MsgBoxStyle.Critical)
            unitTextBox.Clear()
            totalPriceTextBox.Clear()
            receiveCashTextBox.Clear()
            '' TextBox5.Clear()


            Return False


        End If



        Return True



    End Function


    Public Sub clear()



        CategoryTextBox.Clear()
        BrandNameTextBox.Clear()


        ProNameTextBox.Clear()
        ProDescTextBox.Clear()
        PriceTextBox.Clear()
        StockTextBox.Clear()

        unitTextBox.Clear()
        totalPriceTextBox.Clear()
        receiveCashTextBox.Clear()
        changeTextBox.Clear()



    End Sub

    Private Sub printPreviewBtn_Click(sender As Object, e As EventArgs) Handles printPreviewBtn.Click


        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()




    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        e.Graphics.DrawString("WELCOME TO SALES INVENTORY MANAGEMENT SYSTEM", New Font("Arial", 20, FontStyle.Bold), Brushes.Red, New Point(20, 10))

        e.Graphics.DrawString("Satara District General Stores - 415002", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, New Point(250, 50))

        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, New Point(50, 150))

        e.Graphics.DrawString("Date : " + DateTime.Now, New Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, New Point(50, 200))

        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, New Point(50, 250))


        e.Graphics.DrawString("Product Name : " + ProNameTextBox.Text, New Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, New Point(50, 350))
        e.Graphics.DrawString("Product Description : " + ProDescTextBox.Text, New Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, New Point(50, 400))
        e.Graphics.DrawString("Per product Price : Rs. " + PriceTextBox.Text + "/-", New Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, New Point(50, 450))
        e.Graphics.DrawString("Quantity : " + unitTextBox.Text, New Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, New Point(50, 500))
        e.Graphics.DrawString("Total Amount : Rs. " + totalPriceTextBox.Text + "/-", New Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, New Point(50, 550))



        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, New Point(50, 650))



    End Sub

    Private Sub printBillBtn_Click(sender As Object, e As EventArgs) Handles printBillBtn.Click


        PrintDocument1.Print()


    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click


        clear()


    End Sub
End Class