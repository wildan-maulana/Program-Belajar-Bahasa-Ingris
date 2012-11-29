Public Class Game1
    Dim menit As Integer, detik As Integer, ms As Integer, ur As Integer = 0
    Private Sub Game1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Koneksi.tampil("select * from kosakata")
        DataGridView1.Hide()
        If lev = 1 Then
            menit = 5
            detik = 0
            ms = 10
            Label1.Text = "05.00"
            Timer1.Enabled = True
            ur = 0
            Kata1.Text = DataGridView1.Item(1, ur).Value
            Label24.Text = DataGridView1.Item(0, 0).Value
            Label3.Text = DataGridView1.Item(0, 1).Value
            Label22.Text = DataGridView1.Item(0, 2).Value
            Label12.Text = DataGridView1.Item(0, 3).Value
            Label26.Text = DataGridView1.Item(0, 4).Value
            Label17.Text = DataGridView1.Item(0, 5).Value
            Label7.Text = DataGridView1.Item(0, 6).Value
            Label15.Text = DataGridView1.Item(0, 7).Value
            Label13.Text = DataGridView1.Item(0, 8).Value
            Label4.Text = DataGridView1.Item(0, 9).Value
            Label6.Text = DataGridView1.Item(0, 10).Value
            Label8.Text = DataGridView1.Item(0, 11).Value
            Label14.Text = DataGridView1.Item(0, 12).Value
            Label19.Text = DataGridView1.Item(0, 13).Value
            Label25.Text = DataGridView1.Item(0, 14).Value
            Label18.Text = DataGridView1.Item(0, 15).Value
            Label23.Text = DataGridView1.Item(0, 16).Value
            Label16.Text = DataGridView1.Item(0, 17).Value
            Label10.Text = DataGridView1.Item(0, 18).Value
            Label9.Text = DataGridView1.Item(0, 19).Value
            Label5.Text = DataGridView1.Item(0, 20).Value
            Label21.Text = DataGridView1.Item(0, 21).Value
            Label20.Text = DataGridView1.Item(0, 22).Value
            Label11.Text = DataGridView1.Item(0, 23).Value
            Label2.Text = DataGridView1.Item(0, 24).Value
        ElseIf lev = 2 Then
            menit = 4
            detik = 0
            ms = 10
            Label1.Text = "04:00"
            Timer1.Enabled = True
            ur = 25
            Kata1.Text = DataGridView1.Item(1, ur).Value
            Label2.Text = DataGridView1.Item(0, 25).Value
            Label11.Text = DataGridView1.Item(0, 26).Value
            Label5.Text = DataGridView1.Item(0, 27).Value
            Label9.Text = DataGridView1.Item(0, 28).Value
            Label10.Text = DataGridView1.Item(0, 29).Value
            Label16.Text = DataGridView1.Item(0, 30).Value
            Label23.Text = DataGridView1.Item(0, 31).Value
            Label18.Text = DataGridView1.Item(0, 32).Value
            Label25.Text = DataGridView1.Item(0, 33).Value
            Label19.Text = DataGridView1.Item(0, 34).Value
            Label14.Text = DataGridView1.Item(0, 35).Value
            Label8.Text = DataGridView1.Item(0, 36).Value
            Label6.Text = DataGridView1.Item(0, 37).Value
            Label4.Text = DataGridView1.Item(0, 38).Value
            Label13.Text = DataGridView1.Item(0, 39).Value
            Label15.Text = DataGridView1.Item(0, 40).Value
            Label7.Text = DataGridView1.Item(0, 41).Value
            Label17.Text = DataGridView1.Item(0, 42).Value
            Label26.Text = DataGridView1.Item(0, 43).Value
            Label12.Text = DataGridView1.Item(0, 44).Value
            Label21.Text = DataGridView1.Item(0, 45).Value
            Label20.Text = DataGridView1.Item(0, 46).Value
            Label22.Text = DataGridView1.Item(0, 47).Value
            Label3.Text = DataGridView1.Item(0, 48).Value
            Label24.Text = DataGridView1.Item(0, 49).Value
        ElseIf lev = 3 Then
            menit = 3
            detik = 0
            ms = 10
            Label1.Text = "03:00"
            Timer1.Enabled = True
            ur = 50
            Kata1.Text = DataGridView1.Item(1, ur).Value
            Label6.Text = DataGridView1.Item(0, 50).Value
            Label8.Text = DataGridView1.Item(0, 51).Value
            Label14.Text = DataGridView1.Item(0, 52).Value
            Label19.Text = DataGridView1.Item(0, 53).Value
            Label24.Text = DataGridView1.Item(0, 54).Value
            Label3.Text = DataGridView1.Item(0, 55).Value
            Label22.Text = DataGridView1.Item(0, 56).Value
            Label20.Text = DataGridView1.Item(0, 57).Value
            Label21.Text = DataGridView1.Item(0, 58).Value
            Label5.Text = DataGridView1.Item(0, 59).Value
            Label11.Text = DataGridView1.Item(0, 60).Value
            Label2.Text = DataGridView1.Item(0, 61).Value
            Label12.Text = DataGridView1.Item(0, 62).Value
            Label26.Text = DataGridView1.Item(0, 63).Value
            Label7.Text = DataGridView1.Item(0, 64).Value
            Label15.Text = DataGridView1.Item(0, 65).Value
            Label17.Text = DataGridView1.Item(0, 66).Value
            Label13.Text = DataGridView1.Item(0, 67).Value
            Label4.Text = DataGridView1.Item(0, 68).Value
            Label25.Text = DataGridView1.Item(0, 69).Value
            Label18.Text = DataGridView1.Item(0, 70).Value
            Label23.Text = DataGridView1.Item(0, 71).Value
            Label16.Text = DataGridView1.Item(0, 72).Value
            Label10.Text = DataGridView1.Item(0, 73).Value
            Label9.Text = DataGridView1.Item(0, 74).Value
        ElseIf lev = 4 Then
            menit = 2
            detik = 0
            ms = 10
            Label1.Text = "02:00"
            Timer1.Enabled = True
            ur = 99
            Kata1.Text = DataGridView1.Item(1, ur).Value
            Label24.Text = DataGridView1.Item(0, 99).Value
            Label3.Text = DataGridView1.Item(0, 98).Value
            Label22.Text = DataGridView1.Item(0, 97).Value
            Label12.Text = DataGridView1.Item(0, 96).Value
            Label26.Text = DataGridView1.Item(0, 95).Value
            Label17.Text = DataGridView1.Item(0, 94).Value
            Label7.Text = DataGridView1.Item(0, 93).Value
            Label15.Text = DataGridView1.Item(0, 92).Value
            Label13.Text = DataGridView1.Item(0, 91).Value
            Label4.Text = DataGridView1.Item(0, 90).Value
            Label6.Text = DataGridView1.Item(0, 89).Value
            Label8.Text = DataGridView1.Item(0, 88).Value
            Label14.Text = DataGridView1.Item(0, 87).Value
            Label19.Text = DataGridView1.Item(0, 86).Value
            Label25.Text = DataGridView1.Item(0, 85).Value
            Label18.Text = DataGridView1.Item(0, 84).Value
            Label23.Text = DataGridView1.Item(0, 83).Value
            Label16.Text = DataGridView1.Item(0, 82).Value
            Label10.Text = DataGridView1.Item(0, 81).Value
            Label9.Text = DataGridView1.Item(0, 80).Value
            Label5.Text = DataGridView1.Item(0, 79).Value
            Label21.Text = DataGridView1.Item(0, 78).Value
            Label20.Text = DataGridView1.Item(0, 77).Value
            Label11.Text = DataGridView1.Item(0, 76).Value
            Label2.Text = DataGridView1.Item(0, 75).Value
        ElseIf lev = 5 Then
            menit = 1
            detik = 0
            ms = 10
            Label1.Text = "01:00"
            Timer1.Enabled = True
            ur = 124
            Kata1.Text = DataGridView1.Item(1, ur).Value
            Label2.Text = DataGridView1.Item(0, 124).Value
            Label11.Text = DataGridView1.Item(0, 123).Value
            Label5.Text = DataGridView1.Item(0, 122).Value
            Label9.Text = DataGridView1.Item(0, 121).Value
            Label10.Text = DataGridView1.Item(0, 120).Value
            Label16.Text = DataGridView1.Item(0, 119).Value
            Label23.Text = DataGridView1.Item(0, 118).Value
            Label18.Text = DataGridView1.Item(0, 117).Value
            Label25.Text = DataGridView1.Item(0, 116).Value
            Label19.Text = DataGridView1.Item(0, 115).Value
            Label14.Text = DataGridView1.Item(0, 114).Value
            Label8.Text = DataGridView1.Item(0, 113).Value
            Label6.Text = DataGridView1.Item(0, 112).Value
            Label4.Text = DataGridView1.Item(0, 111).Value
            Label13.Text = DataGridView1.Item(0, 110).Value
            Label15.Text = DataGridView1.Item(0, 109).Value
            Label7.Text = DataGridView1.Item(0, 108).Value
            Label17.Text = DataGridView1.Item(0, 107).Value
            Label26.Text = DataGridView1.Item(0, 106).Value
            Label12.Text = DataGridView1.Item(0, 105).Value
            Label21.Text = DataGridView1.Item(0, 104).Value
            Label20.Text = DataGridView1.Item(0, 103).Value
            Label22.Text = DataGridView1.Item(0, 102).Value
            Label3.Text = DataGridView1.Item(0, 101).Value
            Label24.Text = DataGridView1.Item(0, 100).Value
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ms -= 1
        If ms < 0 Then
            detik -= 1
            If detik < 0 Then
                detik = 59
                menit -= 1
            End If
            Label1.Text = Format(menit, "00") & ":" & Format(detik, "00")
            If menit = 0 And detik = 0 Then
                Timer1.Enabled = False
                Select Case lev
                    Case 1
                        If ur <> 25 Then
                            MsgBox("maaf waktu anda habis coba lagi", MsgBoxStyle.Information)
                            Level.Show()
                            Me.Close()
                        End If
                    Case 2
                        If ur <> 50 Then
                            MsgBox("maaf waktu anda habis coba lagi", MsgBoxStyle.Information)
                            Level.Show()
                            Me.Close()
                        End If
                    Case 3
                        If ur <> 75 Then
                            MsgBox("maaf waktu anda habis coba lagi", MsgBoxStyle.Information)
                            Level.Show()
                            Me.Close()
                        End If
                    Case 4
                        If ur <> 74 Then
                            MsgBox("maaf waktu anda habis coba lagi", MsgBoxStyle.Information)
                            Level.Show()
                            Me.Close()
                        End If
                    Case 5
                        If ur <> 99 Then
                            MsgBox("maaf waktu anda habis coba lagi", MsgBoxStyle.Information)
                            Level.Show()
                            Me.Close()
                        End If
                End Select
            End If
            ms = 10
            Select Case lev
                Case 1
                    If ur = 25 Then
                        Timer1.Enabled = False
                        MsgBox("Selamat anda berhasil", MsgBoxStyle.Information)
                        If leve = lev Then
                            leve += 1
                            Koneksi.tambah("update nama set tingkat = '" + leve.ToString + "' where nama = '" + nm + "'")
                        End If
                        Level.Show()
                        Me.Close()
                    End If
                Case 2
                    If ur = 50 Then
                        Timer1.Enabled = False
                        MsgBox("Selamat anda berhasil", MsgBoxStyle.Information)
                        If leve = lev Then
                            leve += 1
                            Koneksi.tambah("update nama set tingkat = '" + leve.ToString + "' where nama = '" + nm + "'")
                        End If
                        Level.Show()
                        Me.Close()
                    End If
                Case 3
                    If ur = 75 Then
                        Timer1.Enabled = False
                        MsgBox("Selamat anda berhasil", MsgBoxStyle.Information)
                        If leve = lev Then
                            leve += 1
                            Koneksi.tambah("update nama set tingkat = '" + leve.ToString + "' where nama = '" + nm + "'")
                        End If
                        Level.Show()
                        Me.Close()
                    End If
                Case 4
                    If ur = 74 Then
                        Timer1.Enabled = False
                        MsgBox("Selamat anda berhasil", MsgBoxStyle.Information)
                        If leve = lev Then
                            leve += 1
                            Koneksi.tambah("update nama set tingkat = '" + leve.ToString + "' where nama = '" + nm + "'")
                        End If
                        Level.Show()
                        Me.Close()
                    End If
                Case 5
                    If ur = 99 Then
                        Timer1.Enabled = False
                        MsgBox("Selamat anda berhasil menghafal 125 kosakata bahasa inggris", MsgBoxStyle.Information)
                        Level.Show()
                        Me.Close()
                    End If
            End Select
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Level.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label2.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label2.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label2.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label2.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label3.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label3.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label3.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label3.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label4.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label4.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label4.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label4.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label5.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label5.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label5.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label5.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label6.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label6.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label6.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label6.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label7.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label7.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label7.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label7.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label8.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label8.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label8.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label8.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label9.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label9.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label9.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label9.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label10.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label10.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label10.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label10.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label11.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label11.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label11.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label11.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label12.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label12.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label12.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label12.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label13.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label13.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label13.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label13.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label14.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label14.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label14.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label14.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label15.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label15.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label15.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label15.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label16.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label16.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label16.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label16.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label17.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label17.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label17.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label17.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label18.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label18.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label18.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label18.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label19.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label19.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label19.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label19.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label20.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label20.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label20.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label20.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label21.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label21.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label21.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label21.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label22.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label22.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label22.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label22.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label23.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label23.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label23.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label23.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label24.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label24.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label24.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label24.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label25.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label25.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label25.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label25.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        If lev = 1 Or lev = 2 Or lev = 3 Then
            If Label26.Text = DataGridView1.Item(0, ur).Value Then
                ur += 1
                Label26.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        ElseIf lev = 4 Or lev = 5 Then
            If Label26.Text = DataGridView1.Item(0, ur).Value Then
                ur -= 1
                Label26.Hide()
                Kata1.Text = DataGridView1.Item(1, ur).Value
            End If
        End If
    End Sub
End Class