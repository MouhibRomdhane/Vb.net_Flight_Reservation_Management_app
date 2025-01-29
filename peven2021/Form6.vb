Imports System.IO

Public Class Form6

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim s As String
        Dim found As Boolean = False
        Dim t() As String
        Dim t2() As String
        Dim t3() As String
        Dim som As Integer
        Dim som1 As Integer
        Dim fs As New FileStream("D:\projet peven\vol.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim fs2 As New FileStream("D:\projet peven\vol.txt", FileMode.Open, FileAccess.Read)
        Dim sr2 As New StreamReader(fs2)
        If GroupBox2.Visible = False Then
            Form8.Label19.Visible = False
            Form8.Label20.Visible = False
            Form8.Label21.Text = Label3.Text
            While (sr.Peek > -1)
                s = sr.ReadLine
                t = s.Split("#")
                If t(0) = Label3.Text Then
                    Form8.Label7.Text = "Aller Simple"
                    If t(4) = "eco" Then
                        Form8.Label5.Text = "Economique"
                    Else
                        Form8.Label5.Text = "Homme d'affaire"

                    End If
                    Form8.Label9.Text = t(6) + "Dt"
                    Form8.Label17.Text = CStr(NumericUpDown1.Value * CInt(t(6)) + NumericUpDown2.Value * (CInt(t(6)) * 0.95) + NumericUpDown3.Value * (CInt(t(6)) * 0.9)) + "Dt"
                End If

            End While

        ElseIf GroupBox2.Visible = True Then
            Form8.Label19.Visible = True
            Form8.Label20.Visible = True
            Form8.Label21.Text = Label3.Text
            Form8.Label20.Text = Label1.Text
            While sr.Peek > -1
                s = sr.ReadLine
                t2 = s.Split("#")
                If t2(0) = Label3.Text Then
                    Form8.Label7.Text = "Aller-Retoure"
                    If t2(4) = "eco" Then
                        Form8.Label5.Text = "Economique"
                    Else
                        Form8.Label5.Text = "Homme d'affaire"

                    End If

                    som1 = CInt(t2(6))
                End If
            End While
            sr.Close()
            fs.Close()
           
            While sr2.Peek > -1
                s = sr2.ReadLine
                t3 = s.Split("#")
                If t3(0) = Label1.Text Then

                    som = som1 + CInt(t3(6))
                End If
            End While
            Form8.Label9.Text = CStr(som) + "Dt"
            Form8.Label17.Text = CStr(NumericUpDown1.Value * som + NumericUpDown2.Value * (som * 0.95) + NumericUpDown3.Value * (som * 0.9)) + "Dt"
        End If
        sr2.Close()
        fs2.Close()
        Dim fs1 As New FileStream("D:\projet peven\passagers.txt", FileMode.Open, FileAccess.Read)
        Dim sr1 As New StreamReader(fs1)
        Dim s1 As String
        Dim t1() As String
        While sr1.Peek > -1
            s1 = sr1.ReadLine
            t1 = s1.Split("#")
            If t1(0) = TextBox1.Text Then
                Form8.Label3.Text = t1(1) + " " + t1(2)
                found = True


            End If
        End While

        sr1.Close()
        fs1.Close()


        Form8.Label22.Text = TextBox1.Text
        Form8.Label11.Text = CStr(NumericUpDown2.Value)
        Form8.Label13.Text = CStr(NumericUpDown3.Value)
        Form8.Label15.Text = CStr(NumericUpDown1.Value)

        If found = False Then
            MsgBox("le numéro de passeport est incorrecte ", vbCritical, "Error")
        Else
            Form8.Show()

            Button1.Enabled = True
            Me.Hide()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()

    End Sub
End Class