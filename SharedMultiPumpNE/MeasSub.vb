Option Strict Off
Option Explicit On

Module MeasSub
    Public Enum eVIEWFLAG
        NoMeas = 0
        IL1 = 1
        WLin1 = 2
        WLog1 = 3
        Temp1 = 4
        Xtalk1 = 5
        IL2 = 6
        WLin2 = 7
        WLog2 = 8
        Temp2 = 9
        Xtalk2 = 10
        'Below variables are extension from VB6 code
        IL3 = 11
        WLin3 = 12
        WLog3 = 13
        Temp3 = 14
        Xtalk3 = 15
        IL4 = 16
        WLin4 = 17
        WLog4 = 18
        Temp4 = 19
        Xtalk4 = 20
        IL5 = 21
        WLin5 = 22
        WLog5 = 23
        Temp5 = 24
        Xtalk5 = 25
        IL6 = 26
        WLin6 = 27
        WLog6 = 28
        Temp6 = 29
        Xtalk6 = 30
    End Enum

    Class StringPair
        Public Key As String
        Public Value As String
        Public Sub New(ByVal _key As String, ByVal _value As String)
            Key = _key
            Value = _value
        End Sub
    End Class
End Module
