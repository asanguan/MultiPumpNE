<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlOne
    Inherits SlidePanel

    Sub New(owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.StyleManager.Update
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.SuspendLayout()
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(177, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String() {"MetroTextBox1"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(204, 302)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(207, 31)
        Me.MetroTextBox1.TabIndex = 3
        Me.MetroTextBox1.Text = "MetroTextBox1"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(204, 35)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(207, 261)
        Me.MetroProgressBar1.TabIndex = 2
        '
        'pnlOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Name = "pnlOne"
        Me.Size = New System.Drawing.Size(585, 400)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
End Class
