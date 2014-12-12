﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PhysxEngine
{
    public static class MathExtension
    {
        public static StillDesign.PhysX.MathPrimitives.Vector3 AsPhysX(this Vector3 vector)
        {
            return new StillDesign.PhysX.MathPrimitives.Vector3(vector.X, vector.Y, vector.Z);
        }

        public static StillDesign.PhysX.MathPrimitives.Matrix AsPhysX(this Matrix m)
        {
            return new StillDesign.PhysX.MathPrimitives.Matrix
            (
                m.M11, m.M12, m.M13, m.M14,
                m.M21, m.M22, m.M23, m.M24,
                m.M31, m.M32, m.M33, m.M34,
                m.M41, m.M42, m.M43, m.M44
            );
        }

    }
}
