using System.Net;

namespace LekkerBek.Models
{
    public class Employee
    {
        // Propertys
        public virtual int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adres { get; set; }
        // Initial Value

        public Employee()
        {
            EmployeeId = 0;
            Name = "None";
            Email = "None";
            Phone = "None";
            Adres = "None";
        }

        // Function
        public Employee(int employeeId, string name, string email, string phone, string adres)
        {
            EmployeeId = employeeId;
            Name = name;
            Email = email;
            Phone = phone;
            Adres = adres;
        }

        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId}, Name: {Name}, Email: {Email}, Phone: {Phone}, Address: {Adres}";
        }


    }
}
