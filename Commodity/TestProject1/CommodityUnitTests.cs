using NUnit.Framework;
using CommodityLibrary;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class CommodityUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            Commodity commodity = CreateTestCommodity();

            Assert.That(commodity.Article, Is.EqualTo("12345"));
            Assert.That(commodity.Name, Is.EqualTo("Молоко"));
            Assert.That(commodity.WholesalePrice, Is.EqualTo(50.00m));
            Assert.That(commodity.RetailPrice, Is.EqualTo(70.00m));
            Assert.That(commodity.Unit, Is.EqualTo(UnitType.Pieces));
            Assert.That(commodity.Description, Is.EqualTo("Свежее молоко"));
            Assert.That(commodity.StockQuantity, Is.EqualTo(100));
        }

        [Test]
        public void GetInfoTest()
        {
            Commodity commodity = CreateTestCommodity();
            string expectedInfo = "Артикул: 12345\n" +
                                  "Наименование: Молоко\n" +
                                  "Оптовая цена: 50,00\n" +
                                  "Розничная цена: 70,00\n" +
                                  "Единица измерения: Pieces\n" +
                                  "Описание: Свежее молоко\n" +
                                  "Наличие на складе: 100";

            Assert.That(commodity.GetInfo(), Is.EqualTo(expectedInfo));
        }

        private Commodity CreateTestCommodity()
        {
            return new Commodity("12345", "Молоко", 50.00m, 70.00m, UnitType.Pieces, "Свежее молоко", 100);
        }
    }
}