Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i As Integer = 1 To 6
            For j As Integer = 1 To i
                TextBox1.Text = TextBox1.Text & j
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
    End Sub
End Class
