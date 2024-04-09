Public Class Form1

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles color1.Click, color3.Click, color2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If color1.Visible Then
            color2.Visible = True
            color1.Visible = False
            color3.Visible = False
        ElseIf color2.Visible Then
            color3.Visible = True
            color2.Visible = False
            color1.Visible = False
        Else
            color1.Visible = True
            color2.Visible = False
            color3.Visible = False
        End If
    End Sub
End Class
