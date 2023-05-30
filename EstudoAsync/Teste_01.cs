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

        public int ax;
        public int ay;

        public void pegaNumero(int ax, int ay)
        {
            soma(ax, ay);
        }


        internal void soma(int A, int B)
        {
            int R = A + B;
            Console.WriteLine(R);
        }

        //Método Assyncrono para teste
        public async void texto1()
        {
            
            await Task.Delay(10); // Placeholder asynchronous operation
            var texto = "Classe de teste";
            Console.WriteLine(texto);
            //return texto.ToString();
        }


    }

}


/*           
        }

        public async void texto2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Texto_02");
        }





    }
}
*/