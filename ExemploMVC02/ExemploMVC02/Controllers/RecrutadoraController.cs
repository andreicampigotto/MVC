using ExemploMVC02.Models;
using ExemploMVC02.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepositorio().ObterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            ViewBag.TituloPagina = "Recrutadoras";
            return View();
        }
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Recrutadoras - Cadastro";        
            return View();
        }
        public ActionResult Editar()
        {
            Recrutadora recrutadora = new RecrutadoraRepositorio().ObterPeloID(id);
            ViewBag.Recrutadora = recrutadora;
            return View();
        }
        public ActionResult Excluir()
        {

            return View();
        }

    }
}