Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ejercicio Comentarios"
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        MessageBox.Show("Hola" + TextBoxNombre.Text & " de " + TextBoxOrganizacion.Text)
    End Sub
End Class
