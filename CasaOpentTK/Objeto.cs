using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenTK;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{

    [Serializable]
    class Objeto: IObjeto
    {
        public Vector3Ser Centro { get; set; }
        public Hashtable Caras { get; set; }


        public Objeto(){
            Centro = new Vector3Ser(0, 0, 0);
            Caras = new Hashtable();
        }

        public Objeto(Vector3Ser centro)
        {
            Centro = centro;
            Caras = new Hashtable();
        }

        public Objeto(Hashtable caras)
        {
            Centro = new Vector3Ser(0, 0, 0);
            Caras = caras;

        }

        public Objeto(Vector3Ser centro, Hashtable caras)
        {
            Centro = centro;
            Caras = caras;

        }


        public void Dibujar() {
            Cara c;
            foreach (DictionaryEntry cara in Caras) {
                
                if (cara.Value.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                {
                    var json = cara.Value.ToString();
                     c = JsonConvert.DeserializeObject<Cara>(json);
                }
                else {
                    c = (Cara)cara.Value;
                }
                c.Dibujar();
            }
        }

        public void AgregarCara(String key, Cara cara) {
            Caras.Add(key, cara);
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
