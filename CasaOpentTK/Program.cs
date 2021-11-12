using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaOpentTK
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Game ventana = new Game();
            //ventana.Run();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
