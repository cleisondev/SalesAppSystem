using Microsoft.AspNetCore.Mvc;
using SalesAppSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SalesAppSystem.Models.ViewModels;

namespace SalesAppSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Este é um Sistema de gerenciamento e consulta de vendas, feito em ASP.Net Core MVC e Mysql. Esse sistema permite a criação de departamentos, novos vendedores, consultas simples por data e consultas agrupando departamentos por data";
            ViewData["author"] = "Autor: Cleison da Silva Nunes";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
