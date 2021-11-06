using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    [Serializable]
    class Vector3Ser
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3Ser(float X, float Y, float Z) {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

    }
}
