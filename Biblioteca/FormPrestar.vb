Public Class FormPrestar
    Private libro As Libro

    Private Sub FormPrestar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        libro = New Libro("Amanecer", "Stephenie Meyer") ' Crear una instancia del libro
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        If txtTitulo.Text = libro.Titulo AndAlso txtAutor.Text = libro.Autor Then
            If libro.Prestar() Then
                lblResultado.Text = "Libro prestado con éxito."
            Else
                lblResultado.Text = "El libro no está disponible."
            End If
        Else
            lblResultado.Text = "Título o autor incorrectos."
        End If
    End Sub
End Class
