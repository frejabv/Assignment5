using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {

        [Theory]
        //Brie
        [InlineData("Aged Brie", 2, 0, "Aged Brie", 1, 1)]
        [InlineData("Aged Brie", 3, 1, "Aged Brie", 2, 2)]
        [InlineData("Aged Brie", 3, 50, "Aged Brie", 2, 50)]
        [InlineData("Aged Brie", -1, 50, "Aged Brie", (-2), 50)]
        [InlineData("Aged Brie", -1, 30, "Aged Brie", (-2), 32)]
        //Sulfuras
        [InlineData("Sulfuras, Hand of Ragnaros", 0, 80, "Sulfuras, Hand of Ragnaros", 0, 80)]
        [InlineData("Sulfuras, Hand of Ragnaros", -1, 80, "Sulfuras, Hand of Ragnaros", (-1), 80)]
        //Backstage pass
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 15, 20, "Backstage passes to a TAFKAL80ETC concert", 14, 21)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 14, 50, "Backstage passes to a TAFKAL80ETC concert", 13, 50)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 9, 10, "Backstage passes to a TAFKAL80ETC concert", 8, 12)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 5, 10, "Backstage passes to a TAFKAL80ETC concert", 4, 13)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 5, 49, "Backstage passes to a TAFKAL80ETC concert", 4, 50)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 5, 50, "Backstage passes to a TAFKAL80ETC concert", 4, 50)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -1, 50, "Backstage passes to a TAFKAL80ETC concert", (-2), 0)]
        //Other items
        [InlineData("+5 Dexterity Vest", 10, 20, "+5 Dexterity Vest", 9, 19)]
        [InlineData("+5 Dexterity Vest", -1, 20, "+5 Dexterity Vest", -2, 18)]
        [InlineData("+5 Dexterity Vest", -1, 0, "+5 Dexterity Vest", -2, 0)]
        [InlineData("+5 Dexterity Vest", 1, 0, "+5 Dexterity Vest", 0, 0)]

        public void UpdateQuality(string name, int sellin, int quality, string expectedName, int expectedSellin, int expectedQuality)
        {
            var p = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = name, SellIn = sellin, Quality = quality}
                }
            };

            p.UpdateQuality();

            Assert.Equal(expectedName, p.Items[0].Name);
            Assert.Equal(expectedSellin, p.Items[0].SellIn);
            Assert.Equal(expectedQuality, p.Items[0].Quality);
        }

        https://github.com/danielpalme/ReportGenerator
    }
}