using System;
using System.Collections.Generic;

namespace Activity2
{
    public class PriceCalculator
    {
        public List<Deal> Deals { get; }

        public PriceCalculator(List<Deal> deals)
        {
            Deals = deals;
        }
        
        public decimal CalculatePrice(List<Item> items, User user)
        {
            // A flag associated with each item.
            // Starts at false, but becomes true when the item belongs to a promotion.
            // This prevents applying multiple promotions to the same item.
            var checks = new Dictionary<Item, bool>();
            var total = 0m;

            foreach (var item in items)
            {
                total += item.Price;
            }

            foreach (var deal in Deals)
            {
                // Number of times this deal is present amongst the client's items
                int numberOfDiscounts = 0;

                while (true)
                {
                    // Temp list of items, holds deal items' subset
                    var theItems = new List<Item>();
                    var count = 0;

                    foreach (var dealItem in deal.Items)
                    {
                        var temp = items.Find(i => i.Id == dealItem.Id && !checks.ContainsKey(i) && !theItems.Contains(i));
                        if (temp != null)
                        {
                            theItems.Add(temp);
                            count++;
                        }
                    }

                    // If every item in the deal is present in the current shopping list, apply discount.
                    if (count == deal.Items.Count)
                    {
                        numberOfDiscounts++;
                        foreach (var item in theItems)
                        {
                            checks[item] = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
                // A deal may be present multiple times in the shopping list.
                for (int i = 0; i < numberOfDiscounts; i++)
                {
                    foreach (var item in deal.Items)
                    {
                        total -= item.Price;
                    }
                    
                    total += deal.Price;
                }
            }

            var dateTime = DateTime.Now;
            
            if (total >= 200000 && user.Membership == MembershipType.Silver && dateTime.Hour >= 12 && dateTime.Hour <= 16)
            {
                total -= 10000;
            } 
            else if (total >= 200000 && user.Membership == MembershipType.Gold)
            {
                total -= 15000;
            }
            else if (total >= 300000 && user.Membership == MembershipType.Platinum)
            {
                total -= 40000;
            } else if (total >= 200000 && user.Membership == MembershipType.Platinum)
            {
                total -= 20000;
            }
            
            if (dateTime.DayOfWeek == DayOfWeek.Thursday || dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                total *= 0.9m;
            }

            if (user.Gender == Gender.Male && user.Age >= 65 || user.Gender == Gender.Female && user.Age >= 60)
            {
                total *= 0.85m;
            }
            
            return total;
        }
    }
}