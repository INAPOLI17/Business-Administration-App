using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public class DATOSFACTURA
    {
        public int ID { get; set; }
        public string NAMECLIENTE { get; set; }
        public int IDCLIENTE { get; set; }
        public int PAGONETO { get; set; }
        public DateTime DATE = Convert.ToDateTime(DateTime.Today.ToShortDateString());

        public int PRECIOVENTA { get; set; }
        public string DIRECCION { get; set; }
        public string ESTADO { get; set; }
        public int TOTAL { get; set; }
        public int DESCUENTO { get; set; }
        public string TIPOFACTURA { get; set; }
    }
}
