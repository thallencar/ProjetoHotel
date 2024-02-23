using static System.Net.Mime.MediaTypeNames;

namespace ProjetoHotel
{
    public class Suite
    {
        public int NumeroQuarto{ get; set; }
        public decimal ValorDiaria { get; set; }
        public string TipoSuite{ get; set;}
        public int Capacidade { get; set; }
        public int NumBanheiros { get; set; }
        public int NumCamas { get; set; }

        public Suite(int numeroQuarto, decimal valorDiaria, string tipoSuite, int capacidade, int numBanheiros, int numCamas)
        {
            NumeroQuarto = numeroQuarto;
            ValorDiaria = valorDiaria;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            NumBanheiros = numBanheiros;
            NumCamas = numCamas;
        }

        public Suite()
        {
                
        }

        List<Suite> suites = new List<Suite>();

        public void CadastrarSuite()
        {
            Console.WriteLine("CADASTRO DE SUÍTE\nNÚMERO DO QUARTO:");
            NumeroQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("VALOR DA DIÁRIA: ");
            ValorDiaria = decimal.Parse(Console.ReadLine());
            Console.WriteLine("TIPO DA SUÍTE: ");
            TipoSuite = Console.ReadLine();
            Console.WriteLine("CAPACIDADE: ");
            Capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine("NÚMERO DE BANHEIROS: ");
            NumBanheiros = int.Parse(Console.ReadLine());
            Console.WriteLine("NÚMERO DE CAMAS: ");
            NumCamas = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" ");

            Suite novaSuite = new Suite(NumeroQuarto, ValorDiaria, TipoSuite, Capacidade, NumBanheiros, NumCamas);
            suites.Add(novaSuite);
        }

        public void SuiteConsultaIndividual()
        {
            Console.WriteLine("Digite o núemero do quarto: ");
            int buscarQuarto = int.Parse(Console.ReadLine());

            foreach (var suite in suites)
            {
                if (buscarQuarto == suite.NumeroQuarto)
                {
                    Console.WriteLine(@$"DADOS DO QUARTO Nº {suite.NumeroQuarto}
VALOR DA DIÁRIA: R${suite.ValorDiaria}
TIPO DE SUÍTE: {suite.TipoSuite}
CAPACIDADE:{suite.Capacidade} PESSOAS
NÚMERO DE CAMAS: {suite.NumCamas}
NÚMERO DE BANHEIROS: {suite.NumBanheiros}
");
                    Console.WriteLine(" ");
                    return;
                }
                else{
                    Console.WriteLine("Cadastro não encontrado.");
                }
            }

        }

        public void SuiteConsulta()
        {
            foreach (var suite in suites)
            {
                Console.WriteLine(@$"DADOS DO QUARTO Nº {suite.NumeroQuarto}
VALOR DA DIÁRIA: R${suite.ValorDiaria}
TIPO DE SUÍTE: {suite.TipoSuite}
CAPACIDADE:{suite.Capacidade} PESSOAS
NÚMERO DE CAMAS: {suite.NumCamas}
NÚMERO DE BANHEIROS: {suite.NumBanheiros}
");
                Console.WriteLine(" ");

            }
        }
    }
}
