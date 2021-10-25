using System;

namespace GildedRose
{
    public class ConjuredItem : Item
    {
        public override void UpdateItem()
        {
            if (Quality > 0)
            {
                Quality = Quality - 2;
            }

            SellIn--;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 2;
                }
            }
        }
    }
}