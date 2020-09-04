Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports MetroFramework

Public Class frmMain
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTest.Text = myLocalization.My.Resources.Components.mnuOpen
        lblLanguage.Text = My.Settings.Language

        'Button1.Font = New Font("Webdings", 11.0F)
        'btnLeftdoor.Font = New Font("Webdings", 11.0F)

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
        mnuSettings.Text = myLocalization.My.Resources.Components.mnuSettings
        mnuTheme.Text = myLocalization.My.Resources.Components.mnuTheme
        mnuLanguage.Text = myLocalization.My.Resources.Components.mnuLanguage
#End Region
    End Sub

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

    Private Sub mlnLB2_Click(sender As Object, e As EventArgs) Handles mlnLB2.Click
        mcmLB2.Show(mlnLB2, 40, mlnLB2.Height - 100)
    End Sub

    Private Sub mnuLanguage_Click(sender As Object, e As EventArgs) Handles mnuLanguage.Click
        'Dim cul As New Globalization.CultureInfo(My.Settings.Language)

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
End Class