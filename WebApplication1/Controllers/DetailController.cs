using First_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace First_Application.Controllers
{
    public class DetailController : Controller
    {

        public IActionResult Index(int id)
        {
            List<Detail> prodetails = new List<Detail>()
            {
                new Detail()
                {
                    Pid=1,
                    Model="Bmw M8",
                    Year="2002",
                    Motor="5.5l"
                },new Detail()
                {
                    Pid=2,
                    Model="Lamborghini SVJ",
                    Year="2021",
                    Motor="6.3;"
                },new Detail()
                {
                    Pid=3,
                    Model="Lamborghini Avendator",
                    Year="2012",
                    Motor="4.4l"
                }
            };
            var mydetail = prodetails.FirstOrDefault(p => p.Pid == id);
            return View(mydetail);
        }
    }
}
