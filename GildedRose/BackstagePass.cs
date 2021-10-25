using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class BackstagePass : Item
    {
        public override void UpdateItem()
        {
            if (Quality < 50)
            {
                Quality++;

                if (SellIn < 11 && Quality < 50)
                {
                    Quality++;
                }

                if (SellIn < 6 && Quality < 50)
                {
                    Quality++;
                }
            }
            //decrease sellin
            SellIn = SellIn - 1;
            //if sellin is negative
            if (SellIn < 0)
            {
                {
                    Quality = 0;
                }
            }
        }
    }
}

