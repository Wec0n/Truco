using System.Text;

namespace Truco.Entities;
class Carta {
    public int Valor { get; set; }
    public int Pontos { get; set; }
    public string Naipe { get; set; }

    public Carta() {
        Random rand = new Random();

        string[] naipes = new string[4]{"Espada", "Basto", "Ouro", "Copa"};

        Valor = rand.Next(1, 14);
        Naipe = naipes[rand.Next(0, 3)];
        Pontos = 0;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Valor: " + Valor);
        sb.AppendLine("Naipe: " + Naipe);

        return sb.ToString();
    }
}