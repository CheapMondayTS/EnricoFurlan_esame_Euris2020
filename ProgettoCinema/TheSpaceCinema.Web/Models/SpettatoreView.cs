using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.Web.Models
{
    public class SpettatoreView
    {
        private int idSpettatore;
        private string nomeSpettatore;
        private string cognomeSpettatore;
        private DateTime dataNascita;

        [Display(Name = "Pass Spettatore")]
        public int IdSpettatore
        {
            get { return idSpettatore; }
            set { idSpettatore = value; }
        }

        [Display(Name = "Nome")]
        public string NomeSpettatore
        {
            get { return nomeSpettatore; }
            set { nomeSpettatore = value; }
        }

        [Display(Name = "Cognome")]
        public string CognomeSpettatore
        {
            get { return cognomeSpettatore; }
            set { cognomeSpettatore = value; }
        }

        [Display(Name = "Età")]
        public DateTime DataNascita
        {
            get { return dataNascita; }
            set { dataNascita = value; }
        }

        public SpettatoreView(Spettatore spettatore)
        {
            IdSpettatore = spettatore.IdSpettatore;
            NomeSpettatore = spettatore.NomeSpettatore;
            CognomeSpettatore = spettatore.CognomeSpettatore;
            DataNascita = spettatore.DataNascita;
        }
    }
}