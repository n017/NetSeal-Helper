using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSeal_Helper.Forms
{
    public partial class ViewMessageForm : Form
    {
        public ViewMessageForm(string message, string title)
        {
            InitializeComponent();
            this.Text = title;
            this.rtbMessage.Text = message;
        }
    }
}
