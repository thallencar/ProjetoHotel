namespace ProjetoHotel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hospede hospede = new Hospede();
            Suite suite = new Suite();
            Reserva reserva = new Reserva();

            while (true)
            {
                Console.WriteLine(@"MENU HOTEL
1 - CADASTRAR
2 - CONSULTAR
3 - LISTAR

0 - SAIR");
                Console.Write("\nEscolha uma opção: ");
                int option = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        return;
                    case 1:
                        Console.WriteLine(@"SUBMENU CADASTRO: 
1 - HOSPÉDE
2 - SUÍTE
3 - RESERVA");
                        Console.Write("\nEscolha uma opção: ");
                        int opcaoCadastro = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcaoCadastro)
                        {
                            case 1:
                                hospede.CadastrarHospede();
                                Console.Clear();
                                break;
                            case 2:
                                suite.CadastrarSuite();
                                Console.Clear();
                                break;
                            case 3:
                                reserva.CadastrarReserva();
                                Console.Clear();
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
                        Console.Write("\nEscolha uma opção: ");
                        int opcaoConsulta = int.Parse(Console.ReadLine());
                        Console.Clear();

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
                        Console.Write("\nEscolha uma opção: ");
                        int opcaoLista = int.Parse(Console.ReadLine());
                        Console.Clear();

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
        }
    }
}