using System;

namespace pilhaDeJogos
{
    internal class Program
    {
        public static int Menu()
        {
            bool flag = true;
            string selecionado;
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("----- Pilha de jogos -----");
                Console.WriteLine("\n1 - Adicionar um jogo a pilha\n2 - Buscar um jogo da pilha" +
                    "\n3 - Imprimir a pilha de jogos\n4 - Remover um jogo da pilha\n5 - Sair");
                Console.WriteLine("");
                selecionado = Console.ReadLine();
                int.TryParse(selecionado, out opcao);

                if ((opcao < 1) || (opcao > 5))
                {
                    Console.WriteLine("Opção inválida !!!");
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadKey();
                }
                else
                {
                    flag = false;
                }
            } while (flag);
            return opcao;
        }
        static Jogo InserirJogo()
        {
            Console.WriteLine("Insira o título do jogo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Insira o gênero do jogo: ");
            string genero = Console.ReadLine();
            Console.WriteLine("Insira a desenvolvedora do jogo: ");
            string desenvolvedora = Console.ReadLine();
            Console.WriteLine("Insira a distribuidora do jogo: ");
            string distribuidora = Console.ReadLine();
            Console.WriteLine("Insira o ano de lançamento do jogo: ");
            int anoDeLancamento = int.Parse(Console.ReadLine());
            return new Jogo(titulo, genero, desenvolvedora, distribuidora, anoDeLancamento);
        }
        static void Main(string[] args)
        {
            Pilha_Jogo novaPilhaDeJogos = new Pilha_Jogo();

            bool flag = true;
            int opcao = 0;
            opcao = Menu();

            do
            {
                switch (opcao)
                {
                    case 1:
                        novaPilhaDeJogos.Push(InserirJogo());
                        opcao = Menu();
                        break;
                    case 2:
                        novaPilhaDeJogos.Search();
                        opcao = Menu();
                        break;
                    case 3:
                        novaPilhaDeJogos.Print();
                        opcao = Menu();
                        break;
                    case 4:
                        novaPilhaDeJogos.Pop();
                        opcao = Menu();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Pressione ENTER para voltar");
                        Console.ReadKey();
                        break;
                }
            } while (flag);
        }
    }
}
