using Microsoft.AspNetCore.Mvc;

namespace netcoremain.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}