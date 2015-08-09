using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSeal_Helper.Extensions
{
    public static class ListViewExtensions
    {
        public static string GetSubItemTextFromSelectedIndex(this ListView list, short cellIndex)
        {
            if (list.SelectedIndices.Count > 0)
                return list.Items[list.SelectedIndices[0]].SubItems[cellIndex].Text;
            else
                return null;
        }
        public static string[] GetSubItemsTextFromSelectedIndex(this ListView list)
        {
            if (list.SelectedIndices.Count > 0)
            {
                var subItems = list.Items[list.SelectedIndices[0]].SubItems;
                var result = new string[subItems.Count];

                for (int index = 0; index < subItems.Count; index++)
                {
                    result[index] = subItems[index].Text;
                }
                return result;
            }
            else
                return null;
        }
    }
}
