namespace LekkerBek.Models
{
    public class EmployeeData

    {
        // Private static instance of the class
        private static EmployeeData instance = null;

        // Private constructor to prevent instantiation from outside
        private EmployeeData()
        {
            // Initialize data here
        }

        // Public static method to get the instance of the class
        public static EmployeeData GetInstance()
        {
            // Create a new instance if one doesn't already exist
            if (instance == null)
            {
                instance = new EmployeeData();
            }
            return instance;
        }

        // Methods and properties go here
        // ...


        
    }
}
