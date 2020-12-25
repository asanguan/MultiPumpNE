Option Strict Off
Option Explicit Off
Module MsgSub
    Public Function MsgBoxSp(ByVal o_Owner As Object,
                             ByVal o_Prompt As String,
                             Optional ByVal o_Buttons As MsgBoxStyle = MsgBoxStyle.OkOnly,
                             Optional ByVal o_Title As String = "",
                             Optional ByVal o_Sec As Short = 0) _
                             As MsgBoxResult
        o_Title = My.Application.Info.AssemblyName
        p_Buttons = o_Buttons
        p_Sec = o_Sec
        If o_Title = vbNullString Then
            MsgBoxSp = MsgBox(o_Prompt, o_Buttons)
        Else
            MsgBoxSp = MsgBox(o_Prompt, o_Buttons, o_Title)
        End If
    End Function
End Module
