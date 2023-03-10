namespace Aula_05
{
    public sealed class Cliente
    {
        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;

        }

        private int Id;
        private string Nome;
        private string Telefone;


        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }
       
        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}