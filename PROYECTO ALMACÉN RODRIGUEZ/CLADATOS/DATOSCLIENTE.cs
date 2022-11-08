using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public class DATOSCLIENTE
    {
        public int ID { get; set; }
        public string NAMECLIENTE { get; set; }

        public string APELLIDO { get; set; }

        public DateTime FECHA = Convert.ToDateTime(DateTime.Today.ToShortDateString());

        public string TELEFONO { get; set; }

        public string DIRECCION { get; set; }

    }
}
