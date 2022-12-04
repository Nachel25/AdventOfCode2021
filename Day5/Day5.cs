using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Day5
{
    class Day5
    {
        private readonly string[] lines;

        public Day5(string filepath)
        {
            lines = File.ReadAllLines(filepath);
            var dataTable = new DataTable();

            var splitLines = (from f in lines select f.Split(" -> ")).ToArray();

            int maxLength = (from s in splitLines select s.Length).Max();

            for (int i = 0; i < maxLength; i++)
            {
                dataTable.Columns.Add();
            }

            foreach (var line in splitLines)
            {
                DataRow row = dataTable.NewRow();
                row.ItemArray = (object[])line;
                dataTable.Rows.Add(row);
            }

            Console.WriteLine(dataTable.ToString());
        }
    }
}
