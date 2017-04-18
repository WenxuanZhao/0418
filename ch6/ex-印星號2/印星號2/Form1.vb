Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        Do While (i <= 5)
            For j As Integer = (5 - i) To 0 Step -1
                TextBox1.Text = TextBox1.Text & "  "
            Next
            For j As Integer = 1 To i
                TextBox1.Text = TextBox1.Text & "*"
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
            i = i + 1
        Loop
    End Sub
End Class
