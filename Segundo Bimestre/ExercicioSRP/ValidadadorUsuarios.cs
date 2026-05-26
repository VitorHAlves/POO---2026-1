using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioSRP
{
    public class ValidadadorUsuarios
    {

        public bool ValidarUsuario(Conta conta, string? nome)
        {
            return conta.Titular == nome;
        }
    }
}