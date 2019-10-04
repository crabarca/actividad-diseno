using System;
using System.Collections.Generic;

namespace Activity2
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Item>
            {
                new Item(1, 10000),
                new Item(2, 20000),
                new Item(3, 15000),
                new Item(4, 22000),
                new Item(5, 7000),
                new Item(6, 35000),
                new Item(7, 30000),
                new Item(8, 26000),
                new Item(9, 40000),
                new Item(10, 45000),
                new Item(1, 10000),
                new Item(1, 10000),
                new Item(1, 10000),
                new Item(2, 20000)
            };
            
            var user = new User("Harry Hacker", 30, MembershipType.None, Gender.Male);
            
            var deals = new List<Deal>();
            deals.Add(new Deal(10000, new List<Item> {items[0], items[1]}));
            deals.Add(new Deal(5000, new List<Item> { items[0]}));

            var priceCalculator = new PriceCalculator(deals);
            var price = priceCalculator.CalculatePrice(items, user);
            Console.WriteLine($"Total to pay: {price}");
        }
    }
}