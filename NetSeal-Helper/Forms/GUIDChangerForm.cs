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
    public partial class GUIDChangerForm : Form
    {
        public string NewGUID
        {
            get;
            set;
        }

        public GUIDChangerForm(string guid)
        {
            InitializeComponent();
            this.txtNewGuid.Text = guid;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NewGUID = this.txtNewGuid.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
