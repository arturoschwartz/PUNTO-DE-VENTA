using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_de_venta.Clases
{
    internal class conexion
    {
        public string conn()
        {
            string miconexion = ("Data Source=DESKTOP-JMGB3LE;Initial Catalog=pventa;Integrated Security=True");
            return miconexion;
        }
    }
}
