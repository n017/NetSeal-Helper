using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSeal_Helper.NetSeal;

namespace NetSeal_Helper.Forms
{
    public partial class NewsForm : Form
    {
        List<NewsPost> News = new List<NewsPost>();

        public NewsForm(List<NewsPost> news)
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

        private void PopUpMessage()
        {
            if (this.ltvNews.SelectedItems.Count > 0)
            {
                var message = News[ltvNews.SelectedIndices[0]].PostMessage;
                var title = News[ltvNews.SelectedIndices[0]].Name;
                var viewMessage = new ViewMessageForm(message, title);
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
