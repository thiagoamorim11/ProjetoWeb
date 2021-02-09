using SalesWebMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;


namespace SalesWebMvc.Data
{
    public class RegistroService
    {
        private readonly SalesWebMvcContext _context;
        public RegistroService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Insert(Registro obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
