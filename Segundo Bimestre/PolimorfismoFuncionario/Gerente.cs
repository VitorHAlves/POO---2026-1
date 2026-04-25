using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(double salario) : base(salario)
        {
        }
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}