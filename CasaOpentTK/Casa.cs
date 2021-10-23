using OpenTK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{

    class Casa
    {
        private Vector3 Centro;
        private float Largo;
        private float Alto;
        private float Ancho;
        private Hashtable Partes;

        public Casa(){
            Centro = new Vector3(0, 0, 0);
            Largo = 150.0f;
            Alto = 150.0f;
            Ancho = 150.0f;
            Partes = new Hashtable();
            ConstruirCasa();
        }

        public Casa(Vector3 centro)
        {
            Centro = centro;
            Largo = 150.0f;
            Alto = 150.0f;
            Ancho = 150.0f;
            Partes = new Hashtable();
            ConstruirCasa();
        }

        public Casa(Vector3 centro, float largo, float alto, float ancho)
        {
            Centro = centro;
            Largo = largo;
            Alto = alto;
            Ancho = ancho;
            Partes = new Hashtable();
            ConstruirCasa();
        }

        private void ConstruirCasa() {
            Face casa = new Face(Centro, Largo, Alto, Ancho);

            Vector3 centroTecho = new Vector3(Centro.X, (Centro.Y + Alto*0.5f) + Alto*0.075f ,Centro.Z);
            Face techo = new Face(centroTecho, Largo + Largo*0.2f, Alto * 0.15f, Ancho + Ancho * 0.1f);

            Vector3 centroPuerta = new Vector3(Centro.X-Largo*0.3f, Centro.Y-Alto*0.15f, Centro.Z+Ancho*0.5f);
            Face puerta = new Face(centroPuerta, Largo*0.3f, Alto*0.7f, Ancho*0.02f);

            Vector3 centroVentana = new Vector3(Centro.X + Largo * 0.2f, Centro.Y, Centro.Z + Ancho * 0.5f);
            Face ventana = new Face(centroVentana, Largo*0.3f, Alto*0.3f, Ancho*0.015f);

            Partes.Add("Casa",casa);
            Partes.Add("Techo", techo);
            Partes.Add("Puerta", puerta);
            Partes.Add("Ventana", ventana);
        }

        public void Dibujar() {
            foreach (DictionaryEntry parte in Partes) {
                Face p = (Face)parte.Value;
                p.Dibujar();
            }
        }
    }
}
