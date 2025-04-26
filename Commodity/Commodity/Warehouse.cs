using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CommodityLibrary
{
    public class Warehouse : IEnumerable<Commodity>
    {
        public string Name { get; set; }

        public int Count
        {
            get { return _goodsList.Count; }
        }

        private List<Commodity> _goodsList;

        public Warehouse(string name, IEnumerable<Commodity> goods)
        {
            Name = name;
            _goodsList = new List<Commodity>();

            foreach (var item in goods)
            {
                if (!_goodsList.Contains(item))
                {
                    _goodsList.Add(item);
                }
            }
        }
        public IEnumerator<Commodity> GetEnumerator()
        {
            return _goodsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
