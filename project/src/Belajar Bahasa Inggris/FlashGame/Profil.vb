Public Class Profil

    Private Sub newPlayer_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles playerBaru.LinkClicked
        newPlayer.Text = "New Player"
        newPlayer.Show()
    End Sub

    Private Sub Profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukakoneksi()
        DataGridView1.DataSource = Koneksi.tampil("select * from nama")
    End Sub

    Private Sub Rename_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RenamePlayer.LinkClicked
        Try
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                rename = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                newPlayer.TextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                newPlayer.Text = "Rename"
                newPlayer.Show()
            End If
        Catch ex As Exception
            MsgBox("data kosong", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Delete_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Delete.LinkClicked
        Try
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                Koneksi.hapus("delete from nama where nama = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value + "'")
                DataGridView1.DataSource = Koneksi.tampil("select * from nama")
            End If
        Catch ex As Exception
            MsgBox("data belum dipilih", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                If DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 1 Then
                    lev = 1
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 2 Then
                    lev = 2
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 3 Then
                    lev = 3
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 4 Then
                    lev = 4
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 5 Then
                    lev = 5
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                End If
                leve = lev
                Level.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("data kosong", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Bantuan.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub
End Class