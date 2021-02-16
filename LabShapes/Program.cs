using Shapes;
using System;
using System.Collections.Generic;

namespace LabShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            }

            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
