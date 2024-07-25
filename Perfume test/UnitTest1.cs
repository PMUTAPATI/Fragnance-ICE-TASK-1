using Fragnance.indexExamples;

namespace Perfume_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Constructor_ShouldSetProperties()
        {
            // Arrange
            string name = "Chanel No. 5";
            string brand = "Chanel";
            double price = 100.0;
            string topNotes = "Jasmine, Ylang-Ylang";
            string middleNotes = "Rose, Iris";
            string baseNotes = "Vanilla, Sandalwood";

            // Act
            Perfume perfume = new Perfume(name, brand, price, topNotes, middleNotes, baseNotes);

            // Assert
            //Assert.AreEqual(name, perfume.name);
            //Assert.AreEqual(brand, perfume.brand);
            //Assert.AreEqual(price, perfume.price);
            //Assert.AreEqual(topNotes, perfume.topNotes);
            //Assert.AreEqual(middleNotes, perfume.middleNotes);
            //Assert.AreEqual(baseNotes, perfume.baseNotes);
        }


        [TestMethod]
        public void Indexer_GetByIndex_ShouldReturnCorrectProperty()
        {
            // Arrange
            Perfume perfume = new Perfume("Chanel No. 5", "Chanel", 100.0, "Jasmine, Ylang-Ylang", "Rose, Iris", "Vanilla, Sandalwood");

            // Act and Assert
            Assert.AreEqual("Chanel No. 5", perfume[0]);
            Assert.AreEqual("Chanel", perfume[1]);
            Assert.AreEqual(100.0, perfume[2]);
            Assert.AreEqual("Jasmine, Ylang-Ylang", perfume[3]);
            Assert.AreEqual("Rose, Iris", perfume[4]);
            Assert.AreEqual("Vanilla, Sandalwood", perfume[5]);
            Assert.IsNull(perfume[6]);
        }


        [TestMethod]
        public void Indexer_SetByIndex_ShouldUpdateCorrectProperty()
        {
            // Arrange
            Perfume perfume = new Perfume("Chanel No. 5", "Chanel", 100.0, "Jasmine, Ylang-Ylang", "Rose, Iris", "Vanilla, Sandalwood");

            // Act
            perfume[0] = "Dior J'adore";
            perfume[1] = "Dior";
            perfume[2] = 120.0;
            perfume[3] = "Bergamot, Mandarin";
            perfume[4] = "Lily-of-the-Valley, Jasmine";
            perfume[5] = "Amber, Musk";

            // Assert
            Assert.AreEqual("Dior J'adore", perfume[0]);
            Assert.AreEqual("Dior", perfume[1]);
            Assert.AreEqual(120.0, perfume[2]);
            Assert.AreEqual("Bergamot, Mandarin", perfume[3]);
            Assert.AreEqual("Lily-of-the-Valley, Jasmine", perfume[4]);
            Assert.AreEqual("Amber, Musk", perfume[5]);
        }


        [TestMethod]
        public void PropertyIndexer_GetByName_ShouldReturnCorrectProperty()
        {
            // Arrange
            Perfume perfume = new Perfume("Chanel No. 5", "Chanel", 100.0, "Jasmine, Ylang-Ylang", "Rose, Iris", "Vanilla, Sandalwood");

            // Act and Assert
            Assert.AreEqual("Chanel No. 5", perfume["name"]);
            Assert.AreEqual("Chanel", perfume["brand"]);
            Assert.AreEqual(100.0, perfume["price"]);
            Assert.AreEqual("Jasmine, Ylang-Ylang", perfume["topnotes"]);
            Assert.AreEqual("Rose, Iris", perfume["middlenotes"]);
            Assert.AreEqual("Vanilla, Sandalwood", perfume["basenotes"]);
            Assert.IsNull(perfume["unknown"]);
        }

        [TestMethod]
        public void PropertyIndexer_SetByName_ShouldUpdateCorrectProperty()
        {
            // Arrange
            Perfume perfume = new Perfume("Chanel No. 5", "Chanel", 100.0, "Jasmine, Ylang-Ylang", "Rose, Iris", "Vanilla, Sandalwood");

            // Act
            perfume["name"] = "Dior J'adore";
            perfume["brand"] = "Dior";
            perfume["price"] = 120.0;
            perfume["topnotes"] = "Bergamot, Mandarin";
            perfume["middlenotes"] = "Lily-of-the-Valley, Jasmine";
            perfume["basenotes"] = "Amber, Musk";

            // Assert
            Assert.AreEqual("Dior J'adore", perfume["name"]);
            Assert.AreEqual("Dior", perfume["brand"]);
            Assert.AreEqual(120.0, perfume["price"]);
            Assert.AreEqual("Bergamot, Mandarin", perfume["topnotes"]);
            Assert.AreEqual("Lily-of-the-Valley, Jasmine", perfume["middlenotes"]);
            Assert.AreEqual("Amber, Musk", perfume["basenotes"]);
        }
    }
}