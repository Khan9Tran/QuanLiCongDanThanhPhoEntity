using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLiCongDanThanhPho.Models;
using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        static QuanlitpContext db = new QuanlitpContext();

        public static QuanlitpContext Db { get => db; set => db = value; }

        public void CapNhat()
        {
            db.SaveChanges();
        }
        public void ThucThi(string sqlStr, string thongBao)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(thongBao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
        public CongDan LayThongTinCongDan(string sqlStr)
        {
            CongDan cd = new CongDan();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cd.SDT = reader["SDT"].ToString();
                    cd.Ten = reader["Ten"].ToString();
                    cd.CCCD = reader["CCCD"].ToString();
                    cd.TonGiao = reader["TonGiao"].ToString();
                    cd.MaHoKhau = reader["MaHK"].ToString();
                    cd.QuanHeVoiChuHo = reader["QuanHeVoiChuHo"].ToString();
                    cd.NgheNghiep = reader["NgheNghiep"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return cd;
        }

        public Cccd LayThongTinCCCD(string sqlStr)
        {
           Cccd cCCD = new Cccd();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cCCD.MaCccd = reader["MaCCCD"].ToString();
                    cCCD.NgayCap = reader.GetDateTime("NgayCap");
                    cCCD.DacDiem = reader["DacDiem"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return cCCD;
        }
        public Models.Account LayThongTinTaiKhoan(string sqlStr)
        {
            Models.Account accTmp = new Models.Account();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accTmp.UserName = reader["UserName"].ToString();
                    accTmp.Password = reader["StrPassword"].ToString();
                    accTmp.DisplayName = reader["DisplayName"].ToString();
                    accTmp.Type = int.Parse(reader["QuyenTruyCap"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return accTmp;
        }
        public Khaisinh LayThongTinKhaiSinh(string sqlStr)
        {
            return null;
        }

        public Hokhau LayThongTinHoKhau(string sqlStr)
        {
            return null;
        }
        public Honnhan LayThongTinHonNhan(string sqlStr)
        {
            return null;
        }
        public Tamtrutamvang LayThongTinTamTruTamVang(string sqlStr)
        {
            return null;
        }
        public Boolean KiemTraCoKhong(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetInt32("COUNT") > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
                return false;
            }
            finally
            { 
                conn.Close();
            }
            return false;
        }
    }
}
