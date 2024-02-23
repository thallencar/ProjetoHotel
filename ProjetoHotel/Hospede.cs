namespace ProjetoHotel
{
    public class Hospede
    {
        public long Cpf{ get; set; }
        public int Rg {  get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string Logradouro { get; set; }
        public string Profissao { get; set; }

        public Hospede(long cpf, int rg, string nome, string sobrenome, long telefone, string email, int idade, char genero, string logradouro, string profissao)
        {
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
            Idade = idade;
            Genero = genero;
            Logradouro = logradouro;
            Profissao = profissao;
        }

        public Hospede()
        {
            
        }

        List<Hospede> hospedes = new List<Hospede>();
        public void CadastrarHospede()
        {
            Console.WriteLine("CADASTRO DE HÓSPEDES\nCPF (Apenas números):");
            Cpf = long.Parse(Console.ReadLine());
            Console.WriteLine("RG (Apenas números): ");
            Rg = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("NOME: ");
            Nome = Console.ReadLine();
            Console.WriteLine("SOBRENOME: ");
            Sobrenome = Console.ReadLine();
            Console.WriteLine("TELEFONE (Apenas números): ");
            Telefone = long.Parse(Console.ReadLine());
            Console.WriteLine("E-MAIL: ");
            Email = Console.ReadLine();
            Console.WriteLine("IDADE: ");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("GÊNERO (M/F): ");
            Genero = char.Parse(Console.ReadLine().ToUpper());    
            Console.WriteLine("LOGRADOURO: ");
            Logradouro = Console.ReadLine();
            Console.WriteLine("PROFISSÃO: ");
            Profissao = Console.ReadLine();
            Console.WriteLine(" ");

            Hospede novoHospede = new Hospede(Cpf, Rg, Nome, Sobrenome, Telefone, Email, Idade, Genero, Logradouro, Profissao);
            hospedes.Add(novoHospede);
        }

        public void HospedeConsultaIndividual()
        {
            Console.WriteLine("Digite o CPF do hóspede (Apenas números): ");
            long buscarCpf = long.Parse(Console.ReadLine());

            foreach (var hospede in hospedes)
            {
                if (buscarCpf == hospede.Cpf) {
                    Console.WriteLine(@$"DADOS DE SR(A) {hospede.Sobrenome.ToUpper()}, {hospede.Nome}:
CPF: {hospede.Cpf}
RG: {hospede.Rg}
TELEFONE: {hospede.Telefone}
E-MAIL:{hospede.Email}
IDADE: {hospede.Idade}
GÊNERO: {hospede.Genero}
LOGRADOURO: {hospede.Logradouro}
PROFISSÃO: {hospede.Profissao}
");
                    Console.WriteLine(" ");
                    return;
                }
                else
                {
                    Console.WriteLine("Cadastro não encontrado.");
                }
            }   

        }

        public void HospedeConsulta()
        {
            foreach (var hospede in hospedes)
            {
                Console.WriteLine(@$"DADOS DE SR(A) {hospede.Sobrenome.ToUpper()}, {hospede.Nome}:
CPF: {hospede.Cpf}
RG: {hospede.Rg}
TELEFONE: {hospede.Telefone}
E-MAIL:{hospede.Email}
IDADE: {hospede.Idade}
GÊNERO: {hospede.Genero}
LOGRADOURO: {hospede.Logradouro}
PROFISSÃO: {hospede.Profissao}
");
                Console.WriteLine(" ");

            }
        }

    }
}
