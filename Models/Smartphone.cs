using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioCelular.models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public void Ligar()
        {
            Console.WriteLine("Celular ligado..");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
        }

        public virtual void InstalarAplicativo(string nome)
        {

        }

    }
}