Public Class Form2
    Private n1, n2, add, diff, quo, prod, total1 As Double

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total1 = n1 + n2
        total.Text = total1
    End Sub

    Private Sub num1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged
        n1 = num1.Text
    End Sub

    Private Sub num2_TextChanged(sender As Object, e As EventArgs) Handles num2.TextChanged
        n2 = num2.Text
    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged
        total.Text = total1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        total1 = n1 * n2
        total.Text = total1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total1 = n1 / n2
        total.Text = total1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        total1 = n1 - n2
        total.Text = total1
    End Sub
End Class