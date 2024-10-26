<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDevolver
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
        btnDevolver = New Button()
        lblTitulo = New Label()
        lblAutor = New Label()
        lblResultado = New Label()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        SuspendLayout()
        ' 
        ' btnDevolver
        ' 
        btnDevolver.BackColor = Color.Thistle
        btnDevolver.ForeColor = SystemColors.ButtonFace
        btnDevolver.Location = New Point(314, 320)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(112, 34)
        btnDevolver.TabIndex = 0
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.Thistle
        lblTitulo.ForeColor = SystemColors.ControlLight
        lblTitulo.Location = New Point(91, 104)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(126, 25)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Titulo del libro"
        ' 
        ' lblAutor
        ' 
        lblAutor.AutoSize = True
        lblAutor.BackColor = Color.Thistle
        lblAutor.ForeColor = SystemColors.ControlLight
        lblAutor.Location = New Point(512, 104)
        lblAutor.Name = "lblAutor"
        lblAutor.Size = New Size(127, 25)
        lblAutor.TabIndex = 2
        lblAutor.Text = "Autor del libro"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(396, 343)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(0, 25)
        lblResultado.TabIndex = 3
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(72, 173)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(193, 31)
        txtTitulo.TabIndex = 4
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(474, 173)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(193, 31)
        txtAutor.TabIndex = 5
        ' 
        ' FormDevolver
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Plum
        ClientSize = New Size(800, 450)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(lblResultado)
        Controls.Add(lblAutor)
        Controls.Add(lblTitulo)
        Controls.Add(btnDevolver)
        Name = "FormDevolver"
        Text = "Devolver libros"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDevolver As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
End Class
