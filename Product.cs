namespace TDD_GuildedRose
{
    public class Product
    {
        public Product(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
        public Product(string name, int sellIn, int quality, string conjured)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            Conjured = conjured;
        }

        public string Name { get; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public string Conjured { get; set; } = string.Empty;

        public void UpdateProduct()
        {
            if (this.Name == "Aged Brie") UpdateAgedBrie();
            else if (this.Name == "Backstage Passes") UpdateBackstagePasses();
            else if (this.Name == "Sulfuras") UpdateSulfuras();
            else
            {
                if (this.Conjured == "Conjured") this.Quality -= 2;
                else
                {
                    this.SellIn--;
                    if (SellIn <= 0) this.Quality -= 2;
                    else
                    {
                        if (Quality > 0) this.Quality--;
                    }
                    if (Quality < 0) Quality = 0;
                }
            }
            
        }
        public void UpdateAgedBrie()
        {
            this.SellIn--;
            if (this.Quality < 50) this.Quality++;
            else this.Quality = 50;
        }
        public void UpdateBackstagePasses()
        {
            if (this.SellIn > 0) this.SellIn--;
            if (this.SellIn == 0) this.Quality = 0;
            else
            {
                if ((Math.Abs(this.SellIn - this.Quality)) <= 10)
                {
                    if ((Math.Abs(this.SellIn - this.Quality)) <= 5) this.Quality += 3;
                    else this.Quality += 2;
                }
            }
        }
        public void UpdateSulfuras()
        {
            this.Quality= 80;
        }
    }
}