Option Strict Off
Option Explicit On
Module DEFINE
    Public Enum eDataType
        DataTypeNone = 0
        DataTypeIL = 1
        DataTypeWLin = 2
        DataTypeWLog = 3
        DataTypeTemp = 4
        DataTypeXtalk = 5
        DataTypeIopWLog = 6
        DataTypeTsIL = 7
        DataTypeTsWLog = 8
    End Enum

    Public Structure cfg
        Dim Key As String
        Dim dat As Object
        Sub Initialize()

        End Sub
    End Structure

    Public Structure cfgs
        Dim Index1, Index2, Index3, Index4, Index5 As Short
        Dim Mark1, Mark2, Mark3, Mark4, Mark5 As Short
        Dim PartsNo, LotNo, SerialNo As String
        Dim ProcName, ProcNo, ProcSerial, Operator_Renamed, DateTime As String
        Dim nMeasure, nStepIndex As Short
        Dim Confs(), Terms(), Chars(), Views() As cfg
        Sub Initialize()

        End Sub
    End Structure

End Module
