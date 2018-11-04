using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows.RegistryEditor.Utils;

namespace Windows.RegistryEditor.Views.Controls
{
    public class ListViewEx : ListView
    {

        public ListViewEx()
        {
            CheckBoxes = true;
            FullRowSelect = true;
            GridLines = true;
        }

        public void SelectAllItems() => Utility.SelectAllItems(this);

        public void DeselectAllItems() => Utility.DeselectAllItems(this);

        public void CheckAllItems(bool value)
        {
            foreach (ListViewItem item in Items)
                item.Checked = value;
        }

        public string GetAllSelectedSubItemsText(int index)
        {
            string data = String.Empty;
            foreach (ListViewItem item in SelectedItems)
                data += item.SubItems[index].Text + Environment.NewLine;

            data = data.TrimEnd();

            return data;
        }

        public List<string> GetAllSelectedSubItemsTextList(int index)
        {
            List<string> newList = new List<string>();
            foreach (ListViewItem item in SelectedItems)
                newList.Add(item.SubItems[index].Text);

            return newList;
        }

        public List<string> GetAllCheckedSubItemsTextList(int index)
        {
            List<string> newList = new List<string>();
            foreach (ListViewItem item in CheckedItems)
                newList.Add(item.SubItems[index].Text);

            return newList;
        }
    }
}
