
Public Class Form5

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Button2.Enabled = False Then
            MsgBox("Il n'y a pas des vols pour le momment", MsgBoxStyle.Information, "Désoler")

        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim verif As Boolean = True
        If TextBox2.Visible = True Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                verif = False

            End If
        ElseIf TextBox2.Visible = False Then
            If TextBox1.Text = "" Then
                verif = False
            End If
        End If

        If verif = False Then
            MsgBox("Entrer le Numéro de vol", MsgBoxStyle.Exclamation, "Attention")
        Else
            Form6.Label3.Text = TextBox1.Text
            Form6.Label1.Text = TextBox2.Text
            Form6.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class