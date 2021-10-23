using OpenTK;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{

    class Objeto
    {
        private Vector3 Centro;
        private Hashtable Caras;

        public Objeto(){
            Centro = new Vector3(0, 0, 0);
            Caras = new Hashtable();
        }

        public Objeto(Vector3 centro)
        {
            Centro = centro;
            Caras = new Hashtable();
        }

        public Objeto(Hashtable caras)
        {
            Centro = new Vector3(0, 0, 0);
            Caras = caras;

        }

        public Objeto(Vector3 centro, Hashtable caras)
        {
            Centro = centro;
            Caras = caras;

        }


        public void Dibujar() {
            foreach (DictionaryEntry parte in Caras) {
                Cara p = (Cara)parte.Value;
                p.Dibujar();
            }
        }

        public Vector3 GetCentro() { return this.Centro; }
        public void SetCentro(Vector3 centro) { this.Centro = centro; }
    }
}
