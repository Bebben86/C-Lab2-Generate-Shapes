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
        public Vector3 center;
        public Vector3 size;
        public Vector3 p1;
        public Vector3 p2;
        public Vector3 p3;

        public Cuboid(Vector3 center, Vector3 size)
        {
            size = size;
            center = center;
            
        }

        public Cuboid(Vector3 center, float width)
        {
            center = center;
            size = new Vector3(width, width, width);
            
        }
        public override float Volume 
        {
            get
            {
                return (size.X * size.Y * size.Z);
            }
        }

        public override Vector3 Center
        { 
        get
            {
                return center; 
            }
        }

        public override float Area 
        {
            get
            {
                return (2 * p1.X * p1.Y) + (2 * p2.X * p2.Y) + (2 * p3.X * p3.Y);
            }
        }

        public bool IsCube()
        {
            return ; //x = z, z = y
        }

        public override string ToString() 
        {
            return $"Cuboid @(): w = ";
        }

    }
}
