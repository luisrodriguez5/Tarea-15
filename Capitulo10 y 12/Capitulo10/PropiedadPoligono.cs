using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_y_12.Capitulo10
{
    public class PropiedadPoligono
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }
        public PropiedadPoligono()
        {

        }
        public PropiedadPoligono(Double Perimetro, Double Apotema)

        {
            this.Perimetro = Perimetro;
            this.Apotema = Apotema;
        }

        public double Area
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 15; Apotema = 3.25; }
        }

    }
}
