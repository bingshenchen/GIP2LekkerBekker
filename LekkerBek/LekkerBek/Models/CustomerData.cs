namespace LekkerBek.Models
{
    public class CustomerData
    {


        // Propertys
        private static List<Customer> customers;
        private static CustomerData instance;

        // Initial Value
        private CustomerData()
        {
            // Set initial values if necessary
            customers = new List<Customer> {
                new Customer(1, "Jan", "Jan.loly@example.com", "02 01 23 32", "Brussel", new DateTime(1990, 5, 15, 10, 30, 0), 10, "Mosselen met friet"),
                new Customer(2, "Jans", "Jans@ucll.be", "016 23 32 10", "Leueven", new DateTime(1978, 4, 12, 12, 20, 1), 8.8, "Chocolade en pralines"),
                new Customer(3, "Janssen", "Janssen.jan@gmail.com", "089 02 01 23", "Gent", new DateTime(2000, 2, 2, 2, 2, 2), 9.5, "Stoofvlees op Vlaamse wijze"),
                new Customer(4, "Sophie", "sophie.vandenbroeck@hotmail.com", "03 123 45 67", "Antwerpen", new DateTime(1995, 9, 18, 14, 30, 0), 9.7, "Wafels"),
                new Customer(5, "Maxime", "maxime.vervoort@yaohao.com", "011 98 76 54", "Hasselt", new DateTime(1988, 7, 6, 9, 0, 0), 8.7, "Frikandel speciaal"),
                new Customer(6, "Lucas", "lucas.somers@qq.com", "09 876 54 32", "Gent", new DateTime(2002, 11, 11, 11, 11, 0), 8.9, "Waterzooi"),
                new Customer(7, "Emma", "emma.janssens@126.com", "015 12 34 56", "Mechelen", new DateTime(1977, 3, 1, 15, 15, 0), 7.4, "Stoemp"),
                new Customer(8, "Jolien", "jolien.vandevenne@outlook.com", "050 12 34 56", "Brugge", new DateTime(1998, 1, 27, 18, 30, 0), 10, "Konijn met pruimen"),
                new Customer(9, "Pieter", "pieter.vanhoof@sina.com", "089 12 34 56", "Genk", new DateTime(1993, 6, 22, 12, 0, 0), 8.6, "Koninginnehapje"),
                new Customer(10, "Thomas", "thomas.claes@163.com", "02 234 56 78", "Brussel", new DateTime(1985, 12, 1, 20, 45, 0), 9.3, "Stoofpotje"),
                new Customer(11, "Lotte", "lotte.dewit@outlook.com", "03 456 78 90", "Antwerpen", new DateTime(2001, 4, 4, 4, 4, 0), 9, "Garnaalkroketten"),
                new Customer(12, "Ines", "Ines.jacobs@example.com", "09 345 67 89", "Gent", new DateTime(1996, 10, 10, 10, 10, 0), 8.7, "Paling in 't groen")
            };
        }

        public static CustomerData GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerData();
            }
            return instance;
        }

        public static List<Customer> GetCustomers()
        {
            GetInstance();
            return customers;
        }



        // Functions

        public static Customer GetCustomerByName(string name)
        {
            Customer result = null;
            foreach (Customer customer in GetCustomers())
            {
                if (customer.Name == name)
                {
                    result = customer;
                    break;
                }
            }
            return result;
        }


        public static Customer GetCustomerById(int id)
        {
            Customer result = null;
            foreach (Customer customer in GetCustomers())
            {
                if (customer.Id == id)
                {
                    result = customer;
                    break;
                }
            }
            return result;
        }


        public static void UpCustomer(int id, string name, string email, string phone, string adres, DateTime birthday, double loyaltyScore, string preferredDishes)
        {

            //using (var db = new DbContext()){ }

            Customer CustomerToUpdate = GetCustomerById(id);

            if (CustomerToUpdate != null)
            {
                CustomerToUpdate.Name = name;
                CustomerToUpdate.Email = email;
                CustomerToUpdate.Phone = phone;
                CustomerToUpdate.Adres = adres;
                CustomerToUpdate.Birthday = birthday;
                CustomerToUpdate.LoyaltyScore = loyaltyScore;
                CustomerToUpdate.PreferredDishes = preferredDishes;
            }

            // db.SaveChanges();
        }
        public static void AddCustomer(Customer customer)
        {
            int nextId = 0;
            foreach (Customer newCustomer in GetCustomers())
            {
                nextId = Math.Max(nextId, newCustomer.Id);
            }

            customer.Id = nextId + 1;
            GetCustomers().Add(new Customer(customer.Id, customer.Name, customer.Email, customer.Phone, customer.Adres, customer.Birthday, customer.LoyaltyScore, customer.PreferredDishes));
        }


    }
}
