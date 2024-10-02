using System.Text.RegularExpressions;

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

        public Hospede()
        {

        }

        private readonly List<Hospede> hospedes = new List<Hospede>();
        public void CadastrarHospede()
        {
            Console.WriteLine("CADASTRO DE HÓSPEDES");

            ValidarDocumentos();

            Console.Write("NOME COMPLETO: ");
            Nome = Console.ReadLine();

            Console.Write("TELEFONE: ");
            Telefone = Console.ReadLine();

            ValidarEmail();

            Console.Write("DATA DE NASCIMENTO: ");
            DataNascimento = DateOnly.Parse(Console.ReadLine());

            Console.Write("GÊNERO (M/F): ");
            Genero = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("LOGRADOURO: ");
            Logradouro = Console.ReadLine();

            Console.Write("PROFISSÃO: ");
            Profissao = Console.ReadLine();

            Console.WriteLine(" ");

            Hospede novoHospede = new Hospede(Cpf, Rg, Nome, Telefone, Email, DataNascimento, Genero, Logradouro, Profissao);
            hospedes.Add(novoHospede);
        }

        public void HospedeConsultaIndividual()
        {
            Console.Write("Digite o CPF do hóspede: ");
            string buscarCpf = Console.ReadLine();

            foreach (var hospede in hospedes)
            {
                if (buscarCpf == hospede.Cpf)
                {
                    Console.WriteLine(@$"DADOS DE SR(A) {hospede.ExibirSobrenome()}:
CPF: {hospede.Cpf}
RG: {hospede.Rg}
TELEFONE: {hospede.Telefone}
E-MAIL:{hospede.Email}
DATA DE NASCIMENTO: {hospede.DataNascimento}
GÊNERO: {hospede.Genero}
LOGRADOURO: {hospede.Logradouro}
PROFISSÃO: {hospede.Profissao}
");
                    Console.WriteLine(" ");
                }
                else Console.WriteLine("Cadastro não encontrado.");
            }

        }

        public void HospedeConsulta()
        {
            foreach (var hospede in hospedes)
            {
                Console.Write(@$"DADOS DE SR(A) {hospede.ExibirSobrenome()}:
CPF: {hospede.Cpf}
RG: {hospede.Rg}
TELEFONE: {hospede.Telefone}
E-MAIL:{hospede.Email}
DATA DE NASCIMENTO: {hospede.DataNascimento}
GÊNERO: {hospede.Genero}
LOGRADOURO: {hospede.Logradouro}
PROFISSÃO: {hospede.Profissao}
");
                Console.WriteLine("");
                Console.WriteLine("");

            }
        }

        public bool ValidarDocumentos()
        {
            Console.Write("CPF: ");
            Cpf = Console.ReadLine();

            string cpfRegex = @"^(\d{3}\.\d{3}\.\d{3}-\d{2}|\d{11})$";
            while (!Regex.IsMatch(Cpf, cpfRegex))
            {
                Console.WriteLine("O número do CPF deve conter 11 dígitos.");
                Console.Write("CPF: ");
                Cpf = Console.ReadLine();
            }

            Console.Write("RG: ");
            Rg = Console.ReadLine();

            string rgRegex = @"^(\d{2}\.\d{3}\.\d{3}[-]?[0-9Xx]|\d{9})$";

            while (!Regex.IsMatch(Rg, rgRegex))
            {
                Console.WriteLine("O número do RG deve conter 9 dígitos.");
                Console.Write("RG: ");
                Rg = Console.ReadLine();
            }

            return true;
        }

        public bool ValidarEmail()
        {
            Console.Write("E-MAIL: ");
            Email = Console.ReadLine();

            string emailRegex = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,}$";

            while (!Regex.IsMatch(Email, emailRegex))
            {
                Console.WriteLine("Formato de email inválido. Tente novamente.");
                Console.Write("E-MAIL: ");
                Email = Console.ReadLine();
            }
            return true;
        }

        public string ExibirSobrenome()
        {
            string[] nomes = Nome.Split(' ');

            string primeiroNome = nomes[0];
            string ultimoNome = nomes[nomes.Length - 1];

            return $"{ultimoNome.ToUpper()}, {primeiroNome}";
        }
    }
}
