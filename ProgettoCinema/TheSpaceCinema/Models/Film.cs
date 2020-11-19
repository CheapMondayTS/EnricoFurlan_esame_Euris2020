namespace TheSpaceCinema.Model
{
    public class Film
    {
        private int idFilm;
        private string titoloFilm;
        private string autore;
        private string produttore;
        private string genere;
        private int durata;

        public int IdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public string TitoloFilm
        {
            get { return titoloFilm; }
            set { titoloFilm = value; }
        }

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

        public string Produttore
        {
            get { return produttore; }
            set { produttore = value; }
        }

        public string Genere
        {
            get { return genere; }
            set { genere = value; }
        }

        public int Durata
        {
            get { return durata; }
            set { durata = value; }
        }

        public Film(int idFilm, string titoloFilm, string autore, string produttore, string genere, int durata)
        {
            IdFilm = idFilm;
            TitoloFilm = titoloFilm;
            Autore = autore;
            Produttore = produttore;
            Genere = genere;
            Durata = durata;
        }
    }
}
