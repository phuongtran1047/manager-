Public Class MH_Xem_Danh_sach_Tivi
    Dim Dinh_dang_VN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN")
    Dim The_hien As New XL_THE_HIEN
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Danh_sach_Tivi As List(Of XL_TIVI)
    Public Sub Khoi_dong(Danh_sach_Tivi_Xem As List(Of XL_TIVI))
        Danh_sach_Tivi = Danh_sach_Tivi_Xem
        Xuat_Danh_sach_Tivi()
    End Sub
    Sub Xuat_Danh_sach_Tivi()
        Danh_sach_Tivi.ForEach(
            Sub(Tivi)
                Dim Th_Tivi As New FlowLayoutPanel
                Th_Danh_sach_Tivi.Controls.Add(Th_Tivi)
                Th_Tivi.Dock = DockStyle.Top
                Th_Tivi.AutoSize = True
                Th_Tivi.Font = New Font("Arial", 14)
                Th_Tivi.Name = Tivi.Ma_so
                Dim Th_Hinh = The_hien.Tao_The_hien_Hinh(Tivi.Ma_so, New Size(80, 60))
                Th_Tivi.Controls.Add(Th_Hinh)
                Dim Th_Tom_tat As New Label
                Th_Tivi.Controls.Add(Th_Tom_tat)
                Th_Tom_tat.Size = New Size(320, 80)

                Th_Tom_tat.Text = Tivi.Ten &
                                  vbCrLf & "Đơn giá Nhập " & Tivi.Don_gia_Nhap.ToString("c0", Dinh_dang_VN) &
                                  vbCrLf & "Số lượng Tồn " & Tivi.So_luong_Ton.ToString("n0", Dinh_dang_VN)

                AddHandler Th_Hinh.Click,
                       Sub()
                           Kich_hoat_Man_hinh_Nhap_Tivi(Tivi)
                       End Sub
                AddHandler Th_Tom_tat.Click,
                 Sub()
                     Kich_hoat_Man_hinh_Nhap_Tivi(Tivi)
                 End Sub
            End Sub)
    End Sub
    Sub Kich_hoat_Man_hinh_Nhap_Tivi(Tivi As XL_TIVI)
        Me.Visible = False
        Dim Khung_Chuc_nang As Control = Me.Parent
        Dim Mh = New MH_Nhap_Tivi()
        Mh.Khoi_dong(Tivi)
        Mh.Dock = DockStyle.Fill
        Khung_Chuc_nang.Controls.Add(Mh)

        AddHandler Mh.Da_Nhap_hang,
            Sub(Nhap_hang As XL_NHAP_HANG)
                Me.Visible = True
                Khung_Chuc_nang.Controls.Remove(Mh)
                Dim Th_Tivi = Th_Danh_sach_Tivi.Controls(Tivi.Ma_so)
                Dim Th_Tom_tat = Th_Tivi.Controls(1)
                Th_Tom_tat.ForeColor = Color.Brown
                Th_Tom_tat.Text = Tivi.Ten &
                                  vbCrLf & "Đơn giá Nhập " & Tivi.Don_gia_Nhap.ToString("c0", Dinh_dang_VN) &
                                  vbCrLf & "Số lượng Tồn " & Tivi.So_luong_Ton.ToString("n0", Dinh_dang_VN) &
                                  vbCrLf & "Số lượng Nhập " & Nhap_hang.So_luong & " Tiền " & Nhap_hang.Tien.ToString("c0", Dinh_dang_VN)
            End Sub

    End Sub
End Class
