Option Strict Off
Option Explicit On

Module File
#Region "Global Variables"
    Public Const DatExt As String = ".LDD"
    Const DataFileID As String = "##LD Data File"
    Const DataFileSt As String = "##LD Data Start"
    Const DataFileEd As String = "##LD Data End"
    Const DataConfID As String = "##LD Data Confs"
    Const DataTermID As String = "##LD Data Terms"
    Const DataCharID As String = "##LD Data Chars"
    Const DataViewID As String = "##LD Data Views"
    Public gFilePath As String              '---'
    Public Const FILE_ATTRIBUTE_DIRECTORY As Integer = &H10
#End Region

    Function SelLoadFileM(ByVal FPath As String, ByVal FName As String, ByVal Filter_Renamed As String, ByVal FilterIdx As Short) As String
        On Error GoTo ErrHandler
        frmDlg.dlgComOpen.ShowReadOnly = False
        frmDlg.dlgComOpen.CheckFileExists = True
        frmDlg.dlgComOpen.Multiselect = True
        frmDlg.dlgComOpen.Filter = Filter_Renamed
        frmDlg.dlgComOpen.FilterIndex = FilterIdx
        frmDlg.dlgComOpen.InitialDirectory = FPath
        frmDlg.dlgComOpen.FileName = FName
        frmDlg.dlgComOpen.ShowDialog()
        SelLoadFileM = frmDlg.dlgComOpen.FileName
        frmDlg.Close()
        Exit Function

ErrHandler:
        SelLoadFileM = ""
        frmDlg.Close()
    End Function

    Function ExistFile(ByRef FName As String) As Short
        Dim s As String
        ExistFile = True
        s = FName
        On Error GoTo ErrExistFile
        If s <> "" And s.IndexOf("\") < 0 Then
            s = DataFolder & "\" & s
        End If
        If s <> "" And Dir(s) <> "" Then Exit Function
        GoTo QuitExistFile
ErrExistFile:
        MsgBoxSp(Nothing, Err.Number & " " & Err.Description)
        Resume QuitExistFile
QuitExistFile:
        ExistFile = False
    End Function
End Module
