using Truco.Entities.Enums;
using System.Text;

namespace Truco.Entities;
public class Carta {
    public Valor Valor { get; set; }
    public string Naipe { get; set; }
    public int Pontos { get; set; }

    public Carta (Valor valor) {
        string[] vectNaipes = {"Espada", "Basto", "Ouro", "Copa"};
        Valor = valor;
        Naipe = vectNaipes[(int)Enum.Parse<Naipe>(valor.ToString())];
        Pontos = (int)Enum.Parse<Ponto>(valor.ToString());
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Valor: " + Valor);
        sb.AppendLine("Naipe: " + Naipe);
        sb.AppendLine("Pontos: " + Pontos);

        return sb.ToString();
    }
}