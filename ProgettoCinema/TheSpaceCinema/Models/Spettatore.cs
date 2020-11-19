using System;

namespace TheSpaceCinema.Model
{
    public class Spettatore
    {
        private int idSpettatore;
        private string nomeSpettatore;
        private string cognomeSpettatore;
        private DateTime dataNascita;

        public int IdSpettatore
        {
            get { return idSpettatore; }
            set { idSpettatore = value; }
        }

        public string NomeSpettatore
        {
            get { return nomeSpettatore; }
            set { nomeSpettatore = value; }
        }

        public string CognomeSpettatore
        {
            get { return cognomeSpettatore; }
            set { cognomeSpettatore = value; }
        }

        public DateTime DataNascita
        {
            get { return dataNascita; }
            set { dataNascita = value; }
        }


        private static int CalcoloAnni(DateTime dataNascita)
        {
            int anni = 0;
            anni = DateTime.Now.Year - dataNascita.Year;
            if (DateTime.Now.DayOfYear < dataNascita.DayOfYear)
                anni = anni - 1;

            return anni;
        }

        public int Anni { get; set; }

        public Spettatore(int idSpettatore, string nomeSpettatore, string cognomeSpettatore, DateTime dataNascita)
        {
            IdSpettatore = idSpettatore;
            NomeSpettatore = nomeSpettatore;
            CognomeSpettatore = cognomeSpettatore;
            DataNascita = dataNascita; 
        }
    }
}
