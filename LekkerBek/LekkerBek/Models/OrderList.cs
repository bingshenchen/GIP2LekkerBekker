namespace LekkerBek.Models
{
    public class OrderList
    {
        private static List<Order> orderList;
        private static OrderList instance;

        private OrderList()
        {
            orderList = new List<Order>()
            {
                new Order(1, 2, 1, new DateTime(2022, 5, 15, 10, 30, 0), new List<Dish>() { new Dish(12, "Menu A", 25, 2), new Dish(13, "Menu B", 25, 1),new Dish(1, "Stoemp", 1.5, 1), new Dish(4, "Tomatensoep met balletjes", 4.2, 9)}),
                new Order(2, 3, 3, new DateTime(2023, 3, 21, 15, 10, 0), new List<Dish>() { new Dish(13, "Menu B", 25, 1), new Dish(15, "Menu D", 25, 3), new Dish(9, "Kip aan 't spit", 9.7, 2) }),
                new Order(3, 4, 4, new DateTime(2021, 4, 17, 8, 5, 0), new List<Dish>() { new Dish(14, "Menu C", 25, 1), new Dish(15, "Menu D", 25, 1) }),
                new Order(4, 5, 5, new DateTime(2023, 5, 6, 23, 35, 0), new List<Dish>() { new Dish(12, "Menu A", 25, 1)}),
                new Order(5, 2, 3, new DateTime(2022, 8, 9, 14, 45, 0), new List<Dish>() { new Dish(14, "Menu C", 25, 2), new Dish(17, "Menu F", 25, 1) }),
                new Order(6, 3, 9, new DateTime(2021, 9, 30, 17, 10, 0), new List<Dish>() { new Dish(13, "Menu B", 25, 1), new Dish(14, "Menu C", 25, 2), new Dish(4, "Tomatensoep met balletjes", 4.2, 3) }),
                new Order(7, 4, 11, new DateTime(2023, 7, 4, 9, 0, 0), new List<Dish>() { new Dish(12, "Menu A", 25, 1), new Dish(17, "Menu F", 25, 3),new Dish(1, "Stoemp", 1.5, 1)})
            };
        }

        public static OrderList GetInstance()
        {
            if (instance == null)
            {
                instance = new OrderList();
            }
            return instance;
        }

        public static List<Order> GetOrderList()
        {
            GetInstance();
            return orderList;
        }
        public static Order GetOrderById(int orderId)
        {
            Order result = null;
            foreach (Order order in GetOrderList())
            {
                if (order.OrderId == orderId)
                {
                    result = order;
                    break;
                }
            }
            return result;
        }

        
        public static void AddOrder(Order order)
        {
            int nextId = 0;
            foreach (Order newOrder in GetOrderList())
            {
                nextId = Math.Max(nextId, newOrder.OrderId);
            }

            order.OrderId = nextId + 1;
            GetOrderList().Add(new Order(order.OrderId, order.CookId, order.CustomerId, order.OrderDate));
        }

        public static void UpdateOrder(int orderId, int cookId, int customerId, DateTime orderDate)
        {
            // using (var db = new DbContext()){ }
            Order orderToUpdate = GetOrderById(orderId);

            if ( orderToUpdate != null )
            {
                orderToUpdate.CookId = cookId;
                orderToUpdate.CustomerId = customerId;
                orderToUpdate.OrderDate = orderDate;
            }
            // db.SaveChanges();
        }
       
    }
}
