Public Class Form6
    Dim x, y, z As Integer
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = TextBox1.Text
        y = TextBox2.Text
        z = TextBox3.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.PasswordChar = "*"
        TextBox2.PasswordChar = "*"
        TextBox3.PasswordChar = "*"
        If x = Form1.y And y = z Then
            Form4.Show()
        Else
            MsgBox("PIN does not match. Try again")
        End If
        Form1.y = z
    End Sub
End Class