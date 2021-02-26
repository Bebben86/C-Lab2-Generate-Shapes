using Shapes;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace LabShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            

            Console.Write("Do you want to enter a center position? (Y/N)  ");
            string answer = Console.ReadLine();
            Console.WriteLine();

            if (answer is "Y" || answer is "y")
            {
                Console.Write("Enter center position X:");
                float userCenterX = float.Parse(Console.ReadLine());
                Console.Write("Enter center position Y:");
                float userCenterY = float.Parse(Console.ReadLine());
                Console.Write("Enter center position Z:");
                float userCenterZ = float.Parse(Console.ReadLine());
                Console.WriteLine();

                
                for (int i = 0; i < 20; i++)
                {
                    shapes.Add(Shape.GenerateShape(new Vector3(userCenterX, userCenterY, userCenterZ)));
                }
                PrintValues(shapes);
                

            }
            else if (answer is "N" || answer is "n")
            {
                
                for (int i = 0; i < 20; i++)
                {
                    shapes.Add(Shape.GenerateShape());
                }
                PrintValues(shapes);
                
            }
            else
            {
                Console.WriteLine("Invalid input. Program will exit."); 
            }

            

           
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
                    Console.WriteLine($"#{lineCount++}:\t {triangle}");
                    
                }
                else
                {
                    Console.WriteLine($"#{lineCount++}:\t {shape}");
                    
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
