using System;
namespace RestauraantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, Category category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }

    public enum Category
    {
        DRINK,
        APPETIZER,
        MAIN_COURSE,
        SIDE,
        DESSERT

    }
}
