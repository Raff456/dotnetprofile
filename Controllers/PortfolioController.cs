﻿using Microsoft.AspNetCore.Mvc;


namespace netcoremain.Controllers
{
    
    
    public class PortfolioController : Controller
    {
        
        public ActionResult OneColumn()
        {
            return View();
        }
        
        public ActionResult ThreeColumn()
        {
            return View();
        }
        
        public ActionResult SingleItem()
        {
            return View();
        }
    }
}