using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioSRP
{
    public class GeradorRelatorios
    {
        public string GerarRelatorio()
        {
            return $"Titular: {Titular}\tSaldo: {Saldo:c}";
        }
    }
}