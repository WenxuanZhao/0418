Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim acc As String
        Dim pass As String
        Do
            acc = InputBox("請輸入帳號")
            pass = InputBox("請輸入密碼")
            If (acc = "abc" And pass = "123") Then
                MsgBox("登入成功")
                Exit Do
            Else
                MsgBox("登入失敗")
            End If
        Loop While (1)
    End Sub
End Class
