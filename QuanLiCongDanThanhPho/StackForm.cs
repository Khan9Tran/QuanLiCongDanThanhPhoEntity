namespace QuanLiCongDanThanhPho
{
    //Dùng hổ trợ cho nút Back và nút Home
    static internal class StackForm
    {
        //Lưu các form con
        static private List<Form> forms = new List<Form>();

        //Lưu form trang chủ
        private static FTrangChu? trangChu;
        public static FTrangChu? TrangChu { get => trangChu; set => trangChu = value; }

        //Thêm form vào stack
        static public void Add(Form form)
        {
            forms.Add(form);
        }

        //Xóa form
        static public void RemoveForm()
        {
            forms[forms.Count - 1].Close();
            forms.RemoveAt(forms.Count - 1);
        }

        //Thực hiện quay lui form
        static public void Back()
        {
            if (forms.Count > 0)
            {
                RemoveForm();
                if (forms.Count > 0)
                {
                   if (forms[forms.Count - 1].Name == "FDanhSachCongDan" ||
                            forms[forms.Count - 1].Name == "FDanhSachThue" ||
                            forms[forms.Count - 1].Name == "FDanhSachTamTruTamVang" ||
                            forms[forms.Count - 1].Name == "FDanhSachHoKhau"
                            )
                   {
                        for (int i = forms.Count - 2; i >= 0; i--)
                        {
                            if (forms[i].Name == "FDanhSach")
                            {
                                trangChu?.ChildForm.Open(forms[i]);
                                (forms[i] as FDanhSach).ChildForm.Open(forms[forms.Count - 1]);
                                break;
                            }
                        }
                    }
                    else if (forms[forms.Count - 1].Name == "FTachGopHo" ||
                            forms[forms.Count - 1].Name == "FThemNguoiVaoHo")
                    {
                        for (int i = forms.Count - 2; i >= 0; i--)
                        {
                            if (forms[i].Name == "FDangKyHoKhau")
                            {
                                trangChu?.ChildForm.Open(forms[i]);
                                (forms[i] as FDangKyHoKhau).ChildForm.Open(forms[forms.Count - 1]);
                                break;
                            }
                        }
                    }
                    else if (forms[forms.Count - 1].Name == "FThongKeThue" ||
                            forms[forms.Count - 1].Name == "FThongKeCongDan" ||
                            forms[forms.Count - 1].Name == "FThongKePhanBo")
                    {
                        for (int i = forms.Count - 2; i >= 0; i--)
                        {
                            if (forms[i].Name == "FThongKe")
                            {
                                trangChu?.ChildForm.Open(forms[i]);
                                (forms[i] as FThongKe).ChildForm.Open(forms[forms.Count - 1]);
                                break;
                            }
                        }
                    }
                    else
                    {
                        forms[forms.Count - 1].Show();
                    }
                }
            }
        }

        //Xóa tất cả các form
        static public void ClearAll()
        {
            foreach (var form in forms) 
            {
                form.Close();
            }
            forms.Clear();
        }    
    }
}
