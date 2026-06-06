using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class NotaFiscal
    {
        public string Numero { get; set; }
        public double Valor { get; set; }
        public double Imposto { get; set; }
        public DateTime DataEmissao { get; set; }
        public void DefinirImposto(double valor)
        {
            this.Imposto = valor;
        }
        public NotaFiscal(string numero, double valor)
        {
            this.Numero = numero;
            this.Valor = valor;
            this.DataEmissao = DateTime.Now;
        }

    }
}