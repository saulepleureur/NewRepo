using NUnit.Framework;
using CommodityLibrary;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class OversizedTests
    {
        private Oversized GetTestOversized()
        {
            var oversizedItem = new Oversized(
                article: "OG789",
                name: "Шкаф",
                wholesalePrice: 8000.00m,
                retailPrice: 12000.00m,
                unit: UnitType.Pieces,
                description: "Большой платяной шкаф",
                stockQuantity: 5,
                length: 2.0m,
                width: 0.6m,
                height: 2.2m
            );
            return oversizedItem;
        }

        [Test]
        public void ConstructorTest()
        {
            var oversizedItem = GetTestOversized();

            Assert.That(oversizedItem.Article, Is.EqualTo("OG789"));
            Assert.That(oversizedItem.Name, Is.EqualTo("Шкаф"));
            Assert.That(oversizedItem.WholesalePrice, Is.EqualTo(8000.00m));
            Assert.That(oversizedItem.RetailPrice, Is.EqualTo(12000.00m));
            Assert.That(oversizedItem.Unit, Is.EqualTo(UnitType.Pieces));
            Assert.That(oversizedItem.Description, Is.EqualTo("Большой платяной шкаф"));
            Assert.That(oversizedItem.StockQuantity, Is.EqualTo(5));
            Assert.That(oversizedItem.Length, Is.EqualTo(2.0m));
            Assert.That(oversizedItem.Width, Is.EqualTo(0.6m));
            Assert.That(oversizedItem.Height, Is.EqualTo(2.2m));
        }

        [Test]
        public void GetInfoTest()
        {
            var oversizedItem = GetTestOversized();

            string expectedInfo = "Артикул: OG789\n" +
                                  "Наименование: Шкаф\n" +
                                  "Оптовая цена: 8000,00\n" +
                                  "Розничная цена: 12000,00\n" +
                                  "Единица измерения: Pieces\n" +
                                  "Описание: Большой платяной шкаф\n" +
                                  "Наличие на складе: 5\n" +
                                  "Размеры (ДxШxВ): 2,0x0,6x2,2";

            Assert.That(oversizedItem.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}