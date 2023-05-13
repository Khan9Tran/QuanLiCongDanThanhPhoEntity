using System.Data;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeCongDan : Form
    {
        private CongDanDAO cDDAO;
        private KhaiSinhDAO kSDAO;

        public FThongKeCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
        }

        private void FThongKeCongDancs_Load(object sender, EventArgs e)
        {
            TaoBieuDoTiLeGioiTinh();
            TaoBieuDoTiLeNhomTuoi();
            TaoBieuDoTiLeHonNhan();
            lblSoCongDan.Text += string.Format($" {cDDAO.LaySoLuongCongDan()} người");
            HeaderText();
        }

        private void HeaderText()
        {
            gvHonNhan.Columns[0].HeaderText = "Tình trạng";
            gvHonNhan.Columns[1].HeaderText = "Số lượng";

            gvSoLuongNamNu.Columns[0].HeaderText = "Giới tính m:Nam, f:Nữ";
            gvSoLuongNamNu.Columns[1].HeaderText = "Số lượng";
        }

        private void TaoBieuDoTiLeGioiTinh()
        {
            TaoChartGioiTinh();
            // Set the chart type to Pie
            chartGioiTinh.Series.Add("Data");
            chartGioiTinh.Series["Data"].ChartType = SeriesChartType.Pie;

            // Bind the chart data to the DataTable
            var dt = kSDAO.LayDanhSachVeSoNamNu();
            gvSoLuongNamNu.DataSource = dt;
            chartGioiTinh.DataSource = dt;
            chartGioiTinh.Series["Data"].XValueMember = "MaHk";
            chartGioiTinh.Series["Data"].YValueMembers = "SoLuong";

            // Set the chart properties
            chartGioiTinh.ChartAreas.Add(new ChartArea());
            chartGioiTinh.Legends.Add(new Legend());
            chartGioiTinh.Legends[0].Enabled = true;

            // Format the data labels to show percentages
            chartGioiTinh.Series["Data"].Label = "#PERCENT";
            chartGioiTinh.Series["Data"].LegendText = "#VALX";

            Controls.Add(chartGioiTinh);
        }

        private void TaoBieuDoTiLeNhomTuoi()
        {
            TaoChartNhomTuoi();
            // Set the chart type to Pie
            chartNhomTuoi.Series.Add("Data");
            chartNhomTuoi.Series["Data"].ChartType = SeriesChartType.Pie;

            // Bind the chart data to the DataTable
            DataTable dt = kSDAO.LayTuoiCongDan();
            gvNhomTuoi.DataSource = dt;
            chartNhomTuoi.DataSource = dt;
            chartNhomTuoi.Series["Data"].XValueMember = "Nhóm tuổi";
            chartNhomTuoi.Series["Data"].YValueMembers = "Số lượng";

            // Set the chart properties
            chartNhomTuoi.ChartAreas.Add(new ChartArea());
            chartNhomTuoi.Legends.Add(new Legend());
            chartNhomTuoi.Legends[0].Enabled = true;

            // Format the data labels to show percentages
            chartNhomTuoi.Series["Data"].Label = "#PERCENT";
            chartNhomTuoi.Series["Data"].LegendText = "#VALX";

            Controls.Add(chartNhomTuoi);
        }

        private void TaoBieuDoTiLeHonNhan()
        {
            TaoChartHonNhan();
            // Set the chart type to Pie
            chartHonNhan.Series.Add("Data");
            chartHonNhan.Series["Data"].ChartType = SeriesChartType.Pie;

            // Bind the chart data to the DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Tình trạng", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));

            dt.Rows.Add("Đã kết hôn", cDDAO.LaySoLuongDaKetHon());
            dt.Rows.Add("Độc thân", cDDAO.LaySoLuongDocThan());
            gvHonNhan.DataSource = dt;
            chartHonNhan.DataSource = dt;
            chartHonNhan.Series["Data"].XValueMember = "Tình trạng";
            chartHonNhan.Series["Data"].YValueMembers = "Số lượng";

            // Set the chart properties
            chartHonNhan.ChartAreas.Add(new ChartArea());
            chartHonNhan.Legends.Add(new Legend());
            chartHonNhan.Legends[0].Enabled = true;

            // Format the data labels to show percentages
            chartHonNhan.Series["Data"].Label = "#PERCENT";
            chartHonNhan.Series["Data"].LegendText = "#VALX";

            Controls.Add(chartHonNhan);
        }

        private void TaoChartGioiTinh()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartGioiTinh = new Chart();

            chartArea1.Name = "ChartArea1";
            chartGioiTinh.BackColor = Color.Transparent;
            chartGioiTinh.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGioiTinh.Legends.Add(legend1);
            chartGioiTinh.Location = new Point(12, 77);
            chartGioiTinh.Name = "chartGioiTinh";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGioiTinh.Series.Add(series1);
            chartGioiTinh.Size = new Size(500, 500);
            chartGioiTinh.TabIndex = 0;
            chartGioiTinh.Text = "chartGioiTinh";
        }

        private void TaoChartNhomTuoi()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartNhomTuoi = new Chart();

            chartArea1.Name = "ChartArea1";
            chartNhomTuoi.BackColor = Color.Transparent;
            chartNhomTuoi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartNhomTuoi.Legends.Add(legend1);
            chartNhomTuoi.Location = new Point(500, 77);
            chartNhomTuoi.Name = "chartNhomTuoi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartNhomTuoi.Series.Add(series1);
            chartNhomTuoi.Size = new Size(500, 500);
            chartNhomTuoi.TabIndex = 0;
            chartNhomTuoi.Text = "chartNhomTuoi";
        }

        private void TaoChartHonNhan()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartHonNhan = new Chart();

            chartArea1.Name = "ChartArea1";
            chartHonNhan.BackColor = Color.Transparent;
            chartHonNhan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartHonNhan.Legends.Add(legend1);
            chartHonNhan.Location = new Point(990, 77);
            chartHonNhan.Name = "chartHonNhan";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartHonNhan.Series.Add(series1);
            chartHonNhan.Size = new Size(500, 500);
            chartHonNhan.TabIndex = 0;
            chartHonNhan.Text = "chartHonNhan";
        }
    }
}
