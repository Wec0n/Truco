using System.Text;

namespace Truco.Entities;
class Carta {
    public string Nome { get; set; }
    public int Valor { get; set; }
    public string Naipe { get; set; }
    public int Pontos { get; set; }
    public int Numero { get; set; }

    public Carta(string nome, int valor, string naipe, int pontos, int numero) {
        Nome = nome;
        Valor = valor;
        Naipe = naipe;
        Pontos = pontos;
        Numero = numero;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Nome: " + Nome);
        sb.AppendLine("Valor: " + Valor);
        sb.AppendLine("Naipe: " + Naipe);
        sb.AppendLine("Pontos: " + Pontos);
        sb.AppendLine("Número: " + Numero);

        return sb.ToString();
    }

    public override bool Equals(object obj) {
        if(!(obj is Carta)) {
            return false;
        }

        Carta outra = obj as Carta;

        return Valor.Equals(outra.Valor) && Naipe.Equals(outra.Naipe);
    }
}