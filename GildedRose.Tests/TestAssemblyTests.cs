using GildedRose;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {

        [Theory]
        //Brie
        [InlineData(Value.Aging, "Aged Brie", 2, 0, "Aged Brie", 1, 1)]
        [InlineData(Value.Aging, "Aged Brie", 3, 1, "Aged Brie", 2, 2)]
        [InlineData(Value.Aging, "Aged Brie", 3, 50, "Aged Brie", 2, 50)]
        [InlineData(Value.Aging, "Aged Brie", -1, 50, "Aged Brie", (-2), 50)]
        [InlineData(Value.Aging, "Aged Brie", -1, 30, "Aged Brie", (-2), 32)]
        //Sulfuras
        [InlineData(Value.Legendary, "Sulfuras, Hand of Ragnaros", 0, 80, "Sulfuras, Hand of Ragnaros", 0, 80)]
        [InlineData(Value.Legendary, "Sulfuras, Hand of Ragnaros", -1, 80, "Sulfuras, Hand of Ragnaros", (-1), 80)]
        //Backstage pass
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", 15, 20, "Backstage passes to a TAFKAL80ETC concert", 14, 21)]
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", 14, 50, "Backstage passes to a TAFKAL80ETC concert", 13, 50)]
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", 9, 10, "Backstage passes to a TAFKAL80ETC concert", 8, 12)]
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", 5, 10, "Backstage passes to a TAFKAL80ETC concert", 4, 13)]
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", 5, 49, "Backstage passes to a TAFKAL80ETC concert", 4, 50)]
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", 5, 50, "Backstage passes to a TAFKAL80ETC concert", 4, 50)]
        [InlineData(Value.Backstage, "Backstage passes to a TAFKAL80ETC concert", -1, 50, "Backstage passes to a TAFKAL80ETC concert", (-2), 0)]
        //Normal items
        [InlineData(Value.Normal, "+5 Dexterity Vest", 10, 20, "+5 Dexterity Vest", 9, 19)]
        [InlineData(Value.Normal, "+5 Dexterity Vest", -1, 20, "+5 Dexterity Vest", -2, 18)]
        [InlineData(Value.Normal, "+5 Dexterity Vest", -1, 0, "+5 Dexterity Vest", -2, 0)]
        [InlineData(Value.Normal, "+5 Dexterity Vest", 1, 0, "+5 Dexterity Vest", 0, 0)]
        //Conjured items
        [InlineData(Value.Conjured, "Conjured Mana Cake", 10, 20, "Conjured Mana Cake", 9, 18)]
        [InlineData(Value.Conjured, "Conjured Mana Cake", -1, 20, "Conjured Mana Cake", -2, 16)]
        [InlineData(Value.Conjured, "Conjured Mana Cake", -1, 0, "Conjured Mana Cake", -2, 0)]
        [InlineData(Value.Conjured, "Conjured Mana Cake", 1, 0, "Conjured Mana Cake", 0, 0)]
        [InlineData(Value.Conjured, "Conjured Mana Cake", -1, 2, "Conjured Mana Cake", (-2), 0)]
        [InlineData(Value.Conjured, "Conjured Mana Cake", -1, 3, "Conjured Mana Cake", (-2), -1)]

        public void UpdateQuality(Value value, string name, int sellin, int quality, string expectedName, int expectedSellin, int expectedQuality)
        {
            var testItems = new List<Item>();

            if (value == Value.Aging)
            {
                AgingItem item = new AgingItem { Value = value, Name = name, SellIn = sellin, Quality = quality };
                testItems.Add(item);
            }
            if (value == Value.Backstage)
            {
                BackstagePass item = new BackstagePass { Value = value, Name = name, SellIn = sellin, Quality = quality };
                testItems.Add(item);
            }
            if (value == Value.Legendary)
            {
                LegendaryItem item = new LegendaryItem { Value = value, Name = name, SellIn = sellin, Quality = quality };
                testItems.Add(item);
            }
            if (value == Value.Conjured)
            {
                ConjuredItem item = new ConjuredItem { Value = value, Name = name, SellIn = sellin, Quality = quality };
                testItems.Add(item);
            }
            else
            {
                Item item = new Item { Value = value, Name = name, SellIn = sellin, Quality = quality };
                testItems.Add(item);
            }

            var p = new Program()
            {
                Items = testItems
            };

            p.UpdateQuality();

            Assert.Equal(expectedName, p.Items[0].Name);
            Assert.Equal(expectedSellin, p.Items[0].SellIn);
            Assert.Equal(expectedQuality, p.Items[0].Quality);
        }
    }
}