namespace Tamrin02
{
    public class Dog
    {
        // Properties
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }

        // Methods
        public void Bark()
        {
            Console.WriteLine(Name + " says: Woof!");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }

        public void Run()
        {
            Console.WriteLine(Name + " is running.");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping.");
        }
    }
}
