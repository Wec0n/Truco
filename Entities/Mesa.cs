using System.Text;

namespace Truco.Entities;
public class Mesa {
    public List<Jogador> JogadoresDaMesa { get; set; } = new List<Jogador>(2);
    public Carta[,] Posicoes = new Carta[2, 3];

    public Mesa() {
        // for (int i = 0; i < Posicoes.GetLength(0); i++) {
        //     for (int j = 0; j < Posicoes.GetLength(1); j++) {
        //         Posicoes[i, j] = JogadoresDaMesa[i].ListaDeCartas.ElementAt(j);
        //     }
        // }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < Posicoes.GetLength(0); i++) {
            sb.AppendLine("JOGADOR: " + (i+1));
            for (int j = 0; j < Posicoes.GetLength(1); j++) {
                if (Posicoes[i, j] == null) {
                    sb.AppendLine("Vazio ");
                } else {
                    sb.AppendLine("Linha: " + (i+1) + " - coluna: " + (j+1));
                    sb.AppendLine(Posicoes[i, j].ToString());
                }
            }
            sb.AppendLine();
        }
        foreach(Jogador j in JogadoresDaMesa) {
            sb.AppendLine(j.ToString());
            sb.AppendLine("------------------------------------------------------");
        }

        return sb.ToString();
    }
}