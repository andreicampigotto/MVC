using ExemploMVC_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC_01.Controllers
{
    public class BalaoController : Controller
    {
        // GET: Balao
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Store(Balao balao)
        {
            return View();
        }
    }
}