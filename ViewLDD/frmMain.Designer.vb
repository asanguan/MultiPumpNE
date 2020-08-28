<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblLanguage = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.MetroDropDownButton1 = New MetroFramework.Controls.MetroDropDownButton()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mseMain = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.btnDoorleft = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLanguage
        '
        resources.ApplyResources(Me.lblLanguage, "lblLanguage")
        Me.lblLanguage.Name = "lblLanguage"
        '
        'btnTest
        '
        resources.ApplyResources(Me.btnTest, "btnTest")
        Me.btnTest.Name = "btnTest"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'MetroDropDownButton1
        '
        resources.ApplyResources(Me.MetroDropDownButton1, "MetroDropDownButton1")
        Me.MetroDropDownButton1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.MetroDropDownButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroDropDownButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroDropDownButton1.Name = "MetroDropDownButton1"
        Me.MetroDropDownButton1.UseSelectable = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        resources.ApplyResources(Me.MetroContextMenu1, "MetroContextMenu1")
        '
        'msmMain
        '
        Me.msmMain.Owner = Me
        Me.msmMain.Style = MetroFramework.MetroColorStyle.Pink
        Me.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel1
        '
        resources.ApplyResources(Me.MetroPanel1, "MetroPanel1")
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        resources.ApplyResources(Me.MetroPanel2, "MetroPanel2")
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'btnDoorleft
        '
        resources.ApplyResources(Me.btnDoorleft, "btnDoorleft")
        Me.btnDoorleft.BackColor = System.Drawing.Color.Transparent
        Me.btnDoorleft.FlatAppearance.BorderSize = 0
        Me.btnDoorleft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnDoorleft.ForeColor = System.Drawing.Color.Black
        Me.btnDoorleft.Name = "btnDoorleft"
        Me.btnDoorleft.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.btnDoorleft)
        Me.Panel3.Name = "Panel3"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.ViewLDD.My.Resources.Resources.LDDVIEWico
        Me.BackImagePadding = New System.Windows.Forms.Padding(3)
        Me.BackMaxSize = 24
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroDropDownButton1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblLanguage)
        Me.Name = "frmMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.TransparencyKey = System.Drawing.Color.Empty
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLanguage As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents MetroDropDownButton1 As MetroFramework.Controls.MetroDropDownButton
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Private WithEvents mseMain As MetroFramework.Components.MetroStyleExtender
    Private WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnDoorleft As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
