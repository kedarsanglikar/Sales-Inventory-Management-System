Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 10

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label2.Text = Val(Label2.Text) + 1
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            LoginForm.Show()
            Me.Hide()

        End If
    End Sub
End Class