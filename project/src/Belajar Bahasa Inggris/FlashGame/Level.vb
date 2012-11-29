Public Class Level

    Private Sub Level_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If leve = 2 Then
            Level2m.Hide()
        ElseIf leve = 3 Then
            Level2m.Hide()
            Level3m.Hide()
        ElseIf leve = 4 Then
            Level2m.Hide()
            Level3m.Hide()
            Level4m.Hide()
        ElseIf leve = 5 Then
            Level2m.Hide()
            Level3m.Hide()
            Level4m.Hide()
            Level5m.Hide()
        End If
    End Sub

    Private Sub Level1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level1.Click
        lev = 1
        Game1.Show()
        Me.Close()
    End Sub

    Private Sub Level2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level2.Click
        lev = 2
        Game1.Show()
        Me.Close()
    End Sub

    Private Sub Level3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level3.Click
        lev = 3
        Game1.Show()
        Me.Close()
    End Sub

    Private Sub Level4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level4.Click
        lev = 4
        Game1.Show()
        Me.Close()
    End Sub

    Private Sub Level5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level5.Click
        lev = 5
        Game1.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Profil.Show()
        Me.Close()
    End Sub
End Class