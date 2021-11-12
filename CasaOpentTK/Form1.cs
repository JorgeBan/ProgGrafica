using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaOpentTK
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        private Escenario escenario;

        public Form1()
        {
            InitializeComponent();
            InicializarElementos();
        }

        private void InicializarElementos() {
            escenario = new Escenario();

            String figura1 = "Cubo3D";
            escenario.AgregarObjetoConArchivo(figura1, figura1 + ".txt");

            LlenarCombos();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;

            
            GL.ClearColor(Color.Black);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-300, 300, -300, 300, -300, 300);
            GL.Viewport(0, 0, -300, 300);

           

        }


        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
                return;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl1.SwapBuffers();

        }


        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) // Play nice
                return;

            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

        
            escenario.Dibujar();

            

            glControl1.SwapBuffers();

        }

        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                rotar += 1.5f;
            Console.WriteLine(rotar);
            glControl1.Invalidate();

        }


        private void LlenarCombos() {

            comboEscenario.Text = "Seleccionar Escenario";
            comboEscenario.Items.Add(escenario.ObtnerNombre());
            
        }

        private void LlenarComboCaras(String obj)
        {
            comboCaras.Text = "Seleccionar Cara";
            comboCaras.DataSource = null;
            comboCaras.Items.Clear();
            Objeto o = escenario.ObtenerObjeto(obj); 
            Dictionary<String, Cara> Caras = o.ObtenerCaras();
            foreach (var cara in Caras) {
                Cara c = (Cara)cara.Value;
                comboCaras.Items.Add(c.Nombre);
            }
        }

        private void LlenarComboObjetos(Escenario esc)
        {
            comboObjeto.Text = "Seleccionar Objeto";
            comboObjeto.DataSource = null;
            comboObjeto.Items.Clear();
            Dictionary<String, Objeto> Objetos = esc.ObtenerObjetos();
            foreach (var obj in Objetos)
            {
                Objeto o = (Objeto)obj.Value;
                comboObjeto.Items.Add(o.Nombre);
            }
        }

        private void comboEscenario_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine("combo Objeto: " + comboObjeto.SelectedIndex);
            Console.WriteLine("combo Cara: " + comboCaras.Text);

            btnEliminar.Enabled = true;
            grBoxTransformaciones.Enabled = true;
            btnXmenos.Enabled = true;
            btnXmas.Enabled = true;
            btnYmenos.Enabled = true;
            btnYmas.Enabled = true;
            btnZmenos.Enabled = true;
            btnZmas.Enabled = true;

            comboObjeto.DataSource = null;
            comboObjeto.Items.Clear();
            LlenarComboObjetos(escenario);
        }

        private void comboObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("combo Objeto: " + comboObjeto.SelectedIndex);
            comboCaras.DataSource = null;
            comboCaras.Items.Clear();
            LlenarComboCaras(comboObjeto.Text);
        }

        private Vector3Ser Vtrasladar = new Vector3Ser(0,0,0);
        private float rotar = 0.0f;
        private float escalar = 1.0f;

        private dynamic SeleccionarObjeto() {

            dynamic objetoSeleccionado = escenario;
            if (comboObjeto.SelectedIndex >= 0)
            {
                objetoSeleccionado = (Objeto)objetoSeleccionado.ObtenerObjeto(comboObjeto.Text);
                if (comboCaras.SelectedIndex >= 0)
                {
                    objetoSeleccionado = (Cara)objetoSeleccionado.ObtenerCara(comboCaras.Text);
                }
            }
            return objetoSeleccionado;
        }
        #region Botones
        private void btnXmenos_Click(object sender, EventArgs e)
        {
            IObjeto objetoSeleccionado = SeleccionarObjeto();
         
            if (rbTraslacion.Checked)
            {
                Vtrasladar.X -= 10;
                objetoSeleccionado.Trasladar(new Vector3Ser(Vtrasladar.X, Vtrasladar.Y, Vtrasladar.Z));
                
            }
            else if (rbRotacion.Checked)
            {
                rotar -= 10;
                objetoSeleccionado.Rotar(rotar, new Vector3Ser(1,0,0));
                
            }
            else {
                escalar -= 0.5f;
                objetoSeleccionado.Escalar(escalar);
                
            }

            glControl1.Invalidate();
        }

        private void btnXmas_Click(object sender, EventArgs e)
        {
            IObjeto objetoSeleccionado = SeleccionarObjeto();

            if (rbTraslacion.Checked)
            {
                Vtrasladar.X += 10;
                objetoSeleccionado.Trasladar(new Vector3Ser(Vtrasladar.X, Vtrasladar.Y, Vtrasladar.Z));

            }
            else if (rbRotacion.Checked)
            {
                rotar += 10;
                objetoSeleccionado.Rotar(rotar, new Vector3Ser(1, 0, 0));
            }
            else
            {
                escalar += 0.5f;
                objetoSeleccionado.Escalar(escalar);
            }

            
            glControl1.Invalidate();
        }

        private void btnYmenos_Click(object sender, EventArgs e)
        {
            IObjeto objetoSeleccionado = SeleccionarObjeto();

            if (rbTraslacion.Checked)
            {
                Vtrasladar.Y -= 10;
                objetoSeleccionado.Trasladar(new Vector3Ser(Vtrasladar.X, Vtrasladar.Y, Vtrasladar.Z));
            
            }
            else if (rbRotacion.Checked)
            {
                rotar -= 10;
                objetoSeleccionado.Rotar(rotar, new Vector3Ser(0, 1, 0));
            
            }
            else
            {
                escalar -= 0.5f;
                objetoSeleccionado.Escalar(escalar);
            
            }
            glControl1.Invalidate();
        }

        private void btnYmas_Click(object sender, EventArgs e)
        {
            IObjeto objetoSeleccionado = SeleccionarObjeto();

            if (rbTraslacion.Checked)
            {
                Vtrasladar.Y += 10;
                objetoSeleccionado.Trasladar(new Vector3Ser(Vtrasladar.X, Vtrasladar.Y, Vtrasladar.Z));
            }
            else if (rbRotacion.Checked)
            {
                rotar += 10;
                objetoSeleccionado.Rotar(rotar, new Vector3Ser(0, 1, 0));
            }
            else
            {
                escalar += 0.5f;
                objetoSeleccionado.Escalar(escalar);
            }
            glControl1.Invalidate();
        }

        private void btnZmenos_Click(object sender, EventArgs e)
        {

            IObjeto objetoSeleccionado = SeleccionarObjeto();

            if (rbTraslacion.Checked)
            {
                Vtrasladar.Z -= 10;
                objetoSeleccionado.Trasladar(new Vector3Ser(Vtrasladar.X, Vtrasladar.Y, Vtrasladar.Z));
            }
            else if (rbRotacion.Checked)
            {
                rotar -= 10;
                objetoSeleccionado.Rotar(rotar, new Vector3Ser(0, 0, 1));
            }
            else
            {
                escalar -= 0.5f;
                objetoSeleccionado.Escalar(escalar);
            }



            glControl1.Invalidate();
        }

        private void btnZmas_Click(object sender, EventArgs e)
        {
            IObjeto objetoSeleccionado = SeleccionarObjeto();


            if (rbTraslacion.Checked)
            {
                Vtrasladar.Z += 10;
                objetoSeleccionado.Trasladar(new Vector3Ser(Vtrasladar.X, Vtrasladar.Y, Vtrasladar.Z));
            }
            else if (rbRotacion.Checked)
            {
                rotar += 10;
                objetoSeleccionado.Rotar(rotar, new Vector3Ser(0, 0, 1));
            }
            else
            {
                escalar += 0.5f;
                objetoSeleccionado.Escalar(escalar);
            }
            glControl1.Invalidate();
        }

        #endregion
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Vtrasladar = new Vector3Ser(0, 0, 0);
            rotar = 0.0f;
            escalar = 1.0f;
            escenario.Trasladar(new Vector3Ser(0, 0, 0));
            escenario.Rotar(0,new Vector3Ser(0, 0, 0));
            escenario.Escalar(1);

            comboEscenario.DataSource = null;
            comboEscenario.Items.Clear();
            comboEscenario.Text = "Seleccionar Escenario";
            comboObjeto.DataSource = null;
            comboObjeto.Items.Clear();
            comboObjeto.Text = "Seleccionar Objeto";
            comboCaras.DataSource = null;
            comboCaras.Items.Clear();
            comboCaras.Text = "Seleccionar Cara";


            btnEliminar.Enabled = false;
            grBoxTransformaciones.Enabled = false;
            btnXmenos.Enabled = false;
            btnXmas.Enabled = false;
            btnYmenos.Enabled = false;
            btnYmas.Enabled = false;
            btnZmenos.Enabled = false;
            btnZmas.Enabled = false;

            LlenarCombos();
            glControl1.Invalidate();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String archivo = File.ReadAllText(openFileDialog1.FileName);
                    File.WriteAllText(Path.GetFileName(openFileDialog1.FileName), archivo);
                    String nombreArchivo = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    escenario.AgregarObjetoConArchivo(nombreArchivo, nombreArchivo+".txt");
                    glControl1.Invalidate();
                    LlenarComboObjetos(escenario);
                    MessageBox.Show("Archivo cargado");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("error: "+ex.Message);
            }


        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dynamic objetoSeleccionado = escenario;
            if (comboEscenario.SelectedIndex >= 0) {
                if (comboObjeto.SelectedIndex >= 0)
                {
                    if (comboCaras.SelectedIndex >= 0)
                    {
                        objetoSeleccionado = (Objeto)objetoSeleccionado.ObtenerObjeto(comboObjeto.Text);
                        objetoSeleccionado.ElminarParte(comboCaras.Text);
                        LlenarComboCaras(objetoSeleccionado.Nombre);
                    }
                    else
                    {
                        objetoSeleccionado.ElminarParte(comboObjeto.Text);
                        LlenarComboObjetos(objetoSeleccionado);
                    }
                }
            }
            

            glControl1.Invalidate();
        }
    }
}
