using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            set
            {
                this.verba = value;
            }
            get
            {
                return verba;
            }
        }
        public Comprador(double Valor)
        {
            Verba = Valor;
        }
        public void DiminuirVerba(double ValorVend)
        {
            Verba = Verba - ValorVend;
        }
        public void MostrarAtributos()
        {
         Console.WriteLine($"Verba: {this.Verba}");   
        }   
    }
}