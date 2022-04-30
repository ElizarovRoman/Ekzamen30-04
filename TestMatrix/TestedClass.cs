using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMatrix
{
    class TestedClass
    {
        public static bool test(int[] row, int[] rowT)
        {
            Array.Sort(row);
            Array.Sort(rowT);
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != rowT[i]) return false;
            }
            return true;
        }
    }
}
