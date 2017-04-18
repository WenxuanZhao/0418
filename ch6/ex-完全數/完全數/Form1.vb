Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer
        For i As Integer = 2 To 100
            sum = 0
            For j As Integer = 1 To (i - 1)
                If ((i Mod j) = 0) Then
                    sum = sum + j
                End If
            Next
            If (sum = i) Then
                TextBox1.Text = TextBox1.Text & i & "為質數" & vbNewLine
            End If
        Next
    End Sub
End Class
