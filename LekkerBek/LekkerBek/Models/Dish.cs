using System.Security.Cryptography;

namespace LekkerBek.Models
{

    public class Dish
    {
        // Propertys

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Initial Value
        // Private constructor

        public Dish(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Dish(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = 1;
        }

        public Dish(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Dish()
        {
        }


        // Functions




    }

}
