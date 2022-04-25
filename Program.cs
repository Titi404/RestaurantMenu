using System;
using System.Collections.Generic;


namespace RestaurantMenu
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuItem yumyum = new MenuItem("Yumyum", 50, "EAT AT YOUR OWN RISK", "DANGER", true);
            MenuItem spicyFriedChicken = new MenuItem("Spicy Fried Chicken", 15, "Sorry we don't include water", "Appetizer", false);
            MenuItem spicyFriedChicken1 = new MenuItem("Spicy Fried Chicken", 15, "Sorry we don't include water", "Appetizer", false);







            List<MenuItem> dishes = new List<MenuItem>()
                { yumyum, spicyFriedChicken, spicyFriedChicken1 };


            Menu colinRestaurant = new Menu(dishes);



            Console.WriteLine(yumyum);
            Console.WriteLine(colinRestaurant);


            //foreach (MenuItem food in dishes)
            //{
            //Console.WriteLine($"{food.ItemName} {food.Price} {food.Description} {food.Category} {food.IsNew}" );

            //}
            //var now = DateTime.Now.ToString();
            //DateTime.Parse(dateString);

            //Console.WriteLine(colinRestaurant.Dishes.ToString);
            //Console.WriteLine(spicyFriedChicken.Equals(spicyFriedChicken1));


            










        }



    }
}




