Public Class FormDevolver
    Private libro As Libro

    Private Sub FormDevolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        libro = New Libro("Amanecer", "Stephenie Meyer") ' Usar la misma instancia del libro que en el otro formulario
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        If txtTitulo.Text = libro.Titulo AndAlso txtAutor.Text = libro.Autor Then
            If libro.Devolver() Then
                lblResultado.Text = "Libro devuelto con éxito."
            Else
                lblResultado.Text = "El libro ya está disponible."
            End If
        Else
            lblResultado.Text = "Título o autor incorrectos."
        End If
    End Sub
End Class