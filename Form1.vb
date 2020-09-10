Public Class frmShowMessage
    Private Sub ShowMassage(sender As Object, e As EventArgs) Handles btnMassage.Click
        lblMessage.Text = "Hello VB!"
    End Sub

    Private Sub ExitProc(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
