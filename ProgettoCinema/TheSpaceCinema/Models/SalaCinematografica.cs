namespace TheSpaceCinema.Model
{
    public class SalaCinematografica
    {
        private int idSalaCinematografica;
        private string nomeSalaCinematografica;
        private int capienza;

        public int IdSalaCinematografica
        {
            get { return idSalaCinematografica; }
            set { idSalaCinematografica = value; }
        }

        public string NomeSalaCinematografica
        {
            get { return nomeSalaCinematografica; }
            set { nomeSalaCinematografica = value; }
        }

        public int Capienza
        {
            get { return capienza; }
            set { capienza = value; }
        }

        public SalaCinematografica(int idSalaCinematografica, string nomeSalaCinematografica, int capienza)
        {
            IdSalaCinematografica = idSalaCinematografica;
            NomeSalaCinematografica = nomeSalaCinematografica;
            Capienza = capienza;
        }

        public SalaCinematografica()
        {
        }
    }
}
