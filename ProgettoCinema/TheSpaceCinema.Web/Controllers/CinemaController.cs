using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using TheSpaceCinema.SqlProvider;
using TheSpaceCinema.Web.Models;

namespace TheSpaceCinema.Web.Controllers
{
    public class CinemaController : Controller
    {
        private CinemaSqlProvider _cinemaSqlProvider;

        public CinemaController()
        {
            _cinemaSqlProvider = new CinemaSqlProvider(ConfigurationManager.ConnectionStrings["_connectionString"].ConnectionString);
        }

        public ActionResult Index()
        {
            var cinemaList = _cinemaSqlProvider.GetAll().Select(c => new CinemaView(c));
            return View(cinemaList);
        }
    }
}
