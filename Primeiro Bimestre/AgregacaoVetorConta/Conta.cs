using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVetorConta
{
    public class Conta
    {
        //Encapsulamento compacto
        public int Numero { get; set; }
        //Estabelecimento de agregação
        public List<Cliente> VetTitular { get; set; }//generics
        public double Saldo { get; set; }        
    }
}