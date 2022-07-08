using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string SubCategory { get; set; }


        public override string ToString()
        {
            return "Categoria: " + Name + " Codigo: " + Code + " Subcategoria: " + SubCategory;
        }
    }
    

}
