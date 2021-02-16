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

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            throw new NotImplementedException();
        }
        public override float Volume => throw new NotImplementedException();

        public override Vector3 Center => throw new NotImplementedException();

        public override float Area => throw new NotImplementedException();

        public bool IsCube => throw new NotImplementedException();

        public override string ToString() => throw new NotImplementedException();

    }
}
