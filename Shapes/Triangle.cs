using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape2D
    {
        Vector2 p1, p2, p3;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        
        public override Vector3 Center => new Vector3((p1.X + p2.X + p3.X) / 3.0f, (p1.Y + p2.Y + p3.Y) / 3.0f, 0);
        public override float Circumference => (Vector2.Distance(p1, p2) + Vector2.Distance(p1, p3) + Vector2.Distance(p2, p3));
        
        public override float Area => (p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2f;
        
        public override string ToString()
        {
            return $"Triangle @({Center.X:0.0}, {Center.Y:0.0}) | p1 = {p1:0.0}, p2 = {p2:0.0}, p3 = {p3:0.0}"; //\n  Area = {Area}.\n  Circ. = {Circumference}
        }
    }
}
