using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPinturaOO
{
    class ClassCalculo
    {
        public double Area { get; set; }
        public double ValorLata { get; set; }
        public double ValorMaodObra { get; set; }

        //Método cálculo para saber quantas latas de tintas, precisará
        public double CalculoLata()
        {
            return Area / 20;
        }

        //Método para cálculo de dias necessário para realizar a pintura
        public double DiasNecessarios()
        {
            return Area / 10;
        }

        //Método para cáculo do valor(R$) da tinta 
        public double CalculoTintas()
        {
            return CalculoLata() * ValorLata;
        }

        //Método para cálculo da mão-de-obra, realizando o produto da diário com a área deseja a pintar
        public double CalculoMaodObra()
        {
            return ValorMaodObra * (Area);
        }

        //Método para cálculo do valor total da pintura
        public double CalculoValorTotal()
        {
            return CalculoMaodObra() + CalculoTintas();
        }
    }
}
