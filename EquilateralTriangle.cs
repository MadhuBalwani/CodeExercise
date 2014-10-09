using System;

namespace FSLCodeExercise
{
    class EquilateralTriangle : Shape
    {       
        private double width;

        public double Width
        {
            get
            {
                return width;
            }
        }

        public EquilateralTriangle(double width)
        {
            this.width = width;
        }

        public override double Area()
        {
            return (Math.Sqrt(4) / 3) * Width * Width;
        }
    }
}
