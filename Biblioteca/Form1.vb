﻿Public Class Form1

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        Dim prestarForm As New FormPrestar()
        prestarForm.Show()
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        Dim devolverForm As New FormDevolver()
        devolverForm.Show()
    End Sub

End Class