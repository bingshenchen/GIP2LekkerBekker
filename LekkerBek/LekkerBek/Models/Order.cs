namespace LekkerBek.Models
{
    public class Order
    {
        // Properties
        public int OrderId { get; set; }
        public int CookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Dish> Dishes { get; set; }

        // Constructor
        public Order(int orderId, int cookId, int customerId, DateTime orderDate)
        {
            OrderId = orderId;
            CookId = cookId;
            CustomerId = customerId;
            OrderDate = orderDate;
            Dishes = new List<Dish>
            {
                new Dish("Menu A", 25)
            };
        }
        public Order(int orderId, int cookId, int customerId, DateTime orderDate, List<Dish> dishes)
        {
            OrderId = orderId;
            CookId = cookId;
            CustomerId = customerId;
            OrderDate = orderDate;
            Dishes = dishes;
        }

        public Order(int cookId, int customerId, DateTime orderDate)
        {
            CookId = cookId;
            CustomerId = customerId;
            OrderDate = orderDate;
        }

        // Method to calculate total cost of the order
        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (Dish dish in Dishes)
            {
                totalCost += dish.Price * dish.Quantity;
            }
            return totalCost;
        }
    }
}
