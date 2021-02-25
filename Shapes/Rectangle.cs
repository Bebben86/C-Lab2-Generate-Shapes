using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Shapes
{
    class Rectangle : Shape2D
    {

        public Vector2 position;
        public Vector2 size;
        

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.size = size;
            this.position = center;

        }

        public Rectangle(Vector2 center, float width)
        {
            this.position = center;
            this.size = new Vector2(width, width);

        }

        public override float Area => (size.X * size.Y);
        

        public override float Circumference => ((2 * size.X) + (2 * size.Y));
        

        public override Vector3 Center => new Vector3(position, 0);
        

        public bool IsSquare()
        {
            if (size.X == size.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            if (IsSquare())
            {
                return $"Square @({position.X:0.0}, {position.Y:0.0}) | w, h = {size.X:0.0}"; //\n  Area = {Area}\n  Circ. = {Circumference}
            }
            else
            {
                return $"Rectangle @({position.X:0.0}, {position.Y:0.0}) | w = {size.X:0.0}, h = {size.Y:0.0}"; //\n  Area = {Area}\n  Circ. = {Circumference}
            }
        }

    }
}
