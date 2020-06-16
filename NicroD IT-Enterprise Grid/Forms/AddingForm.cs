using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicroD_IT_Enterprise_Table.Forms
{
    public partial class AddingForm : Form
    {
        private readonly BDC _context;
        private bool IsValid()
        {
            if (OrgTextBox.Text != string.Empty)
                if (CityTextBox.Text != string.Empty)
                    if (CountryTextBox.Text != string.Empty)
                        if (ManagerTextBox.Text != string.Empty)
                            if (CountTextBox.Text != string.Empty)
                                if (SumTextBox.Text != string.Empty)
                                    return true;

            return false;
        }
        public AddingForm()
        {
            InitializeComponent();
        }
        public AddingForm(BDC context) : this()
        {
            _context = context;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                if (IsValid())
                {
                    try
                    {
                        var newReg = new Reg
                        {
                            RegDate = DateTimePicker.Value,
                            RegOrgName = OrgTextBox.Text,
                            RegCityName = CityTextBox.Text,
                            RegCountryName = CountryTextBox.Text,
                            RegManagerName = ManagerTextBox.Text,
                            RegCount = Convert.ToInt32(CountTextBox.Text),
                            RegTotalSum = Convert.ToInt32(SumTextBox.Text)
                        };

                        _context.Regs.Add(newReg);
                        await _context.SaveChangesAsync();
                        MessageBox.Show("Operation complete!", "Info");

                        MethodInvoker inv = delegate
                        {
                            this.Close();
                        };
                        this.Invoke(inv);

                        return;
                    }
                    catch { }
                }
                MessageBox.Show("Text boxes can't be empty.", "Warning");

            });
        }


        private void SumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void CountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
    }
}
