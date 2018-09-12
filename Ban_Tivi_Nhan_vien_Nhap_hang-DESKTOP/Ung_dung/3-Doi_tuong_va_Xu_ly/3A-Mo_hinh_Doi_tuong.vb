'**************** Cấu trúc các biến Đối tượng khi Lập trình *******************
'****** Đối tượng CSDL Du_lieu
Public Class XL_DU_LIEU
    Public Cua_hang As New XL_CUA_HANG
    Public Danh_sach_Tivi As New List(Of XL_TIVI) ' Đối tượng Quản lý chính 
End Class
Public Class XL_CUA_HANG
    Public Ten, Ma_so As String
    Public Danh_sach_Nhan_vien_Nhap_hang As New List(Of XL_NHAN_VIEN_NHAP_HANG)
End Class
Public Class XL_NHOM_TIVI
    Public Ten, Ma_so As String
End Class
Public Class XL_NHAN_VIEN_NHAP_HANG
    Public Ho_ten, Ma_so, Ten_Dang_nhap, Mat_khau As String
End Class

'****** Đối tượng Quản lý Chính 
Public Class XL_TIVI
    Public Ten, Ma_so As String
    Public Don_gia_Nhap As Long
    Public Nhom_Tivi As New XL_NHOM_TIVI()
    Public So_luong_Ton As Long
    Public Danh_sach_Nhap_hang As New List(Of XL_NHAP_HANG)
End Class
'****** Các Đối tượng Hoạt động 
Public Class XL_NHAP_HANG
    Public Ngay As DateTime = DateTime.Today
    Public Don_gia, So_luong, Tien As Long
End Class


