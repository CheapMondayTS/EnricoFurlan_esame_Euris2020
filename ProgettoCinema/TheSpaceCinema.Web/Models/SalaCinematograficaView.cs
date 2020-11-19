using System.ComponentModel.DataAnnotations;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.Web.Models
{
    public class SalaCinematograficaView
    {
        private int idSalaCinematografica;
        private string nomeSalaCinematografica;
        private int capienza;

        [Display(Name = "Codice di Sala")]
        public int IdSalaCinematografica
        {
            get { return idSalaCinematografica; }
            set { idSalaCinematografica = value; }
        }

        [Display(Name = "Numero di Sala")]
        public string NomeSalaCinematografica
        {
            get { return nomeSalaCinematografica; }
            set { nomeSalaCinematografica = value; }
        }

        [Display(Name = "Capienza Massima")]
        public int Capienza
        {
            get { return capienza; }
            set { capienza = value; }
        }

        public SalaCinematograficaView(SalaCinematografica salaCinematografica)
        {
            IdSalaCinematografica = salaCinematografica.IdSalaCinematografica;
            NomeSalaCinematografica = salaCinematografica.NomeSalaCinematografica;
            Capienza = salaCinematografica.Capienza;
        }
    }
}