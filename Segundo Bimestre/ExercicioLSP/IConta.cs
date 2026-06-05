using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioLSP
{
    public interface IConta
    {
        void Sacar(decimal valor);
        decimal Saldo {get;}
        void Depositar(decimal valor);
    }
}