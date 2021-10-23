using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    class Cara
    {
        private Vector3 Centro;
        private Color ColorF;
        private Hashtable Vertices; 

        public Cara()
        {
            Centro = new Vector3(0, 0, 0);
            Vertices = new Hashtable();
            ColorF = Color.Black;
        }

        public Cara(Hashtable vertices) {
            Centro = new Vector3(0, 0, 0);
            Vertices = vertices;
            ColorF = Color.Black;
        }

        public Cara(Vector3 centro, Hashtable vertices)
        {
            Centro = centro;
            Vertices = vertices;
            ColorF = Color.Black;
        }

        public Cara(Vector3 c)
        {
            Centro = c;
            Vertices = new Hashtable();
            ColorF = Color.Black;
        }


        public void Dibujar() {

            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            foreach (DictionaryEntry vertice in Vertices) {
                Vector3 v = (Vector3)vertice.Value;
                GL.Vertex3(Centro.X + v.X,Centro.Y+v.Y, Centro.Z+v.Z);
            }
            GL.End();

        }

        


    }
}
