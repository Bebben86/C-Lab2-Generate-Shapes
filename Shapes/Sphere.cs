using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Sphere : Shape3D
    {
        private Vector3 center;
        private float radius;

        public Sphere(Vector3 center, float radius)
        {
            this.radius = radius;
            this.center = center;
                        
        }

        public override float Volume => (float)(4.0/3 * Math.PI * Math.Pow(radius, 3));
        

        public override float Area => (float)(4 * Math.PI * Math.Pow(radius, 2));
        

        public override Vector3 Center => center;
        

        public override string ToString()
        {
            return $"Sphere @({Center.X:0.0}, {Center.Y:0.0}, {Center.Z:0.0}) | r = {radius:0.0}";
        }

    }
}
