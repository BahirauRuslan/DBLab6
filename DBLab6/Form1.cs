using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLab6
{
    public partial class Form1 : Form
    {
        private string[] _filters = 
        {
            "FullName LIKE 'Б%'",
            "Number < 10704000",
            "FullName LIKE 'А%'",
            "Number > 10701111"
        };

        private Lab6Manager _manager = new Lab6Manager();

        public Form1()
        {
            this.InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.mainDataGridView.DataSource = null;
            this.secondDataGridView.DataSource = null;
            this.leftListBox.SelectedIndex = -1;
            this.rightListBox.SelectedIndex = -1;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            var firstTable = this._manager.GetViewTableWithCalculatedColumn();
            var secondTable = this._manager.GetViewTable();
            this.SetFilters(firstTable, secondTable);
            this._manager.SetSortToDataView(firstTable, "FullName");
            this._manager.SetSortToDataView(secondTable, "Number");
            this.mainDataGridView.DataSource = firstTable;
            this.secondDataGridView.DataSource = secondTable;
        }

        private void SetFilters(DataView first, DataView second)
        {
            var filter = string.Empty;
            if (this.leftListBox.SelectedIndex > -1 && this.rightListBox.SelectedIndex > -1)
            {
                filter = this._filters[this.leftListBox.SelectedIndex] + " AND " + this._filters[this.rightListBox.SelectedIndex];
            }
            else if (this.leftListBox.SelectedIndex > -1)
            {
                filter = this._filters[this.leftListBox.SelectedIndex];
            }
            else if (this.rightListBox.SelectedIndex > -1)
            {
                filter = this._filters[this.rightListBox.SelectedIndex];
            }
            else
            {
                return;
            }

            this._manager.SetFilterToDataView(first, filter);
            this._manager.SetFilterToDataView(second, filter);
        }
    }
}
