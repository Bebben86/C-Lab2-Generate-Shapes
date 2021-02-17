using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


public class Sphere : Shape3D
{
    public Sphere(Vector3 center, float radius)
    {
        public Vector3 center;
        public float radius;

        _radius = radius;
        Center = center;
        Area = (float)(4 * Math.PI * Math.Pow(_radius, 2));
        Volume = (float)(0.75D * Math.PI * Math.Pow(_radius, 3));
    }


}
