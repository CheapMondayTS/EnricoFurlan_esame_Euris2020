namespace TheSpaceCinema.Model
{
    public class Cinema
    {
        private int idCinema;
        private string nomeCinema;

        public int IdCinema
        {
            get { return idCinema; }
            set { idCinema = value; }
        }

        public string NomeCinema
        {
            get { return nomeCinema; }
            set { nomeCinema = value; }
        }

        public Cinema(int idCinema, string nomeCinema)
        {
            IdCinema = idCinema;
            NomeCinema = nomeCinema;
        }
    }
}
