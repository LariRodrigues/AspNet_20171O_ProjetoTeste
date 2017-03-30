using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_ConceitosCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.Ano = 1980;
            c.QuantidadeRoda = 4;
            c.Nome = "Fusca";
            c.Acelerar();
            c.Frear();

            Barco b = new Barco();
            b.QuantidadePes = 20;
            b.Nome = "Titanic";
            b.Ano = 1909;
            c.Acelerar();
            c.Frear();

            Uber u = new Uber("Godofredo");
            u.Ano = 2017;
            u.Nome = "BMW";
            u.QuantidadeRoda = 4;
            c.Acelerar();
            c.Frear();

            System.Console.ReadKey();
            

        }
    }
}
