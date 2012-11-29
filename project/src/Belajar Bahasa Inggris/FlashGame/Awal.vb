Public Class Awal

    Private Sub Awal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Mulai.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Mulai.Show()
        End If
    End Sub

    Private Sub Mulai_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Mulai.LinkClicked
        Me.Hide()
        Profil.Show()
    End Sub
End Class
