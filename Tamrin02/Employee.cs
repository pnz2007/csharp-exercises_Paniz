namespace Tamrin02
{
    public class Employee
    {
        // Properties
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }

        // Methods
        public void CheckIn()
        {
            Console.WriteLine(FirstName + " checked in.");
        }

        public void Work()
        {
            Console.WriteLine(FirstName + " is working as " + Position + ".");
        }

        public void RequestLeave()
        {
            Console.WriteLine(FirstName + " requested a leave.");
        }

        public void GetSalary()
        {
            Console.WriteLine(FirstName + " got " + Salary + " salary.");
        }
    }
}
