using System.Text;

namespace Truco.Entities;
class Jogador {
    List<Carta> ListaDeCartas { get; set; }
    public int PontosDoJogador { get; private set; }
    public bool Flor { get; private set; }

    public Jogador() {
        ListaDeCartas = GerarCartas();
        PontosDoJogador = Pontos();
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

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        foreach(Carta c in ListaDeCartas) {
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