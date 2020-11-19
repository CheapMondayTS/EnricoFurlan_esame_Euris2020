using System.ComponentModel.DataAnnotations;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.Web.Models
{
    public class CinemaView
    {
        private int idCinema;
        private string nomeCinema;

        [Display(Name = "Codice Cinema")]
        public int IdCinema
        {
            get { return idCinema; }
            set { idCinema = value; }
        }

        [Display(Name = "Nome del Cinema")]
        public string NomeCinema
        {
            get { return nomeCinema; }
            set { nomeCinema = value; }
        }

        public CinemaView(Cinema cinema)
        {
            IdCinema = cinema.IdCinema;
            NomeCinema = cinema.NomeCinema;
        }
    }
}