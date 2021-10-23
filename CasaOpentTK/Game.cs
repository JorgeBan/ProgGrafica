using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    class Game: GameWindow
    {

        private Escenario escenario ;


        public Game()
            : base(900, 600, GraphicsMode.Default, "Escenario")
        {
       
        }

        protected override void OnLoad(EventArgs e)
        {
            OnResize(null);
            escenario = new Escenario();
            Casa casa = new Casa();
            Casa casa2 = new Casa(new Vector3(200, 0, 0));
            Casa casa3 = new Casa(new Vector3(-200, 0, 0), 100, 50, 70);
            escenario.AgregarObjeto("casa1", casa);
            escenario.AgregarObjeto("casa2", casa2);
            escenario.AgregarObjeto("casa3", casa3);

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

            //GL.PushMatrix();
            //parte.rotar(30,1,1,0);

            rotar += 0.5f;
            GL.Rotate(rotar, 1,0,1);
            escenario.Dibujar();
            //GL.PopMatrix();
            //rotar += 2;
            //parte2.rotar(rotar, 1, 0, 0);
            //parte2.Dibujar();

            SwapBuffers();
            base.OnRenderFrame(e);
        }

        
        protected override void OnUpdateFrame(FrameEventArgs e)
        {

         
            base.OnUpdateFrame(e);
        }

        
    }
}
