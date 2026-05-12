using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticadavel
{
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha){
            if (Senha == senha)
            {
                Console.WriteLine("Gerente Autenticado!");
                return true;
            }
            Console.WriteLine("Gerente não autenticado!");
            return false;
        }
    }
}