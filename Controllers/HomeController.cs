using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * 3. В этом же проекте (который создан по шаблону Empty Project),
 * добавьте папку с Controllers и класс HomeController
добавьте туда метод Index с возвращаемым типом string. 
(пока что результат этого метода будет возвращаться прямо на страницу браузера, View создавать не нужно)
Попробуйте вызвать метод по адресу https://localhost:{port}/Home/Index, где port - это порт на котором работает ваше приложение.   44318 54599
 */
namespace IntroductionHomeworkKukhar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> loggerr)
        {
            _logger = loggerr;
                
        }
       // public IActionResult Index()
       // {
       //     return View();
     //   }

         //GET:  /Home/Index/
        public string Index()
        {
            return "foolback my bag";
            //return View("MVC");
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
