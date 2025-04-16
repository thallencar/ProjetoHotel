namespace ProjetoHotel
{
    public class Hospede
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }
        public char Genero { get; set; }
        public string Logradouro { get; set; }
        public string Profissao { get; set; }

        public Hospede()
        {

        }

        public Hospede(string cpf, string rg, string nome, string telefone, string email, DateOnly dataNascimento, char genero, string logradouro, string profissao)
        {
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            Genero = genero;
            Logradouro = logradouro;
            Profissao = profissao;
        }
    }
}