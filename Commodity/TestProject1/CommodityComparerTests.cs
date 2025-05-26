using NUnit.Framework;
using CommodityLibrary;
using System.Collections.Generic;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class CommodityComparerTests
    {
        [Test]
        public void Compare_SortsByNameThenPrice()
        {
            var commodityA1 = new Commodity("A1", "Яблоко", 10m, 15m, UnitType.Pieces, "Красное яблоко", 10);
            var commodityA2 = new Commodity("A2", "Яблоко", 12m, 18m, UnitType.Pieces, "Зеленое яблоко", 8);
            var commodityB1 = new Commodity("B1", "Банан", 20m, 25m, UnitType.Pieces, "Желтый банан", 15);
            var commodityC1 = new Commodity("C1", "Груша", 30m, 35m, UnitType.Pieces, "Сочная груша", 20);

            IComparer<Commodity> comparer = new CommodityComparer();

            Assert.That(comparer.Compare(commodityB1, commodityA1), Is.LessThan(0), "Банан должен быть раньше яблока");
            Assert.That(comparer.Compare(commodityA1, commodityB1), Is.GreaterThan(0), "Яблоко должно быть позже банана");

            Assert.That(comparer.Compare(commodityA1, commodityA2), Is.LessThan(0), "Яблоко A1 (15m) должно быть раньше яблока A2 (18m)");
            Assert.That(comparer.Compare(commodityA2, commodityA1), Is.GreaterThan(0), "Яблоко A2 (18m) должно быть позже яблока A1 (15m)");

            Assert.That(comparer.Compare(commodityA1, commodityA1), Is.EqualTo(0), "Сравнение одного и того же объекта должно быть 0");

            Assert.That(comparer.Compare(commodityA1, null), Is.GreaterThan(0), "Товар не должен быть меньше null при сравнении через компаратор");
            Assert.That(comparer.Compare(null, commodityA1), Is.LessThan(0), "null должен быть меньше товара при сравнении через компаратор");
            Assert.That(comparer.Compare(null, null), Is.EqualTo(0), "null и null должны быть равны при сравнении через компаратор");
        }
    }
}