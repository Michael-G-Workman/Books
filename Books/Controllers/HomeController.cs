using System.Web.Mvc;

namespace Books.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Books Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Info";

            return View();
        }

        public ActionResult License()
        {
            ViewBag.Message = "License Info";

            return View();
        }
    }
}