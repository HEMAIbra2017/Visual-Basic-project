Public Class Form1
    Dim NumToMultiply As Integer = 1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do While (NumToMultiply <= 10)
            ListBox1.Items.Add(NumToMultiply & " * " & Val(TextBox1.Text) & " =" & NumToMultiply * Val(TextBox1.Text))
            NumToMultiply += 1

        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox1.Refresh()
        TextBox1.Text = ""
        NumToMultiply = 1
    End Sub
End Class
