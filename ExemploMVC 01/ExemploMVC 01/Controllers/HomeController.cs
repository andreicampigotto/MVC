using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //
            ViewBag.Nome = "Andrei";
            ViewBag.Idade = 23;
            return View();
        }
        public ActionResult Calculadora() 
        {

            return View();
        }
        public ActionResult Calcular (int numero01, int numero02)
        {
            int soma = numero01 + numero02;
            ViewBag.Soma = soma;
            ViewBag.Numero01 = numero01;
            ViewBag.Numero02 = numero02;
            return View();
        }
    }
}