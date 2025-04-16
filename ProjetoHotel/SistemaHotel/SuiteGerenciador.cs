using ProjetoHotel.Enums;

namespace ProjetoHotel.SistemaHotel
{
    public class SuiteGerenciador
    {
        readonly List<Suite> suites = new();

        public void CadastrarSuite()
        {
            Console.WriteLine("CADASTRO DE DE SUÍTE");

            Console.Write("NÚMERO DO QUARTO: ");
            int numeroQuarto = int.Parse(Console.ReadLine());
            
            Console.Write("VALOR DA DIÁRIA: ");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());

            Console.Write("TIPO DE QUARTO: ");
            TipoSuite tipoSuite = (TipoSuite)int.Parse(Console.ReadLine());

            Console.Write("CAPACIDADE: ");
            int capacidade = int.Parse(Console.ReadLine());

            Console.Write("NÚMERO DE BANHEIROS: ");
            int numBanheiros = int.Parse(Console.ReadLine());

            Console.Write("NÚMERO DE CAMAS: ");
            int numCamas = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Suite novaSuite = new(numeroQuarto,valorDiaria, tipoSuite, capacidade, numBanheiros, numCamas);
            suites.Add(novaSuite);
        }

        public void SuiteConsultaIndividual()
        {
            Console.Write("Digite o número do quarto: ");
            int buscarQuarto = int.Parse(Console.ReadLine());

            foreach (var suite in suites)
            {
                if (buscarQuarto == suite.NumeroQuarto)
                {
                    Console.WriteLine(@$"DADOS DO QUARTO Nº {suite.NumeroQuarto}
VALOR DA DIÁRIA: R${suite.ValorDiaria}
TIPO DE SUÍTE: {suite.TipoSuite}
CAPACIDADE: {suite.Capacidade} PESSOAS 
NÚMERO DE CAMAS: {suite.NumCamas}
NÚMERO DE BANHEIROS: {suite.NumBanheiros}
");
                    Console.WriteLine(" ");
                    return;
                } 
            }
            Console.WriteLine("Cadastro não encontrado.");
        }

        public void SuiteConsulta()
        {
            if (suites != null)
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
            else Console.WriteLine("Não há suítes listadas.");
        }

        public static void ListarSuites()
        {
            Console.Write("SUÍTES: ");

            foreach (var tipo in Enum.GetValues(typeof(TipoSuite)))
            {
                Console.WriteLine($"{(int)tipo} - {tipo}");
            }

            Console.Write("TIPO DA SUÍTE: ");
        }

        public Suite BuscarSuitePorNumero(int numeroQuarto)
        {
            return suites.FirstOrDefault(suite => suite.NumeroQuarto == numeroQuarto);
        }
    }
}
