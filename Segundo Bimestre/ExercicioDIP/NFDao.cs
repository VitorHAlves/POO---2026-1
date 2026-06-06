using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class NFDao : INFDao
    {
        public void Persiste(NotaFiscal nf)
        {
            Console.WriteLine("Nota fiscal salva no banco de dados.");
        }
    }
}