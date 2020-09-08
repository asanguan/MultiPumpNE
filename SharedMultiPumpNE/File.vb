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
End Module
