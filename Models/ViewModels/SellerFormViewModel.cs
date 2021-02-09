using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Registro Registro { get; set; }
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
