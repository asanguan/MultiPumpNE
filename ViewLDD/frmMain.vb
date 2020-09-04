Imports System.Runtime.InteropServices
Imports System.Windows.Forms

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

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTest.Text = myLocalization.My.Resources.Components.mnuOpen
        lblLanguage.Text = My.Settings.Language

        'Button1.Font = New Font("Webdings", 11.0F)
        'btnLeftdoor.Font = New Font("Webdings", 11.0F)

#Region "TitleMenu"
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

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

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

#End Region
End Class