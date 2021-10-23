using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    class Game : GameWindow
    {

        private Escenario escenario;
        private Objeto objeto;
        private Hashtable Vertices;
        private Hashtable Caras;
        private Hashtable Objetos;


        public Game()
            : base(900, 600, GraphicsMode.Default, "Escenario")
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            OnResize(null);
            
            Vertices = new Hashtable();
            Caras = new Hashtable();
            Objetos = new Hashtable();


            CargarVertices(new Vector3(-150, 0, 0));

            objeto = new Objeto(Caras);

            Objetos.Add("objeto1",objeto);
            
            escenario = new Escenario(Objetos);
            GL.ClearColor(Color4.LightBlue);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-300, 300, -300, 300, -300, 300);

        }

        float rotar = 0;
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();


            rotar += 0.5f;
            GL.Rotate(rotar, 1, 0, 1);
            escenario.Dibujar();
            
            SwapBuffers();
            base.OnRenderFrame(e);
        }


        protected override void OnUpdateFrame(FrameEventArgs e)
        {


            base.OnUpdateFrame(e);
        }


        private void CargarVertices(Vector3 centro) {
            
            Vertices.Add("punto1", new Vector3(-50.0f,  50.0f, 50.0f));
            Vertices.Add("punto2", new Vector3( 50.0f,  50.0f, 50.0f));
            Vertices.Add("punto3", new Vector3( 50.0f, -50.0f, 50.0f));
            Vertices.Add("punto4", new Vector3(-50.0f, -50.0f, 50.0f));
            Cara cara1 = new Cara(centro, Vertices);

            Vertices = new Hashtable();
            Vertices.Add("punto1", new Vector3(-50.0f,  50.0f, -50.0f));
            Vertices.Add("punto2", new Vector3( 50.0f,  50.0f, -50.0f));
            Vertices.Add("punto3", new Vector3( 50.0f, -50.0f, -50.0f));
            Vertices.Add("punto4", new Vector3(-50.0f, -50.0f, -50.0f));
            Cara cara2 = new Cara(centro, Vertices);


            Vertices = new Hashtable();
            Vertices.Add("punto1", new Vector3(-50.0f,  50.0f, -50.0f));
            Vertices.Add("punto2", new Vector3(-50.0f,  50.0f,  50.0f));
            Vertices.Add("punto3", new Vector3(-50.0f, -50.0f,  50.0f));
            Vertices.Add("punto4", new Vector3(-50.0f, -50.0f, -50.0f));
            Cara cara3 = new Cara(centro, Vertices);


            Vertices = new Hashtable();
            Vertices.Add("punto1", new Vector3(50.0f,  50.0f, -50.0f));
            Vertices.Add("punto2", new Vector3(50.0f,  50.0f,  50.0f));
            Vertices.Add("punto3", new Vector3(50.0f, -50.0f,  50.0f));
            Vertices.Add("punto4", new Vector3(50.0f, -50.0f, -50.0f));
            Cara cara4 = new Cara(centro, Vertices);


            Vertices = new Hashtable();
            Vertices.Add("punto1", new Vector3(-50.0f, 50.0f, -50.0f));
            Vertices.Add("punto2", new Vector3( 50.0f, 50.0f, -50.0f));
            Vertices.Add("punto3", new Vector3( 50.0f, 50.0f,  50.0f));
            Vertices.Add("punto4", new Vector3(-50.0f, 50.0f,  50.0f));
            Cara cara5 = new Cara(centro, Vertices);


            Vertices = new Hashtable();
            Vertices.Add("punto1", new Vector3(-50.0f, 50.0f, -50.0f));
            Vertices.Add("punto2", new Vector3( 50.0f, 50.0f, -50.0f));
            Vertices.Add("punto3", new Vector3( 50.0f, 50.0f,  50.0f));
            Vertices.Add("punto4", new Vector3(-50.0f, 50.0f,  50.0f));
            Cara cara6 = new Cara(centro, Vertices);

            Caras.Add("Cara1", cara1);
            Caras.Add("Cara2", cara2);
            Caras.Add("Cara3", cara3);
            Caras.Add("Cara4", cara4);
            Caras.Add("Cara5", cara5);
            Caras.Add("Cara6", cara6);

        }
    }
}
