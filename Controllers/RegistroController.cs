using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace SalesWebMvc.Controllers
{
    public class RegistroController : Controller
    {
 
        private readonly RegistroService _registroService;
        public RegistroController(RegistroService registroService)
        {
            _registroService = registroService;
        }

        public IActionResult Index()
        {
            //List<Registro> List = new List<Registro>();
            //List.Add(new Registro { });
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registro registro)
        {
            _registroService.Insert(registro);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
