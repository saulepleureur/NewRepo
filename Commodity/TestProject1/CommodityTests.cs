using NUnit.Framework;
using CommodityLibrary;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class CommodityTests
    {
        [Test]
        public void CompareTo_SortsByArticle()
        {
            var commodityA = new Commodity("A100", "Item A", 10m, 15m, UnitType.Pieces, "Desc A", 10);
            var commodityB = new Commodity("B200", "Item B", 20m, 25m, UnitType.Pieces, "Desc B", 5);
            var commodityC = new Commodity("C300", "Item C", 30m, 35m, UnitType.Pieces, "Desc C", 15);
            var commodityA2 = new Commodity("A100", "Item A2", 12m, 18m, UnitType.Packages, "Desc A2", 8);

            Assert.That(commodityA.CompareTo(commodityB), Is.LessThan(0), "A100 должен быть меньше B200");
            Assert.That(commodityC.CompareTo(commodityA), Is.GreaterThan(0), "C300 должен быть больше A100");
            Assert.That(commodityB.CompareTo(commodityC), Is.LessThan(0), "B200 должен быть меньше C300");

            Assert.That(commodityA.CompareTo(commodityA2), Is.EqualTo(0), "Товары с одинаковым артикулом должны быть равны по CompareTo");

            Assert.That(commodityA.CompareTo(null), Is.GreaterThan(0), "Товар не должен быть меньше null");
        }
        [Test]
        public void GetInfoTest()
        {
            var commodity = new Commodity("12345", "Молоко", 50.00m, 70.00m, UnitType.Pieces, "Свежее молоко", 100);
            string expectedInfo = "Артикул: 12345\n" +
                                  "Наименование: Молоко\n" +
                                  "Оптовая цена: 50,00\n" +
                                  "Розничная цена: 70,00\n" +
                                  "Единица измерения: Pieces\n" +
                                  "Описание: Свежее молоко\n" +
                                  "Наличие на складе: 100";

            Assert.That(commodity.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
