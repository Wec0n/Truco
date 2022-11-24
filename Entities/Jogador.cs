using System.Text;

namespace Truco.Entities;
public class Jogador {
    public List<Carta> ListaDeCartas { get; set; } = new List<Carta>(3);
    public int PontosDoJogador { get; set; }
    public bool Flor { get; set; }
    public Mesa Mesa { get; set; }
    public bool JogadorPrincipal { get; set; }
    public int Pontuacao { get; set; }

    public Jogador(Mesa mesa) {
        Mesa = mesa;
    }

    public void JogarCarta(int posicaoDaCarta) {
        for (int i = 0; i < Mesa.Posicoes.GetLength(1); i++) {
            if (Mesa.Posicoes[Mesa.JogadoresDaMesa.IndexOf(this), i] == null) {
                Mesa.Posicoes[Mesa.JogadoresDaMesa.IndexOf(this), i] = ListaDeCartas.ElementAt(posicaoDaCarta);
                ListaDeCartas.Remove(ListaDeCartas.ElementAt(posicaoDaCarta));
                break;
            }
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        foreach(Carta c in ListaDeCartas) {
            sb.AppendLine(c.ToString());
            sb.AppendLine("INDEX DA CARTA: " + ListaDeCartas.IndexOf(c));
        }

        sb.AppendLine("Pontos: " + PontosDoJogador);
        sb.AppendLine("Tem flor: " + Flor);
        sb.AppendLine("É jogador principal? " + JogadorPrincipal);
        sb.AppendLine("Pontuação: ".ToUpper() + Pontuacao);

        return sb.ToString();
    }
}