using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using TheSpaceCinema.SqlProvider;
using TheSpaceCinema.Web.Models;

namespace TheSpaceCinema.Web.Controllers
{
    public class SalaCinematograficaController : Controller
    {
        private SalaCinematograficaSqlProvider _salaCinematograficaSqlProvider;

        public SalaCinematograficaController()
        {
            _salaCinematograficaSqlProvider = new SalaCinematograficaSqlProvider(ConfigurationManager.ConnectionStrings["_connectionString"].ConnectionString);
        }

        public ActionResult Index()
        {
            var saleProiezioneList = _salaCinematograficaSqlProvider.GetAll().Select(s => new SalaCinematograficaView(s));
            return View(saleProiezioneList);

        }
    }
}
