Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Then
            MsgBox("Enter val of color")
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Enter val of color")

        ElseIf TextBox1.Text > 255 Or TextBox2.Text > 255 Or TextBox3.Text > 255 Then

            MsgBox("Enter value of color between 0 and 255")
        ElseIf TextBox1.Text < 0 Or TextBox2.Text < 0 Or TextBox3.Text < 0 Then
            MsgBox("enter val of color more than or equal 0")
        Else : PictureBox1.BackColor = Color.FromArgb(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)



        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
