<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblCurso = New Label()
        txtCurso = New TextBox()
        txtLista = New TextBox()
        btnAdicioanar = New Button()
        btnLimpar = New Button()
        SuspendLayout()
        ' 
        ' lblCurso
        ' 
        lblCurso.AutoSize = True
        lblCurso.Location = New Point(12, 9)
        lblCurso.Name = "lblCurso"
        lblCurso.Size = New Size(41, 15)
        lblCurso.TabIndex = 2
        lblCurso.Text = "Label2"
        ' 
        ' txtCurso
        ' 
        txtCurso.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCurso.BorderStyle = BorderStyle.FixedSingle
        txtCurso.Location = New Point(12, 36)
        txtCurso.Name = "txtCurso"
        txtCurso.Size = New Size(306, 23)
        txtCurso.TabIndex = 3
        ' 
        ' txtLista
        ' 
        txtLista.BorderStyle = BorderStyle.FixedSingle
        txtLista.Location = New Point(12, 76)
        txtLista.Multiline = True
        txtLista.Name = "txtLista"
        txtLista.ReadOnly = True
        txtLista.ScrollBars = ScrollBars.Vertical
        txtLista.Size = New Size(321, 133)
        txtLista.TabIndex = 5
        ' 
        ' btnAdicioanar
        ' 
        btnAdicioanar.Location = New Point(347, 31)
        btnAdicioanar.Name = "btnAdicioanar"
        btnAdicioanar.Size = New Size(122, 29)
        btnAdicioanar.TabIndex = 4
        btnAdicioanar.Text = "Button2"
        btnAdicioanar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Location = New Point(350, 73)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(117, 24)
        btnLimpar.TabIndex = 6
        btnLimpar.Text = "Button1"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLimpar)
        Controls.Add(txtLista)
        Controls.Add(btnAdicioanar)
        Controls.Add(txtCurso)
        Controls.Add(lblCurso)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblCurso As Label
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents txtLista As TextBox
    Friend WithEvents btnAdicioanar As Button
    Friend WithEvents btnLimpar As Button
End Class
