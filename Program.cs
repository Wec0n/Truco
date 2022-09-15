using Truco.Entities;

namespace Truco;
class Program {
    static void Main(string[] args) {
        Random rand = new Random();

        Baralho.CriarBaralho();

        Jogador j1 = new Jogador();
        Console.WriteLine(j1);
        
        // Jogador j2 = new Jogador();
        // Console.WriteLine(j2);
        // Jogador j3 = new Jogador();
        // Console.WriteLine(j3);
        // Jogador j4 = new Jogador();
        // Console.WriteLine(j4);
        // Jogador j5 = new Jogador();
        // Console.WriteLine(j5);
        // Jogador j6 = new Jogador();
        // Console.WriteLine(j6);

        // Carta c1 = Baralho.Cartas.ElementAt(rand.Next(0, 3));
        // Carta c1 = Baralho.Cartas.ElementAt(4); // três de espada
        // Carta c2 = Baralho.Cartas.ElementAt(5); // três de basto
        // Carta c3 = Baralho.Cartas.ElementAt(8); // dois de espada
        // Carta c4 = Baralho.Cartas.ElementAt(0); // ás de espada
        // Carta c5 = Baralho.Cartas.ElementAt(0); // ás de espada
    }

    static void Joagada(Carta c1, Carta c2) {
        if (c1.Valor > c2.Valor) {
            Console.WriteLine(c1.Nome + " é maior que " + c2.Nome);
        } else if ((c1.Valor < c2.Valor)) {
            Console.WriteLine(c2.Nome + " é maior que " + c1.Nome);
        } else if ((c1.Valor == c2.Valor) && (c1.Naipe == c2.Naipe)) {
            Console.WriteLine("Carta 1 e carta 2 são a mesma carta: " + c1.Nome);
        } else {
            Console.WriteLine(c1.Nome + " e " + c2.Nome + " têm o mesmo valor");
        }
    }
}