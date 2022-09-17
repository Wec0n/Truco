using System.Text;

namespace Truco.Entities;
class Jogador {
    List<Carta> CartasDoJogador { get; set; } = new List<Carta>(3);
    public int PontosDoJogador { get; set; }
    public bool Flor { get; set; }

    public Jogador() {
        Random rand = new Random();
        while (CartasDoJogador.Count < 3) {
            int IndiceQuantidadeBaralho = Baralho.Cartas.Count;
            int IndiceDaCarta = rand.Next(IndiceQuantidadeBaralho);

            Carta Carta = Baralho.Cartas.ElementAt(IndiceDaCarta);

            if (CartasDoJogador.IndexOf(Carta) < 0) {
                CartasDoJogador.Add(Carta);
                Baralho.Cartas.Remove(Carta);
            }
        }

        PontosDoJogador = Pontos();
    }

    public int Pontos() {
        int contador = 0;
        int total = 0;
        for (int i = 0; i < CartasDoJogador.Count; i++) {
            for (int j = 0; j < CartasDoJogador.Count; j++) {
                if (i == j) {
                    break;
                }
                if ((CartasDoJogador.ElementAt(i).Naipe == CartasDoJogador.ElementAt(j).Naipe)) {
                    contador++;
                    total = CartasDoJogador.ElementAt(i).Pontos + CartasDoJogador.ElementAt(j).Pontos + 20;
                }
            }
        }
        if (contador == 3) {
            Flor = true;
            total = 20;
            foreach (Carta c in CartasDoJogador) {
                total += c.Pontos;
            }
        }
        if (contador == 0) {
            total += CartasDoJogador.MaxBy(x => x.Pontos).Pontos;
        }

        return total;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        foreach(Carta c in CartasDoJogador) {
            // sb.AppendLine(c.Numero.ToString() + " - " + c.Naipe.ToString());

            sb.AppendLine(c.ToString());
        }

        sb.AppendLine("Tem Flor: " + Flor);
        if (!Flor) {
            sb.AppendLine("Pontos do envido: " + PontosDoJogador);
        } else {
            sb.AppendLine("Pontos da flor: " + PontosDoJogador);
        }

        return sb.ToString();
    }
}