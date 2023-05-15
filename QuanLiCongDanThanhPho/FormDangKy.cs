namespace QuanLiCongDanThanhPho
{
    public class FormDangKy : Form
    {
        private CongDanDAO cDDAO;
        private KhaiSinhDAO kSDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private HoKhauDAO hKDAO;
        private TamTruTamVangDAO tTTVDAO;
        private CCCDDAO cCCDDAO;
        private HinhDaiDien hinhCongDan;

        public HinhDaiDien HinhCongDan { get => hinhCongDan; set => hinhCongDan = value; }
        internal CongDanDAO CDDAO { get => cDDAO; set => cDDAO = value; }
        internal KhaiSinhDAO KSDAO { get => kSDAO; set => kSDAO = value; }
        internal ThueDAO ThueDAO { get => thueDAO; set => thueDAO = value; }
        internal HonNhanDAO HNDAO { get => hNDAO; set => hNDAO = value; }
        internal HoKhauDAO HKDAO { get => hKDAO; set => hKDAO = value; }
        internal TamTruTamVangDAO TTTVDAO { get => tTTVDAO; set => tTTVDAO = value; }
        internal CCCDDAO CCCDDAO { get => cCCDDAO; set => cCCDDAO = value; }
        
        public FormDangKy()
        {
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            hKDAO = new HoKhauDAO();
            tTTVDAO = new TamTruTamVangDAO();
            cCCDDAO = new CCCDDAO();
        }

        internal virtual void DangKy() { }
        internal virtual void Reset() 
        {
            ToolsForControl.ClearTextBox(Controls);
        }
    }
}
