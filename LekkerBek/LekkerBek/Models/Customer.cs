namespace LekkerBek.Models
{
	public class Customer
	{
        // Propertys

        public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Adres { get; set; }
		public DateTime Birthday { get; set; }
        public double LoyaltyScore { get; set; }
        public string PreferredDishes { get; set; }

        // Initial Value

        public Customer(int id, string name, string email, string phone, string adres, DateTime birthday, double loyaltyScore, string preferredDishes)
		{
			Id = id;
			Name = name;
			Email = email;
			Phone = phone;
			Adres = adres;
            Birthday = birthday;
            LoyaltyScore = loyaltyScore;
            PreferredDishes = preferredDishes;
        }

        public Customer(string name, string email, string phone, string adres, DateTime birthday, double loyaltyScore, string preferredDishes)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Adres = adres;
            Birthday = birthday;
            LoyaltyScore = loyaltyScore;
            PreferredDishes = preferredDishes;
        }


    }
}