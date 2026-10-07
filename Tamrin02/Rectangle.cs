namespace Tamrin02
{
    public class Rectangle
    {
        // Properties
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        // Methods
        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public void Resize(double newWidth, double newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }
    }
}
