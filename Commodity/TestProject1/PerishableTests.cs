using NUnit.Framework;
using CommodityLibrary;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class PerishableTests
    {
        private Perishable GetTestPerishable()
        {
            var perishableItem = new Perishable(
                article: "PG456",
                name: "Молоко",
                wholesalePrice: 50.00m,
                retailPrice: 70.00m,
                unit: UnitType.Packages,
                description: "Свежее молоко в пакетах",
                stockQuantity: 100,
                maximumStorageLifeDays: 7
            );
            return perishableItem;
        }

        [Test]
        public void ConstructorTest()
        {
            var perishableItem = GetTestPerishable();

            Assert.That(perishableItem.Article, Is.EqualTo("PG456"));
            Assert.That(perishableItem.Name, Is.EqualTo("Молоко"));
            Assert.That(perishableItem.WholesalePrice, Is.EqualTo(50.00m));
            Assert.That(perishableItem.RetailPrice, Is.EqualTo(70.00m));
            Assert.That(perishableItem.Unit, Is.EqualTo(UnitType.Packages));
            Assert.That(perishableItem.Description, Is.EqualTo("Свежее молоко в пакетах"));
            Assert.That(perishableItem.StockQuantity, Is.EqualTo(100));
            Assert.That(perishableItem.MaximumStorageLifeDays, Is.EqualTo(7));
        }

        [Test]
        public void GetInfoTest()
        {
            var perishableItem = GetTestPerishable();

            string expectedInfo = "Артикул: PG456\n" +
                                  "Наименование: Молоко\n" +
                                  "Оптовая цена: 50,00\n" +
                                  "Розничная цена: 70,00\n" +
                                  "Единица измерения: Packages\n" +
                                  "Описание: Свежее молоко в пакетах\n" +
                                  "Наличие на складе: 100\n" +
                                  "Максимальный срок хранения (дни): 7";

            Assert.That(perishableItem.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
