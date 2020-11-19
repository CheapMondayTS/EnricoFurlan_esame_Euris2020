using System;

namespace TheSpaceCinema.Model
{
    class Spettatore
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
    }
}
