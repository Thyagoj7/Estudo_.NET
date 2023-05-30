// See https://aka.ms/new-console-template for more information


using System;
using System.Diagnostics;

namespace EstudoAsync // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;


            Teste_01 teste = new Teste_01();
            //Foi colocado um delay na task do metodo para simular um aguarde, e então o Classe Principal acaba executando primeiro
            teste.texto1();

            //Thread.Sleep(5000);
            Console.WriteLine("Classe Principal");

           
        }
    }
}
