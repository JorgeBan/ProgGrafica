using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    class Face
    {
        private Vector3 Centro;
        private float Largo;
        private float Alto;
        private float Ancho;
        private Color ColorF;

        public Face()
        {
            Centro = new Vector3(0, 0, 0);
            Largo = 250.0f;
            Alto = 250.0f;
            Ancho = 250.0f;
            ColorF = Color.Black;
        }

        public Face(Vector3 c)
        {
            Centro = c;
            Largo = 250.0f;
            Alto = 250.0f;
            Ancho = 250.0f;
            ColorF = Color.Black;
        }

        public Face(Vector3 c, float largo, float alto, float ancho)
        {
            Centro = c;
            Largo = largo;
            Alto = alto;
            Ancho = ancho;
            ColorF = Color.Black;
        }

        public Face(Vector3 c, float largo, float alto, float ancho, Color color)
        {
            Centro = c;
            Largo = largo;
            Alto = alto;
            Ancho = ancho;
            ColorF = color;
        }



        public void Dibujar()
        {

            PrimitiveType primitiveType = PrimitiveType.LineLoop;


            //Adelante
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.End();

            //Atras
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.End();


            //Izquierda
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.End();

            //Derecha
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.End();



            //Arriba
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y + Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.End();

            //Abajo
            GL.Color3(ColorF);
            GL.Begin(primitiveType);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z - Ancho * 0.5f);
            GL.Vertex3(Centro.X + Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.Vertex3(Centro.X - Largo * 0.5f, Centro.Y - Alto * 0.5f, Centro.Z + Ancho * 0.5f);
            GL.End();
        }

        
    }
}
