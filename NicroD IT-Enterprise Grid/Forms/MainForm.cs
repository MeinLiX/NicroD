using NicroD_IT_Enterprise_Table.Forms;
using System;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Source.ResizeByColumn(this, dataGridView);
        }

        #region Buttons
        private async void AddNewItem_ClickAsync(object sender, EventArgs e)
        {
            new AddingForm(_context).ShowDialog(this);
            await Source.UpdateGrid(ref dataGridView, _context);
            Source.ResizeByColumn(this, dataGridView);
        }
        private async void SelectButton_ClickAsync(object sender, EventArgs e)
        {
            await Source.UpdateGrid(ref dataGridView, _context, listBox.SelectedItems);
            Source.ResizeByColumn(this, dataGridView);

        }
        #endregion

        #region Grids
        private void DataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Source.ResizeByColumn(this, dataGridView);
        }

        private void DataGridView_RowHeadersWidthChanged(object sender, EventArgs e)
        {
            Source.ResizeByColumn(this, dataGridView);
        }
        #endregion

    }
}
