using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2SanwichBuilder
{
    internal class Order
    {

        public SortedList<string, double> GetCheckedListBox(CheckedListBox checkedListBox)
        {
            SortedList<string, double> selectedBread = new SortedList<string, double>();


            if (checkedListBox.SelectedItem != null)
            {
                // Split the selected item into key and value
                string selectedItem = checkedListBox.SelectedItem.ToString();
                string[] parts = selectedItem.Split('$');
                if (parts.Length == 2)
                {
                    string key = parts[0];
                    if (double.TryParse(parts[1], out double value))
                    {
                        selectedBread.Add(key, value);
                    }
                }
            }
            return selectedBread;
        }

        public SortedList<string, double> GetListboxItem(ListBox listBox)
        {
            SortedList<string, double> selectedBread = new SortedList<string, double>();

            if (listBox.SelectedItem != null)
            {
                // Split the selected item into key and value
                string selectedItem = listBox.SelectedItem.ToString();
                string[] parts = selectedItem.Split('$');
                if (parts.Length == 2)
                {
                    string key = parts[0];
                    if (double.TryParse(parts[1], out double value))
                    {
                        selectedBread.Add(key, value);
                    }
                }
            }

            return selectedBread;
        }
        public SortedList<string, double> GetComboBoxItem(ComboBox comboBox)
        {
            SortedList<string, double> selectedBreadSize = new SortedList<string, double>();

            if (comboBox.SelectedItem != null)
            {
                // Split the selected item into key and value
                string selectedItem = comboBox.SelectedItem.ToString();
                string[] parts = selectedItem.Split('$'); 
                if (parts.Length == 2)
                {
                    string key = parts[0];
                    if (double.TryParse(parts[1], out double value))
                    {
                        selectedBreadSize.Add(key, value);
                    }
                }
            }
            return selectedBreadSize;
        }

    }
}
