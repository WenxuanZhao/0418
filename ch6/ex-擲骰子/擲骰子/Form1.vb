Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim n As Integer
        Do
            n = CInt(Int(6 * Rnd())) + 1
            MsgBox("點數為" & n)
            If (n = 6) Then
                Exit Do
            End If
        Loop While (1)
    End Sub
End Class
