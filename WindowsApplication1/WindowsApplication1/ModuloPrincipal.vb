﻿Option Strict On
Option Explicit Off

Module ModuloPrincipal



    Public ArticulosList As New ArticulosCollection
    Public RubrosList As New RubrosCollection


    Public Sub main()

        Application.Run(MenuForm)

    End Sub

End Module