using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CasaOpentTK
{
    class Game : GameWindow
    {

        private Escenario escenario;
        private Dictionary<String, Vector3Ser> Vertices;
        private Dictionary<String, Cara> Caras;
        public Game()
            : base(900, 600, GraphicsMode.Default, "Escenario")
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            OnResize(null);

            
            escenario = new Escenario();
            escenario.AgregarObjetoConArchivo("Cubo.txt");
            escenario.AgregarObjetoConArchivo("Triangulo.txt");

            


            GL.ClearColor(Color4.LightBlue);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-400, 400, -400, 400, -400, 400);

        }

        float rotar = 0;
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();


            rotar += 1.5f;
            escenario.Rotar(rotar, new Vector3Ser(1, 0, 0));
            //escenario.Trasladar(new Vector3Ser(rotar,rotar,rotar));
            //escenario.Escalar(rotar);
            //GL.Scale(rotar,rotar,rotar);
            escenario.Dibujar();

 
            SwapBuffers();
            base.OnRenderFrame(e);
        }


        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            base.OnUpdateFrame(e);
        }



        
    }
}
