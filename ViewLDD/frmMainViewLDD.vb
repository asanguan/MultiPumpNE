Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports MetroFramework
Public Class frmMainViewLDD
    Dim LeftDoorState As DoorState
    Enum DoorState
        Close
        HalfOpen
        FullOpen
    End Enum
    Sub New()
        Dim cul As New Globalization.CultureInfo(My.Settings.Language)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Threading.Thread.CurrentThread.CurrentCulture = cul
        Threading.Thread.CurrentThread.CurrentUICulture = cul
        Globalization.CultureInfo.DefaultThreadCurrentCulture = cul
        Globalization.CultureInfo.DefaultThreadCurrentUICulture = cul

        Me.StyleManager = msmMain
        Select Case My.Settings.Theme
            Case "Dark"
                Me.StyleManager.Theme = MetroThemeStyle.Dark
            Case "Light"
                Me.StyleManager.Theme = MetroThemeStyle.Light
        End Select
        My.Settings.Theme = Me.StyleManager.Theme.ToString

    End Sub

    Private Sub frmMainViewLDD_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnTest.Text = myLocalization.My.Resources.Components.mnuOpen
        lblLanguage.Text = My.Settings.Language

#Region "Load - TitleMenu"
        mtlTitleMenu1.Text = myLocalization.My.Resources.Components.mnuFile
        mnuOpen.Text = myLocalization.My.Resources.Components.mnuOpen
        mnuSave.Text = myLocalization.My.Resources.Components.mnuSave
        mnuClose.Text = myLocalization.My.Resources.Components.mnuClose
        mnuExit.Text = myLocalization.My.Resources.Components.mnuExit

        mtlTitleMenu2.Text = myLocalization.My.Resources.Components.mnuEdit
        mnuChangePN.Text = myLocalization.My.Resources.Components.mnuChangePN
        mnuChangeLN.Text = myLocalization.My.Resources.Components.mnuChangeLN
        mnuChangeSN.Text = myLocalization.My.Resources.Components.mnuChangeSN
        mnuDeleteCard.Text = myLocalization.My.Resources.Components.mnuDeleteCard

        mtlTitleMenu3.Text = myLocalization.My.Resources.Components.mnuView
        mnuViewTerm.Text = myLocalization.My.Resources.Components.mnuViewTerm
        mnuViewChars.Text = myLocalization.My.Resources.Components.mnuViewChars
        mnuViewAbout.Text = myLocalization.My.Resources.Components.mnuViewAbout

        mtlTitleMenu4.Text = myLocalization.My.Resources.Components.mnuData
        mnuSort.Text = myLocalization.My.Resources.Components.mnuSort
        mnuMark.Text = myLocalization.My.Resources.Components.mnuMark
        mnuGraph.Text = myLocalization.My.Resources.Components.mnuGraph
        mnuReCalc.Text = myLocalization.My.Resources.Components.mnuReCalc
        mnuSort.Text = myLocalization.My.Resources.Components.mnuSort
        mnuWrite.Text = myLocalization.My.Resources.Components.mnuWrite
        mnuWriteNum.Text = myLocalization.My.Resources.Components.mnuWriteNum
#End Region

#Region "LeftMenu"
        'Left Menu Top
        Call TileReset_LT()
        'Left Menu Bottom
        mnuSettings.Text = myLocalization.My.Resources.Components.mnuSettings
        mnuTheme.Text = myLocalization.My.Resources.Components.mnuTheme
        mnuLanguage.Text = myLocalization.My.Resources.Components.mnuLanguage
        Call TileReset_LB()
        'Left Door
        Call LeftDoorClose()
#End Region

#Region "RightMenu"
        Call TileReset_RT()
#End Region

    End Sub

#Region "Subroutine to control each control state"
    Private Sub LeftDoorClose()
        mpnLeftMenu.Visible = False
        mpnLeftContent.Visible = False
        mpnLeftDoor.Visible = True
        mpnLeft.Width = My.Settings.LeftDoorWidth
        btnLeftDoor.Text = 4
        Call TileReset_LT()
        LeftDoorState = DoorState.Close
    End Sub

    Private Sub LeftDoorHalfOpen()
        mpnLeftMenu.Visible = True
        mpnLeftContent.Visible = False
        mpnLeftDoor.Visible = True
        mpnLeft.Width = My.Settings.LeftMenuWidth + My.Settings.LeftDoorWidth
        btnLeftDoor.Text = 3
        LeftDoorState = DoorState.HalfOpen
    End Sub

    Private Sub LeftDoorFullOpen()
        mpnLeftMenu.Visible = True
        mpnLeftContent.Visible = True
        mpnLeftDoor.Visible = True
        mpnLeft.Width = My.Settings.LeftMenuWidth + My.Settings.LeftContentWidth + My.Settings.LeftDoorWidth
        btnLeftDoor.Text = 3
        LeftDoorState = DoorState.FullOpen
    End Sub

    Private Sub TileReset_LT()
        For i As Integer = 0 To 3
            mtiLT(i).Visible = False
        Next
    End Sub
    Private Sub TileReset_LB()
        For i As Integer = 0 To 1
            mtiLB(i).Visible = False
        Next
    End Sub
    Private Sub TileReset_RT()
        For i As Integer = 0 To 3
            mtiRT(i).Visible = False
        Next
    End Sub
#End Region
    Private Sub btnLeftDoor_Click(sender As Object, e As EventArgs) Handles btnLeftDoor.Click
        Select Case LeftDoorState
            Case DoorState.Close
                Call LeftDoorHalfOpen()
            Case DoorState.HalfOpen
                Call LeftDoorClose()
            Case DoorState.FullOpen
                Call LeftDoorClose()
        End Select
    End Sub

#Region "Context Menu setting"
    Private Sub mtlTitleMenu1_Click(sender As Object, e As EventArgs) Handles mtlTitleMenu1.Click
        mcmTitleMenu1.Show(mtlTitleMenu1, 0, mtlTitleMenu1.Height)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mtlTitleMenu2_Click(sender As Object, e As EventArgs) Handles mtlTitleMenu2.Click
        mcmTitleMenu2.Show(mtlTitleMenu2, 0, mtlTitleMenu2.Height)
    End Sub

    Private Sub mtlTitleMenu3_Click(sender As Object, e As EventArgs) Handles mtlTitleMenu3.Click
        mcmTitleMenu3.Show(mtlTitleMenu3, 0, mtlTitleMenu3.Height)
    End Sub

    Private Sub mtlTitleMenu4_Click(sender As Object, e As EventArgs) Handles mtlTitleMenu4.Click
        mcmTitleMenu4.Show(mtlTitleMenu4, 0, mtlTitleMenu4.Height)
    End Sub

    Private Sub mlnLB1_Click(sender As Object, e As EventArgs) Handles mlnLB1.Click
        mcmLB1.Show(mlnLB1, 40, mlnLB1.Height - 100)
    End Sub
#End Region

    Private Sub mnuLanguage_Click(sender As Object, e As EventArgs) Handles mnuLanguage.Click
        Select Case My.Settings.Language
            Case "en"
                My.Settings.Language = "ja"
            Case "ja"
                My.Settings.Language = "en"
        End Select
        Application.Restart()
    End Sub

    Private Sub mnuTheme_Click(sender As Object, e As EventArgs) Handles mnuTheme.Click
        Select Case Me.StyleManager.Theme
            Case 2
                My.Settings.Theme = "Light"
            Case 1
                My.Settings.Theme = "Dark"
        End Select
        Application.Restart()
    End Sub

    Private Sub mlnLT0_Click(sender As Object, e As EventArgs) Handles mlnLT0.Click
        Call TileReset_LT()
        Call TileReset_LB()
        Call LeftDoorFullOpen()
        mtiLT(0).Visible = True
        mtiTest.Text = "Tile0 is active"
    End Sub
    Private Sub mlnLT1_Click(sender As Object, e As EventArgs) Handles mlnLT1.Click
        Call TileReset_LT()
        Call TileReset_LB()
        Call LeftDoorFullOpen()
        mtiLT(1).Visible = True
        mtiTest.Text = "Tile1 is active"
    End Sub
    Private Sub mlnLT2_Click(sender As Object, e As EventArgs) Handles mlnLT2.Click
        Call TileReset_LT()
        Call TileReset_LB()
        Call LeftDoorFullOpen()
        mtiLT(2).Visible = True
        mtiTest.Text = "Tile2 is active"
    End Sub
    Private Sub mlnLT3_Click(sender As Object, e As EventArgs) Handles mlnLT3.Click
        Call TileReset_LT()
        Call TileReset_LB()
        Call LeftDoorFullOpen()
        mtiLT(3).Visible = True
        mtiTest.Text = "Tile3 is active"
    End Sub

    Private Sub mlnLB0_Click(sender As Object, e As EventArgs) Handles mlnLB0.Click
        Call TileReset_LT()
        Call TileReset_LB()
        Call LeftDoorFullOpen()
        mtiLB(0).Visible = True
        mtiTest.Text = "Tile LB is active"
    End Sub

End Class