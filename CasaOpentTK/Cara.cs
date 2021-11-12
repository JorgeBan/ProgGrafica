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

        private float AnguloRotacion;
        private Vector3Ser Rotacion;
        private float FactorEscalacion;
        private Vector3Ser Traslacion;

        public String Nombre { get; set; }

        public Cara() {
            this.Nombre = "";

            this.Centro = new Vector3Ser(0, 0, 0);
            this.Vertices = new Dictionary<String, Vector3Ser>();

            this.AnguloRotacion = 0;
            this.Rotacion = new Vector3Ser(0, 0, 0);
            this.FactorEscalacion = 1;
            this.Traslacion = new Vector3Ser(0, 0, 0);
        }



        public Cara(String Nombre)
        {
            this.Nombre = Nombre;

            this.Centro = new Vector3Ser(0, 0, 0);
            this.Vertices = new Dictionary<String, Vector3Ser>();

            this.AnguloRotacion = 0;
            this.Rotacion = new Vector3Ser(0, 0, 0);
            this.FactorEscalacion = 1;
            this.Traslacion = new Vector3Ser(0, 0, 0);
        }

        public Cara(String Nombre, Dictionary<String, Vector3Ser> Vertices) {
            
            this.Nombre = Nombre;

            this.Centro = new Vector3Ser(0, 0, 0);
            this.Vertices = Vertices;

            this.AnguloRotacion = 0;
            this.Rotacion = new Vector3Ser(0, 0, 0);
            this.FactorEscalacion = 1;
            this.Traslacion = new Vector3Ser(0, 0, 0);
        }

        public Cara(String Nombre, Vector3Ser Centro, Dictionary<String, Vector3Ser> Vertices)
        {
            this.Nombre = Nombre;

            this.Centro = Centro;
            this.Vertices = Vertices;

            this.AnguloRotacion = 0;
            this.Rotacion = new Vector3Ser(0, 0, 0);
            this.FactorEscalacion = 1;
            this.Traslacion = new Vector3Ser(0, 0, 0);
        }

        public Cara(String Nombre, Vector3Ser Centro)
        {
            this.Nombre = Nombre;

            this.Centro = Centro;
            Vertices = new Dictionary<String, Vector3Ser>();

            this.AnguloRotacion = 0;
            this.Rotacion = new Vector3Ser(0, 0, 0);
            this.FactorEscalacion = 1;
            this.Traslacion = new Vector3Ser(0, 0, 0);
        }


        public void Dibujar() {
            
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            GL.Color3(Color.Red);
            GL.PushMatrix();

            GL.Scale(this.FactorEscalacion, this.FactorEscalacion, this.FactorEscalacion);

            GL.Translate(this.Centro.X+this.Traslacion.X, this.Centro.Y + this.Traslacion.Y, this.Centro.Z + this.Traslacion.Z);
            GL.Rotate(this.AnguloRotacion, this.Rotacion.X, this.Rotacion.Y, this.Rotacion.Z);
            GL.Translate(-this.Centro.X, -this.Centro.Y, -this.Centro.Z);

            GL.Begin(primitiveType);
            Vector3Ser v;
            foreach (var vertice in Vertices) { 
                v = (Vector3Ser)vertice.Value;
                GL.Vertex3(Centro.X + v.X,Centro.Y+v.Y, Centro.Z+v.Z);
                
            }

            
            GL.End();
            GL.PopMatrix();

            
            
        }


        public void AgregarVertice(String key, Vector3Ser vertice){
            Vertices.Add(key, vertice);
        }

        public Vector3Ser ObtenerVertice(String NombreVertice) {
            return Vertices[NombreVertice];
        }

        public void Rotar(float angulo, Vector3Ser rotacion)
        {

            this.AnguloRotacion = angulo;
            this.Rotacion = rotacion;
            
        }

        public void Trasladar(Vector3Ser trasladar)
        {
            this.Traslacion = trasladar;
        }

        public void Escalar(float escala)
        {
            this.FactorEscalacion = escala;
        }

        public void ElminarParte(string key)
        {
            this.Vertices.Remove(key);
        }
    }
}
