namespace Aula_05
{
    public sealed class Produto
    {
        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;

        }

        private int Id;
        private decimal Valor;
        private string Descricao;

    }
}