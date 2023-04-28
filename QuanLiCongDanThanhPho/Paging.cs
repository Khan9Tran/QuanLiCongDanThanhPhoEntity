namespace QuanLiCongDanThanhPho
{
    internal class Paging
    {
        private NumericUpDown nudPage;
        private int recordNum;
        public Paging(NumericUpDown nudPage, int recordNum)
        {
            this.nudPage = nudPage;
            this.recordNum = recordNum;
        }

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
