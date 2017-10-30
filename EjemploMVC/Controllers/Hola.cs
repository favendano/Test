using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EjemploMVC.Controllers
{
    public class Hola : Controller
    {
        // GET: /Hola/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Hola/Bienvenidos
        public IActionResult Bienvenidos(string nombre, int cantidad = 1)
        {
            ViewData["Mensaje"] = "Hola " + nombre;
            ViewData["Veces"] = cantidad;

            return View();
        }
    }
}
