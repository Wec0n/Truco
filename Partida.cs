using System.Text;

namespace Truco.Entities;
public class Partida {
    public Mesa MesaDaJogada { get; set; } = new Mesa();

    public Partida() {
        Baralho.CriarBaralho();
        for (int i = 0; i < MesaDaJogada.JogadoresDaMesa.Capacity; i++) {
            MesaDaJogada.JogadoresDaMesa.Add(new Jogador(MesaDaJogada));
            Random rand = new Random();
            while (MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.Count < 3) {
                int IndiceQuantidadeBaralho = Baralho.Cartas.Count;
                int IndiceDaCarta = rand.Next(IndiceQuantidadeBaralho);
                Carta Carta = Baralho.Cartas.ElementAt(IndiceDaCarta);
                if (MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.IndexOf(Carta) < 0) {
                    MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.Add(Carta);
                    Baralho.Cartas.Remove(Carta);
                }
            }
            // GERAR OS PONTOS DO JOGADOR
            int contador = 0;
            int total = 0;
            for (int j = 0; j < MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.Count; j++) {
                for (int k = 0; k < MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.Count; k++) {
                    if (i == j) {
                        break;
                    }
                    if ((MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.ElementAt(i).Naipe == MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.ElementAt(j).Naipe)) {
                        contador++;
                        total = MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.ElementAt(i).Pontos + MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.ElementAt(j).Pontos + 20;
                    }
                }
            }
            if (contador == 3) {
                MesaDaJogada.JogadoresDaMesa[i].Flor = true;
                total = 20;
                foreach (Carta c in MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas) {
                    total += c.Pontos;
                }
            }
            if (contador == 0) {
                total += MesaDaJogada.JogadoresDaMesa[i].ListaDeCartas.MaxBy(x => x.Pontos).Pontos;
            }
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(MesaDaJogada.ToString());

        return sb.ToString();
    }
}