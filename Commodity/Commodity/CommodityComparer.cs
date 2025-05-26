using System;
using System.Collections.Generic;
using System.Globalization;

namespace CommodityLibrary
{
    public class CommodityComparer : IComparer<Commodity>
    {
        public int Compare(Commodity x, Commodity y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            int nameComparison = string.Compare(x.Name, y.Name, StringComparison.InvariantCultureIgnoreCase);

            if (nameComparison == 0)
            {
                return x.RetailPrice.CompareTo(y.RetailPrice);
            }

            return nameComparison;
        }
    }
}
