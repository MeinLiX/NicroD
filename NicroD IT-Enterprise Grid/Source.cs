
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicroD_IT_Enterprise_Table
{
    static class Source
    {
        public class Searching
        {
            public string Result;
            public int Count;
            public decimal TotalSum;
        }

        public static Task UpdateGrid(ref DataGridView grid, BDC context)
        {
            grid.Columns.Clear();

            AddGridColumn(ref grid, "Date", "Organisation", "City", "Country", "Manager", "Count", "Sum", "id");
            grid.Columns[grid.Columns.Count - 1].Visible = false; //id not visible for user

            var RegList = context.Regs;
            foreach (var item in RegList)
                grid.Rows.Add(item.RegDate.ToString("dd-MM-yyyy"), item.RegOrgName, item.RegCityName, item.RegCountryName, item.RegManagerName, item.RegCount, item.RegTotalSum, item.Id);

            return Task.CompletedTask;
        }


        public static Task UpdateGrid(ref DataGridView grid, BDC context, ListBox.SelectedObjectCollection selectedItems)
        {
            if (selectedItems.Count > 1)
            {
                UpdateGrid(ref grid, context);
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column.HeaderText == "Count" || column.HeaderText == "Sum")
                        continue;

                    column.Visible = false;
                    foreach (var item in selectedItems)
                    {
                        if (column.HeaderText.ToLower() == item.ToString().ToLower())
                            column.Visible = true;
                    }
                }
            }
            else if (selectedItems.Count == 1)
            {
                grid.Columns.Clear();
                AddGridColumn(ref grid, selectedItems[0].ToString(), "Count", "Sum");

                IQueryable<Searching> search = null;
                switch (selectedItems[0].ToString())
                {
                    case "Organisation":
                        search = context.Regs.Select(o => new Searching { Result = o.RegOrgName, Count = context.Regs.Where(i => i.RegOrgName == o.RegOrgName).Sum(s => s.RegCount), TotalSum = context.Regs.Where(i => i.RegOrgName == o.RegOrgName).Sum(s => s.RegTotalSum) }).Distinct();
                        break;
                    case "City":
                        search = context.Regs.Select(o => new Searching { Result = o.RegCityName, Count = context.Regs.Where(i => i.RegCityName == o.RegCityName).Sum(s => s.RegCount), TotalSum = context.Regs.Where(i => i.RegCityName == o.RegCityName).Sum(s => s.RegTotalSum) }).Distinct();
                        break;
                    case "Country":
                        search = context.Regs.Select(o => new Searching { Result = o.RegCountryName, Count = context.Regs.Where(i => i.RegCountryName == o.RegCountryName).Sum(s => s.RegCount), TotalSum = context.Regs.Where(i => i.RegCountryName == o.RegCountryName).Sum(s => s.RegTotalSum) }).Distinct();
                        break;
                    case "Manager":
                        search = context.Regs.Select(o => new Searching { Result = o.RegManagerName, Count = context.Regs.Where(i => i.RegManagerName == o.RegManagerName).Sum(s => s.RegCount), TotalSum = context.Regs.Where(i => i.RegManagerName == o.RegManagerName).Sum(s => s.RegTotalSum) }).Distinct();
                        break;
                }

                if (search != null)
                    foreach (var item in search)
                        grid.Rows.Add(item.Result, item.Count, item.TotalSum);
                else
                    UpdateGrid(ref grid, context);
            }
            else
                UpdateGrid(ref grid, context);

            return Task.CompletedTask;
        }

        public static void AddGridColumn(ref DataGridView grid, params object[] values)
        {
            foreach (var item in values)
                grid.Columns.Add(new DataGridViewColumn
                {
                    HeaderText = item.ToString(),
                    Name = item.ToString() + "Column",
                    CellTemplate = new DataGridViewTextBoxCell()
                });

        }

        public static void ResizeByColumn(Form form, DataGridView grid)
        {

            var WidthSize = grid.RowHeadersWidth + 20 + 110; //110 - left panel | 20 - const integer for balance 

            foreach (DataGridViewColumn item in grid.Columns)
                if (item.Visible)
                    WidthSize += item.Width;

            form.Width = WidthSize;
        }

    }
}
