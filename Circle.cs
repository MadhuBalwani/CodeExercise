using System;

namespace FSLCodeExercise
{
    class Circle : Shape
    {        
        private double width;

        public double Width
        {
            get
            {
                return width;
            }
        }

        public Circle(double width)
        {
            this.width = width;
        }

        public override double Area()
        {
            return Math.PI * (Width / 2) * (Width / 2);
        }
    }
}
