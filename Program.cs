using Truco.Entities;
using Truco.Entities.Enums;

namespace Truco;
class Program {
    static void Main(string[] args) {
        Random rand = new Random();

        Carta c1 = new Carta((Valor)rand.Next(1, 14));

        Console.WriteLine(c1);

        // string teste = "Willian Eduardo Soares da Silva";

        // bool contem = teste.Contains("Willian");

        // Console.WriteLine(contem);
    }
}