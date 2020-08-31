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
        Me.mcmTitleMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mseMain = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.btnLeftDoor = New System.Windows.Forms.Button()
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mpnLeftMenu = New MetroFramework.Controls.MetroPanel()
        Me.mtiLT1 = New MetroFramework.Controls.MetroTile()
        Me.mpnLeftDoor = New MetroFramework.Controls.MetroPanel()
        Me.pnlLeftDoorL = New System.Windows.Forms.Panel()
        Me.pnlLeftDoorR = New System.Windows.Forms.Panel()
        Me.mlnLT1 = New MetroFramework.Controls.MetroLink()
        Me.mtiLT2 = New MetroFramework.Controls.MetroTile()
        Me.mtiLT3 = New MetroFramework.Controls.MetroTile()
        Me.mtiLT4 = New MetroFramework.Controls.MetroTile()
        Me.mtiLB2 = New MetroFramework.Controls.MetroTile()
        Me.mtiLB1 = New MetroFramework.Controls.MetroTile()
        Me.mlnLT2 = New MetroFramework.Controls.MetroLink()
        Me.mlnLT3 = New MetroFramework.Controls.MetroLink()
        Me.mlnLT4 = New MetroFramework.Controls.MetroLink()
        Me.mlnLB2 = New MetroFramework.Controls.MetroLink()
        Me.mlnLB1 = New MetroFramework.Controls.MetroLink()
        Me.mpnLeftContent = New MetroFramework.Controls.MetroPanel()
        Me.mcmTitleMenu1.SuspendLayout()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mpnLeftMenu.SuspendLayout()
        Me.mpnLeftDoor.SuspendLayout()
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
        Me.MetroDropDownButton1.BackColor = System.Drawing.Color.Transparent
        Me.MetroDropDownButton1.ContextMenuStrip = Me.mcmTitleMenu1
        Me.MetroDropDownButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroDropDownButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroDropDownButton1.Name = "MetroDropDownButton1"
        Me.MetroDropDownButton1.SplitMenuStrip = Me.mcmTitleMenu1
        Me.MetroDropDownButton1.UseSelectable = True
        '
        'mcmTitleMenu1
        '
        Me.mcmTitleMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mcmTitleMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcmTitleMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.mcmTitleMenu1.Name = "MetroContextMenu1"
        resources.ApplyResources(Me.mcmTitleMenu1, "mcmTitleMenu1")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        '
        'btnLeftDoor
        '
        resources.ApplyResources(Me.btnLeftDoor, "btnLeftDoor")
        Me.mseMain.SetApplyMetroTheme(Me.btnLeftDoor, True)
        Me.btnLeftDoor.BackColor = System.Drawing.Color.Transparent
        Me.btnLeftDoor.FlatAppearance.BorderSize = 0
        Me.btnLeftDoor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnLeftDoor.ForeColor = System.Drawing.Color.DimGray
        Me.btnLeftDoor.Name = "btnLeftDoor"
        Me.btnLeftDoor.UseVisualStyleBackColor = False
        '
        'msmMain
        '
        Me.msmMain.Owner = Me
        Me.msmMain.Style = MetroFramework.MetroColorStyle.Pink
        '
        'mpnLeftMenu
        '
        resources.ApplyResources(Me.mpnLeftMenu, "mpnLeftMenu")
        Me.mpnLeftMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mpnLeftMenu.Controls.Add(Me.mlnLT1)
        Me.mpnLeftMenu.Controls.Add(Me.mlnLT2)
        Me.mpnLeftMenu.Controls.Add(Me.mlnLT3)
        Me.mpnLeftMenu.Controls.Add(Me.mlnLT4)
        Me.mpnLeftMenu.Controls.Add(Me.mlnLB1)
        Me.mpnLeftMenu.Controls.Add(Me.mlnLB2)
        Me.mpnLeftMenu.Controls.Add(Me.mtiLT1)
        Me.mpnLeftMenu.Controls.Add(Me.mtiLT2)
        Me.mpnLeftMenu.Controls.Add(Me.mtiLT3)
        Me.mpnLeftMenu.Controls.Add(Me.mtiLT4)
        Me.mpnLeftMenu.Controls.Add(Me.mtiLB1)
        Me.mpnLeftMenu.Controls.Add(Me.mtiLB2)
        Me.mpnLeftMenu.HorizontalScrollbarBarColor = True
        Me.mpnLeftMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnLeftMenu.HorizontalScrollbarSize = 10
        Me.mpnLeftMenu.Name = "mpnLeftMenu"
        Me.mpnLeftMenu.VerticalScrollbarBarColor = True
        Me.mpnLeftMenu.VerticalScrollbarHighlightOnWheel = False
        Me.mpnLeftMenu.VerticalScrollbarSize = 10
        '
        'mtiLT1
        '
        Me.mtiLT1.ActiveControl = Nothing
        Me.mtiLT1.ContextMenuStrip = Me.mcmTitleMenu1
        resources.ApplyResources(Me.mtiLT1, "mtiLT1")
        Me.mtiLT1.Name = "mtiLT1"
        Me.mtiLT1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLT1.UseSelectable = True
        '
        'mpnLeftDoor
        '
        resources.ApplyResources(Me.mpnLeftDoor, "mpnLeftDoor")
        Me.mpnLeftDoor.Controls.Add(Me.pnlLeftDoorL)
        Me.mpnLeftDoor.Controls.Add(Me.pnlLeftDoorR)
        Me.mpnLeftDoor.Controls.Add(Me.btnLeftDoor)
        Me.mpnLeftDoor.HorizontalScrollbarBarColor = True
        Me.mpnLeftDoor.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnLeftDoor.HorizontalScrollbarSize = 10
        Me.mpnLeftDoor.Name = "mpnLeftDoor"
        Me.mpnLeftDoor.VerticalScrollbarBarColor = True
        Me.mpnLeftDoor.VerticalScrollbarHighlightOnWheel = False
        Me.mpnLeftDoor.VerticalScrollbarSize = 10
        '
        'pnlLeftDoorL
        '
        resources.ApplyResources(Me.pnlLeftDoorL, "pnlLeftDoorL")
        Me.pnlLeftDoorL.BackColor = System.Drawing.Color.Silver
        Me.pnlLeftDoorL.Name = "pnlLeftDoorL"
        '
        'pnlLeftDoorR
        '
        resources.ApplyResources(Me.pnlLeftDoorR, "pnlLeftDoorR")
        Me.pnlLeftDoorR.BackColor = System.Drawing.Color.Silver
        Me.pnlLeftDoorR.Name = "pnlLeftDoorR"
        '
        'mlnLT1
        '
        Me.mlnLT1.AllowDrop = True
        Me.mlnLT1.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnLT1.ImageSize = 32
        resources.ApplyResources(Me.mlnLT1, "mlnLT1")
        Me.mlnLT1.Name = "mlnLT1"
        Me.mlnLT1.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnLT1.UseSelectable = True
        '
        'mtiLT2
        '
        Me.mtiLT2.ActiveControl = Nothing
        Me.mtiLT2.ContextMenuStrip = Me.mcmTitleMenu1
        resources.ApplyResources(Me.mtiLT2, "mtiLT2")
        Me.mtiLT2.Name = "mtiLT2"
        Me.mtiLT2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLT2.UseSelectable = True
        '
        'mtiLT3
        '
        Me.mtiLT3.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiLT3, "mtiLT3")
        Me.mtiLT3.Name = "mtiLT3"
        Me.mtiLT3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLT3.UseSelectable = True
        '
        'mtiLT4
        '
        Me.mtiLT4.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiLT4, "mtiLT4")
        Me.mtiLT4.Name = "mtiLT4"
        Me.mtiLT4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLT4.UseSelectable = True
        '
        'mtiLB2
        '
        Me.mtiLB2.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiLB2, "mtiLB2")
        Me.mtiLB2.Name = "mtiLB2"
        Me.mtiLB2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLB2.UseSelectable = True
        '
        'mtiLB1
        '
        Me.mtiLB1.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiLB1, "mtiLB1")
        Me.mtiLB1.Name = "mtiLB1"
        Me.mtiLB1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLB1.UseSelectable = True
        '
        'mlnLT2
        '
        Me.mlnLT2.AllowDrop = True
        Me.mlnLT2.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnLT2.ImageSize = 32
        resources.ApplyResources(Me.mlnLT2, "mlnLT2")
        Me.mlnLT2.Name = "mlnLT2"
        Me.mlnLT2.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnLT2.UseSelectable = True
        '
        'mlnLT3
        '
        Me.mlnLT3.AllowDrop = True
        Me.mlnLT3.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnLT3.ImageSize = 32
        resources.ApplyResources(Me.mlnLT3, "mlnLT3")
        Me.mlnLT3.Name = "mlnLT3"
        Me.mlnLT3.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnLT3.UseSelectable = True
        '
        'mlnLT4
        '
        Me.mlnLT4.AllowDrop = True
        Me.mlnLT4.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnLT4.ImageSize = 32
        resources.ApplyResources(Me.mlnLT4, "mlnLT4")
        Me.mlnLT4.Name = "mlnLT4"
        Me.mlnLT4.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnLT4.UseSelectable = True
        '
        'mlnLB2
        '
        Me.mlnLB2.AllowDrop = True
        resources.ApplyResources(Me.mlnLB2, "mlnLB2")
        Me.mlnLB2.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnLB2.ImageSize = 32
        Me.mlnLB2.Name = "mlnLB2"
        Me.mlnLB2.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnLB2.UseSelectable = True
        '
        'mlnLB1
        '
        Me.mlnLB1.AllowDrop = True
        resources.ApplyResources(Me.mlnLB1, "mlnLB1")
        Me.mlnLB1.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnLB1.ImageSize = 32
        Me.mlnLB1.Name = "mlnLB1"
        Me.mlnLB1.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnLB1.UseSelectable = True
        '
        'mpnLeftContent
        '
        resources.ApplyResources(Me.mpnLeftContent, "mpnLeftContent")
        Me.mpnLeftContent.HorizontalScrollbarBarColor = True
        Me.mpnLeftContent.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnLeftContent.HorizontalScrollbarSize = 10
        Me.mpnLeftContent.Name = "mpnLeftContent"
        Me.mpnLeftContent.VerticalScrollbarBarColor = True
        Me.mpnLeftContent.VerticalScrollbarHighlightOnWheel = False
        Me.mpnLeftContent.VerticalScrollbarSize = 10
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = CType(resources.GetObject("$this.BackImage"), System.Drawing.Image)
        Me.BackImagePadding = New System.Windows.Forms.Padding(3)
        Me.BackMaxSize = 24
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Controls.Add(Me.mpnLeftContent)
        Me.Controls.Add(Me.mpnLeftDoor)
        Me.Controls.Add(Me.mpnLeftMenu)
        Me.Controls.Add(Me.MetroDropDownButton1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblLanguage)
        Me.Name = "frmMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.mcmTitleMenu1.ResumeLayout(False)
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mpnLeftMenu.ResumeLayout(False)
        Me.mpnLeftDoor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLanguage As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents MetroDropDownButton1 As MetroFramework.Controls.MetroDropDownButton
    Friend WithEvents mcmTitleMenu1 As MetroFramework.Controls.MetroContextMenu
    Private WithEvents mseMain As MetroFramework.Components.MetroStyleExtender
    Private WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mpnLeftDoor As MetroFramework.Controls.MetroPanel
    Friend WithEvents mpnLeftMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnLeftDoor As Button
    Friend WithEvents mtiLT1 As MetroFramework.Controls.MetroTile
    Friend WithEvents pnlLeftDoorR As Panel
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents pnlLeftDoorL As Panel
    Friend WithEvents mlnLT1 As MetroFramework.Controls.MetroLink
    Friend WithEvents mtiLT2 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiLT3 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiLT4 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiLB1 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiLB2 As MetroFramework.Controls.MetroTile
    Friend WithEvents mlnLT2 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnLT4 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnLT3 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnLB1 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnLB2 As MetroFramework.Controls.MetroLink
    Friend WithEvents mpnLeftContent As MetroFramework.Controls.MetroPanel
End Class
