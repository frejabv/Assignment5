namespace GildedRose
{
    public class Item : IUpdateable
    {
        public Value Value { get; set; }
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
        public virtual void UpdateItem()
        {
            if (Quality > 0)
            {
                Quality--;
            }

            //decrease sellin
            SellIn--;
            //if sellin is negative
            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality--;
                }
            }
        }
    }
}