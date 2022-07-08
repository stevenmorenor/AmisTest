using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion
{
    public class BaseEntity
    {
        public string CreateBy { get; set; }
        public string EditBy { get; set; }
        public DateTime DateModified { get; set; }
        public bool ErasedLogical { get; set; }

        public override string ToString()
        {
            return "Creado por: " + CreateBy + " Editado por: " + EditBy + " Fecha de modificaion " + DateModified+ " Borrado logico " + ErasedLogical;
        }
    }
}
