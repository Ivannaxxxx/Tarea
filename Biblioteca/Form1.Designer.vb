<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnPrestar = New Button()
        btnDevolver = New Button()
        SuspendLayout()
        ' 
        ' btnPrestar
        ' 
        btnPrestar.BackColor = Color.Thistle
        btnPrestar.ForeColor = Color.Transparent
        btnPrestar.Location = New Point(130, 187)
        btnPrestar.Name = "btnPrestar"
        btnPrestar.Size = New Size(193, 114)
        btnPrestar.TabIndex = 0
        btnPrestar.Text = "Prestar libros"
        btnPrestar.UseVisualStyleBackColor = False
        ' 
        ' btnDevolver
        ' 
        btnDevolver.BackColor = Color.Thistle
        btnDevolver.ForeColor = Color.Transparent
        btnDevolver.Location = New Point(478, 187)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(193, 114)
        btnDevolver.TabIndex = 1
        btnDevolver.Text = "Devolver libros"
        btnDevolver.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Plum
        ClientSize = New Size(800, 450)
        Controls.Add(btnDevolver)
        Controls.Add(btnPrestar)
        ForeColor = Color.CornflowerBlue
        Name = "Form1"
        Text = "Biblioteca"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPrestar As Button
    Friend WithEvents btnDevolver As Button
End Class
