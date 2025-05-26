using NUnit.Framework;
using CommodityLibrary;
using System.Collections.Generic;
using System.Linq;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class WarehouseTests
    {
        [Test]
        public void Constructor_InitializesPropertiesAndList()
        {
            var goodsList = new List<Commodity>
            {
                new Commodity("C1", "Item 1", 10m, 15m, UnitType.Pieces, "Desc 1", 10),
                new Commodity("C2", "Item 2", 20m, 25m, UnitType.Packages, "Desc 2", 5),
                new Commodity("C1", "Item 1", 10m, 15m, UnitType.Pieces, "Desc 1", 10)
            };

            var warehouse = new Warehouse("Main Warehouse", goodsList);

            Assert.That(warehouse.Name, Is.EqualTo("Main Warehouse"), "Название склада должно быть инициализировано конструктором");

            Assert.That(warehouse.Count, Is.EqualTo(3), "Количество товаров на складе должно соответствовать количеству переданных уникальных товаров");
        }

        [Test]
        public void Count_ReturnsCorrectNumberOfItems()
        {
            var goodsList = new List<Commodity>
            {
                new Commodity("C1", "Item 1", 10m, 15m, UnitType.Pieces, "Desc 1", 10),
                new Commodity("C2", "Item 2", 20m, 25m, UnitType.Packages, "Desc 2", 5)
            };
            var warehouse = new Warehouse("Another Warehouse", goodsList);

            Assert.That(warehouse.Count, Is.EqualTo(2), "Свойство Count должно возвращать фактическое количество товаров");
        }

        [Test]
        public void IEnumerable_AllowsIteration()
        {
            var goodsList = new List<Commodity>
            {
                new Commodity("C1", "Item 1", 10m, 15m, UnitType.Pieces, "Desc 1", 10),
                new Commodity("C2", "Item 2", 20m, 25m, UnitType.Packages, "Desc 2", 5)
            };
            var warehouse = new Warehouse("Iterable Warehouse", goodsList);

            var iteratedItems = new List<Commodity>();
            foreach (var item in warehouse)
            {
                iteratedItems.Add(item);
            }
            Assert.That(iteratedItems.Count, Is.EqualTo(goodsList.Count), "Количество элементов при переборе должно совпадать с исходным списком");

            for (int i = 0; i < goodsList.Count; i++)
            {
                Assert.That(iteratedItems[i], Is.SameAs(goodsList[i]), $"Элемент {i} при переборе должен совпадать с элементом из исходного списка");
            }
        }
    }
}
