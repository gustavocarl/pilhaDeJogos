using System;

namespace pilhaDeJogos
{
    internal class Pilha_Jogo
    {
        public Jogo Top { get; set; }

        public Pilha_Jogo()
        {
            Top = null;
        }

        public void Push(Jogo aux)
        {
            aux.Anterior = Top;
            Top = aux;
            Console.WriteLine("----- Adicionando um jogo a pilha -----");
            Console.WriteLine(aux.ToString());
            Console.ReadKey();
        }

        public void Print()
        {
            if (Vazio())
            {
                Console.WriteLine("Essa pilha está vazia, por favor adicione um novo jogo!!!");
                Console.ReadKey();
            }
            else
            {
                Jogo aux = Top;
                Console.WriteLine("Imprimindo lista de jogos\n");
                do
                {
                    Console.WriteLine(aux.ToString() + "\n");
                    Console.ReadKey();
                    aux = aux.Anterior;
                } while (aux != null);
            }
        }

        public void Pop()
        {
            Jogo aux = Top;
            if (Vazio())
            {
                Console.WriteLine("Não há nenhum jogo nessa pilha!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O jogo " + aux.Titulo + " está sendo removido da pilha: ");
                Top = Top.Anterior;
                Console.WriteLine("Jogo removido com sucesso");
                Console.ReadKey();
            }
        }

        public void Search()
        {
            StringComparer realizarBusca = StringComparer.CurrentCultureIgnoreCase;
            Jogo aux = Top;
            if (Vazio())
            {
                Console.WriteLine("Essa pilha não contém nenhum jogo!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Por qual jogo deseja buscar: ");
                string buscarJogo = Console.ReadLine();
                do
                {
                    if (realizarBusca.Compare(buscarJogo, aux.Titulo) == 0)
                    {
                        Console.WriteLine("----- Buscando um jogo na pilha -----");
                        Console.WriteLine(aux.ToString());
                        Console.ReadKey();
                    }
                    aux = aux.Anterior;
                } while (aux != null);
            }
        }

        public bool Vazio()
        {
            if (Top == null)
                return true;
            else
                return false;
        }
    }
}
