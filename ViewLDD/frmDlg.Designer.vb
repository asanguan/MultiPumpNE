<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDlg
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public dlgComOpen As System.Windows.Forms.OpenFileDialog
    Public dlgComSave As System.Windows.Forms.SaveFileDialog
    Public dlgComFont As System.Windows.Forms.FontDialog
    Public dlgComColor As System.Windows.Forms.ColorDialog
    Public dlgComPrint As System.Windows.Forms.PrintDialog

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDlg))
        Me.dlgComOpen = New System.Windows.Forms.OpenFileDialog
        Me.dlgComSave = New System.Windows.Forms.SaveFileDialog
        Me.dlgComFont = New System.Windows.Forms.FontDialog
        Me.dlgComColor = New System.Windows.Forms.ColorDialog
        Me.dlgComPrint = New System.Windows.Forms.PrintDialog
        Me.SuspendLayout()
        '
        'frmDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 161)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CommonDialog"
        Me.ResumeLayout(False)

    End Sub
End Class
