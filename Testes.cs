// using System.Text;
// using Truco.Entities;

// namespace Truco.Entities;
// public static class Testes {
//     public static void JogadoresArquivoTexto() {
//         // SALVAR OS JOGADORES EM UM ARQUIVO DE TEXTO (TESTES!)
//         string path = @"C:\Development\csharp\Truco\jogadores-testes.txt";
//         for (int j = 0; j < 1000; j++) { // Criação de listas de 6 jogadores
//             Baralho.CriarBaralho();
//             List<Jogador> jogadores = new List<Jogador>();
//             for (int i = 0; i < 13; i++) {
//                 jogadores.Add(new Jogador());
//             }
//             using (StreamWriter sw = File.AppendText(path)) {
//                 foreach (Jogador k in jogadores) {
//                     Console.WriteLine(k);
//                     Console.WriteLine("----------------------------------------------------------------");
//                     sw.WriteLine(k);
//                     sw.WriteLine("----------------------------------------------------------------");
//                 }
//             }
//         }
//         // SALVAR OS JOGADORES EM UM ARQUIVO DE TEXTO (TESTES!)
//     }
//     public static void ListarCartasDosJogadores() {
//         Baralho.CriarBaralho();
//         List<Jogador> jogadores = new List<Jogador>();
//         for (int i = 0; i < 1; i++) {
//             jogadores.Add(new Jogador());
//         }
//         foreach (Jogador k in jogadores) {
//             Console.WriteLine(k);
//             Console.WriteLine("----------------------------------------------------------------");
//         }
//     }

//     public static void GerarJogadores() {
//         Random rand = new Random();

//         Baralho.CriarBaralho();

//         Jogador j1 = new Jogador();
//         Console.WriteLine(j1);
//         Console.WriteLine("---------------------------------------------------");
//         Jogador j2 = new Jogador();
//         Console.WriteLine(j2);
//         Console.WriteLine("---------------------------------------------------");
//         Jogador j3 = new Jogador();
//         Console.WriteLine(j3);
//         Console.WriteLine("---------------------------------------------------");
//         Jogador j4 = new Jogador();
//         Console.WriteLine(j4);
//         Console.WriteLine("---------------------------------------------------");
//         Jogador j5 = new Jogador();
//         Console.WriteLine(j5);
//         Console.WriteLine("---------------------------------------------------");
//         Jogador j6 = new Jogador();
//         Console.WriteLine(j6);
//     }

//     public static void CompararCartas(Carta c1, Carta c2) {
//         if (c1.Valor > c2.Valor) {
//             Console.WriteLine(c1.Nome + " é maior que " + c2.Nome);
//         } else if ((c1.Valor < c2.Valor)) {
//             Console.WriteLine(c2.Nome + " é maior que " + c1.Nome);
//         } else if ((c1.Valor == c2.Valor) && (c1.Naipe == c2.Naipe)) {
//             Console.WriteLine("Carta 1 e carta 2 são a mesma carta: " + c1.Nome);
//         } else {
//             Console.WriteLine(c1.Nome + " e " + c2.Nome + " têm o mesmo valor");
//         }
//     }

//     public static void GerarCartas() {
//         Random rand = new Random();
//         Carta c1 = Baralho.Cartas.ElementAt(4); // três de espada
//         Carta c2 = Baralho.Cartas.ElementAt(5); // três de basto
//         Carta c3 = Baralho.Cartas.ElementAt(8); // dois de espada
//         Carta c4 = Baralho.Cartas.ElementAt(0); // ás de espada
//         Carta c5 = Baralho.Cartas.ElementAt(0); // ás de espada
//     }
// }