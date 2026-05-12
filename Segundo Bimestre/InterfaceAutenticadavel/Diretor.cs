using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticadavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha){
            if (Senha == senha)
            {
                Console.WriteLine("Diretor Autenticado!");
                return true;
            }
            Console.WriteLine("Diretor não autenticado!");
            return false;
        }
    }
}