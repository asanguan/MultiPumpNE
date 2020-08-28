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

    End Sub
End Class