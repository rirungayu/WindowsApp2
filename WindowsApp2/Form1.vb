Public Class Form1
    Public Property TextBoxMode As Object
    Public p, q, z As String
    Public x = 35689543
    Public y = 2247

    Public acc_bal As Integer = 500000

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p = TextBox1.Text
        q = TextBox2.Text
        TextBox1.Text = ""
        TextBox1.PasswordChar = "*"
        If p = x And q = y Then
            Form2.Show()
        Else
            MsgBox("Wrong Account Number or PIN. Try again")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
