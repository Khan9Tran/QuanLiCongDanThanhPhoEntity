using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    static internal class StackForm
    {
        static private List<Form> forms = new List<Form>();
        static public FTrangChu fTrangChu = new FTrangChu();
        static public void Add(Form form)
        {
            forms.Add(form);
        }
        static public void RemoveForm()
        {
            forms[forms.Count - 1].Close();
            forms.RemoveAt(forms.Count - 1);
        }
        static public void Back()
        {
            if (forms.Count > 0)
            {
                RemoveForm();
                if (forms.Count > 0)
                {
                    if (forms[forms.Count - 1].Name == "FDangKyCongDan" ||
                        forms[forms.Count - 1].Name == "FDangHoKhau" ||
                        forms[forms.Count - 1].Name == "FDangKyThue" ||
                        forms[forms.Count - 1].Name == "FDangKyHonNhan" ||
                        forms[forms.Count - 1].Name == "FDangKyTamTruTamVang" ||
                        forms[forms.Count - 1].Name == "FDangKyKhaiSinh" ||
                        forms[forms.Count - 1].Name == "FDangKyCCCD" ||
                        forms[forms.Count - 1].Name == "FDanhSach"
                        )
                    {
                        fTrangChu.OpenChildForm(forms[forms.Count - 1]);
                    }
                    else if (forms[forms.Count - 1].Name == "FDanhSachCongDan" ||
                            forms[forms.Count - 1].Name == "FDanhSachThue" ||
                            forms[forms.Count - 1].Name == "FDanhSachTamTruTamVang" ||
                            forms[forms.Count - 1].Name == "FDanhSachHoKhau"
                            )
                    {
                        for (int i = forms.Count - 2; i >= 0; i--)
                        {
                            if (forms[i].Name == "FDanhSach")
                            {
                                fTrangChu.OpenChildForm(forms[i]);
                                (forms[i] as FDanhSach).OpenChildForm(forms[forms.Count - 1]);
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
                                fTrangChu.OpenChildForm(forms[i]);
                                (forms[i] as FDangKyHoKhau).OpenChildForm(forms[forms.Count - 1]);
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
