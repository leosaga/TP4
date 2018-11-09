<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoForm
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
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.DescipcionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.RubroLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(76, 134)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(216, 134)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 1
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'DescipcionTextBox
        '
        Me.DescipcionTextBox.Location = New System.Drawing.Point(111, 71)
        Me.DescipcionTextBox.Name = "DescipcionTextBox"
        Me.DescipcionTextBox.Size = New System.Drawing.Size(199, 20)
        Me.DescipcionTextBox.TabIndex = 2
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(111, 50)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelId.Location = New System.Drawing.Point(82, 48)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(23, 20)
        Me.LabelId.TabIndex = 4
        Me.LabelId.Text = "Id"
        Me.LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(13, 69)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(92, 20)
        Me.LabelDescripcion.TabIndex = 5
        Me.LabelDescripcion.Text = "Descripcion"
        '
        'RubroLabel
        '
        Me.RubroLabel.AutoSize = True
        Me.RubroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RubroLabel.Location = New System.Drawing.Point(52, 91)
        Me.RubroLabel.Name = "RubroLabel"
        Me.RubroLabel.Size = New System.Drawing.Size(53, 20)
        Me.RubroLabel.TabIndex = 6
        Me.RubroLabel.Text = "Rubro"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 178)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RubroLabel)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.DescipcionTextBox)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Name = "ProductoForm"
        Me.Text = "ArticulosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Aceptar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents DescipcionTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents LabelId As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents RubroLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
