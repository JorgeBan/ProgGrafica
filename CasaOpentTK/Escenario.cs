using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CasaOpentTK
{
    class Escenario: IObjeto
    {


        private Dictionary<String, Objeto> Objetos;
        private Vector3Ser Centro;
        private String Nombre;

        public Escenario()
        {
            this.Centro = new Vector3Ser(0, 0, 0);
            this.Objetos = new Dictionary<String, Objeto>();
            this.Nombre = "Escenario1";
        }

        public Escenario(Dictionary<String, Objeto> Objetos)
        {
            this.Centro = new Vector3Ser(0,0,0);
            this.Objetos = Objetos;
            this.Nombre = "Escenario1";
        }

        public Escenario(Vector3Ser Centro, Dictionary<String, Objeto> Objetos)
        {
            this.Centro = Centro;
            this.Objetos = Objetos;
            this.Nombre = "Escenario1";
        }


        public Escenario(String NombreArchivo, String archivoObjetos)
        {
            Centro = new Vector3Ser(0, 0, 0);
            Objetos = new Dictionary<String, Objeto>();
            this.Nombre = "Escenario1";
            AgregarObjetoConArchivo(NombreArchivo, archivoObjetos);
        }

        public void Dibujar(){
            Objeto obj;
            foreach (var objeto in Objetos)
            {
                obj = (Objeto)objeto.Value;
                obj.Dibujar();
            }
        }

        public void AgregarObjeto(String key, Objeto obj) {
            Objetos.Add(key, obj);
        }


        public Objeto ObtenerObjeto(String NombreObjeto) {
            return Objetos[NombreObjeto];
        }

        public void AgregarObjetoConArchivo(String Nombre, String archivoObjeto) {
            string json = File.ReadAllText(archivoObjeto);
            Objeto objeto = JsonConvert.DeserializeObject<Objeto>(json);
            Objetos.Add(Nombre,objeto);

        }


        public void SetCentro(Vector3Ser centro) { this.Centro = centro; }
        public Vector3Ser GetCentro() { return this.Centro; }



        public void Escalar(float escala)
        {
            Objeto obj;
            foreach (var Objeto in Objetos)
            {
                obj = (Objeto)Objeto.Value;
                obj.Escalar(escala);
            }
        }

        public void Rotar(float angulo, Vector3Ser rotacion)
        {
            Objeto obj;
            foreach (var Objeto in Objetos) {
                obj = (Objeto)Objeto.Value;
                obj.Rotar(angulo,rotacion);
            }
        }

        public void Trasladar(Vector3Ser trasladar)
        {
            Objeto obj;
            foreach (var Objeto in Objetos)
            {
                obj = (Objeto)Objeto.Value;
                obj.Trasladar(trasladar);
            }
        }

        public String ObtnerNombre() {
            return this.Nombre;
        }

        public Dictionary<String, Objeto> ObtenerObjetos() {
            return this.Objetos;
        }

        public void EliminarObjeto(String key) {
            this.Objetos.Remove(key);
        }

        public void ElminarParte(string key)
        {
            this.Objetos.Remove(key);
        }
    }
}
