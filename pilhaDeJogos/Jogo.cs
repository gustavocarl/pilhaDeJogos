namespace pilhaDeJogos
{
    internal class Jogo
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Desenvolvedor { get; set; }
        public string Distribuidora { get; set; }
        public int DataDeLancamento { get; set; }
        public Jogo Anterior { get; set; }


        public Jogo(string titulo, string genero, string desenvolvedor, string distribuidora, int dataDeLancamento)
        {
            Titulo = titulo;
            Genero = genero;
            Desenvolvedor = desenvolvedor;
            Distribuidora = distribuidora;
            DataDeLancamento = dataDeLancamento;
            Anterior = null;
        }

        public override string ToString()
        {
            return "\nTítulo: " + Titulo + "\nGênero: " + Genero +
                "\nDesenvolvedor: " + Desenvolvedor + "\nDistribuidora: " + Distribuidora + "\nData de Lançamento: " + DataDeLancamento;
        }
    }
}