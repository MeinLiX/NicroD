using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicroD_IT_Enterprise_Table
{
    static class Source
    {
        public static Task UpdateGrid(ref DataGridView grid, BDC context)
        {
            grid.Columns.Clear();

            AddGridColumn(ref grid, "Date", "Organisation", "City", "Country", "Manager", "Count", "Sum", "id");

            var RegList = context.Regs;
            foreach (var item in RegList)
            {
                grid.Rows.Add(item.RegDate.ToString("dd-MM-yyyy"), item.RegOrgName, item.RegCityName, item.RegCountryName, item.RegManagerName, item.RegCount, item.RegTotalSum, item.Id);

            }
            return Task.CompletedTask;
        }

        public static void AddGridColumn(ref DataGridView grid, params object[] values)
        {
            foreach (var item in values)
            {
                grid.Columns.Add(new DataGridViewColumn
                {
                    HeaderText = item.ToString(),
                    Name = item.ToString() + "Column",
                    //Frozen = true,
                    CellTemplate = new DataGridViewTextBoxCell()
                });
            }
        }
        public static void ResizeByColumn(Form form, DataGridView grid)
        {
            var WidthSize = grid.RowHeadersWidth + 20 + 110;
            foreach (DataGridViewColumn item in grid.Columns)
            {
                WidthSize += item.Width;
            }

            form.Width = WidthSize;
        }




    }
}
