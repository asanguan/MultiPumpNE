Imports Transitions
Public Class SlidePaneltoPanel
    Public Event Closed As EventHandler
    Public Event Shown As EventHandler

    Private Sub owner_Resize(Sender As Object, e As EventArgs)
        Resizeform()
    End Sub

    Private Sub Resizeform()
        Me.Width = _owner.Width
        Me.Height = _owner.Height - 77
        Me.Location = New Point(If(_loaded, 0, _owner.Width), 50)
    End Sub

    Public Sub Swipe(Optional ByVal show As Boolean = False)
        Me.Visible = True
        Dim _transition As Transition = New Transitions.Transition(New TransitionType_EaseInEaseOut(500))
        _transition.add(Me, "Left", IIf(show, 0, Me.Width))
        _transition.run()

        While Me.Left <> IIf(show, 0, Me.Width)
            Application.DoEvents()
        End While

        If Not show Then
            RaiseEvent Closed(Me, New EventArgs)
            RemoveHandler _owner.Resize, AddressOf owner_Resize
            _owner.Controls.Remove(Me)
            Me.Dispose()
        Else
            _loaded = True
            Resizeform()
            RaiseEvent Shown(Me, New EventArgs)
        End If
    End Sub

    Private Sub SlidePanel_Click(sender As Object, e As EventArgs) Handles Me.Click
        Swipe(False)
    End Sub
End Class
