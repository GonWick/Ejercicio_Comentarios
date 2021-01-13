Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EjercicioComentariosDataSet.Comentarios' Puede moverla o quitarla según sea necesario.
        Me.ComentariosTableAdapter.Fill(Me.EjercicioComentariosDataSet.Comentarios)
        Me.Text = "Ejercicio Comentarios"
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        MessageBox.Show("Hola " + TextBoxNombre.Text & " de " + TextBoxOrganizacion.Text)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            LabelComentarios.ForeColor = ColorDialog1.Color
        End If
    End Sub
End Class
