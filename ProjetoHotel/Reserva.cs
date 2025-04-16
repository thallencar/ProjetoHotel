namespace ProjetoHotel
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public Hospede Hospede { get; set; }
        public Suite Suite { get; set; }
        public DateOnly CheckIn { get; set; }
        public DateOnly CheckOut { get; set; }
        public decimal PrecoTotalReserva { get; set; }

        public Reserva()
        {

        }

        public Reserva(int idReserva, Hospede hospede, Suite suite, DateOnly checkIn, DateOnly checkOut)
        {
            IdReserva = idReserva;
            Hospede = hospede;
            Suite = suite;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}