using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FKhaiTu : Form
    {
        public FKhaiTu()
        {
            InitializeComponent();
            StackForm.Add(this);
            congDanDAO = new CongDanDAO();
        }
        CongDanDAO congDanDAO;

        private void XoaCongDan()
        {
            Congdan? cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (cD!= null && cD.Ten == txtTen.Text)
            {
                HinhDaiDien hinhDaiDien = new HinhDaiDien(HinhDaiDien.Type.congDan);
                hinhDaiDien.DeleteDirectory(hinhDaiDien.GetFolderPath(), cD.Cccd);
                if (congDanDAO.XoaCongDan(cD))
                    MessageBox.Show("Đã khai tử");
            }    
            else
            {
                MessageBox.Show("Thất bại");
            }    
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {   
            XoaCongDan();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            Congdan? cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (cD != null)
                txtTen.Text = cD.Ten;
        }
    }
}
