Imports System.IO
Imports Newtonsoft.Json
Imports System.Net
'**************** View/Presentation Layer  VL/PL *******************
Public Class XL_THE_HIEN
    Public Shared Dinh_dang_VN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN")
    Public Sub Xuat_Hinh(Ma_so As String, Kich_thuoc As Size, Th As Button)
        Th.Size = Kich_thuoc
        Dim Nhi_phan = New XL_LUU_TRU().Doc_Nhi_phan_Hinh(Ma_so)
        Dim Luong As New IO.MemoryStream(Nhi_phan)
        Th.BackgroundImage = Image.FromStream(Luong)
        Th.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Public Function Tao_The_hien_Hinh(Ma_so As String, Kich_thuoc As Size) As Button
        Dim Th As New Button
        Th.Size = Kich_thuoc
        Dim Nhi_phan = New XL_LUU_TRU().Doc_Nhi_phan_Hinh(Ma_so)
        Dim Luong As New IO.MemoryStream(Nhi_phan)
        Th.BackgroundImage = Image.FromStream(Luong)
        Th.BackgroundImageLayout = ImageLayout.Stretch
        Return Th
    End Function
End Class

'**************** Business Layer  BL *******************
Public Class XL_NGHIEP_VU
    Public Function Tra_cuu_Tivi(Chuoi_Tra_cuu As String, Danh_sach_Tivi As List(Of XL_TIVI)) As List(Of XL_TIVI)
        Chuoi_Tra_cuu = Chuoi_Tra_cuu.ToUpper
        Dim Danh_sach = Danh_sach_Tivi.FindAll(
            Function(Tivi)
                Return Tivi.Ten.ToString.ToUpper.Contains(Chuoi_Tra_cuu)
            End Function)
        Return Danh_sach
    End Function

End Class


'**************** Data Layer  DL *******************

Public Class XL_LUU_TRU

    Dim Dia_chi_Dich_vu As String = "http://localhost:50963"
    Dim Dia_chi_Dich_vu_Nhan_vien_Nhap_hang As String = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Nhan_vien_Nhap_hang.cshtml"
    Dim Dia_chi_Media As String = $"{Dia_chi_Dich_vu}/Media"
#Region "Xử lý Đọc"

    Public Function Doc_Du_lieu() As XL_DU_LIEU ' Chưa xử lý Caching
        Dim Xu_ly As New WebClient()
        Xu_ly.Encoding = System.Text.Encoding.UTF8
        Dim Tham_so As String = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_NHAN_VIEN_NHAP_HANG"
        Dim Dia_chi_Xu_ly As String = $"{Dia_chi_Dich_vu_Nhan_vien_Nhap_hang}?{Tham_so}"
        Dim Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly)
        Dim Du_lieu = JsonConvert.DeserializeObject(Of XL_DU_LIEU)(Chuoi_JSON)
        Return Du_lieu
    End Function

    Public Function Doc_Nhi_phan_Hinh(Ma_so As String) As Byte() ' Chưa xử lý Caching
        Dim Kq As Byte()

        Dim Dia_chi_Nhi_phan = $"{Dia_chi_Media}/{Ma_so}.png"
        Dim Xu_ly As New WebClient()
        Kq = Xu_ly.DownloadData(Dia_chi_Nhi_phan)
        Return Kq
    End Function
#End Region

#Region "Xử lý Ghi"
    Public Function Ghi_Nhap_hang_Moi(Tivi As XL_TIVI, Nhap_hang As XL_NHAP_HANG) As String
        Dim Kq As String = ""
        Tivi.Danh_sach_Nhap_hang.Add(Nhap_hang)
        Try
            Dim Xu__ly As New WebClient()
            Xu__ly.Encoding = System.Text.Encoding.UTF8
            Dim Tham_so As String = $"Ma_so_Xu_ly=GHI_NHAP_HANG_MOI&Ma_so_Tivi={Tivi.Ma_so}"
            Dim Dia_chi_Xu_ly As String = $"{Dia_chi_Dich_vu_Nhan_vien_Nhap_hang}?{Tham_so}"
            Dim Chuoi_JSON = JsonConvert.SerializeObject(Nhap_hang)
            Kq = Xu__ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim
        Catch Loi As Exception
            Kq = Loi.Message
        End Try
        If Kq = "OK" Then
            Tivi.So_luong_Ton += Nhap_hang.So_luong
        Else
            Tivi.Danh_sach_Nhap_hang.Remove(Nhap_hang)
        End If
        Return Kq
    End Function
#End Region




End Class

