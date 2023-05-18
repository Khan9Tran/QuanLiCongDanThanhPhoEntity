namespace QuanLiCongDanThanhPho
{
    //Dùng ngắt trang để hiển thị thông tin trên datagridview
    internal class Paging
    {
        private NumericUpDown nudPage;
        private int recordNum;

        //Khởi tạo với liên kết với nudPgae để chuyển trang, và recordNum đế quy định tổng số trang
        public Paging(NumericUpDown nudPage, int recordNum)
        {
            this.nudPage = nudPage;
            this.recordNum = recordNum;
        }

        //Trả về Dữ liệu sao khi đã ngắt trang
        public List<T> NgatTrang<T>(List<T> ds)
        {
            int totalRecord = ds.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum = totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page - 1) * recordNum).Take(recordNum).ToList();
        }

    }
}
