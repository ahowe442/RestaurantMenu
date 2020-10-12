using System;
using System.Collections.Generic;

namespace RestauraantMenu
{
    public class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItem> MenuItems { get; set; }
 

        public Menu()
        {
            LastUpdated = DateTime.Now;
            MenuItems = new List<MenuItem>
            {
                new MenuItem("Jalapeno Poppers", 6.45, "Jalapeno's filled with cream cheese, breadded and deep fried.", Category.APPETIZER, false),
                new MenuItem("Rum & Coke", 5.35, "Also known as a cuba libre, consists of 2oz. of run and remainder filled with coke.", Category.DRINK, true),
                new MenuItem("10 oz. Sirloin", 14.95, " best damn steak in the world", Category.MAIN_COURSE, false),
                new MenuItem("Ice Cream", 4.98, "Cold dessert", Category.DESSERT, true)

            };
        
        }
    }

    
}
