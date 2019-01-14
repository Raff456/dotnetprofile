using Microsoft.AspNetCore.Mvc;


namespace netcoremain.Controllers
{
    
    
    public class OtherController : Controller
    {
        
        public ActionResult SideBar()
        {
            return View();
        }
        
        public ActionResult FourOhFour()
        {
            return View();
        }
    }
}
