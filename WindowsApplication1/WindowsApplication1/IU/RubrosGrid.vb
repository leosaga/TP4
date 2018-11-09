Public Class RubrosGrid



    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If
        RubroForm.operacion = "Modificar"
        RubroForm.Text = "modificar Rubro"
        RubroForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        RubroForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index
        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub


    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        RubroForm.operacion = "Agregar"
        RubroForm.Text = "Agregar  Rubro"

        RubroForm.Show()
    End Sub

    Private Sub Salir_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()
    End Sub

    Private Sub Eliminar_Click_1(sender As Object, e As EventArgs) Handles Eliminar.Click
        'Determina si existen filas en el DataGridView

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminaar.")
            Exit Sub
        End If

        RubroForm.operacion = "Eliminar"
        RubroForm.Text = "Eliminar Rubro"
        RubroForm.indice = DataGridView1.CurrentRow.Index
        llenarRubroform()
        RubroForm.Show()
    End Sub

    Private Sub llenarRubroform()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        RubroForm.IdText.Text = RubroList.Item(fila).Id
        RubroForm.DescripcionText.Text = RubroList.Item(fila).Descripcion


    End Sub

End Class




