Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim variable, dato As Integer
        variable = 0
        dato = 2
        For i As Integer = 2 To 2000 Step 2
            variable = dato + variable
            ListaNumeros.Items.Add(variable.ToString())
        Next
    End Sub
End Class
