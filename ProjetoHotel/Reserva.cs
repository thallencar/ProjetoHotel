namespace ProjetoHotel
{
    public class Reserva
    {
        public int NumeroReserva { get; set; }
        public Hospede Hospede { get; set; }
        public Suite Suite { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva(int numeroReserva, Hospede hospede, Suite suite, DateTime checkIn, DateTime checkOut)
        {
            NumeroReserva = numeroReserva;
            Hospede = hospede;
            Suite = suite;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public Reserva()
        {
            
        }

        List<Reserva> reservas = new List<Reserva>();
        

        public decimal DescontoDiaria(decimal desconto)
        {
            int checkIn = CheckIn.Day;
            int checkOut = CheckOut.Day;

            int diasEstadia = checkOut - checkIn;
            decimal precoTotalEstadia = Suite.ValorDiaria * diasEstadia;


            if(diasEstadia > 10)
            {
                desconto = diasEstadia * 0.10m;
            }

            return precoTotalEstadia - desconto;

        }

        public void CadastrarReserva()
        {
            Hospede hospede = new Hospede();
            Suite suite = new Suite();

            Console.WriteLine("CADASTRO DE RESERVA\nCPF DO HÓSPEDE: ");
            hospede.Cpf = Console.ReadLine();

            Console.WriteLine("NÚMERO DO QUARTO: ");
            suite.NumeroQuarto = int.Parse(Console.ReadLine());

            Console.WriteLine("CHECK-IN (DD/MM/AA 00:00:00): ");
            CheckIn = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("CHECK-OUT: (DD/MM/AA 00:00:00)");
            CheckOut = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int proximoNumeroReserva = 1;
            NumeroReserva = proximoNumeroReserva++;

            Reserva novaReserva = new Reserva(NumeroReserva, hospede, suite, CheckIn, CheckOut);
            reservas.Add(novaReserva);
        }


    public void ReservaConsultaIndividual()
        {

            Console.WriteLine("Digite o número da reserva: ");
            int buscarReserva = int.Parse(Console.ReadLine());

            foreach (var reserva in reservas)
            {
                if (buscarReserva == reserva.NumeroReserva)
                {
                    Console.WriteLine(@$"DADOS DA RESERVA Nº {reserva.NumeroReserva}:
HÓSPEDE: {reserva.Hospede.Nome}
CHECK-IN: {reserva.CheckIn}
CHECK-OUT: {reserva.CheckOut}
VALOR DA DIÁRIA: R${reserva.Suite.ValorDiaria}
CAPACIDADE DO QUARTO: {reserva.Suite.Capacidade} PESSOAS
NÚMERO DE CAMAS: {reserva.Suite.NumBanheiros}
NÚMERO DE BANHEIROS: {reserva.Suite.NumBanheiros}
");


                    Console.WriteLine(" ");
                    return;
                }
                else{
                    Console.WriteLine("Reserva não encontrada.");
                }
            }

        }

        public void ReservaConsulta()
        {
            Hospede hospede = new Hospede();
            Suite suite = new Suite();

            foreach (var reserva in reservas)
            {
                Console.WriteLine(@$"DADOS DA RESERVA Nº {reserva.NumeroReserva}:
HÓSPEDE: {reserva.Hospede.Nome}
CHECK-IN: {reserva.CheckIn}
CHECK-OUT: {reserva.CheckOut}
VALOR DA DIÁRIA: R${reserva.Suite.ValorDiaria}
CAPACIDADE DO QUARTO: {reserva.Suite.Capacidade} PESSOAS
NÚMERO DE CAMAS: {reserva.Suite.NumBanheiros}
NÚMERO DE BANHEIROS: {reserva.Suite.NumBanheiros}
");

                Console.WriteLine(" ");

            }
        }


    }
}
