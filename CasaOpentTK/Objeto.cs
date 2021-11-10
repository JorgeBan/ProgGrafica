using System;
using System.Collections.Generic;

namespace CasaOpentTK
{

    [Serializable]
    class Objeto: IObjeto
    {

        public Vector3Ser Centro { get; set; }
        public Dictionary<String,Cara> Caras { get; set; }
        public String Nombre { get; set; }

        public Objeto() {
            this.Nombre = "";
            this.Centro = new Vector3Ser(0, 0, 0);
            this.Caras = new Dictionary<String, Cara>();
        }

        public Objeto(String Nombre){
            this.Nombre = Nombre;
            this.Centro = new Vector3Ser(0, 0, 0);
            this.Caras = new Dictionary<String, Cara>();
        }

        public Objeto(String Nombre,Vector3Ser Centro)
        {
            this.Nombre = Nombre;
            this.Centro = Centro;
            this.Caras = new Dictionary<String, Cara>();
        }

        public Objeto(String Nombre, Dictionary<String, Cara> Caras)
        {
            this.Nombre = Nombre;
            this.Centro = new Vector3Ser(0, 0, 0);
            this.Caras = Caras;

        }

        public Objeto(String Nombre, Vector3Ser Centro, Dictionary<String, Cara> Caras)
        {
            this.Nombre = Nombre;
            this.Centro = Centro;
            this.Caras = Caras;

        }


        public void Dibujar() {
            Cara c;
            foreach(var cara in Caras) {
                c = (Cara)cara.Value;
                c.Dibujar();
            }
        }

        public void AgregarCara(String key, Cara cara) {
            Caras.Add(key, cara);
        }

        public Cara ObtenerCara(String NombreCara) {
            return Caras[NombreCara];
        }

        public void Escalar(float escala)
        {
            Cara c;
            foreach (var Cara in Caras)
            {
                c = (Cara)Cara.Value;
                c.Escalar(escala);
            }
        }

        public void Rotar(float angulo, Vector3Ser rotacion)
        {
            Cara c;
            foreach (var Cara in Caras) {
                c = (Cara)Cara.Value;
                c.Rotar(angulo, rotacion);
            }
        }

        public void Trasladar(Vector3Ser trasladar)
        {
            Cara c;
            foreach (var Cara in Caras)
            {
                c = (Cara)Cara.Value;
                c.Trasladar(trasladar);
            }
        }
    }
}
