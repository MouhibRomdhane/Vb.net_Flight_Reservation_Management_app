Imports System.IO


Public Class Form9

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim verif As Boolean = False
        Dim fs1 As New FileStream("D:\projet peven\corbeille.txt", FileMode.Create, FileAccess.Write)
        Dim sr1 As New StreamWriter(fs1)

        Dim fs As New FileStream("D:\projet peven\reservation.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")

            If RadioButton1.Checked = True Then
                If t(2) = TextBox2.Text And t(3) = TextBox1.Text Or t(3) = TextBox3.Text Then
                    sr1.WriteLine("Annuler" + "#" + t(1) + "#" + t(2) + "#" + t(3) + "#" + t(4) + "#" + t(5) + "#" + t(6) + "#" + t(7) + "#" + t(8) + "#" + t(9) + "#" + t(10))
                    verif = True
                Else
                    sr1.WriteLine(s)
                End If
            Else
                If t(2) = TextBox2.Text And t(3) = TextBox1.Text Then
                    verif = True
                    sr1.WriteLine("Annuler" + "#" + t(1) + "#" + t(2) + "#" + t(3) + "#" + t(4) + "#" + t(5) + "#" + t(6) + "#" + t(7) + "#" + t(8) + "#" + t(9) + "#" + t(10))
                Else
                    sr1.WriteLine(s)
                End If
            End If
        End While
        sr.Close()
        fs.Close()
        sr1.Close()
        fs1.Close()
        Dim fs2 As New FileStream("D:\projet peven\reservation.txt", FileMode.Create, FileAccess.Write)
        Dim sr2 As New StreamWriter(fs2)
        Dim fs3 As New FileStream("D:\projet peven\corbeille.txt", FileMode.Open, FileAccess.Read)
        Dim sr3 As New StreamReader(fs3)
        While sr3.Peek > -1
            sr2.WriteLine(sr3.ReadLine)
        End While
        sr3.Close()
        fs3.Close()
        sr2.Close()
        fs2.Close()
        If verif = True Then
            MsgBox("le réservation est annuler")
        Else

            MsgBox("cordonner invalide")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then

            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        TextBox3.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class