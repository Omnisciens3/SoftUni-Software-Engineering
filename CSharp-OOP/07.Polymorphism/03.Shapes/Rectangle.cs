using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double h, double w)
        {
            Height = h;
            Width = w;
        }

        public double Height 
        {
            get => height;
            private set => height = value; 
        }

        public double Width 
        {
            get => width;
            private set => width = value;
        }


        public override double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
