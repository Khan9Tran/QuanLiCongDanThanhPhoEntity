using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{


    public partial class FormThongTin : MoveForm
    {
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private KhaiSinhDAO kSDAO;
        private TamTruTamVangDAO tTTVDAO;
        private CongDanDAO cDDAO;
        private CCCDDAO cCCDDAO;
        private HoKhauDAO hKDAO;
        private ToolsForControl tool;
        private Congdan congDan;
        private HinhDaiDien hinhCongDan;


        private string? maCCCD;
        private string? maHoKhau;

        internal ThueDAO ThueDAO { get => thueDAO; set => thueDAO = value; }
        internal HonNhanDAO HNDAO { get => hNDAO; set => hNDAO = value; }
        internal KhaiSinhDAO KSDAO { get => kSDAO; set => kSDAO = value; }
        internal TamTruTamVangDAO TTTVDAO { get => tTTVDAO; set => tTTVDAO = value; }
        internal CongDanDAO CDDAO { get => cDDAO; set => cDDAO = value; }
        internal CCCDDAO CCCDDAO { get => cCCDDAO; set => cCCDDAO = value; }
        internal HoKhauDAO HKDAO { get => hKDAO; set => hKDAO = value; }
        public ToolsForControl Tool { get => tool; set => tool = value; }
        public string? MaCCCD { get => maCCCD; set => maCCCD = value; }
        public string? MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public Congdan CongDan { get => congDan; set => congDan = value; }
        public HinhDaiDien HinhCongDan { get => hinhCongDan; set => hinhCongDan = value; }


        public FormThongTin()
        {
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            kSDAO = new KhaiSinhDAO();
            tTTVDAO = new TamTruTamVangDAO();
            cDDAO = new CongDanDAO();
            cCCDDAO = new CCCDDAO();
            hKDAO = new HoKhauDAO();
            StackForm.Add(this);
        }

        internal virtual void SetTools() { }

    }

}
