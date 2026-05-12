using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticadavel
{
    public interface IAutenticavel
    {//esse metodo é implicitamente público e abstrato
        bool Autenticar(int senha);
    }
}