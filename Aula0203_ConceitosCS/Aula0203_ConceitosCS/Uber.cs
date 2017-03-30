using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_ConceitosCS
{
    public class Uber : Carro
    {
        public string NomeMotorista { get; set; }

        public Uber(string nomeMotorista)
        {
            NomeMotorista = nomeMotorista;
        }
    }
}
