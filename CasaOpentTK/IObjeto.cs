using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaOpentTK
{
    interface IObjeto
    {
        void Dibujar();
        void Rotar(float angulo, Vector3Ser rotacion);
        void Trasladar(Vector3Ser trasladar);
        void Escalar(float escala);
    }
}
