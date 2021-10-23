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

        public Escenario()
        {
            Objetos = new Hashtable();
        }

        public void AgregarObjeto(String nombre, Object ob)
        {
            Objetos.Add(nombre, ob);
        }

        public void Dibujar(){
            foreach (DictionaryEntry objeto in Objetos)
            {
                Casa c = (Casa)objeto.Value;
                c.Dibujar();
            }
        }

    }
}
