using Blockcraft;

Arma espada = new Espada(10);

Enemigo enemigo = new Enemigo(100);

Personaje personaje = new Personaje(new NoArma());

personaje.Atacar(enemigo);
enemigo.exponerEnergia();

personaje.AgarrarArma(espada);

Console.WriteLine("Estoy atacando ...");

personaje.Atacar(enemigo);
enemigo.exponerEnergia();
