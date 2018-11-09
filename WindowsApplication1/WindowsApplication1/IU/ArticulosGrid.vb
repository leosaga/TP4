Public Class ArticulosGrid
    Private Sub ArticulosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True
        Me.Dispose()

    End Sub

    Private Sub ArticulosGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArticuloComboBox.DataSource = RubrosList.TraerRubros()
        ArticuloComboBox.displayMenber = "Descripcion"
        ArticuloComboBox.valueMember = "Id"

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        'boton modificar
        ArticuloForm.operacion = "Modificar"
        ArticuloForm.Text = "Modificar Articulo"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        RubroForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

        'Coloreamos la fila de nuevo despues de modificar.
        If ArticuloList.Item(fila).Descripcion Then
            DataGridView1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.Red
        Else
            DataGridView1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.White
        End If

    End Sub


    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True
        Me.Dispose()


    End Sub

    Private Sub FiltroButton_Click(sender As Object, e As EventArgs) Handles FiltroButton.Click
        ArticulosCollectionBingSource.datasource = ArticulosList.TraerArticulos(ComboBox.SelectedValue)

        'Obtiene el Id seleccionando en el Combobox1.
        Dim IdRubro As Integer = CInt(ArticuloCombo.ComboBox.SelectedValue)

        'Quita la seleccion del contenido del Combobox
        ArticuloCombo.SelectionLength = 0


        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub
    Private Sub llenarform()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'funcion que llena la grilla con los datos de base de datos
        ArticuloForm.IdText.Text = ArticuloList.Item(fila).Id
        ArticuloForm.DescripcionText.Text = ArticuloList.Item(fila).Descripcion
        ArticuloForm.RubroCombo = ArticuloList.Item(fila).IdRubro

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        ArticuloForm.operacion = "Agregar"
        ArticuloForm.Text = "Agregar  Articulo"

        ArticuloForm.Show()
    End Sub

    End Sub
End Class