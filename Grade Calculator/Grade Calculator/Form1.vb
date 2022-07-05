Public Class Form1
    Private pq1, mq2, fq3, pass1, mass2, fass3, pact1, mact2, fact3, pe1, me2, fe3, tpre, tmid, tfinal, ttotal As Double



    Private Sub q1_TextChanged(sender As Object, e As EventArgs) Handles q1.TextChanged
        pq1 = q1.Text

    End Sub

    Private Sub ass1_TextChanged(sender As Object, e As EventArgs) Handles ass1.TextChanged
        pass1 = ass1.Text

    End Sub

    Private Sub act1_TextChanged(sender As Object, e As EventArgs) Handles act1.TextChanged
        pact1 = act1.Text

    End Sub

    Private Sub e1_TextChanged(sender As Object, e As EventArgs) Handles e1.TextChanged
        pe1 = e1.Text

    End Sub

    Private Sub q2_TextChanged(sender As Object, e As EventArgs) Handles q2.TextChanged
        mq2 = q2.Text

    End Sub

    Private Sub ass2_TextChanged(sender As Object, e As EventArgs) Handles ass2.TextChanged
        mass2 = ass2.Text

    End Sub

    Private Sub act2_TextChanged(sender As Object, e As EventArgs) Handles act2.TextChanged
        mact2 = act2.Text

    End Sub

    Private Sub e2_TextChanged(sender As Object, e As EventArgs) Handles e2.TextChanged
        me2 = e2.Text

    End Sub

    Private Sub q3_TextChanged(sender As Object, e As EventArgs) Handles q3.TextChanged
        fq3 = q3.Text

    End Sub

    Private Sub ass3_TextChanged(sender As Object, e As EventArgs) Handles ass3.TextChanged
        fass3 = ass3.Text

    End Sub

    Private Sub act3_TextChanged(sender As Object, e As EventArgs) Handles act3.TextChanged
        fact3 = act3.Text

    End Sub

    Private Sub e3_TextChanged(sender As Object, e As EventArgs) Handles e3.TextChanged
        fe3 = e3.Text

    End Sub

    Private Sub pre_TextChanged(sender As Object, e As EventArgs) Handles pre.TextChanged
        tpre = pre.Text
    End Sub

    Private Sub mid_TextChanged(sender As Object, e As EventArgs) Handles midterm.TextChanged
        tmid = midterm.Text

    End Sub

    Private Sub final_TextChanged(sender As Object, e As EventArgs) Handles final.TextChanged
        tfinal = final.Text

    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged
        ttotal = total.Text

    End Sub

    Private Sub pre_btn_Click(sender As Object, e As EventArgs) Handles pre_btn.Click
        tpre = pq1 * (0.2) + pass1 * (0.15) + pact1 * (0.35) + pe1 * (0.3)
        pre.Text = tpre

    End Sub

    Private Sub mid_btn_Click(sender As Object, e As EventArgs) Handles mid_btn.Click
        tmid = mq2 * (0.2) + mass2 * (0.15) + mact2 * (0.35) + me2 * (0.3)
        midterm.Text = tmid
    End Sub

    Private Sub final_btn_Click(sender As Object, e As EventArgs) Handles final_btn.Click
        tfinal = fq3 * (0.2) + fass3 * (0.15) + fact3 * (0.35) + fe3 * (0.3)
        final.Text = tfinal

    End Sub

    Private Sub total_btn_Click(sender As Object, e As EventArgs) Handles total_btn.Click
        ttotal = tpre * (0.3) + tmid * (0.3) + tfinal * (0.4)
        total.Text = ttotal
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
