using Truco.Entities.Enums;
using System.Text;

namespace Truco.Entities;
class Jogador {
    List<Carta> CartasDoJogador = new List<Carta>();

    public Jogador () {
        Random rand = new Random();

        while (CartasDoJogador.Count < 3) {
            int aleatorio = rand.Next(1, 14);
            Carta cartateste = new Carta((Valor)aleatorio);
            if (CartasDoJogador.IndexOf(cartateste) < 0) {
                CartasDoJogador.Add(cartateste);
            }
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        foreach (Carta c in CartasDoJogador) {
            sb.AppendLine(c.ToString());
        }

        return sb.ToString();
    }
}