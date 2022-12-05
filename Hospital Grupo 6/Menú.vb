Public Class Menú
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Me.Close()
        Pacientes.Show()
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        Me.Close()
        Consultas.Show()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Me.Close()
        Empleados.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MsgBox("En este momento regresará al Login")
        Me.Close()
        Form1.Show()
    End Sub
End Class