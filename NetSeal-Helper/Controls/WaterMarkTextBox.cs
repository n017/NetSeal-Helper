using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSeal_Helper.Controls
{
    public partial class WaterMarkTextBox : TextBox
    {
        private Color _waterMarkColor = SystemColors.GrayText;
        [Category("WaterMark")]
        [Browsable(true)]
        [Description("Set the color associated to the watermark")]
        public Color WaterMarkColor
        {
            get { return _waterMarkColor; }
            set
            {
                _waterMarkColor = value;
                Invalidate();
            }
        }

        private string _waterMarkText = "WaterMark";
        [Category("WaterMark")]
        [Browsable(true)]
        [Description("Set the text associated to the watermark")]
        public string WaterMarkText
        {
            get { return _waterMarkText; }
            set
            {
                _waterMarkText = value;
                Invalidate();
            }
        }

        private Font _waterMarkFont = new Font("Verdana", 8.25f, FontStyle.Italic);
        [Category("WaterMark")]
        [Browsable(true)]
        [Description("Set the font associated to the watermark")]
        public Font WaterMarkFont
        {
            get { return _waterMarkFont; }
            set
            {
                _waterMarkFont = value;
                Invalidate();
            }
        }


        public WaterMarkTextBox()
        {
            InitializeComponent();
            this.Enter += JoinWaterMark;
            this.Leave += JoinWaterMark;
            this.TextChanged += JoinWaterMark;
        }

        private void JoinWaterMark(object sender, EventArgs e)
        {
            if (this.Text.Length <= 0)
                EnableWaterMark();
            else
            {
                DisableWaterMark();
            }
        }

        private void EnableWaterMark()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Refresh();
        }
        private void DisableWaterMark()
        {
            this.SetStyle(ControlStyles.UserPaint, false);
            this.Refresh();
        }
        

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            JoinWaterMark(null, null);            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Font drawFont = WaterMarkFont;
            Brush brushColor = new SolidBrush(WaterMarkColor);
            e.Graphics.DrawString(WaterMarkText, drawFont, brushColor, 0f, 0f); 
        }
    }
}
