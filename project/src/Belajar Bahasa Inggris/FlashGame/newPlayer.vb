Public Class newPlayer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Text = "New Player" Then
            Koneksi.tambah("insert into nama (nama, tingkat) values ('" + TextBox1.Text + "', '1')")
            MsgBox("Data telah ditambahkan", MsgBoxStyle.Information)
        ElseIf Me.Text = "Rename" Then
            Koneksi.tambah("update nama set nama = '" + TextBox1.Text + "' where nama = '" + rename + "'")
            MsgBox("Data telah diubah", MsgBoxStyle.Information)
        End If
        Profil.DataGridView1.DataSource = Koneksi.tampil("select * from nama")
        Me.Close()
    End Sub
End Class