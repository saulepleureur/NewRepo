using NUnit.Framework;
using CommodityLibrary;

namespace CommodityLibrary.Tests
{
    [TestFixture]
    public class FragileTests
    {
        private Fragile GetTestFragile()
        {
            var fragileItem = new Fragile(
                article: "FG123",
                name: "Стеклянная ваза",
                wholesalePrice: 500.00m,
                retailPrice: 750.00m,
                unit: UnitType.Pieces,
                description: "Хрупкая декоративная ваза",
                stockQuantity: 20,
                maximumStackQuantity: 2
            );
            return fragileItem;
        }

        [Test]
        public void ConstructorTest()
        {
            var fragileItem = GetTestFragile();

            Assert.That(fragileItem.Article, Is.EqualTo("FG123"));
            Assert.That(fragileItem.Name, Is.EqualTo("Стеклянная ваза"));
            Assert.That(fragileItem.WholesalePrice, Is.EqualTo(500.00m));
            Assert.That(fragileItem.RetailPrice, Is.EqualTo(750.00m));
            Assert.That(fragileItem.Unit, Is.EqualTo(UnitType.Pieces));
            Assert.That(fragileItem.Description, Is.EqualTo("Хрупкая декоративная ваза"));
            Assert.That(fragileItem.StockQuantity, Is.EqualTo(20));
            Assert.That(fragileItem.MaximumStackQuantity, Is.EqualTo(2));
        }

        [Test]
        public void GetInfoTest()
        {
            var fragileItem = GetTestFragile();

            
            string expectedInfo = "Артикул: FG123\n" +
                                  "Наименование: Стеклянная ваза\n" +
                                  "Оптовая цена: 500,00\n" +
                                  "Розничная цена: 750,00\n" +
                                  "Единица измерения: Pieces\n" +
                                  "Описание: Хрупкая декоративная ваза\n" +
                                  "Наличие на складе: 20\n" +
                                  "Максимальное количество в стопке: 2";

            Assert.That(fragileItem.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
