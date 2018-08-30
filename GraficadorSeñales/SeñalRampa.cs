using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalRampa
    {

        public List<Muestra> Muestras { get; set; }
        public double AmplitudMaxima { get; set; }

        public SeñalRampa()
        {
            
            AmplitudMaxima = 0.0;
            Muestras = new List<Muestra>();

        }

        public double evaluar(double tiempo)
        {
            double resultado = 0;
            if (tiempo >= 0)
            {
                resultado = tiempo;
            }

            else
            { 
                resultado = 0;
            }

           

            return resultado;
        }
    }
}
