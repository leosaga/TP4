Public Class ProductoForm

    Dim MiArticulo As New ArticuloClass
    Dim IdRubro_ As Integer
    Dim operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property



    Public Property IdRubro() As Integer
        Get
            Return IdRubro_
        End Get
        Set(value As Integer)
            IdRubro_ = value
        End Set
    End Property
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        Mi.Descripcion = DescipcionTextBox.Text
        Mi.IdRubro = IdRubro_

        If operacion <> "Agregar" Then
            MiArticulo.Id = CInt(IdTextBox.Text)
        End If

        ArtculoList.ActualizarArticulo(MiArticulo)

        Select Case operacion_

            Case "Agregar"
                carrerasList.InsertarArticulo(MiArticulo)

            Case "Modificar"
                carrerasList.ActualizarArticulo(MiArticulo)

            Case "Eliminar"
                carrerasList.EliminarArticulo(MiArticulo)

        End Select



        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()

    End Sub
    Public Property Rubrocombo() As Integer
        Get
            Return Rubrocombo_
        End Get
        Set(value As Integer)
            Rubrocombo_ = value
        End Set
    End Property

   
    
     'Fuente de datos carrerasList
        RubroComboBox.DataSource = RubroList
        'Miembro para mostrar carreras
        RubroComboBox.DisplayMember = "Descripcion"
        'Miembro de valor Id.
        RubroComboBox.ValueMember = "Id"
        'El valor seleccionado del combo
        RubroComboBox.SelectedValue = Rubrocombo_
End Class