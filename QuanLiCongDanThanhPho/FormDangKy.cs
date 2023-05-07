namespace QuanLiCongDanThanhPho
{
    public partial class FormDangKy : Form
    {
        private CongDanDAO cDDAO;
        private KhaiSinhDAO kSDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private HoKhauDAO hKDAO;
        private HinhDaiDien hinhCongDan;
        private TamTruTamVangDAO tTTVDAO;

        public HinhDaiDien HinhCongDan { get => hinhCongDan; set => hinhCongDan = value; }
        internal CongDanDAO CDDAO { get => cDDAO; set => cDDAO = value; }
        internal KhaiSinhDAO KSDAO { get => kSDAO; set => kSDAO = value; }
        internal ThueDAO ThueDAO { get => thueDAO; set => thueDAO = value; }
        internal HonNhanDAO HNDAO { get => hNDAO; set => hNDAO = value; }
        internal HoKhauDAO HKDAO { get => hKDAO; set => hKDAO = value; }
        internal TamTruTamVangDAO TTTVDAO { get => tTTVDAO; set => tTTVDAO = value; }

        public FormDangKy()
        {
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            hKDAO = new HoKhauDAO();
            tTTVDAO = new TamTruTamVangDAO();
           
        }

        internal virtual void DangKy() { }
        internal virtual void Reset() 
        {
            ToolsForControl.ClearTextBox(Controls);
        }
    }
}
