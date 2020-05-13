using System;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double CapitalInicial { get; set; }
        public double TasaInteresCompue { get; set; }
        public double TiempoDeDuracion { get; set; }
        public double TotalAPagar { get; set; }
        public double n { get; set; }
        public double i { get; set; }

        public void CalcularCapitalFinal()
        {
            n = (TiempoDeDuracion/12);
            i = (TasaInteresCompue/100);

            TotalAPagar = CapitalInicialDeCredito * Math.Pow((1+i),n); ;

        }

    }
}
