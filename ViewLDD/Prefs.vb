Option Strict Off
Option Explicit On
Module Prefs
    Public ParamFolder As String
    Public DataFolder As String

    Sub InitPrefs()
        Dim i As Short

        ParamFolder = My.Application.Info.DirectoryPath
        DataFolder = My.Application.Info.DirectoryPath

    End Sub
End Module
