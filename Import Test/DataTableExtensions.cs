using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Import_Test
{
    public static class DataTableExtensions
    {
        public static void SetColumnsOrder(this DataTable dTable, params String[] columnNames)
        {
            int columnIndex = 0;
            foreach (var columnName in columnNames)
            {
                dTable.Columns[columnName].SetOrdinal(columnIndex);
                columnIndex++;
            }
        }
    }
}
