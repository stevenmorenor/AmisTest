using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion
{
    public class Product : BaseEntity
    {
        private int _price;
        private string _name;
        private string _description;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string ToString()
        {
            return "El producto " + _name + " Tiene un valor de: " + _price + " Y su descripcion es: " + _description;
        }



    }
}
