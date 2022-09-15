using System.Text;

namespace Truco.Entities;
class Carta {
    public string Nome { get; set; }
    public int Valor { get; set; }
    public string Naipe { get; set; }
    public int Pontos { get; set; }

    public Carta(int valor, string naipe) {
        Nome = ;
        Valor = valor;
        Naipe = naipe;
        Pontos = pontos;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Nome: " + Nome);
        sb.AppendLine("Valor: " + Valor);
        sb.AppendLine("Naipe: " + Naipe);
        sb.AppendLine("Pontos: " + Pontos);

        return sb.ToString();
    }
}