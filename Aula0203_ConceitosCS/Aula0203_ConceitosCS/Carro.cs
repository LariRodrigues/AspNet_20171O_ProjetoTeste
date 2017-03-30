using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_ConceitosCS
{
    public class Carro : MeioTransporte
    {
        public override void Acelerar()
        {
            //base.Acelerar();
            System.Console.WriteLine("Carro: Acelerando..");
        }
    }
}
