﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape2D
    {
        private Vector2 position;
        private float radius;
        public Circle(Vector2 center, float radius)
        {
            this.position = center;
            this.radius = radius;
        }
        public override Vector3 Center => new Vector3(position, 0);
        public override float Circumference => (radius + radius) * MathF.PI;
        
        public override float Area => radius * radius * MathF.PI;
        
        public override string ToString()
        {
            return $"Circle @({position.X:0.0}, {position.Y:0.0}) | r = {radius:0.0}"; //\n  Area= {Area}\n  Circ. = {Circumference}
        }

    }
}
