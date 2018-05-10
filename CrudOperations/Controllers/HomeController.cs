using App.Services;
using System.Web.Mvc;

namespace CrudOperations.Controllers
{
    public class HomeController : Controller
    {
        private IAppService _serv;

        public HomeController(IAppService serv)
        {
            _serv = serv;
        }
        public ActionResult Index()
        {

            var tbl = _serv.GetAll();
           

            return View();
        }


    }
}