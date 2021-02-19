﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape2D
    {
        Vector2 p1, p2, p3;     // Corners of triangle

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        // Referens: http://www.math.chalmers.se/~hasse/LINALG.pdf, Exempel 2.4, sid 8-9
        // Referens2: http://www.rasmus.is/sv/t/G/Su58k03.htm
        public override Vector3 Center => new Vector3((p1.X + p2.X + p3.X) / 3.0f, (p1.Y + p2.Y + p3.Y) / 3.0f, 0);
        public override float Circumference 
        {
            get
            {
                return (Vector2.Distance(p1, p2) + Vector2.Distance(p1, p3) + Vector2.Distance(p2, p3));
            }
        }
        public override float Area 
        {
            get
            {
                return (p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2f;
            }
        }
        public override string ToString()
        {
            return $"Triangle @({Center.X}, {Center.Y}): p1 = {p1}, p2 = {p2}, p3 = {p3}";
        }
    }
}
