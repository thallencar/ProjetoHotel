namespace ProjetoHotel.SistemaHotel
{
    public class ReservaGerenciador
    {
        private readonly List<Reserva> reservas = new();

        private readonly HospedeGerenciador _hospedeGerenciador;
        private readonly SuiteGerenciador _suiteGerenciador;


        public ReservaGerenciador(HospedeGerenciador hospedeGerenciador, SuiteGerenciador suiteGerenciador)
        {
            _hospedeGerenciador = hospedeGerenciador;
            _suiteGerenciador = suiteGerenciador;
        }

        int proximaReserva = 1;

        public void CadastrarReserva()
        {
            Console.Write("CADASTRO DE RESERVA\nCPF DO HÓSPEDE: ");
            string cpf = Console.ReadLine();

            var hospede = _hospedeGerenciador.BuscarHospedePorCpf(cpf);

            if(hospede == null)
            {
                Console.WriteLine("Hóspede não encontrado!");
            }

            Console.Write("NÚMERO DO QUARTO: ");
            int numeroQuarto = int.Parse(Console.ReadLine());

            var suite = _suiteGerenciador.BuscarSuitePorNumero(numeroQuarto);

            if (suite == null)
            {
                Console.WriteLine("Quarto não encontrado!");
            }

            Console.Write("CHECK-IN (DD/MM/AA): ");
            DateOnly checkIn = DateOnly.Parse(Console.ReadLine());

            Console.Write("CHECK-OUT (DD/MM/AA): ");
            DateOnly checkOut = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Reserva novaReserva = new(proximaReserva++, hospede, suite, checkIn, checkOut);

            novaReserva.PrecoTotalReserva = DescontoDiaria(novaReserva);

            reservas.Add(novaReserva);
        }


        public void ReservaConsultaIndividual()
        {

            Console.Write("Digite o número da reserva: ");
            int buscarReserva = int.Parse(Console.ReadLine());

            foreach (var reserva in reservas)
            {
                if (buscarReserva == reserva.IdReserva)
                {
                    Console.WriteLine(@$"DADOS DA RESERVA Nº {reserva.IdReserva}:
HÓSPEDE: {reserva.Hospede.Nome}
CHECK-IN: {reserva.CheckIn}
CHECK-OUT: {reserva.CheckOut}
VALOR DA DIÁRIA: R${reserva.Suite.ValorDiaria}
CAPACIDADE DO QUARTO: {reserva.Suite.Capacidade} PESSOAS
NÚMERO DE CAMAS: {reserva.Suite.NumCamas}
NÚMERO DE BANHEIROS: {reserva.Suite.NumBanheiros}
");
                    Console.WriteLine(" ");
                    return;
                }
            }
            Console.WriteLine("Reserva não encontrada.");
        }

        public void ReservaConsulta()
        {
            foreach (var reserva in reservas)
            {
                Console.WriteLine(@$"DADOS DA RESERVA Nº {reserva.IdReserva}:
HÓSPEDE: {reserva.Hospede.Nome}
CHECK-IN: {reserva.CheckIn}
CHECK-OUT: {reserva.CheckOut}
VALOR DA DIÁRIA: R${reserva.Suite.ValorDiaria}
CAPACIDADE DO QUARTO: {reserva.Suite.Capacidade} PESSOAS
NÚMERO DE CAMAS: {reserva.Suite.NumCamas}
NÚMERO DE BANHEIROS: {reserva.Suite.NumBanheiros}
");
                Console.WriteLine(" ");
            }
        }

        private static decimal DescontoDiaria(Reserva reserva)
        {
            int diasEstadia = (reserva.CheckOut - reserva.CheckIn).Days;
            decimal precoTotalEstadia = reserva.Suite.ValorDiaria * diasEstadia;

            decimal desconto = 0;

            if (diasEstadia > 10) desconto = precoTotalEstadia * 0.10m;

            return precoTotalEstadia - desconto;
        }
    }
}
