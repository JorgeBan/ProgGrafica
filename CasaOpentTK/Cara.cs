using Newtonsoft.Json;
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
    [Serializable]
    class Cara : IObjeto
    {

        public Dictionary<String, Vector3Ser> Vertices { get; set; }
        public Vector3Ser Centro { get; set; }


        public Cara()
        {
            this.Centro = new Vector3Ser(0, 0, 0);
            this.Vertices = new Dictionary<String, Vector3Ser>();
        }

        public Cara(Dictionary<String, Vector3Ser> Vertices) {
            this.Centro = new Vector3Ser(0, 0, 0);
            this.Vertices = Vertices;
        }

        public Cara(Vector3Ser Centro, Dictionary<String, Vector3Ser> Vertices)
        {
            this.Centro = Centro;
            this.Vertices = Vertices;
        }

        public Cara(Vector3Ser Centro)
        {
            this.Centro = Centro;
            Vertices = new Dictionary<String, Vector3Ser>();
        }


        public void Dibujar() {

            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            GL.Color3(Color.Black);
            GL.Begin(primitiveType);
            Vector3Ser v;
            foreach (var vertice in Vertices) { 
                v = (Vector3Ser)vertice.Value;
                GL.Vertex3(Centro.X + v.X,Centro.Y+v.Y, Centro.Z+v.Z);
            }
            GL.End();

        }


        public void AgregarCara(String key, Vector3Ser vertice){
            Vertices.Add(key, vertice);
        }

        public void Rotar(float angulo, Vector3Ser rotacion)
        {
            
            GL.Rotate(angulo, rotacion.X, rotacion.Y, rotacion.Z);
            
        }

        public void Trasladar(Vector3Ser trasladar)
        {
            GL.Translate(trasladar.X, trasladar.Y, trasladar.Z);
        }

        public void Escalar(float escala)
        {
            GL.Scale(escala, escala, escala);
        }
    }
}
