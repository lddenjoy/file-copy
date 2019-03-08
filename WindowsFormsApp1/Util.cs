using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  class Util
    {
        public static bool IsNullOrEmpty(string[] arr)
        {
            return arr == null || arr.Length == 0;
        }

        public static bool IsNullOrEmpty(string str)
        {
            return str == null || str.Length == 0;
        }

    }
}
