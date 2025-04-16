using ProjetoHotel.Enums;

namespace ProjetoHotel
{
    public class Suite
    {
        public int NumeroQuarto { get; set; }
        public decimal ValorDiaria { get; set; }
        public TipoSuite TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public int NumBanheiros { get; set; }
        public int NumCamas { get; set; }

        public Suite()
        {

        }

        public Suite(int numeroQuarto, decimal valorDiaria, TipoSuite tipoSuite, int capacidade, int numBanheiros, int numCamas)
        {
            NumeroQuarto = numeroQuarto;
            ValorDiaria = valorDiaria;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            NumBanheiros = numBanheiros;
            NumCamas = numCamas;
        }   
    }
}