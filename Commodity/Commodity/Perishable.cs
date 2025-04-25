using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityLibrary
{
    
    public class Perishable : Commodity
    {
        
        public int MaximumStorageLifeDays { get; set; }

        
        public Perishable(string article, string name, decimal wholesalePrice, decimal retailPrice, UnitType unit, string description, int stockQuantity, int maximumStorageLifeDays)
            
            : base(article, name, wholesalePrice, retailPrice, unit, description, stockQuantity)
        {
            MaximumStorageLifeDays = maximumStorageLifeDays;
        }

        
        public override string GetInfo()
        {
            
            string baseInfo = base.GetInfo();
            
            return baseInfo + $"\nМаксимальный срок хранения (дни): {MaximumStorageLifeDays}";
        }
    }
}
