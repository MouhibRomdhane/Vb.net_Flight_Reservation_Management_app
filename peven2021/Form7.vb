Imports System.IO


Public Class Form7

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
        Dim trouv As Boolean = False

        Dim s As String
        Dim t() As String
        Dim element As New ListViewItem
        Dim fs As New FileStream("D:\projet peven\passagers.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            If t(0) = TextBox1.Text Then
                trouv = True
                If trouv = True Then
                    element.Text = t(1)
                    element.SubItems.Add(t(2))
                    element.SubItems.Add(t(3))
                    element.SubItems.Add(t(4))
                    element.SubItems.Add(t(5))
                    element.SubItems.Add(t(6))
                    ListView1.Items.Add(element)

                End If
            End If
        End While
        If trouv = False Then
            MsgBox("le passager inexistant", MsgBoxStyle.Information, "Passager")
        End If
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class