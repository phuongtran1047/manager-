Public Class MH_Nhap_Tivi
    Dim Dinh_dang_VN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN")
    Dim The_hien As New XL_THE_HIEN
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Luu_tru As New XL_LUU_TRU
    Dim Tivi As XL_TIVI
    Public Event Da_Nhap_hang(XL_NHAP_HANG)
    Sub Khoi_dong(Tivi_Chon As XL_TIVI)
        Dim Du_lieu As XL_DU_LIEU = Luu_tru.Doc_Du_lieu
        Dim Tivi_Dong_bo = Du_lieu.Danh_sach_Tivi.FirstOrDefault(Function(Tivi) Tivi.Ma_so = Tivi_Chon.Ma_so)
        Tivi_Chon.Don_gia_Nhap = Tivi_Dong_bo.Don_gia_Nhap
        Tivi = Tivi_Chon
        Xuat_Tivi()
    End Sub
    Sub Xuat_Tivi()
        Dim Th_Hinh = The_hien.Tao_The_hien_Hinh(Tivi.Ma_so, New Size(120, 80))
        Th_Tivi.Controls.Add(Th_Hinh)
        Dim Th_Ho_so As New FlowLayoutPanel
        Th_Tivi.Controls.Add(Th_Ho_so)
        Th_Ho_so.Size = New Size(300, 180)
        Dim Th_Tom_tat As New Label
        Th_Ho_so.Controls.Add(Th_Tom_tat)
        Th_Tom_tat.Size = New Size(300, 40)
        Th_Tom_tat.Text = Tivi.Ten & vbCrLf & Tivi.Don_gia_Nhap.ToString("c0", Dinh_dang_VN)
        Dim Th_So_luong As New TextBox
        Th_Ho_so.Controls.Add(Th_So_luong)
        Dim So_luong As Integer = 1
        Th_So_luong.Text = So_luong
        Dim Th_Dong_y As New Button
        Th_Dong_y.ForeColor = Color.Red
        Th_Ho_so.Controls.Add(Th_Dong_y)
        Th_Dong_y.Text = "Đồng ý"

        AddHandler Th_Dong_y.Click,
            Sub()
                Dim Hop_le = Integer.TryParse(Th_So_luong.Text, So_luong) AndAlso So_luong > 0
                If Hop_le Then
                    Dim Nhap_hang As New XL_NHAP_HANG
                    Nhap_hang.Ngay = DateTime.Today
                    Nhap_hang.So_luong = So_luong
                    Nhap_hang.Don_gia = Tivi.Don_gia_Nhap
                    Nhap_hang.Tien = So_luong * Nhap_hang.Don_gia
                    Dim Kq As String = Luu_tru.Ghi_Nhap_hang_Moi(Tivi, Nhap_hang)
                    If (Kq = "OK") Then

                        RaiseEvent Da_Nhap_hang(Nhap_hang)
                    Else
                        MessageBox.Show("Lỗi Hệ thống :")
                    End If

                Else
                    Th_So_luong.Text = 1
                    MessageBox.Show("Số lượng không hợp lệ :")
                End If
            End Sub
    End Sub


End Class
