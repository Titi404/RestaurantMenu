using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class MenuItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public bool IsNew { get; set; }

        public MenuItem(string itemName, double price, string description, string category, bool isNew)
        {
            ItemName = itemName;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;

        }

        public override bool Equals(object? obj)
        {
            return obj is MenuItem item &&
                   ItemName == item.ItemName;
        }

        public override string? ToString()
        {
            return ($"{ItemName} {Price} {Description} {Category} {IsNew}");
        }


    }
}
