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
    }
}
