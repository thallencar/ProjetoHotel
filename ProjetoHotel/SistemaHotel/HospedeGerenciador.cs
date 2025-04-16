using System.Text.RegularExpressions;

namespace ProjetoHotel.SistemaHotel
{
    public class HospedeGerenciador
    {
        private readonly List<Hospede> hospedes = new();
        public void CadastrarHospede()
        {
            Console.WriteLine("CADASTRO DE HÓSPEDES");

            string cpf = ValidarCpf();

            string rg = ValidarRg();

            Console.Write("NOME COMPLETO: ");
            string nome = Console.ReadLine();

            Console.Write("TELEFONE: ");
            string telefone = Console.ReadLine();

            string email = ValidarEmail();

            Console.Write("DATA DE NASCIMENTO: ");
            DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());

            Console.Write("GÊNERO (M/F): ");
            char genero = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("LOGRADOURO: ");
            string logradouro = Console.ReadLine();

            Console.Write("PROFISSÃO: ");
            string profissao = Console.ReadLine();

            Console.WriteLine(" ");

            Hospede novoHospede = new (cpf, rg, nome, telefone, email, dataNascimento, genero, logradouro, profissao);
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
                    Console.WriteLine(@$"DADOS DE SR(A) {ExibirSobrenome(hospede)}:
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
                    return;
                }
            }
            Console.WriteLine("Cadastro não encontrado.");
        }

        public void HospedeConsulta()
        {
            if (hospedes != null)
            {
                foreach (var hospede in hospedes)
                {
                    Console.Write(@$"DADOS DE SR(A) {ExibirSobrenome(hospede)}:
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
            else Console.WriteLine("Não há hospedes listados!");

        }

        private static string ValidarCpf()
        {
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            string cpfRegex = @"^(\d{3}\.\d{3}\.\d{3}-\d{2}|\d{11})$";

            while (!Regex.IsMatch(cpf, cpfRegex))
            {
                Console.WriteLine("O número do CPF deve conter 11 dígitos.");
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
            }

            return cpf;
        }

        private static string ValidarRg()
        {
            Console.Write("RG: ");
            string rg = Console.ReadLine();

            string rgRegex = @"^(\d{2}\.\d{3}\.\d{3}[-]?[0-9Xx]|\d{9})$";

            while (!Regex.IsMatch(rg, rgRegex))
            {
                Console.WriteLine("O número do RG deve conter 9 dígitos.");
                Console.Write("RG: ");
                rg = Console.ReadLine();
            }

            return rg;
        }

        private static string ValidarEmail()
        {
            Console.Write("E-MAIL: ");
            string email = Console.ReadLine();

            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            while (!Regex.IsMatch(email, emailRegex))
            {
                Console.WriteLine("Formato de email inválido. Tente novamente.");
                Console.Write("E-MAIL: ");
                email = Console.ReadLine();
            }

            return email;
        }

        /*
        private bool ValidarDataNascimento()
        {
            Console.Write("DATA DE NASCIMENTO: ");
            DataNascimento = DateOnly.Parse(Console.ReadLine());

            string birthDateRegex = @"^\d{2}/\d{2}/\d{4}$";
            while (!Regex.IsMatch(DataNascimento.ToString(), birthDateRegex))
            {
                Console.WriteLine("Formato de data inválida! Tente novamente.");
                Console.Write("DATA DE NASCIMENTO: ");
                DataNascimento = DateOnly.Parse(Console.ReadLine());
            }

            return true;
        }
        */

        private static string ExibirSobrenome(Hospede hospede)
        {
            string[] nomes = hospede.Nome.Split(' ');

            string primeiroNome = nomes[0];
            string ultimoNome = nomes[nomes.Length - 1];

            return $"{ultimoNome.ToUpper()}, {primeiroNome}";
        }

        public Hospede BuscarHospedePorCpf(string cpf)
        {
            return hospedes.FirstOrDefault(hospede => hospede.Cpf == cpf);
        }
    }
}