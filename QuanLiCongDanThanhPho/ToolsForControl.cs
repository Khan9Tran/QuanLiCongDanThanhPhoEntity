using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    //Dùng tự động bật tắt readonly và khả dụng cho button
    public class ToolsForControl
   {
        private List<TextBox> needReadOnly;
        private List<Control> needUnEnabled;
        private Turn state;

        public ToolsForControl(List<TextBox> needReadOnly, List<Control> needUnEnabled, Turn state)
        {
            this.needReadOnly = needReadOnly;
            this.needUnEnabled = needUnEnabled;
            this.state = state;
        }

        public enum Turn
        {
            on,
            off
        }

        //Xóa text nếu control là textbox
        public static void ClearTextBox(Control.ControlCollection Controls)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox)?.Clear();
                }
            }
        }
        public Turn State {set => state = value; }

        //Tự động bật tắt readonly
        public void AutoReadOnly()
        {
            if (state == Turn.on)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }

        }
        public void TurnOff()
        {
            foreach (var ctr in needReadOnly)
            {
                ctr.ReadOnly = true;
                ctr.BackColor = Color.Gainsboro;
            }
            foreach (var ctr in needUnEnabled)
            {
                ctr.Enabled = false;
            }
            state = Turn.off;
        }
        public void TurnOn()
        {
            foreach (var ctr in needReadOnly)
            {
                ctr.ReadOnly = false;
                ctr.BackColor = Color.FromArgb(167, 205, 231);
            }
            foreach (var ctr in needUnEnabled)
            {
                ctr.Enabled = true;
            }
            state = Turn.on;
        }

        public static void ReadOnly(List<TextBox> textBoxs, bool trangThai, Color color)
        {
            foreach (var textBox in textBoxs)
            {
                textBox.ReadOnly = trangThai;
                textBox.BackColor = color;
            }
        }
    }
}
