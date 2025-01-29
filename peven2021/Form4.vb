Imports System.IO
Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            DateTimePicker2.Enabled = False

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DateTimePicker2.Enabled = True

        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim fs As New FileStream("D:\projet peven\vol.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim verif As Boolean
        Dim t() As String
        Dim vid As Boolean = True

        verif = True
        If DateTimePicker1.Value.Date < Date.Now.Date Then
            MsgBox("Veuillez choisir le date correctement", vbCritical, "heey")
            verif = False
        End If
        If verif = True Then
            While sr.Peek > -1
                s = sr.ReadLine
                t = s.Split("#")
                If RadioButton4.Checked = True Then
                    If RadioButton2.Checked = True Then
                        Form5.TextBox2.Visible = False
                        Form5.Label3.Visible = False
                        Form6.GroupBox2.Visible = False
                        If (t(1) = ComboBox4.Text) And (t(2) = ComboBox3.Text) And (t(4) = "eco") And (t(3) = "Aller") And (Convert.ToDateTime(t(5)) = DateTimePicker1.Value.Date) Then
                            vid = False
                            Dim element As New ListViewItem
                            element.Text = t(0)
                            element.SubItems.Add(t(5))
                            element.SubItems.Add(t(7))
                            element.SubItems.Add(t(6))
                            Form5.ListView1.Items.Add(element)

                        End If
                    ElseIf RadioButton3.Checked = True Then
                        If (t(1) = ComboBox4.Text) And (t(2) = ComboBox3.Text) And (t(4) = "vip") And (t(3) = "Aller") And (Convert.ToDateTime(t(5)) = DateTimePicker1.Value.Date) Then
                            vid = False
                            Dim element As New ListViewItem
                            element.Text = t(0)
                            element.SubItems.Add(t(5))
                            element.SubItems.Add(t(7))
                            element.SubItems.Add(t(6))
                            Form5.ListView1.Items.Add(element)

                        End If
                    End If
                ElseIf RadioButton1.Checked = True Then
                    Form5.TextBox2.Visible = True
                    Form5.Label3.Visible = True
                    Form6.GroupBox2.Visible = True

                    If RadioButton2.Checked = True Then
                        If (t(1) = ComboBox4.Text) And (t(2) = ComboBox3.Text) And (t(4) = "eco") And (t(3) = "Aller") And (Convert.ToDateTime(t(5)) = DateTimePicker1.Value.Date) Then
                            vid = False
                            Dim element As New ListViewItem
                            element.Text = t(0)
                            element.SubItems.Add(t(5))
                            element.SubItems.Add(t(7))
                            element.SubItems.Add(t(6))
                            Form5.ListView1.Items.Add(element)

                        ElseIf (t(1) = ComboBox3.Text) And (t(2) = ComboBox4.Text) And (t(4) = "eco") And (t(3) = "retour") And (Convert.ToDateTime(t(5)) = DateTimePicker2.Value.Date) Then
                            vid = False
                            Dim element1 As New ListViewItem
                            element1.Text = t(0)
                            element1.SubItems.Add(t(5))
                            element1.SubItems.Add(t(7))
                            element1.SubItems.Add(t(6))
                            Form5.ListView2.Items.Add(element1)

                        End If
                    ElseIf RadioButton3.Checked = True Then
                        If (t(1) = ComboBox4.Text) And (t(2) = ComboBox3.Text) And (t(4) = "vip") And (t(3) = "Aller") And (Convert.ToDateTime(t(5)) = DateTimePicker1.Value.Date) Then
                            vid = False
                            Dim element As New ListViewItem
                            element.Text = t(0)
                            element.SubItems.Add(t(5))
                            element.SubItems.Add(t(7))
                            element.SubItems.Add(t(6))
                            Form5.ListView1.Items.Add(element)

                        ElseIf (t(1) = ComboBox3.Text) And (t(2) = ComboBox4.Text) And (t(4) = "vip") And (t(3) = "retour") And (Convert.ToDateTime(t(5)) = DateTimePicker2.Value.Date) Then
                            vid = False
                            Dim element1 As New ListViewItem
                            element1.Text = t(0)
                            element1.SubItems.Add(t(5))
                            element1.SubItems.Add(t(7))
                            element1.SubItems.Add(t(6))
                            Form5.ListView2.Items.Add(element1)


                        End If
                    End If


                End If

            End While
        End If
        sr.Close()
        fs.Close()


        If vid = True Then
            Form5.Button2.Enabled = False
        Else
            Form5.Button2.Enabled = True



        End If
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class