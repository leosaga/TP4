<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ArticulosGrid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosGrid))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.FiltroButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Blue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ButtonAgregar, Me.ToolStripSeparator2, Me.ButtonModificar, Me.ToolStripSeparator3, Me.ButtonEliminar, Me.ToolStripSeparator4, Me.ButtonSalir, Me.ToolStripComboBox1, Me.ToolStripSeparator5, Me.FiltroButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 64)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 64)
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonAgregar.Image = CType(resources.GetObject("ButtonAgregar.Image"), System.Drawing.Image)
        Me.ButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(53, 61)
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 64)
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Image = CType(resources.GetObject("ButtonModificar.Image"), System.Drawing.Image)
        Me.ButtonModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(62, 61)
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 64)
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Image = CType(resources.GetObject("ButtonEliminar.Image"), System.Drawing.Image)
        Me.ButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(54, 61)
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 64)
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(44, 61)
        Me.ButtonSalir.Text = "Saliar"
        Me.ButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(833, 487)
        Me.DataGridView1.TabIndex = 2
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(300, 64)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 64)
        '
        'FiltroButton
        '
        Me.FiltroButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FiltroButton.Image = CType(resources.GetObject("FiltroButton.Image"), System.Drawing.Image)
        Me.FiltroButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FiltroButton.Name = "FiltroButton"
        Me.FiltroButton.Size = New System.Drawing.Size(44, 61)
        Me.FiltroButton.Text = "Filtro"
        Me.FiltroButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ArticulosGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 487)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ArticulosGrid"
        Me.Text = "ArticulosGrid"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ButtonAgregar As ToolStripButton
    Friend WithEvents ButtonModificar As ToolStripButton
    Friend WithEvents ButtonEliminar As ToolStripButton
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents FiltroButton As ToolStripButton
End Class
