using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.Web.Models
{
    public class FilmView
    {
        private int idFilm;
        private string titoloFilm;
        private string autore;
        private string produttore;
        private string genere;
        private int durata;

        [Display(Name = "Codice del Film")]
        public int IdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        [Display(Name = "Titolo del Film")]
        public string TitoloFilm
        {
            get { return titoloFilm; }
            set { titoloFilm = value; }
        }

        [Display(Name = "Regista")]
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

        public FilmView(Film film)
        {
            IdFilm = film.IdFilm;
            TitoloFilm = film.TitoloFilm;
            Autore = film.Autore;
            Produttore = film.Produttore;
            Genere = film.Genere;
            Durata = film.Durata;
        }
    }
}