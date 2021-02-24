using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        public Vector3 position;
        public Vector3 size;
       

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.size = size;
            this.position = center;
            
        }

        public Cuboid(Vector3 center, float width)
        {
            this.position = center;
            this.size = new Vector3(width, width, width);
            
        }
        public override float Volume => (size.X * size.Y * size.Z);
        

        public override Vector3 Center => Center;
        

        public override float Area => (2 * size.X * size.Y) + (2 * size.X * size.Y) + (2 * size.X * size.Y);
        

        public bool IsCube()
        {
            if (size.X == size.Y && size.X == size.Z)
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
            if (IsCube())
            {
                return $"Cube @({position.X}, {position.Y}) | w, h, l = {size.X}";
            }
            else 
            {
                return $"Cuboid @({position.X}, {position.Y}) | w = {size.X}, h = {size.Y}, l = {size.Z}";
            }
        }

    }
}
