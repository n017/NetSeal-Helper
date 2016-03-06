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
using System.Windows.Forms;
using NetSeal_Helper.NetSeal;

namespace NetSeal_Helper.Forms
{
    public partial class frmNews : Form
    {
        List<NewsPost> News = new List<NewsPost>();

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="news"></param>
        /// <exception cref="Exception"></exception>
        public frmNews(List<NewsPost> news)
        {
            InitializeComponent();

            if (news == null)
                throw new Exception("news");

            this.News = news;

            ltvNews.Columns.Add("ID").Width = 100;
            ltvNews.Columns.Add("Name").Width = ltvNews.Width - 305;
            ltvNews.Columns.Add("Creation Date").Width = 200;

            news.Sort((x, y) => x.ID.CompareTo(y.ID));

            for (int index = 0; index < news.Count; index++)
            {
                ltvNews.Items.Add(news[index].ID.ToString());
                ltvNews.Items[index].SubItems.Add(news[index].Name);
                ltvNews.Items[index].SubItems.Add(news[index].Time.ToString());   
            }           
        }

        /// <summary>
        /// Display a message with the news message
        /// </summary>
        private void PopUpMessage()
        {
            if (this.ltvNews.SelectedItems.Count > 0)
            {
                var title = News[ltvNews.SelectedIndices[0]].Name;
                var message = News[ltvNews.SelectedIndices[0]].PostMessage;
                var viewMessage = new frmViewMessage(title, message);
                viewMessage.ShowDialog();
                viewMessage.Dispose();
            }
        }

        private void viewMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopUpMessage();
        }
        private void ltvNews_DoubleClick(object sender, EventArgs e)
        {
            if (ltvNews.SelectedIndices.Count > 0)
                PopUpMessage();
        }
        private void ltvNews_SizeChanged(object sender, EventArgs e)
        {
            ltvNews.Columns[1].Width = ltvNews.Width - 305;
        }
    }
}