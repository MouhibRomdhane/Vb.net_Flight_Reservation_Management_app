Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "isgtun2021" Then
            Form2.Show()
            Me.Hide()
        Else


            MsgBox("Mot de passe incorrect", vbCritical, "Attention")
            TextBox1.Clear()
            TextBox1.Focus()



        End If
    End Sub

   
   
End Class
