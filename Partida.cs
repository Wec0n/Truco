using System.Text;

namespace Truco.Entities;
public class Partida {
    public Mesa MesaDaJogada { get; set; } = new Mesa();

    public Partida() {
        Baralho.CriarBaralho();
        for (int i = 0; i < MesaDaJogada.JogadoresDaMesa.Capacity; i++) {
            MesaDaJogada.JogadoresDaMesa.Add(new Jogador(MesaDaJogada));
            if (i == 0 ) {
                MesaDaJogada.JogadoresDaMesa[i].JogadorPrincipal = true;
            }
            DarCartas(MesaDaJogada.JogadoresDaMesa[i]);
            GerarPontos(MesaDaJogada.JogadoresDaMesa[i]);
        }
    }

    public void DarCartas(Jogador jogador) {
        Random rand = new Random();
        while (jogador.ListaDeCartas.Count < 3) {
            int IndiceQuantidadeBaralho = Baralho.Cartas.Count;
            int IndiceDaCarta = rand.Next(IndiceQuantidadeBaralho);
            Carta Carta = Baralho.Cartas.ElementAt(IndiceDaCarta);
            if (jogador.ListaDeCartas.IndexOf(Carta) < 0) {
                jogador.ListaDeCartas.Add(Carta);
                Baralho.Cartas.Remove(Carta);
            }
        }
    }

    public void GerarPontos(Jogador jogador) {
        int contador = 0;
        int total = 0;
        for (int j = 0; j < jogador.ListaDeCartas.Count; j++) {
            for (int k = 0; k < jogador.ListaDeCartas.Count; k++) {
                if (j == k) {
                    break;
                }
                if ((jogador.ListaDeCartas.ElementAt(j).Naipe == jogador.ListaDeCartas.ElementAt(k).Naipe)) {
                    contador++;
                    total = jogador.ListaDeCartas.ElementAt(j).Pontos + jogador.ListaDeCartas.ElementAt(k).Pontos + 20;
                }
            }
        }
        if (contador == 3) {
            jogador.Flor = true;
            total = 20;
            foreach (Carta c in jogador.ListaDeCartas) {
                total += c.Pontos;
            }
        }
        if (contador == 0) {
            total += jogador.ListaDeCartas.MaxBy(x => x.Pontos).Pontos;
        }
        jogador.PontosDoJogador += total;
    }

    public void Teste() {
        Jogador JogadorParaContagemDeCarta = null;
        MesaDaJogada.JogadoresDaMesa.ForEach(ParametroContagemCartasJogadorPrincipal => {
            if (ParametroContagemCartasJogadorPrincipal.JogadorPrincipal == true) {
                JogadorParaContagemDeCarta = ParametroContagemCartasJogadorPrincipal;
            }
        });
        while(JogadorParaContagemDeCarta.ListaDeCartas.Count > 0) {
            Random rand = new Random();
            Carta c1 = null;
            Carta c2 = null;
            foreach(Jogador j in MesaDaJogada.JogadoresDaMesa) {
                if (j.JogadorPrincipal == true) {
                    Console.WriteLine("Escolha uma carta para ser jogada: ");
                    int carta = int.Parse(Console.ReadLine());
                    c1 = j.ListaDeCartas[carta];
                    j.JogarCarta(carta);
                } else {
                    int qtdeCartasAdversario = j.ListaDeCartas.Count;
                    int CartaDoAdversario = rand.Next(0, qtdeCartasAdversario);
                    c2 = j.ListaDeCartas[CartaDoAdversario];
                    j.JogarCarta(CartaDoAdversario);
                }
                Console.WriteLine(this.MesaDaJogada);
                if (c1 != null && c2 != null) {
                    CompararCartas(c1, c2);
                }
            }
        }
    }

    public void CompararCartas(Carta c1, Carta c2) {
        if (c1.Valor > c2.Valor) {
            Console.WriteLine(c1.Nome + " é maior que " + c2.Nome);
        } else if ((c1.Valor < c2.Valor)) {
            Console.WriteLine(c2.Nome + " é maior que " + c1.Nome);
        } else if ((c1.Valor == c2.Valor) && (c1.Naipe == c2.Naipe)) {
            Console.WriteLine("Carta 1 e carta 2 são a mesma carta: " + c1.Nome);
        } else {
            Console.WriteLine(c1.Nome + " e " + c2.Nome + " têm o mesmo valor");
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(MesaDaJogada.ToString());

        return sb.ToString();
    }
}