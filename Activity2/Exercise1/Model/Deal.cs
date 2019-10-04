using System.Collections.Generic;

namespace Activity2
{
    public class Deal
    {
        public decimal Price { get; }
        public List<Item> Items { get; }

        public Deal(int price, List<Item> items)
        {
            Price = price;
            Items = items;
        }
    }
}