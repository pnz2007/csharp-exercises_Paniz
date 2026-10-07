namespace Tamrin02
{
    public class Customer
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Methods
        public void Register()
        {
            Console.WriteLine(FirstName + " " + LastName + " registered.");
        }

        public void PlaceOrder()
        {
            Console.WriteLine(FirstName + " placed an order.");
        }

        public void Pay()
        {
            Console.WriteLine(FirstName + " paid the bill.");
        }

        public void CancelOrder()
        {
            Console.WriteLine(FirstName + " canceled the order.");
        }
    }
}
