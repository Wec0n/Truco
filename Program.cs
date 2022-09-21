using Truco.Entities;

namespace Truco;
class Program {
    static void Main(string[] args) {
        Partida p1 = new Partida();
        Console.WriteLine(p1);
        
        p1.MesaDaJogada.JogadoresDaMesa[0].JogarCarta(0);
        
        Console.WriteLine(p1);
    }
}