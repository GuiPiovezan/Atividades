using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO
{
    class ClassCalculo
    {
        //Método Get Set de Peso e Altura

        public double Peso {get; set;}
        public double Altura {get; set;}

        //Método para cálculo de IMC
        public double CalqIMC()
        {

            return Peso/(Altura * Altura);
        }
    }
}
