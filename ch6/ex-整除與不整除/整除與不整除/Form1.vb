Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        For i As Integer = 1 To 1000
            If ((i Mod 7) = 0) Then
                If ((i Mod 21) = 0) Then
                    Continue For
                Else
                    TextBox1.Text = TextBox1.Text & i & vbNewLine
                    sum = sum + i
                End If
            End If
        Next
        TextBox1.Text = TextBox1.Text & sum & vbNewLine
    End Sub
End Class
