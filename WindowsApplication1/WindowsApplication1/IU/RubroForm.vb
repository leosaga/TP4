Public Class RubroForm
    Dim RubrosList As New RubrosCollection

    Dim operacion_ As String
    Dim MiRubro As New Rubroclass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As String
        Get
            Return indice_
        End Get
        Set(ByVal value As String)

            indice_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        MiCarrera.Descripcion = DescripcionTextBox.Text

        If operacion <> "Agregar" Then
            MiCarrera.Id = CInt(IdTextBox.Text)
        End If

        Select Case operacion_

            Case "Agregar"
                carrerasList.InsertarCarrera(MiCarrera)

            Case "Modificar"
                carrerasList.ActualizarCarrera(MiCarrera)
                'CarrerasGrid.DataGridView1.Refresh()

            Case "Eliminar"
                carrerasList.EliminarCarrera(MiCarrera)

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

End Class