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
using System.Windows.Forms;

namespace NetSeal_Helper.Forms
{
    public partial class frmGUIDChanger : Form
    {
        public string NewGUID
        {
            get;
            set;
        }

        public frmGUIDChanger(string guid)
        {
            InitializeComponent();
            this.txtNewGuid.Text = guid;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNewGuid.TextLength < 32)
            {
                MessageBox.Show("Make sure the Length of the new GUID are 32 chars", "Invalid GUID Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NewGUID = this.txtNewGuid.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}