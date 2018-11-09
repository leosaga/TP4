<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ProductosButton = New System.Windows.Forms.ToolStripButton()
        Me.RubrosButton = New System.Windows.Forms.ToolStripButton()
        Me.SalirButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosButton, Me.RubrosButton, Me.SalirButton})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1024, 38)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ProductosButton
        '
        Me.ProductosButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProductosButton.Image = CType(resources.GetObject("ProductosButton.Image"), System.Drawing.Image)
        Me.ProductosButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ProductosButton.Name = "ProductosButton"
        Me.ProductosButton.Size = New System.Drawing.Size(48, 35)
        Me.ProductosButton.Text = "Rubros"
        Me.ProductosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RubrosButton
        '
        Me.RubrosButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RubrosButton.Image = CType(resources.GetObject("RubrosButton.Image"), System.Drawing.Image)
        Me.RubrosButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RubrosButton.Name = "RubrosButton"
        Me.RubrosButton.Size = New System.Drawing.Size(65, 35)
        Me.RubrosButton.Text = "Productos"
        Me.RubrosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirButton
        '
        Me.SalirButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SalirButton.Image = CType(resources.GetObject("SalirButton.Image"), System.Drawing.Image)
        Me.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(33, 35)
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 60)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 561)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ProductosButton As ToolStripButton
    Friend WithEvents RubrosButton As ToolStripButton
    Friend WithEvents SalirButton As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
