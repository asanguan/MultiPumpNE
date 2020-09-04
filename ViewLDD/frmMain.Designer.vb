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
        Me.mcmTitleMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mseMain = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.btnLeftDoor = New System.Windows.Forms.Button()
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mpnLeftMenu = New MetroFramework.Controls.MetroPanel()
        Me.mlnLT1 = New MetroFramework.Controls.MetroLink()
        Me.mlnLT2 = New MetroFramework.Controls.MetroLink()
        Me.mlnLT3 = New MetroFramework.Controls.MetroLink()
        Me.mlnLT4 = New MetroFramework.Controls.MetroLink()
        Me.mlnLB1 = New MetroFramework.Controls.MetroLink()
        Me.mlnLB2 = New MetroFramework.Controls.MetroLink()
        Me.mtiLT1 = New MetroFramework.Controls.MetroTile()
        Me.mtiLT2 = New MetroFramework.Controls.MetroTile()
        Me.mtiLT3 = New MetroFramework.Controls.MetroTile()
        Me.mtiLT4 = New MetroFramework.Controls.MetroTile()
        Me.mtiLB1 = New MetroFramework.Controls.MetroTile()
        Me.mtiLB2 = New MetroFramework.Controls.MetroTile()
        Me.mpnLeftDoor = New MetroFramework.Controls.MetroPanel()
        Me.pnlLeftDoorL = New System.Windows.Forms.Panel()
        Me.pnlLeftDoorR = New System.Windows.Forms.Panel()
        Me.mpnLeftContent = New MetroFramework.Controls.MetroPanel()
        Me.mpnRightMenu = New MetroFramework.Controls.MetroPanel()
        Me.mlnRT1 = New MetroFramework.Controls.MetroLink()
        Me.mlnRT2 = New MetroFramework.Controls.MetroLink()
        Me.mlnRT3 = New MetroFramework.Controls.MetroLink()
        Me.mlnRT4 = New MetroFramework.Controls.MetroLink()
        Me.mtiRT1 = New MetroFramework.Controls.MetroTile()
        Me.mtiRT2 = New MetroFramework.Controls.MetroTile()
        Me.mtiRT3 = New MetroFramework.Controls.MetroTile()
        Me.mtiRT4 = New MetroFramework.Controls.MetroTile()
        Me.mpnRightContent = New MetroFramework.Controls.MetroPanel()
        Me.mpnMain = New MetroFramework.Controls.MetroPanel()
        Me.mpnData = New MetroFramework.Controls.MetroPanel()
        Me.mtlTitleMenu1 = New MetroFramework.Controls.MetroLink()
        Me.mtlTitleMenu2 = New MetroFramework.Controls.MetroLink()
        Me.mtlTitleMenu3 = New MetroFramework.Controls.MetroLink()
        Me.mtlTitleMenu4 = New MetroFramework.Controls.MetroLink()
        Me.mcmTitleMenu2 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mnuChangePN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangeLN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangeSN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDeleteCard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mcmTitleMenu3 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mnuViewTerm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewChars = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mcmTitleMenu4 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMark = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWrite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWriteNum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mcmLB2 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mcmTitleMenu1.SuspendLayout()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mpnLeftMenu.SuspendLayout()
        Me.mpnLeftDoor.SuspendLayout()
        Me.mpnRightMenu.SuspendLayout()
        Me.mpnData.SuspendLayout()
        Me.mcmTitleMenu2.SuspendLayout()
        Me.mcmTitleMenu3.SuspendLayout()
        Me.mcmTitleMenu4.SuspendLayout()
        Me.mcmLB2.SuspendLayout()
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
        'mcmTitleMenu1
        '
        Me.mcmTitleMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.mcmTitleMenu1, "mcmTitleMenu1")
        Me.mcmTitleMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcmTitleMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuSave, Me.mnuClose, Me.ToolStripMenuItem4, Me.mnuExit})
        Me.mcmTitleMenu1.Name = "MetroContextMenu1"
        Me.mcmTitleMenu1.ShowImageMargin = False
        '
        'mnuOpen
        '
        Me.mnuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuOpen.Name = "mnuOpen"
        resources.ApplyResources(Me.mnuOpen, "mnuOpen")
        '
        'mnuSave
        '
        Me.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSave.Name = "mnuSave"
        resources.ApplyResources(Me.mnuSave, "mnuSave")
        '
        'mnuClose
        '
        Me.mnuClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuClose.Name = "mnuClose"
        resources.ApplyResources(Me.mnuClose, "mnuClose")
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        '
        'mnuExit
        '
        Me.mnuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuExit.Name = "mnuExit"
        resources.ApplyResources(Me.mnuExit, "mnuExit")
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
        Me.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark
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
        'mtiLT1
        '
        Me.mtiLT1.ActiveControl = Nothing
        Me.mtiLT1.ContextMenuStrip = Me.mcmTitleMenu1
        resources.ApplyResources(Me.mtiLT1, "mtiLT1")
        Me.mtiLT1.Name = "mtiLT1"
        Me.mtiLT1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLT1.UseSelectable = True
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
        'mtiLB1
        '
        Me.mtiLB1.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiLB1, "mtiLB1")
        Me.mtiLB1.Name = "mtiLB1"
        Me.mtiLB1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLB1.UseSelectable = True
        '
        'mtiLB2
        '
        Me.mtiLB2.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiLB2, "mtiLB2")
        Me.mtiLB2.Name = "mtiLB2"
        Me.mtiLB2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiLB2.UseSelectable = True
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
        'mpnRightMenu
        '
        Me.mpnRightMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mpnRightMenu.Controls.Add(Me.mlnRT1)
        Me.mpnRightMenu.Controls.Add(Me.mlnRT2)
        Me.mpnRightMenu.Controls.Add(Me.mlnRT3)
        Me.mpnRightMenu.Controls.Add(Me.mlnRT4)
        Me.mpnRightMenu.Controls.Add(Me.mtiRT1)
        Me.mpnRightMenu.Controls.Add(Me.mtiRT2)
        Me.mpnRightMenu.Controls.Add(Me.mtiRT3)
        Me.mpnRightMenu.Controls.Add(Me.mtiRT4)
        resources.ApplyResources(Me.mpnRightMenu, "mpnRightMenu")
        Me.mpnRightMenu.HorizontalScrollbarBarColor = True
        Me.mpnRightMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnRightMenu.HorizontalScrollbarSize = 10
        Me.mpnRightMenu.Name = "mpnRightMenu"
        Me.mpnRightMenu.VerticalScrollbarBarColor = True
        Me.mpnRightMenu.VerticalScrollbarHighlightOnWheel = False
        Me.mpnRightMenu.VerticalScrollbarSize = 10
        '
        'mlnRT1
        '
        Me.mlnRT1.AllowDrop = True
        Me.mlnRT1.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnRT1.ImageSize = 32
        resources.ApplyResources(Me.mlnRT1, "mlnRT1")
        Me.mlnRT1.Name = "mlnRT1"
        Me.mlnRT1.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnRT1.UseSelectable = True
        '
        'mlnRT2
        '
        Me.mlnRT2.AllowDrop = True
        Me.mlnRT2.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnRT2.ImageSize = 32
        resources.ApplyResources(Me.mlnRT2, "mlnRT2")
        Me.mlnRT2.Name = "mlnRT2"
        Me.mlnRT2.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnRT2.UseSelectable = True
        '
        'mlnRT3
        '
        Me.mlnRT3.AllowDrop = True
        Me.mlnRT3.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnRT3.ImageSize = 32
        resources.ApplyResources(Me.mlnRT3, "mlnRT3")
        Me.mlnRT3.Name = "mlnRT3"
        Me.mlnRT3.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnRT3.UseSelectable = True
        '
        'mlnRT4
        '
        Me.mlnRT4.AllowDrop = True
        Me.mlnRT4.Image = Global.ViewLDD.My.Resources.Resources.mnuSetting_focus
        Me.mlnRT4.ImageSize = 32
        resources.ApplyResources(Me.mlnRT4, "mlnRT4")
        Me.mlnRT4.Name = "mlnRT4"
        Me.mlnRT4.NoFocusImage = Global.ViewLDD.My.Resources.Resources.mnuSetting_nofocus
        Me.mlnRT4.UseSelectable = True
        '
        'mtiRT1
        '
        Me.mtiRT1.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiRT1, "mtiRT1")
        Me.mtiRT1.Name = "mtiRT1"
        Me.mtiRT1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiRT1.UseSelectable = True
        '
        'mtiRT2
        '
        Me.mtiRT2.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiRT2, "mtiRT2")
        Me.mtiRT2.Name = "mtiRT2"
        Me.mtiRT2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiRT2.UseSelectable = True
        '
        'mtiRT3
        '
        Me.mtiRT3.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiRT3, "mtiRT3")
        Me.mtiRT3.Name = "mtiRT3"
        Me.mtiRT3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiRT3.UseSelectable = True
        '
        'mtiRT4
        '
        Me.mtiRT4.ActiveControl = Nothing
        resources.ApplyResources(Me.mtiRT4, "mtiRT4")
        Me.mtiRT4.Name = "mtiRT4"
        Me.mtiRT4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtiRT4.UseSelectable = True
        '
        'mpnRightContent
        '
        resources.ApplyResources(Me.mpnRightContent, "mpnRightContent")
        Me.mpnRightContent.HorizontalScrollbarBarColor = True
        Me.mpnRightContent.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnRightContent.HorizontalScrollbarSize = 10
        Me.mpnRightContent.Name = "mpnRightContent"
        Me.mpnRightContent.VerticalScrollbarBarColor = True
        Me.mpnRightContent.VerticalScrollbarHighlightOnWheel = False
        Me.mpnRightContent.VerticalScrollbarSize = 10
        '
        'mpnMain
        '
        resources.ApplyResources(Me.mpnMain, "mpnMain")
        Me.mpnMain.HorizontalScrollbarBarColor = True
        Me.mpnMain.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnMain.HorizontalScrollbarSize = 10
        Me.mpnMain.Name = "mpnMain"
        Me.mpnMain.VerticalScrollbarBarColor = True
        Me.mpnMain.VerticalScrollbarHighlightOnWheel = False
        Me.mpnMain.VerticalScrollbarSize = 10
        '
        'mpnData
        '
        resources.ApplyResources(Me.mpnData, "mpnData")
        Me.mpnData.Controls.Add(Me.btnTest)
        Me.mpnData.Controls.Add(Me.lblLanguage)
        Me.mpnData.HorizontalScrollbarBarColor = True
        Me.mpnData.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnData.HorizontalScrollbarSize = 10
        Me.mpnData.Name = "mpnData"
        Me.mpnData.VerticalScrollbarBarColor = True
        Me.mpnData.VerticalScrollbarHighlightOnWheel = False
        Me.mpnData.VerticalScrollbarSize = 10
        '
        'mtlTitleMenu1
        '
        Me.mtlTitleMenu1.BackColor = System.Drawing.Color.Transparent
        Me.mtlTitleMenu1.ContextMenuStrip = Me.mcmTitleMenu1
        Me.mtlTitleMenu1.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlTitleMenu1.FontWeight = MetroFramework.MetroLinkWeight.Regular
        resources.ApplyResources(Me.mtlTitleMenu1, "mtlTitleMenu1")
        Me.mtlTitleMenu1.Name = "mtlTitleMenu1"
        Me.mtlTitleMenu1.UseCustomBackColor = True
        Me.mtlTitleMenu1.UseSelectable = True
        '
        'mtlTitleMenu2
        '
        Me.mtlTitleMenu2.BackColor = System.Drawing.Color.Transparent
        Me.mtlTitleMenu2.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlTitleMenu2.FontWeight = MetroFramework.MetroLinkWeight.Regular
        resources.ApplyResources(Me.mtlTitleMenu2, "mtlTitleMenu2")
        Me.mtlTitleMenu2.Name = "mtlTitleMenu2"
        Me.mtlTitleMenu2.UseCustomBackColor = True
        Me.mtlTitleMenu2.UseSelectable = True
        '
        'mtlTitleMenu3
        '
        Me.mtlTitleMenu3.BackColor = System.Drawing.Color.Transparent
        Me.mtlTitleMenu3.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlTitleMenu3.FontWeight = MetroFramework.MetroLinkWeight.Regular
        resources.ApplyResources(Me.mtlTitleMenu3, "mtlTitleMenu3")
        Me.mtlTitleMenu3.Name = "mtlTitleMenu3"
        Me.mtlTitleMenu3.UseCustomBackColor = True
        Me.mtlTitleMenu3.UseSelectable = True
        '
        'mtlTitleMenu4
        '
        Me.mtlTitleMenu4.BackColor = System.Drawing.Color.Transparent
        Me.mtlTitleMenu4.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlTitleMenu4.FontWeight = MetroFramework.MetroLinkWeight.Regular
        resources.ApplyResources(Me.mtlTitleMenu4, "mtlTitleMenu4")
        Me.mtlTitleMenu4.Name = "mtlTitleMenu4"
        Me.mtlTitleMenu4.UseCustomBackColor = True
        Me.mtlTitleMenu4.UseSelectable = True
        '
        'mcmTitleMenu2
        '
        Me.mcmTitleMenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.mcmTitleMenu2, "mcmTitleMenu2")
        Me.mcmTitleMenu2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcmTitleMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChangePN, Me.mnuChangeLN, Me.mnuChangeSN, Me.ToolStripSeparator1, Me.mnuDeleteCard})
        Me.mcmTitleMenu2.Name = "MetroContextMenu1"
        Me.mcmTitleMenu2.ShowImageMargin = False
        '
        'mnuChangePN
        '
        Me.mnuChangePN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuChangePN.Name = "mnuChangePN"
        resources.ApplyResources(Me.mnuChangePN, "mnuChangePN")
        '
        'mnuChangeLN
        '
        Me.mnuChangeLN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuChangeLN.Name = "mnuChangeLN"
        resources.ApplyResources(Me.mnuChangeLN, "mnuChangeLN")
        '
        'mnuChangeSN
        '
        Me.mnuChangeSN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuChangeSN.Name = "mnuChangeSN"
        resources.ApplyResources(Me.mnuChangeSN, "mnuChangeSN")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'mnuDeleteCard
        '
        Me.mnuDeleteCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuDeleteCard.Name = "mnuDeleteCard"
        resources.ApplyResources(Me.mnuDeleteCard, "mnuDeleteCard")
        '
        'mcmTitleMenu3
        '
        Me.mcmTitleMenu3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.mcmTitleMenu3, "mcmTitleMenu3")
        Me.mcmTitleMenu3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcmTitleMenu3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewTerm, Me.mnuViewChars, Me.mnuViewAbout})
        Me.mcmTitleMenu3.Name = "MetroContextMenu1"
        Me.mcmTitleMenu3.ShowImageMargin = False
        '
        'mnuViewTerm
        '
        Me.mnuViewTerm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuViewTerm.Name = "mnuViewTerm"
        resources.ApplyResources(Me.mnuViewTerm, "mnuViewTerm")
        '
        'mnuViewChars
        '
        Me.mnuViewChars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuViewChars.Name = "mnuViewChars"
        resources.ApplyResources(Me.mnuViewChars, "mnuViewChars")
        '
        'mnuViewAbout
        '
        Me.mnuViewAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuViewAbout.Name = "mnuViewAbout"
        resources.ApplyResources(Me.mnuViewAbout, "mnuViewAbout")
        '
        'mcmTitleMenu4
        '
        Me.mcmTitleMenu4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.mcmTitleMenu4, "mcmTitleMenu4")
        Me.mcmTitleMenu4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcmTitleMenu4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSort, Me.mnuMark, Me.mnuGraph, Me.mnuReCalc, Me.mnuWrite, Me.mnuWriteNum})
        Me.mcmTitleMenu4.Name = "MetroContextMenu1"
        Me.mcmTitleMenu4.ShowImageMargin = False
        '
        'mnuSort
        '
        Me.mnuSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSort.Name = "mnuSort"
        resources.ApplyResources(Me.mnuSort, "mnuSort")
        '
        'mnuMark
        '
        Me.mnuMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuMark.Name = "mnuMark"
        resources.ApplyResources(Me.mnuMark, "mnuMark")
        '
        'mnuGraph
        '
        Me.mnuGraph.Name = "mnuGraph"
        resources.ApplyResources(Me.mnuGraph, "mnuGraph")
        '
        'mnuReCalc
        '
        Me.mnuReCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuReCalc.Name = "mnuReCalc"
        resources.ApplyResources(Me.mnuReCalc, "mnuReCalc")
        '
        'mnuWrite
        '
        Me.mnuWrite.Name = "mnuWrite"
        resources.ApplyResources(Me.mnuWrite, "mnuWrite")
        '
        'mnuWriteNum
        '
        Me.mnuWriteNum.Name = "mnuWriteNum"
        resources.ApplyResources(Me.mnuWriteNum, "mnuWriteNum")
        '
        'mcmLB2
        '
        Me.mcmLB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.mcmLB2, "mcmLB2")
        Me.mcmLB2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcmLB2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSettings, Me.mnuTheme, Me.mnuLanguage})
        Me.mcmLB2.Name = "MetroContextMenu1"
        Me.mcmLB2.ShowImageMargin = False
        '
        'mnuSettings
        '
        Me.mnuSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSettings.Name = "mnuSettings"
        resources.ApplyResources(Me.mnuSettings, "mnuSettings")
        '
        'mnuTheme
        '
        Me.mnuTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuTheme.Name = "mnuTheme"
        resources.ApplyResources(Me.mnuTheme, "mnuTheme")
        '
        'mnuLanguage
        '
        Me.mnuLanguage.Name = "mnuLanguage"
        resources.ApplyResources(Me.mnuLanguage, "mnuLanguage")
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = CType(resources.GetObject("$this.BackImage"), System.Drawing.Image)
        Me.BackImagePadding = New System.Windows.Forms.Padding(3)
        Me.BackMaxSize = 24
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Controls.Add(Me.mtlTitleMenu4)
        Me.Controls.Add(Me.mtlTitleMenu3)
        Me.Controls.Add(Me.mtlTitleMenu2)
        Me.Controls.Add(Me.mtlTitleMenu1)
        Me.Controls.Add(Me.mpnRightMenu)
        Me.Controls.Add(Me.mpnRightContent)
        Me.Controls.Add(Me.mpnLeftDoor)
        Me.Controls.Add(Me.mpnLeftMenu)
        Me.Controls.Add(Me.mpnLeftContent)
        Me.Controls.Add(Me.mpnData)
        Me.Controls.Add(Me.mpnMain)
        Me.Name = "frmMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.mcmTitleMenu1.ResumeLayout(False)
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mpnLeftMenu.ResumeLayout(False)
        Me.mpnLeftDoor.ResumeLayout(False)
        Me.mpnRightMenu.ResumeLayout(False)
        Me.mpnData.ResumeLayout(False)
        Me.mpnData.PerformLayout()
        Me.mcmTitleMenu2.ResumeLayout(False)
        Me.mcmTitleMenu3.ResumeLayout(False)
        Me.mcmTitleMenu4.ResumeLayout(False)
        Me.mcmLB2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLanguage As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents mcmTitleMenu1 As MetroFramework.Controls.MetroContextMenu
    Private WithEvents mseMain As MetroFramework.Components.MetroStyleExtender
    Private WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mpnLeftDoor As MetroFramework.Controls.MetroPanel
    Friend WithEvents mpnLeftMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnLeftDoor As Button
    Friend WithEvents mtiLT1 As MetroFramework.Controls.MetroTile
    Friend WithEvents pnlLeftDoorR As Panel
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
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
    Friend WithEvents mpnRightMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlnRT1 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnRT2 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnRT3 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnRT4 As MetroFramework.Controls.MetroLink
    Friend WithEvents mtiRT1 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiRT2 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiRT3 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtiRT4 As MetroFramework.Controls.MetroTile
    Friend WithEvents mpnData As MetroFramework.Controls.MetroPanel
    Friend WithEvents mpnRightContent As MetroFramework.Controls.MetroPanel
    Friend WithEvents mpnMain As MetroFramework.Controls.MetroPanel
    Friend WithEvents mtlTitleMenu1 As MetroFramework.Controls.MetroLink
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mtlTitleMenu4 As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlTitleMenu3 As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlTitleMenu2 As MetroFramework.Controls.MetroLink
    Friend WithEvents mcmTitleMenu2 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents mnuChangePN As ToolStripMenuItem
    Friend WithEvents mnuChangeLN As ToolStripMenuItem
    Friend WithEvents mnuChangeSN As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuDeleteCard As ToolStripMenuItem
    Friend WithEvents mcmTitleMenu3 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents mnuViewTerm As ToolStripMenuItem
    Friend WithEvents mnuViewChars As ToolStripMenuItem
    Friend WithEvents mnuViewAbout As ToolStripMenuItem
    Friend WithEvents mcmTitleMenu4 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents mnuSort As ToolStripMenuItem
    Friend WithEvents mnuMark As ToolStripMenuItem
    Friend WithEvents mnuReCalc As ToolStripMenuItem
    Friend WithEvents mnuWrite As ToolStripMenuItem
    Friend WithEvents mnuWriteNum As ToolStripMenuItem
    Friend WithEvents mnuGraph As ToolStripMenuItem
    Friend WithEvents mcmLB2 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents mnuSettings As ToolStripMenuItem
    Friend WithEvents mnuTheme As ToolStripMenuItem
    Friend WithEvents mnuLanguage As ToolStripMenuItem
End Class
