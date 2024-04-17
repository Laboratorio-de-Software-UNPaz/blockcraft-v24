using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class NoArma : Arma
    {
        private int danio;

        public NoArma()
        {
            this.danio = 0;
        }
        public void Atacar(Enemigo enemigo)
        {
            enemigo.RecibirDanio(this.danio);
        }
    }
}
