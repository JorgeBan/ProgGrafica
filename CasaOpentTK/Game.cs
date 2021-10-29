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

        public Game()
            : base(900, 600, GraphicsMode.Default, "Escenario")
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            OnResize(null);


            escenario = new Escenario();
            escenario.AgregarObjetoConArchivo("Cubo1.txt");
            escenario.AgregarObjetoConArchivo("Triangulo1.txt");




            GL.ClearColor(Color4.LightBlue);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-600, 600, -600, 600, -600, 600);

        }

        float rotar = 0;
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();


            rotar += 0.35f;
            GL.Rotate(rotar, 1, 0, 1);
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
