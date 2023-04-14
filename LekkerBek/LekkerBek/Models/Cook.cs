namespace LekkerBek.Models
{
    public class Cook: Employee
    {
        public int CookId { get; set; }
        public Cook(int employeeId)
        {
            base.EmployeeId = employeeId;
        }
    }
}
