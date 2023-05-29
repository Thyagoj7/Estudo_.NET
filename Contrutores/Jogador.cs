using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrutores
{
    public class Jogador
    {
        public int energia;
        public bool vivo;

        

        public Jogador(int energia) {
            this.energia = energia;
        }

        public Jogador() { }

        public int saldoGol(int bola)
        {
            return bola;
        }
    }
}
