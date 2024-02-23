namespace ProjetoHotel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hospede hospede = new Hospede();
            List<Hospede> hospedes = new List<Hospede>();
            Suite suite = new Suite();
            List<Suite> suites = new List<Suite>();
            Reserva reserva = new Reserva();
            List<Reserva> reservas = new List<Reserva>();

            while (true)
            {
                Console.WriteLine(@"MENU HOTEL
1 - CADASTRAR
2 - CONSULTAR
3 - LISTAR

0 - SAIR");
                Console.WriteLine("Escolha uma opção: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        return;
                    case 1:
                        Console.WriteLine(@"SUBMENU CADASTRO: 
1 - HOSPÉDE
2 - SUÍTE
3 - RESERVA");
                        int opcaoCadastro = int.Parse(Console.ReadLine());
                        switch (opcaoCadastro)
                        {
                            case 1:
                                hospede.CadastrarHospede();
                                break;
                            case 2:
                                suite.CadastrarSuite();
                                break;
                            case 3:
                                reserva.CadastrarReserva();
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine(@"SUBMENU CONSULTA: 
1 - HOSPÉDE
2 - SUÍTE
3 - RESERVA");
                        int opcaoConsulta = int.Parse(Console.ReadLine());
                        switch (opcaoConsulta)
                        {
                            case 1:
                                hospede.HospedeConsultaIndividual();
                                break;
                            case 2:
                                suite.SuiteConsultaIndividual();
                                break;
                            case 3:
                                reserva.ReservaConsultaIndividual();
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(@"SUBMENU LISTA: 
1 - HOSPÉDE
2 - SUÍTE
3 - RESERVA");
                        int opcaoLista = int.Parse(Console.ReadLine());
                        switch (opcaoLista)
                        {
                            case 1:
                                hospede.HospedeConsulta();
                                break;
                            case 2:
                                suite.SuiteConsulta();
                                break;
                            case 3:
                                reserva.ReservaConsulta();
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                        break;
                }

            }
        Console.WriteLine("Pressione qualquer tecla para sair...");
        string op = Console.ReadLine();
        }
    }
}