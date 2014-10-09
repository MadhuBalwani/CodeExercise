using System;

namespace FSLCodeExercise
{
    class Program
    {
        public enum ShapeType
        {
            Square = 1,
            Circle,
            EquilateralTriangle
        }

        static void Main(string[] args)
        {
            ShapeType type = 0;
            double width = 0.0;
            double area = 0.0;
            string userChoice = "";

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("FSL Code Exercise v1.0");
            Console.WriteLine();
            Console.WriteLine("Calculates and prints information for a user-supplied shape and width");
            Console.WriteLine("---------------------------------------------------------------------");

            do
            {
                Console.WriteLine("Do you want a square (1), circle (2), equilateral triangle (3): ");
                type = (ShapeType)int.Parse(Console.ReadLine());

                width = area = 0.0;

                switch (type)
                {
                    case ShapeType.Square:
                        Console.WriteLine("Enter the square's width: ");
                        width = double.Parse(Console.ReadLine());
                        Square sq = new Square(width);
                        area = sq.Area();
                        break;
                    case ShapeType.Circle:
                        Console.WriteLine("Enter the circle's radius: ");
                        width = double.Parse(Console.ReadLine());
                        Circle ci = new Circle(width);
                        area = ci.Area();
                        break;
                    case ShapeType.EquilateralTriangle:
                        Console.WriteLine("Enter the triangle's base: ");
                        width = double.Parse(Console.ReadLine());
                        EquilateralTriangle eq = new EquilateralTriangle(width);
                        area = eq.Area();
                        break;
                    default:
                        Console.WriteLine("Unknown type detected. Please try again.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Shape properties:");
                Console.WriteLine("\tWidth: " + width);
                Console.WriteLine("\tArea: " + area);

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue? - Yes or No");
                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }
    }
}
