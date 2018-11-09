Public Class MenuForm





    Private Sub ProductosButton_Click(sender As Object, e As EventArgs) Handles ProductosButton.Click

        ToolStrip1.Enabled = False

        Dim gridProductos As New ArticulosGrid

        gridProductos.MdiParent = Me

        gridProductos.Show()
    End Sub

    Private Sub RubrosButton_Click(sender As Object, e As EventArgs) Handles RubrosButton.Click

        ToolStrip1.Enabled = False

        Dim gridRubros As New RubrosGrid

        gridRubros.MdiParent = Me

        gridRubros.Show()
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click

    End Sub


End Class