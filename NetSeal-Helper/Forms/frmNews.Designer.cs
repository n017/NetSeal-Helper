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

namespace NetSeal_Helper.Forms
{
    partial class frmNews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ltvNews = new System.Windows.Forms.ListView();
            this.cmsNews = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvNews
            // 
            this.ltvNews.ContextMenuStrip = this.cmsNews;
            this.ltvNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvNews.FullRowSelect = true;
            this.ltvNews.Location = new System.Drawing.Point(0, 0);
            this.ltvNews.Name = "ltvNews";
            this.ltvNews.Size = new System.Drawing.Size(599, 438);
            this.ltvNews.TabIndex = 0;
            this.ltvNews.UseCompatibleStateImageBehavior = false;
            this.ltvNews.View = System.Windows.Forms.View.Details;
            this.ltvNews.SizeChanged += new System.EventHandler(this.ltvNews_SizeChanged);
            this.ltvNews.DoubleClick += new System.EventHandler(this.ltvNews_DoubleClick);
            // 
            // cmsNews
            // 
            this.cmsNews.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsNews.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMessageToolStripMenuItem});
            this.cmsNews.Name = "cmsNews";
            this.cmsNews.Size = new System.Drawing.Size(155, 26);
            // 
            // viewMessageToolStripMenuItem
            // 
            this.viewMessageToolStripMenuItem.Name = "viewMessageToolStripMenuItem";
            this.viewMessageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewMessageToolStripMenuItem.Text = "View Message";
            this.viewMessageToolStripMenuItem.Click += new System.EventHandler(this.viewMessageToolStripMenuItem_Click);
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 438);
            this.Controls.Add(this.ltvNews);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::NetSeal_Helper.Properties.Resources.SkullIcon;
            this.MinimumSize = new System.Drawing.Size(615, 476);
            this.Name = "NewsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Net Seal News";
            this.cmsNews.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvNews;
        private System.Windows.Forms.ContextMenuStrip cmsNews;
        private System.Windows.Forms.ToolStripMenuItem viewMessageToolStripMenuItem;
    }
}