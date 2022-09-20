using System.Text;

namespace Truco.Entities;
public class Partida {
    public Mesa MesaDaJogada { get; set; }

    public Partida() {
        Baralho.CriarBaralho();
        MesaDaJogada = new Mesa();
        for (int i = 0; i < MesaDaJogada.JogadoresDaMesa.Capacity; i++) {
            MesaDaJogada.JogadoresDaMesa.Add(new Jogador(MesaDaJogada));
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        // foreach(Jogador j in JogadoresDaPartida) {
        //     sb.AppendLine(j.ToString());
        //     sb.AppendLine();
        // }
        sb.AppendLine(MesaDaJogada.ToString());

        return sb.ToString();
    }
}