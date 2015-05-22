using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMan.Logging
{
    public static class Priority
    {
        public const int Lowest = 0;
        public const int Low = 1;
        public const int Normal = 2;
        public const int High = 3;
        public const int Highest = 4;
    }

    public static class Category
    {
        public const string General = "General";
        public const string Trace = "Trace";
    }
}
