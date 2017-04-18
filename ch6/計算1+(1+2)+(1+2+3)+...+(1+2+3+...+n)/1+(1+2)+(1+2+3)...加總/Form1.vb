Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)
        Dim sum As Integer
        Dim sumAll As Integer = 0
        For i As Integer = 1 To n
            sum = 0
            For j As Integer = 1 To i
                sum = sum + j
            Next
            TextBox2.Text = TextBox2.Text & "i=" & i & ",sum=" & sum & vbNewLine
            sumAll = sumAll + sum
        Next
        TextBox2.Text = TextBox2.Text & "1+(1+2)+(1+2+3)+...+(1+2+3+...+n)=" & sumAll
    End Sub
End Class
