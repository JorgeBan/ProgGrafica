using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    class Escenario: IObjeto
    {

        private Hashtable Objetos;
        private Vector3Ser Centro;

        public Escenario()
        {
            Centro = new Vector3Ser(0, 0, 0);
            Objetos = new Hashtable();
        }

        public Escenario(Hashtable objetos)
        {
            Centro = new Vector3Ser(0,0,0);
            Objetos = objetos;
        }

        public Escenario(Vector3Ser centro, Hashtable objetos)
        {
            Centro = centro;
            Objetos = objetos;
        }


        public Escenario(String archivoObjetos)
        {
            Centro = new Vector3Ser(0, 0, 0);
            Objetos = new Hashtable();
            AgregarObjetoConArchivo(archivoObjetos);
        }

        public void Dibujar(){
            foreach (DictionaryEntry objeto in Objetos)
            {
                Objeto c = (Objeto)objeto.Value;
                c.Dibujar();
            }
        }

        public void AgregarObjeto(String key, Objeto obj) {
            Objetos.Add(key, obj);
        }


        public void AgregarObjetoConArchivo(string archivoObjeto) {
            string json = File.ReadAllText(archivoObjeto);
            Objeto objeto = JsonConvert.DeserializeObject<Objeto>(json);
            Objetos.Add(archivoObjeto,objeto);

        }


        public void SetCentro(Vector3Ser centro) { this.Centro = centro; }
        public Vector3Ser GetCentro() { return this.Centro; }



        public void Escalar()
        {
            throw new NotImplementedException();
        }

        public void Rotar()
        {
            throw new NotImplementedException();
        }

        public void Trasladar()
        {
            throw new NotImplementedException();
        }
    }
}
