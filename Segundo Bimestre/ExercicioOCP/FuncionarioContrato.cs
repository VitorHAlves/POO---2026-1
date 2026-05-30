using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioOCP
{
    public class FuncionarioContrato : Funcionario, ICalculadoraSalarios
    {
        public FuncionarioContrato(string nome,double salario) : base(nome,salario)
        {
                    
        }
        public double CalcularSalario()
        {
            return Salario; 
        }
    }
}