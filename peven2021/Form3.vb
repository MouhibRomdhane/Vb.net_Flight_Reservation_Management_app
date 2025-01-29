Imports System.IO

Public Class Form3

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.KeyChar = ""
        End If
    End Sub

   

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim verif As Boolean = True
        Dim Accents As String = "àáâãäåèéêëìíîïðñòóôõöùúûüýÿ"
        Dim CarInterdits As String = ",;#`'/*+:\&<>~{}=)([]|?§"
        Dim TestAccents As Boolean = True
        Dim TestCarInterdits As Boolean = True
        Dim TestEspace As Boolean = False
        Dim testadress As Boolean = False
        Dim arobase2 As New Boolean
        Dim pos_point, pos_point2, pos_arobase As New Integer
        Dim i As New Integer
        If Len(TextBox5.Text) > 6 Then

            pos_arobase = InStr(1, TextBox5.Text, "@")


            If pos_arobase > 0 Then
                'Vérifie qu'il n'y a pas plusieurs @ dans l'adresse mail

                arobase2 = TextBox5.Text.Substring(pos_arobase).Contains("@")
                'Position du . après l'@
                pos_point = InStr(pos_arobase + 1, TextBox5.Text, ".")
                'Position du . avant l'@
                pos_point2 = InStr(1, TextBox5.Text.Substring(0, pos_arobase), ".")
                If pos_arobase > 1 And pos_point > 1 And pos_point - pos_arobase > 1 And pos_arobase - pos_point2 > 1 And pos_point2 > 1 And pos_arobase - pos_point2 <> pos_arobase And Len(TextBox5.Text) - pos_point > 0 And arobase2 = False Then
                    testadress = True
                Else
                    testadress = False
                End If
            End If
        End If
        'Vérifie qu'il n'y a pas de caractères accentués dans l'adresse mail


        For i = 0 To Len(TextBox5.Text) - 1
            If InStr(1, Accents, LCase(TextBox5.Text.Substring(i, 1))) > 0 Then
                TestAccents = False
                Exit For
            End If

        Next
        'Vérifie qu'il n'y a pas de caractères exclus dans l'adresse mail

        For i = 0 To Len(TextBox5.Text) - 1
            If InStr(1, CarInterdits, LCase(TextBox5.Text.Substring(i, 1))) > 0 Then
                TestCarInterdits = False


                Exit For
            End If
        Next
        Dim espace As String = " "
        For i = 0 To Len(TextBox5.Text) - 1
            If InStr(1, espace, LCase(TextBox5.Text.Substring(i, 1))) > 0 Then
                TestEspace = True

                Exit For
            End If
        Next

        If (TestAccents = False) Or (TestEspace = True) Or (TestCarInterdits = False) Or (testadress = False) Then
            verif = False
            Label3.Visible = True

        End If

        If TextBox4.Text.Length > 8 Then
            verif = False
            Label9.Visible = True

        End If


        If TextBox3.Text.Length > 8 Then
            verif = False
            Label10.Visible = True

        End If



        If (Date.Now.Date.Year - DateTimePicker1.Value.Date.Year < 18) Then
            MsgBox("Choisir la date de naissance correctement", vbCritical, "Attention")
            verif = False

        End If
        Dim trouv As Boolean = False

        Dim s As String
        Dim t() As String
        If verif = True Then
            Dim fs As New FileStream("D:\projet peven\passagers.txt", FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(fs)
            While sr.Peek > -1
                s = sr.ReadLine
                t = s.Split("#")
                If t(0) = TextBox3.Text Then
                    trouv = True
                End If
            End While
            sr.Close()
            fs.Close()

            If trouv = False Then
                Dim fs1 As New FileStream("D:\projet peven\passagers.txt", FileMode.Append, FileAccess.Write)
                Dim sr1 As New StreamWriter(fs1)
                sr1.WriteLine(TextBox3.Text + "#" + TextBox1.Text + "#" + TextBox2.Text + "#" + TextBox4.Text + "#" + TextBox5.Text + "#" + DateTimePicker1.Value.Date + "#" + ComboBox1.SelectedItem)
                sr1.Close()
                fs1.Close()
                MsgBox("l'inscription est terminer avec succes")

              
            Else
                MsgBox("le passager est déja existe", MsgBoxStyle.Information, "Inscription")

            End If

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.KeyChar = ""

        End If
    End Sub


    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.KeyChar = ""
        End If
    End Sub

  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class