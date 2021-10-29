using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    [Serializable]
    class Cara : IObjeto
    {

        public Hashtable Vertices { get; set; }
        public Vector3Ser Centro { get; set; }


        public Cara()
        {
            Centro = new Vector3Ser(0, 0, 0);
            Vertices = new Hashtable();
        }

        public Cara(Hashtable vertices) {
            Centro = new Vector3Ser(0, 0, 0);
            Vertices = vertices;
        }

        public Cara(Vector3Ser centro, Hashtable vertices)
        {
            Centro = centro;
            Vertices = vertices;
        }

        public Cara(Vector3Ser  c)
        {
            Centro = c;
            Vertices = new Hashtable();
        }


        public void Dibujar() {

            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            GL.Color3(Color.Black);
            GL.Begin(primitiveType);
            Vector3Ser v;
            foreach (DictionaryEntry vertice in Vertices) {
                
                if (vertice.Value.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                {
                    var json = vertice.Value.ToString();
                    v = JsonConvert.DeserializeObject<Vector3Ser>(json);

                }
                else {
                    v = (Vector3Ser)vertice.Value;
                }

                GL.Vertex3(Centro.X + v.X,Centro.Y+v.Y, Centro.Z+v.Z);
            }
            GL.End();

        }


        public void AgregarCara(String key, Vector3Ser vertice){
            Vertices.Add(key, vertice);
        }

        public void Rotar()
        {
            throw new NotImplementedException();
        }

        public void Trasladar()
        {
            throw new NotImplementedException();
        }

        public void Escalar()
        {
            throw new NotImplementedException();
        }
    }
}
