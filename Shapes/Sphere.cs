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

        public override float Volume 
        {
            get
            {
                return (float)(0.75d * Math.PI * Math.Pow(radius, 3)); //Dubbelkolla
            }
        }

        public override float Area
        { 
            get
            {
                return (float)(4 * Math.PI * Math.Pow(radius, 2)); //Dubbelkolla
            }
        }

        public override Vector3 Center
        { 
            get
            {
                return center;
            }
        }

        public override string ToString()
        {
            return $"Sphere @({Center.X}, {Center.Y}, {Center.Z}): r = {radius}";
        }

    }
}
