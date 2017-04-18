Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        Dim j As Integer
        Do While (i <= 4)
            j = 1
            Do While (j <= 4)
                If (i = j) Then
                    TextBox1.Text = TextBox1.Text & "1"
                Else
                    TextBox1.Text = TextBox1.Text & "0"
                End If
                j = j + 1
            Loop
            TextBox1.Text = TextBox1.Text & vbNewLine
            i = i + 1
        Loop
    End Sub
End Class
