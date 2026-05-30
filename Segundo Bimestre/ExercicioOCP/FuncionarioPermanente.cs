using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioOCP
{
    public class FuncionarioPermanente : Funcionario, ICalculadoraSalarios
    {
        public FuncionarioPermanente(string nome,double salario) : base(nome,salario)
        {

        }
        public double CalcularSalario()
        {
            return Salario * 1.3; 
        }
    }
}