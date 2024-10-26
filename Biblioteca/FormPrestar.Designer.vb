<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrestar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblAutor = New Label()
        lblResultado = New Label()
        btnPrestar = New Button()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.Thistle
        lblTitulo.ForeColor = SystemColors.ControlLight
        lblTitulo.Location = New Point(103, 100)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(126, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Titulo del libro"
        ' 
        ' lblAutor
        ' 
        lblAutor.AutoSize = True
        lblAutor.BackColor = Color.Thistle
        lblAutor.ForeColor = SystemColors.ControlLight
        lblAutor.Location = New Point(523, 100)
        lblAutor.Name = "lblAutor"
        lblAutor.Size = New Size(127, 25)
        lblAutor.TabIndex = 1
        lblAutor.Text = "Autor del libro"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(475, 330)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(0, 25)
        lblResultado.TabIndex = 2
        ' 
        ' btnPrestar
        ' 
        btnPrestar.ForeColor = SystemColors.ControlDarkDark
        btnPrestar.Location = New Point(332, 345)
        btnPrestar.Name = "btnPrestar"
        btnPrestar.Size = New Size(137, 37)
        btnPrestar.TabIndex = 3
        btnPrestar.Text = "Prestar"
        btnPrestar.UseVisualStyleBackColor = True
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(68, 164)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.PlaceholderText = "Titulo del libro"
        txtTitulo.Size = New Size(231, 31)
        txtTitulo.TabIndex = 4
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(464, 164)
        txtAutor.Name = "txtAutor"
        txtAutor.PlaceholderText = "Autor del libro"
        txtAutor.Size = New Size(231, 31)
        txtAutor.TabIndex = 5
        ' 
        ' FormPrestar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Plum
        ClientSize = New Size(800, 450)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(btnPrestar)
        Controls.Add(lblResultado)
        Controls.Add(lblAutor)
        Controls.Add(lblTitulo)
        Name = "FormPrestar"
        Text = "Prestar libros"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnPrestar As Button
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox

End Class
