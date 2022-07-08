using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion
{
    public static class Extensions
    {
        public static string ToCorrectFormat(this DateTime str)
        {
           return str.ToString("yyyy/MM/dd");
        }
    }
}
