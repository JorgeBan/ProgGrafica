using OpenTK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    class Escenario
    {

        private Hashtable Objetos;
        private Vector3 Centro;

        public Escenario()
        {
            Centro = new Vector3(0, 0, 0);
            Objetos = new Hashtable();
        }

        public Escenario(Hashtable objetos)
        {
            Centro = new Vector3(0,0,0);
            Objetos = objetos;
        }

        public Escenario(Vector3 centro,Hashtable objetos)
        {
            Centro = centro;
            Objetos = objetos;
        }

        public void AgregarObjeto(String nombre, Object ob)
        {
            Objetos.Add(nombre, ob);
        }

        public void Dibujar(){
            foreach (DictionaryEntry objeto in Objetos)
            {
                Objeto c = (Objeto)objeto.Value;
                c.Dibujar();
            }
        }

        public Vector3 GetCentro() { return this.Centro; }
        public void SetCentro(Vector3 centro) { this.Centro = centro; }



      

    }
}
