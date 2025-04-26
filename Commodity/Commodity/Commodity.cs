using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityLibrary
{
    public class Commodity : IComparable<Commodity>
    {
        public readonly string Article;
        public string Name { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public UnitType Unit { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        public Commodity(string article, string name, decimal wholesalePrice, decimal retailPrice, UnitType unit, string description, int stockQuantity)
        {
            Article = article;
            Name = name;
            WholesalePrice = wholesalePrice;
            RetailPrice = retailPrice;
            Unit = unit;
            Description = description;
            StockQuantity = stockQuantity;
        }

        public virtual string GetInfo()
        {
            return $"Артикул: {Article}\n" +
                   $"Наименование: {Name}\n" +
                   $"Оптовая цена: {WholesalePrice}\n" +
                   $"Розничная цена: {RetailPrice}\n" +
                   $"Единица измерения: {Unit}\n" +
                   $"Описание: {Description}\n" +
                   $"Наличие на складе: {StockQuantity}";
        }
        public int CompareTo(Commodity other)
        {
            if (other == null) return 1;

            return string.Compare(this.Article, other.Article, StringComparison.Ordinal);
        }
    }
}
