namespace Tamrin02
{
    public class Cat
    {
        // Properties
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }

        // Methods
        public void Meow()
        {
            Console.WriteLine(Name + " says: Meow!");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping.");
        }

        public void Scratch()
        {
            Console.WriteLine(Name + " is scratching.");
        }
    }
}
