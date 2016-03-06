//    Copyright(C) 2015/2016 Alcatraz Developer
//
//    This file is part of NetSeal Helper
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<http://www.gnu.org/licenses/>.

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
