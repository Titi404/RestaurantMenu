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



            List<MenuItem> list = new List<MenuItem>()
                { yumyum, spicyFriedChicken };


            foreach (MenuItem food in list)
            {
            Console.WriteLine($"{food.ItemName} {food.Price} {food.Description} {food.Category} {food.IsNew}" );

            }
            //var now = DateTime.Now.ToString();
            //DateTime.Parse(dateString);

            //Console.WriteLine(s)








        }



    }
}




