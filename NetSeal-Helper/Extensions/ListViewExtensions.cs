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

using System.Windows.Forms;

namespace NetSeal_Helper.Extensions
{
    public static class ListViewExtensions
    {
        /// <summary>
        /// Gets the SubItem of the selected index from a ListView Column 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cellIndex">The cell index</param>
        /// <returns><see cref="string"/></returns>
        public static string GetSubItemTextFromSelectedIndex(this ListView list, short cellIndex)
        {
            if (list.SelectedIndices.Count > 0)
                return list.Items[list.SelectedIndices[0]].SubItems[cellIndex].Text;
            else
                return null;
        }       
    }
}