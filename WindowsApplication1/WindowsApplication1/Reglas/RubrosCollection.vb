Public ﻿Imports System.ComponentModel
Imports System.Text

Public Class RubrosCollection


    Inherits BindingList(Of RubroClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New RubroClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each rubros In Me
            If prop.GetValue(rubros).Equals(key) Then
                Return Me.IndexOf(rubros)
            End If
        Next

        Return -1
    End Function

    Public Function TraerRubros() As RubrosCollection

        If Me.Items.Count > 0 Then Me.ClearItems()

        'crea la intancia de base de datos
        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiRubro As RubroClass

        ObjBaseDatos.objTabla = "Rubros"
        'devuelve los datos de la base de dato
        MiDataTable = ObjBaseDatos.TraerTodo
        'por cada dr (fila)llena cada rubro

        For Each dr As DataRow In MiDataTable.Rows
            'crea la instancia por cada campo
            MiRubro = New RubroClass

            MiRubro.Id = CInt(dr("Id"))
            MiRubro.Descripcion = dr("Descripcion")

            Me.Add(MiRubro)

        Next

        Return Me

    End Function

    Public Sub InsertarRubro(ByVal MiRubro As RubroClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla rubros 
        ObjBasedeDato.objTabla = "Rubros"

        Dim vsql As New StringBuilder
        vsql.Append("(Descripcion)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiRubro.Descripcion & "')")

        MiRubro.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiRubro.Id = 0 Then
            MsgBox("No fue posible agregar el Rubro ")
            Exit Sub
        End If

        Me.Add(MiRubro)

    End Sub

    Public Sub EliminarRubro(ByVal MiRubro As RubroClass)

        ' Instancio en el objeto BaseDatosClass para accede a la base Fechas
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Rubros"

        For Each articulo In articulosList

            'ejecuta el método base eliminar 
            Dim resultado As Boolean

            resultado = objBaseDatos.Eliminar(articulo.Id)

            If Not resultado Then
                MessageBox.Show("No fue posible eliminar el Rubro ")
                Exit Sub
            End If

        Next

        Me.ClearItems()

    End Sub

    Public Sub ActualizarRubro(ByVal MiRubro As RubroClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base Rubros.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Rubros"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiPersona.Id.ToString & "'")
        vSQL.Append("Descripcion='" & MiRubro.Descripcion & "'")
        'vSQL.Append(",FechaDesde='" & MiRubro.FechaDesde.ToString & "'")
        'vSQL.Append(",FechaHasta='" & MiRubro.FechaHasta.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiRubro.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el Rubro ")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un Rubro.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiRubro)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiRubro.Id)) = MiRubro

    End Sub

End Class
