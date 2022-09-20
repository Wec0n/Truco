using System.Text;

namespace Truco.Entities;
public class Jogador {
    public List<Carta> ListaDeCartas { get; set; }
    public int PontosDoJogador { get; private set; }
    public bool Flor { get; private set; }
    public Mesa Mesa { get; set; }

    public Jogador(Mesa mesa) {
        ListaDeCartas = GerarCartas();
        PontosDoJogador = Pontos();
        Mesa = mesa;
    }

    public List<Carta> GerarCartas() {
        List<Carta> ListaDeCartas = new List<Carta>(3);
        Random rand = new Random();
        while (ListaDeCartas.Count < 3) {
            int IndiceQuantidadeBaralho = Baralho.Cartas.Count;
            int IndiceDaCarta = rand.Next(IndiceQuantidadeBaralho);
            Carta Carta = Baralho.Cartas.ElementAt(IndiceDaCarta);
            if (ListaDeCartas.IndexOf(Carta) < 0) {
                ListaDeCartas.Add(Carta);
                Baralho.Cartas.Remove(Carta);
            }
        }
        return ListaDeCartas;
    }

    public int Pontos() {
        int contador = 0;
        int total = 0;
        for (int i = 0; i < ListaDeCartas.Count; i++) {
            for (int j = 0; j < ListaDeCartas.Count; j++) {
                if (i == j) {
                    break;
                }
                if ((ListaDeCartas.ElementAt(i).Naipe == ListaDeCartas.ElementAt(j).Naipe)) {
                    contador++;
                    total = ListaDeCartas.ElementAt(i).Pontos + ListaDeCartas.ElementAt(j).Pontos + 20;
                }
            }
        }
        if (contador == 3) {
            Flor = true;
            total = 20;
            foreach (Carta c in ListaDeCartas) {
                total += c.Pontos;
            }
        }
        if (contador == 0) {
            total += ListaDeCartas.MaxBy(x => x.Pontos).Pontos;
        }
        return total;
    }

    public void JogarCarta() {
        Mesa.Posicoes[0, 0] = ListaDeCartas.ElementAt(0);
        ListaDeCartas.Remove(ListaDeCartas.ElementAt(0));
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        foreach(Carta c in ListaDeCartas) {
            sb.AppendLine(c.ToString());
        }

        sb.AppendLine("Pontos: " + PontosDoJogador);
        sb.AppendLine("Tem flor: " + Flor);

        return sb.ToString();
    }
}