using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HoKhauDAO
    {
        DBConnection conn = new DBConnection();
        public HoKhauDAO() { }
        public void ThemHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('{hK.MaHoKhau}',N'{hK.DiaChi.toString()}', '{hK.CCCDChuHo}');");
            conn.ThucThi(sqlStr, "Tạo hộ khẩu mới thành công");
        }
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU EXCEPT SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU WHERE MaHK like '00000A' OR MaHK like '00000B'");
        }
        public HoKhau LayThongTin(string maHoKhau)
        {
            string sqlStr = string.Format("SELECT * FROM HOKHAU WHERE MaHK = '{0}'", maHoKhau);
            return conn.LayThongTinHoKhau(sqlStr);
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string sqlStr = string.Format($"SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU WHERE DiaChi like N'%{tu}%' OR CCCDChuHo like '%{tu}%' OR MaHK like '%{tu}%' EXCEPT SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU WHERE MaHK like '00000A' OR MaHK like '00000B'");
            return conn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachXepTheoSoTV(string tu)
        {
            string sqlStr = string.Format($"SELECT HOKHAU.MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU INNER JOIN (SELECT MaHK, count(CCCD) as SL FROM CONGDAN GROUP BY MaHK) AS CONGDAN ON HOKHAU.MaHK = CONGDAN.MAHK WHERE DiaChi like N'%{tu}%' OR CCCDChuHo like '%{tu}%' OR HOKHAU.MaHK like '%{tu}%' ORDER BY SL ASC EXCEPT SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU WHERE MaHK like '00000A' OR MaHK like '00000B'");
            return conn.LayDanhSach(sqlStr);
        }
        public void CapNhatHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"UPDATE HOKHAU SET DiaChi = N'{hK.DiaChi.toString()}', CCCDChuHo = '{hK.CCCDChuHo}' WHERE MaHK = '{hK.MaHoKhau}'");
            conn.ThucThi(sqlStr, $"Cập nhật hộ khẩu thành công");
        }
        public void XoaHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"DELETE HOKHAU WHERE MaHK = '{hK.MaHoKhau}'");
            conn.ThucThi(sqlStr, "Đã xóa hộ không còn thành viên");
        }
        public DataTable TimHoNhieuNguoiNhat()
        {
            string sqlStr = string.Format("SELECT MaHK as 'Mã hộ', count(CCCD) as 'Số lượng' FROM CONGDAN GROUP BY MaHK HAVING count(CCCD) = (SELECT max(SL) FROM (SELECT count(CCCD) as SL FROM CONGDAN WHERE MaHK != '00000B' AND MaHK != '00000A' GROUP BY MaHK) as A)");
            return conn.LayDanhSach(sqlStr);
        }
    }
}
