using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_y_12.Capitulo10
{
    public class Poligono
    {

        public Double Apotema { get; set; }
        public Poligono()
        {

        }
        public Poligono(Double Perimetro, Double Apotema)
        {
            Perimetro = Perimetro;
            Apotema = Apotema;
        }
    }
}
