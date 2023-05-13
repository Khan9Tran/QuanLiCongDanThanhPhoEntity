using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeNgheNghiep : Form
    {
        CongDanDAO cDDAO;

        public FThongKeNgheNghiep()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
        }

        private void FThongKeNgheNghiep_Load(object sender, EventArgs e)
        {
            TaoDoThiNgheNghiep();
        }

        private void TaoDoThiNgheNghiep()
        {
            TaoChartNgheNghiep();
            chartNgheNghiep.Series.Add("Data");
            chartNgheNghiep.Series["Data"].ChartType = SeriesChartType.Column;
            chartNgheNghiep.Series["Data"].Color = Color.SkyBlue;

            var dt = cDDAO.LayDanhSachNgheNghiep();
            var dt15 = dt.AsEnumerable().Take(15);
            chartNgheNghiep.DataSource = dt15;
            chartNgheNghiep.Series["Data"].XValueMember = "NgheNghiep";
            chartNgheNghiep.Series["Data"].YValueMembers = "SoLuong";


            chartNgheNghiep.ChartAreas.Add("ChartArea");
            chartNgheNghiep.ChartAreas["ChartArea"].AxisX.LabelStyle.Angle = -90;
            chartNgheNghiep.ChartAreas["ChartArea"].BackColor = Color.Transparent;
            // Set the column width
            chartNgheNghiep.Series["Data"].CustomProperties = "PixelPointWidth=30";

            chartNgheNghiep.Legends.Clear();
            Controls.Add(chartNgheNghiep);
        }

        private void TaoChartNgheNghiep()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartNgheNghiep = new Chart();

            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 93F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartNgheNghiep.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartNgheNghiep.Legends.Add(legend1);
            chartNgheNghiep.Location = new Point(12, 180);
            chartNgheNghiep.Name = "chartNgheNghiep";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            chartNgheNghiep.Series.Add(series1);
            chartNgheNghiep.Size = new Size(1490, 440);
            chartNgheNghiep.TabIndex = 0;
            chartNgheNghiep.Text = "chart1";
        }
    }
}
