Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Studentdb.Recodset.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studentdb.Recordset.fields("Student ID") = txtroll.text
        studentdb.Recordset.fields("Name") = txtroll.text
        studentdb.Recordset.fields("class") = txtroll.text
        studentdb.Recordset.fields("Address") = txtroll.text
        studentdb.Recordset.fields("email") = txtroll.text
        studentdb.Recordset.fields("phone") = txtroll.text
        studentdb.Recordset.update()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        confirmation=MsgBox"Do you want to delete ?! ",vbyesNo+vbcritical,"Delete Record confirmation")
        If confirmation = vbYes Then
            studentdb.Recordset.delete()
            MsgBox("It`s deleted", vbInformation,"Message"
        Else
                   MsgBox Record Not delete !!! ",VbInformattion,"Message"
            studentdb.Recordset.Delete()

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtstudentID.text = ""
        txtName.text = ""
        txtclass.text = ""
        txtaddress.txt = ""
        txtemail.text = ""
        txtphone.text = ""
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Hide()

    End Sub
End Class
