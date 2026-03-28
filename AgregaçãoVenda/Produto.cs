using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregaçãoVenda
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        private static int contador;
        public static int Contador
        {
            get
            {
                return contador;
            }
        }
        public int Codigo
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }
    }
}