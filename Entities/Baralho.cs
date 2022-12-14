// using System.Text;

namespace Truco.Entities;
static class Baralho {
    public static List<Carta> Cartas { get; set; } = new List<Carta>();

    public static void CriarBaralho() {
        Cartas.Add(new Carta("Ás de espada", 14, "Espada", 1, 1)); // Ás de espada
        Cartas.Add(new Carta("Ás de basto", 13, "Basto", 1, 1));  // Ás de basto
        Cartas.Add(new Carta("Manilha de Espada", 12, "Espada", 7, 7)); // Manilha de espada
        Cartas.Add(new Carta("Manilha de ouro", 11, "Ouro", 7, 7));   // Manilha de ouro

        Cartas.Add(new Carta("Três de espada", 10, "Espada", 3, 3)); // Três
        Cartas.Add(new Carta("Três de basto", 10, "Basto", 3, 3));  // Três
        Cartas.Add(new Carta("Três de ouro", 10, "Ouro", 3, 3));   // Três
        Cartas.Add(new Carta("Três de copa", 10, "Copa", 3, 3));   // Três

        Cartas.Add(new Carta("Dois de espada", 9, "Espada", 2, 2));  // Dois
        Cartas.Add(new Carta("Dois de basto", 9, "Basto", 2, 2));   // Dois
        Cartas.Add(new Carta("Dois de ouro", 9, "Ouro", 2, 2));    // Dois
        Cartas.Add(new Carta("Dois de copa", 9, "Copa", 2, 2));    // Dois

        Cartas.Add(new Carta("Ás de ouro", 8, "Ouro", 1, 1));    // Ás de ouro
        Cartas.Add(new Carta("Ás de copa", 8, "Copa", 1, 1));    // Ás de copa

        Cartas.Add(new Carta("Rei de espada", 7, "Espada", 0, 12));  // Rei
        Cartas.Add(new Carta("Rei de basto", 7, "Basto", 0, 12));   // Rei
        Cartas.Add(new Carta("Rei de ouro", 7, "Ouro", 0, 12));    // Rei
        Cartas.Add(new Carta("Rei de copa", 7, "Copa", 0, 12));    // Rei

        Cartas.Add(new Carta("Cavalo de espada", 6, "Espada", 0, 11));  // Cavalo
        Cartas.Add(new Carta("Cavalo de basto", 6, "Basto", 0, 11));   // Cavalo
        Cartas.Add(new Carta("Cavalo de ouro", 6, "Ouro", 0, 11));    // Cavalo
        Cartas.Add(new Carta("Cavalo de copa", 6, "Copa", 0, 11));    // Cavalo

        Cartas.Add(new Carta("Sota de espada", 5, "Espada", 0, 10));  // Sota
        Cartas.Add(new Carta("Sota de basto", 5, "Basto", 0, 10));   // Sota
        Cartas.Add(new Carta("Sota de ouro", 5, "Ouro", 0, 10));    // Sota
        Cartas.Add(new Carta("Sota de copa", 5, "Copa", 0, 10));    // Sota

        Cartas.Add(new Carta("Sete de basto", 4, "Basto", 7, 7));   // Sete de basto
        Cartas.Add(new Carta("Sete de copa", 4, "Copa", 7, 7));    // Sete de copa

        Cartas.Add(new Carta("Seis de espada", 3, "Espada", 6, 6));  // Seis
        Cartas.Add(new Carta("Seis de basto", 3, "Basto", 6, 6));   // Seis
        Cartas.Add(new Carta("Seis de ouro", 3, "Ouro", 6, 6));    // Seis
        Cartas.Add(new Carta("Seis de copa", 3, "Copa", 6, 6));    // Seis

        Cartas.Add(new Carta("Cinco de espada", 2, "Espada", 5, 5));  // Cinco
        Cartas.Add(new Carta("Cinco de basto", 2, "Basto", 5, 5));   // Cinco
        Cartas.Add(new Carta("Cinco de ouro", 2, "Ouro", 5, 5));    // Cinco
        Cartas.Add(new Carta("Cinco de copa", 2, "Copa", 5, 5));    // Cinco

        Cartas.Add(new Carta("Quatro de espada", 1, "Espada", 4, 4));  // Quatro
        Cartas.Add(new Carta("Quatro de basto", 1, "Basto", 4, 4));   // Quatro
        Cartas.Add(new Carta("Quatro de ouro", 1, "Ouro", 4, 4));    // Quatro
        Cartas.Add(new Carta("Quatro de copa", 1, "Copa", 4, 4));    // Quatro
    }

    // public override string ToString() {
    //     StringBuilder sb = new StringBuilder();

    //     sb.AppendLine("");

    //     return sb.ToString();
    // }
}