using System.Text;

namespace Truco.Entities;
class Jogador {
    List<Carta> CartasDoJogador { get; set; } = new List<Carta>(3);
    public int PontosDoJogador { get; set; }
    public bool Flor { get; set; }

    public Jogador() {
        Random rand = new Random();
        while (CartasDoJogador.Count < 3) {
            int IndiceQuantidadeBaralho = Baralho.Cartas.Count - 1;
            int IndiceDaCarta = rand.Next(IndiceQuantidadeBaralho);

            Carta Carta = Baralho.Cartas.ElementAt(IndiceDaCarta);

            if (CartasDoJogador.IndexOf(Carta) < 0) {
                CartasDoJogador.Add(Carta);
                Baralho.Cartas.Remove(Carta);
            }
        }
    }

    public void Pontos() {
        int contador = 0;
        int total = 0;
        for (int i = 0; i < CartasDoJogador.Count; i++) {
            for (int j = 0; j < CartasDoJogador.Count; j++) {
                if (i == j) {
                    break;
                }
                if (CartasDoJogador.ElementAt(i).Naipe == CartasDoJogador.ElementAt(j).Naipe) {
                    contador++;
                    total = CartasDoJogador.ElementAt(i).Pontos + CartasDoJogador.ElementAt(j).Pontos;
                }
            }
        }
        Console.WriteLine(contador);
        Console.WriteLine(total);
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        foreach(Carta c in CartasDoJogador) {
            sb.AppendLine(c.Numero.ToString() + " - " + c.Naipe.ToString());
        }

        return sb.ToString();
    }

    // public override bool Equals(object obj) {
    //     if(!(obj is Carta)) {
    //         return false;
    //     }

    //     Carta outra = obj as Carta;

    //     return Valor.Equals(outra.Valor) && Naipe.Equals(outra.Naipe);
    // }
}