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
        private readonly Vector3 _p1;
        private readonly Vector3 _p2;
        private readonly Vector3 _p3;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;

        }

        public Cuboid(Vector3 center, float width)
        {
            throw new NotImplementedException();
        }
        public override float Volume => _p1 * _p2 * _p3;

        public override Vector3 Center => (Vector3 ) / 8;

        public override float Area => throw new NotImplementedException();

        public bool IsCube()
        {
            if(_p1 == _p2 == _p3)
            {
            return true;
            }
            else
            {
            return false;
            }
        }

        public override string ToString() => throw new NotImplementedException();

    }
}
