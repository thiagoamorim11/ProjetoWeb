using SalesWebMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc.Services
{
    public class RegistroService
    {
        private readonly SalesWebMvcContext _context;
        public RegistroService(SalesWebMvcContext context)
        {
            _context = context;
        }
    }
}
