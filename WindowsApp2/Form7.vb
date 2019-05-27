Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text > 100000 Then
            MsgBox("Amount exceeds transaction limit. 
                    Enter a different amount")
        Else
            Form4.Show()
            Me.Close()
        End If
    End Sub
End Class