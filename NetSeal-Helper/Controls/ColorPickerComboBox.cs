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
    public partial class ColorPickerComboBox : ComboBox
    {
        public ColorPickerComboBox()
        {
            InitializeComponent();
            this.Size = new Size(255, 22);

            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            //The visual designer auto set the items with all the strings, so copy the code bellow manually
            //var colors = Enum.GetNames(typeof(KnownColor));
            //this.Items.AddRange(colors);
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();
            var colorName = this.Items[e.Index].ToString();
            var color = Color.FromName(colorName);
            var pen = new Pen(color);
            var rectangle = new Rectangle(this.Size.Width - 111, e.Bounds.Top + 1, 90, 14);


            e.Graphics.DrawString(colorName, this.Font, new SolidBrush(this.ForeColor), 2, e.Bounds.Top + 1);
            e.Graphics.FillRectangle(pen.Brush, rectangle);
            e.DrawFocusRectangle();            
            
            pen.Dispose();
            e.Graphics.Dispose();

            base.OnDrawItem(e);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
