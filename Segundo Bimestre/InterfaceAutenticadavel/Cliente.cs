using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticadavel
{
    public class Cliente : IAutenticavel//interface
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha){
            if (Senha == senha)
            {
                Console.WriteLine("Cliente Autenticado!");
                return true;
            }
            Console.WriteLine("Cliente não autenticado!");
            return false;
        }
    }
}