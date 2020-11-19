namespace TheSpaceCinema.Model
{
    class Biglietto
    {
        private int idBiglietto;
        private int numeroPosto;
        private string fila;

        public int IdBiglietto
        {
            get { return idBiglietto; }
            set { idBiglietto = value; }
        }

        public int NumeroPosto
        {
            get { return numeroPosto; }
            set { numeroPosto = value; }
        }

        public string Fila
        {
            get { return fila; }
            set { fila = value; }
        }
    }
}
