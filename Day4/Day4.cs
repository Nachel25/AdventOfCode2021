using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Day4
{
    class Day4
    {
        private readonly string[] lines;

        public Day4(string filepath)
        {
            lines = File.ReadAllLines(filepath);
        }
    }
}
