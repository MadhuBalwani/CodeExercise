
namespace FSLCodeExercise
{
    class Square : Shape
    {
        private double width;

        public double Width
        {
            get
            {
                return width;
            }
        }

        public Square(double width)
        {
            this.width = width;
        }

        public override double Area()
        {
            return Width * Width;
        }
    }
}
