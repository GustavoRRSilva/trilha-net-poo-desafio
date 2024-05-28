using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioCelular.models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no seu Nokia...");
        }
    }
}