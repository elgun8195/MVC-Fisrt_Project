using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        
        
        public IActionResult Index(string search)
        {
            Product pro1 = new Product()
            {
                Descript = "SuperCar",
                Name = "BMW",
                Price = 100,
                Image = "https://imgd.aeplcdn.com/0x0/n/cw/ec/46994/jaguar-f-type-right-front-three-quarter18.jpeg"
            };
            Product pro2 = new Product()
            {
                Descript = "SuperCar",
                Name = "Lamborghini",
                Price = 200,
                Image= "https://stimg.cardekho.com/images/carexteriorimages/930x620/Lamborghini/Aventador/6721/Lamborghini-Aventador-SVJ/1621849426405/front-left-side-47.jpg?tr=w-375"
            }; Product pro3 = new Product()
            {
                Descript = "SuperCar",
                Name = "Lamborghini",
                Price = 300,
                Image= "https://stimg.cardekho.com/images/carexteriorimages/930x620/Lamborghini/Aventador/6721/Lamborghini-Aventador-SVJ/1621849426405/front-left-side-47.jpg?tr=w-375"
            };
            List<Product> list = new List<Product>()
            {
                pro1, pro2, pro3
            };


            if (!string.IsNullOrWhiteSpace(search))
            {
               list = list.FindAll(c=> c.Name.ToLower().Contains(search));
                if (list.Count==0)
                {
                    return NotFound();
                }
            }
            return View(list);
        }
    }
}
