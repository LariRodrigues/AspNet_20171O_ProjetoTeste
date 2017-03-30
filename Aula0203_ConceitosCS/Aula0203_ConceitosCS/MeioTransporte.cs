using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_ConceitosCS
{
    public abstract class MeioTransporte : Imotorizado
    {
        public int QuantidadeRoda { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }


        public virtual void Acelerar()
        {
            Console.WriteLine("MT: Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine("MT: Freando");
        }
    }
}
