using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Hacha : Arma
    {
        private int danio;

        public Hacha(int danio)
        {
            this.danio = danio;
        }

        public void Atacar(Enemigo enemigo)
        {
            enemigo.RecibirDanio(this.danio);
        }
    }
}
