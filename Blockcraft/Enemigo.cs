using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Enemigo
    {
        private int energia;

        public Enemigo(int energia)
        {
            this.energia = energia;
        }

        public void exponerEnergia()
        {
            Console.WriteLine("Mi energía es: " + this.energia);
        }

        public void RecibirDanio(int danio)
        {
            this.energia -= danio;
        }
    }
}
