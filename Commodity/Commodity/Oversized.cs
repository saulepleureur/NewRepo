using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityLibrary
{
    
    public class Oversized : Commodity
    {
        
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        
        public Oversized(string article, string name, decimal wholesalePrice, decimal retailPrice, UnitType unit, string description, int stockQuantity, decimal length, decimal width, decimal height)
            
            : base(article, name, wholesalePrice, retailPrice, unit, description, stockQuantity)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        
        public override string GetInfo()
        {
            
            string baseInfo = base.GetInfo();
            
            return baseInfo + $"\nРазмеры (ДxШxВ): {Length}x{Width}x{Height}";
        }
    }
}
