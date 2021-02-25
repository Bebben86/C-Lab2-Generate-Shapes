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

            //foreach (Shape s in shapes)
            //{
            //    Console.WriteLine(s);
            //    Console.WriteLine();
            //}
            PrintValues(shapes);

            Console.ForegroundColor = ConsoleColor.Yellow;

            
            Console.WriteLine("\n+---------------------------------+\n");
            Console.WriteLine("This was Lab2 by Andreas Nilsson.");
            Console.Write("Please press any key to exit.");
            Console.ReadKey();
        }

        //Beräkna och skriv ut snittarean för alla shapes, omkretsen av alla trianglar och hitta största volymen.
        public static void PrintValues(List<Shape> ShapeList)
        {
            float circTriangles = 0;
            float averageShapeArea = 0;
            float biggestVolume = 0;
            string largestShape = "";
            Shape3D shape3D;

            int lineCount = 1;
            foreach (var shape in ShapeList)
            {
                if (shape is Triangle)
                {
                    var triangle = shape as Triangle;
                    circTriangles += triangle.Circumference;
                    Console.WriteLine($"#{lineCount++}: {triangle}");
                    
                }
                else
                {
                    Console.WriteLine($"#{lineCount++}: {shape}");
                    
                }

                averageShapeArea += shape.Area;

                if (shape is Shape3D)
                {
                    shape3D = shape as Shape3D;
                    if (biggestVolume < shape3D.Volume)
                    {
                        biggestVolume = shape3D.Volume;
                        largestShape = shape3D.ToString(); 
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            
            Console.WriteLine("\n+---------------------------------+\n");
            Console.Write($"Total circ. for triangles is {circTriangles}, ");
            Console.WriteLine($"and the average area of all shapes is {averageShapeArea / 20}.");
            Console.WriteLine($"{largestShape} is largest with a volume of {biggestVolume}.");
        }

    }
}
