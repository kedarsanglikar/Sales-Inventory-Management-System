Imports System.Data
Imports System.Data.SqlClient

Module DbSqlServer
    Public con As New SqlConnection("Data Source=DESKTOP-1GNNH8U;Initial Catalog=SalesInventoryManagementSystem;Integrated Security=True")
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public qr As String
    Public i As Integer

    Public Function SearchData(ByVal qr As String) As DataSet

        da = New SqlDataAdapter(qr, con)
            ds = New DataSet
            da.Fill(ds)
            Return ds


    End Function

    Public Function InsertData(ByVal qr As String) As Integer

        Try

            cmd = New SqlCommand(qr, con)
            con.Open()
            i = cmd.ExecuteNonQuery()
            con.Close()
            Return i

        Catch ex As Exception

        End Try



    End Function
End Module
