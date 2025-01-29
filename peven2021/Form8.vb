Imports System.IO

Public Class Form8

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim fs As New FileStream("D:\projet peven\reservation.txt", FileMode.Append, FileAccess.Write)
        Dim sr As New StreamWriter(fs)
        If Label7.Text = "Aller Simple" Then
            Dim fs1 As New FileStream("D:\projet peven\vol.txt", FileMode.Open, FileAccess.Read)
            Dim sr1 As New StreamReader(fs1)
            Dim t() As String
            While sr1.Peek > -1
                t = sr1.ReadLine.Split("#")
                If t(0) = Label21.Text Then

                    sr.WriteLine("valider" + "#" + Label17.Text + "#" + Label22.Text + "#" + t(0) + "#" + t(1) + "#" + t(2) + "#" + t(3) + "#" + t(4) + "#" + t(5) + "#" + t(6) + "#" + t(7))
                End If

            End While
            sr1.Close()
            fs1.Close()
        Else
            Dim fs2 As New FileStream("D:\projet peven\vol.txt", FileMode.Open, FileAccess.Read)
            Dim sr2 As New StreamReader(fs2)
            Dim t1() As String
            While sr2.Peek > -1
                t1 = sr2.ReadLine.Split("#")
                If t1(0) = Label21.Text Or t1(0) = Label20.Text Then

                    sr.WriteLine("valider" + "#" + Label17.Text + "#" + Label22.Text + "#" + t1(0) + "#" + t1(1) + "#" + t1(2) + "#" + t1(3) + "#" + t1(4) + "#" + t1(5) + "#" + t1(6) + "#" + t1(7))
                End If
            End While

            sr2.Close()
            fs2.Close()
        End If
        sr.Close()
        fs.Close()
        MsgBox("réservation términer avec succes")
        Button1.Enabled = False


    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Êtes-vous sûr de vouloir vous quiter?", MsgBoxStyle.YesNo, MessageBoxIcon.Question)
        If MsgBoxResult.Yes Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub
End Class