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
using System.Drawing;

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

            String figura1 = "Cubo3D";
            String figura2 = "CuboPrueba";
            escenario = new Escenario();
            escenario.AgregarObjetoConArchivo(figura1, figura1 +".txt");
            escenario.AgregarObjetoConArchivo(figura2, figura2 + ".txt");
            



            GL.ClearColor(Color4.Black);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-200, 200, -200, 200, -200, 200);

        }

        float rotar = 0;
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            
            rotar += 1.0f;

            ///escenario.ObtenerObjeto("Cubo3D").Rotar(rotar, new Vector3Ser(1, 0, 0));
            //escenario.ObtenerObjeto("3DCubo").ObtenerCara("CaraDerecha").Rotar(rotar, new Vector3Ser(0, 1, 0));
            escenario.Rotar(rotar, new Vector3Ser(1,1,1));
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
