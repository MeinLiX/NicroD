using NicroD_IT_Enterprise_Table.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicroD_IT_Enterprise_Table
{
    public partial class MainForm : Form
    {
        private readonly BDC _context;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(BDC context_) : this()
        {
            _context = context_;
            Source.UpdateGrid(ref dataGridView, _context);
        }

        private async void AddNewItem_Click(object sender, EventArgs e)
        {
            new AddingForm(_context).ShowDialog(this);
            await Source.UpdateGrid(ref dataGridView, _context);
            Source.ResizeByColumn(this, dataGridView);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Source.ResizeByColumn(this, dataGridView);
        }

        private void DataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Source.ResizeByColumn(this, dataGridView);
        }

        private void DataGridView_RowHeadersWidthChanged(object sender, EventArgs e)
        {
            Source.ResizeByColumn(this, dataGridView);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var res = string.Empty;
            foreach (var i in listBox.SelectedItems) { res += i.ToString()+" "; }
            MessageBox.Show(res);
        }
    }
}
