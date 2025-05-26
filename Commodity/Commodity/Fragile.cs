using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityLibrary
{
    
    public class Fragile : Commodity
    {
        
        public int MaximumStackQuantity { get; set; }

        
        public Fragile(string article, string name, decimal wholesalePrice, decimal retailPrice, UnitType unit, string description, int stockQuantity, int maximumStackQuantity)
            
            : base(article, name, wholesalePrice, retailPrice, unit, description, stockQuantity)
        {
            MaximumStackQuantity = maximumStackQuantity;
        }

        
        public override string GetInfo()
        {
            
            string baseInfo = base.GetInfo();
            
            return baseInfo + $"\nМаксимальное количество в стопке: {MaximumStackQuantity}";
        }
    }
}
