﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlidePaneltoPanel
    Inherits MetroFramework.Controls.MetroUserControl

    Dim _owner As Panel = Nothing
    Dim _loaded As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(owner As Panel)

        ' This call is required by the designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.New()
        Me.Visible = False

        _owner = owner
        owner.Controls.Add(Me)
        Me.BringToFront()
        AddHandler owner.Resize, AddressOf owner_Resize

        Resizeform()
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
        'components = New System.ComponentModel.Container()
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.SuspendLayout()
        '
        'Slide Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "SlidePanel"
        Me.ResumeLayout(False)
    End Sub

End Class
