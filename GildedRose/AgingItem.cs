using System;

namespace GildedRose
{
    public class AgingItem : Item
    {
        public override void UpdateItem()
        {
            {
                if (Quality < 50)
                {
                    Quality++;
                }
                //decrease sellin
                SellIn--;

                if (SellIn < 0)
                {
                    if (Quality < 50)
                    {
                        Quality++;
                    }
                }
            }
        }
    }
}