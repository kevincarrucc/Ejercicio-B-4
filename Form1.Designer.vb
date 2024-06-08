<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Boton = New System.Windows.Forms.Button()
        Me.ListaNumeros = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(383, 216)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 0
        Me.Boton.Text = "Ejecutar"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'ListaNumeros
        '
        Me.ListaNumeros.FormattingEnabled = True
        Me.ListaNumeros.HorizontalScrollbar = True
        Me.ListaNumeros.Location = New System.Drawing.Point(104, 5)
        Me.ListaNumeros.MultiColumn = True
        Me.ListaNumeros.Name = "ListaNumeros"
        Me.ListaNumeros.Size = New System.Drawing.Size(125, 446)
        Me.ListaNumeros.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 450)
        Me.Controls.Add(Me.ListaNumeros)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Boton As Button
    Friend WithEvents ListaNumeros As ListBox
End Class
