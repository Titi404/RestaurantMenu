using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class Menu
    {
        public List<MenuItem> Dishes { get; set; }
        public DateTime LastUpdated { get; set; }


        public Menu(List<MenuItem> dishes)
        {
            Dishes = dishes;
            LastUpdated = DateTime.Now;

        }


        public void AddDishes(MenuItem item)
        {
            Dishes.Add(item);
        }

        public void RemoveDishes(MenuItem item)
        {
            Dishes.Remove(item);
        }

        //public bool IsNew(MenuItem item)
        //{
        //    return item.IsNew;
        //}



        public void Print(MenuItem item)
        {


            Console.WriteLine(item);


        }

        public override string ToString()
        {
            string printAll = "";
            foreach (MenuItem item in Dishes)
            {
                printAll +=  item.ToString()+ "\n";
            }
            return printAll;

        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }




    }
    //public override string? ToString()
    //{
    //    return ($"{food.ItemName} {food.Price} {food.Description} {food.Category} {food.IsNew}");
    //}
}

