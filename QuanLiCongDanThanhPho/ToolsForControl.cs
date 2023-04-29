namespace QuanLiCongDanThanhPho
{
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

        public Turn State {set => state = value; }

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
                ctr.BackColor = Color.SteelBlue;
            }
            foreach (var ctr in needUnEnabled)
            {
                ctr.Enabled = true;
            }
            state = Turn.on;
        }    
    }
}
