<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RubroForm
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
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLabel.Location = New System.Drawing.Point(81, 45)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(23, 20)
        Me.IdLabel.TabIndex = 0
        Me.IdLabel.Text = "Id"
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.Location = New System.Drawing.Point(12, 71)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(92, 20)
        Me.DescLabel.TabIndex = 1
        Me.DescLabel.Text = "Descripcion"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(110, 47)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(79, 20)
        Me.TextBoxId.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(110, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 3
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(56, 123)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 4
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(174, 123)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 5
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'RubroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 160)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.DescLabel)
        Me.Controls.Add(Me.IdLabel)
        Me.Name = "RubroForm"
        Me.Text = "RubroForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IdLabel As Label
    Friend WithEvents DescLabel As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonCancelar As Button
End Class
