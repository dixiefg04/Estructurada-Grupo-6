Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usuario As String
        Dim contraseña As Integer
        usuario = txt_Usuario.Text
        contraseña = txt_Contraseña.Text
        If usuario = "Admin" And contraseña = "1234" Then
            Menú.Show()
        Else
            MsgBox("Usuario o Contraseña incorrecta")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
