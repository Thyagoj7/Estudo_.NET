using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAsync
{
    internal class Teste_01
    {

        public Teste_01()
        {


        }

        public Teste_01(int a, int b)
        {
            ax = a;
            ay = b;

        }

        public int ax { get; set; }
        public int ay { get; set; }

        public void pegaNumero(int ax, int ay)
        {
            soma(ax, ay);
        }


        internal void soma(int A, int B)
        {
            int R = A + B;
            Console.WriteLine(R);
        }


    }
}
