namespace Tamrin02
{
    public class Square
    {
        // Properties
        public double Side { get; set; }
        public string Color { get; set; }

        // Methods
        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public void Resize(double newSide)
        {
            Side = newSide;
        }
    }
}
