using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class UsuarioService
    {
        private readonly SalesWebMvcContext _context;
        public UsuarioService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Registro> FindAll()
        {
            return _context.Registro.ToList();
        }
    }
}
