using PrintingHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouse
{
    public class SortingByCirculation : IComparer<Books>
    {
        public int Compare(Books? x, Books? y)
        {
            if (x.Circulation.CompareTo(y.Circulation) != 0)
            {
                return x.Circulation.CompareTo(y.Circulation);
            }
            return 0;
        }
    }
}
