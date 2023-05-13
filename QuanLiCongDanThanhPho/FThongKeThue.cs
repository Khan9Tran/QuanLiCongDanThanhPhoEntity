using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeThue : Form
    {
        private ThueDAO thueDAO;
        public FThongKeThue()
        {
            InitializeComponent();
            StackForm.Add(this);
            thueDAO = new ThueDAO();
        }
        private string donVi()
        {
            return " VNĐ";
        }
        private void FThongKeThue_Load(object sender, EventArgs e)
        {
            TaoBieuDoQuanDongNhieuThue();
            TaoBieuDoThue();
            TaoBieuDoQuanDongItThue();
            int[] thues = thueDAO.LayThongKeThue();
            int soNguoiTreHan = thueDAO.LaySoNguoiTreHan();
            lblTongTienThue.Text += " " + thues[2].ToString() + donVi();
            lblTongThueCanDong.Text += " " +thues[1].ToString() + donVi();
            lblTongThueDaDong.Text += " " + thues[0].ToString() + donVi();
            lblTrungBinhThue.Text += " " +(((int)(thues[2] / thues[3])).ToString()) + donVi();
            lblSoNguoiTreHan.Text += " " + soNguoiTreHan.ToString();
        }

        private void TaoBieuDoThue()
        {
            TaoChartThue();
            int[] thues = thueDAO.LayThongKeThue();

            // Set the chart type to Pie
            chartThue.Series.Add("Data");
            chartThue.Series["Data"].ChartType = SeriesChartType.Pie;

            // Bind the chart data to the DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Tình trạng", typeof(string));
            dt.Columns.Add("Số tiền", typeof(int));

            dt.Rows.Add("Đã đóng", thues[0]);
            dt.Rows.Add("Còn thiếu", thues[1]);
            chartThue.DataSource = dt;
            chartThue.Series["Data"].XValueMember = "Tình trạng";
            chartThue.Series["Data"].YValueMembers = "Số tiền";

            // Set the chart properties
            chartThue.ChartAreas.Add(new ChartArea());
            chartThue.Legends.Add(new Legend());
            chartThue.Legends[0].Enabled = true;

            // Format the data labels to show percentages
            chartThue.Series["Data"].Label = "#PERCENT";
            chartThue.Series["Data"].LegendText = "#VALX";

            Controls.Add(chartThue);
        }

        private void TaoBieuDoQuanDongItThue()
        {
            TaoChartQuanDongItThue();
            chartQuanDongItThue.Series.Add("Data");
            chartQuanDongItThue.Series["Data"].ChartType = SeriesChartType.Column;
            chartQuanDongItThue.Series["Data"].Color = Color.SkyBlue;

            DataTable dt = thueDAO.LayDanhSachTienDongThueCacQuan();
            dt.DefaultView.Sort = "Tiền đã thu ASC";
            DataTable sortedDT = dt.DefaultView.ToTable();
            var dt5 = sortedDT.AsEnumerable().Take(5);
            chartQuanDongItThue.DataSource = dt5;
            chartQuanDongItThue.Series["Data"].XValueMember = "Quận";
            chartQuanDongItThue.Series["Data"].YValueMembers = "Tiền đã thu";


            chartQuanDongItThue.ChartAreas.Add("ChartArea");
            chartQuanDongItThue.ChartAreas["ChartArea"].AxisX.LabelStyle.Angle = -90;
            chartQuanDongItThue.ChartAreas["ChartArea"].BackColor = Color.Transparent;
            // Set the column width
            chartQuanDongItThue.Series["Data"].CustomProperties = "PixelPointWidth=30";

            chartQuanDongItThue.Legends.Clear();
            Controls.Add(chartQuanDongItThue);
        }

        private void TaoBieuDoQuanDongNhieuThue()
        {
            TaoChartQuanDongNhieuThue();
            chartQuanDongNhieuThue.Series.Add("Data");
            chartQuanDongNhieuThue.Series["Data"].ChartType = SeriesChartType.Column;
            chartQuanDongNhieuThue.Series["Data"].Color = Color.SkyBlue;

            DataTable dt = thueDAO.LayDanhSachTienDongThueCacQuan();
            dt.DefaultView.Sort = "Tiền đã thu DESC";
            DataTable sortedDT = dt.DefaultView.ToTable();
            var dt5 = sortedDT.AsEnumerable().Take(5);
            chartQuanDongNhieuThue.DataSource = dt5;
            chartQuanDongNhieuThue.Series["Data"].XValueMember = "Quận";
            chartQuanDongNhieuThue.Series["Data"].YValueMembers = "Tiền đã thu";


            chartQuanDongNhieuThue.ChartAreas.Add("ChartArea");
            chartQuanDongNhieuThue.ChartAreas["ChartArea"].AxisX.LabelStyle.Angle = -90;
            chartQuanDongNhieuThue.ChartAreas["ChartArea"].BackColor = Color.Transparent;
            // Set the column width
            chartQuanDongNhieuThue.Series["Data"].CustomProperties = "PixelPointWidth=30";

            chartQuanDongNhieuThue.Legends.Clear();
            Controls.Add(chartQuanDongNhieuThue);
        }

        private void TaoChartThue()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartThue = new Chart();

            chartArea1.Name = "ChartArea1";
            chartThue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartThue.Legends.Add(legend1);
            chartThue.Location = new Point(900, 12);
            chartThue.Name = "chartGioiTinh";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";

            chartThue.Series.Add(series1);
            chartThue.Size = new Size(500, 500);
            chartThue.TabIndex = 0;
            chartThue.Text = "chartGioiTinh";
        }

        private void TaoChartQuanDongItThue()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartQuanDongItThue = new Chart();

            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 93F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartQuanDongItThue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartQuanDongItThue.Legends.Add(legend1);
            chartQuanDongItThue.Location = new Point(12, 300);
            chartQuanDongItThue.Name = "chartNgheNghiep";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            chartQuanDongItThue.Series.Add(series1);
            chartQuanDongItThue.Size = new Size(700, 400);
            chartQuanDongItThue.TabIndex = 0;
            chartQuanDongItThue.Text = "chart1";
        }

        private void TaoChartQuanDongNhieuThue()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartQuanDongNhieuThue = new Chart();

            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 93F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartQuanDongNhieuThue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartQuanDongNhieuThue.Legends.Add(legend1);
            chartQuanDongNhieuThue.Location = new Point(800, 300);
            chartQuanDongNhieuThue.Name = "chartNgheNghiep";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            chartQuanDongNhieuThue.Series.Add(series1);
            chartQuanDongNhieuThue.Size = new Size(700, 400);
            chartQuanDongNhieuThue.TabIndex = 0;
            chartQuanDongNhieuThue.Text = "chart1";
        }
    }
}
