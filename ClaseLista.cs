using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class ClaseLista
    {
   
       
        public List<Empleado> myStruct = new List<Empleado>();
       

        public struct Empleado
        {
            public string Ticket { get; set; }
            public string Nombre { get; set; }
            public string Producto { get; set; }
            public string Fecha { get; set; }
        }
    }
}
