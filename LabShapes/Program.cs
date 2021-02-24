﻿using Shapes;
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
            Console.Write("\nPlease press any key to exit.");
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

            int count = 1;
            foreach (var shape in ShapeList)
            {
                if (shape is Triangle)
                {
                    var triangle = shape as Triangle;
                    circTriangles += triangle.Circumference;
                    Console.WriteLine($"#{count++}: {triangle}");
                    
                    //foreach (var triangleCorners in ShapeList)
                    //{
                    //    Console.WriteLine($"Triangelhörn {triangleCorners}");
                        
                    //}
                }
                else
                {
                    Console.WriteLine($"#{count++}: {shape}");
                    
                }

                averageShapeArea += shape.Area;

                if (shape is Shape3D)
                {
                    shape3D = shape as Shape3D;
                    if (biggestVolume < shape3D.Volume)
                    {
                        biggestVolume = shape3D.Volume;
                        largestShape = shape3D.ToString(); //TODO Göra if-satser, shape is Cuboid, Cube, Sphere
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            
            Console.WriteLine("\n+---------------------------------+\n");
            Console.WriteLine($"Total circ. for triangles is {circTriangles},");
            Console.WriteLine($"and the average area is {averageShapeArea / 20}.");
            Console.WriteLine($"{largestShape} is the biggest with a volume of {biggestVolume}.");             //shape3D kan inte skriva ut vilkent typ av form
        }

    }
}
