using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Personaje
    {
        private Arma arma;

        public Personaje(Arma arma)
        {
            this.arma = arma;
        }

        public void AgarrarArma(Arma arma)
        {
            this.arma = arma;
        }

        public void Atacar(Enemigo enemigo)
        {
            //enemigo.setEnergia(enemigo.getEnergia() - arma.danio);
            //enemigo.RecibirDanio(arma.getDanio());
            this.arma.Atacar(enemigo);
        }
    }
}
